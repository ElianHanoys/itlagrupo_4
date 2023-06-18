using itlagrupo_4.Infrastructure.Context;
using NuGet.Protocol.Core.Types;
using Microsoft.EntityFrameworkCore;
using itlagrupo_4.Infrastructure.Context;
using itlagrupo_4.Infrastructure.Interfaces;
using itlagrupo_4.Infrastructure.Repositories;
using System.Runtime.CompilerServices;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Registro de dependencia base de de datos //
builder.Services.AddDbContext<itlagrupo_4Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PubsContext")));

// Repositories //
builder.Services.AddTransient<ITitlesRepository, TitlesRepository>();

// Registros de app services //
builder.Services.AddTransient<ITitlesService, TitlesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
