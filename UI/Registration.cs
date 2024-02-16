using Expendiary.Data;

namespace Expendiary
{
    public partial class Registration : Form
    {
        Database data = new Database();
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string username = username_rtb.Text;
            string password = password_rtb.Text; // The password the user entered

            bool userCreated = data.CreateUser(username, password);
            if (userCreated)
            {
                MessageBox.Show("User successfully created.");
                // Possibly transition to a login screen or dashboard
            }
            else
            {
                MessageBox.Show("User could not be created. The username might already exist.");
            }
        }
    }
}
