using coffee_shop.data_access_layer;
using coffee_shop.data_transfer_object;
using System;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class fProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount { get => loginAccount; set { loginAccount = value; changeAccount(loginAccount); } }

        public fProfile(Account account)
        {
            InitializeComponent();
            LoginAccount = account;
        }

        void changeAccount(Account account)
        {
            txtID.Text = loginAccount.UserName;
        }

        void updateAccount()
        {
            string userName = txtID.Text;
            string password = txtPassword.Text;
            string newPassword = tbNewPassword.Text;
            string confirm = tbConfirm.Text;
            if (!newPassword.Equals(confirm))
                MessageBox.Show("Wrong confirm password!");
            else if (AccountDAO.Instance.updateAccountPassword(userName, password, newPassword))
            {
                MessageBox.Show("Update complete!");
                this.Close();
            }
            else MessageBox.Show("Reenter password!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            updateAccount();
        }
    }
}
