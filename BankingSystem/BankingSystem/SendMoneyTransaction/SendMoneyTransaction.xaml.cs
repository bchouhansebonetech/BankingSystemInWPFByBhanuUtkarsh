using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankingSystem.SendMoneyTransaction
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void TransactionButton_Click(object sender, RoutedEventArgs e)
        {
            SendMoneyData data = new SendMoneyData(NameTextBox.Text,AccountNumberTextBox.Text,IFCTextBox.Text,Convert.ToDouble(amountTextBox.Text),FromTextBox.Text);
            SendMoneyTransactionImpl sendMoneyTransactionImpl = new SendMoneyTransactionImpl();
            bool status = sendMoneyTransactionImpl.sendMoneyTransaction(data);
            if (status)
                MessageBox.Show("Payment done");
            else
                MessageBox.Show("Payment not donw");


        }
    }
}
