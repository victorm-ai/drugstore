using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreTestProject
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Permissions { get; set; }

        // Relación: un Role tiene muchos Users
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
