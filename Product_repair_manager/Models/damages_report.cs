using System.ComponentModel.DataAnnotations;

namespace Product_repair_manager.Models
{
    public class damages_report
    {
        public int damages_reportId { get; set; }
        public int UserId { get; set; }
        public int ClassesId { get; set; }
        public string fixed_report { get; set; }
        public string item_status { get; set; }
        public DateOnly Item_date { get; set; }
        public int Item_damagesId { get; set; }

    }

    public class reports
    {
        [ScaffoldColumn(false)]
        reports damages_reportId { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1, ErrorMessage = "try again")]
        [Display(Name = "enter a report")]


        public string fixed_report { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

        public string item_status { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]

        public string Item_date { get; set; }
        [DataType(DataType.DateTime)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
    }
}
