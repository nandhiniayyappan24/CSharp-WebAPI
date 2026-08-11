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
dotnet restore
dotnet build
dotnet test
```

## Run

```bash
dotnet run --project src/CSharpWebApi/CSharpWebApi.csproj
```

## Tool entry points

| Tool | Location |
|------|----------|
| AltCover | `tools/AltCover/run_altcover.sh` |
| Coverlet | `tools/Coverlet/run_coverlet.sh` |
| NuGet-Audit | `tools/NuGet-Audit/run_nuget_audit.sh` |
| OpenTelemetry | configured in `src/CSharpWebApi/Extensions/OpenTelemetryExtensions.cs` |
| Roslyn | `.editorconfig` + `src/CSharpWebApi/Analysis/LintViolations.cs` |
| Semgrep | `tools/semgrep/run_semgrep.sh` |
| Stryker.NET | `tools/stryker-config.json` |
| jscpd | `tools/jscpd/.jscpd.json` |
| lizard | `tools/lizard/run_lizard.sh` |
| pydriller | `tools/pydriller/run_pydriller.py` |
| roslyn-sast | `tools/roslyn-sast/.globalconfig` + `src/CSharpWebApi/Analysis/SastFixture.cs` |
