using BankingSystem.SignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.MockDataFiles;

namespace BankingSystem.LogIn
{
    public class LogInImpl : ILogIn
    {
         public  UserLogInDataDO loginAccess(UserLogInDataDO userLoginDataDO)
        {
            if (userLoginDataDO.status == true)
                return userLoginDataDO;
            else
            {
                ReadData readData = new ReadData();
                List<UserSignUpDataDO> userSignUpList = readData.getUserSignUpDataDOs();
                if (userLoginDataDO.userName == null || userLoginDataDO.password == null)
                    userLoginDataDO.status = false;
                else
                {
                    foreach (UserSignUpDataDO user in userSignUpList)
                    {
                        if (user.userName == userLoginDataDO.userName && userLoginDataDO.password == user.password)
                        {
                            userLoginDataDO.status = true;
                            
                        }      
                    }
                }
                return userLoginDataDO;
            }
        }
    }
}
