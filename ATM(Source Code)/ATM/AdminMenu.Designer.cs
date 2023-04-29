namespace ATM
{
    partial class AdminMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ChangePin = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdrawal = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 97);
            this.panel1.TabIndex = 6;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(331, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 48);
            this.Title.TabIndex = 2;
            this.Title.Text = "MENU";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 10);
            this.panel2.TabIndex = 26;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logout.Location = new System.Drawing.Point(686, 558);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(102, 50);
            this.logout.TabIndex = 33;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(12, 558);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 50);
            this.exit.TabIndex = 32;
            this.exit.Text = "Close";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // ChangePin
            // 
            this.ChangePin.BackColor = System.Drawing.Color.Transparent;
            this.ChangePin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChangePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangePin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChangePin.Location = new System.Drawing.Point(49, 292);
            this.ChangePin.Name = "ChangePin";
            this.ChangePin.Size = new System.Drawing.Size(240, 50);
            this.ChangePin.TabIndex = 31;
            this.ChangePin.Text = "Change Pin";
            this.ChangePin.UseVisualStyleBackColor = false;
            this.ChangePin.Click += new System.EventHandler(this.ChangePin_Click);
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.Transparent;
            this.Transfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Transfer.Location = new System.Drawing.Point(49, 431);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(240, 50);
            this.Transfer.TabIndex = 30;
            this.Transfer.Text = "Transfer Money";
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.Transparent;
            this.Deposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Deposit.Location = new System.Drawing.Point(512, 292);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(240, 50);
            this.Deposit.TabIndex = 29;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Withdrawal
            // 
            this.Withdrawal.BackColor = System.Drawing.Color.Transparent;
            this.Withdrawal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdrawal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdrawal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Withdrawal.Location = new System.Drawing.Point(512, 175);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(240, 50);
            this.Withdrawal.TabIndex = 28;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = false;
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // Balance
            // 
            this.Balance.BackColor = System.Drawing.Color.Transparent;
            this.Balance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Balance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Balance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Balance.Location = new System.Drawing.Point(49, 175);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(240, 50);
            this.Balance.TabIndex = 27;
            this.Balance.Text = "Balance Enquiry";
            this.Balance.UseVisualStyleBackColor = false;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(512, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 50);
            this.button1.TabIndex = 34;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ChangePin);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Withdrawal);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Title;
        private Panel panel2;
        private Button logout;
        private Button Close;
        private Button ChangePin;
        private Button Transfer;
        private Button Deposit;
        private Button Withdrawal;
        private Button Balance;
        private Button button1;
        private Button close;
        private Button exit;
    }
}