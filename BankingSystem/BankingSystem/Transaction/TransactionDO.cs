using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Transaction
{
    public class TransactionDO
    {
        public string UserName { get; set; }
        public string TransactionID { get; set; }
        public double Ammount { get; set; }
        public string FromBank { get; set; }
        public string ToBank { get; set; }
        public string CreditOrDeposite { get; set; }

        public TransactionDO() { }
        public TransactionDO(string UserName, string TransactionID, double Ammount, string FromBank, string ToBank, string CreditOrDeposite)
        {
            this.UserName = UserName;
            this.TransactionID = TransactionID;
            this.Ammount = Ammount;
            this.FromBank = FromBank;
            this.ToBank = ToBank;
            this.CreditOrDeposite = CreditOrDeposite;
        }
    }
}
