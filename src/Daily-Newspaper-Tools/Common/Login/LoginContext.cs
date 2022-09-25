using DAL.DTO;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Newspaper_Tools.Common.Login
{
    public sealed class LoginContext
    {
        public static LoginContext Current { get; set; }

        public UserDTO UserInfo { get; set; }

        public string UserName => _userName;
        public Guid UserId => _userid;

        public string Password => _password;
        private readonly Guid _userid;
        private readonly string _userName;
        private readonly string _password;

        public LoginContext(UserDTO loginUser)
        {
            UserInfo = loginUser;
            this._userid = loginUser.UserId;
            this._password = loginUser.Password;
            this._userName = loginUser.UserName;
        }
    }
}
