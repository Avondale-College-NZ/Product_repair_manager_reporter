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
}
