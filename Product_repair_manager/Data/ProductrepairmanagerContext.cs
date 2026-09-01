using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Product_repair_manager.Data;
using Product_repair_manager.Models;

public class ProductrepairmanagerContext : IdentityDbContext<ApplicationUser>
{
    public ProductrepairmanagerContext(DbContextOptions<ProductrepairmanagerContext> options)
        : base(options)
    {
    }

    public DbSet<Product_repair_manager.Models.Items> Items { get; set; } = default!;

    public DbSet<Product_repair_manager.Models.Catagory> Catagory { get; set; } = default!;

    public DbSet<Product_repair_manager.Models.Classes> Classes { get; set; } = default!;

    public DbSet<Product_repair_manager.Models.Item_damages> Item_damages { get; set; } = default!;

    public DbSet<Product_repair_manager.Models.damages_report> damages_report { get; set; } = default!;
}
