using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            loadCurrentSetting();
        }

        public void loadCurrentSetting()
        {
            txtServerName.Text = Properties.Settings.Default.ServerName;
            txtDatabase.Text = Properties.Settings.Default.Database;
            txtUserID.Text = Properties.Settings.Default.UserID;
            txtPassword.Text = Properties.Settings.Default.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtServerName.Text != "" && txtDatabase.Text != "" && txtUserID.Text != "" && txtPassword.Text != "")
            {
                Properties.Settings.Default.ServerName = txtServerName.Text;
                Properties.Settings.Default.Database = txtDatabase.Text;
                Properties.Settings.Default.UserID = txtUserID.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else MessageBox.Show("Input setting field!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
