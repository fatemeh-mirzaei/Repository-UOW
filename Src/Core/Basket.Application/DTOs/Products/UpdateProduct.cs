﻿namespace Basket.Application.DTOs.Products
{
    public class UpdateProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

    }
}
