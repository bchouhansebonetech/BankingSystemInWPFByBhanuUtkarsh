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

namespace BankingSystem.SignUp
{
    /// <summary>
    /// Interaction logic for SignUpForm.xaml
    /// </summary>
    public partial class SignUpForm : Window
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            UserSignUpDataDO userSignUpDataDO = new UserSignUpDataDO();
            userSignUpDataDO.firstName = txtFirstName.Text;
            userSignUpDataDO.lastName = txtLastName.Text;
            userSignUpDataDO.userName = txtUserName.Text;
            userSignUpDataDO.email = txtEMail.Text;
            userSignUpDataDO.city = txtCity.Text;
            userSignUpDataDO.pincode = Convert.ToInt32(txtPincode.Text);
            userSignUpDataDO.password = txtPassword.Text;

            MessageBox.Show($"{userSignUpDataDO.firstName}, {userSignUpDataDO.lastName}, {userSignUpDataDO.userName}");
        }
    }
}
