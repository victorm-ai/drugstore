using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DrugStoreTestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opciones de EF Core: ajusta para tu proveedor preferido
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Data Source=");

            using (var context = new AppDbContext(optionsBuilder.Options))
            {
                // Crea o migra la base de datos (en ambiente de desarrollo)
                context.Database.EnsureCreated();
                // Para entornos productivos se recomienda: context.Database.Migrate();

                // Sembrado de datos inicial (si no existen)
                SeedInitialData(context);

                // Ejemplo de consulta: obtener todos los productos
                var products = context.Products
                                      .Include(p => p.Category)
                                      .ToList();

                Console.WriteLine("Productos en la base de datos:");
                foreach (var p in products)
                {
                    Console.WriteLine($"- {p.ProductName} | Categoría: {p.Category?.CategoryName}");
                }

                Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
                Console.ReadKey();
            }
        }

        private static void SeedInitialData(AppDbContext context)
        {
            // Roles
            if (!context.Roles.Any())
            {
                var adminRole = new Role { RoleName = "Administrator", Permissions = "All" };
                var cashierRole = new Role { RoleName = "Cashier", Permissions = "Sales,Refunds" };

                context.Roles.AddRange(adminRole, cashierRole);
                context.SaveChanges();
            }

            // Usuarios
            if (!context.Users.Any())
            {
                var adminRoleId = context.Roles.First(r => r.RoleName == "Administrator").RoleId;
                var user = new User
                {
                    Username = "admin",
                    Password = "admin123", // en producción, encriptar o hashear
                    RoleId = adminRoleId
                };
                context.Users.Add(user);
                context.SaveChanges();
            }

            // Categorías
            if (!context.Categories.Any())
            {
                var cat1 = new Category { CategoryName = "Analgesics" };
                var cat2 = new Category { CategoryName = "Antibiotics" };
                context.Categories.AddRange(cat1, cat2);
                context.SaveChanges();
            }

            // Productos
            if (!context.Products.Any())
            {
                var catAnalgesicsId = context.Categories.First(c => c.CategoryName == "Analgesics").CategoryId;
                var product = new Product
                {
                    ProductName = "Acetaminophen",
                    Price = 2.50f,
                    RequiresPrescription = false,
                    Stock = 100,
                    CategoryId = catAnalgesicsId
                };
                context.Products.Add(product);
                context.SaveChanges()
            }

            // Proveedores, Clientes, etc. (puedes agregar más ejemplos)
            if (!context.Providers.Any())
            {
                var provider = new Provider
                {
                    ProviderName = "PharmaCorp",
                    Address = "Calle 123, Ciudad",
                    Phone = "555-1234",
                    Email = "contact@pharmacorp.com"
                };
                context.Providers.Add(provider);
                context.SaveChanges();
            }

            if (!context.Clients.Any())
            {
                var client = new Client
                {
                    ClientName = "Juan Pérez",
                    Phone = "555-5678",
                    Email = "juan@example.com"
                };
                context.Clients.Add();
                context.SaveChanges();
            }
        }
    }
}
