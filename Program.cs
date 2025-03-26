var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/student", () => "Artem Yurchenko [KP-22]");

app.Run();
