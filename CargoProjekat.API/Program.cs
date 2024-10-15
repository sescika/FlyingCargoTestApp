using CargoProject.API;
using CargoProject.API.Implementation;
using CargoProject.API.Interfaces;
using CargoProject.API.Validation;
using CargoProject.Data.Data;
using Microsoft.Data.SqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var settings = new AppSettings();

builder.Configuration.Bind(settings);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

////valdators
//builder.Services.AddTransient<UpdateProductDtoValidator>();
//builder.Services.AddTransient<AddProductDtoValidator>();

//other
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//connection
builder.Services.AddTransient<BazaCargoTestContext>(x => new BazaCargoTestContext(settings.ConnectionString));
builder.Services.AddScoped<IDbConnection>(x => new SqlConnection(settings.ConnectionString));

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
