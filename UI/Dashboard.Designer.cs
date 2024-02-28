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
            welcomeMessage = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newTransactionToolStripMenuItem = new ToolStripMenuItem();
            importDataToolStripMenuItem = new ToolStripMenuItem();
            exportDataToolStripMenuItem = new ToolStripMenuItem();
            printReportToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            summaryToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            budgetsToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem1 = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            budgetPlannerToolStripMenuItem = new ToolStripMenuItem();
            expenseTrackerToolStripMenuItem = new ToolStripMenuItem();
            investmentCalculatorToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            spendingByCategoryToolStripMenuItem = new ToolStripMenuItem();
            incomeVsExpensesToolStripMenuItem = new ToolStripMenuItem();
            monthlySummaryToolStripMenuItem = new ToolStripMenuItem();
            annualSummaryToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            userGuideToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            checkOfUpdatesToolStripMenuItem = new ToolStripMenuItem();
            contactSupportToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(86, 86, 86);
            label1.Location = new Point(338, 24);
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
            BudgetsButton.Text = "WealthWatcher";
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
            // welcomeMessage
            // 
            welcomeMessage.AutoSize = true;
            welcomeMessage.ForeColor = Color.FromArgb(86, 86, 86);
            welcomeMessage.Location = new Point(49, 86);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(71, 14);
            welcomeMessage.TabIndex = 9;
            welcomeMessage.Text = "Welcome, ";
            welcomeMessage.VisibleChanged += welcomeMessage_VisibleChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, reportsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newTransactionToolStripMenuItem, importDataToolStripMenuItem, exportDataToolStripMenuItem, printReportToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newTransactionToolStripMenuItem
            // 
            newTransactionToolStripMenuItem.Name = "newTransactionToolStripMenuItem";
            newTransactionToolStripMenuItem.Size = new Size(161, 22);
            newTransactionToolStripMenuItem.Text = "New Transaction";
            // 
            // importDataToolStripMenuItem
            // 
            importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            importDataToolStripMenuItem.Size = new Size(161, 22);
            importDataToolStripMenuItem.Text = "Import Data";
            // 
            // exportDataToolStripMenuItem
            // 
            exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            exportDataToolStripMenuItem.Size = new Size(161, 22);
            exportDataToolStripMenuItem.Text = "Export Data";
            // 
            // printReportToolStripMenuItem
            // 
            printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            printReportToolStripMenuItem.Size = new Size(161, 22);
            printReportToolStripMenuItem.Text = "Print Report";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(161, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, settingsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(116, 22);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(116, 22);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(116, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(116, 22);
            copyToolStripMenuItem.Text = "Copy ";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(116, 22);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { summaryToolStripMenuItem, transactionsToolStripMenuItem, budgetsToolStripMenuItem, reportsToolStripMenuItem1 });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // summaryToolStripMenuItem
            // 
            summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            summaryToolStripMenuItem.Size = new Size(139, 22);
            summaryToolStripMenuItem.Text = "Summary";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(139, 22);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // budgetsToolStripMenuItem
            // 
            budgetsToolStripMenuItem.Name = "budgetsToolStripMenuItem";
            budgetsToolStripMenuItem.Size = new Size(139, 22);
            budgetsToolStripMenuItem.Text = "Budgets";
            // 
            // reportsToolStripMenuItem1
            // 
            reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            reportsToolStripMenuItem1.Size = new Size(139, 22);
            reportsToolStripMenuItem1.Text = "Reports";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { budgetPlannerToolStripMenuItem, expenseTrackerToolStripMenuItem, investmentCalculatorToolStripMenuItem, findToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // budgetPlannerToolStripMenuItem
            // 
            budgetPlannerToolStripMenuItem.Name = "budgetPlannerToolStripMenuItem";
            budgetPlannerToolStripMenuItem.Size = new Size(190, 22);
            budgetPlannerToolStripMenuItem.Text = "Budget Planner";
            // 
            // expenseTrackerToolStripMenuItem
            // 
            expenseTrackerToolStripMenuItem.Name = "expenseTrackerToolStripMenuItem";
            expenseTrackerToolStripMenuItem.Size = new Size(190, 22);
            expenseTrackerToolStripMenuItem.Text = "Expense Tracker";
            // 
            // investmentCalculatorToolStripMenuItem
            // 
            investmentCalculatorToolStripMenuItem.Name = "investmentCalculatorToolStripMenuItem";
            investmentCalculatorToolStripMenuItem.Size = new Size(190, 22);
            investmentCalculatorToolStripMenuItem.Text = "Investment Calculator";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(190, 22);
            findToolStripMenuItem.Text = "Find";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spendingByCategoryToolStripMenuItem, incomeVsExpensesToolStripMenuItem, monthlySummaryToolStripMenuItem, annualSummaryToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // spendingByCategoryToolStripMenuItem
            // 
            spendingByCategoryToolStripMenuItem.Name = "spendingByCategoryToolStripMenuItem";
            spendingByCategoryToolStripMenuItem.Size = new Size(191, 22);
            spendingByCategoryToolStripMenuItem.Text = "Spending by Category";
            // 
            // incomeVsExpensesToolStripMenuItem
            // 
            incomeVsExpensesToolStripMenuItem.Name = "incomeVsExpensesToolStripMenuItem";
            incomeVsExpensesToolStripMenuItem.Size = new Size(191, 22);
            incomeVsExpensesToolStripMenuItem.Text = "Income vs Expenses";
            // 
            // monthlySummaryToolStripMenuItem
            // 
            monthlySummaryToolStripMenuItem.Name = "monthlySummaryToolStripMenuItem";
            monthlySummaryToolStripMenuItem.Size = new Size(191, 22);
            monthlySummaryToolStripMenuItem.Text = "Monthly Summary";
            // 
            // annualSummaryToolStripMenuItem
            // 
            annualSummaryToolStripMenuItem.Name = "annualSummaryToolStripMenuItem";
            annualSummaryToolStripMenuItem.Size = new Size(191, 22);
            annualSummaryToolStripMenuItem.Text = "Annual Summary";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userGuideToolStripMenuItem, aboutToolStripMenuItem, checkOfUpdatesToolStripMenuItem, contactSupportToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // userGuideToolStripMenuItem
            // 
            userGuideToolStripMenuItem.Name = "userGuideToolStripMenuItem";
            userGuideToolStripMenuItem.Size = new Size(167, 22);
            userGuideToolStripMenuItem.Text = "User Guide";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(167, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // checkOfUpdatesToolStripMenuItem
            // 
            checkOfUpdatesToolStripMenuItem.Name = "checkOfUpdatesToolStripMenuItem";
            checkOfUpdatesToolStripMenuItem.Size = new Size(167, 22);
            checkOfUpdatesToolStripMenuItem.Text = "Check of Updates";
            // 
            // contactSupportToolStripMenuItem
            // 
            contactSupportToolStripMenuItem.Name = "contactSupportToolStripMenuItem";
            contactSupportToolStripMenuItem.Size = new Size(167, 22);
            contactSupportToolStripMenuItem.Text = "Contact Support";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 206, 199);
            ClientSize = new Size(914, 420);
            Controls.Add(menuStrip1);
            Controls.Add(welcomeMessage);
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label welcomeMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newTransactionToolStripMenuItem;
        private ToolStripMenuItem importDataToolStripMenuItem;
        private ToolStripMenuItem exportDataToolStripMenuItem;
        private ToolStripMenuItem printReportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem summaryToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem budgetsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem1;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem budgetPlannerToolStripMenuItem;
        private ToolStripMenuItem expenseTrackerToolStripMenuItem;
        private ToolStripMenuItem investmentCalculatorToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem spendingByCategoryToolStripMenuItem;
        private ToolStripMenuItem incomeVsExpensesToolStripMenuItem;
        private ToolStripMenuItem monthlySummaryToolStripMenuItem;
        private ToolStripMenuItem annualSummaryToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem userGuideToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem checkOfUpdatesToolStripMenuItem;
        private ToolStripMenuItem contactSupportToolStripMenuItem;
    }
}