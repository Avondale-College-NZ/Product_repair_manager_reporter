using Product_repair_manager.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_repair_manager.Models
{
    public class damages_report
    {


        
        public int damages_reportId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser appuser { get; set; }
        public int ClassesId { get; set; }
        public int Item_damagesId { get; set; }

        
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string fixed_report { get; set; }
       
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string item_status { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string Item_date { get; set; }
        public Classes classes { get; set; }
        public Item_damages item_damages { get; set; }

    }

    
}
//[StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
//[MaxLength(100), MinLength(1)]

//[DataType(DataType.Text)]
//[StringLength(1, ErrorMessage = "try again")]
//[Display(Name = "enter a report")]

//public int damages_reportId { get; set; }
//public int UserId { get; set; }
//public int ClassesId { get; set; }
//public string fixed_report { get; set; }
//public string item_status { get; set; }
//public DateOnly Item_date { get; set; }
//public int Item_damagesId { get; set; }
