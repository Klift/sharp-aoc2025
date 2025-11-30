# Advent of Code 2025 - C# Solutions

My solutions for [Advent of Code 2025](https://adventofcode.com/2025), implemented in C# / .NET 8.
Focusing on **Clean Architecture**, **TDD**, and **Zero-Allocation** parsing techniques.

## Structure

* **AoC.Core**: Shared interfaces (`ISolver`) and domain utilities (Grid, Point, etc.).
* **AoC.Solutions**: Daily puzzle logic (e.g., `Day01.cs`).
* **AoC.App**: Console runner with Dependency Injection and Benchmarking.
* **AoC.Tests**: xUnit test harness ensuring logic works against sample data.

## Usage

**Run a specific day:**
```bash
dotnet run --project src/AoC.App