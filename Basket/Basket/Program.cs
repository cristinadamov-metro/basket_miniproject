using Basket;
using Basket.ArticleDomain;
using Basket.BasketDomain;
using Basket.CustomerDomain;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using System.Xml.Linq;
//// create an article model with following fields (id, name, price)
///make an api that return the article entity(for the moment it will return null)
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BasketContext>();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IBasketService, BasketService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();


var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/articles/{name}", async (string name, IArticleService articleService) =>
{

    return await articleService.FindItem(name); //IArticleService ArticleService
    //return list.Where(a => a.Name.Contains(name)).ToList();
    
});


app.MapPost("/articles", async (Article art, IArticleService articleService) =>
{
    await articleService.AddItem(art);
});

app.MapPost("/baskets", async (IBasketService basketService) =>
{
    return await basketService.Add();
});

app.MapGet("/baskets/{id}", async (Guid id, IBasketService basketService) =>
{
    return await basketService.Get(id);
}
);

app.MapPost("/baskets/{basketId}/articlelines/", async (Guid basketId, ArticleLineSaveDto dto, IBasketService basketService) =>{
    return await basketService.AddArticleLine(basketId, dto);
});

app.MapPost("/customers", async (Customer customer, ICustomerService customerService) =>
{
    await customerService.AddCustomerAsync(customer);
});

app.Run();




