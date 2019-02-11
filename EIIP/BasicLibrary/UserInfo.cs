using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIIP.BasicLibrary
{
    public class UserInfo
    {
        private string UserId;
        private string UserName;
        private string PermId;
        private string LoginIp;

        public string _UserId
        {
            set { UserId = value; }
            get { return UserId; }
        }

        public string _UserName
        {
            set { UserName = value; }
            get { return UserName; }
        }
    }
}
