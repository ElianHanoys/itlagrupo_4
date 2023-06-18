using itlagrupo_4.Infrastructure.Context;
using itlagrupo_4.Infrastructure.Interfaces;
using itlagrupo_4.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Reigstro de dependencia a la base de datos.
builder.Services.AddDbContext<PubsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PubsContext")));

// Repositories //

builder.Services.AddTransient< IAuthorRepository,AuthorRepository>();


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
