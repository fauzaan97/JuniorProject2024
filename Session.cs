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
        private static string UserName { get; set; }
        private static string Email { get; set; }
        private static string Role { get; set; }

        public static string GetUserName()
        {
            return UserName;
        }

        public static void SetUserName(string userName)
        {
            UserName = userName ?? string.Empty;

        }

        public static string GetEmail()
        {
            return Email;
        }

        public static void SetEmail(string email)
        {
            Email = email ?? string.Empty;
        }

        public static string GetRole()
        {
            return Role;
        }

        public static void SetRole(string role)
        {
            Role = role ?? string.Empty;

        }

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
