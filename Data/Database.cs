using Expendiary.Core;
using Expendiary.UI;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Expendiary.Data
{
    internal class Database
    {
        private SqlConnection conn;
        private SqlCommand command;

        public Database()
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Directory\\Durham College\\Semester 4\\Expendiary\\Data\\Expendiary.mdf\"; Integrated Security = True";
            conn = new SqlConnection(connectionString);
            command = new SqlCommand(connectionString, conn);
        }

        public bool Login(string username, string password)
        {
            bool isAuthenticated = false;

            // Open the connection
            OpenConnection();

            // Prepare the command for authentication check
            command.Parameters.Clear();
            command.CommandText = "SELECT COUNT(1) FROM users WHERE username = @username AND passwordHash = @password";
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password); // This should ideally be a hashed password

            // Execute the command
            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count > 0)
            {
                isAuthenticated = true;

                // User is authenticated, now update the lastAccess field
                command.CommandText = "UPDATE users SET lastAccess = @lastAccess WHERE username = @username";
                command.Parameters.AddWithValue("@lastAccess", DateTime.Now);

                // Execute the update command
                command.ExecuteNonQuery();
            }

            // Close the connection
            CloseConnection();

            // Return true if a match is found and lastAccess is updated
            return isAuthenticated;
        }

        // WILL ADD HASHING LATER
        public bool CreateUser(string username, string password)
        {
            try
            {
                // Open the connection
                OpenConnection();

                // Prepare the command to insert the user
                command.CommandText = "INSERT INTO users (username, passwordHash, creationDate) VALUES (@username, @password, @creationDate)";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // Storing the password as plain text (not recommended)
                command.Parameters.AddWithValue("@creationDate", DateTime.Now);

                // Execute the command
                int result = command.ExecuteNonQuery();

                // Close the connection
                CloseConnection();

                // Return true if one row was inserted
                return result == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void SQL_SELECT_TRANSACTIONS()
        {
            if (UserSession.CurrentUsername == "Admin")
            {
                command.Parameters.Clear();
                command.CommandText =
                    "SELECT " +
                    "dateOfPurchase AS 'DATE', " +
                    "transactionID AS 'TRANS #', " +
                    "username AS 'USERNAME', " +
                    "category AS 'CATEGORY', " +
                    "company AS 'COMPANY', " +
                    "FORMAT(amount, 'C', 'en-US') AS 'AMOUNT' " + // Note the use of FORMAT here
                    "FROM transactions " +
                    "ORDER BY dateOfPurchase DESC";
                command.Parameters.AddWithValue("@Username", UserSession.CurrentUsername);
            }
            else
            {
                command.Parameters.Clear();
                command.CommandText =
                    "SELECT " +
                    "dateOfPurchase AS 'DATE', " +
                    "transactionID AS 'TRANS #', " +
                    "username AS 'USERNAME', " +
                    "category AS 'CATEGORY', " +
                    "company AS 'COMPANY', " +
                    "FORMAT(amount, 'C', 'en-US') AS 'AMOUNT' " + // Note the use of FORMAT here
                    "FROM transactions " +
                    "WHERE username = @Username " +
                    "ORDER BY dateOfPurchase DESC";
                command.Parameters.AddWithValue("@Username", UserSession.CurrentUsername);
            }
        }

        public void SQL_INSERT_TRANSACTIONS(Core.Transaction transaction)
        {
            OpenConnection();

            try
            {
                command.Parameters.AddWithValue("@Username", UserSession.CurrentUsername);
                command.CommandText = "INSERT INTO transactions (Username, Company, Category, Amount, DateOfPurchase) VALUES (@Username, @Company, @Category, @Amount, @DateOfPurchase)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Username", transaction.Username);
                command.Parameters.AddWithValue("@Company", transaction.Company);
                command.Parameters.AddWithValue("@Category", transaction.Category);
                command.Parameters.AddWithValue("@Amount", transaction.Amount);
                command.Parameters.AddWithValue("@DateOfPurchase", transaction.DateOfPurchase);
                command.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                // Handle exceptions
                Console.WriteLine(e.Message);
            }
        }

        public bool SQL_DELETE_TRANSACTIONS(int transactionId, DataGridView TransactionGrid)
        {
            try
            {
                // Open the connection
                OpenConnection();

                // Prepare the command to delete the transaction
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM transactions WHERE transactionID = @transactionId";
                command.Parameters.AddWithValue("@transactionId", transactionId);

                // Execute the command
                int result = command.ExecuteNonQuery();
                LOAD_GRID_VIEW_TRANSACTIONS(TransactionGrid);

                // Return true if one row was deleted
                return result == 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void SQL_RETRIEVE_TRANSACTIONS(DataGridView TransactionGrid)
        {
            SqlDataAdapter DA = new SqlDataAdapter(command);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            TransactionGrid.DataSource = DT;
        }
        
       

        public void LOAD_GRID_VIEW_TRANSACTIONS(DataGridView TransactionGrid)
        {
            OpenConnection();
            try
            {
                SQL_SELECT_TRANSACTIONS();
                SQL_RETRIEVE_TRANSACTIONS(TransactionGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        public void CreateConnection_Transactions(DataGridView TransactionGrid)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Directory\\Durham College\\Semester 4\\Expendiary\\Data\\Expendiary.mdf\"; Integrated Security = True";

            conn = new SqlConnection(connectionString);
            conn.Open();
            command = conn.CreateCommand();
            LOAD_GRID_VIEW_TRANSACTIONS(TransactionGrid);
        }

        
        public void SQL_SELECT_BUDGET(DataGridView BudgetGrid)
        {
            if (UserSession.CurrentUsername == "Admin")
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM vw_UserFinancialSummary;";
                command.Parameters.AddWithValue("@Username", UserSession.CurrentUsername);
            }
            else
            {
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM vw_UserFinancialSummary WHERE username = @Username";
                command.Parameters.AddWithValue("@Username", UserSession.CurrentUsername);
            }
        }

        public void SQL_RETRIEVE_BUDGETS(DataGridView BudgetGrid)
        {
            SqlDataAdapter DA = new SqlDataAdapter(command);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            BudgetGrid.DataSource = DT;
        }

        public void LOAD_GRID_VIEW_BUDGETS(DataGridView BudgetGrid)
        {
            OpenConnection();
            try
            {
                SQL_SELECT_BUDGET(BudgetGrid);
                SQL_RETRIEVE_BUDGETS(BudgetGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        public void CreateConnection_Budgets(DataGridView BudgetGrid)
        {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"D:\\Directory\\Durham College\\Semester 4\\Expendiary\\Data\\Expendiary.mdf\"; Integrated Security = True";

            conn = new SqlConnection(connectionString);
            conn.Open();
            command = conn.CreateCommand();
            LOAD_GRID_VIEW_BUDGETS(BudgetGrid);
        }


        public void OpenConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}

