using CatalogoCleanArch.Domain.Interfaces;
using CatalogoCleanArch.Infra.Data.Context;
using CatalogoCleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CatalogoCleanArch.Application.Mappings;
using CatalogoCleanArch.Application.Interfaces;
using CatalogoCleanArch.Application.Services;

namespace CatalogoCleanArch.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>( options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(cfg => cfg.AddProfile<DomainToDTOMappingProfile>());
            services.AddAutoMapper(cfg => cfg.AddProfile<DTOToCommandMappingProfile>());

            var myhandlers = AppDomain.CurrentDomain.Load("CatalogoCleanArch.Application");
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(myhandlers));

            return services;
        }
    }
}
