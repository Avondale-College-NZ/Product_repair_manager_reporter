using Product_repair_manager.Models;
using System;
using System.Linq;
namespace Product_repair_manager.Data
{
    public class DbInitializer
    {
        public static void Initialize(Product_repair_managerContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            var users = new User[]
            {
             new Models.User { FirstName = "Admin", LastName = "User", Email = "admin@test.com", role = "Admin" },
            new Models.User { FirstName = "John", LastName = "Tech", Email = "john@test.com", role = "Technician" },
             new Models.User { FirstName = "Jane", LastName = "Customer", Email = "jane@test.com", role = "Customer" }
            };

            foreach (User s in users)
            {
                context.User.Add(s);
            }
            context.SaveChanges();
        }
    }
}
