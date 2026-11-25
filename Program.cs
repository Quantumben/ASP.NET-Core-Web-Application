var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


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



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler(errorApp =>
    {
        errorApp.Run(async context =>
        {
            context.Response.StatusCode = 500;

            await context.Response.WriteAsJsonAsync(
                new { Error = "An unexpected error occurred." });
        });
    });
}

app.MapGet("/", () => "Application running");

app.Run();