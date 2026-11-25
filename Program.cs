var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/employees/{id:int}", (int id) =>
{
    if (id != 1)
    {
        return Results.NotFound(
            "Employee not found");
    }

    return Results.Ok(new
    {
        Id = 1,
        Name = "Samuel"
    });
});

app.Run();