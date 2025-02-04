using ReNovo_API.Database;
using ReNovo_API.Repositories.Interfaces;

namespace ReNovo_API.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		private Dictionary<Type, object> _repositories = new();
		private readonly AppDbContext _context;

		public UnitOfWork(AppDbContext context)
		{
			_context = context;
		}

		public IRepository<T> Repository<T>() where T : class
		{
			if (_repositories.ContainsKey(typeof(T)))
			{
				return _repositories[typeof(T)] as IRepository<T>;
			}

			var newRepository = new Repository<T>(_context);
			_repositories.Add(typeof(T), newRepository);

			return newRepository;
		}

		public Task Complete()
		{
			return _context.SaveChangesAsync();
		}
	}
}
