using BooksList.Infra;
using Microsoft.EntityFrameworkCore;

namespace BooksList.Api;

using Extensions;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        var connectionString = Configuration.GetConnectionString("ConnectionStrings:Default");
        
        services.AddDbContext<BooksListDbContext>(options =>
            options.UseNpgsql(connectionString));
        services.AddDependencyInjection();
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}