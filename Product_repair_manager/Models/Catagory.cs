using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_repair_manager.Models
{
    public class Catagory
    {
        public int CatagoryId { get; set; }

        //[DataType(DataType.Text)]
        //[StringLength(1, ErrorMessage = "try again")]
        //[Display(Name = "enter a Catagory")]


        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string Catagory_Name { get; set; }

        [NotMapped]
        public ICollection<Items> Items { get; set; }
    }
}
