using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Services.Maintenance.Business.DI;
using Services.Maintenance.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OperationManagement.Services.Maintanence", Version = "v1" });
});

builder.Services.AddDbContext<MaintenanceDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("MaintanenceDb")));
builder.Services.AddDependencyInjection();

AppContext.SetSwitch("Npsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OperationManagement.Services.Maintanence v1"));
}

app.UseAuthorization();

app.MapControllers();

app.Run();
