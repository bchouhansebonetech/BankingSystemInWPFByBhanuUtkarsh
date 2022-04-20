using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.SendMoneySelection
{
    public class PayeeDetails
    {
        public String payeeName { get; set; }
        public String payeeAccountNo { get; set; }

        public String location { get; set; }

        public PayeeDetails() { }
        public PayeeDetails(string pname, String payeeAc,string location)
        {
            this.payeeName = pname;
            this.payeeAccountNo = payeeAc;
            this.location = location;
        }

    }
}
