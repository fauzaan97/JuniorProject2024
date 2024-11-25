using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    internal static class SessionManager
    {
        // Static properties to store session data
        public static string UserName { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; }

        // Static constructor - This runs once when the class is first used
        static SessionManager()
        {
            // Initialize default values if necessary (optional)
            UserName = string.Empty;
            Email = string.Empty;
            Role = "user"; // Default role (optional)
        }

        // Clear the session data when the user logs out
        public static void Logout()
        {
            UserName = null;
            Email = null;
            Role = null;
        }

        // Check if a user is logged in
        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(Email);
        }
    }

}
