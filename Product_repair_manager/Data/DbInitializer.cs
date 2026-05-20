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
            new Item_damages { ItemsId = 1, Item_damagesId = 1, damage_type = "Cracked Screen", severity = "High", date = "2025-01-10" },
            new Item_damages { ItemsId = 2, Item_damagesId = 2, damage_type = "Loose Hinge", severity = "Medium", date = "2025-01-15" },
            new Item_damages { ItemsId = 3, Item_damagesId = 3, damage_type = "Liquid Damage", severity = "High", date = "2025-01-20" },
            new Item_damages { ItemsId = 4, Item_damagesId = 4, damage_type = "Missing Keycaps", severity = "Low", date = "2025-01-25" },
            new Item_damages { ItemsId = 5, Item_damagesId = 5, damage_type = "Casing Crack", severity = "Medium", date = "2025-02-01" },
            new Item_damages { ItemsId = 6, Item_damagesId = 6, damage_type = "Power Jack Issue", severity = "High", date = "2025-02-05" },
            new Item_damages { ItemsId = 7, Item_damagesId = 7, damage_type = "Noisy Fan", severity = "Medium", date = "2025-02-10" },
            new Item_damages { ItemsId = 8, Item_damagesId = 8, damage_type = "Firmware Corruption", severity = "Medium", date = "2025-02-15" },
            new Item_damages { ItemsId = 9, Item_damagesId = 9, damage_type = "Battery Failure", severity = "High", date = "2025-02-20" },
            new Item_damages { ItemsId = 10, Item_damagesId = 10, damage_type = "Charging Cable Issue", severity = "Medium", date = "2025-02-25" },
            new Item_damages { ItemsId = 11, Item_damagesId = 11, damage_type = "Camera Misalignment", severity = "Medium", date = "2025-03-01" },
            new Item_damages { ItemsId = 12, Item_damagesId = 12, damage_type = "Broken Port Cover", severity = "Low", date = "2025-03-05" },
            new Item_damages { ItemsId = 13, Item_damagesId = 13, damage_type = "Overheating", severity = "High", date = "2025-03-10" },
            new Item_damages { ItemsId = 14, Item_damagesId = 14, damage_type = "Loose Wiring", severity = "Medium", date = "2025-03-15" },
            new Item_damages { ItemsId = 15, Item_damagesId = 15, damage_type = "Damaged Cable", severity = "High", date = "2025-03-20" },
            new Item_damages { ItemsId = 16, Item_damagesId = 16, damage_type = "Track Mechanism Lubrication", severity = "Low", date = "2025-03-25" },
            new Item_damages { ItemsId = 17, Item_damagesId = 17, damage_type = "Fuse Replacement", severity = "Medium", date = "2025-04-01" },
            new Item_damages { ItemsId = 18, Item_damagesId = 18, damage_type = "RAM Reseat", severity = "Medium", date = "2025-04-05" },
            new Item_damages { ItemsId = 19, Item_damagesId = 19, damage_type = "HDMI Port Replacement", severity = "High", date = "2025-04-10" },
            new Item_damages { ItemsId = 20, Item_damagesId = 20, damage_type = "Alignment Check", severity = "Low", date = "2025-04-15" },
        };
            foreach (Item_damages b in Item_damages)
            {
                context.Item_damages.Add(b);
            }
            context.SaveChanges();




            
            var damages_report = new damages_report[]
        {
            new damages_report { UserId = 1, ClassesId = 1, Item_damagesId = 1, damages_reportId = 1, fixed_report = "Replaced cracked screen", item_status = "Fixed", Item_date = "2025-01-10" },
            new damages_report { UserId = 2, ClassesId = 1, Item_damagesId =2, damages_reportId = 2, fixed_report = "Tightened loose hinge", item_status = "Operational", Item_date = "2025-01-15" },
            new damages_report { UserId = 3, ClassesId = 2, Item_damagesId = 3, damages_reportId = 3, fixed_report = "Cleaned liquid residue", item_status = "Monitoring", Item_date = "2025-02-01" },
            new damages_report { UserId = 4, ClassesId = 2, Item_damagesId = 4, damages_reportId = 4, fixed_report = "Replaced missing keycaps", item_status = "Fixed", Item_date = "2025-02-12" },
            new damages_report { UserId = 5, ClassesId = 3, Item_damagesId = 5, damages_reportId = 5, fixed_report = "Patched casing crack", item_status = "Operational", Item_date = "2025-02-20" },
            new damages_report { UserId = 6, ClassesId = 3, Item_damagesId = 6, damages_reportId = 6, fixed_report = "Re-soldered power jack", item_status = "Fixed", Item_date = "2025-03-03" },
            new damages_report { UserId = 7, ClassesId = 4, Item_damagesId = 7, damages_reportId = 7, fixed_report = "Replaced noisy fan", item_status = "Fixed", Item_date = "2025-03-10" },
            new damages_report { UserId = 8, ClassesId = 4, Item_damagesId = 8, damages_reportId = 8, fixed_report = "Updated firmware", item_status = "Operational", Item_date = "2025-03-18" },
            new damages_report { UserId = 9, ClassesId = 5, Item_damagesId = 9, damages_reportId = 9, fixed_report = "Replaced battery", item_status = "Fixed", Item_date = "2025-04-02" },
            new damages_report { UserId = 10, ClassesId = 5, Item_damagesId = 10, damages_reportId = 10, fixed_report = "Repaired charging cable", item_status = "Operational", Item_date = "2025-04-15" },
            new damages_report { UserId = 11, ClassesId = 6, Item_damagesId = 11, damages_reportId = 11, fixed_report = "Realigned camera module", item_status = "Fixed", Item_date = "2025-04-22" },
            new damages_report { UserId = 12, ClassesId = 6, Item_damagesId = 12, damages_reportId = 12, fixed_report = "Replaced broken port cover", item_status = "Operational", Item_date = "2025-05-01" },
            new damages_report { UserId = 13, ClassesId = 7, Item_damagesId = 13, damages_reportId = 13, fixed_report = "Reapplied thermal paste", item_status = "Fixed", Item_date = "2025-05-09" },
            new damages_report { UserId = 14, ClassesId = 7, Item_damagesId = 14, damages_reportId = 14, fixed_report = "Secured loose wiring", item_status = "Operational", Item_date = "2025-05-20" },
            new damages_report { UserId = 15, ClassesId = 8, Item_damagesId = 15, damages_reportId = 15, fixed_report = "Replaced damaged cable", item_status = "Fixed", Item_date = "2025-06-01" },
            new damages_report { UserId = 16, ClassesId = 8, Item_damagesId = 16, damages_reportId = 16, fixed_report = "Lubricated track mechanism", item_status = "Operational", Item_date = "2025-06-12" },
            new damages_report { UserId = 17, ClassesId = 9, Item_damagesId = 17, damages_reportId = 17, fixed_report = "Replaced fuse", item_status = "Fixed", Item_date = "2025-06-20" },
            new damages_report { UserId = 18, ClassesId = 9, Item_damagesId = 18, damages_reportId = 18, fixed_report = "Reseated RAM", item_status = "Operational", Item_date = "2025-07-05" },
            new damages_report { UserId = 19, ClassesId = 10, Item_damagesId = 19, damages_reportId = 19, fixed_report = "Replaced HDMI port", item_status = "Fixed", Item_date = "2025-07-18" },
            new damages_report { UserId = 20, ClassesId = 10, Item_damagesId = 20, damages_reportId = 20, fixed_report = "Adjusted alignment", item_status = "Operational", Item_date = "2025-07-28" },
        };
            foreach (damages_report d in damages_report)
            {
                context.damages_report.Add(d);
            }
            context.SaveChanges();

        }
    }
}
