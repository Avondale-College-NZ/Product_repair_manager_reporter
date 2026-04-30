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
            // Look for any User.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            var user = new User[]
            {
             new User { FirstName = "Admin", LastName = "blocks", Email = "admin@test.com", role = "student" },
            new User { FirstName = "John", LastName = "pork", Email = "john@test.com", role = "teacher" },
             new User { FirstName = "Jane", LastName = "iornlung", Email = "jane@test.com", role = "student" },
             new User { FirstName = "Alex", LastName = "Turner", Email = "alex.turner@test.com", role = "student" },
            new User { FirstName = "Bella", LastName = "Scott", Email = "bella.scott@test.com", role = "student" },
            new User { FirstName = "Chris", LastName = "Adams", Email = "chris.adams@test.com", role = "student" },
            new User { FirstName = "Diana", LastName = "Baker", Email = "diana.baker@test.com", role = "student" },
            new User { FirstName = "Ethan", LastName = "Clark", Email = "ethan.clark@test.com", role = "student" },
            new User { FirstName = "Fiona", LastName = "Hall", Email = "fiona.hall@test.com", role = "student" },
            new User { FirstName = "George", LastName = "Allen", Email = "george.allen@test.com", role = "student" },
            new User { FirstName = "Hannah", LastName = "Young", Email = "hannah.young@test.com", role = "student" },
            new User { FirstName = "Isaac", LastName = "King", Email = "isaac.king@test.com", role = "student" },
            new User { FirstName = "Julia", LastName = "Wright", Email = "julia.wright@test.com", role = "student" },
            new User { FirstName = "Kevin", LastName = "Green", Email = "kevin.green@test.com", role = "student" },
            new User { FirstName = "Lily", LastName = "Hill", Email = "lily.hill@test.com", role = "student" },
            new User { FirstName = "Mason", LastName = "Nelson", Email = "mason.nelson@test.com", role = "student" },
            new User { FirstName = "Nora", LastName = "Carter", Email = "nora.carter@test.com", role = "student" },
            new User { FirstName = "Oscar", LastName = "Mitchell", Email = "oscar.mitchell@test.com", role = "student" },
            new User { FirstName = "Penny", LastName = "Perez", Email = "penny.perez@test.com", role = "student" },
            new User { FirstName = "Ryan", LastName = "Roberts", Email = "ryan.roberts@test.com", role = "student" },
            new User { FirstName = "Sophia", LastName = "Campbell", Email = "sophia.campbell@test.com", role = "student" },
            new User { FirstName = "Tom", LastName = "Phillips", Email = "tom.phillips@test.com", role = "student" },
            new User { FirstName = "Uma", LastName = "Evans", Email = "uma.evans@test.com", role = "student" }
                        };

            foreach (User s in user)
            {
                context.User.Add(s);
            }
            context.SaveChanges();
            
            var Staff = new Staff[]
            {
             new Staff { FirstName = "ice", LastName = "blocks", Email = "admin@test.com", role = "IT" },
            new Staff { FirstName = "jake", LastName = "pork", Email = "john@test.com", role = "teacher" },
             new Staff { FirstName = "john", LastName = "iornlung", Email = "jane@test.com", role = "teacher" },
             new Staff { FirstName = "Alice", LastName = "Smith", Email = "alice.smith@test.com", role = "teacher" },
            new Staff { FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@test.com", role = "teacher" },
            new Staff { FirstName = "Carol", LastName = "Williams", Email = "carol.williams@test.com", role = "teacher" },
            new Staff { FirstName = "David", LastName = "Brown", Email = "david.brown@test.com", role = "teacher" },
            new Staff { FirstName = "Emma", LastName = "Jones", Email = "emma.jones@test.com", role = "teacher" },
            new Staff { FirstName = "Frank", LastName = "Garcia", Email = "frank.garcia@test.com", role = "teacher" },
            new Staff { FirstName = "Grace", LastName = "Miller", Email = "grace.miller@test.com", role = "teacher" },
            new Staff { FirstName = "Henry", LastName = "Davis", Email = "henry.davis@test.com", role = "teacher" },
            new Staff { FirstName = "Ivy", LastName = "Rodriguez", Email = "ivy.rodriguez@test.com", role = "teacher" },
            new Staff { FirstName = "Jack", LastName = "Martinez", Email = "jack.martinez@test.com", role = "teacher" },
            new Staff { FirstName = "Karen", LastName = "Hernandez", Email = "karen.hernandez@test.com", role = "teacher" },
            new Staff { FirstName = "Leo", LastName = "Lopez", Email = "leo.lopez@test.com", role = "teacher" },
            new Staff { FirstName = "Mia", LastName = "Gonzalez", Email = "mia.gonzalez@test.com", role = "teacher" },
            new Staff { FirstName = "Nathan", LastName = "Wilson", Email = "nathan.wilson@test.com", role = "teacher" },
            new Staff { FirstName = "Olivia", LastName = "Anderson", Email = "olivia.anderson@test.com", role = "teacher" },
            new Staff { FirstName = "Paul", LastName = "Thomas", Email = "paul.thomas@test.com", role = "teacher" },
            new Staff { FirstName = "Quinn", LastName = "Taylor", Email = "quinn.taylor@test.com", role = "teacher" },
            new Staff { FirstName = "Rachel", LastName = "Moore", Email = "rachel.moore@test.com", role = "teacher" },
            new Staff { FirstName = "Sam", LastName = "Jackson", Email = "sam.jackson@test.com", role = "teacher" },
            new Staff { FirstName = "Tina", LastName = "Martin", Email = "tina.martin@test.com", role = "teacher" }
            };

            foreach (Staff a in Staff)
            {
                context.Staff.Add(a);
            }
            context.SaveChanges();


            var Items = new Items[]
           {
           new Items { items_Name = "Laptop", CatagoryId = 1 },
           new Items { items_Name = "Desktop Computer", CatagoryId = 1 },
            new Items { items_Name = "Tablet", CatagoryId = 1 },
            new Items { items_Name = "Smartphone", CatagoryId = 1 },
            new Items { items_Name = "Monitor", CatagoryId = 1 },
            new Items { items_Name = "Keyboard", CatagoryId = 2 },
            new Items { items_Name = "Mouse", CatagoryId = 2 },
            new Items { items_Name = "Printer", CatagoryId = 3 },
            new Items { items_Name = "Scanner", CatagoryId = 3 },
            new Items { items_Name = "Projector", CatagoryId = 4 },
            new Items { items_Name = "Webcam", CatagoryId = 2 },
            new Items { items_Name = "Headphones", CatagoryId = 2 },
            new Items { items_Name = "Speakers", CatagoryId = 2 },
            new Items { items_Name = "External Hard Drive", CatagoryId = 5 },
            new Items { items_Name = "USB Flash Drive", CatagoryId = 5 },
            new Items { items_Name = "Router", CatagoryId = 6 },
            new Items { items_Name = "Modem", CatagoryId = 6 },
            new Items { items_Name = "Microphone", CatagoryId = 2 },
            new Items { items_Name = "Graphics Tablet", CatagoryId = 1 },
            new Items { items_Name = "Laptop Stand", CatagoryId = 2 },
            new Items { items_Name = "Docking Station", CatagoryId = 5 }
           };

            foreach (Items I in Items)
            {
                context.Items.Add(I);
            }
            context.SaveChanges();


            var Catagory = new Catagory[]
           {
           new Catagory { Catagory_Name = "eletroics" },
           new Catagory { Catagory_Name = "Furniture" },
            new Catagory { Catagory_Name = "Stationery" },
            new Catagory { Catagory_Name = "Appliances" },
            new Catagory { Catagory_Name = "Accessories" },
            new Catagory { Catagory_Name = "Networking" },
            new Catagory { Catagory_Name = "Storage Devices" },
            new Catagory { Catagory_Name = "Office Supplies" },
            new Catagory { Catagory_Name = "Audio Equipment" },
            new Catagory { Catagory_Name = "Video Equipment" },
            new Catagory { Catagory_Name = "Gaming" },
            new Catagory { Catagory_Name = "Software" },
            new Catagory { Catagory_Name = "Security" },
            new Catagory { Catagory_Name = "Cables" },
            new Catagory { Catagory_Name = "Wearables" },
            new Catagory { Catagory_Name = "Smart Home" },
            new Catagory { Catagory_Name = "Power Supplies" },
            new Catagory { Catagory_Name = "Printers & Ink" },
            new Catagory { Catagory_Name = "Cleaning Equipment" },
            new Catagory { Catagory_Name = "Lighting" },
            new Catagory { Catagory_Name = "Classroom Tools" }
           };

            foreach (Catagory C in Catagory)
            {
                context.Catagory.Add(C);
            }
            context.SaveChanges();


           var Classes = new Classes[]
           {
                new Classes { block = "A", classroom = 27},
                new Classes { block = "A", classroom = 28 },
                new Classes { block = "A", classroom = 29 },
                new Classes { block = "A", classroom = 30 },
                new Classes { block = "B", classroom = 1 },
                new Classes { block = "B", classroom = 2 },
                new Classes { block = "B", classroom = 3 },
                new Classes { block = "B", classroom = 4 },
                new Classes { block = "C", classroom = 5 },
                new Classes { block = "C", classroom = 6 },
                new Classes { block = "C", classroom = 7 },
                new Classes { block = "C", classroom = 8 },
                new Classes { block = "D", classroom = 9 },
                new Classes { block = "D", classroom = 10 },
                new Classes { block = "D", classroom = 11 },
                new Classes { block = "D", classroom = 12 },
                new Classes { block = "E", classroom = 13 },
                new Classes { block = "E", classroom = 14 },
                new Classes { block = "E", classroom = 15 },
                new Classes { block = "F", classroom = 16 },
                new Classes { block = "F", classroom = 17 }
           };

            foreach (Classes e in Classes)
            {
                context.Classes.Add(e);
            }
            context.SaveChanges();


            var Item_damages = new Item_damages[]
       {
          new Item_damages { ItemsId = 1, damage_type = "Scratch", severity = "Low", date = new DateOnly(2025, 1, 1) },
          new Item_damages { ItemsId = 2, damage_type = "Dent", severity = "Medium", date = new DateOnly(2025, 1, 2) },
          new Item_damages { ItemsId = 3, damage_type = "Crack", severity = "High", date = new DateOnly(2025, 1, 3) },
          new Item_damages { ItemsId = 4, damage_type = "Break", severity = "Critical", date = new DateOnly(2025, 1, 4) },
          new Item_damages { ItemsId = 5, damage_type = "Rust", severity = "Low", date = new DateOnly(2025, 1, 5) },
          new Item_damages { ItemsId = 6, damage_type = "Corrosion", severity = "Medium", date = new DateOnly(2025, 1, 6) },
          new Item_damages { ItemsId = 7, damage_type = "Burn", severity = "High", date = new DateOnly(2025, 1, 7) },
          new Item_damages { ItemsId = 8, damage_type = "Water Damage", severity = "Critical", date = new DateOnly(2025, 1, 8) },
          new Item_damages { ItemsId = 9, damage_type = "Tear", severity = "Low", date = new DateOnly(2025, 1, 9) },
          new Item_damages { ItemsId = 10, damage_type = "Loose Part", severity = "Medium", date = new DateOnly(2025, 1, 10) },
          new Item_damages { ItemsId = 11, damage_type = "Discoloration", severity = "Low", date = new DateOnly(2025, 1, 11) },
          new Item_damages { ItemsId = 12, damage_type = "Fracture", severity = "High", date = new DateOnly(2025, 1, 12) },
          new Item_damages { ItemsId = 13, damage_type = "Chip", severity = "Low", date = new DateOnly(2025, 1, 13) },
          new Item_damages { ItemsId = 14, damage_type = "Warp", severity = "Medium", date = new DateOnly(2025, 1, 14) },
          new Item_damages { ItemsId = 15, damage_type = "Leak", severity = "High", date = new DateOnly(2025, 1, 15) },
          new Item_damages { ItemsId = 16, damage_type = "Malfunction", severity = "Critical", date = new DateOnly(2025, 1, 16) },
          new Item_damages { ItemsId = 17, damage_type = "Bent", severity = "Medium", date = new DateOnly(2025, 1, 17) },
          new Item_damages { ItemsId = 18, damage_type = "Crush", severity = "High", date = new DateOnly(2025, 1, 18) },
          new Item_damages { ItemsId = 19, damage_type = "Peeling", severity = "Low", date = new DateOnly(2025, 1, 19) },
          new Item_damages { ItemsId = 20, damage_type = "Short Circuit", severity = "Critical", date = new DateOnly(2025, 1, 20) }
       };

            foreach (Item_damages D in Item_damages)
            {
                context.Item_damages.Add(D);
            }
            context.SaveChanges();


            var damages_report = new damages_report[]
              {
                 new damages_report { UserId = 1, ClassesId = 1, fixed_report = "Repaired screen", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 1), Item_damagesId = 1 },
                new damages_report { UserId = 2, ClassesId = 1, fixed_report = "Replaced battery", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 2), Item_damagesId = 2 },
                new damages_report { UserId = 3, ClassesId = 2, fixed_report = "Broken keyboard", item_status = "Pending", Item_date = new DateOnly(2026, 1, 3), Item_damagesId = 3 },
                new damages_report { UserId = 4, ClassesId = 2, fixed_report = "Water damage cleaned", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 4), Item_damagesId = 4 },
                new damages_report { UserId = 5, ClassesId = 3, fixed_report = "Cracked casing", item_status = "Pending", Item_date = new DateOnly(2026, 1, 5), Item_damagesId = 5 },
                new damages_report { UserId = 6, ClassesId = 3, fixed_report = "Screen flickering", item_status = "In Progress", Item_date = new DateOnly(2026, 1, 6), Item_damagesId = 6 },
                new damages_report { UserId = 7, ClassesId = 4, fixed_report = "Loose hinge fixed", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 7), Item_damagesId = 7 },
                new damages_report { UserId = 8, ClassesId = 4, fixed_report = "Touchpad not working", item_status = "Pending", Item_date = new DateOnly(2026, 1, 8), Item_damagesId = 8 },
                new damages_report { UserId = 9, ClassesId = 5, fixed_report = "Speaker issue resolved", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 9), Item_damagesId = 9 },
                new damages_report { UserId = 10, ClassesId = 5, fixed_report = "Overheating problem", item_status = "In Progress", Item_date = new DateOnly(2026, 1, 10), Item_damagesId = 10 },
                new damages_report { UserId = 11, ClassesId = 6, fixed_report = "Fan replaced", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 11), Item_damagesId = 11 },
                new damages_report { UserId = 12, ClassesId = 6, fixed_report = "Motherboard issue", item_status = "Pending", Item_date = new DateOnly(2026, 1, 12), Item_damagesId = 12 },
                new damages_report { UserId = 13, ClassesId = 7, fixed_report = "Software reinstall", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 13), Item_damagesId = 13 },
                new damages_report { UserId = 14, ClassesId = 7, fixed_report = "Virus removed", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 14), Item_damagesId = 14 },
                new damages_report { UserId = 15, ClassesId = 8, fixed_report = "Network card issue", item_status = "In Progress", Item_date = new DateOnly(2026, 1, 15), Item_damagesId = 15 },
                new damages_report { UserId = 16, ClassesId = 8, fixed_report = "Charging port replaced", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 16), Item_damagesId = 16 },
                new damages_report { UserId = 17, ClassesId = 9, fixed_report = "Display cable issue", item_status = "Pending", Item_date = new DateOnly(2026, 1, 17), Item_damagesId = 17 },
                new damages_report { UserId = 18, ClassesId = 9, fixed_report = "RAM upgraded", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 18), Item_damagesId = 18 },
                new damages_report { UserId = 19, ClassesId = 10, fixed_report = "Hard drive failure", item_status = "In Progress", Item_date = new DateOnly(2026, 1, 19), Item_damagesId = 19 },
                new damages_report { UserId = 20, ClassesId = 10, fixed_report = "SSD installed", item_status = "Fixed", Item_date = new DateOnly(2026, 1, 20), Item_damagesId = 20 }
            };

            foreach (damages_report R in damages_report)
            {
                context.damages_report.Add(R);
            }
            context.SaveChanges();

        }
    }
}
