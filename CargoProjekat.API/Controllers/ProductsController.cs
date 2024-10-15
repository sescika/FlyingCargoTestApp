using CargoProject.API.DTO;
using CargoProject.API.Interfaces;
using CargoProject.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoProject.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public ProductsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		[HttpGet]
		public IActionResult Get([FromQuery] SearchProductDto search)
		{
			return Ok(_unitOfWork.Products.GetAll(search));
		}


		[HttpPost]
		public IActionResult Add([FromBody] AddProductDto dto)
		{
			try
			{
				_unitOfWork.Products.AddProduct(dto);
				return StatusCode(201);
			}
			catch (ValidationException ex)
			{
				return UnprocessableEntity(ex.Errors);
			}
			catch (Exception e)
			{
				return StatusCode(500);
			}
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			try
			{
				_unitOfWork.Products.DeleteProduct(id);
				return NoContent();
			}
			catch (Exception e)
			{
				return StatusCode(500);
			}
		}
		[HttpPut("{id}")]
		public IActionResult Update([FromBody] UpdateProductDto dto, int id)
		{
			try
			{
				_unitOfWork.Products.UpdateProduct(dto, id);
				return StatusCode(201);
			}
			catch (ValidationException ex)
			{
				return UnprocessableEntity(ex.Errors);
			}
			catch (Exception e)
			{
				return StatusCode(500);
			}
		}
	}
}
