namespace CargoProject.API.DTO
{
	public class ProductDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public double StockQuantity { get; set; }
		public ICollection<CategoryDto> Categories { get; set; }
	}

	public class CategoryDto
	{
		public string Name { get; set; }
	}
}
