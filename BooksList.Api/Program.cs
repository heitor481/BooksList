using BooksList.Api;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseStartup<Startup>();
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
var app = builder.Build();
startup.Configure(app, builder.Environment);