using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SignUp;
using System.IO;
using BankingSystem.SendMoneySelection;
using BankingSystem.SendMoneyTransaction;

namespace BankingSystem.MockDataFiles
{
    public class ReadData
    {

        public List<UserSignUpDataDO> getUserSignUpDataDOs()
        {
            List<UserSignUpDataDO> users = new List<UserSignUpDataDO>();
            //const string filePath = @"C:\Users\Utkarsh Shrivastava\source\repos\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
            string filePath = "";
            //const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
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

        public List<PayeeDetails> readPayeeData()
        {
            List<PayeeDetails> payeeDetailsList = new List<PayeeDetails>();
            //const string filePath = @"C:\Users\Utkarsh Shrivastava\source\repos\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\PayeeDetails.Csv";
            string filePath = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = "";

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    PayeeDetails payeeDetails = new PayeeDetails(values[0], values[1], values[2]);
                    payeeDetailsList.Add(payeeDetails);

                }
                reader.Close();
            }
            return payeeDetailsList;

        }

        public Dictionary<string, SendMoneyData> readUserData()
        {
            Dictionary<string, SendMoneyData> data = new Dictionary<string, SendMoneyData>();
            //filepath
            string filePath = "";
            //const string filePath = @"C:\Users\Utkarsh Shrivastava\source\repos\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\SendMoneyTransaction.Csv";
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
