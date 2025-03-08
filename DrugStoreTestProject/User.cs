using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Llave foránea a Role
        public int RoleId { get; set; }
        public Role Role { get; set; }

        // Relación: un User registra muchas Sales
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

        // Relación: un User registra muchas Purchases
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
