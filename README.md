# Projeto de Automação - Desafios Técnicos

Este repositório contém soluções para vários desafios técnicos desenvolvidos em C#. Cada desafio está em seu próprio diretório com código-fonte e testes automatizados.

## Estrutura do Projeto

```plaintext
.
├── README.md
├── SwapVariables
│   ├── Program.cs
│   ├── data.txt
│   └── SwapVariables.csproj
├── SwapVariablesTests
│   ├── UnitTest1.cs
│   └── SwapVariablesTests.csproj
├── SalespersonSalary
│   ├── Program.cs
│   ├── data.txt
│   └── SalespersonSalary.csproj
├── SalespersonSalaryTests
│   ├── UnitTest1.cs
│   └── SalespersonSalaryTests.csproj
├── ShirtSales
│   ├── Program.cs
│   ├── data.txt
│   └── ShirtSales.csproj
├── ShirtSalesTests
│   ├── UnitTest1.cs
│   └── ShirtSalesTests.csproj
├── ChessGameDuration
│   ├── Program.cs
│   ├── chess_games.db
│   └── ChessGameDuration.csproj
└── ChessGameDurationTests
    ├── UnitTest1.cs
    └── ChessGameDurationTests.csproj

# Compilar e Executar Cada Projeto

## swapVariables

cd SwapVariables
dotnet build
dotnet run

## salespersonSalary

cd ../SalespersonSalary
dotnet build
dotnet run

## shirtSales

cd ../ShirtSales
dotnet build
dotnet run

## chessGameDuration

cd ../ChessGameDuration
dotnet build
dotnet run

# Executar Testes Automatizados

## swapVariablesTests

cd ../SwapVariablesTests
dotnet build
dotnet test

## salespersonSalaryTests

cd ../SalespersonSalaryTests
dotnet build
dotnet test

## shirtSalesTests

cd ../ShirtSalesTests
dotnet build
dotnet test

## chessGameDurationTests

cd ../ChessGameDurationTests
dotnet build
dotnet test

# Com essa estrutura e o README detalhado, você terá um projeto bem organizado e fácil de testar.
