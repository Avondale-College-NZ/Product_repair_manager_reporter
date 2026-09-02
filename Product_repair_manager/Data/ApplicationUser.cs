using Microsoft.AspNetCore.Identity;
using Product_repair_manager.Models;
using System.ComponentModel.DataAnnotations;
namespace Product_repair_manager.Data; 
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required dis]

    public ICollection<damages_report> damages_Reports { get; set; }
}
