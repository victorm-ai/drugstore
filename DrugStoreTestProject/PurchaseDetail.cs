using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class PurchaseDetail
    {
        public int PurchaseDetailId { get; set; }

        // Llave foránea a Purchase
        public int PurchaseId { get; set; }
        public Purchase Purchase { get; set; }

        // Llave foránea a Product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public float Cost { get; set; }
        public string LotNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
