using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class SaleDetail
    {
        public int SaleDetailId { get; set; }

        // Llave foránea a Sale
        public int SaleId { get; set; }
        public Sale Sale { get; set; }

        // Llave foránea a Product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
    }
}
