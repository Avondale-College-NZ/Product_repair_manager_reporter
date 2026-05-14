using System.ComponentModel.DataAnnotations;

namespace Product_repair_manager.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string Catagory_Name { get; set; }
    }

    public class catagory
    {
        [ScaffoldColumn(false)]
        Catagory CatagoryId { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1, ErrorMessage = "try again")]
        [Display(Name = "enter a Catagory")]


        public string Catagory_Name { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

    }
}
