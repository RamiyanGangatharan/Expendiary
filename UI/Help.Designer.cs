namespace Expendiary.UI
{
    partial class Help
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(128, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Help";
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 12F);
            button1.Location = new Point(30, 54);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 1;
            button1.Text = "Transaction Log";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 12F);
            button2.Location = new Point(30, 110);
            button2.Name = "button2";
            button2.Size = new Size(250, 50);
            button2.TabIndex = 2;
            button2.Text = "WealthWatchers";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 12F);
            button3.Location = new Point(30, 166);
            button3.Name = "button3";
            button3.Size = new Size(250, 50);
            button3.TabIndex = 3;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 12F);
            button4.Location = new Point(30, 222);
            button4.Name = "button4";
            button4.Size = new Size(250, 50);
            button4.TabIndex = 4;
            button4.Text = "Investments";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Verdana", 12F);
            button5.Location = new Point(30, 278);
            button5.Name = "button5";
            button5.Size = new Size(250, 50);
            button5.TabIndex = 5;
            button5.Text = "Contact the Developer";
            button5.UseVisualStyleBackColor = true;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 357);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Help";
            Text = "Help";
            Load += Help_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}