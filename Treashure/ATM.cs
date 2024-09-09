using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    public class PlasticATM
    {
        public int ATMID { get; set; }
        public string ATMLocation { get; set; }
        public string Status { get; set; }

        public void AcceptPlastic(Plastic plastic, float quantity)
        {
            plastic.Quantity += quantity;
            Console.WriteLine($"Accepted {quantity} kg of plastic. Total: {plastic.Quantity} kg.");
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }
    }

}
