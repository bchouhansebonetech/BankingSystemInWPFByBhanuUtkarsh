using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SignUp;


namespace BankingSystem.MockDataFiles
{
    public class WriteData
    {
        public void writeUserSignData(UserSignUpDataDO obj)
        {
            const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
            //var writer = new StreamWriter(filePath);

            string line = String.Format(obj.firstName + "," + obj.lastName + "," + obj.userName + "," + obj.email + "," + obj.city + "," + obj.pincode.ToString() + "," + obj.password);
            File.AppendAllText(filePath, line + Environment.NewLine);
            //writer.WriteLine(line);
            //writer.Flush();
        }
    }
}
