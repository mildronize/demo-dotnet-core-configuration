var builder = WebApplication.CreateBuilder(args);

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
Console.WriteLine($"Env = {environment}");
Console.WriteLine($"MyAppSettings__ApplicationName = {Environment.GetEnvironmentVariable("MyAppSettings__ApplicationName")}");

// Add configuration from appsettings.json and appsettings.Production.json
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

var app = builder.Build();

app.MapGet("/", (IConfiguration config) =>
{
    var appSettings = config.GetSection("MyAppSettings");
    var version = appSettings["Version"];

    return Results.Ok(new
    {
        appName = new
        {
            withGetSection = appSettings["ApplicationName"],
            withConfiguration = builder.Configuration["MyAppSettings:ApplicationName"],
        },
        version
    });
});



app.Run();
