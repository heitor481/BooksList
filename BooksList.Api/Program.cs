using BooksList.Api.Extensions;
using BooksList.Infra;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("ConnectionStrings:Default");
        
builder.Services.AddDbContext<BooksListDbContext>(options =>
    options.UseNpgsql("Server=127.0.0.1;Port=5453;Database=bookslist;User Id=postgres;Password=Jotaro@1234"));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}

builder.Services.AddDependencyInjection();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors();
app.Run();