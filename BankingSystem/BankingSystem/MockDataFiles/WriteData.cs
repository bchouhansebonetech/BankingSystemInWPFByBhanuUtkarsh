using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SignUp;
using BankingSystem.LogIn;
using BankingSystem.SendMoneySelection;


namespace BankingSystem.MockDataFiles
{
    public class WriteData
    {
        string ProjectDir;
        public WriteData()
        {
            ProjectDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        }
        public void writeUserSignData(UserSignUpDataDO obj)
        { 
            string filePath = ProjectDir + @"\MockDataFiles\UserSignUpDummyData.csv";
            int id = Convert.ToInt32(File.ReadLines(filePath).Last().Split(",")[0]) + 1;
            string line = String.Format(Convert.ToString(id) + "," + obj.firstName + "," + obj.lastName + "," + obj.userName + "," + obj.email + "," + obj.city 
                                        + "," + obj.pincode.ToString() + "," + obj.password);

            File.AppendAllText(filePath, line + Environment.NewLine);
        }

        public void writeLogInDataOfCurrentUser(UserLogInDataDO userLogInDataDO)
        { 
            string filePath = ProjectDir + @"\MockDataFiles\CurrentUserData.csv";

            string line = String.Format(userLogInDataDO.userName + "," + userLogInDataDO.password + "," + Convert.ToString(userLogInDataDO.status));

            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine(line);
            streamWriter.Flush();
            streamWriter.Close();

        }

        public void writePayeeData(PayeeDetailsDO payeeDetailsDO)
        {
            string filePath = ProjectDir + @"\MockDataFiles\PayeeDetails.csv";

            string line = String.Format(payeeDetailsDO.payeeAccountNo + "," + payeeDetailsDO.payeeName + "," + payeeDetailsDO.location);
            
            File.AppendAllText(filePath, line + Environment.NewLine);
        }
    }
}
