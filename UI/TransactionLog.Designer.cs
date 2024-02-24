namespace Expendiary
{
    partial class TransactionLog
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
            TransactionGrid = new DataGridView();
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
            label1 = new Label();
            companyRTB = new RichTextBox();
            label2 = new Label();
            AmountRTB = new RichTextBox();
            label3 = new Label();
            DTP_insertion = new MonthCalendar();
            insertButton = new Button();
            exitButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            categoryCombo = new ComboBox();
            groupBox1 = new GroupBox();
            button5 = new Button();
            label10 = new Label();
            label9 = new Label();
            richTextBox4 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)TransactionGrid).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // TransactionGrid
            // 
            TransactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TransactionGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TransactionGrid.BackgroundColor = Color.FromArgb(215, 206, 199);
            TransactionGrid.BorderStyle = BorderStyle.None;
            TransactionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionGrid.Location = new Point(14, 25);
            TransactionGrid.MultiSelect = false;
            TransactionGrid.Name = "TransactionGrid";
            TransactionGrid.ReadOnly = true;
            TransactionGrid.RowTemplate.ReadOnly = true;
            TransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionGrid.Size = new Size(788, 200);
            TransactionGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, reportsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(816, 24);
            menuStrip1.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 14);
            label1.TabIndex = 2;
            label1.Text = "Company";
            // 
            // companyRTB
            // 
            companyRTB.Location = new Point(6, 35);
            companyRTB.Name = "companyRTB";
            companyRTB.Size = new Size(200, 25);
            companyRTB.TabIndex = 3;
            companyRTB.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(65, 14);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // AmountRTB
            // 
            AmountRTB.Location = new Point(6, 150);
            AmountRTB.Name = "AmountRTB";
            AmountRTB.Size = new Size(200, 25);
            AmountRTB.TabIndex = 7;
            AmountRTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 133);
            label3.Name = "label3";
            label3.Size = new Size(77, 14);
            label3.TabIndex = 6;
            label3.Text = "Amount ($)";
            // 
            // DTP_insertion
            // 
            DTP_insertion.Location = new Point(218, 27);
            DTP_insertion.Name = "DTP_insertion";
            DTP_insertion.TabIndex = 8;
            DTP_insertion.DateSelected += DTP_insertion_DateSelected;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(457, 31);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(75, 35);
            insertButton.TabIndex = 11;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(457, 154);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 35);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(457, 72);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 35);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(457, 113);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 35);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // categoryCombo
            // 
            categoryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryCombo.FlatStyle = FlatStyle.Flat;
            categoryCombo.FormattingEnabled = true;
            categoryCombo.Items.AddRange(new object[] { "Income", "Housing ", "Transportation", "Dining", "Utilities ", "Entertainment", "Grocery", "Fuel", "Insurance", "Medical", "Savings ", "Investments ", "Miscellaneous" });
            categoryCombo.Location = new Point(6, 96);
            categoryCombo.Name = "categoryCombo";
            categoryCombo.Size = new Size(200, 22);
            categoryCombo.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(richTextBox4);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(564, 231);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 202);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // button5
            // 
            button5.Location = new Point(6, 154);
            button5.Name = "button5";
            button5.Size = new Size(226, 35);
            button5.TabIndex = 26;
            button5.Text = "Apply Filter(s)";
            button5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(114, 41);
            label10.Name = "label10";
            label10.Size = new Size(12, 14);
            label10.TabIndex = 25;
            label10.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(114, 128);
            label9.Name = "label9";
            label9.Size = new Size(12, 14);
            label9.TabIndex = 24;
            label9.Text = "-";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(132, 121);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(100, 25);
            richTextBox4.TabIndex = 23;
            richTextBox4.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 121);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(100, 25);
            richTextBox2.TabIndex = 22;
            richTextBox2.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(81, 104);
            label8.Name = "label8";
            label8.Size = new Size(81, 14);
            label8.TabIndex = 21;
            label8.Text = "Price Range";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 18);
            label7.Name = "label7";
            label7.Size = new Size(65, 14);
            label7.TabIndex = 20;
            label7.Text = "End Date";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(120, 79);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(112, 22);
            comboBox3.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(112, 22);
            comboBox2.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 62);
            label6.Name = "label6";
            label6.Size = new Size(65, 14);
            label6.TabIndex = 17;
            label6.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 62);
            label5.Name = "label5";
            label5.Size = new Size(112, 14);
            label5.TabIndex = 16;
            label5.Text = "Transaction Type";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(132, 35);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(100, 22);
            dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(6, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 22);
            dateTimePicker1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 18);
            label4.Name = "label4";
            label4.Size = new Size(72, 14);
            label4.TabIndex = 13;
            label4.Text = "Start Date";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(companyRTB);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(categoryCombo);
            groupBox2.Controls.Add(updateButton);
            groupBox2.Controls.Add(exitButton);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(insertButton);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(AmountRTB);
            groupBox2.Controls.Add(DTP_insertion);
            groupBox2.Location = new Point(14, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 202);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Entry Fields";
            // 
            // TransactionLog
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 206, 199);
            ClientSize = new Size(816, 445);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TransactionGrid);
            Controls.Add(menuStrip1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "TransactionLog";
            Text = "Expendiary";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)TransactionGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TransactionGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem newTransactionToolStripMenuItem;
        private ToolStripMenuItem importDataToolStripMenuItem;
        private ToolStripMenuItem exportDataToolStripMenuItem;
        private ToolStripMenuItem printReportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem summaryToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem budgetsToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem1;
        private ToolStripMenuItem budgetPlannerToolStripMenuItem;
        private ToolStripMenuItem expenseTrackerToolStripMenuItem;
        private ToolStripMenuItem investmentCalculatorToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem spendingByCategoryToolStripMenuItem;
        private ToolStripMenuItem incomeVsExpensesToolStripMenuItem;
        private ToolStripMenuItem monthlySummaryToolStripMenuItem;
        private ToolStripMenuItem annualSummaryToolStripMenuItem;
        private ToolStripMenuItem userGuideToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem checkOfUpdatesToolStripMenuItem;
        private ToolStripMenuItem contactSupportToolStripMenuItem;
        private Label label1;
        private RichTextBox companyRTB;
        private Label label2;
        private RichTextBox AmountRTB;
        private Label label3;
        private MonthCalendar DTP_insertion;
        private Button insertButton;
        private Button exitButton;
        private Button updateButton;
        private Button deleteButton;
        private ComboBox categoryCombo;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label7;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label5;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox2;
        private Label label8;
        private GroupBox groupBox2;
        private Label label9;
        private Label label10;
        private Button button5;
    }
}