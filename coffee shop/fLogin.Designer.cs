namespace coffee_shop
{
    partial class fLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnExit);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lbPassword);
            this.pnlLogin.Controls.Add(this.lbID);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtID);
            this.pnlLogin.Location = new System.Drawing.Point(13, 13);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(331, 136);
            this.pnlLogin.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 105);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(36, 66);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(36, 26);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 63);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 20);
            this.txtID.TabIndex = 0;
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 161);
            this.ControlBox = false;
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
    }
}

