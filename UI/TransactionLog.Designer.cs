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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            applyFilterButton = new Button();
            label10 = new Label();
            label9 = new Label();
            priceRange2FilterRTB = new RichTextBox();
            priceRange1FilterRTB = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            CategoryFilterCombo = new ComboBox();
            transactionTypeFilterCombo = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            endDateFilterDTP = new DateTimePicker();
            startDateFilterDTP = new DateTimePicker();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TransactionGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            TransactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TransactionGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TransactionGrid.BackgroundColor = Color.FromArgb(215, 206, 199);
            TransactionGrid.BorderStyle = BorderStyle.None;
            TransactionGrid.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            TransactionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            TransactionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            TransactionGrid.DefaultCellStyle = dataGridViewCellStyle6;
            TransactionGrid.Location = new Point(14, 25);
            TransactionGrid.MultiSelect = false;
            TransactionGrid.Name = "TransactionGrid";
            TransactionGrid.ReadOnly = true;
            TransactionGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            TransactionGrid.RowTemplate.ReadOnly = true;
            TransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionGrid.Size = new Size(741, 474);
            TransactionGrid.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, reportsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1184, 24);
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
            label1.Location = new Point(9, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 14);
            label1.TabIndex = 2;
            label1.Text = "Company";
            // 
            // companyRTB
            // 
            companyRTB.Location = new Point(9, 35);
            companyRTB.Name = "companyRTB";
            companyRTB.Size = new Size(161, 25);
            companyRTB.TabIndex = 3;
            companyRTB.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 79);
            label2.Name = "label2";
            label2.Size = new Size(65, 14);
            label2.TabIndex = 4;
            label2.Text = "Category";
            // 
            // AmountRTB
            // 
            AmountRTB.Location = new Point(9, 150);
            AmountRTB.Name = "AmountRTB";
            AmountRTB.Size = new Size(161, 25);
            AmountRTB.TabIndex = 7;
            AmountRTB.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 133);
            label3.Name = "label3";
            label3.Size = new Size(77, 14);
            label3.TabIndex = 6;
            label3.Text = "Amount ($)";
            // 
            // DTP_insertion
            // 
            DTP_insertion.Location = new Point(182, 27);
            DTP_insertion.Name = "DTP_insertion";
            DTP_insertion.TabIndex = 8;
            DTP_insertion.DateSelected += DTP_insertion_DateSelected;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(761, 235);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(100, 45);
            insertButton.TabIndex = 11;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1079, 235);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 45);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(867, 235);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 45);
            updateButton.TabIndex = 13;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(973, 235);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 45);
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
            categoryCombo.Location = new Point(9, 96);
            categoryCombo.Name = "categoryCombo";
            categoryCombo.Size = new Size(161, 22);
            categoryCombo.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(applyFilterButton);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(priceRange2FilterRTB);
            groupBox1.Controls.Add(priceRange1FilterRTB);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(CategoryFilterCombo);
            groupBox1.Controls.Add(transactionTypeFilterCombo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(endDateFilterDTP);
            groupBox1.Controls.Add(startDateFilterDTP);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(761, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 202);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // applyFilterButton
            // 
            applyFilterButton.Location = new Point(6, 154);
            applyFilterButton.Name = "applyFilterButton";
            applyFilterButton.Size = new Size(226, 35);
            applyFilterButton.TabIndex = 26;
            applyFilterButton.Text = "Apply Filter(s)";
            applyFilterButton.UseVisualStyleBackColor = true;
            applyFilterButton.Click += applyFilterButton_Click;
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
            // priceRange2FilterRTB
            // 
            priceRange2FilterRTB.Location = new Point(132, 121);
            priceRange2FilterRTB.Name = "priceRange2FilterRTB";
            priceRange2FilterRTB.Size = new Size(100, 25);
            priceRange2FilterRTB.TabIndex = 23;
            priceRange2FilterRTB.Text = "";
            // 
            // priceRange1FilterRTB
            // 
            priceRange1FilterRTB.Location = new Point(6, 121);
            priceRange1FilterRTB.Name = "priceRange1FilterRTB";
            priceRange1FilterRTB.Size = new Size(100, 25);
            priceRange1FilterRTB.TabIndex = 22;
            priceRange1FilterRTB.Text = "";
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
            label7.Location = new Point(132, 18);
            label7.Name = "label7";
            label7.Size = new Size(65, 14);
            label7.TabIndex = 20;
            label7.Text = "End Date";
            // 
            // CategoryFilterCombo
            // 
            CategoryFilterCombo.FormattingEnabled = true;
            CategoryFilterCombo.Location = new Point(120, 79);
            CategoryFilterCombo.Name = "CategoryFilterCombo";
            CategoryFilterCombo.Size = new Size(112, 22);
            CategoryFilterCombo.TabIndex = 19;
            // 
            // transactionTypeFilterCombo
            // 
            transactionTypeFilterCombo.FormattingEnabled = true;
            transactionTypeFilterCombo.Location = new Point(6, 79);
            transactionTypeFilterCombo.Name = "transactionTypeFilterCombo";
            transactionTypeFilterCombo.Size = new Size(112, 22);
            transactionTypeFilterCombo.TabIndex = 18;
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
            // endDateFilterDTP
            // 
            endDateFilterDTP.Format = DateTimePickerFormat.Short;
            endDateFilterDTP.Location = new Point(132, 35);
            endDateFilterDTP.Name = "endDateFilterDTP";
            endDateFilterDTP.Size = new Size(100, 22);
            endDateFilterDTP.TabIndex = 15;
            // 
            // startDateFilterDTP
            // 
            startDateFilterDTP.Format = DateTimePickerFormat.Short;
            startDateFilterDTP.Location = new Point(6, 35);
            startDateFilterDTP.Name = "startDateFilterDTP";
            startDateFilterDTP.Size = new Size(100, 22);
            startDateFilterDTP.TabIndex = 14;
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
            groupBox2.Controls.Add(categoryCombo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(AmountRTB);
            groupBox2.Controls.Add(DTP_insertion);
            groupBox2.Location = new Point(761, 297);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(418, 202);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Entry Fields";
            // 
            // TransactionLog
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 206, 199);
            ClientSize = new Size(1184, 511);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(deleteButton);
            Controls.Add(exitButton);
            Controls.Add(TransactionGrid);
            Controls.Add(menuStrip1);
            Controls.Add(updateButton);
            Controls.Add(insertButton);
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
        private DateTimePicker endDateFilterDTP;
        private DateTimePicker startDateFilterDTP;
        private Label label4;
        private Label label7;
        private ComboBox CategoryFilterCombo;
        private ComboBox transactionTypeFilterCombo;
        private Label label6;
        private Label label5;
        private RichTextBox priceRange2FilterRTB;
        private RichTextBox priceRange1FilterRTB;
        private Label label8;
        private GroupBox groupBox2;
        private Label label9;
        private Label label10;
        private Button applyFilterButton;
    }
}