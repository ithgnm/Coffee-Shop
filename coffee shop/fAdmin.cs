using coffee_shop.data_access_layer;
using coffee_shop.data_transfer_object;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class fAdmin : Form
    {
        BindingSource drinkList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();

        public Account loginAccount;

        public fAdmin()
        {
            InitializeComponent();
            load();
        }

        #region Methods
        void load()
        {
            loadListBillByDate(dtpFrom.Value, dtpTo.Value);
            dgvDrink.DataSource = drinkList;
            loadListDrink();
            dgvCategory.DataSource = categoryList;
            loadListCategory();
            dgvTable.DataSource = tableList;
            loadListTable();
            loadCategoryIntoCB(cbDrinkCategory);
            loadTableStatusIntoCB(cbTableStatus);
            dgvAccount.DataSource = accountList;
            loadListAccount();
            addDrinkBinding();
            addCategoryBinding();
            addTableBinding();
            addAccountBinding();
            loadAccountTypeIntoCB(cbAccountType);
        }

        void loadListBillByDate(DateTime checkin, DateTime checkout)
        {
            dgvBill.DataSource = BillDAO.Instance.getBillListByDate(checkin, checkout);
        }

        void loadListDrink()
        {
            drinkList.DataSource = DrinkDAO.Instance.getListDrink();
        }

        void loadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.getListCategory();
        }

        void loadListTable()
        {
            tableList.DataSource = TableDAO.Instance.loadTableList();
        }

        void loadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.getListAccount();
        }

        void loadCategoryIntoCB(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.getListCategory();
            cb.DisplayMember = "name";
        }

        void loadTableStatusIntoCB(ComboBox cb)
        {
            cb.Items.Add("Empty");
            cb.Items.Add("Guest");
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

        void addAccountBinding()
        {
            tbAccountID.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "username", true, DataSourceUpdateMode.Never));
            tbAccountName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "displayname", true, DataSourceUpdateMode.Never));
            cbAccountType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "typename", true, DataSourceUpdateMode.Never));
        }

        List<Drink> searchDrinkByName(string name)
        {
            List<Drink> listDrink = DrinkDAO.Instance.searchDrinkByName(name);
            return listDrink;
        }
        #endregion

        #region Events
        private void btnBillShow_Click(object sender, EventArgs e)
        {
            loadListBillByDate(dtpFrom.Value, dtpTo.Value);
        }

        private void txtDrinkID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvDrink.SelectedCells[0].OwningRow.Cells["idcategory"].Value;
                Category category = CategoryDAO.Instance.getListCategoryByID(id);
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

        private void btnDrinkAdd_Click(object sender, EventArgs e)
        {
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            string name = txtDrink.Text;
            float price = (float)nudDrinkPrice.Value;
            if (DrinkDAO.Instance.insertDrink(idCategory, name, price))
            {
                MessageBox.Show("Add drink complete!");
                loadListDrink();
                if (insertDrink != null) insertDrink(this, new EventArgs());
            }
            else MessageBox.Show("Fail to add drink!");
        }

        private void btnDrinkUpdate_Click(object sender, EventArgs e)
        {
            int idCategory = (cbDrinkCategory.SelectedItem as Category).ID;
            string name = txtDrink.Text;
            float price = (float)nudDrinkPrice.Value;
            int id = Convert.ToInt32(txtDrinkID.Text);
            if (DrinkDAO.Instance.updateDrink(id, idCategory, name, price))
            {
                MessageBox.Show("Update drink complete!");
                loadListDrink();
                if (updateDrink != null) updateDrink(this, new EventArgs());
            }
            else MessageBox.Show("Fail to update drink!");
        }

        private void btnDrinkRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDrinkID.Text);
            if (DrinkDAO.Instance.deleteDrink(id))
            {
                MessageBox.Show("Remove drink complete!");
                loadListDrink();
                if (deleteDrink != null) deleteDrink(this, new EventArgs());
            }
            else MessageBox.Show("Fail to remove drink!");
        }

        private event EventHandler insertDrink;
        public event EventHandler InsertDrink
        {
            add { insertDrink += value; }
            remove { insertDrink -= value; }
        }

        private event EventHandler updateDrink;
        public event EventHandler UpdateDrink
        {
            add { updateDrink += value; }
            remove { updateDrink -= value; }
        }

        private event EventHandler deleteDrink;
        public event EventHandler DeleteDrink
        {
            add { deleteDrink += value; }
            remove { deleteDrink -= value; }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string name = tbCategoryName.Text;
            if (CategoryDAO.Instance.insertCategory(name))
            {
                MessageBox.Show("Add category complete!");
                loadListCategory();
                if (insertCategory != null) insertCategory(this, new EventArgs());
            }
            else MessageBox.Show("Fail to add category!");
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbCategoryID.Text);
            string name = tbCategoryName.Text;
            if (CategoryDAO.Instance.updateCategory(id, name))
            {
                MessageBox.Show("Update category complete!");
                loadListCategory();
                if (updateCategory != null) updateCategory(this, new EventArgs());
            }
            else MessageBox.Show("Fail to update category!");
        }

        private void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbCategoryID.Text);
            if (CategoryDAO.Instance.deleteCategory(id))
            {
                MessageBox.Show("Remove category complete!");
                loadListCategory();
                if (deleteCategory != null) deleteCategory(this, new EventArgs());
            }
            else MessageBox.Show("Fail to remove category!");
        }

        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            string name = tbTableName.Text;
            if (TableDAO.Instance.insertTable(name))
            {
                MessageBox.Show("Add table complete!");
                loadListTable();
                if (insertTable != null) insertTable(this, new EventArgs());
            }
            else MessageBox.Show("Fail to add table!");
        }

        private void btnTableUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableID.Text);
            string name = tbTableName.Text;
            string status = cbTableStatus.Text;
            if (TableDAO.Instance.updateTable(id, name, status))
            {
                MessageBox.Show("Update table complete!");
                loadListTable();
                if (updateTable != null) updateTable(this, new EventArgs());
            }
            else MessageBox.Show("Fail to update table!");
        }

        private void btnTableRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbTableID.Text);
            if (TableDAO.Instance.removeTable(id))
            {
                MessageBox.Show("Remove table complete!");
                loadListTable();
                if (updateTable != null) updateTable(this, new EventArgs());
            }
            else MessageBox.Show("Fail to update table!");
        }

        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
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
                if (AccountDAO.Instance.insertAccount(userName, displayName, type, typeName))
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
            if (AccountDAO.Instance.updateAccount(userName, displayName, type, typeName))
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
                if (AccountDAO.Instance.deleteAccount(userName))
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
            if (AccountDAO.Instance.resetPasswordAccount(userName))
            {
                MessageBox.Show("Reset password complete!");
                loadListAccount();
            }
            else MessageBox.Show("Fail to reset password!");
        }
        #endregion
    }
}
