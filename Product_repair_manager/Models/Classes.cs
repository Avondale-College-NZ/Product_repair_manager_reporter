using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Product_repair_manager.Models
{
    public class Classes
    {


        [ScaffoldColumn(false)]
        public int ClassesId { get; set; }


        [Display(Name = "enter school area")]
        [StringLength(1, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(1), MinLength(1)]
        public string blocks { get; set; }

        [Display(Name = "enter classroom number")]
        [DataType(DataType.Text)]
        [Range(1, 52, ErrorMessage = "Please enter a valid classroom number")]
        public int classroom { get; set; }
    }



}

//[DataType(DataType.Text)]
//[StringLength(1, ErrorMessage = "try again")]
//[Display(Name = "enter school area")]

//public int ClassesId { get; set; }
//public string block { get; set; }
//public int classroom { get; set; }