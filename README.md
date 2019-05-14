[![CodeFactor](https://www.codefactor.io/repository/github/konard/t4genericsexample/badge)](https://www.codefactor.io/repository/github/konard/t4genericsexample)

# T4GenericsExample
This example shows how to generate multiple generic interface implementations using T4 text templates.
There is the `IGeneric<T>` interface.
T4 is used to generate specific implementations of this interface for `UInt64`, `UInt32`, `UInt16` and `Byte` types.
All implementations share single base template `GenericClass.ttinclude` logic.

## Setup
Requires .NET Core 2.2 SDK and Runtime.

https://dotnet.microsoft.com/download

## Run
```
dotnet run
```

## Development process videos
https://www.youtube.com/playlist?list=PLeYxH0Vd8louZqRXtRXm1X3HAEYcwR4ZQ
