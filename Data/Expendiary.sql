CREATE TABLE users
(
    userID INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(25) NOT NULL UNIQUE,
    passwordHash VARCHAR(255) NOT NULL,
    creationDate DATETIME NOT NULL, 
    lastAccess DATETIME NULL 
);

CREATE TABLE categories
(
    categoryID INT IDENTITY(1,1) PRIMARY KEY,
    categoryName VARCHAR(25) NOT NULL,
    userID INT NOT NULL,
    FOREIGN KEY (userID) REFERENCES users(userID) ON DELETE CASCADE,
    UNIQUE(userID, categoryName)
);

CREATE TABLE budgets
(
    budgetID INT IDENTITY(1,1) PRIMARY KEY,
    userID INT NOT NULL,
    categoryID INT NOT NULL,
    budgetAmount DECIMAL(19,4),
    startDate DATETIME, 
    endDate DATETIME, 
    FOREIGN KEY (userID) REFERENCES users(userID),
    FOREIGN KEY (categoryID) REFERENCES categories(categoryID),
    UNIQUE(userID, categoryID, startDate, endDate) 
);

CREATE TABLE transactions
(
    transactionID INT IDENTITY(1,1) PRIMARY KEY,
    userID INT NOT NULL,
    categoryID INT NOT NULL,
    transactionAmount DECIMAL(19,4) NOT NULL,
    transactionDate DATETIME NOT NULL, 
    transactionDescription VARCHAR(255),
    paymentMethod VARCHAR(50),
    FOREIGN KEY (userID) REFERENCES users(userID),
    FOREIGN KEY (categoryID) REFERENCES categories(categoryID)
);

CREATE TABLE settings
(
    settingID INT IDENTITY(1,1) PRIMARY KEY,
    userID INT NOT NULL,
    settingName VARCHAR(25) NOT NULL,
    settingValue VARCHAR(255),
    FOREIGN KEY (userID) REFERENCES users(userID),
    UNIQUE(userID, settingName)
);


DROP TABLE settings;
DROP TABLE transactions;
DROP TABLE budgets;
DROP TABLE categories;
DROP TABLE users;

SELECT * FROM users;