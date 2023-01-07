namespace Recruitment.Core.Entities
{
    public class Order
    {
        public int Id { get; set; } = 0;

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public List<OrderDetail> OrderDetailList { get; set; } = new();

        public Customer Customer { get; set; } = new();
    }
}
