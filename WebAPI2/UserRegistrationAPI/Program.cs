using BusinessLayer.Service;
using RepositoryLayer.Service;
using NLog;
using NLog.Web;
using BusinessLayer.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// isse manually object create krne ki zaroorat nhi pdhti 
//iska use dependency injection k liye hote h 
builder.Services.AddScoped<UserRegistrationBL>();
builder.Services.AddScoped<UserRegistrationRL>();
builder.Host.UseNLog();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
