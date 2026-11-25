var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/request-info", (HttpContext context) =>
{
    var method = context.Request.Method;

    var path = context.Request.Path.ToString();

    var host = context.Request.Host.ToString();

    return Results.Ok(new
    {
        Method = method,
        Path = path,
        Host = host
    });
});

app.Run();