using PhotosApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<DataService>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(x => x.MapControllers());
app.UseStaticFiles();
app.Run();
