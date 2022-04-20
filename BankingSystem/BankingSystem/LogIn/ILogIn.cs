using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.MockDataFiles;
using BankingSystem.SignUp;
namespace BankingSystem.LogIn
   
{
    public interface ILogIn
    {
        public UserLogInDataDO loginAccess(UserLogInDataDO userLoginDataDO);
    }
}
