using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SignUp;
using BankingSystem.Transaction;
using System.IO;
using BankingSystem.LogIn;

namespace BankingSystem.MockDataFiles
{
    public class ReadData
    {

        public List<UserSignUpDataDO> getUserSignUpDataDOs()
        {
            List<UserSignUpDataDO> users = new List<UserSignUpDataDO>();
            //const string filePath = @"C:\Users\Utkarsh Shrivastava\source\repos\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
            string filePath = "";
            //const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
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

        public List<TransactionDO> getTransactionDOs()
        {
            List<TransactionDO> transactionDOs = new List<TransactionDO>();

            const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\TransactionDummyData.csv";

            using(StreamReader reader = new StreamReader(filePath))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    TransactionDO transactionDO = new TransactionDO(values[0], values[1], Convert.ToInt32(values[2]), values[3], values[4], values[5]);
                    transactionDOs.Add(transactionDO);
                }
                reader.Close();
            }

            return transactionDOs;
        }

        public UserLogInDataDO getCurrentUser()
        {
            UserLogInDataDO userLogInDataDO = null;
            const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\CurrentUserData.csv";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    userLogInDataDO = new UserLogInDataDO(values[0], values[1], Convert.ToBoolean(values[2]));
                }
                reader.Close();
            }
            return userLogInDataDO;
        }
    }
}
