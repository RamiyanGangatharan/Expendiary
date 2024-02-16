namespace Expendiary
{
    partial class Dashboard
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
            label1 = new Label();
            transactionLogButton = new Button();
            BudgetsButton = new Button();
            ReportsButton = new Button();
            investmentsButton = new Button();
            settingsButton = new Button();
            exitButton = new Button();
            logoutButton = new Button();
            helpButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(86, 86, 86);
            label1.Location = new Point(337, 35);
            label1.Name = "label1";
            label1.Size = new Size(253, 45);
            label1.TabIndex = 0;
            label1.Text = "Expendiary";
            // 
            // transactionLogButton
            // 
            transactionLogButton.BackColor = Color.FromArgb(118, 50, 63);
            transactionLogButton.FlatStyle = FlatStyle.Flat;
            transactionLogButton.Font = new Font("Verdana", 14.25F);
            transactionLogButton.ForeColor = Color.FromArgb(215, 206, 199);
            transactionLogButton.Location = new Point(49, 103);
            transactionLogButton.Name = "transactionLogButton";
            transactionLogButton.Size = new Size(200, 140);
            transactionLogButton.TabIndex = 1;
            transactionLogButton.Text = "Transaction Log";
            transactionLogButton.UseVisualStyleBackColor = false;
            transactionLogButton.Click += transactionLogButton_Click;
            // 
            // BudgetsButton
            // 
            BudgetsButton.BackColor = Color.FromArgb(118, 50, 63);
            BudgetsButton.FlatStyle = FlatStyle.Flat;
            BudgetsButton.Font = new Font("Verdana", 14.25F);
            BudgetsButton.ForeColor = Color.FromArgb(215, 206, 199);
            BudgetsButton.Location = new Point(255, 103);
            BudgetsButton.Name = "BudgetsButton";
            BudgetsButton.Size = new Size(200, 140);
            BudgetsButton.TabIndex = 2;
            BudgetsButton.Text = "Budgets";
            BudgetsButton.UseVisualStyleBackColor = false;
            BudgetsButton.Click += BudgetsButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.BackColor = Color.FromArgb(118, 50, 63);
            ReportsButton.FlatStyle = FlatStyle.Flat;
            ReportsButton.Font = new Font("Verdana", 14.25F);
            ReportsButton.ForeColor = Color.FromArgb(215, 206, 199);
            ReportsButton.Location = new Point(462, 103);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(200, 140);
            ReportsButton.TabIndex = 3;
            ReportsButton.Text = "Reports";
            ReportsButton.UseVisualStyleBackColor = false;
            ReportsButton.Click += ReportsButton_Click;
            // 
            // investmentsButton
            // 
            investmentsButton.BackColor = Color.FromArgb(118, 50, 63);
            investmentsButton.FlatStyle = FlatStyle.Flat;
            investmentsButton.Font = new Font("Verdana", 14.25F);
            investmentsButton.ForeColor = Color.FromArgb(215, 206, 199);
            investmentsButton.Location = new Point(669, 103);
            investmentsButton.Name = "investmentsButton";
            investmentsButton.Size = new Size(200, 140);
            investmentsButton.TabIndex = 4;
            investmentsButton.Text = "Investments";
            investmentsButton.UseVisualStyleBackColor = false;
            investmentsButton.Click += investmentsButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(118, 50, 63);
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Verdana", 14.25F);
            settingsButton.ForeColor = Color.FromArgb(215, 206, 199);
            settingsButton.Location = new Point(49, 248);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(200, 140);
            settingsButton.TabIndex = 5;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(118, 50, 63);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Verdana", 14.25F);
            exitButton.ForeColor = Color.FromArgb(215, 206, 199);
            exitButton.Location = new Point(669, 248);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 140);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(118, 50, 63);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Verdana", 14.25F);
            logoutButton.ForeColor = Color.FromArgb(215, 206, 199);
            logoutButton.Location = new Point(462, 248);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 140);
            logoutButton.TabIndex = 7;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = Color.FromArgb(118, 50, 63);
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.Font = new Font("Verdana", 14.25F);
            helpButton.ForeColor = Color.FromArgb(215, 206, 199);
            helpButton.Location = new Point(255, 248);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(200, 140);
            helpButton.TabIndex = 8;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 206, 199);
            ClientSize = new Size(914, 420);
            Controls.Add(helpButton);
            Controls.Add(logoutButton);
            Controls.Add(exitButton);
            Controls.Add(settingsButton);
            Controls.Add(investmentsButton);
            Controls.Add(ReportsButton);
            Controls.Add(BudgetsButton);
            Controls.Add(transactionLogButton);
            Controls.Add(label1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(231, 223, 221);
            Name = "Dashboard";
            Text = "Expendiary - Dashboard";
            FormClosed += Dashboard_FormClosed;
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button transactionLogButton;
        private Button BudgetsButton;
        private Button ReportsButton;
        private Button investmentsButton;
        private Button settingsButton;
        private Button exitButton;
        private Button logoutButton;
        private Button helpButton;
    }
}