using CSharpWebApi.Extensions;
using CSharpWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddProblemDetails();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddCSharpWebApiTelemetry(builder.Configuration);
builder.Services.AddOpenApi();

var app = builder.Build();
app.UseExceptionHandler();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/health", () => Results.Ok(new { status = "healthy", framework = "net9.0" }))
    .WithName("HealthCheck")
    .WithTags("Health");

app.Run();

public partial class Program { }
