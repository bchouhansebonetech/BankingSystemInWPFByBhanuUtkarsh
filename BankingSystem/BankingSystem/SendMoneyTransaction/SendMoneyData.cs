using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.SendMoneyTransaction
{
    public class SendMoneyData
    {
        private string text1;
        private string text2;
        private string text3;
        private object text4;
        private string text5;

        public string name { get; set; }
        public string accountNo { get; set; }
        public string ifcCode { get; set; }
        public Double amount { get; set; }
        public string from { get; set; }
        public Boolean paymentStatus { get; set; }
        public Double bankBalance { get; set; }
        
        public SendMoneyData() { }
        public SendMoneyData(string name, string accountNo, string ifcCode, Double amount, string from, Boolean paymentStatus, Double bankBalance)
        {
            this.name = name;
            this.accountNo = accountNo;
            this.ifcCode = ifcCode;
            this.amount = amount;
            this.from = from;
            this.paymentStatus = paymentStatus;
            this.bankBalance = bankBalance;

        }

        public SendMoneyData(string name, string accountNo, string ifccode,Double amount,string from)
        {
            this.name=name;
            this.accountNo = accountNo;
            this.ifcCode = ifcCode;
            this.amount=amount;
            this.from = from;
        
        }
    }
}
