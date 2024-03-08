# Side Project: Expendiary

## Overview

Expendiary began as a focused ambition to develop a comprehensive Transaction Log application during the reading week of February 15, 2024. However, as I delved deeper into the project, I recognized the potential for a more expansive suite of financial management tools. This realization led to the conceptualization of Expendiary as a suite, with a central Dashboard serving as the hub for accessing various financial management applications. Initiated with the intent to enhance personal financial tracking and management, this project marks the beginning of an ongoing endeavor that I plan to expand and refine throughout my tenure at Durham College. The evolution from a singular application to a multifaceted suite underscores my commitment to providing a robust, user-friendly tool for personal finance management.

## Features

- **Secure Login**: User authentication to ensure secure access to transaction data.
- **Data Entry**: Easy-to-use interface for entering and tracking transactions.
- **Database Integration**: Direct integration with a SQL Server database via an MDF file for persistent storage of transaction data.
- **Budgeting Capabilities**: Simple forms to create budgets and to track your current spending habits.


## Main Applications Within this Application (Work in Progress)
   ### Login (Work in Progress)
   - This window demonstrates database usage as it must verify a user exists with the right password through the users table.
   - In the future, I will be implementing password hashing as I have learned it in web development classes in college.

   ### Registration (Work in Progress)
   - This window demonstrates database usage through insert statements with validation where it must first check if the user exists, then insert the row into the database now creating a user.

   ### Dashboard (Work in Progress)
   - This window is the central hub for my application.
      - think of it like the Adobe suite but less sophisticated where you can access all the applications created in relation to the project as a whole.

   ### Transaction Log (Work in Progress)
   - This window was initially the application I was going to make until I realized the potential to create a suite of apps within this project as I had lots of time during my reading week.
   
   ### Budgets (Work in Progress)
   - This window allows has two functions
      1. **Financial Overview**
         - This tab displays the current financial situation of the user, how much they have made in income, how much they are spending, and if they are over or under budget.
      2. **Theoretical Budgeting Calculator**
         - This tab is a form that you can input your expenses and income and see how much money you save or lose.

   ### Investments (not started yet)
   ### Reports (not started yet)
   ### Settings (not started yet)

   ### Help (Work in Progress)
   - This window is intended to be the central area for the documentation of the application to help users fix issues within the program and to act like a tutoral for it.

## Getting Started

To get started with the Transaction Tracker, follow these steps:

1. **Environment Setup**: Ensure you have SQL Server and your preferred development environment set up.
2. **Database Configuration**: (NOTE: I have reset the directories to where you do not need to modify the paths for MDF or database files)
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
4. **View Gains & Losses**: View the flow of income and expenses through the budgeting section of the app.
5. **Create Budgets**: Using my budgeting tool, you can create budgets of your own.

## Technical Details

- **Backend**: The application backend is responsible for handling user authentication, data processing, and database interactions.
- **Frontend**: Provides a user-friendly interface for logging in, entering transactions, and reviewing transaction history.
- **Database**: Utilizes a SQL Server database stored as an MDF file for data storage. Ensure proper configuration and connection to this database for the application to function correctly.

## Contributing

Contributions to the Transaction Tracker are welcome! If you have suggestions or improvements, please fork the repository and submit a pull request with your changes.
