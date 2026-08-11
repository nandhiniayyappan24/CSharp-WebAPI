# CSharp Web API — Monolithic (net48)

ASP.NET Web API 2 (OWIN self-host) monolithic project for **net4.8** branch targeting **net48**.

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
