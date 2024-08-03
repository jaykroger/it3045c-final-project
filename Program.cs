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
builder.Services.AddDbContext<CourseEnrollmentsContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("CourseEnrollmentsContext")));

builder.Services.AddDbContext<FavoriteTVShowsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FavoriteTVShowsContext")));


builder.Services.AddDbContext<TeamMembersContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TeamMembersContext")));

builder.Services.AddScoped<CourseEnrollmentsContextDAO>();
builder.Services.AddScoped<FavoriteTVShowsContextDAO>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerDocument();



builder.Services.AddScoped<ITeamMembersContextDAO, TeamMembersContextDAO>();


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
