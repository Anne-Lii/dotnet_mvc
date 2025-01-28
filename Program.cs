var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Aktiverar MVC
var app = builder.Build();

app.UseStaticFiles();// För att kunna använda statiska filer
app.UseRouting();//För routing

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
