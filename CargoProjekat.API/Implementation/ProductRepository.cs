using CargoProject.API.DTO;
using CargoProject.API.Interfaces;
using CargoProject.API.Validation;
using CargoProject.Data.Data;
using CargoProject.Data.Entities;
using FluentValidation;

namespace CargoProject.API.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly BazaCargoTestContext _ctx;
		private readonly AddProductDtoValidator _validatorAdd;
		private readonly UpdateProductDtoValidator _validatorUpdate;
		public ProductRepository(BazaCargoTestContext ctx)
		{
			_ctx = ctx;
		}
		public ProductRepository(BazaCargoTestContext ctx, AddProductDtoValidator validatorAdd, UpdateProductDtoValidator validatorUpdate)
		{
			_validatorAdd = validatorAdd;
			_ctx = ctx;
			_validatorUpdate = validatorUpdate;
		}
		public void AddProduct(AddProductDto product)
		{

			//_validatorAdd.ValidateAndThrow(p);
			Product productToAdd = new Product
			{
				ProductName = product.Name,
				Description = product.Description,
				Price = product.Price,
				StockQuantity = product.StockQuantity
			};
			_ctx.Add(productToAdd);
			_ctx.SaveChanges();
		}

		public void DeleteProduct(int productId)
		{
			var product  = _ctx.Products.FirstOrDefault(p => p.ProductId == productId);
			if (product == null)
			{
				throw new Exception("Product doesn't exist.");
			}

			_ctx.Products.Remove(product);
			_ctx.SaveChanges();
		}

		public List<ProductDto> GetAll(SearchProductDto? dto)
		{
			var query = _ctx.Products.AsQueryable();

			if (dto.Id.HasValue)
			{
				query = query.Where(x => x.ProductId == dto.Id);
			}

			if (!string.IsNullOrEmpty(dto.Name))
			{
				query = query.Where(x => x.ProductName.ToLower().Contains(dto.Name.ToLower()));
			}

			if (!string.IsNullOrEmpty(dto.Description))
			{
				query = query.Where(x => x.Description.ToLower().Contains(dto.Description.ToLower()));
			}

			if (dto.PriceGreaterThan.HasValue)
			{
				query = query.Where(x => x.Price >= dto.PriceGreaterThan);
			}

			if (dto.PriceLesserThan.HasValue)
			{
				query = query.Where(x => x.Price <= dto.PriceGreaterThan);
			}

			if (dto.CreatedDate.HasValue)
			{
				query = query.Where(x => x.CreatedAt >= dto.CreatedDate);
			}

			if(dto.StockQuantity.HasValue)
			{
				query = query.Where(x => x.StockQuantity >= dto.StockQuantity);
			}
			return query.Select(x => new ProductDto
			{
				Id = x.ProductId,
				Name = x.ProductName,
				Description = x.Description,
				Categories = (ICollection<CategoryDto>)x.ProductCategories.Select(y => new CategoryDto
				{
					Name = y.Category.CategoryName
				}),
				Price = x.Price,
				StockQuantity = x.StockQuantity,

			}).ToList();
		}
		public void UpdateProduct(UpdateProductDto product, int id)
		{
			//_validatorUpdate.ValidateAndThrow(product);
			var p = _ctx.Products.FirstOrDefault(x => x.ProductId == id);

			if(p == null)
			{
				throw new Exception("Product doesn't exist.");
			} 

			p.ProductName = !string.IsNullOrEmpty(product.Name) ? product.Name : p.ProductName;
			p.Price = product.Price.HasValue ? (decimal)product.Price : p.Price;
			p.Description = !string.IsNullOrEmpty(product.Description) ? product.Description : p.Description;
			p.StockQuantity = product.Price.HasValue ? (double)product.StockQuantity : p.StockQuantity;
			
			_ctx.SaveChanges();
		}
	}
}
