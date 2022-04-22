using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SignUp;
using BankingSystem.Transaction;
using System.IO;
using BankingSystem.LogIn;
using BankingSystem.SendMoneySelection;
using BankingSystem.SendMoneyTransaction;

namespace BankingSystem.MockDataFiles
{
    public class ReadData
    {
        string ProjectDir;
        public ReadData()
        {
            ProjectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        }
        public List<UserSignUpDataDO> getUserSignUpDataDOs()
        {
            List<UserSignUpDataDO> users = new List<UserSignUpDataDO>();
            string filePath = ProjectDir + @"\MockDataFiles\UserSignUpDummyData.csv";
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

            string filePath = ProjectDir + @"\MockDataFiles\TransactionDummyData.csv";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    TransactionDO transactionDO = new TransactionDO(values[0], values[1], Convert.ToDouble(values[2]), values[3], values[4], values[5]);
                    transactionDOs.Add(transactionDO);
                }
                reader.Close();
            }

            return transactionDOs;
        }

        public UserLogInDataDO getCurrentUser()
        {
            UserLogInDataDO userLogInDataDO = null;
            string filePath = ProjectDir + @"\MockDataFiles\CurrentUserData.csv";
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
        public List<PayeeDetailsDO> readPayeeData()
        {
            List<PayeeDetailsDO> payeeDetailsList = new List<PayeeDetailsDO>();
            string filePath = ProjectDir + @"\MockDataFiles\PayeeDetails.csv";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    PayeeDetailsDO payeeDetails = new PayeeDetailsDO(values[0], values[1], values[2]);
                    payeeDetailsList.Add(payeeDetails);
                }
                reader.Close();
            }
            return payeeDetailsList;

        }

        public Dictionary<string, SendMoneyData> readUserData()
        {
            Dictionary<string, SendMoneyData> data = new Dictionary<string, SendMoneyData>();
            string filePath = ProjectDir + @"\MockDataFiles\SendMoneyTransaction.csv";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = "";
                while ((line != reader.ReadLine()) != null)
                {
                    string[] vs = line.Split(',');
                    SendMoneyData sendMoneyData = new SendMoneyData(vs[0],vs[1],vs[2], Convert.ToDouble(vs[4]),vs[5],Convert.ToBoolean(vs[6]),Convert.ToDouble(vs[7]));
                    data.Add(sendMoneyData.name, sendMoneyData);
                }
            }
            return data;
        }
    }
}
