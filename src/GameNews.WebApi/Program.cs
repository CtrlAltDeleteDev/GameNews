using GameNews.ApplicationCore;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Repositories;
using GameNews.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var ConnectionString = builder.Configuration["DBConnectionString"];
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(ConnectionString , b => b.MigrationsAssembly("GameNews.Infrastructure")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mediatr
builder.Services.AddGameNewsApplication();

//Dependency injection
builder.Services.AddScoped<IBlogRepository,BlogRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//dotnet ef migrations add <MigrationName> --startup-project <ProjectWithDesignPackage> --project <InfrastructureProject>