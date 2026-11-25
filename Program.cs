var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Home Page");

app.MapGet("/employees", () =>
{
    return "All Employees";
});

app.MapGet("/employees/{id:int}", (int id) =>
{
    return $"Employee ID: {id}";
});

app.MapPost("/employees", () =>
{
    return Results.Created(
        "/employees/4",
        new { Id = 4, Name = "Ada" });
});

app.Run();