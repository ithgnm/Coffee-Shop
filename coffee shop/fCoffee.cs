using coffee_shop.data_access_layer;
using coffee_shop.data_transfer_object;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class fCoffee : Form
    {
        private Account loginAccount;
        public Account LoginAccount { get => loginAccount; set { loginAccount = value; changeAccount(loginAccount.Type); } }

        public fCoffee(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            loadTable();
            loadCategory();
            loadCBTable(cbSwitch);
            btnSwitch.Enabled = false;
            btnDiscount.Enabled = false;
        }

        #region Method
        void changeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
        }

        void loadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.tableWidth, Height = TableDAO.tableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Empty":
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }

        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.getListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void loadDrinkListByCategory(int id)
        {
            List<Drink> listDrink = DrinkDAO.Instance.getDrinkByIDCatogery(id);
            cbDrink.DataSource = listDrink;
            cbDrink.DisplayMember = "Name";
        }

        void showBill(int id)
        {
            lvList.Items.Clear();
            List<data_transfer_object.Menu> listBillInfo = MenuDAO.Instance.getListMenuByTable(id);
            float totalPrice = 0;
            foreach (data_transfer_object.Menu item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.DrinkName.ToString());
                lvItem.SubItems.Add(item.Count.ToString());
                lvItem.SubItems.Add(item.Price.ToString());
                lvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvList.Items.Add(lvItem);
            }
            CultureInfo culture = new CultureInfo("vni-vn");
            txtTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        void loadCBTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion

        #region Event
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvList.Tag = (sender as Button).Tag;
            showBill(tableID);
            btnSwitch.Enabled = true;
            btnDiscount.Enabled = true;
            txtCurrentTable.Text = "Table " + tableID;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin admin = new fAdmin();
            admin.loginAccount = LoginAccount;
            admin.InsertDrink += Admin_InsertDrink;
            admin.DeleteDrink += Admin_DeleteDrink;
            admin.UpdateDrink += Admin_UpdateDrink;
            admin.InsertCategory += Admin_InsertCategory;
            admin.UpdateCategory += Admin_UpdateCategory;
            admin.DeleteCategory += Admin_DeleteCategory;
            admin.InsertTable += Admin_InsertTable;
            admin.UpdateTable += Admin_UpdateTable;
            admin.DeleteTable += Admin_DeleteTable;
            admin.ShowDialog();
        }

        private void Admin_DeleteTable(object sender, EventArgs e)
        {
            loadCBTable(cbSwitch);
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
            loadTable();
        }

        private void Admin_UpdateTable(object sender, EventArgs e)
        {
            loadCBTable(cbSwitch);
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
            loadTable();
        }

        private void Admin_InsertTable(object sender, EventArgs e)
        {
            loadCBTable(cbSwitch);
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
            loadTable();
        }

        private void Admin_DeleteCategory(object sender, EventArgs e)
        {
            loadCategory();
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
            loadTable();
        }

        private void Admin_UpdateCategory(object sender, EventArgs e)
        {
            loadCategory();
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
        }

        private void Admin_InsertCategory(object sender, EventArgs e)
        {
            loadCategory();
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
        }

        private void Admin_UpdateDrink(object sender, EventArgs e)
        {
            loadDrinkListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
        }

        private void Admin_DeleteDrink(object sender, EventArgs e)
        {
            loadDrinkListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
            loadTable();
        }

        private void Admin_InsertDrink(object sender, EventArgs e)
        {
            loadDrinkListByCategory((cbCategory.SelectedItem as Category).ID);
            if (lvList.Tag != null) showBill((lvList.Tag as Table).ID);
        }

        private void userInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile profile = new fProfile(loginAccount);
            profile.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            loadDrinkListByCategory(id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Table table = lvList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose table!");
                return;
            }
            int iDBill = BillDAO.Instance.getUncheckBillIDByTableID(table.ID);
            int iDDrink = (cbDrink.SelectedItem as Drink).ID;
            int count = (int)nmDrinkCount.Value;
            int discount = (int)nmDiscount.Value;
            if (iDBill == -1)
            {
                BillDAO.Instance.insertBill(table.ID);
                BillInfoDAO.Instance.insertBillInfo(BillDAO.Instance.getMaxIDBill(), iDDrink, count);
            }
            else
            {
                BillInfoDAO.Instance.insertBillInfo(iDBill, iDDrink, count);
            }
            showBill(table.ID);
            loadTable();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Table table = lvList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose table!");
                return;
            }
            int iDBill = BillDAO.Instance.getUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split('₫')[1]);
            if (iDBill != -1)
            {
                if (MessageBox.Show("Pay " + table.Name, "Payment", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.checkout(iDBill, discount, (float)totalPrice);
                    showBill(table.ID);
                    loadTable();
                }
            }
            nmDiscount.Value = 0;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vni-vn");
            txtTotalPrice.Text = (Convert.ToDouble(txtTotalPrice.Text.Split('₫')[1]) * (1 - (Convert.ToDouble(nmDiscount.Value) / 100))).ToString("c", culture);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int id1 = (lvList.Tag as Table).ID;
            int id2 = (cbSwitch.SelectedItem as Table).ID;
            if (MessageBox.Show("Switch Table " + id1 + " into Table " + id2, "Switch", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAO.Instance.switchTable(id1, id2);
                loadTable();
            }
            showBill(id1);
        }
        #endregion
    }
}
