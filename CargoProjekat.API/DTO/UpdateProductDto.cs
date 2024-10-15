﻿using CargoProject.Data.Entities;

namespace CargoProject.API.DTO
{
	public class UpdateProductDto
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal? Price { get; set; }
		public double? StockQuantity { get; set; }
		//public ICollection<Category>? Categories { get; set; }
	}
}
