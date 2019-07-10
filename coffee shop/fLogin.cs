using business_logic_layer;
using data_transfer_object;
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

        private AccountBLL accBLL = new AccountBLL();

        bool login(string username, string password)
        {
            Provider provider = new Provider(
                Properties.Settings.Default.ServerName,
                Properties.Settings.Default.Database,
                Properties.Settings.Default.UserID,
                Properties.Settings.Default.Password
                );
            return accBLL.login(username, password, provider);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtID.Text;
                string password = txtPassword.Text;
                if (login(userName, password))
                {
                    Account loginAccount = accBLL.getAccountByUserName(userName);
                    fCoffee fCoffee = new fCoffee(loginAccount);
                    this.Hide();
                    fCoffee.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("Wrong ID or Password!");
            }
            catch
            {
                MessageBox.Show("Connect fail!");
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting fSetting = new Setting();
            fSetting.ShowDialog();
        }
    }
}
