namespace Recruitment.Core.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; } = 0;

        public Product Product { get; set; } = new();

        public int Amount { get; set; } = 0;

        public Order Order { get; set; } = new();
    }
}
