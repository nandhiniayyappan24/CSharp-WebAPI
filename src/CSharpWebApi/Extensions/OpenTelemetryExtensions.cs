using System.Diagnostics;

namespace CSharpWebApi.Extensions
{
    public static class OpenTelemetryBootstrap
    {
        public static void Initialize()
        {
            var source = new TraceSource("CSharpWebApi");
            source.TraceEvent(TraceEventType.Information, 0, "Framework Web API startup (net45 DiagnosticSource)");
        }
    }
}
