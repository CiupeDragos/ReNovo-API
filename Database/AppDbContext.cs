using Microsoft.EntityFrameworkCore;
using ReNovo_API.Models.Entities;

namespace ReNovo_API.Database;

public class AppDbContext: DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<User> Users { get; set; }
}
