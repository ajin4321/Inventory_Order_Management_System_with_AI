namespace IOMS.Models
{
    public class StockTransaction
    {
        public int StockTransactionId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string Type { get; set; } = "In"; // In / Out
        public int Quantity { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;

    }
}
