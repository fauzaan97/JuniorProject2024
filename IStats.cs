using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treashure
{
    public interface IStats
    {
        Dictionary<string, decimal> CollectionAmounts { get; }

        void UpdateCollectionAmountsForThisMonth();
        void UpdateCollectionAmounts();
        void  UpdateNewestTransactions();
    }
}
