var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDirectoryBrowser();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseDirectoryBrowser();

app.Run();
