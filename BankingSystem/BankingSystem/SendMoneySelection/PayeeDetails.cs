using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.SendMoneySelection
{
    public class PayeeDetails
    {
        public String payeeAccountNo { get; set; }
        public String payeeName { get; set; }
        

        public String location { get; set; }

        public PayeeDetails() { }
        public PayeeDetails(string payeeAc, String pName,string location)
        {
            this.payeeAccountNo = payeeAc;
            this.payeeName = pName;
            this.location = location;
        }

    }
}
