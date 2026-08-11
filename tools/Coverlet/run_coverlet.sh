#!/usr/bin/env bash
set -euo pipefail
dotnet test ../../tests/CSharpWebApi.Tests/CSharpWebApi.Tests.csproj --collect:"XPlat Code Coverage"
