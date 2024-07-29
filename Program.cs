var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // add this
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
