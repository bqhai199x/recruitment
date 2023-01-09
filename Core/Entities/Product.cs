namespace Recruitment.Core.Entities
{
    public class Product
    {
        public int Id { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Quantity { get; set; } = 0;

        public int CategoryId { get; set; } = 0;

        public Category Category { get; set; } = new();
    }
}
