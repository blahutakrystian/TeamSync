using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services
    .AddFastEndpoints()
    .SwaggerDocument();

var app = builder.Build();

app
    .UseFastEndpoints()
    .UseSwaggerGen();

app.UseHttpsRedirection();

app.Run();


