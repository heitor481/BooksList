using BooksList.Infra;
using BooksList.Infra.Repositories;
using BooksList.Infra.Repositories.Contracts;

namespace BooksList.Api.Extensions;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<BooksListDbContext>();
        services.AddScoped<IBooksRepository, BooksRepository>();
        return services;
    }
}