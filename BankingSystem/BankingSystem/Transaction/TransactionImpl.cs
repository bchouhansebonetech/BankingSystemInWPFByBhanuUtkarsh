using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem.LogIn;
using BankingSystem.MockDataFiles;
using BankingSystem.SignUp;

namespace BankingSystem.Transaction
{
    public class TransactionImpl
    {
        public List<TransactionDO> getAllTransactionsOfUser()
        {
            List<TransactionDO> allTransactions = null;
            ReadData readData1 = new ReadData();
            UserLogInDataDO userLogInData = readData1.getCurrentUser();
            if (userLogInData != null && userLogInData.status)
            {
                allTransactions = new List<TransactionDO>();

                ReadData readData = new ReadData();
                var transaction = readData.getTransactionDOs();

                foreach (TransactionDO transactionDO in transaction)
                {
                    if(transactionDO.UserName == userLogInData.userName)
                        allTransactions.Add(transactionDO);
                }
            }

            return allTransactions;
        }
    }
}
