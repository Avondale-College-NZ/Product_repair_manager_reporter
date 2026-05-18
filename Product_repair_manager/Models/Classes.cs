using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Product_repair_manager.Models
{
    public class Classes
    {
        //public int ClassesId { get; set; }
        //public string block { get; set; }
        //public int classroom { get; set; }

        [ScaffoldColumn(false)]
        
        //[DataType(DataType.Text)]
        //[StringLength(1, ErrorMessage = "try again")]
        //[Display(Name = "enter school area")]
        public int ClassesId { get; set; }



        [StringLength(1, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(1), MinLength(1)]
        public string block { get; set; }

        
        //[DataType(DataType.)]
        //[StringLength(1, ErrorMessage = "no know number exist try again")]
        public int classroom { get; set; }
    }



}
