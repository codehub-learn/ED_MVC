﻿namespace ED_MVC.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageLoc { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
