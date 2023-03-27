using testapp_api.Shared.AppServices.Interfaces;
using testapp_api.Shared.Profiles;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddOpenApiDocument();
    
    builder.Services.AddAutoMapper(typeof(MappingsProfile));
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy",
            builder =>
            {
                builder.WithOrigins("http://localhost:4200", "http://yourdomain.com").AllowAnyMethod()
                    .AllowAnyHeader();
            });
    });
    builder.Services.Scan(scan => scan.FromAssemblyOf<ITestFileAppService>().AddClasses()
        .AsMatchingInterface());
}

var app = builder.Build();
{
    app.UseCors("CorsPolicy");
    app.UseRouting();

    app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

    app.MapControllers();
    if (app.Environment.IsDevelopment())
    {
        app.UseOpenApi();
        app.UseSwaggerUi3();
    }


    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}
app.Run();