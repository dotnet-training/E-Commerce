﻿namespace ECommerce
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameSecondLanguage { get; set; }
        public string Description { get; set; }
        public string DescriptionSecondLanguage { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}