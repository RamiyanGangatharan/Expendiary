using Expendiary.Core;
using Expendiary.Data;

namespace Expendiary
{
    public partial class TransactionLog : Form
    {
        Database data = new Database();
        Core.Transaction transaction = new Core.Transaction();
        public TransactionLog() {InitializeComponent();}

        private void Main_Load(object sender, EventArgs e)
        {
            data.CreateConnection(TransactionGrid);
            data.OpenConnection();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            // Use UserSession.CurrentUsername to get the logged-in username
            string loggedInUsername = UserSession.CurrentUsername;

            Core.Transaction transaction = new Core.Transaction
            {
                Username = loggedInUsername, // Set the transaction's username
                Company = companyRTB.Text,
                Category = categoryCombo.Text,
                Amount = decimal.Parse(AmountRTB.Text), // Ensure this parsing is safe
                DateOfPurchase = DTP_insertion.SelectionStart
            };

            data.SQL_INSERT(transaction);
            data.LoadGridView(TransactionGrid);

            companyRTB.Clear();
            categoryCombo.SelectedIndex = 0;
            AmountRTB.Clear();
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Check if at least one row is selected
            if (TransactionGrid.SelectedRows.Count > 0)
            {
                var selectedRow = TransactionGrid.SelectedRows[0];
                // Retrieve the data from the selected row
                int transactionId = Convert.ToInt32(selectedRow.Cells[1].Value ?? default(int));
                string company = Convert.ToString(selectedRow.Cells[4].Value ?? string.Empty);
                string category = Convert.ToString(selectedRow.Cells[3].Value ?? string.Empty);
                decimal amount = Convert.ToDecimal(selectedRow.Cells[5].Value ?? default(decimal));
                DateTime dateOfPurchase = Convert.ToDateTime(selectedRow.Cells[0].Value ?? default(DateTime));

                Transaction selectedTransaction = new Transaction
                {
                    TransactionID = transactionId,
                    Username = UserSession.CurrentUsername, // Make sure UserSession.CurrentUsername is correctly set
                    Company = company,
                    Category = category,
                    Amount = amount,
                    DateOfPurchase = dateOfPurchase
                };

                // Update the UI elements with the selected transaction's details
                companyRTB.Text = selectedTransaction.Company;
                categoryCombo.Text = selectedTransaction.Category;
                AmountRTB.Text = selectedTransaction.Amount.ToString("0.00");
                DTP_insertion.SetDate(selectedTransaction.DateOfPurchase);

                data.SQL_DELETE(transactionId, TransactionGrid);
            }
            else
            {
                MessageBox.Show("Please select a transaction to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (TransactionGrid.SelectedRows.Count > 0)
            {
                int transactionId = Convert.ToInt32(TransactionGrid.SelectedRows[0].Cells[1].Value);

                // Confirm delete action with the user
                var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    bool isDeleted = data.SQL_DELETE(transactionId, TransactionGrid);
                    if (isDeleted)
                    {
                        MessageBox.Show("Transaction deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // You may want to handle the situation where the row was not deleted
                        MessageBox.Show("The transaction could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DTP_insertion_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
    }
}
