
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BankingSystem.MockDataFiles;
using BankingSystem.SendMoneyTransaction;

namespace BankingSystem.SendMoneySelection
{
    /// <summary>
    /// Interaction logic for SendMoneySelection.xaml
    /// </summary>
    public partial class SendMoneySelection : Window
    {
        public List<PayeeDetails> payeeDetailList { get; set; }
        public SendMoneySelection()
        {
            InitializeComponent();

            payeeDetailList = new List<PayeeDetails>();
            ReadData readData = new ReadData();
            List<PayeeDetails> payeeDetailsList2 = readData.readPayeeData();
           foreach(PayeeDetails payeeDetails in payeeDetailsList2)
            {
                PayeeDetails payeeDetails1 = new PayeeDetails(payeeDetails.payeeAccountNo,payeeDetails.payeeName,payeeDetails.location);
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

        }
        private void SendMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            BankingSystem.SendMoneyTransaction.Window1 sendMoneyTransaction = new BankingSystem.SendMoneyTransaction.Window1();
            sendMoneyTransaction.Show();
        }
    }
}
