namespace coffee_shop
{
    partial class fCoffee
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
            this.msCoffee = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlList = new System.Windows.Forms.Panel();
            this.lvList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.cbSwitch = new System.Windows.Forms.ComboBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlDrink = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmDrinkCount = new System.Windows.Forms.NumericUpDown();
            this.cbDrink = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbProject = new System.Windows.Forms.Label();
            this.txtCurrentTable = new System.Windows.Forms.TextBox();
            this.msCoffee.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.pnlDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).BeginInit();
            this.SuspendLayout();
            // 
            // msCoffee
            // 
            this.msCoffee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.customerInfomationToolStripMenuItem});
            this.msCoffee.Location = new System.Drawing.Point(0, 0);
            this.msCoffee.Name = "msCoffee";
            this.msCoffee.Size = new System.Drawing.Size(800, 24);
            this.msCoffee.TabIndex = 0;
            this.msCoffee.Text = "Menu Strip";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // customerInfomationToolStripMenuItem
            // 
            this.customerInfomationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfomationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.customerInfomationToolStripMenuItem.Name = "customerInfomationToolStripMenuItem";
            this.customerInfomationToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.customerInfomationToolStripMenuItem.Text = "Infomation";
            // 
            // userInfomationToolStripMenuItem
            // 
            this.userInfomationToolStripMenuItem.Name = "userInfomationToolStripMenuItem";
            this.userInfomationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userInfomationToolStripMenuItem.Text = "User Infomation";
            this.userInfomationToolStripMenuItem.Click += new System.EventHandler(this.userInfomationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.logOutToolStripMenuItem.Text = "Logout";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.lvList);
            this.pnlList.Location = new System.Drawing.Point(511, 89);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(277, 289);
            this.pnlList.TabIndex = 2;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(3, 3);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(271, 283);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Drink Name";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 71;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 69;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.txtTotalPrice);
            this.pnlButton.Controls.Add(this.nmDiscount);
            this.pnlButton.Controls.Add(this.cbSwitch);
            this.pnlButton.Controls.Add(this.btnDiscount);
            this.pnlButton.Controls.Add(this.btnSwitch);
            this.pnlButton.Controls.Add(this.btnPayment);
            this.pnlButton.Location = new System.Drawing.Point(511, 381);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(277, 57);
            this.pnlButton.TabIndex = 3;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(199, 3);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(75, 20);
            this.txtTotalPrice.TabIndex = 5;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(103, 3);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(75, 20);
            this.nmDiscount.TabIndex = 4;
            // 
            // cbSwitch
            // 
            this.cbSwitch.FormattingEnabled = true;
            this.cbSwitch.Location = new System.Drawing.Point(3, 3);
            this.cbSwitch.Name = "cbSwitch";
            this.cbSwitch.Size = new System.Drawing.Size(75, 21);
            this.cbSwitch.TabIndex = 3;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(103, 30);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(75, 23);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(3, 30);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.Text = "Switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(199, 30);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // pnlDrink
            // 
            this.pnlDrink.Controls.Add(this.txtCurrentTable);
            this.pnlDrink.Controls.Add(this.btnAdd);
            this.pnlDrink.Controls.Add(this.nmDrinkCount);
            this.pnlDrink.Controls.Add(this.cbDrink);
            this.pnlDrink.Controls.Add(this.cbCategory);
            this.pnlDrink.Location = new System.Drawing.Point(511, 28);
            this.pnlDrink.Name = "pnlDrink";
            this.pnlDrink.Size = new System.Drawing.Size(277, 55);
            this.pnlDrink.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmDrinkCount
            // 
            this.nmDrinkCount.Location = new System.Drawing.Point(211, 30);
            this.nmDrinkCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDrinkCount.Name = "nmDrinkCount";
            this.nmDrinkCount.Size = new System.Drawing.Size(63, 20);
            this.nmDrinkCount.TabIndex = 2;
            this.nmDrinkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDrink
            // 
            this.cbDrink.FormattingEnabled = true;
            this.cbDrink.Location = new System.Drawing.Point(3, 30);
            this.cbDrink.Name = "cbDrink";
            this.cbDrink.Size = new System.Drawing.Size(121, 21);
            this.cbDrink.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(13, 28);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(492, 410);
            this.flpTable.TabIndex = 5;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbAuthor.Location = new System.Drawing.Point(12, 441);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(155, 13);
            this.lbAuthor.TabIndex = 6;
            this.lbAuthor.Text = "Huy Nguyễn Minh - 175050002";
            // 
            // lbProject
            // 
            this.lbProject.AutoSize = true;
            this.lbProject.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbProject.Location = new System.Drawing.Point(635, 441);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(153, 13);
            this.lbProject.TabIndex = 6;
            this.lbProject.Text = "Windows Development Project";
            this.lbProject.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCurrentTable
            // 
            this.txtCurrentTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTable.Location = new System.Drawing.Point(131, 3);
            this.txtCurrentTable.Name = "txtCurrentTable";
            this.txtCurrentTable.ReadOnly = true;
            this.txtCurrentTable.Size = new System.Drawing.Size(74, 20);
            this.txtCurrentTable.TabIndex = 4;
            this.txtCurrentTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.lbProject);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.pnlDrink);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.msCoffee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msCoffee;
            this.MaximizeBox = false;
            this.Name = "fCoffee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Manager";
            this.msCoffee.ResumeLayout(false);
            this.msCoffee.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.pnlDrink.ResumeLayout(false);
            this.pnlDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msCoffee;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInfomationToolStripMenuItem;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel pnlDrink;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmDrinkCount;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.ComboBox cbSwitch;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.ToolStripMenuItem userInfomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbProject;
        private System.Windows.Forms.TextBox txtCurrentTable;
    }
}