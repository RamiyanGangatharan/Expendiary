using Microsoft.VisualBasic;

namespace Expendiary.Core
{
    internal class Budget
    {
        public double Income1 { get; set; }
        public double Income2 { get; set; }
        public double Income3 { get; set; }
        public double Income4 { get; set; }
        public double Housing { get; set; }
        public double Utilities { get; set; }
        public double Insurance { get; set; }
        public double Transportation { get; set; }
        public double Debt { get; set; }
        public double Grocery { get; set; }
        public double DiningOut { get; set; }
        public double Savings { get; set; }

        // Default constructor
        public Budget()
        {
            Income1 = 0.00;
            Income2 = 0.00;
            Income3 = 0.00;
            Income4 = 0.00;
            Housing = 0.00;
            Utilities = 0.00;
            Insurance = 0.00;
            Transportation = 0.00;
            Debt = 0.00;
            Grocery = 0.00;
            DiningOut = 0.00;
            Savings = 0.00;
        }

        // Parameterized constructor
        public Budget(double income1, double income2, double income3, double income4, double housing, double utilities, double insurance, double transportation,
                      double debt, double grocery, double diningOut, double savings)
        {
            Income1 = income1;
            Income2 = income2;
            Income3 = income3;
            Income4 = income4;
            Housing = housing;
            Utilities = utilities;
            Insurance = insurance;
            Transportation = transportation;
            Debt = debt;
            Grocery = grocery;
            DiningOut = diningOut;
            Savings = savings;
        }
    }

}
