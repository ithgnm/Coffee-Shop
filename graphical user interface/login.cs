using business_logic_layer;
using System;
using System.Windows.Forms;


namespace graphical_user_interface
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        protected AccountBLL accBLL = new AccountBLL();
        private bool isOnline = false;

        public login()
        {
            InitializeComponent();
            dlafStyle.LookAndFeel.SetSkinStyle(Properties.Settings.Default.Theme);
        }

        private bool getLoginAccount()
        {
            string userName = txtID.Text;
            string password = txtPassword.Text;
            return accBLL.login(userName, password, isOnline);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (getLoginAccount())
            {
                coffee coffee = new coffee();
                this.Hide();
                coffee.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Wrong ID or Password!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ceOnline_CheckedChanged(object sender, EventArgs e)
        {
            isOnline = isOnline == true ? false : true;
        }
    }
}