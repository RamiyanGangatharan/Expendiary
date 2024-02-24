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

SELECT * FROM transactions;
DELETE FROM users WHERE users.userID = 1;

DROP TABLE transactions;