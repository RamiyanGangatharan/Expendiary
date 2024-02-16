namespace Expendiary.Core
{
    internal class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Assuming you will store hash instead of plain password
        public DateTime CreationDate { get; set; }
        public DateTime? LastAccess { get; set; } // Nullable for cases when last access is not set

        // Default Constructor
        public User()
        {
            UserID = 0;
            Username = "default";
            PasswordHash = "defaultHash";
            CreationDate = DateTime.UtcNow;
            LastAccess = null; // Nullable DateTime, no need to set if default is null
        }

        // Parameterized Constructor
        public User(int userID, string username, string passwordHash, DateTime creationDate, DateTime? lastAccess)
        {
            UserID = userID;
            Username = username;
            PasswordHash = passwordHash;
            CreationDate = creationDate;
            LastAccess = lastAccess;
        }
    }
}
