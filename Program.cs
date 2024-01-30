var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Run(HangleRequest);

app.Run();

async Task HangleRequest(HttpContext context)
{
    var path = context.Request.Path;
    var date = DateTime.Now;
    var response = context.Response;

    if (path == "/date")
        await response.WriteAsync($"Date: {date.ToShortDateString()}");
    else if (path == "/time")
        await response.WriteAsync($"Time: {date.ToShortTimeString()}");
    else
        await response.WriteAsync("Not found");
}   