
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BankingSystem.MockDataFiles;
using BankingSystem.SignUp;

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
            List<UserSignUpDataDO> userSignUpDataDOs = readData.getUserSignUpDataDOs();
            foreach (UserSignUpDataDO userSignUpDataDO in userSignUpDataDOs)
            {
                PayeeDetails payeeDetails = new PayeeDetails(userSignUpDataDO.firstName,userSignUpDataDO.userName,userSignUpDataDO.city);
                payeeDetailList.Add(payeeDetails);

            }
            DataContext = payeeDetailList;


        }

    }
}
