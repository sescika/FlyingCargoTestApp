using CargoProject.API.Interfaces;
using CargoProject.API.Repositories;
using CargoProject.Data.Data;
using System;

namespace CargoProject.API.Implementation
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly BazaCargoTestContext _context;
		public IProductRepository Products { get; private set; }

		public UnitOfWork(BazaCargoTestContext context)
		{
			_context = context;
			Products = new ProductRepository(_context);
		}

		public void Commit()
		{
			_context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
