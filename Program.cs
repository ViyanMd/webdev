var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Run(HangleRequest);

app.Run();

async Task HangleRequest(HttpContext context)
{
    context.Response.ContentType = "text/html; charset=utf-8";

    if (context.Request.Path == "/old")
        context.Response.Redirect("/new");
    else if (context.Request.Path == "/new")
        await context.Response.WriteAsync("New Page");
    else
        await context.Response.WriteAsync("Main Page");
}