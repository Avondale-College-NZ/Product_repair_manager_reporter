using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Identity.Client;
using Product_repair_manager.Areas.Admin.Models;
using Product_repair_manager.Data;

namespace Product_repair_manager.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<ApplicationUser> userMngr, RoleManager<IdentityRole> roleMngr)
        {
            _userManager = userMngr;
            _roleManager = roleMngr;
        }

        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            foreach (ApplicationUser user in _userManager.Users)
            {
                user.rolesnames = await _userManager.GetRolesAsync(user);
                users.Add(user);
            }
            UserViewModel model = new UserViewModel
            {
                Users = users,
                Roles = _roleManager.Roles
            };
            return View(model);
        }

        


        [HttpPost]
        public async Task<IActionResult> AddUserToRole(string userId, string roleName)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(roleName);
            if (role != null)
            {
                TempData["message"] = $"Role '{roleName}' does not exist.";
            }
            else
            {
                ApplicationUser user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, roleName);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveUserFromRole(string userId, string roleName)
        {
            ApplicationUser user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, roleName);
            }
            return RedirectToAction("Index");
        }
    }
}