var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("Request received");

    await next();

    Console.WriteLine("Response completed");
});

app.MapGet("/", () => "Welcome!");

app.Run();