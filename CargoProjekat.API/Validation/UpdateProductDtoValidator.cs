using CargoProject.API.DTO;
using FluentValidation;

namespace CargoProject.API.Validation
{
	public class UpdateProductDtoValidator : AbstractValidator<UpdateProductDto>
	{
		public UpdateProductDtoValidator() 
		{ 
			ClassLevelCascadeMode = CascadeMode.Stop;

			RuleFor(x => x.Name).NotEmpty().WithMessage("Name can't be empty.").MinimumLength(2).WithMessage("Product name must be at lest 2 characters.");
			RuleFor(x => x.Price).NotEmpty().WithMessage("Price can't be empty.").GreaterThan(0).WithMessage("Price can't be 0.");
			RuleFor(x => x.StockQuantity).NotEmpty().WithMessage("StockQuantity can't be empty.").GreaterThan(0).WithMessage("StockQuantity can't be 0.");
			RuleFor(x => x.Description).NotEmpty().WithMessage("Description can't be empty.");
		}
	}
}
