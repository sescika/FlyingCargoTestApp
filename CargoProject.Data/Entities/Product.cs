using System;
using System.Collections.Generic;

namespace CargoProject.Data.Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public string Description { get; set; } = null!;

    public double StockQuantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}
