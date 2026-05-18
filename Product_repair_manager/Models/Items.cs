using System.ComponentModel.DataAnnotations;

namespace Product_repair_manager.Models
{
    public class Items
    {
        //public int ItemsId {  get; set; }
        //public string items_Name { get; set; }
        //public int CatagoryId { get; set; }

        [ScaffoldColumn(false)]

        //[DataType(DataType.Custom)]
        //[StringLength(1, ErrorMessage = "try again")]
        //[Display(Name = "enter a report")]
        public int CatagoryId { get; set; }

        //[DataType(DataType.Custom)]
        //[StringLength(1, ErrorMessage = "try again")]
        //[Display(Name = "enter a report")]
        public int ItemsId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string items_Name { get; set; }
    }
}
