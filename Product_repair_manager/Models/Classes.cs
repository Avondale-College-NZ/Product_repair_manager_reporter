using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Product_repair_manager.Models
{
    public class Classes
    {
        //this connects classes to damages_report table so that we can have a one to many relationship between them
        [ForeignKey("damages_reportId")]
        public int damages_reportId { get; set; }
        // this is the primary key for the classes table that can connect to damages_report table
        [Key]
        public int ClassesId { get; set; }

        // this for the block where the classroom is located
        [Required, Display(Name = "enter school area")]
        [StringLength(1, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(1), MinLength(1)]
        public string blocks { get; set; }

        [Required, Display(Name = "enter classroom number")]
        [DataType(DataType.Text)]
        [Range(1, 52, ErrorMessage = "Please enter a valid classroom number")]
        public int classroom { get; set; }

        // this connects both classes and damages_report togther so that we can have a one to many relationship between them
        public ICollection<damages_report>? damages_reports { get; set; }
    }



}
