using Module.Login.DTO.WorkWeChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrganizationUnit.DTO
{
    public class WorkWeChatUsers: ApiBaseResult
    {
        public List<WorkWeChatUsersDTO> userlist { get; set; }
    }
    public class WorkWeChatUsersDTO
    { 
        public string userid { get; set; }

        public string name { get; set; }

        public string[] department { get; set; }

        public string open_userid { get; set; }
    }
}
