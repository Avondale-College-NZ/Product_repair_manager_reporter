using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_repair_manager.Models
{
    public class Catagory
    {
        // this is the primary key for the catagory table that can connect to items table
        [Key]
        public int CatagoryId { get; set; }

        [Required, DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string Catagory_Name { get; set; }

        // this connects both items and catagory togther so that we can have a one to many relationship between them
        public ICollection<Items>? Items { get; set; }
    }
}