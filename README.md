# Side Project: Expendiary

## Overview

This side project, Transaction Tracker, is designed to provide a simple and secure way to log in and track financial transactions. The application directly interfaces with a database stored as an MDF file, ensuring that all transactions are recorded and can be reviewed at any time.

## Features

- **Secure Login**: User authentication to ensure secure access to transaction data.
- **Data Entry**: Easy-to-use interface for entering and tracking transactions.
- **Database Integration**: Direct integration with a SQL Server database via an MDF file for persistent storage of transaction data.

## Getting Started

To get started with the Transaction Tracker, follow these steps:

1. **Environment Setup**: Ensure you have SQL Server and your preferred development environment set up.
2. **Database Configuration**:
   - Locate the `.mdf` file in the project directory.
   - Attach the `.mdf` file to your SQL Server instance.
3. **Application Configuration**:
   - Open the project in your IDE.
   - Update the database connection string in the configuration file to point to your attached MDF file.
4. **Run the Application**: Build and run the application. Navigate to the login page to start tracking your transactions.

## Usage

1. **Login**: Access the application and log in using your credentials.
2. **Enter Transactions**: Once logged in, use the data entry form to input your transactions.
3. **Review Transactions**: View and manage your recorded transactions through the application interface.

## Technical Details

- **Backend**: The application backend is responsible for handling user authentication, data processing, and database interactions.
- **Frontend**: Provides a user-friendly interface for logging in, entering transactions, and reviewing transaction history.
- **Database**: Utilizes a SQL Server database stored as an MDF file for data storage. Ensure proper configuration and connection to this database for the application to function correctly.

## Contributing

Contributions to the Transaction Tracker are welcome! If you have suggestions or improvements, please fork the repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
