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
using BankingSystem.LogIn;
using BankingSystem.MockDataFiles;
using BankingSystem.SignUp;


namespace BankingSystem.Transaction
{
    /// <summary>
    /// Interaction logic for TransactionForm.xaml
    /// </summary>
    public partial class TransactionForm : Window
    {
        //List<Car> cars { get; set; }
        List<TransactionDO> transactions { get; set; }

        public TransactionForm()
        {
            InitializeComponent();
            //cars = new List<Car>();
            //Car car = new Car();    
            //cars = car.getCars();
            //myList.ItemsSource = cars;
            transactions = new List<TransactionDO>();
            TransactionImpl transactionImpl = new TransactionImpl();
            List<TransactionDO> transactionsList = transactionImpl.getAllTransactionsOfUser();

            foreach (TransactionDO transaction in transactionsList)
            {
                transactions.Add(transaction);
            }

            myList.ItemsSource = transactions;
        }

        public bool FilterDeposite(object obj)
        {
            var FilterObject = obj as TransactionDO;

            return FilterObject.CreditOrDeposite.Contains(ComboBox1.Text, StringComparison.OrdinalIgnoreCase);

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedValue == credit)
            {
                //myList.Items.Filter = FilterDeposite;
                //MessageBox.Show("Credit Selected");
                List<TransactionDO> creditTransactions = new List<TransactionDO>();
                foreach (TransactionDO transaction in transactions)
                {
                    if(transaction.CreditOrDeposite == "Credit")
                    {
                        creditTransactions.Add(transaction);
                    }
                }
                myList.ItemsSource = creditTransactions;
            }
            else if (ComboBox1.SelectedValue == deposite)
            {
                //MessageBox.Show("Deposite Selected");
                List<TransactionDO> depositeTransactions = new List<TransactionDO>();
                foreach (TransactionDO transaction in transactions)
                {
                    if (transaction.CreditOrDeposite == "Deposite")
                    {
                        depositeTransactions.Add(transaction);
                    }
                }
                myList.ItemsSource = depositeTransactions;
            }
            else
            {
                myList.ItemsSource = transactions;
            }
        }
    }
}
