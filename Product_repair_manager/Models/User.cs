using System.ComponentModel.DataAnnotations;

namespace Product_repair_manager.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string role { get; set; }

    }

    public class person
    {
        [ScaffoldColumn(false)]
        User UserId { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1, ErrorMessage = "try again")]
        [Display(Name = "enter a report")]


        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

        public string LastName { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

        public string Email { get; set; }
        [DataType(DataType.DateTime)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

        public string role { get; set; }
        [DataType(DataType.DateTime)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
    }
}
