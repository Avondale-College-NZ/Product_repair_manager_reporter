namespace Product_repair_manager.Models
{
    public class Item_damages
    {
        public int Item_damagesId { get; set; }
        public int ItemId { get; set; }
        public string damage_report { get; set; }
        public DateOnly Item_date { get; set; }
    }
}
