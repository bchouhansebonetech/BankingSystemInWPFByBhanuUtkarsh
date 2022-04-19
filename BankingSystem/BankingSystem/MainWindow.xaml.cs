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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginRedirectingButton_Click(object sender, RoutedEventArgs e)
        {
            BankingSystem.LogIn.LogInForm form = new BankingSystem.LogIn.LogInForm();
            form.Show();
        }

        private void SignupRedirectingButton_Click(object sender, RoutedEventArgs e)
        {
            BankingSystem.SignUp.SignUpForm form = new BankingSystem.SignUp.SignUpForm();
            form.Show();
        }
    }
}
