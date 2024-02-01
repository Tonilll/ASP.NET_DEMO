var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Welcome}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "H24",
    pattern: "{controller=ProgrammeurWeb}/{action=H24}/{id?}"
);

app.Run();
