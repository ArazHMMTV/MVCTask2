using FrontToBackTask2.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-ANFV6LC;Database=FrontToBack;Trusted_Connection=true;Integrated Security=true;TrustServerCertificate=true") ;
});

var app = builder.Build();


app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}"
    );


//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();

app.Run();
