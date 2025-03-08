using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class Sale
    {
        public int SaleId { get; set; }

        // Llave foránea a User
        public int UserId { get; set; }
        public User User { get; set; }

        // Llave foránea a Client
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime SaleDate { get; set; }
        public float Total { get; set; }
        public string PaymentMethod { get; set; }

        // Relación: una Sale tiene muchos SaleDetails
        public ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();
    }
}
