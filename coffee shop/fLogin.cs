using coffee_shop.data_access_layer;
using coffee_shop.data_transfer_object;
using System;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtID.Text;
            string password = txtPassword.Text;
            if (login(userName, password))
            {
                Account loginAccount = AccountDAO.Instance.getAccountByUserName(userName);
                fCoffee fCoffee = new fCoffee(loginAccount);
                this.Hide();
                fCoffee.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Wrong ID or Password!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
