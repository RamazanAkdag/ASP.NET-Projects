using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using FluentValidation.AspNetCore;
using MvcWebUI.Helpers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IProductService, ProductManager>()
    .AddSingleton<IProductDal, EfProductDal>()
    .AddSingleton<ICategoryService, CategoryManager>()
    .AddSingleton<ICategoryDal, EfCategoryDal>()
    .AddScoped<ICartService, CartManager>()
    .AddScoped<ICartSessionHelper, CartSessionHelper>()
    .AddSingleton<IHttpContextAccessor, HttpContextAccessor>()
    .AddSession()
    .AddControllersWithViews()
    .AddFluentValidation(option => option.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

 



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
