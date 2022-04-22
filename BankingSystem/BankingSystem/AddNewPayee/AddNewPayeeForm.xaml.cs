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
using BankingSystem.SendMoneySelection;
using BankingSystem.AddNewPayee;

namespace BankingSystem.AddNewPayee
{
    /// <summary>
    /// Interaction logic for AddNewPayeeForm.xaml
    /// </summary>
    public partial class AddNewPayeeForm : Window
    {
        public AddNewPayeeForm()
        {
            InitializeComponent();
        }

        private void btnAddPayee_Click(object sender, RoutedEventArgs e)
        {
            PayeeDetailsDO payeeDetailsDO = new PayeeDetailsDO();
            payeeDetailsDO.payeeAccountNo = Account.Text;
            payeeDetailsDO.payeeName = PayeeName.Text;
            payeeDetailsDO.location = Address.Text;

            AddNewPayeeImpl addNewPayeeImpl = new AddNewPayeeImpl();

            if (addNewPayeeImpl.addPayee(payeeDetailsDO))
            {
                MessageBox.Show("New Payee is added");

            }
            else
            {
                MessageBox.Show("Payee already exist");
            }
        }
    }
}
