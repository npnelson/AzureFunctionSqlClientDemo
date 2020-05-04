# AzureFunctionSqlClientDemo
Demonstrates Microsoft.Data.SqlClient is not supported on this platform error

https://github.com/Azure/azure-functions-host/issues/5950

This is a Visual Studio 2019 sample that demonstrates one way to get a "Microsoft.Data.SqlClient is not supported on this platform" error.

The project includes an Azure Function triggered by an http binding - on my machine it's http://localhost:7071/api/Function1.

The program uses a bogus connection string. When running locally on Windows 10, the program correctly reports "Format of the initialization string does not conform to specification starting at index 0"

However, this sample also includes a Docker file. When lauching via Docker (in this case, using Docker Desktop with a Linux node) at http://localhost:34657/api/Function1 you will get "Microsoft.Data.SqlClient is not supported on this platform" 
