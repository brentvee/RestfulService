using System.Data.Entity;

namespace RestfulApi.Model
{
	public class RestfulDbContext : DbContext
	{
		public DbSet<Item> Items { get; set; }
		public DbSet<Package> Packages { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new ItemMap())
		}
	}
}
