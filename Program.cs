using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();

//Datbase contents and connection string
builder.Services.AddDbContext<FavoriteFoodsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FavoriteFoodsContext")));


builder.Services.AddScoped<FoodsContextDAO>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument();

builder.Services.AddScoped<FoodsContextDAO>();
builder.Services.AddScoped<FavoriteFoods>();




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
