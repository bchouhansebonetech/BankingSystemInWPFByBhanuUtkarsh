using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.LogIn
{
    public class UserLogInDataDO
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool status { get; set; }

        public UserLogInDataDO() { }
        public UserLogInDataDO(string userName, string password, bool status)
        {
            this.userName = userName;
            this.password = password;
            this.status = status;
        }
    }
}
