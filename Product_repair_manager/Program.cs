using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Product_repair_manager.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ProductrepairmanagerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductrepairmanagerContext") ?? throw new InvalidOperationException("Connection string 'ProductrepairmanagerContext' not found.")));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddRoles<IdentityRole>()
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
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        DbInitializer.Initialize(context, userManager);
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

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Creates an Admin account if one doesn't exist yet, or ensures the existing account has the correct role
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

    // Admin account details
    string adminID = "00000000000";
    string adminEmail = "BDstaff@org.nz";
    string adminPassword = "BloodDonation@123";

    // Checks to see if the Admin account already exists using the adminID
    var existingUser = await userManager.FindByIdAsync(adminID);

    if (existingUser == null)
    {
        // Sets up a new admin user account with it's details
        var user = new User
        {
            Id = adminID,
            UserName = adminEmail,
            Email = adminEmail,
            EmailConfirmed = true,
            FirstName = "System",
            LastName = "Admin"
        };

        // Creates the user in the database and gives the user the "Admin" role
        var result = await userManager.CreateAsync(user, adminPassword);
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Admin");
        }
    }
    else
    {
        // If the user exists but lost the Admin role, this gives it back to them
        if (!await userManager.IsInRoleAsync(existingUser, "Admin"))
        {
            await userManager.AddToRoleAsync(existingUser, "Admin");
        }
    }
}

app.Run();


