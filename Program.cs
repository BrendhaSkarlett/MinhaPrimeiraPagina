var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/sobre",async cotext =>
{
    await ContextBoundObject.Response.SendFile
}");

app.Run();
