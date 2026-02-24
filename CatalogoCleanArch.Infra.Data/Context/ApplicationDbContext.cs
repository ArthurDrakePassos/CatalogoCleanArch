using CatalogoCleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogoCleanArch.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Responsável por aplicar as configurações das entidades que estão nos arquivos da pasta EntitiesConfiguration, pois herdam da interface IEntityTypeConfiguration<T>.
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
