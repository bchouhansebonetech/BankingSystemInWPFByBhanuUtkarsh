using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SignUp;
using System.IO;

namespace BankingSystem.MockDataFiles
{
    public class ReadData
    {
        public List<UserSignUpDataDO> getUserSignUpDataDOs()
        {
            List<UserSignUpDataDO> users = new List<UserSignUpDataDO>();
            const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    UserSignUpDataDO userSignUpDataDO = new UserSignUpDataDO(values[1], values[2], values[3], values[4], values[5], Convert.ToInt32(values[6]), values[7]);
                    users.Add(userSignUpDataDO);
                }
                reader.Close();
            }
            return users;
        }
    }
}
