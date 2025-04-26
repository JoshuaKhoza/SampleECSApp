var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("<h1><b>Your Name</b></h1>", "text/html"));

app.Run();
