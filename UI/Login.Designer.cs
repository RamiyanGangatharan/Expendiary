

namespace Expendiary
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            label1 = new Label();
            label2 = new Label();
            LoginButton = new Button();
            label3 = new Label();
            label4 = new Label();
            username_rtb = new RichTextBox();
            registerButton = new Button();
            password_rtb = new MaskedTextBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(143, 9);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(144, 25);
            Title.TabIndex = 0;
            Title.Text = "Expendiary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 277);
            label1.Name = "label1";
            label1.Size = new Size(330, 16);
            label1.TabIndex = 1;
            label1.Text = "Copyright - Ramiyan Gangatharan February 2024";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 35);
            label2.Name = "label2";
            label2.Size = new Size(250, 18);
            label2.TabIndex = 2;
            label2.Text = "The ultimate financial tracker";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(118, 50, 63);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Verdana", 12F);
            LoginButton.ForeColor = Color.FromArgb(215, 206, 199);
            LoginButton.Location = new Point(120, 188);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(200, 36);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Sign in";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F);
            label3.Location = new Point(119, 76);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F);
            label4.Location = new Point(120, 127);
            label4.Name = "label4";
            label4.Size = new Size(85, 18);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // username_rtb
            // 
            username_rtb.Location = new Point(119, 99);
            username_rtb.Name = "username_rtb";
            username_rtb.Size = new Size(200, 25);
            username_rtb.TabIndex = 6;
            username_rtb.Text = "";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(118, 50, 63);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Verdana", 12F);
            registerButton.ForeColor = Color.FromArgb(215, 206, 199);
            registerButton.Location = new Point(120, 230);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(200, 36);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // password_rtb
            // 
            password_rtb.Location = new Point(119, 148);
            password_rtb.Name = "password_rtb";
            password_rtb.PasswordChar = '*';
            password_rtb.Size = new Size(200, 27);
            password_rtb.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 206, 199);
            ClientSize = new Size(428, 316);
            Controls.Add(password_rtb);
            Controls.Add(registerButton);
            Controls.Add(username_rtb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LoginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Title);
            Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expendiary - Login";
            FormClosed += Login_FormClosed;
            Load += Window_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private Label label2;
        private Button LoginButton;
        private Label label3;
        private Label label4;
        private RichTextBox username_rtb;
        private Button registerButton;
        private MaskedTextBox password_rtb;
    }
}
