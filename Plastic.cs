using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    public class Plastic
    {
        public int MaterialID { get; set; }
        public string Type { get; set; }
        public float Quantity { get; set; }

        public void AddTrash(float amount)
        {
            Quantity += amount;
        }

        public string GetTrashInfo()
        {
            return $"Material ID: {MaterialID}, Type: {Type}, Quantity: {Quantity} kg";
        }

        public void UpdateTrash(float newQuantity)
        {
            Quantity = newQuantity;
        }
    }

}
