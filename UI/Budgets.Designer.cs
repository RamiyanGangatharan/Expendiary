namespace Expendiary.UI
{
    partial class Budgets
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
            BudgetGrid = new DataGridView();
            label4 = new Label();
            exitButton = new Button();
            label5 = new Label();
            WealthWatcherTab = new TabControl();
            OverviewTab = new TabPage();
            BudgetPlannerTab = new TabPage();
            clearButton = new Button();
            groupBox3 = new GroupBox();
            totalExpenseRTB = new RichTextBox();
            label17 = new Label();
            label15 = new Label();
            netProfitLossRTB = new RichTextBox();
            totalIncomeRTB = new RichTextBox();
            label16 = new Label();
            calculateButton = new Button();
            groupBox2 = new GroupBox();
            savingsRTB = new RichTextBox();
            label11 = new Label();
            diningRTB = new RichTextBox();
            label12 = new Label();
            groceryRTB = new RichTextBox();
            label13 = new Label();
            debtRTB = new RichTextBox();
            label14 = new Label();
            transportationRTB = new RichTextBox();
            label10 = new Label();
            insuranceRTB = new RichTextBox();
            label9 = new Label();
            utilitiesRTB = new RichTextBox();
            label6 = new Label();
            housingRTB = new RichTextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            income4RTB = new RichTextBox();
            income3RTB = new RichTextBox();
            income1RTB = new RichTextBox();
            income2RTB = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)BudgetGrid).BeginInit();
            WealthWatcherTab.SuspendLayout();
            OverviewTab.SuspendLayout();
            BudgetPlannerTab.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 24);
            label1.Name = "label1";
            label1.Size = new Size(192, 29);
            label1.TabIndex = 0;
            label1.Text = "WealthWatcher";
            // 
            // BudgetGrid
            // 
            BudgetGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            BudgetGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BudgetGrid.BackgroundColor = Color.FromArgb(215, 206, 199);
            BudgetGrid.BorderStyle = BorderStyle.None;
            BudgetGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BudgetGrid.Location = new Point(23, 37);
            BudgetGrid.Name = "BudgetGrid";
            BudgetGrid.Size = new Size(587, 200);
            BudgetGrid.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(265, 11);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 17;
            label4.Text = "Overview";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(555, 194);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(60, 40);
            exitButton.TabIndex = 18;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 53);
            label5.Name = "label5";
            label5.Size = new Size(140, 13);
            label5.TabIndex = 23;
            label5.Text = "For all your budgeting needs";
            // 
            // WealthWatcherTab
            // 
            WealthWatcherTab.Controls.Add(OverviewTab);
            WealthWatcherTab.Controls.Add(BudgetPlannerTab);
            WealthWatcherTab.Location = new Point(3, 74);
            WealthWatcherTab.Name = "WealthWatcherTab";
            WealthWatcherTab.SelectedIndex = 0;
            WealthWatcherTab.Size = new Size(639, 269);
            WealthWatcherTab.TabIndex = 24;
            // 
            // OverviewTab
            // 
            OverviewTab.BackColor = Color.FromArgb(215, 206, 199);
            OverviewTab.Controls.Add(BudgetGrid);
            OverviewTab.Controls.Add(label4);
            OverviewTab.Location = new Point(4, 22);
            OverviewTab.Name = "OverviewTab";
            OverviewTab.Padding = new Padding(3);
            OverviewTab.Size = new Size(631, 243);
            OverviewTab.TabIndex = 0;
            OverviewTab.Text = "Funds Overview";
            // 
            // BudgetPlannerTab
            // 
            BudgetPlannerTab.BackColor = Color.FromArgb(215, 206, 199);
            BudgetPlannerTab.Controls.Add(clearButton);
            BudgetPlannerTab.Controls.Add(groupBox3);
            BudgetPlannerTab.Controls.Add(calculateButton);
            BudgetPlannerTab.Controls.Add(groupBox2);
            BudgetPlannerTab.Controls.Add(exitButton);
            BudgetPlannerTab.Controls.Add(groupBox1);
            BudgetPlannerTab.Location = new Point(4, 22);
            BudgetPlannerTab.Name = "BudgetPlannerTab";
            BudgetPlannerTab.Padding = new Padding(3);
            BudgetPlannerTab.Size = new Size(631, 243);
            BudgetPlannerTab.TabIndex = 1;
            BudgetPlannerTab.Text = "Budget Planner";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(489, 194);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(60, 40);
            clearButton.TabIndex = 36;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(totalExpenseRTB);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(netProfitLossRTB);
            groupBox3.Controls.Add(totalIncomeRTB);
            groupBox3.Controls.Add(label16);
            groupBox3.Location = new Point(423, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(192, 174);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Overall Values";
            // 
            // totalExpenseRTB
            // 
            totalExpenseRTB.Location = new Point(6, 82);
            totalExpenseRTB.Name = "totalExpenseRTB";
            totalExpenseRTB.ReadOnly = true;
            totalExpenseRTB.Size = new Size(180, 25);
            totalExpenseRTB.TabIndex = 31;
            totalExpenseRTB.Text = "";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 120);
            label17.Name = "label17";
            label17.Size = new Size(78, 13);
            label17.TabIndex = 34;
            label17.Text = "Net Profit/Loss";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 16);
            label15.Name = "label15";
            label15.Size = new Size(69, 13);
            label15.TabIndex = 29;
            label15.Text = "Total Income";
            // 
            // netProfitLossRTB
            // 
            netProfitLossRTB.Location = new Point(6, 136);
            netProfitLossRTB.Name = "netProfitLossRTB";
            netProfitLossRTB.ReadOnly = true;
            netProfitLossRTB.Size = new Size(180, 25);
            netProfitLossRTB.TabIndex = 33;
            netProfitLossRTB.Text = "";
            // 
            // totalIncomeRTB
            // 
            totalIncomeRTB.Location = new Point(6, 32);
            totalIncomeRTB.Name = "totalIncomeRTB";
            totalIncomeRTB.ReadOnly = true;
            totalIncomeRTB.Size = new Size(180, 25);
            totalIncomeRTB.TabIndex = 30;
            totalIncomeRTB.Text = "";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 66);
            label16.Name = "label16";
            label16.Size = new Size(90, 13);
            label16.TabIndex = 32;
            label16.Text = "Total Expenditure";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(423, 194);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(60, 40);
            calculateButton.TabIndex = 35;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(savingsRTB);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(diningRTB);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(groceryRTB);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(debtRTB);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(transportationRTB);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(insuranceRTB);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(utilitiesRTB);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(housingRTB);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(150, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 220);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Expense Source(s)";
            // 
            // savingsRTB
            // 
            savingsRTB.Location = new Point(132, 174);
            savingsRTB.Name = "savingsRTB";
            savingsRTB.Size = new Size(120, 25);
            savingsRTB.TabIndex = 39;
            savingsRTB.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(132, 158);
            label11.Name = "label11";
            label11.Size = new Size(45, 13);
            label11.TabIndex = 38;
            label11.Text = "Savings";
            // 
            // diningRTB
            // 
            diningRTB.Location = new Point(132, 130);
            diningRTB.Name = "diningRTB";
            diningRTB.Size = new Size(120, 25);
            diningRTB.TabIndex = 37;
            diningRTB.Text = "";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(132, 114);
            label12.Name = "label12";
            label12.Size = new Size(57, 13);
            label12.TabIndex = 36;
            label12.Text = "Dining Out";
            // 
            // groceryRTB
            // 
            groceryRTB.Location = new Point(132, 86);
            groceryRTB.Name = "groceryRTB";
            groceryRTB.Size = new Size(120, 25);
            groceryRTB.TabIndex = 35;
            groceryRTB.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(132, 70);
            label13.Name = "label13";
            label13.Size = new Size(44, 13);
            label13.TabIndex = 34;
            label13.Text = "Grocery";
            // 
            // debtRTB
            // 
            debtRTB.Location = new Point(132, 42);
            debtRTB.Name = "debtRTB";
            debtRTB.Size = new Size(120, 25);
            debtRTB.TabIndex = 33;
            debtRTB.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(132, 26);
            label14.Name = "label14";
            label14.Size = new Size(79, 13);
            label14.TabIndex = 32;
            label14.Text = "Debt Payments";
            // 
            // transportationRTB
            // 
            transportationRTB.Location = new Point(6, 174);
            transportationRTB.Name = "transportationRTB";
            transportationRTB.Size = new Size(120, 25);
            transportationRTB.TabIndex = 31;
            transportationRTB.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 158);
            label10.Name = "label10";
            label10.Size = new Size(75, 13);
            label10.TabIndex = 30;
            label10.Text = "Transportation";
            // 
            // insuranceRTB
            // 
            insuranceRTB.Location = new Point(6, 130);
            insuranceRTB.Name = "insuranceRTB";
            insuranceRTB.Size = new Size(120, 25);
            insuranceRTB.TabIndex = 29;
            insuranceRTB.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 114);
            label9.Name = "label9";
            label9.Size = new Size(54, 13);
            label9.TabIndex = 28;
            label9.Text = "Insurance";
            // 
            // utilitiesRTB
            // 
            utilitiesRTB.Location = new Point(6, 86);
            utilitiesRTB.Name = "utilitiesRTB";
            utilitiesRTB.Size = new Size(120, 25);
            utilitiesRTB.TabIndex = 27;
            utilitiesRTB.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 70);
            label6.Name = "label6";
            label6.Size = new Size(40, 13);
            label6.TabIndex = 26;
            label6.Text = "Utilities";
            // 
            // housingRTB
            // 
            housingRTB.Location = new Point(6, 42);
            housingRTB.Name = "housingRTB";
            housingRTB.Size = new Size(120, 25);
            housingRTB.TabIndex = 25;
            housingRTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(46, 13);
            label3.TabIndex = 24;
            label3.Text = "Housing";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(income4RTB);
            groupBox1.Controls.Add(income3RTB);
            groupBox1.Controls.Add(income1RTB);
            groupBox1.Controls.Add(income2RTB);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(6, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(138, 220);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Income Source(s)";
            // 
            // income4RTB
            // 
            income4RTB.Location = new Point(6, 174);
            income4RTB.Name = "income4RTB";
            income4RTB.Size = new Size(120, 25);
            income4RTB.TabIndex = 28;
            income4RTB.Text = "";
            // 
            // income3RTB
            // 
            income3RTB.Location = new Point(6, 130);
            income3RTB.Name = "income3RTB";
            income3RTB.Size = new Size(120, 25);
            income3RTB.TabIndex = 27;
            income3RTB.Text = "";
            // 
            // income1RTB
            // 
            income1RTB.Location = new Point(6, 42);
            income1RTB.Name = "income1RTB";
            income1RTB.Size = new Size(120, 25);
            income1RTB.TabIndex = 23;
            income1RTB.Text = "";
            // 
            // income2RTB
            // 
            income2RTB.Location = new Point(6, 86);
            income2RTB.Name = "income2RTB";
            income2RTB.Size = new Size(120, 25);
            income2RTB.TabIndex = 26;
            income2RTB.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 26);
            label7.Name = "label7";
            label7.Size = new Size(105, 13);
            label7.TabIndex = 3;
            label7.Text = "Net Primary Income: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 70);
            label8.Name = "label8";
            label8.Size = new Size(71, 13);
            label8.TabIndex = 24;
            label8.Text = "Other Income";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, reportsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(649, 24);
            menuStrip1.TabIndex = 25;
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
            // Budgets
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 206, 199);
            ClientSize = new Size(649, 347);
            Controls.Add(menuStrip1);
            Controls.Add(WealthWatcherTab);
            Controls.Add(label5);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Budgets";
            Text = "WealthWatcher";
            Load += Budgets_Load;
            ((System.ComponentModel.ISupportInitialize)BudgetGrid).EndInit();
            WealthWatcherTab.ResumeLayout(false);
            OverviewTab.ResumeLayout(false);
            OverviewTab.PerformLayout();
            BudgetPlannerTab.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView BudgetGrid;
        private Label label4;
        private Button exitButton;
        private Button button4;
        private Button button2;
        private Button button5;
        private Label label5;
        private TabControl WealthWatcherTab;
        private TabPage OverviewTab;
        private TabPage BudgetPlannerTab;
        private Label label7;
        private RichTextBox income2RTB;
        private Label label8;
        private RichTextBox income1RTB;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox income4RTB;
        private RichTextBox income3RTB;
        private RichTextBox housingRTB;
        private Label label3;
        private RichTextBox transportationRTB;
        private Label label10;
        private RichTextBox insuranceRTB;
        private Label label9;
        private RichTextBox utilitiesRTB;
        private Label label6;
        private RichTextBox savingsRTB;
        private Label label11;
        private RichTextBox diningRTB;
        private Label label12;
        private RichTextBox groceryRTB;
        private Label label13;
        private RichTextBox debtRTB;
        private Label label14;
        private RichTextBox totalIncomeRTB;
        private Label label15;
        private Label label16;
        private RichTextBox totalExpenseRTB;
        private Label label17;
        private RichTextBox netProfitLossRTB;
        private Button calculateButton;
        private GroupBox groupBox3;
        private Button clearButton;
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