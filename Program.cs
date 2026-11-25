var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/employees", (ILogger<Program> logger) =>
{
    logger.LogInformation(
        "Employee endpoint was accessed");

    return "Employee records retrieved";
});

app.Run();