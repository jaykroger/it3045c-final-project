using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using IT3045C_Final_Project.Data;
using IT3045C_Final_Project.Interfaces;
using IT3045C_Final_Project.Controllers;


var builder = WebApplication.CreateBuilder(args);

// API Controllers
builder.Services.AddControllers();


//Database contexts and connection string
builder.Services.AddDbContext<TeamMembersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TeamMembersContext")));

builder.Services.AddDbContext<FavoriteFoodsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FavoriteFoodsContext")));

builder.Services.AddDbContext<CoursesContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("CoursesContext")));

builder.Services.AddDbContext<TVShowsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TVShowsContext")));

// Data Access Objects
builder.Services.AddScoped<TeamMembersContextDAO>();
builder.Services.AddScoped<FoodsContextDAO>();
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
