namespace ReNovo_API.Repositories.Interfaces;

public interface IUnitOfWork
{
	public IRepository<T> Repository<T>() where T : class;

	public Task Complete();
}
