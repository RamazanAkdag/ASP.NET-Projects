using ASPNetCoreIntro.Services.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//istek : Bir kod blo�unun herhangi bir yerinde �a�r�lma 
//builder.Services.AddScoped<InLogger, DbLogger>();//bir kod blao�u(scope(Class veya fonksiyon)) i�indeki t�m istekler i�in ayn� instanceyi d�nd�r�r fakat. Scope d���nda
//t�m isteklere ayr� instanceler d�nd�r�r
builder.Services.AddSingleton<InLogger,FileLogger>();//bunda ise ilk isteyen i�in biir instance olu�tur ve bunu bellekte tut. di�er isteyenler de bunu kullans�n
//builder.Services.AddTransient<ILogger, ILogger>();//t�m istekler i�in ayr� instance
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
