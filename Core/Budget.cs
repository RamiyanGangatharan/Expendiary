namespace Expendiary.Core
{
    internal class Budget
    {
        public int BudgetID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public decimal BudgetAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Budget()
        {
            BudgetID = 0;
            UserID = 0;
            CategoryID = 0;
            BudgetAmount = 0.0m;
            StartDate = DateTime.UtcNow;
            EndDate = DateTime.UtcNow.AddMonths(1); // Example: set to one month from now
        }

        public Budget(int budgetID, int userID, int categoryID, decimal budgetAmount, DateTime startDate, DateTime endDate)
        {
            BudgetID = budgetID;
            UserID = userID;
            CategoryID = categoryID;
            BudgetAmount = budgetAmount;
            StartDate = startDate;
            EndDate = endDate;
        }
    }

}
