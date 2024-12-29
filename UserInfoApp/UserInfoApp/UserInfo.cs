using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfoApp
{
    internal class UserInfo
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public int UserAge { get; set; }
        public UserInfo(string userName, string userId, int userAge)
        {
            UserName = userName;
            UserId = userId;
            UserAge = userAge;
        }

        public override string ToString()
        {
            return UserId + "\t" + UserName + "\t" + UserAge + "\n";
        }
    }
}
