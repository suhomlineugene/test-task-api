using testapp_api.Shared.Profiles;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddAutoMapper(typeof(MappingsProfile));


app.MapGet("/", () => "Hello World!");

app.Run();