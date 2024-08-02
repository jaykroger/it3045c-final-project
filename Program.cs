using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Interfaces;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// API Controllers
builder.Services.AddControllers();

// Database Contexts
builder.Services.AddDbContext<CoursesContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("CoursesContext")));

builder.Services.AddDbContext<TVShowsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TVShowsContext")));

builder.Services.AddScoped<CoursesContextDAO>();
builder.Services.AddScoped<TVShowsContextDAO>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument();


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
