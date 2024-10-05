using ExpressTaste.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
  
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
    p.UseSqlServer(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSql")));

//builder.Services.AddDbContext<ExpressTasteDbContext>(p =>
//    p.UseSqlite(builder.Configuration.GetConnectionString("ExpressTasteStrConnectionSqLite")));

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
