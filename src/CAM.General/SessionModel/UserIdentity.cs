using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAM.General.SessionModel
{

    /// <summary>
    /// 用户身份信息
    /// </summary>
    [Serializable]
    public class UserIdentity
    {
        public UserIdentity_PassportInfo PassportInfo { get; set; }

        public UserIdentity_UserInfo UserInfo { get; set; }

        public UserIdentity_RoleInfo RoleInfo { get; set; }
    }

    [Serializable]
    public class UserIdentity_PassportInfo
    {
        public long PassportId { get; set; }
        public string LoginName { get; set; }
        public string Token { get; set; }
        public UserIdentity_PassportInfo()
        {
            PassportId = 0;
            LoginName = "";
            Token = "";
        }
    }

    [Serializable]
    public class UserIdentity_UserInfo
    {
        public long UserId { get; set; }
        public string Name { get; set; }

        public UserIdentity_UserInfo()
        {
            UserId = 0;
            Name = "";
        }
    }

    [Serializable]
    public class UserIdentity_RoleInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PopedomKeys { get; set; }

        public UserIdentity_RoleInfo()
        {
            Id = 0;
            Name = "";
            PopedomKeys = "";
        }
    }


}
