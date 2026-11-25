
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Home endpoint
app.MapGet("/", () =>
{
    return "Welcome to Employee Management API!";
});

// Get all employees
app.MapGet("/employees", () =>
{
    var employees = new[]
    {
        new { Id = 1, Name = "Samuel", Department = "IT" },
        new { Id = 2, Name = "Grace", Department = "HR" },
        new { Id = 3, Name = "David", Department = "Finance" }
    };

    return Results.Ok(employees);
});

// Get one employee
app.MapGet("/employees/{id:int}", (int id) =>
{
    return $"You requested employee number {id}";
});

app.Run();
