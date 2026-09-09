using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Product_repair_manager.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProductrepairmanagerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductrepairmanagerContext") ?? throw new InvalidOperationException("Connection string 'ProductrepairmanagerContext' not found.")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ProductrepairmanagerContext>();   
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ProductrepairmanagerContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}

app.MapRazorPages();

app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();


using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "User", "Staff" };
    foreach (var role in roles)
    {
        if (await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    string adminemail = "F2@F2.com";
    string adminpassword = "School123!";

    if (await userManager.FindByEmailAsync("F2@F2.com") == null)
    {
        var user = new ApplicationUser
        {
            FirstName = "F2",
            LastName = "F2",
            Email = adminemail,
            PasswordHash = adminpassword,
            EmailConfirmed = true,
        };

        await userManager.CreateAsync(user, adminpassword);

        await userManager.AddToRoleAsync(user, "F2");
    }
}
await DbInitializer.Initialize(app);

app.Run();