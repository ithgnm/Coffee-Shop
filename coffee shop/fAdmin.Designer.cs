namespace coffee_shop
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBillShow = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.tpDrink = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudDrinkPrice = new System.Windows.Forms.NumericUpDown();
            this.cbDrinkCategory = new System.Windows.Forms.ComboBox();
            this.lbDrinkPrice = new System.Windows.Forms.Label();
            this.lbDrinkCategory = new System.Windows.Forms.Label();
            this.lbDrinkDrink = new System.Windows.Forms.Label();
            this.lbDrinkID = new System.Windows.Forms.Label();
            this.txtDrink = new System.Windows.Forms.TextBox();
            this.txtDrinkID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDrinkFind = new System.Windows.Forms.TextBox();
            this.btnDrinkFind = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDrinkUpdate = new System.Windows.Forms.Button();
            this.btnDrinkRemove = new System.Windows.Forms.Button();
            this.btnDrinkAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbCategoryCategory = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tbCategoryID = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryRemove = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbTableStatus = new System.Windows.Forms.ComboBox();
            this.lbTableStatus = new System.Windows.Forms.Label();
            this.lbTableName = new System.Windows.Forms.Label();
            this.lbTableID = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.tbTableID = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnTableUpdate = new System.Windows.Forms.Button();
            this.btnTableRemove = new System.Windows.Forms.Button();
            this.btnTableAdd = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnAccountResetPassword = new System.Windows.Forms.Button();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.lbAccountID = new System.Windows.Forms.Label();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tbAccountID = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnAccountUpdate = new System.Windows.Forms.Button();
            this.btnAccountRemove = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpDrink.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            this.tpCategory.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tpTable.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.tpAccount.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpDrink);
            this.tcAdmin.Controls.Add(this.tpCategory);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(13, 13);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(535, 372);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.dgvBill);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(527, 346);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Bill";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(6, 36);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(515, 304);
            this.dgvBill.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBillShow);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 27);
            this.panel1.TabIndex = 0;
            // 
            // btnBillShow
            // 
            this.btnBillShow.Location = new System.Drawing.Point(415, 1);
            this.btnBillShow.Name = "btnBillShow";
            this.btnBillShow.Size = new System.Drawing.Size(103, 23);
            this.btnBillShow.TabIndex = 2;
            this.btnBillShow.Text = "Show";
            this.btnBillShow.UseVisualStyleBackColor = true;
            this.btnBillShow.Click += new System.EventHandler(this.btnBillShow_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = false;
            this.dtpTo.Location = new System.Drawing.Point(209, 3);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 0;
            this.dtpTo.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = false;
            this.dtpFrom.Location = new System.Drawing.Point(3, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.Value = new System.DateTime(2019, 5, 17, 0, 0, 0, 0);
            // 
            // tpDrink
            // 
            this.tpDrink.Controls.Add(this.panel3);
            this.tpDrink.Controls.Add(this.panel5);
            this.tpDrink.Controls.Add(this.panel4);
            this.tpDrink.Controls.Add(this.panel2);
            this.tpDrink.Location = new System.Drawing.Point(4, 22);
            this.tpDrink.Name = "tpDrink";
            this.tpDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tpDrink.Size = new System.Drawing.Size(527, 346);
            this.tpDrink.TabIndex = 1;
            this.tpDrink.Text = "Drink";
            this.tpDrink.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudDrinkPrice);
            this.panel3.Controls.Add(this.cbDrinkCategory);
            this.panel3.Controls.Add(this.lbDrinkPrice);
            this.panel3.Controls.Add(this.lbDrinkCategory);
            this.panel3.Controls.Add(this.lbDrinkDrink);
            this.panel3.Controls.Add(this.lbDrinkID);
            this.panel3.Controls.Add(this.txtDrink);
            this.panel3.Controls.Add(this.txtDrinkID);
            this.panel3.Location = new System.Drawing.Point(298, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 298);
            this.panel3.TabIndex = 1;
            // 
            // nudDrinkPrice
            // 
            this.nudDrinkPrice.Location = new System.Drawing.Point(76, 125);
            this.nudDrinkPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDrinkPrice.Name = "nudDrinkPrice";
            this.nudDrinkPrice.Size = new System.Drawing.Size(128, 20);
            this.nudDrinkPrice.TabIndex = 8;
            // 
            // cbDrinkCategory
            // 
            this.cbDrinkCategory.FormattingEnabled = true;
            this.cbDrinkCategory.Location = new System.Drawing.Point(76, 87);
            this.cbDrinkCategory.Name = "cbDrinkCategory";
            this.cbDrinkCategory.Size = new System.Drawing.Size(128, 21);
            this.cbDrinkCategory.TabIndex = 7;
            // 
            // lbDrinkPrice
            // 
            this.lbDrinkPrice.AutoSize = true;
            this.lbDrinkPrice.Location = new System.Drawing.Point(12, 127);
            this.lbDrinkPrice.Name = "lbDrinkPrice";
            this.lbDrinkPrice.Size = new System.Drawing.Size(34, 13);
            this.lbDrinkPrice.TabIndex = 4;
            this.lbDrinkPrice.Text = "Price:";
            // 
            // lbDrinkCategory
            // 
            this.lbDrinkCategory.AutoSize = true;
            this.lbDrinkCategory.Location = new System.Drawing.Point(12, 90);
            this.lbDrinkCategory.Name = "lbDrinkCategory";
            this.lbDrinkCategory.Size = new System.Drawing.Size(52, 13);
            this.lbDrinkCategory.TabIndex = 4;
            this.lbDrinkCategory.Text = "Category:";
            // 
            // lbDrinkDrink
            // 
            this.lbDrinkDrink.AutoSize = true;
            this.lbDrinkDrink.Location = new System.Drawing.Point(12, 53);
            this.lbDrinkDrink.Name = "lbDrinkDrink";
            this.lbDrinkDrink.Size = new System.Drawing.Size(35, 13);
            this.lbDrinkDrink.TabIndex = 4;
            this.lbDrinkDrink.Text = "Drink:";
            // 
            // lbDrinkID
            // 
            this.lbDrinkID.AutoSize = true;
            this.lbDrinkID.Location = new System.Drawing.Point(12, 18);
            this.lbDrinkID.Name = "lbDrinkID";
            this.lbDrinkID.Size = new System.Drawing.Size(21, 13);
            this.lbDrinkID.TabIndex = 4;
            this.lbDrinkID.Text = "ID:";
            // 
            // txtDrink
            // 
            this.txtDrink.Location = new System.Drawing.Point(76, 50);
            this.txtDrink.Name = "txtDrink";
            this.txtDrink.Size = new System.Drawing.Size(128, 20);
            this.txtDrink.TabIndex = 6;
            // 
            // txtDrinkID
            // 
            this.txtDrinkID.Location = new System.Drawing.Point(76, 15);
            this.txtDrinkID.Name = "txtDrinkID";
            this.txtDrinkID.ReadOnly = true;
            this.txtDrinkID.Size = new System.Drawing.Size(128, 20);
            this.txtDrinkID.TabIndex = 5;
            this.txtDrinkID.TextChanged += new System.EventHandler(this.txtDrinkID_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtDrinkFind);
            this.panel5.Controls.Add(this.btnDrinkFind);
            this.panel5.Location = new System.Drawing.Point(298, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 30);
            this.panel5.TabIndex = 0;
            // 
            // txtDrinkFind
            // 
            this.txtDrinkFind.Location = new System.Drawing.Point(15, 5);
            this.txtDrinkFind.Name = "txtDrinkFind";
            this.txtDrinkFind.Size = new System.Drawing.Size(100, 20);
            this.txtDrinkFind.TabIndex = 3;
            // 
            // btnDrinkFind
            // 
            this.btnDrinkFind.Location = new System.Drawing.Point(129, 3);
            this.btnDrinkFind.Name = "btnDrinkFind";
            this.btnDrinkFind.Size = new System.Drawing.Size(75, 23);
            this.btnDrinkFind.TabIndex = 4;
            this.btnDrinkFind.Text = "Find";
            this.btnDrinkFind.UseVisualStyleBackColor = true;
            this.btnDrinkFind.Click += new System.EventHandler(this.btnDrinkFind_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDrinkUpdate);
            this.panel4.Controls.Add(this.btnDrinkRemove);
            this.panel4.Controls.Add(this.btnDrinkAdd);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 30);
            this.panel4.TabIndex = 0;
            // 
            // btnDrinkUpdate
            // 
            this.btnDrinkUpdate.Location = new System.Drawing.Point(208, 3);
            this.btnDrinkUpdate.Name = "btnDrinkUpdate";
            this.btnDrinkUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDrinkUpdate.TabIndex = 2;
            this.btnDrinkUpdate.Text = "Update";
            this.btnDrinkUpdate.UseVisualStyleBackColor = true;
            this.btnDrinkUpdate.Click += new System.EventHandler(this.btnDrinkUpdate_Click);
            // 
            // btnDrinkRemove
            // 
            this.btnDrinkRemove.Location = new System.Drawing.Point(107, 3);
            this.btnDrinkRemove.Name = "btnDrinkRemove";
            this.btnDrinkRemove.Size = new System.Drawing.Size(75, 23);
            this.btnDrinkRemove.TabIndex = 1;
            this.btnDrinkRemove.Text = "Remove";
            this.btnDrinkRemove.UseVisualStyleBackColor = true;
            this.btnDrinkRemove.Click += new System.EventHandler(this.btnDrinkRemove_Click);
            // 
            // btnDrinkAdd
            // 
            this.btnDrinkAdd.Location = new System.Drawing.Point(4, 3);
            this.btnDrinkAdd.Name = "btnDrinkAdd";
            this.btnDrinkAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDrinkAdd.TabIndex = 0;
            this.btnDrinkAdd.Text = "Add";
            this.btnDrinkAdd.UseVisualStyleBackColor = true;
            this.btnDrinkAdd.Click += new System.EventHandler(this.btnDrinkAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDrink);
            this.panel2.Location = new System.Drawing.Point(6, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 298);
            this.panel2.TabIndex = 0;
            // 
            // dgvDrink
            // 
            this.dgvDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Location = new System.Drawing.Point(4, 4);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.Size = new System.Drawing.Size(279, 291);
            this.dgvDrink.TabIndex = 0;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.panel6);
            this.tpCategory.Controls.Add(this.panel8);
            this.tpCategory.Controls.Add(this.panel9);
            this.tpCategory.Location = new System.Drawing.Point(4, 22);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(527, 346);
            this.tpCategory.TabIndex = 3;
            this.tpCategory.Text = "Category";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbCategoryCategory);
            this.panel6.Controls.Add(this.lbCategoryID);
            this.panel6.Controls.Add(this.tbCategoryName);
            this.panel6.Controls.Add(this.tbCategoryID);
            this.panel6.Location = new System.Drawing.Point(298, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 298);
            this.panel6.TabIndex = 5;
            // 
            // lbCategoryCategory
            // 
            this.lbCategoryCategory.AutoSize = true;
            this.lbCategoryCategory.Location = new System.Drawing.Point(12, 53);
            this.lbCategoryCategory.Name = "lbCategoryCategory";
            this.lbCategoryCategory.Size = new System.Drawing.Size(52, 13);
            this.lbCategoryCategory.TabIndex = 4;
            this.lbCategoryCategory.Text = "Category:";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(12, 18);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(21, 13);
            this.lbCategoryID.TabIndex = 4;
            this.lbCategoryID.Text = "ID:";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(76, 50);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(128, 20);
            this.tbCategoryName.TabIndex = 3;
            // 
            // tbCategoryID
            // 
            this.tbCategoryID.Location = new System.Drawing.Point(76, 15);
            this.tbCategoryID.Name = "tbCategoryID";
            this.tbCategoryID.ReadOnly = true;
            this.tbCategoryID.Size = new System.Drawing.Size(128, 20);
            this.tbCategoryID.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnCategoryUpdate);
            this.panel8.Controls.Add(this.btnCategoryRemove);
            this.panel8.Controls.Add(this.btnCategoryAdd);
            this.panel8.Location = new System.Drawing.Point(6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(286, 30);
            this.panel8.TabIndex = 3;
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(208, 3);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryUpdate.TabIndex = 0;
            this.btnCategoryUpdate.Text = "Update";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryRemove
            // 
            this.btnCategoryRemove.Location = new System.Drawing.Point(107, 3);
            this.btnCategoryRemove.Name = "btnCategoryRemove";
            this.btnCategoryRemove.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryRemove.TabIndex = 0;
            this.btnCategoryRemove.Text = "Remove";
            this.btnCategoryRemove.UseVisualStyleBackColor = true;
            this.btnCategoryRemove.Click += new System.EventHandler(this.btnCategoryRemove_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(4, 3);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryAdd.TabIndex = 0;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgvCategory);
            this.panel9.Location = new System.Drawing.Point(6, 42);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(286, 298);
            this.panel9.TabIndex = 4;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(4, 4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(279, 291);
            this.dgvCategory.TabIndex = 0;
            // 
            // tpTable
            // 
            this.tpTable.Controls.Add(this.panel7);
            this.tpTable.Controls.Add(this.panel10);
            this.tpTable.Controls.Add(this.panel11);
            this.tpTable.Location = new System.Drawing.Point(4, 22);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(527, 346);
            this.tpTable.TabIndex = 4;
            this.tpTable.Text = "Table";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbTableStatus);
            this.panel7.Controls.Add(this.lbTableStatus);
            this.panel7.Controls.Add(this.lbTableName);
            this.panel7.Controls.Add(this.lbTableID);
            this.panel7.Controls.Add(this.tbTableName);
            this.panel7.Controls.Add(this.tbTableID);
            this.panel7.Location = new System.Drawing.Point(298, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 298);
            this.panel7.TabIndex = 4;
            // 
            // cbTableStatus
            // 
            this.cbTableStatus.FormattingEnabled = true;
            this.cbTableStatus.Location = new System.Drawing.Point(76, 87);
            this.cbTableStatus.Name = "cbTableStatus";
            this.cbTableStatus.Size = new System.Drawing.Size(128, 21);
            this.cbTableStatus.TabIndex = 5;
            // 
            // lbTableStatus
            // 
            this.lbTableStatus.AutoSize = true;
            this.lbTableStatus.Location = new System.Drawing.Point(12, 90);
            this.lbTableStatus.Name = "lbTableStatus";
            this.lbTableStatus.Size = new System.Drawing.Size(40, 13);
            this.lbTableStatus.TabIndex = 4;
            this.lbTableStatus.Text = "Status:";
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Location = new System.Drawing.Point(12, 53);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(37, 13);
            this.lbTableName.TabIndex = 4;
            this.lbTableName.Text = "Table:";
            // 
            // lbTableID
            // 
            this.lbTableID.AutoSize = true;
            this.lbTableID.Location = new System.Drawing.Point(12, 18);
            this.lbTableID.Name = "lbTableID";
            this.lbTableID.Size = new System.Drawing.Size(21, 13);
            this.lbTableID.TabIndex = 4;
            this.lbTableID.Text = "ID:";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(76, 50);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(128, 20);
            this.tbTableName.TabIndex = 3;
            // 
            // tbTableID
            // 
            this.tbTableID.Location = new System.Drawing.Point(76, 15);
            this.tbTableID.Name = "tbTableID";
            this.tbTableID.ReadOnly = true;
            this.tbTableID.Size = new System.Drawing.Size(128, 20);
            this.tbTableID.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnTableUpdate);
            this.panel10.Controls.Add(this.btnTableRemove);
            this.panel10.Controls.Add(this.btnTableAdd);
            this.panel10.Location = new System.Drawing.Point(6, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(286, 30);
            this.panel10.TabIndex = 2;
            // 
            // btnTableUpdate
            // 
            this.btnTableUpdate.Location = new System.Drawing.Point(208, 3);
            this.btnTableUpdate.Name = "btnTableUpdate";
            this.btnTableUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTableUpdate.TabIndex = 0;
            this.btnTableUpdate.Text = "Update";
            this.btnTableUpdate.UseVisualStyleBackColor = true;
            this.btnTableUpdate.Click += new System.EventHandler(this.btnTableUpdate_Click);
            // 
            // btnTableRemove
            // 
            this.btnTableRemove.Location = new System.Drawing.Point(107, 3);
            this.btnTableRemove.Name = "btnTableRemove";
            this.btnTableRemove.Size = new System.Drawing.Size(75, 23);
            this.btnTableRemove.TabIndex = 0;
            this.btnTableRemove.Text = "Remove";
            this.btnTableRemove.UseVisualStyleBackColor = true;
            this.btnTableRemove.Click += new System.EventHandler(this.btnTableRemove_Click);
            // 
            // btnTableAdd
            // 
            this.btnTableAdd.Location = new System.Drawing.Point(4, 3);
            this.btnTableAdd.Name = "btnTableAdd";
            this.btnTableAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTableAdd.TabIndex = 0;
            this.btnTableAdd.Text = "Add";
            this.btnTableAdd.UseVisualStyleBackColor = true;
            this.btnTableAdd.Click += new System.EventHandler(this.btnTableAdd_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvTable);
            this.panel11.Location = new System.Drawing.Point(6, 42);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(286, 298);
            this.panel11.TabIndex = 3;
            // 
            // dgvTable
            // 
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(4, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(279, 291);
            this.dgvTable.TabIndex = 0;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel12);
            this.tpAccount.Controls.Add(this.panel13);
            this.tpAccount.Controls.Add(this.panel14);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(527, 346);
            this.tpAccount.TabIndex = 5;
            this.tpAccount.Text = "Account";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnAccountResetPassword);
            this.panel12.Controls.Add(this.cbAccountType);
            this.panel12.Controls.Add(this.lbAccountType);
            this.panel12.Controls.Add(this.lbAccountName);
            this.panel12.Controls.Add(this.lbAccountID);
            this.panel12.Controls.Add(this.tbAccountName);
            this.panel12.Controls.Add(this.tbAccountID);
            this.panel12.Location = new System.Drawing.Point(298, 42);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(223, 298);
            this.panel12.TabIndex = 4;
            // 
            // btnAccountResetPassword
            // 
            this.btnAccountResetPassword.Location = new System.Drawing.Point(15, 126);
            this.btnAccountResetPassword.Name = "btnAccountResetPassword";
            this.btnAccountResetPassword.Size = new System.Drawing.Size(189, 23);
            this.btnAccountResetPassword.TabIndex = 6;
            this.btnAccountResetPassword.Text = "Reset Password";
            this.btnAccountResetPassword.UseVisualStyleBackColor = true;
            this.btnAccountResetPassword.Click += new System.EventHandler(this.btnAccountResetPassword_Click);
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(76, 87);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(128, 21);
            this.cbAccountType.TabIndex = 5;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(12, 90);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(34, 13);
            this.lbAccountType.TabIndex = 4;
            this.lbAccountType.Text = "Type:";
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(12, 53);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(38, 13);
            this.lbAccountName.TabIndex = 4;
            this.lbAccountName.Text = "Name:";
            // 
            // lbAccountID
            // 
            this.lbAccountID.AutoSize = true;
            this.lbAccountID.Location = new System.Drawing.Point(12, 18);
            this.lbAccountID.Name = "lbAccountID";
            this.lbAccountID.Size = new System.Drawing.Size(32, 13);
            this.lbAccountID.TabIndex = 4;
            this.lbAccountID.Text = "User:";
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(76, 50);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(128, 20);
            this.tbAccountName.TabIndex = 4;
            // 
            // tbAccountID
            // 
            this.tbAccountID.Location = new System.Drawing.Point(76, 15);
            this.tbAccountID.Name = "tbAccountID";
            this.tbAccountID.Size = new System.Drawing.Size(128, 20);
            this.tbAccountID.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnAccountUpdate);
            this.panel13.Controls.Add(this.btnAccountRemove);
            this.panel13.Controls.Add(this.btnAccountAdd);
            this.panel13.Location = new System.Drawing.Point(6, 6);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(286, 30);
            this.panel13.TabIndex = 2;
            // 
            // btnAccountUpdate
            // 
            this.btnAccountUpdate.Location = new System.Drawing.Point(208, 3);
            this.btnAccountUpdate.Name = "btnAccountUpdate";
            this.btnAccountUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAccountUpdate.TabIndex = 2;
            this.btnAccountUpdate.Text = "Update";
            this.btnAccountUpdate.UseVisualStyleBackColor = true;
            this.btnAccountUpdate.Click += new System.EventHandler(this.btnAccountUpdate_Click);
            // 
            // btnAccountRemove
            // 
            this.btnAccountRemove.Location = new System.Drawing.Point(107, 3);
            this.btnAccountRemove.Name = "btnAccountRemove";
            this.btnAccountRemove.Size = new System.Drawing.Size(75, 23);
            this.btnAccountRemove.TabIndex = 1;
            this.btnAccountRemove.Text = "Remove";
            this.btnAccountRemove.UseVisualStyleBackColor = true;
            this.btnAccountRemove.Click += new System.EventHandler(this.btnAccountRemove_Click);
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Location = new System.Drawing.Point(4, 3);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAccountAdd.TabIndex = 0;
            this.btnAccountAdd.Text = "Add";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.dgvAccount);
            this.panel14.Location = new System.Drawing.Point(6, 42);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(286, 298);
            this.panel14.TabIndex = 3;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(4, 4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(279, 291);
            this.dgvAccount.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 397);
            this.Controls.Add(this.tcAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tpDrink.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            this.tpCategory.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tpTable.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.tpAccount.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpDrink;
        private System.Windows.Forms.Button btnBillShow;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDrinkAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.Button btnDrinkRemove;
        private System.Windows.Forms.TextBox txtDrinkFind;
        private System.Windows.Forms.Button btnDrinkFind;
        private System.Windows.Forms.Button btnDrinkUpdate;
        private System.Windows.Forms.NumericUpDown nudDrinkPrice;
        private System.Windows.Forms.ComboBox cbDrinkCategory;
        private System.Windows.Forms.Label lbDrinkPrice;
        private System.Windows.Forms.Label lbDrinkCategory;
        private System.Windows.Forms.Label lbDrinkDrink;
        private System.Windows.Forms.Label lbDrinkID;
        private System.Windows.Forms.TextBox txtDrink;
        private System.Windows.Forms.TextBox txtDrinkID;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbCategoryCategory;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.TextBox tbCategoryID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryRemove;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbTableStatus;
        private System.Windows.Forms.Label lbTableStatus;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Label lbTableID;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.TextBox tbTableID;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnTableUpdate;
        private System.Windows.Forms.Button btnTableRemove;
        private System.Windows.Forms.Button btnTableAdd;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label lbAccountID;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.TextBox tbAccountID;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnAccountUpdate;
        private System.Windows.Forms.Button btnAccountRemove;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnAccountResetPassword;
        private System.Windows.Forms.TextBox tbCategoryName;
    }
}