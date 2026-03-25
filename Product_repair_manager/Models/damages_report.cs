namespace Product_repair_manager.Models
{
    public class damages_report
    {
        public int UserId { get; set; }
        public string fixed_report { get; set; }
        public string item_status { get; set; }
        public int ClassId { get; set; }
        public DateOnly Item_date { get; set; }
        public int item_damages_id { get; set; }

    }
}
