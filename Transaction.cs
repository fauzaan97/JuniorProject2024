using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime TransactionDate { get; set; }
        public float Amount { get; set; }
        public string Type { get; set; }  // e.g., Plastic Deposit, Bank Transfer

        public void Update(float newAmount)
        {
            Amount = newAmount;
        }

        public void Transfer(User user, float amount)
        {
            user.Balance += amount;
            Console.WriteLine($"Transferred {amount} to {user.Name}. New Balance: {user.Balance}");
        }
    }

}
