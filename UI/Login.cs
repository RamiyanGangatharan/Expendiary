using Expendiary.Core;
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
            // First, declare and initialize the username and password variables
            string username = username_rtb.Text;
            string password = password_rtb.Text; // This should ideally be hashed

            // Then, attempt the login
            if (data.Login(username, password))
            {
                // Store the username in the UserSession
                UserSession.Login(username);

                // Then create the Dashboard instance
                Dashboard dashboard = new Dashboard(); // No need to pass username anymore
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("INVALID CREDENTIALS. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password_rtb.Clear();
                username_rtb.Clear();
            }
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
