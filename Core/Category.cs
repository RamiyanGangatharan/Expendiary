namespace Expendiary.Core
{
    internal class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int UserID { get; set; }

        public Category()
        {
            CategoryID = 0;
            CategoryName = "defaultCategory";
            UserID = 0;
        }

        public Category(int categoryID, string categoryName, int userID)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
            UserID = userID;
        }
    }
}
