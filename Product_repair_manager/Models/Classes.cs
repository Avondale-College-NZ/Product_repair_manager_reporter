using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Product_repair_manager.Models
{
    public class Classes
    {
        public int ClassesId { get; set; }
        public string block { get; set; }
        public int classroom { get; set; }
    }

    public class Room
    {
        [ScaffoldColumn(false)]
        Classes ClassesId { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1, ErrorMessage = "try again")]


        public string block { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(1), MinLength(1)]

        public int classroom { get; set; }
        [DataType(DataType.Text)]
        [StringLength(54, ErrorMessage = "no know number exist try again")]
    }


}
