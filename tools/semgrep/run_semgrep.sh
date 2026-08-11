#!/usr/bin/env bash
set -euo pipefail
semgrep scan --config=p/csharp --error ../../src/CSharpWebApi/Analysis/SastFixture.cs
