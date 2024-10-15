using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTest.GUI.Models
{
	public class ProductDto
	{
		public int? Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public double StockQuantity { get; set; }
		public List<CategoryDto> Categories { get; set; }
	}

	public class CategoryDto
	{
		public string Name { get; set; }
	}
}
