# GrpcErrorRepro

This repository is for repro that is compile error when use Grpc with WPF on .NET Core apps.

## Repro steps

1. Clone this repository.
2. Type following commands.

```
cd ConsoleApp
dotnet build
```

That will finish with no compile error.

```
cd WpfApp
dotnet build
```

There is following compile errors.

```
MainWindow.xaml.cs(35,55): error CS0246: The type or namespace name 'MyGrpcServices' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\username\source\repos\GrpcErrorRepro\WpfApp\WpfApp_v4a1l2r4_wpftmp.csproj]
MainWindow.xaml.cs(36,47): error CS0246: The type or namespace name 'MyGrpcServices' could not be found (are you missing a using directive or an assembly reference?) [C:\Users\username\source\repos\GrpcErrorRepro\WpfApp\WpfApp_v4a1l2r4_wpftmp.csproj]
```
