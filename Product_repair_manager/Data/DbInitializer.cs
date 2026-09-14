using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.Identity.Client;
using Product_repair_manager.Models;
using Product_repair_manager.Data;
using System;
using System.Linq;


namespace Product_repair_manager.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProductrepairmanagerContext context)
        {


            context.Database.EnsureCreated();
            // Look for any User.
            if (context.Classes.Any())
            {
                return;   // DB has been seeded
            }


            var Classes = new Classes[]
{
                new Classes { blocks = "A", classroom = 27},
                new Classes { blocks = "A", classroom = 28 },
                new Classes { blocks = "A", classroom = 29 },
                new Classes { blocks = "A", classroom = 30 },
                new Classes { blocks = "B", classroom = 1 },
                new Classes { blocks = "B", classroom = 2 },
                new Classes { blocks = "B", classroom = 3 },
                new Classes { blocks = "B", classroom = 4 },
                new Classes { blocks = "C", classroom = 5 },
                new Classes { blocks = "C", classroom = 6 },
                new Classes { blocks = "C", classroom = 7 },
                new Classes { blocks = "C", classroom = 8 },
                new Classes { blocks = "D", classroom = 9 },
                new Classes { blocks = "D", classroom = 10 },
                new Classes { blocks = "D", classroom = 11 },
                new Classes { blocks = "D", classroom = 12 },
                new Classes { blocks = "E", classroom = 13 },
                new Classes { blocks = "E", classroom = 14 },
                new Classes { blocks = "E", classroom = 15 },
                new Classes { blocks = "F", classroom = 16 },
                new Classes { blocks = "F", classroom = 17 }
};

            foreach (Classes L in Classes)
            {
                context.Classes.Add(L);
            }
            context.SaveChanges();


            //var ApplicationUser = new ApplicationUser[]
            //    {
            //    new ApplicationUser { FirstName = "F3", LastName = "F3", Email = "F3@F3.com", PasswordHash = "F3@F3.com" }
            //    };
            //foreach (ApplicationUser U in ApplicationUser)
            //{
            //    context.ApplicationUser.Add(U);
            //}
            //context.SaveChanges();


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


            var Item_damages = new Item_damages[]
         {
            new Item_damages { ItemsId = 1, Item_damagesId = 1, damage_type = "Scratch", severity = "Low", date = DateTime.Now.AddDays(-10) },
            new Item_damages { ItemsId = 2, Item_damagesId = 2, damage_type = "Dent", severity = "Medium", date = DateTime.Now.AddDays(-9) },
            new Item_damages { ItemsId = 3, Item_damagesId = 3, damage_type = "Break", severity = "High", date = DateTime.Now.AddDays(-8) },
            new Item_damages { ItemsId = 4, Item_damagesId = 4, damage_type = "Crack", severity = "Medium", date = DateTime.Now.AddDays(-7) },
            new Item_damages { ItemsId = 5, Item_damagesId = 5, damage_type = "Rust", severity = "Low", date = DateTime.Now.AddDays(-6) },
            new Item_damages { ItemsId = 6, Item_damagesId = 6, damage_type = "Shattered", severity = "High", date = DateTime.Now.AddDays(-5) },
            new Item_damages { ItemsId = 7, Item_damagesId = 7, damage_type = "Tear", severity = "Medium", date = DateTime.Now.AddDays(-4) },
            new Item_damages { ItemsId = 8, Item_damagesId = 8, damage_type = "Bend", severity = "Low", date = DateTime.Now.AddDays(-3) },
            new Item_damages { ItemsId = 9, Item_damagesId = 9, damage_type = "Peel", severity = "Medium", date = DateTime.Now.AddDays(-2) },
            new Item_damages { ItemsId = 10, Item_damagesId = 10, damage_type = "Dirt", severity = "Low", date = DateTime.Now.AddDays(-1) },
            new Item_damages { ItemsId = 11, Item_damagesId = 11, damage_type = "Chip", severity = "Medium", date = DateTime.Now.AddDays(-4)},
            new Item_damages { ItemsId = 12, Item_damagesId = 12, damage_type = "Scratch", severity = "Low", date = DateTime.Now.AddDays(1) },
            new Item_damages { ItemsId = 13, Item_damagesId = 13, damage_type = "Leak", severity = "High", date = DateTime.Now.AddDays(2) },
            new Item_damages { ItemsId = 14, Item_damagesId = 14, damage_type = "Fade", severity = "Medium", date = DateTime.Now.AddDays(3) },
            new Item_damages { ItemsId = 15, Item_damagesId = 15, damage_type = "Stain", severity = "Medium", date = DateTime.Now.AddDays(4) },
            new Item_damages { ItemsId = 16, Item_damagesId = 16, damage_type = "Warp", severity = "High", date = DateTime.Now.AddDays(5) },
            new Item_damages { ItemsId = 17, Item_damagesId = 17, damage_type = "Dirt", severity = "Low", date = DateTime.Now.AddDays(6) },
            new Item_damages { ItemsId = 18, Item_damagesId = 18, damage_type = "Rust", severity = "Critical", date = DateTime.Now.AddDays(7) },
            new Item_damages { ItemsId = 19, Item_damagesId = 19, damage_type = "Crack", severity = "Medium", date = DateTime.Now.AddDays(8) },
            new Item_damages { ItemsId = 20, Item_damagesId = 20, damage_type = "Shatter", severity = "High", date = DateTime.Now.AddDays(9) }

        };
            foreach (Item_damages t in Item_damages)
            {
                context.Item_damages.Add(t);
            }
            context.SaveChanges();



            var damages_report = new damages_report[]
        {
            new damages_report { ClassesId = 1, Item_damagesId = 1, damages_reportId = 1, fixed_report = "Replaced cracked screen", item_status = "Fixed", Item_date = "2025-01-10" },
            new damages_report { ClassesId = 1, Item_damagesId =2, damages_reportId = 2, fixed_report = "Tightened loose hinge", item_status = "Operational", Item_date = "2025-01-15" },
            new damages_report { ClassesId = 2, Item_damagesId = 3, damages_reportId = 3, fixed_report = "Cleaned liquid residue", item_status = "Monitoring", Item_date = "2025-02-01" },
            new damages_report {  ClassesId = 2, Item_damagesId = 4, damages_reportId = 4, fixed_report = "Replaced missing keycaps", item_status = "Fixed", Item_date = "2025-02-12" },
            new damages_report { ClassesId = 3, Item_damagesId = 5, damages_reportId = 5, fixed_report = "Patched casing crack", item_status = "Operational", Item_date = "2025-02-20" },
            new damages_report { ClassesId = 3, Item_damagesId = 6, damages_reportId = 6, fixed_report = "Re-soldered power jack", item_status = "Fixed", Item_date = "2025-03-03" },
            new damages_report { ClassesId = 4, Item_damagesId = 7, damages_reportId = 7, fixed_report = "Replaced noisy fan", item_status = "Fixed", Item_date = "2025-03-10" },
            new damages_report { ClassesId = 4, Item_damagesId = 8, damages_reportId = 8, fixed_report = "Updated firmware", item_status = "Operational", Item_date = "2025-03-18" },
            new damages_report { ClassesId = 5, Item_damagesId = 9, damages_reportId = 9, fixed_report = "Replaced battery", item_status = "Fixed", Item_date = "2025-04-02" },
            new damages_report { ClassesId = 5, Item_damagesId = 10, damages_reportId = 10, fixed_report = "Repaired charging cable", item_status = "Operational", Item_date = "2025-04-15" },
            new damages_report { ClassesId = 6, Item_damagesId = 11, damages_reportId = 11, fixed_report = "Realigned camera module", item_status = "Fixed", Item_date = "2025-04-22" },
            new damages_report { ClassesId = 6, Item_damagesId = 12, damages_reportId = 12, fixed_report = "Replaced broken port cover", item_status = "Operational", Item_date = "2025-05-01" },
            new damages_report { ClassesId = 7, Item_damagesId = 13, damages_reportId = 13, fixed_report = "Reapplied thermal paste", item_status = "Fixed", Item_date = "2025-05-09" },
            new damages_report { ClassesId = 7, Item_damagesId = 14, damages_reportId = 14, fixed_report = "Secured loose wiring", item_status = "Operational", Item_date = "2025-05-20" },
            new damages_report { ClassesId = 8, Item_damagesId = 15, damages_reportId = 15, fixed_report = "Replaced damaged cable", item_status = "Fixed", Item_date = "2025-06-01" },
            new damages_report { ClassesId = 8, Item_damagesId = 16, damages_reportId = 16, fixed_report = "Lubricated track mechanism", item_status = "Operational", Item_date = "2025-06-12" },
            new damages_report { ClassesId = 9, Item_damagesId = 17, damages_reportId = 17, fixed_report = "Replaced fuse", item_status = "Fixed", Item_date = "0:2025-06-20" },
            new damages_report { ClassesId = 9, Item_damagesId = 18, damages_reportId = 18, fixed_report = "Reseated RAM", item_status = "Operational", Item_date = "2025-07-05" },
            new damages_report { ClassesId = 10, Item_damagesId = 19, damages_reportId = 19, fixed_report = "Replaced HDMI port", item_status = "Fixed", Item_date = "2025-07-18" },
            new damages_report { ClassesId = 10, Item_damagesId = 20, damages_reportId = 20, fixed_report = "Adjusted alignment", item_status = "Operational", Item_date = "2025-07-28" }
        };
            foreach (damages_report d in damages_report)
            {
                context.damages_report.Add(d);
            }
            context.SaveChanges();



        }
    }
}

//new Item_damages { ItemsId = 1, Item_damagesId = 1, damage_type = "Cracked Screen", severity = "High", date = 20250110 },
//new Item_damages { ItemsId = 2, Item_damagesId = 2, damage_type = "Loose Hinge", severity = "Medium", date = 20250115 },
//new Item_damages { ItemsId = 3, Item_damagesId = 3, damage_type = "Liquid Damage", severity = "High", date = 20250120 },
//new Item_damages { ItemsId = 4, Item_damagesId = 4, damage_type = "Missing Keycaps", severity = "Low", date = 20250125 },
//new Item_damages { ItemsId = 5, Item_damagesId = 5, damage_type = "Casing Crack", severity = "Medium", date = 20250201 },
//new Item_damages { ItemsId = 6, Item_damagesId = 6, damage_type = "Power Jack Issue", severity = "High", date = 20250205 },
//new Item_damages { ItemsId = 7, Item_damagesId = 7, damage_type = "Noisy Fan", severity = "Medium", date = 20250210 },
//new Item_damages { ItemsId = 8, Item_damagesId = 8, damage_type = "Firmware Corruption", severity = "Medium", date = 20250215 },
//new Item_damages { ItemsId = 9, Item_damagesId = 9, damage_type = "Battery Failure", severity = "High", date = 20250220 },
//new Item_damages { ItemsId = 10, Item_damagesId = 10, damage_type = "Charging Cable Issue", severity = "Medium", date = 20250225 },
//new Item_damages { ItemsId = 11, Item_damagesId = 11, damage_type = "Camera Misalignment", severity = "Medium", date = 20250301 },
//new Item_damages { ItemsId = 12, Item_damagesId = 12, damage_type = "Broken Port Cover", severity = "Low", date = 20250305 },
//new Item_damages { ItemsId = 13, Item_damagesId = 13, damage_type = "Overheating", severity = "High", date = 20250310 },
//new Item_damages { ItemsId = 14, Item_damagesId = 14, damage_type = "Loose Wiring", severity = "Medium", date = 20250315 },
//new Item_damages { ItemsId = 15, Item_damagesId = 15, damage_type = "Damaged Cable", severity = "High", date = 20250320 },
//new Item_damages { ItemsId = 16, Item_damagesId = 16, damage_type = "Track Mechanism Lubrication", severity = "Low", date = 20250325 },
//new Item_damages { ItemsId = 17, Item_damagesId = 17, damage_type = "Fuse Replacement", severity = "Medium", date = 20250401 },
//new Item_damages { ItemsId = 18, Item_damagesId = 18, damage_type = "RAM Reseat", severity = "Medium", date = 20250405 },
//new Item_damages { ItemsId = 19, Item_damagesId = 19, damage_type = "HDMI Port Replacement", severity = "High", date = 20250410 },
//new Item_damages { ItemsId = 20, Item_damagesId = 20, damage_type = "Alignment Check", severity = "Low", date = 20250415 },