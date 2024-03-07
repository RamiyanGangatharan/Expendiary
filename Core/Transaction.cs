namespace Expendiary.Core
{
    internal class Transaction
    {
        public int TransactionID { get; set; }
        public string Username { get; set; } 
        public string Company { get; set; } 
        public string Category { get; set; } 
        public decimal Amount { get; set; } 
        public DateTime DateOfPurchase { get; set; } 

        public Transaction()
        {
            TransactionID = 0;
            Username = "";
            Company = "";
            Category = "";
            Amount = 0.0m;
            DateOfPurchase = DateTime.UtcNow;
        }

        public Transaction(int transactionID, string username, string company, string category, decimal amount, DateTime dateOfPurchase)
        {
            TransactionID = transactionID;
            Username = username;
            Company = company;
            Category = category;
            Amount = amount;
            DateOfPurchase = dateOfPurchase;
        }
    }
}
