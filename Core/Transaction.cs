namespace Expendiary.Core
{
    internal class Transaction
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; }
        public string PaymentMethod { get; set; }

        public Transaction()
        {
            TransactionID = 0;
            UserID = 0;
            CategoryID = 0;
            TransactionAmount = 0.0m;
            TransactionDate = DateTime.UtcNow;
            TransactionDescription = "defaultDescription";
            PaymentMethod = "defaultMethod";
        }

        public Transaction(int transactionID, int userID, int categoryID, decimal transactionAmount, DateTime transactionDate, string transactionDescription, string paymentMethod)
        {
            TransactionID = transactionID;
            UserID = userID;
            CategoryID = categoryID;
            TransactionAmount = transactionAmount;
            TransactionDate = transactionDate;
            TransactionDescription = transactionDescription;
            PaymentMethod = paymentMethod;
        }
    }

}
