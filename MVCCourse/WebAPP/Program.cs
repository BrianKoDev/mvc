using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//inject all services requred by MapControllerRoute
builder.Services.AddControllersWithViews();

var app = builder.Build();


//enable static files access
app.UseStaticFiles();
app.UseRouting();

// Map a default controller route for the application
app.MapControllerRoute(
    name: "default",                   // Name of the route
    pattern: "{controller=Home}/{action=Index}/{id?}"
// The route pattern:
//   - {controller}: Defaults to "Home" if not provided
//   - {action}: Defaults to "Index" if not provided
//   - {id?}: optional id
);



app.Run();

