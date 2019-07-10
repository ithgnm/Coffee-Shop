using business_logic_layer;
using data_transfer_object;
using crystal_report;
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

        private TableBLL tbBLL = new TableBLL();
        private CategoryBLL cgBLL = new CategoryBLL();
        private DrinkBLL drBLL = new DrinkBLL();
        private MenuBLL mnBLL = new MenuBLL();
        private BillBLL bBLL = new BillBLL();
        private BillInfoBLL biBLL = new BillInfoBLL();
        private AreaBLL arBLL = new AreaBLL();

        private bool isChange = false;
        private float totalPrice;
        private TabControl tcTable;
        private TabPage tpTable;
        private int areaSelected;

        public fCoffee(Account account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            loadTable();
            loadCBTable(cbSwitch);
        }

        #region Method
        public void changeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            customerInfomationToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }

        public void loadTable()
        {
            flpCoffee.Controls.Clear();
            tcTable = new TabControl() { Width = flpCoffee.Width - 6, Height = flpCoffee.Height - 6 };
            List<Area> listArea = arBLL.getListArea();
            foreach (Area area in listArea)
            {
                bool isGuest = false, isBooking = false;
                tpTable = new TabPage() { Text = area.Name, Tag = area };
                FlowLayoutPanel flp = new FlowLayoutPanel() { Width = tcTable.Width, Height = tcTable.Height };
                List<Table> listTable = tbBLL.getListTableByAreaID(area.ID);
                foreach (Table item in listTable)
                {
                    Button btnTable = new Button() { Width = TableBLL.tableWidth, Height = TableBLL.tableHeight };
                    btnTable.Text = item.Name + Environment.NewLine + item.Status;
                    btnTable.Click += btnTable_Click;
                    btnTable.Tag = item;
                    switch (item.Status)
                    {
                        case "Booking":
                            isBooking = true;
                            btnTable.BackColor = Color.LightBlue;
                            break;
                        case "Guest":
                            isGuest = true;
                            btnTable.BackColor = Color.LightPink;
                            break;
                        default:
                            break;
                    }
                    flp.Controls.Add(btnTable);
                }
                if (isGuest) tpTable.Text += " (Guest)";
                if (isBooking) tpTable.Text += " (Booking)";
                tpTable.Controls.Add(flp);
                tcTable.Controls.Add(tpTable);
            }
            flpCoffee.Controls.Add(tcTable);
        }

        public void loadDrink()
        {
            flpCoffee.Controls.Clear();
            List<Category> listCategory = cgBLL.getListCategory();
            Control lastControl = null;
            foreach (Category cg in listCategory)
            {
                int index = 1;
                Label lbEmpty = new Label() { Width = DrinkBLL.drinkWidth, Height = DrinkBLL.drinkHeight };
                flpCoffee.Controls.Add(lbEmpty);
                Label lbCategory = new Label()
                {
                    Text = cg.Name,
                    Width = DrinkBLL.drinkWidth,
                    Height = DrinkBLL.drinkHeight,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold)
                };
                flpCoffee.Controls.Add(lbCategory);
                flpCoffee.SetFlowBreak(lbCategory, true);
                List<Drink> listDrink = drBLL.getDrinkByIDCatogery(cg.ID);
                foreach (Drink dr in listDrink)
                {
                    Button btnDrink = new Button() { Width = DrinkBLL.drinkWidth, Height = DrinkBLL.drinkHeight };
                    btnDrink.Text = dr.Name + Environment.NewLine + dr.Price + " đ";
                    btnDrink.MouseUp += btnDrink_MouseUp;
                    btnDrink.Tag = dr;
                    loadSelectedDrink(dr, btnDrink);
                    flpCoffee.Controls.Add(btnDrink);
                    if (index == listDrink.Count) lastControl = btnDrink;
                    index++;
                }
                flpCoffee.SetFlowBreak(lastControl, true);
            }
        }

        public void loadSelectedDrink(Drink dr, Button btn)
        {
            Table table = lvList.Tag as Table;
            if (table != null)
            {
                for (int i = 0; i < lvList.Items.Count; i++)
                {
                    string drinkName = lvList.Items[i].Text;
                    if (dr.Name == drinkName) btn.BackColor = Color.LightGreen;
                }
            }
        }

        public void showBill(int id)
        {
            lvList.Items.Clear();
            List<data_transfer_object.Menu> listBillInfo = mnBLL.getListMenuByTable(id);
            totalPrice = 0;
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

        public void loadCBTable(ComboBox cb)
        {
            List<Table> tableList = tbBLL.getListTable();
            List<Area> areaList = arBLL.getListArea();
            foreach (Area ar in areaList)
                foreach (Table tb in tableList)
                    if (tb.IDArea == ar.ID) tb.Name += " - " + ar.Name;
            cb.DataSource = tableList;
            cb.DisplayMember = "Name";
        }

        public void getReport(Table table, int discount, double totalPrice)
        {
            try
            {
                fReport report = new fReport(table.ID, txtCurrentTable.Text, LoginAccount.DisplayName, discount, totalPrice);
                report.ShowDialog();
            }
            catch { MessageBox.Show("Crystal Report is not installed!"); }
        }
        #endregion

        #region Event
        private void btnTable_Click(object sender, EventArgs e)
        {
            Table table = (sender as Button).Tag as Table;
            Area area = tcTable.SelectedTab.Tag as Area;
            lvList.Tag = table;
            showBill(table.ID);
            btnSwitch.Enabled = true;
            btnDiscount.Enabled = true;
            txtCurrentTable.Text = table.Name + " - " + area.Name;
            areaSelected = tcTable.SelectedIndex;
        }

        private void btnDrink_MouseUp(object sender, MouseEventArgs e)
        {
            int iDDrink = ((sender as Button).Tag as Drink).ID;
            Table table = lvList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose table!");
                loadTable();
                btnChange.Text = "Drink";
                isChange = false;
                return;
            }
            int iDBill = bBLL.getUncheckBillIDByTableID(table.ID);
            int count;
            if (e.Button == MouseButtons.Right) count = -1;
            else count = 1;
            if (iDBill == -1)
            {
                bBLL.insertBill(table.ID);
                biBLL.insertBillInfo(bBLL.getMaxIDBill(), iDDrink, count);
            }
            else biBLL.insertBillInfo(iDBill, iDDrink, count);
            showBill(table.ID);
            loadDrink();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin fAdmin = new fAdmin();
            fAdmin.FormClosed += FAdmin_FormClosed;
            fAdmin.ShowDialog();
        }

        private void FAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadTable();
            tcTable.SelectedIndex = areaSelected;
            isChange = false;
            btnChange.Text = "Drink";
            loadCBTable(cbSwitch);
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Table table = lvList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose table!");
                return;
            }
            int iDBill = bBLL.getUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split('₫')[1]);
            if (iDBill != -1 && (lvList.Items.Count > 0 && lvList.Items[0].Text != ""))
            {
                if (MessageBox.Show("Pay " + txtCurrentTable.Text, "Payment", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    getReport(table, discount, totalPrice);
                    bBLL.checkout(iDBill, discount, (float)totalPrice);
                    showBill(table.ID);
                    loadTable();
                    tcTable.SelectedIndex = areaSelected;
                    btnChange.Text = "Drink";
                    isChange = false;
                    nmDiscount.Value = 0;
                }
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Table table = lvList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose table!");
                return;
            }
            CultureInfo culture = new CultureInfo("vni-vn");
            txtTotalPrice.Text = (Convert.ToDouble(totalPrice) * (1 - (Convert.ToDouble(nmDiscount.Value) / 100))).ToString("c", culture);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Table table = lvList.Tag as Table;
            Area area = tcTable.SelectedTab.Tag as Area;
            if (table == null)
            {
                MessageBox.Show("Choose table!");
                return;
            }
            int id1 = table.ID;
            Table switchTable = cbSwitch.SelectedItem as Table;
            int id2 = switchTable.ID;
            if (MessageBox.Show("Switch " + table.Name + " - " + area.Name + " to " + switchTable.Name, "Switch", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                tbBLL.switchTable(id1, id2);
                loadTable();
                tcTable.SelectedIndex = areaSelected;
            }
            showBill(id1);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!isChange)
            {
                loadDrink();
                btnChange.Text = "Table";
                isChange = true;
            }
            else
            {
                loadTable();
                btnChange.Text = "Drink";
                tcTable.SelectedIndex = areaSelected;
                isChange = false;
            }

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Table table = lvList.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Choose table!");
                return;
            }
            if (table.Status == "Booking")
            {
                if (tbBLL.updateTableStatus(table.ID, "Empty"))
                {
                    MessageBox.Show("Cancel booking complete!");
                    loadTable();
                }
            }
            else if (table.Status == "Guest")
            {
                MessageBox.Show("Table is having customers!");
                return;
            }
            else if (tbBLL.updateTableStatus(table.ID, "Booking"))
            {
                MessageBox.Show("Booking table complete!");
                loadTable();
            }
            else MessageBox.Show("Booking table error!");
        }
        #endregion
    }
}
