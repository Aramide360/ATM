namespace ATM
{
    partial class UserMenu
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
            this.Balance = new System.Windows.Forms.Button();
            this.Withdrawal = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.ChangePin = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 97);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(326, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 48);
            this.Title.TabIndex = 2;
            this.Title.Text = "MENU";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Balance
            // 
            this.Balance.BackColor = System.Drawing.Color.Transparent;
            this.Balance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Balance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Balance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Balance.Location = new System.Drawing.Point(47, 162);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(240, 50);
            this.Balance.TabIndex = 19;
            this.Balance.Text = "Balance Enquiry";
            this.Balance.UseVisualStyleBackColor = false;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // Withdrawal
            // 
            this.Withdrawal.BackColor = System.Drawing.Color.Transparent;
            this.Withdrawal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Withdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdrawal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdrawal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Withdrawal.Location = new System.Drawing.Point(510, 162);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(240, 50);
            this.Withdrawal.TabIndex = 20;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = false;
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.Color.Transparent;
            this.Deposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Deposit.Location = new System.Drawing.Point(510, 279);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(240, 50);
            this.Deposit.TabIndex = 21;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.Color.Transparent;
            this.Transfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Transfer.Location = new System.Drawing.Point(47, 408);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(240, 50);
            this.Transfer.TabIndex = 22;
            this.Transfer.Text = "Transfer Money";
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // ChangePin
            // 
            this.ChangePin.BackColor = System.Drawing.Color.Transparent;
            this.ChangePin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChangePin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangePin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChangePin.Location = new System.Drawing.Point(47, 279);
            this.ChangePin.Name = "ChangePin";
            this.ChangePin.Size = new System.Drawing.Size(240, 50);
            this.ChangePin.TabIndex = 23;
            this.ChangePin.Text = "Change Pin";
            this.ChangePin.UseVisualStyleBackColor = false;
            this.ChangePin.Click += new System.EventHandler(this.ChangePin_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.Color.Red;
            this.Close.Location = new System.Drawing.Point(47, 531);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(102, 50);
            this.Close.TabIndex = 24;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 10);
            this.panel2.TabIndex = 25;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logout.Location = new System.Drawing.Point(648, 531);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(102, 50);
            this.logout.TabIndex = 26;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.ControlBox = false;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ChangePin);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Withdrawal);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMenu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label Title;
        private Button Balance;
        private Button Withdrawal;
        private Button Deposit;
        private Button Transfer;
        private Button ChangePin;
        private Button Close;
        private Panel panel2;
        private Button logout;
    }
}