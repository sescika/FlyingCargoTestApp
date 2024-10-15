namespace CargoProject.API.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IProductRepository Products { get; }
		void Commit();
	}
}
