var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

var app = builder.Build();

app.MapGet("/external-data", async (IHttpClientFactory factory) =>
{
    var client = factory.CreateClient();

    var response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");

    if (!response.IsSuccessStatusCode)
    {
        return Results.Problem(
            "External service is unavailable",
            statusCode: 502);
    }

    var data = await response.Content
        .ReadAsStringAsync();

    return Results.Content(
        data,
        "application/json");
});

app.Run();