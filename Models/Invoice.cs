namespace IOMS.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime DateIssued { get; set; } = DateTime.UtcNow;
        public string PaymentStatus { get; set; } = "Unpaid";

        // Relationship
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

    }
}
