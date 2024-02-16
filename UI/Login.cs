using Expendiary.Data;

namespace Expendiary
{
    public partial class Login : Form
    {
        Database data = new Database();

        public Login()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = username_rtb.Text;
            string password = password_rtb.Text; // This should be a hashed password

            if (data.Login(username, password))
            {
                // Instantiate and show the dashboard form
                Dashboard dashboard = new Dashboard();
                this.Hide(); // Optional: Hide the login form
                dashboard.Show();
            }
            else { MessageBox.Show("Login failed. Please check your username and password."); }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
