using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_repair_manager.Models
{
    public class Items
    {
        public int CatagoryId { get; set; }

        public int ItemsId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string items_Name { get; set; }

        [NotMapped]
        public Catagory catagory { get; set; }

        [NotMapped]
        public ICollection<Item_damages> Item_damages { get; set; }

    }
}
//public int ItemsId {  get; set; }
//public string items_Name { get; set; }
//public int CatagoryId { get; set; }



//[DataType(DataType.Custom)]
//[StringLength(1, ErrorMessage = "try again")]
//[Display(Name = "enter a report")]


//[DataType(DataType.Custom)]
//[StringLength(1, ErrorMessage = "try again")]
//[Display(Name = "enter a report")]