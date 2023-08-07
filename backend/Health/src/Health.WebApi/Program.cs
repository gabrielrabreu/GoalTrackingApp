using Health.WebApi.Scope.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCustomServices();
builder.Services.AddCustomControllers();
builder.Services.AddCustomSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseCustomSwagger();
}

app.MapControllers();

app.Run();
