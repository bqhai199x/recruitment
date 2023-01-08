namespace Recruitment.Core.Entities
{
    public class Order
    {
        public int Id { get; set; } = 0;

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int CustomerId { get; set; } = 0;

        public int Amount { get; set; } = 0;

        public int ProductId { get; set; } = 0;

        public Product Product { get; set; } = new();

        public Customer Customer { get; set; } = new();
    }
}
