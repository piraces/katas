# C# / .NET Core 2.2

Solution implemented in [.NET Core](https://dotnet.microsoft.com/) 2.2 using the C# language and the [xUnit testing tool](https://xunit.net/).

# Requirements

- .NET Core SDK (min version 2.2.402)
- Visual Studio (2017 or greater) / Visual Studio Code / Rider / Terminal

# How to build

Inside the folder `ManhattanDistance.Tests`, execute the following commands:

- `dotnet build` (this will build the solution restoring NuGet packages)

# Executing tests

After building, execute the command `dotnet test` to run all test in the solution.

All test must be successful.

# Other

There is one project for the 'main solution' (`ManhattanDistance.csproj`) and one project for the tests (`ManhattanDistance.Tests.csproj`) all grouped in a solution file (`ManhattanDistance.sln`).