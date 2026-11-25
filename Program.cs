var builder = WebApplication.CreateBuilder(args);

var companyName = builder.Configuration["Company:Name"];

var app = builder.Build();

app.MapGet("/company", () =>
{
    return $"Company: {companyName}";
});

app.Run();