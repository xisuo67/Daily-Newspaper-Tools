using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class ContactsDTO
    {
        public int Id { get; set; }
        /// <summary>
        /// 多用户
        /// </summary>
        public Guid UserId { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string BtnEdit { get; set; } = "编辑";

        public string BtnDel { get; set; } = "删除";
    }
}
