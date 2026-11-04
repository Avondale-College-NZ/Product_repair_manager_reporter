using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_repair_manager.Models
{
    public class Items
    {
        // this is the primary key for the items table that can connect to item_damages table
        [Key]
        public int ItemsId { get; set; }

        //this connects both items and catagory togther so that we can have a one to many relationship between them
        [ForeignKey("CatagoryId")]
        public int CatagoryId { get; set; }

        //name of items
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string items_Name { get; set; }

        // this connects both items and catagory togther so that we can have a one to many relationship between them
        public Catagory? Catagory { get; set; }

       
        public ICollection<Item_damages>? Item_damages { get; set; }

    }
}