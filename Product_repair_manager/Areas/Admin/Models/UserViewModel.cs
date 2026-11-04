using Microsoft.AspNetCore.Identity;
using Product_repair_manager.Data;

namespace Product_repair_manager.Areas.Admin.Models
{
    public class UserViewModel
    {
        // this simply holds the list of users and roles to be displayed in the view as well as new user.
        public IEnumerable<ApplicationUser> Users { get; set; } = null!;
        public IEnumerable<IdentityRole> Roles { get; set; } = null!;
    }
}
