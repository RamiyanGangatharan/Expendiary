using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendiary.Core
{
    public static class UserSession
    {
        public static string CurrentUsername { get; private set; }

        public static void Login(string username)
        {
            CurrentUsername = username;
        }

        public static void Logout()
        {
            CurrentUsername = null;
        }
    }
}
