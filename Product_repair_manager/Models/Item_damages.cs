using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Product_repair_manager.Models
{
    public class Item_damages
    {
        // this is the primary key for the item_damages table that can connect to damages_report table
        [Key]
        public int Item_damagesId { get; set; }

        //this connects both item_damages and items togther so that we can have a one to many relationship between them
        [Display(Name = "Items")]
        [ForeignKey("ItemsId")]
        public int ItemsId { get; set; }
     
        //how bad is it damage is
        [Required, DataType(DataType.Text)] 
        [StringLength(30, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(30), MinLength(1)]
        public string severity { get; set; }

        //what damageme is it
        [Required, DataType(DataType.Text)] 
        [StringLength(30, ErrorMessage = "no such as the you wrote dosent exist please try agains")]
        [MaxLength(30), MinLength(1)]
        public string damage_type { get; set; }


        [ DataType(DataType.DateTime)]
        public DateTime date { get; set; }

        // this connect items with item_damages so that we can have a one to many relationship between them
        public Items? Items { get; set; }

        // this connect item_damages with damages_report so that we can have a one to many relationship between them
        public ICollection<damages_report>? damages_reports { get; set; }

    }

}
