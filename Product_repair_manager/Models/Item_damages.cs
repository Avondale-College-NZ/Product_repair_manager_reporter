using System.ComponentModel.DataAnnotations;

namespace Product_repair_manager.Models
{
    public class Item_damages
    {
        public int Item_damagesId { get; set; }
        public int ItemsId { get; set; }
        public string damage_type { get; set; }
        public string severity{ get; set; }
        public DateOnly date { get; set; }
    }

    public class damages
    {
        [ScaffoldColumn(false)]
        damages Item_damagesId { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1, ErrorMessage = "try again")]
        [Display(Name = "enter a report")]


        public string damage_type { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

        public string severity { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

        public string date { get; set; }
        [DataType(DataType.DateTime)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
    }
}
