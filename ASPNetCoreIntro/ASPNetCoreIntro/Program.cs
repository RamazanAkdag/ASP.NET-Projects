using ASPNetCoreIntro.Services.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//istek : Bir kod bloðunun herhangi bir yerinde çaðrýlma 
//builder.Services.AddScoped<InLogger, DbLogger>();//bir kod blaoðu(scope(Class veya fonksiyon)) içindeki tüm istekler için ayný instanceyi döndürür fakat. Scope dýþýnda
//tüm isteklere ayrý instanceler döndürür
builder.Services.AddSingleton<InLogger,FileLogger>();//bunda ise ilk isteyen için biir instance oluþtur ve bunu bellekte tut. diðer isteyenler de bunu kullansýn
//builder.Services.AddTransient<ILogger, ILogger>();//tüm istekler için ayrý instance
builder.Services.AddSession();

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

app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "admin",
    pattern: "admin/{controller=Customer}/{action=Index}/{id?}"
    );

app.Run();
