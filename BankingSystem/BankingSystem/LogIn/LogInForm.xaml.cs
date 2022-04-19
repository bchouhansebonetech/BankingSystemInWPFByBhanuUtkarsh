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

namespace BankingSystem.LogIn
{
    /// <summary>
    /// Interaction logic for LogInForm.xaml
    /// </summary>
    public partial class LogInForm : Window
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void signupbutton_Click(object sender, RoutedEventArgs e)
        {
            BankingSystem.SignUp.SignUpForm signupform = new BankingSystem.SignUp.SignUpForm();
            signupform.Show();
        }
    }
}
