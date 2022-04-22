using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.SendMoneySelection;
using BankingSystem.MockDataFiles;
using BankingSystem.SendMoneySelection;

namespace BankingSystem.AddNewPayee
{
    public class AddNewPayeeImpl
    {
        public bool addPayee(PayeeDetailsDO payeeDetailsDO)
        {
            
            if (!isPayeeAvailable(payeeDetailsDO))
            {
                createPayee(payeeDetailsDO);
                return true;
            }
            return false;
        }


        private bool isPayeeAvailable(PayeeDetailsDO payeeDetailsDO)
        {
            ReadData readData = new ReadData();

            List<PayeeDetailsDO> payeeDetailsDOList = readData.readPayeeData();

            foreach (PayeeDetailsDO payeeDetailsDO1 in payeeDetailsDOList)
            {
                if (payeeDetailsDO.payeeAccountNo.Equals(payeeDetailsDO1.payeeAccountNo))
                    return true;
            }

            return false;
        }

        private bool createPayee(PayeeDetailsDO payeeDetailsDO)
        {
            WriteData writeData = new WriteData();
            writeData.writePayeeData(payeeDetailsDO);
            return true;
        }
    }
}
