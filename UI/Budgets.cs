using Expendiary.Data;

namespace Expendiary.UI
{
    public partial class Budgets : Form
    {
        public Budgets()
        {
            InitializeComponent();
        }

        Database data = new Database();


        private void Budgets_Load(object sender, EventArgs e)
        {
            data.CreateConnection_Budgets(BudgetGrid);
            data.OpenConnection();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Core.Budget budget = new Core.Budget()
            {
                Income1 = ConvertToDouble(income1RTB.Text),
                Income2 = ConvertToDouble(income2RTB.Text),
                Income3 = ConvertToDouble(income3RTB.Text),
                Income4 = ConvertToDouble(income4RTB.Text),
                Housing = ConvertToDouble(housingRTB.Text),
                Utilities = ConvertToDouble(utilitiesRTB.Text),
                Insurance = ConvertToDouble(insuranceRTB.Text),
                Transportation = ConvertToDouble(transportationRTB.Text),
                Debt = ConvertToDouble(debtRTB.Text),
                Grocery = ConvertToDouble(groceryRTB.Text),
                DiningOut = ConvertToDouble(diningRTB.Text),
                Savings = ConvertToDouble(savingsRTB.Text)
            };

            // Calculate the total income and expenses
            double totalIncome = budget.Income1 + budget.Income2 + budget.Income3 + budget.Income4;
            double totalExpenses = budget.Housing + budget.Utilities + budget.Insurance + budget.Transportation + budget.Debt + budget.Grocery + budget.DiningOut + budget.Savings;
            double net = totalIncome - totalExpenses;

            totalIncomeRTB.Text = totalIncome.ToString("C2");
            totalExpenseRTB.Text = totalExpenses.ToString("C2");
            netProfitLossRTB.Text = net.ToString("C2");

            if (net < 0) { netProfitLossRTB.BackColor = Color.Red; netProfitLossRTB.ForeColor = Color.White; }
            else { netProfitLossRTB.BackColor = Color.Green; netProfitLossRTB.ForeColor = Color.White; }
        }

        private double ConvertToDouble(string text)
        {
            // Check if the input is empty and treat it as 0.0
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0.0;
            }

            // Try to parse the text as a double
            if (double.TryParse(text, out double result))
            {
                return result;
            }
            else
            {
                // Display an error message only if the input is not empty and not a valid number
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.0;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            income1RTB.Clear();
            income2RTB.Clear();
            income3RTB.Clear();
            income4RTB.Clear();
            housingRTB.Clear();
            utilitiesRTB.Clear();
            insuranceRTB.Clear();
            transportationRTB.Clear();
            debtRTB.Clear();
            groceryRTB.Clear();
            diningRTB.Clear();
            savingsRTB.Clear();
            totalIncomeRTB.Clear();
            totalExpenseRTB.Clear();
            netProfitLossRTB.Clear();
            netProfitLossRTB.BackColor = Color.FromName("Control");
        }
    }
}
