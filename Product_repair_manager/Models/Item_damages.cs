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
}
