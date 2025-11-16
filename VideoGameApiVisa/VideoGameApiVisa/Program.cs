using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Serilog;
using VideoGameApiVisa.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSerilog(options => options
           .WriteTo.Console()
           .WriteTo.Debug()
           .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
           .Enrich.FromLogContext()
           .MinimumLevel.Information());

builder.Services.AddDbContext<VideoGameDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
