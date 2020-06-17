#!/bin/bash

cd ../Crispy-Waddle-Console
echo 'Building...'
dotnet build

echo 'Running...'
clear
dotnet run bin/Debug/netcoreapp3.1/Crispy-Waddle-Console.dll