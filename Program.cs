var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Aktiverar MVC
var app = builder.Build();

app.UseStaticFiles();// Stöd för statiska filer
app.UseRouting();//Stöd för routing

//Routing standard
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run(); //Kör i gång applikationen
