

using Lab.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//Services
builder.Services.AddControllersWithViews();

string connectionStr = @"server=DESKTOP-U9LPM9Q;Database=LabDB;Trusted_Connection=True;";
builder.Services.AddDbContext<LabDbContext>(opt =>
{

    opt.UseSqlServer(connectionStr);
});

var app = builder.Build();
//Middleware
app.UseStaticFiles();

app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}"
    );

app.Run();
