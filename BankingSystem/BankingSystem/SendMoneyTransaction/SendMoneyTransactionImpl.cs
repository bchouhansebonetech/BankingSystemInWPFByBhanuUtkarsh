using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.MockDataFiles;

namespace BankingSystem.SendMoneyTransaction
{
    public class SendMoneyTransactionImpl : ISendMoneyTransaction
    {
         public bool sendMoneyTransaction(SendMoneyData data)
        {   // read from transaction
            //hashmap <accountno,SendMoneyTranscation> map/ map.accountno store in obj
            // write that in transacgtion file
            ReadData readData = new ReadData();
            Dictionary<String, SendMoneyData> map = readData.readUserData();
            SendMoneyData mapData = map[data.accountNo];
            data.bankBalance = mapData.bankBalance;

            if (data.bankBalance == 0 || data.amount > data.bankBalance || data.amount <= 0)
                   data.paymentStatus = false;
            else
            {
                //read data from trancastion file


            }
            return true;
        }
    }
}
