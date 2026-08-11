using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace CSharpWebApi.Extensions;

public static class OpenTelemetryExtensions
{
    public static IServiceCollection AddCSharpWebApiTelemetry(this IServiceCollection services, IConfiguration configuration)
    {
        var serviceName = configuration["OpenTelemetry:ServiceName"] ?? "CSharpWebApi";

        services.AddOpenTelemetry()
            .ConfigureResource(resource => resource.AddService(serviceName))
            .WithTracing(tracing => tracing
                .AddAspNetCoreInstrumentation()
                .AddSource("CSharpWebApi")
                .AddConsoleExporter());

        return services;
    }
}
