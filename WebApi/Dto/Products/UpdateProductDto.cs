﻿using System.Text.Json.Serialization;

namespace WebApi.Dto.Products
{
    public class UpdateProductDto
    {
        [JsonIgnore]

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
