namespace IOMS.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactInfo { get; set; } = string.Empty;
        public int DeliveryTimeInDays { get; set; }
        public double ReliabilityScore { get; set; }

  
        public ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
