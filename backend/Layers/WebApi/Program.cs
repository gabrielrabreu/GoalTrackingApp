using WebApi.Scope.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCustomControllers();
builder.Services.AddCustomVersioning();
builder.Services.AddCustomDatabase();
builder.Services.AddCustomServices();
builder.Services.AddCustomSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseCustomSwagger();
}

app.MapControllers();

app.Run();