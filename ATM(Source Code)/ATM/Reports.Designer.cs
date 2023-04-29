namespace ATM
{
    partial class Reports
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.accountrep = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transferrep = new System.Windows.Forms.Button();
            this.depositrep = new System.Windows.Forms.Button();
            this.withdrawalrep = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Location = new System.Drawing.Point(-14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 97);
            this.panel1.TabIndex = 13;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(387, 22);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(176, 48);
            this.Title.TabIndex = 2;
            this.Title.Text = "REPORTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-14, 654);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 11);
            this.panel2.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(34, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 50);
            this.button3.TabIndex = 37;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(736, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 50);
            this.button2.TabIndex = 36;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 222);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(841, 313);
            this.dataGridView.TabIndex = 38;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick_1);
            // 
            // accountrep
            // 
            this.accountrep.BackColor = System.Drawing.Color.Transparent;
            this.accountrep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountrep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountrep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountrep.ForeColor = System.Drawing.Color.Black;
            this.accountrep.Location = new System.Drawing.Point(12, 173);
            this.accountrep.Name = "accountrep";
            this.accountrep.Size = new System.Drawing.Size(164, 43);
            this.accountrep.TabIndex = 39;
            this.accountrep.Text = "Account Report";
            this.accountrep.UseVisualStyleBackColor = false;
            this.accountrep.Click += new System.EventHandler(this.accountrep_Click);
            // 
            // date
            // 
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(92, 123);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(219, 34);
            this.date.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "Date:";
            // 
            // transferrep
            // 
            this.transferrep.BackColor = System.Drawing.Color.Transparent;
            this.transferrep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.transferrep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transferrep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transferrep.ForeColor = System.Drawing.Color.Black;
            this.transferrep.Location = new System.Drawing.Point(694, 123);
            this.transferrep.Name = "transferrep";
            this.transferrep.Size = new System.Drawing.Size(159, 34);
            this.transferrep.TabIndex = 42;
            this.transferrep.Text = "Transfer Report";
            this.transferrep.UseVisualStyleBackColor = false;
            this.transferrep.Click += new System.EventHandler(this.transferrep_Click);
            // 
            // depositrep
            // 
            this.depositrep.BackColor = System.Drawing.Color.Transparent;
            this.depositrep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.depositrep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depositrep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.depositrep.ForeColor = System.Drawing.Color.Black;
            this.depositrep.Location = new System.Drawing.Point(524, 124);
            this.depositrep.Name = "depositrep";
            this.depositrep.Size = new System.Drawing.Size(164, 34);
            this.depositrep.TabIndex = 43;
            this.depositrep.Text = "Deposit Report";
            this.depositrep.UseVisualStyleBackColor = false;
            this.depositrep.Click += new System.EventHandler(this.depositrep_Click);
            // 
            // withdrawalrep
            // 
            this.withdrawalrep.BackColor = System.Drawing.Color.Transparent;
            this.withdrawalrep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdrawalrep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdrawalrep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.withdrawalrep.ForeColor = System.Drawing.Color.Black;
            this.withdrawalrep.Location = new System.Drawing.Point(331, 126);
            this.withdrawalrep.Name = "withdrawalrep";
            this.withdrawalrep.Size = new System.Drawing.Size(187, 31);
            this.withdrawalrep.TabIndex = 44;
            this.withdrawalrep.Text = "Withdrawal Report";
            this.withdrawalrep.UseVisualStyleBackColor = false;
            this.withdrawalrep.Click += new System.EventHandler(this.withdrawalrep_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 664);
            this.Controls.Add(this.withdrawalrep);
            this.Controls.Add(this.depositrep);
            this.Controls.Add(this.transferrep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.accountrep);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Account_Reports";
            this.Load += new System.EventHandler(this.Account_Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Title;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView;
        private Button accountrep;
        private TextBox date;
        private Label label1;
        private Button transferrep;
        private Button depositrep;
        private Button withdrawalrep;
    }
}