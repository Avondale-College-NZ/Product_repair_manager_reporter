using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Product_repair_manager.Models
{
    public class Item_damages
    {
        [Key]
        public int Item_damagesId { get; set; }
        [ForeignKey("ItemsId")]
        public int ItemsId { get; set; }
     

        [Required, DataType(DataType.Text)] 
        [StringLength(30, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(30), MinLength(1)]
        public string severity { get; set; }

        [Required, DataType(DataType.Text)] 
        [StringLength(30, ErrorMessage = "no such as the you wrote dosent exist please try agains")]
        [MaxLength(30), MinLength(1)]
        public string damage_type { get; set; }


        [ DataType(DataType.DateTime)]
        public DateTime date { get; set; }

   
        public Items Items { get; set; }

        
        public ICollection<damages_report> damages_reports { get; set; }

    }

}
//[StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
//[MaxLength(100), MinLength(1)]

//[DataType(DataType.Text)]
//[StringLength(1, ErrorMessage = "try again")]
//[Display(Name = "enter a report")]

//public int Item_damagesId { get; set; }
//public int ItemsId { get; set; }
//public string damage_type { get; set; }
//public string severity{ get; set; }
//public DateOnly date { get; set; }