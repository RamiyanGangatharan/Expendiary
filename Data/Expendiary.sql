CREATE TABLE users
(
    userID INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(25) UNIQUE NOT NULL,
    passwordHash VARCHAR(255) NOT NULL,
    creationDate DATETIME NOT NULL DEFAULT GETDATE(), 
    lastAccess DATETIME NULL,
);

CREATE TABLE transactions
(
    transactionID INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(25) REFERENCES users(username),
    company VARCHAR(100) NOT NULL,
    category VARCHAR(50) CHECK (category IN ('Income', 'Housing', 'Transportation', 'Dining', 'Utilities', 'Entertainment', 'Grocery', 'Fuel', 'Insurance', 'Medical', 'Savings', 'Investments', 'Miscellaneous')),
    amount DECIMAL(10,2) NOT NULL,
    dateOfPurchase DATE NOT NULL
);

CREATE TABLE Categories
(
    categoryID INT IDENTITY(1,1) PRIMARY KEY,
    categoryName VARCHAR(50) UNIQUE NOT NULL
);

CREATE VIEW vw_UserFinancialSummary AS
SELECT
    u.username,
    ISNULL(SUM(CASE WHEN t.category = 'Income' THEN t.amount ELSE 0 END), 0) AS TotalIncome,
    ISNULL(SUM(CASE WHEN t.category NOT IN ('Income') THEN t.amount ELSE 0 END), 0) AS TotalExpenses,
    ISNULL(SUM(CASE WHEN t.category = 'Income' THEN t.amount ELSE -t.amount END), 0) AS FundsRemaining,
    CASE 
        WHEN ISNULL(SUM(CASE WHEN t.category = 'Income' THEN t.amount ELSE -t.amount END), 0) < 0 THEN 'OVER BUDGET'
        ELSE 'UNDER BUDGET'
    END AS BudgetStatus
FROM users u
LEFT JOIN transactions t ON u.username = t.username
GROUP BY u.username;

SELECT * FROM users;