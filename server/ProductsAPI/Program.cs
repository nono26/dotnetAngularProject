using Microsoft.EntityFrameworkCore;
using Products.Application;
using Products.Domain.Contracts;
using Products.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<Products.Infrastructure.ProductDb>(opt =>
    opt.UseInMemoryDatabase("ProductList"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IProductsHandler, ProductsHandler>();
builder.Services.AddTransient<IProductsGateway, ProductsGateway>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
