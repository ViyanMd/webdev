using Microsoft.EntityFrameworkCore;
using webdev.Data;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllersWithViews();

string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connection));

var app = builder.Build();

app.MapControllers();

app.Run();