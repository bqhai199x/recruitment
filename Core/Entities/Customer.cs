﻿namespace Recruitment.Core.Entities
{
    public class Customer
    {
        public int Id { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public List<Order> OrderList { get; set; } = new();
    }
}
