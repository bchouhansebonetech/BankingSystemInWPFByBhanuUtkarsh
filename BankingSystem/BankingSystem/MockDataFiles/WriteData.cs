using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SignUp;
using BankingSystem.LogIn;


namespace BankingSystem.MockDataFiles
{
    public class WriteData
    {
        public void writeUserSignData(UserSignUpDataDO obj)
        {
            //const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
            //const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
            string filePath = "";
            int id = Convert.ToInt32(File.ReadLines(filePath).Last().Split(",")[0]) + 1;
            string line = String.Format(Convert.ToString(id) + "," + obj.firstName + "," + obj.lastName + "," + obj.userName + "," + obj.email + "," + obj.city 
                                        + "," + obj.pincode.ToString() + "," + obj.password);

            File.AppendAllText(filePath, line + Environment.NewLine);
<<<<<<< HEAD
        }

        public void writeLogInDataOfCurrentUser(UserLogInDataDO userLogInDataDO)
        {
            const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystemInWPFByBhanuUtkarsh\BankingSystem\BankingSystem\MockDataFiles\CurrentUserData.csv";

            string line = String.Format(userLogInDataDO.userName + "," + userLogInDataDO.password + "," + Convert.ToString(userLogInDataDO.status));

            StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine(line);
            streamWriter.Flush();
            streamWriter.Close();
=======

>>>>>>> cf59538ec47589cf87283e8b7864a6f43604d77d
        }
    }
}
