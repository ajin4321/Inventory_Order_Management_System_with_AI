namespace IOMS.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int QuantityInStock { get; set; }
        public decimal Price { get; set; }
        public int ReorderLevel { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
