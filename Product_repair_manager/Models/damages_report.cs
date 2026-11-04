using Product_repair_manager.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_repair_manager.Models
{
    public class damages_report
    {

        //primgary key for the damages_report table that can connect to classes table, item_damages table and application user table
        [Key]
        public int damages_reportId { get; set; }
        // the tables connects both damages_report and classes table, item_damages table and application user table togther so that we can have a one to many relationship between them
        [ForeignKey("Id")]
        public string Id { get; set; }
   
        [ForeignKey("ClassesId")]
        public int ClassesId { get; set; }
     
        [ForeignKey("Item_damagesId")]
        public int Item_damagesId { get; set; }

        // this is for the report that the person reports if the item is fixed or not
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string fixed_report { get; set; }

        // this is for the status of the item that is damaged
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "no such as the you wrote dosent exist please try again")]
        [MaxLength(100), MinLength(1)]
        public string item_status { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string Item_date { get; set; }

        //this damages report table connects to the application user table, classes table and item_damages table so that we can have a one to many relationship between them
        public ApplicationUser? appuser { get; set; }

        public Classes? classes { get; set; }

        public Item_damages? item_damages { get; set; }

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
