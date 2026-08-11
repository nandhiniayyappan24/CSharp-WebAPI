# CSharp Web API — Monolithic (net6.0)

ASP.NET Core Web API monolithic project for **net6** branch targeting **net6.0**.

## Project type

- **Language:** C#
- **Scenario:** 1 - Monolithic
- **Project type:** ASP.NET Core Web API
- **Module:** flat (single module)

## Supported tools

- AltCover
- Coverlet
- NuGet-Audit
- OpenTelemetry
- Roslyn
- Semgrep
- Stryker.NET
- jscpd
- lizard
- pydriller
- roslyn-sast

## Build

```bash
dotnet restore CSharpWebApi.sln
dotnet build CSharpWebApi.sln
dotnet test CSharpWebApi.sln
dotnet msbuild tools/CSharpWebApi.Tools/CSharpWebApi.Tools.csproj -t:RunCoverlet
dotnet msbuild tools/CSharpWebApi.Tools/CSharpWebApi.Tools.csproj -t:RunAltCover
```

Fast build (compile only):

```bash
dotnet build CSharpWebApi.sln
```

## Run

```bash
dotnet run --project src/CSharpWebApi/CSharpWebApi.csproj
```

## Solution projects

| Project | Path | Role |
|---------|------|------|
| CSharpWebApi | `src/CSharpWebApi/` | ASP.NET Core Web API |
| CSharpWebApi.Tests | `tests/CSharpWebApi.Tests/` | xUnit tests (Coverlet, AltCover) |
| CSharpWebApi.Tools | `tools/CSharpWebApi.Tools/` | Tool integration (references Web API + tests) |

## Tool entry points

| Tool | Connection |
|------|------------|
| AltCover | NuGet in tests csproj + `tools/AltCover/` + ToolIntegration.targets |
| Coverlet | NuGet in tests csproj + `tools/Coverlet/` + ToolIntegration.targets |
| NuGet-Audit | `Directory.Build.props` NuGetAudit=true |
| OpenTelemetry | `src/CSharpWebApi/Extensions/OpenTelemetryExtensions.cs` |
| Roslyn | `.editorconfig` + analyzers during compile |
| Semgrep | `src/CSharpWebApi/Analysis/SastFixture.cs` + `tools/Semgrep/` |
| Stryker.NET | `tools/Stryker.NET/stryker-config.json` -> Services |
| jscpd | `tools/jscpd/.jscpd.json` -> Services |
| lizard | `src/CSharpWebApi/Analysis/ComplexitySample.cs` + `tools/lizard/` |
| pydriller | `tools/pydriller/run_pydriller.py` |
| roslyn-sast | `tools/roslyn-sast/.globalconfig` in GlobalAnalyzerConfigFiles |
