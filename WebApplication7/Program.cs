using WebApplication7.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<FileDownloadService>();

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=File}/{action=DownloadFile}");

app.Run();