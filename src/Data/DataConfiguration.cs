using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Template.Application.Interfaces;
using Template.Data.Repositories;

namespace Template.Data
{
    public static class DataConfiguration
    {
        public static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IBookRepository, BookRepository>();

            return services;
        }
    }
}
