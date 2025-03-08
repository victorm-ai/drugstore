using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // Relación: un Client puede estar asociado a muchas Sales
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
