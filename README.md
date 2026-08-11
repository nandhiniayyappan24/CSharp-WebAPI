# CSharp Web API — Monolithic (net45)

ASP.NET Web API 2 (OWIN self-host) monolithic project for **net4.5** branch targeting **net45**.

## Project type

- **Language:** C#
- **Scenario:** 1 - Monolithic
- **Project type:** ASP.NET Web API 2 (.NET Framework)
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
```

## Tests (net45)

`dotnet test` does not discover xUnit tests on .NET Framework 4.5 with modern VSTest. Use the MSBuild target instead:

```bash
dotnet msbuild tools/CSharpWebApi.Tools/CSharpWebApi.Tools.csproj -t:RunTests
```

## Run

```bash
dotnet run --project src/CSharpWebApi/CSharpWebApi.csproj
```

## Solution projects

| Project | Path | Role |
|---------|------|------|
| CSharpWebApi | `src/CSharpWebApi/` | ASP.NET Web API 2 |
| CSharpWebApi.Tests | `tests/CSharpWebApi.Tests/` | xUnit tests |
| CSharpWebApi.Tools | `tools/CSharpWebApi.Tools/` | Tool integration |
