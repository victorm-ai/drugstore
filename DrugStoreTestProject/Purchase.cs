using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        // Llave foránea a Provider
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }

        // Llave foránea a User (quien registra la compra)
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime PurchaseDate { get; set; }
        public float Total { get; set; }
        public string Status { get; set; }

        // Relación: una Purchase tiene muchos PurchaseDetails
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
    }
}
