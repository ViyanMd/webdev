using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Run(HangleRequest);

app.Run();

async Task HangleRequest(HttpContext context)
{
    context.Response.ContentType = "text/html; charset=utf-8";

    if (context.Request.Path == "/postuser")
    {
        var form = context.Request.Form;
        var name = form["name"];
        var age = form["age"];
        StringBuilder langList = new StringBuilder();

        foreach (var lang in form["languages"])
            langList.Append(" " + lang);

        await context.Response.WriteAsync($"<div><p>Name: {name}</p>" +
            $"<p>Age: {age}</p>" +
            $"<div>Languages:{langList}</div></div>");
    } else
        await context.Response.SendFileAsync("html/index.html");
}   