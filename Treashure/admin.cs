using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    public class Admin : User
    {
        public int AdminID { get; set; }
        public bool Permission { get; set; }

        public void ManageUserHistory(User user)
        {
            // Logic to manage user's history
            foreach (var transaction in user.CheckHistory())
            {
                // Display or process the user's transaction history
            }
        }

        public void ManageATM(PlasticATM atm, string newStatus)
        {
            atm.UpdateStatus(newStatus);
        }

        public void ManageTrashData(Plastic trash)
        {
            // Logic to manage plastic data
        }
    }

}
