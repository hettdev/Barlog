using SQLite;

namespace Barlog.Models
{
    public class OrderItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public OrderType Type { get; set; }
        public float Price { get; set; }
        public uint Amount { get; set; }
    }
}
