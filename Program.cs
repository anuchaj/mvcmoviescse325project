using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

var builder = WebApplication.CreateBuilder(args);

// Add MVC services.
builder.Services.AddControllersWithViews();

// Add Entity Framework Core with SQLite.
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("MvcMovieContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Default MVC route.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
