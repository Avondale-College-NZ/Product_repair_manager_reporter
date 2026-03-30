using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Models;

    public class Product_repair_managerContext : DbContext
    {
        public Product_repair_managerContext (DbContextOptions<Product_repair_managerContext> options)
            : base(options)
        {
        }

        public DbSet<Product_repair_manager.Models.User> User { get; set; } = default!;

public DbSet<Product_repair_manager.Models.Staff> Staff { get; set; } = default!;

public DbSet<Product_repair_manager.Models.Items> Items { get; set; } = default!;

public DbSet<Product_repair_manager.Models.Catagory> Catagory { get; set; } = default!;

public DbSet<Product_repair_manager.Models.Classes> Classes { get; set; } = default!;

public DbSet<Product_repair_manager.Models.Item_damages> Item_damages { get; set; } = default!;

public DbSet<Product_repair_manager.Models.damages_report> damages_report { get; set; } = default!;
    }
