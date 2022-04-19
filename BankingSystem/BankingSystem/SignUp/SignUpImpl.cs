using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.LogIn;

namespace BankingSystem.SignUp
{
    public class SignUpImpl
    {
        public UserLogInDataDO userSignUp(UserSignUpDataDO userSignUpDataDO)
        {
            UserLogInDataDO userLogInDataDO = null;
            SignUpImpl signUpImpl = new SignUpImpl();

            if (!signUpImpl.isUserAvailable(userSignUpDataDO))
            {
                userLogInDataDO = new UserLogInDataDO();
                signUpImpl.createUser(userSignUpDataDO);
                userLogInDataDO.userName = userSignUpDataDO.userName;
                userLogInDataDO.password = userSignUpDataDO.password;
                userLogInDataDO.status = true;
            }
            return userLogInDataDO;
        }

        private bool isUserAvailable(UserSignUpDataDO userSignUpDataDO)
        {
            return false;
        }

        private bool createUser(UserSignUpDataDO userSignUpDataDO)
        {
            return false;
        }
    }
}
