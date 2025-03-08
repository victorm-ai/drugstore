using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Relación: una Category tiene muchos Products
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
