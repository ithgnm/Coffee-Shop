using business_logic_layer;
using data_transfer_object;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class fAdmin : Form
    {
        private BindingSource drinkList = new BindingSource();
        private BindingSource categoryList = new BindingSource();
        private BindingSource tableList = new BindingSource();
        private BindingSource areaList = new BindingSource();
        private BindingSource accountList = new BindingSource();

        private AccountBLL accBLL = new AccountBLL();
        private TableBLL tbBLL = new TableBLL();
        private CategoryBLL cgBLL = new CategoryBLL();
        private DrinkBLL drBLL = new DrinkBLL();
        private BillBLL bBLL = new BillBLL();
        private AreaBLL arBLL = new AreaBLL();

        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();
            loadForm();
        }

        #region Methods
        void loadForm()
        {
            loadCurrentDateIntoDTP();
            loadListBillByDate(dtpFrom.Value, dtpTo.Value);
            dgvDrink.DataSource = drinkList;
            loadListDrink();
            dgvCategory.DataSource = categoryList;
            loadListCategory();
            dgvTable.DataSource = tableList;
            loadListTable();
            loadCategoryIntoCB(cbDrinkCategory);
            loadTableStatusIntoCB(cbTableStatus);
            dgvArea.DataSource = areaList;
            loadAreaIntoCB(cbTableArea);
            loadListArea();
            addAreaBinding();
            dgvAccount.DataSource = accountList;
            loadListAccount();
            addDrinkBinding();
            addCategoryBinding();
            addTableBinding();
            addAccountBinding();
            loadAccountTypeIntoCB(cbAccountType);
        }

        public void loadCurrentDateIntoDTP()
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        void loadListBillByDate(DateTime checkin, DateTime checkout)
        {
            dgvBill.DataSource = bBLL.getBillListByDate(checkin, checkout);
        }

        void loadListDrink()
        {
            drinkList.DataSource = drBLL.getListDrink();
        }

        void loadListCategory()
        {
            categoryList.DataSource = cgBLL.getListCategory();
        }

        void loadListTable()
        {
            tableList.DataSource = tbBLL.getListTable();
        }

        void loadListArea()
        {
            areaList.DataSource = arBLL.getListArea();
        }

        void loadListAccount()
        {
            accountList.DataSource = accBLL.getListAccount();
        }

        void loadCategoryIntoCB(ComboBox cb)
        {
            cb.DataSource = cgBLL.getListCategory();
            cb.DisplayMember = "name";
        }

        void loadAreaIntoCB(ComboBox cb)
        {
            cb.DataSource = arBLL.getListArea();
            cb.DisplayMember = "name";
        }

        void loadTableStatusIntoCB(ComboBox cb)
        {
            cb.Items.Add("Empty");
            cb.Items.Add("Guest");
            cb.Items.Add("Booking");
        }

        void loadAccountTypeIntoCB(ComboBox cb)
        {
            cb.Items.Add("admin");
            cb.Items.Add("staff");
        }

        void addDrinkBinding()
        {
            txtDrinkID.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtDrink.DataBindings.Add(new Binding("Text", dgvDrink.DataSource, "name", true, DataSourceUpdateMode.Never));
            nudDrinkPrice.DataBindings.Add(new Binding("Value", dgvDrink.DataSource, "price", true, DataSourceUpdateMode.Never));
        }

        void addTableBinding()
        {
            tbTableID.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbTableName.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "name", true, DataSourceUpdateMode.Never));
            cbTableStatus.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "status", true, DataSourceUpdateMode.Never));
        }

        void addCategoryBinding()
        {
            tbCategoryID.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        void addAreaBinding()
        {
            txtAreaID.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtAreaName.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "name", true, DataSourceUpdateMode.Never));
        }

        void addAccountBinding()
        {
            tbAccountID.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            tbAccountName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            cbAccountType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "typename", true, DataSourceUpdateMode.Never));
        }

        List<Drink> searchDrinkByName(string name)
        {
            List<Drink> listDrink = drBLL.searchDrinkByName(name);
            return listDrink;
        }
        #endregion

        #region Events
        private event FormClosedEventHandler formClosed;
        public event FormClosedEventHandler FormCloed
        {
            add { formClosed += value; }
            remove { formClosed -= value; }
        }

        private void btnBillShow_Click(object sender, EventArgs e)
        {
            loadListBillByDate(dtpFrom.Value, dtpTo.Value);
        }

        private void txtDrinkID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvDrink.SelectedCells[0].OwningRow.Cells["idcategory"].Value;
                Category category = cgBLL.getListCategoryByID(id);
                cbDrinkCategory.SelectedItem = category;
                int index = -1, i = 0;
                foreach (Category item in cbDrinkCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbDrinkCategory.SelectedIndex = index;
            }
            catch { }
        }

        private void tbTableID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvTable.SelectedCells[0].OwningRow.Cells["idarea"].Value;
                Area area = arBLL.getListAreaByID(id);
                cbTableArea.SelectedItem = area;
                int index = -1, i = 0;
                foreach (Area item in cbTableArea.Items)
                {
                    if (item.ID == area.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbTableArea.SelectedIndex = index;
            }
            catch { }
        }

        private void btnDrinkAdd_Click(object sender, EventArgs e)
        {
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            string name = txtDrink.Text;
            float price = (float)nudDrinkPrice.Value;
            if (drBLL.insertDrink(idCategory, name, price))
            {
                MessageBox.Show("Add drink complete!");
                loadListDrink();
            }
            else MessageBox.Show("Fail to add drink!");
        }

        private void btnDrinkUpdate_Click(object sender, EventArgs e)
        {
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            string name = txtDrink.Text;
            float price = (float)nudDrinkPrice.Value;
            int id = Convert.ToInt32(txtDrinkID.Text);
            if (drBLL.updateDrink(id, idCategory, name, price))
            {
                MessageBox.Show("Update drink complete!");
                loadListDrink();
            }
            else MessageBox.Show("Fail to update drink!");
        }

        private void btnDrinkRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDrinkID.Text);
            if (drBLL.deleteDrink(id))
            {
                MessageBox.Show("Remove drink complete!");
                loadListDrink();
            }
            else MessageBox.Show("Fail to remove drink!");
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string name = tbCategoryName.Text;
            if (cgBLL.insertCategory(name))
            {
                MessageBox.Show("Add category complete!");
                loadListCategory();
                loadCategoryIntoCB(cbDrinkCategory);
            }
            else MessageBox.Show("Fail to add category!");
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbCategoryID.Text);
            string name = tbCategoryName.Text;
            if (cgBLL.updateCategory(id, name))
            {
                MessageBox.Show("Update category complete!");
                loadListCategory();
                loadCategoryIntoCB(cbDrinkCategory);
                loadListDrink();
            }
            else MessageBox.Show("Fail to update category!");
        }

        private void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbCategoryID.Text);
            if (cgBLL.deleteCategory(id))
            {
                MessageBox.Show("Remove category complete!");
                loadListCategory();
                loadCategoryIntoCB(cbDrinkCategory);
                loadListDrink();
            }
            else MessageBox.Show("Fail to remove category!");
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            int idarea = (cbTableArea.SelectedItem as Area).ID;
            string name = tbTableName.Text;
            if (tbBLL.insertTable(name, idarea))
            {
                MessageBox.Show("Add table complete!");
                loadListTable();
            }
            else MessageBox.Show("Fail to add table!");
        }

        private void btnTableUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableID.Text);
            string name = tbTableName.Text;
            string status = cbTableStatus.Text;
            int idarea = (cbTableArea.SelectedItem as Area).ID;
            if (tbBLL.updateTable(id, name, status, idarea))
            {
                MessageBox.Show("Update table complete!");
                loadListTable();
            }
            else MessageBox.Show("Fail to update table!");
        }

        private void btnTableRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableID.Text);
            if (tbBLL.removeTable(id))
            {
                MessageBox.Show("Remove table complete!");
                loadListTable();
            }
            else MessageBox.Show("Fail to update table!");
        }

        private void btnAreaAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAreaID.Text);
            string name = txtAreaName.Text;
            if (arBLL.insertArea(name))
            {
                MessageBox.Show("Add area complete!");
                loadListArea();
                loadAreaIntoCB(cbTableArea);
                loadListTable();
            }
            else MessageBox.Show("Fail to add area!");
        }

        private void btAreaRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAreaID.Text);
            if (arBLL.deleteArea(id))
            {
                MessageBox.Show("Remove area complete!");
                loadListArea();
                loadAreaIntoCB(cbTableArea);
                loadListTable();
            }
            else MessageBox.Show("Fail to remove area!");
        }

        private void btnAreaUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtAreaID.Text);
            string name = txtAreaName.Text;
            if (arBLL.updateArea(id, name))
            {
                MessageBox.Show("Update area complete!");
                loadListArea();
                loadAreaIntoCB(cbTableArea);
                loadListTable();
            }
            else MessageBox.Show("Fail to update area!");
        }

        private void btnDrinkFind_Click(object sender, EventArgs e)
        {
            drinkList.DataSource = searchDrinkByName(txtDrinkFind.Text);
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = tbAccountID.Text;
                string displayName = tbAccountName.Text;
                string typeName = cbAccountType.Text;
                int type = new int();
                if (typeName == "admin") type = 1;
                else type = 0;
                if (accBLL.insertAccount(userName, displayName, type, typeName))
                {
                    MessageBox.Show("Add account complete!");
                    loadListAccount();
                }
                else MessageBox.Show("Fail to add account!");
            }
            catch
            {
                MessageBox.Show("Username is existed!");
            }
        }

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            string userName = tbAccountID.Text;
            string displayName = tbAccountName.Text;
            string typeName = cbAccountType.Text;
            int type = new int();
            if (typeName == "admin") type = 1;
            else type = 0;
            if (accBLL.updateAccount(userName, displayName, type, typeName))
            {
                MessageBox.Show("Update account complete!");
                loadListAccount();
            }
            else MessageBox.Show("Cannot change user name!");
        }

        private void btnAccountRemove_Click(object sender, EventArgs e)
        {
            string userName = tbAccountID.Text;
            if (userName.Equals(loginAccount.UserName))
            {
                MessageBox.Show("Cannot delete current account!");
                return;
            }
            else
            {
                if (accBLL.deleteAccount(userName))
                {
                    MessageBox.Show("Remove account complete!");
                    loadListAccount();
                }
                else MessageBox.Show("Fail to remove account!");
            }
        }

        private void btnAccountResetPassword_Click(object sender, EventArgs e)
        {
            string userName = tbAccountID.Text;
            if (accBLL.resetPasswordAccount(userName))
            {
                MessageBox.Show("Reset password complete!");
                loadListAccount();
            }
            else MessageBox.Show("Fail to reset password!");
        }
        #endregion
    }
}
