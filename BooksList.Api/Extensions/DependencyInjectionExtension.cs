using BooksList.Infra;

namespace BooksList.Api.Extensions;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<BooksListDbContext>();
        return services;
    }
}