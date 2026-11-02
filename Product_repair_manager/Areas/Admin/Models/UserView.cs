using Microsoft.AspNetCore.Identity;
using Product_repair_manager.Data;

namespace Product_repair_manager.Areas.Admin.Models
{
    public class UserView
    {
        public IEnumerable<ApplicationUser> Users { get; set; } = null!;
        public IEnumerable<IdentityRole> Roles { get; set; } = null!;

    }
}
