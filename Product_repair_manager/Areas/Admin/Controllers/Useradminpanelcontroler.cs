using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Product_repair_manager.Areas.Admin.Models;
using Product_repair_manager.Data;

namespace Product_repair_manager.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Useradminpanelcontroler : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        public Useradminpanelcontroler(UserManager<ApplicationUser> userPanel, RoleManager<IdentityRole> rolePanel)
        {
            userManager = userPanel;
            roleManager = rolePanel;
        }

        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            foreach (ApplicationUser user in userManager.Users)
            {
                user.rolesnames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }

            UserView model = new UserView
            {
                Users = users,
                Roles = roleManager.Roles
            };

            return View(model);
        }
    }
}
