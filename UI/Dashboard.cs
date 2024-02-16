using Expendiary.UI;

namespace Expendiary
{
    public partial class Dashboard : Form
    {
        private object dash;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void transactionLogButton_Click(object sender, EventArgs e)
        {
            TransactionLog trans = new TransactionLog();
            trans.Show();
        }

        private void BudgetsButton_Click(object sender, EventArgs e)
        {
            Budgets bud = new Budgets();
            bud.Show();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Reports rep = new Reports();
            rep.Show();
        }

        private void investmentsButton_Click(object sender, EventArgs e)
        {
            Investments inv = new Investments();
            inv.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            UI.Help helper = new UI.Help();
            helper.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want logout?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var result = MessageBox.Show("Are you really sure you want to close the application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { Application.Exit(); }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close the application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) { Application.Exit(); }
        }
    }
}
