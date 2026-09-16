using Microsoft.AspNetCore.Identity;
using Product_repair_manager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Product_repair_manager.Data; 
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required, Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required, Display(Name = "Last Name")]
    public string LastName { get; set; }

    public ICollection<damages_report> damages_reports { get; set; }

    [NotMapped]
    public IList<string> rolesnames { get; set; }= null;
}
