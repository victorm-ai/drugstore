using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public bool RequiresPrescription { get; set; }
        public int Stock { get; set; }

        // Llave foránea a Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Relación: un Product aparece en muchos SaleDetails
        public ICollection<SaleDetail> SaleDetails { get; set; } = new List<SaleDetail>();

        // Relación: un Product aparece en muchos PurchaseDetails
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
    }
}
