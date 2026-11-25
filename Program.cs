var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapGet("/environment", () =>
        "Development Mode");
}
else
{
    app.MapGet("/environment", () =>
        "Non-Development Mode");
}

app.Run();