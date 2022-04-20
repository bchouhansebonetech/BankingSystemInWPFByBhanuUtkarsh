
using System;
using System.Windows;
using BankingSystem.LogIn;


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

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            UserLogInDataDO userLogInData = new UserLogInDataDO(usernameTextBox.Text, PasswordBox.Password);
            LogInImpl logInImpl = new  LogInImpl();
            bool logInStatus=logInImpl.loginAccess(userLogInData).status;
            if (logInStatus)
            {
                MessageBox.Show("sucess");

            }
            else
                MessageBox.Show("Invalid Username or Password");
            BankingSystem.SendMoneySelection.SendMoneySelection sendMoneySelection = new BankingSystem.SendMoneySelection.SendMoneySelection();
            sendMoneySelection.Show();

        }
    }
}
