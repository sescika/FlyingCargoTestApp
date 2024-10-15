using CargoProject.API.DTO;
using CargoProject.Data.Entities;

namespace CargoProject.API.Interfaces
{
	public interface IProductRepository
	{
		List<ProductDto> GetAll(SearchProductDto? dto);
		void AddProduct(AddProductDto product);
		void UpdateProduct(UpdateProductDto product, int id);
		void DeleteProduct(int id);
	}
}
