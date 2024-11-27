using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    public class Account
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public int PIN { get; set; }
        public User Owner { get; set; }

        public void CheckProfile()
        {
            // Display user's profile details
            Console.WriteLine($"User: {Owner.Name}, Email: {Email}");
        }

        public void CheckTrashData(User user)
        {
            foreach (var transaction in user.CheckHistory())
            {
                // Logic to display trash data in transactions
            }
        }

        public void CheckATMLocation(PlasticATM atm)
        {
            Console.WriteLine($"ATM Location: {atm.ATMLocation}, Status: {atm.Status}");
        }
    }

}
