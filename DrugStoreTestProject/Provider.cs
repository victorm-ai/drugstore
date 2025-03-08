using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Relación: un Provider provee muchas Purchases
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
