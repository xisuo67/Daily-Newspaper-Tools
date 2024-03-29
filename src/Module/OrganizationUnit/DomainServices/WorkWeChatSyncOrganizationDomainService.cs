﻿using Core.Service;
using DAL;
using DAL.Entity;
using DAL.Enum;
using Module.Login.DomainServices;
using Module.Login.DTO.WorkWeChat;
using Module.OrganizationUnit.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Utility.Dependency;
using Utility.Enums;

namespace Module.OrganizationUnit.DomainServices
{
    public class WorkWeChatSyncOrganizationDomainService : IOrganizationUnitSyncService
    {
        LazyService<WorkWeChatLoginDomainService> _workWeChatLoginDomainService = new LazyService<WorkWeChatLoginDomainService>();
        /// <summary>
        /// 类型key，用于工厂注册
        /// </summary>
        public static readonly string TypeKey = LoginEnum.GlobalKey(OrganizationUnitEnum.WorkWeChatSync);
        public List<Department> GetOrganizationSync()
        {
            List<Department> departmentList = new List<Department>();
            //企业微信同步组织架构接口文档地址：https://developer.work.weixin.qq.com/document/path/90208

            //接口地址：https://qyapi.weixin.qq.com/cgi-bin/department/list?access_token=ACCESS_TOKEN&id=ID
            // 参数           必须    说明
            //access_token    是    调用接口凭证
            // id              否   部门id。获取指定部门及其下的子部门（以及子部门的子部门等等，递归）。 如果不填，默认获取全量组织架构
            string token = _workWeChatLoginDomainService.Instance.GetToken();
            string url = $"https://qyapi.weixin.qq.com/cgi-bin/department/list?access_token={token}";
            string jsonText = GetJson(url);
            var workWeChatDepartments = JsonConvert.DeserializeObject<WorkWeChatDepartmentsDTO>(jsonText);
            if (workWeChatDepartments.errcode == "0")
            {
                List<ThirdPartyDepartmentMapping> departmentMappingList = new List<ThirdPartyDepartmentMapping>();
                foreach (var item in workWeChatDepartments.department)
                {
                    ThirdPartyDepartmentMapping department = null;
                    var parent = departmentMappingList.FirstOrDefault(e => e.ThirdPartyId == item.parentid);
                    if (parent != null)
                    {
                        department = new ThirdPartyDepartmentMapping()
                        {
                            DepartmentMappingId = Guid.NewGuid(),
                            ThirdPartyId = item.id,
                            Name = item.name,
                            ThirdPartyParentId = item.parentid,
                            DepartmentMappingParentId = parent.DepartmentMappingId,

                            FromSystem = (ThirdPartySystemEnum)OrganizationUnitEnum.WorkWeChatSync,
                            order = item.order
                        };
                    }
                    else
                    {
                        department = new ThirdPartyDepartmentMapping()
                        {
                            DepartmentMappingId = Guid.NewGuid(),
                            ThirdPartyId = item.id,
                            Name = item.name,
                            ThirdPartyParentId = item.parentid,
                            DepartmentMappingParentId = item.parentid != "0" ? Guid.NewGuid() : (Guid?)null,
                            FromSystem = (ThirdPartySystemEnum)OrganizationUnitEnum.WorkWeChatSync,
                            order = item.order
                        };

                    }

                    departmentMappingList.Add(department);
                }
                //TODO：保留映射关系，目前至实现全删全插功能，后面根据映射关系动态调整部门信息；纳入后面迭代开发

                departmentMappingList.ForEach(e =>
                {
                    Department department = new Department()
                    {
                        Id = e.DepartmentMappingId,
                        Name = e.Name,
                        ParentId = e.DepartmentMappingParentId,
                        Code = e.order
                    };
                    departmentList.Add(department);
                });
                using (var ctx = new EntityContext())
                {
                    //全删全插
                    ctx.Database.ExecuteSqlCommand("delete from ThirdPartyDepartmentMappings");
                    ctx.ThirdPartyDepartmentMappings.AddRange(departmentMappingList);

                    //删除所有部门
                    ctx.Database.ExecuteSqlCommand("delete from Departments");
                    ctx.Departments.AddRange(departmentList);
                    var entity = departmentMappingList.FirstOrDefault(e => e.ThirdPartyParentId == "0");
                    //将原用户更新至最顶级部门，自行调整（后面迭代自动调整）
                    if (entity?.DepartmentMappingId!=null)
                    {
                        ctx.Database.ExecuteSqlCommand($"update Users set DepartmentId='{entity?.DepartmentMappingId}'");
                    }
                    ctx.SaveChanges();

                }
            }
            else
            {
                throw new Exception(workWeChatDepartments.errmsg);
            }
            return departmentList;
        }
        /// <summary>  
        /// 生成Json格式  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="obj"></param>  
        /// <returns></returns>  
        private string GetJson(string url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            wc.Encoding = Encoding.UTF8;
            string result = wc.DownloadString(url);
            return result;
        }
        public List<User> GetOrganizationUsersSync()
        {
            List<User> users = new List<User>();
            //同步企业微信人员信息，接口文档地址：
            //接口地址：https://qyapi.weixin.qq.com/cgi-bin/user/simplelist?access_token=ACCESS_TOKEN&department_id=DEPARTMENT_ID&fetch_child=1/0(1递归获取，0只获取本部门)
            string token = _workWeChatLoginDomainService.Instance.GetToken();
            string url = $"https://qyapi.weixin.qq.com/cgi-bin/user/simplelist?access_token={token}&department_id=1&fetch_child=1";
            string jsonText = GetJson(url);
            var workWeChatUsers = JsonConvert.DeserializeObject<WorkWeChatUsers>(jsonText);
            if (workWeChatUsers.errcode == "0")
            {
                List<ThirdPartyDepartmentMapping> departmentMappingList = new List<ThirdPartyDepartmentMapping>();
                //TODO:后面迭代根据用户名去重添加
                using (var ctx = new EntityContext())
                {
                    departmentMappingList = ctx.ThirdPartyDepartmentMappings.ToList();
                    var dbUsers = ctx.Users.ToList();
                    foreach (var item in workWeChatUsers.userlist)
                    {
                        var user = dbUsers.FirstOrDefault(e => e.WeChatUserid == item.userid);
                        if (user == null)
                        {
                            var entity = departmentMappingList.FirstOrDefault(e => e.ThirdPartyId == item.department.First());
                            users.Add(new User()
                            {
                                UserName = item.userid,
                                WeChatUserid = item.userid,
                                UserId = Guid.NewGuid(),
                                DepartmentId = entity.DepartmentMappingId,
                                Name = item.name,
                            });
                        }

                    }
                    ctx.Users.AddRange(users);
                    ctx.SaveChanges();
                }
            }
            return users;
        }
        /// <summary>
        /// 同步用户前校验
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool VerifyBeforeSyncUser()
        {
            var result = false;
            using (var ctx = new EntityContext())
            {
                var list = ctx.ThirdPartyDepartmentMappings.Where(e => e.FromSystem == (ThirdPartySystemEnum)OrganizationUnitEnum.WorkWeChatSync);
                if (list.Count() > 0)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
