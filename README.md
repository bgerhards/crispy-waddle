# Crispy Waddle (Photo album contents display)

Crispy Waddle is a simple way to view your photo album contents. Simply run the application and enter the album number you would like to view (Currently only displaying ID and Title, but hey, what else do you need to know?).


## Installation

Depending on your Operating system, refer to the documentation listen with each technology:

Primary language: C# .NET (.NET Core 3.1)
Testing Framework: xUnit


## Test

Running tests can be done in your IDE of choice that supports `DOTNET` commands. 

To run the tests in the terminal, once you have .NET installed, simply access the root level and type `dotnet test`. That's it.

## Build

To build and run the application, Visual Studio is recommended because it has a build in compiler and launcher for debugging. 

If you desire to build and run the application from your terminal, run the following commands in order, beginning at the root directory:

#### Build the application (command are to be run in the root directory)
- `cd Crispy-Waddle-Console`
- `dotnet build`

#### Run the application
- `dotnet run bin/Debug/netcoreapp3.1/Crispy-Waddle-Console.dll`

Alternatively, run the bash script `runApplication.sh`