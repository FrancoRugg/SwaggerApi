using api.services.Handlers;
using api.services.Repositories;
using api.services.Services;
using Microsoft.AspNetCore.Builder;
using Umbraco.Core.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

//Config de Controllers
builder.Services.AddControllers();

//Config de Swagger
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

//Config de seguridad de Cors
builder.Services.AddCors(options => options.AddDefaultPolicy(builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
}));

//cadena de conexión a la base de datos
SqliteHandler.ConnString = builder.Configuration.GetConnectionString("defaultConnection");

//inyección de dependencias
//singleton el servicio se ejecuta cada vez que es llamado
builder.Services.AddSingleton<IArticlesRepository, ArticlesService>();
builder.Services.AddSingleton<IPageInfoRepository, PageInfoService>();
builder.Services.AddSingleton<IDatabaseRepository, DataBaseService>();



var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/time", () =>
{
    return DateTime.Now.ToString();
});

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();
app.UseHttpsRedirection();
app.MapControllers();
app.UseAuthentication();
app.UseAuthorization();
app.UseSwaggerUI((c) =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "AngularApi.web");
    c.RoutePrefix = string.Empty;
});
app.Run();

