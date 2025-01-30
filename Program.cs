var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Aktiverar MVC
builder.Services.AddSession(); //Lägger till sessionshantering

var app = builder.Build();

app.UseStaticFiles();// Stöd för statiska filer
app.UseRouting();//Stöd för routing
app.UseSession(); //Aktiverar session

//Routing standard
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run(); //Kör i gång applikationen
