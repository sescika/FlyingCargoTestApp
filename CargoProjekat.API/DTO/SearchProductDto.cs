namespace CargoProject.API.DTO
{
	public class SearchProductDto
	{
        public int? Id { get; set; }
        public string? Name { get; set; }
        public decimal? PriceGreaterThan { get; set; }
		public decimal? PriceLesserThan { get; set; }
		public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double? StockQuantity { get; set; }
    }
}
