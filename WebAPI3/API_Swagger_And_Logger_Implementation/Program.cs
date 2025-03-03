using BusinessLayer;
using BusinessLayer.Service;
using RepositoryLayer;
using RepositoryLayer.Service;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using NLog;

var logger = LogManager.GetCurrentClassLogger();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
logger.Info("Configuring services...");
builder.Services.AddControllers();
builder.Services.AddScoped<IRegistrationRL, RegistrationAPIRL>();
builder.Services.AddScoped<IRegistrationBL, RegistrationAPIBL>();

var connectionString = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<RegistrationContext>(options => options.UseSqlServer(connectionString));

// Add swagger to container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    logger.Info("Swagger enabled in Development mode");
}

// Configure the HTTP request pipeline.
logger.Info("Starting application...");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
