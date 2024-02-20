using Expendiary.Core;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Expendiary.Data
{
    internal class Database
    {
        private SqlConnection conn;
        private SqlCommand command;

        public Database()
        {
            string connectionString = "Data Source=LAPTOP-3UT42LKF;Initial Catalog=Expendiary;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(connectionString);
            command = new SqlCommand(connectionString, conn);
        }

        public bool Login(string username, string password)
        {
            bool isAuthenticated = false;

            // Open the connection
            OpenConnection();

            // Prepare the command for authentication check
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

        public void SQL_SELECT()
        {
            OpenConnection();
            command.CommandText =
               "SELECT " +
               "dateOfPurchase AS 'DATE', " +
               "transactionID AS 'TRANSACTION', " +
               "username AS 'USERNAME', " +
               "category AS 'CATEGORY', " +
               "company AS 'COMPANY', " + 
               "amount AS '($)' " + 
               "FROM transactions " + 
               "ORDER BY dateOfPurchase, transactionID";
        }

        /*
            SQL_INSERT FUNCTION HERE
         */
        public void SQL_DELETE(string invoiceNumber)
        {

        }

        public void SQL_RETRIEVE(DataGridView TransactionGrid)
        {
            OpenConnection();
            SqlDataAdapter DA = new SqlDataAdapter(command);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            TransactionGrid.Refresh();
            TransactionGrid.DataSource = DT;
        }

        public void LoadGridView(DataGridView TransactionGrid)
        {
            OpenConnection();
            try
            {
                SQL_SELECT();
                SQL_RETRIEVE(TransactionGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        public void CreateConnection(DataGridView TransactionGrid)
        {
            string connectionString = "Data Source=LAPTOP-3UT42LKF;Initial Catalog=Expendiary;Integrated Security=True;Encrypt=False";

            conn = new SqlConnection(connectionString);
            command = new SqlCommand(connectionString, conn);

            conn = new SqlConnection(connectionString);
            conn.Open();
            command = conn.CreateCommand();
            LoadGridView(TransactionGrid);
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

