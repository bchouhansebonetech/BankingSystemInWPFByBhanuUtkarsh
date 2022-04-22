
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BankingSystem.MockDataFiles;
using BankingSystem.SendMoneyTransaction;
using BankingSystem.AddNewPayee;

namespace BankingSystem.SendMoneySelection
{
    /// <summary>
    /// Interaction logic for SendMoneySelection.xaml
    /// </summary>
    public partial class SendMoneySelection : Window
    {
        public List<PayeeDetailsDO> payeeDetailList { get; set; }
        public SendMoneySelection()
        {
            InitializeComponent();

            payeeDetailList = new List<PayeeDetailsDO>();
            ReadData readData = new ReadData();
            List<PayeeDetailsDO> payeeDetailsList2 = readData.readPayeeData();
           foreach(PayeeDetailsDO payeeDetails in payeeDetailsList2)
            {
                PayeeDetailsDO payeeDetails1 = new PayeeDetailsDO(payeeDetails.payeeAccountNo,payeeDetails.payeeName,payeeDetails.location);
                payeeDetailList.Add(payeeDetails1);


            }
          /*  List<UserSignUpDataDO> userSignUpDataDOs = readData.getUserSignUpDataDOs();
            foreach (UserSignUpDataDO userSignUpDataDO in userSignUpDataDOs)
            {
                PayeeDetails payeeDetails = new PayeeDetails(userSignUpDataDO.firstName,userSignUpDataDO.userName,userSignUpDataDO.city);
                payeeDetailList.Add(payeeDetails);

            }*/
            DataContext = payeeDetailList;


        }


        private void AddNewPayeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewPayee.AddNewPayeeForm addNewPayeeForm = new AddNewPayee.AddNewPayeeForm();
            addNewPayeeForm.Show();
        }
        private void SendMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            BankingSystem.SendMoneyTransaction.Window1 sendMoneyTransaction = new BankingSystem.SendMoneyTransaction.Window1();
            sendMoneyTransaction.Show();
        }
    }
}
