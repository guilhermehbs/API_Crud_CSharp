using Microsoft.EntityFrameworkCore;

namespace api_crud.Models
{
	public class CrudContext : DbContext
	{
		public DbSet<Usuario> Usuario { get; set; } = null!;

		public CrudContext(DbContextOptions<CrudContext> options) : base(options) { }
	}
}
