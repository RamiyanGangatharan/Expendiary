namespace Expendiary
{
    partial class Registration
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
            password_rtb = new RichTextBox();
            username_rtb = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            createAccountButton = new Button();
            Title = new Label();
            SuspendLayout();
            // 
            // password_rtb
            // 
            password_rtb.Location = new Point(32, 165);
            password_rtb.Name = "password_rtb";
            password_rtb.Size = new Size(200, 24);
            password_rtb.TabIndex = 11;
            password_rtb.Text = "";
            // 
            // username_rtb
            // 
            username_rtb.Location = new Point(31, 114);
            username_rtb.Name = "username_rtb";
            username_rtb.Size = new Size(200, 24);
            username_rtb.TabIndex = 10;
            username_rtb.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Location = new Point(32, 147);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(32, 96);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // createAccountButton
            // 
            createAccountButton.BackColor = Color.FromArgb(118, 50, 63);
            createAccountButton.FlatStyle = FlatStyle.Flat;
            createAccountButton.ForeColor = Color.FromArgb(215, 206, 199);
            createAccountButton.Location = new Point(32, 205);
            createAccountButton.Name = "createAccountButton";
            createAccountButton.Size = new Size(200, 35);
            createAccountButton.TabIndex = 12;
            createAccountButton.Text = "Create Account";
            createAccountButton.UseVisualStyleBackColor = false;
            createAccountButton.Click += createAccountButton_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(60, 43);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(152, 26);
            Title.TabIndex = 13;
            Title.Text = "Registration";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 206, 199);
            ClientSize = new Size(275, 254);
            Controls.Add(Title);
            Controls.Add(createAccountButton);
            Controls.Add(password_rtb);
            Controls.Add(username_rtb);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox password_rtb;
        private RichTextBox username_rtb;
        private Label label4;
        private Label label3;
        private Button createAccountButton;
        private Label Title;
    }
}