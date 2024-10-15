
namespace CargoProject.API.DTO
{
	public class AddProductDto
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Price { get; set; }
		public string StockQuantity { get; set; }
		//public ICollection<Category>? Categories { get; set; }
	}
}
