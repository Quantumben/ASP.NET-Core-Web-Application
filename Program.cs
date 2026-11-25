using MyFirstWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<EmployeeService>();

var app = builder.Build();

app.MapGet("/employee", (EmployeeService service) =>
{
    return service.GetEmployee();
});

app.Run();