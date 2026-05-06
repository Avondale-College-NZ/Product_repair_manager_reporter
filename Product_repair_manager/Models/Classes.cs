using System.ComponentModel.DataAnnotations;

namespace Product_repair_manager.Models
{
    public class Classes
    {
        public int ClassesId { get; set; }
        public string block { get; set; }
        public int classroom { get; set; }
    }
    public class room
    {
        [ScaffoldColumn(false)]
        block { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "unkown class block please enter the correct one"), MaxLength(1)]
    }

}
