using Microsoft.EntityFrameworkCore;
using stok_takip_1.Data;
using stok_takip_1.Data.Abstract;
using stok_takip_1.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataDbContext>(options => { 
    var cons = builder.Configuration.GetConnectionString("dene");
    options.UseSqlServer(cons);
});

builder.Services.AddScoped<IBrandsRepository, EfBrandsRepository>();
builder.Services.AddScoped<ICategoriesRepository, EfCategoriesRepository>();







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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
