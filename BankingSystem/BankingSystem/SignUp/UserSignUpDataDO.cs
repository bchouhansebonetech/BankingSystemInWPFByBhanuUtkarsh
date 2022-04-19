using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.SignUp
{
    public class UserSignUpDataDO
    {
        public string firstName;
        public string lastName;
        public string userName;
        public string email;
        public string city;
        public int pincode;
        public string password;

        public UserSignUpDataDO() { }
        public UserSignUpDataDO(string firstName, string lastName, string userName, string email, string city, int pincode, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.email = email;
            this.city = city;
            this.pincode = pincode;
            this.password = password;
        }
    }
}
