using OpenTelemetry;
using OpenTelemetry.Trace;

namespace CSharpWebApi.Extensions
{
    public static class OpenTelemetryBootstrap
    {
        private static TracerProvider _provider;

        public static void Initialize()
        {
            _provider = Sdk.CreateTracerProviderBuilder()
                .AddSource("CSharpWebApi")
                .AddConsoleExporter()
                .Build();

            var source = new System.Diagnostics.ActivitySource("CSharpWebApi");
            using (var activity = source.StartActivity("FrameworkWebApiStartup"))
            {
                activity?.SetTag("host.type", "owin");
            }
        }
    }
}
