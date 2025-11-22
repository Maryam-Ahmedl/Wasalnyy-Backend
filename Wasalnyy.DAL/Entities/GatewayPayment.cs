namespace Wasalnyy.DAL.Entities
{
    public class GatewayPayment
    {
        public Guid Id { get; set; }
        public string RiderId { get; set; }
        public Rider Rider { get; set; }
        public string TransactionId { get; set; }
        public PaymentStatus Status { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }

    public enum PaymentStatus
    {
        Pass = 0,
        Fail = 1
    }
}