# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

This is a C# / .NET 10 learning repository. Each project is a standalone console application exploring specific language concepts. All projects are organized under a single root solution (`StudyCenter.slnx`) for unified IntelliSense in VS Code.

## Commands

All commands should be run from within the target project directory (e.g., `ExerciseFour/ExerciseFour/`).

**Run a project:**
```bash
dotnet run --project <ProjectDir>/<ProjectName>/<ProjectName>.csproj
```

**Build a project:**
```bash
dotnet build <ProjectDir>/<ProjectName>/<ProjectName>.csproj
```

**Run from inside the project folder:**
```bash
cd ExerciseFour/ExerciseFour && dotnet run
```

There are no tests in this repository.

## Project Structure

Each exercise follows the pattern `<ExerciseName>/<ExerciseName>/Program.cs` with a matching `.csproj`. All projects target `net10.0` with `ImplicitUsings` and `Nullable` enabled.

| Directory | Topic |
|---|---|
| `FirstProject/` | Hello World, basic console output |
| `Course/` | Primitive types, numeric limits, string formatting, `CultureInfo.InvariantCulture` |
| `FirstExercise/` | Variables, decimal formatting (`F2`, `F3`, `F8`), string interpolation |
| `SecondExercise/` | `Console.ReadLine()`, `int.Parse`, `double.Parse`, `Split(' ')` for multi-value input |
| `ThirdExercise/` | `DateTime.Now.Hour` for time-based greetings, `if/else`, even/odd check |
| `ExerciseFour/` | `for` loop, accumulator pattern, integer sum |
| `ExerciseFive/` | Heron's formula, `Math.Sqrt`, `double` arithmetic, comparing two triangle areas |
| `ExerciseSix/` | Classes with fields, instance methods, `Domain/` subfolder, stock management (`Produto`, `ValorTotalEmEstoque`, `AdicionarProdutos`, `RemoverProdutos`) |
| `ExerciseSeven/` | OOP: classes, constructor overloading, constructor chaining (`: this()`), encapsulation (`private set`), `ToString()` override — bank account (`Conta`) with deposit/withdrawal and per-transaction fee |

## Conventions

- Entry point is always `Program.cs` with a `static void Main(string[] args)` method inside a namespace matching the project name.
- Numeric output uses `CultureInfo.InvariantCulture` with `.ToString("F2", ...)` to ensure a period (`.`) as the decimal separator.
- Console input always uses `Console.ReadLine()` — never `Console.Read()`.
- New exercises follow the naming pattern `ExerciseFive`, `ExerciseSix`, etc., as new directories at the repo root. After creating a new project, add its `.csproj` path to `StudyCenter.slnx` so it's included in IntelliSense.
