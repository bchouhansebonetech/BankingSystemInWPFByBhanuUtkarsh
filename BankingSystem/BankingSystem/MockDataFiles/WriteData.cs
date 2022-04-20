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
            //  const string filePath = @"C:\Users\Bhanu Singh\source\repos\PracticeProgramProject\WPFProject2\BankingSystem\BankingSystem\MockDataFiles\UserSignUpDummyData.csv";
            string filePath = "";
            int id = Convert.ToInt32(File.ReadLines(filePath).Last().Split(",")[0]) + 1;
            string line = String.Format(Convert.ToString(id) + "," + obj.firstName + "," + obj.lastName + "," + obj.userName + "," + obj.email + "," + obj.city 
                                        + "," + obj.pincode.ToString() + "," + obj.password);

            File.AppendAllText(filePath, line + Environment.NewLine);
            //using (StreamWriter sw = File.AppendText(filePath))
            //{
            //    sw.WriteLine(line);
            //}
            //var writer = new StreamWriter(filePath);
            //string[] lines = File.ReadAllLines(filePath);
            //lines.Append(line);

            //var writer = new StreamWriter(filePath);

            //foreach (var item in lines)
            //{
            //    writer.WriteLine(item);
            //    writer.Flush();
            //}
        }
    }
}
