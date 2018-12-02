# dotnet global tool for Protoc

> Easy install [protoc](https://github.com/protocolbuffers/protobuf) executable file.

[![Build status](https://dev.azure.com/lazarofl/dotnetglobal-protoc/_apis/build/status/dotnetglobal-protoc-ASP.NET%20Core-CI)](https://dev.azure.com/lazarofl/dotnetglobal-protoc/_build/latest?definitionId=-1) ![https://img.shields.io/badge/dotnet%20core-2.1-green.svg](https://img.shields.io/badge/dotnet%20core-2.1-green.svg) ![NuGet Pre Release](https://img.shields.io/nuget/vpre/protoc.svg)

Google´s https://github.com/protocolbuffers/protobuf demands you to download and maintain specific versions of protoc.exe executables to generate `C#` code from `.proto` files.

There was no CLI installation, until now.

## Installation

Windows:

https://www.nuget.org/packages/protoc

```sh
dotnet tool install --global protoc --version 3.6.1
```

to uninstall

```sh
dotnet tool uninstall --global protoc
```

## Usage Example

```sh
protoc --version
```

To generate `.cs` from `.proto`

```sh
cd <proto files directory>
protoc --proto_path=. --csharp_out=. filename.proto
```

`filename.cs` will be generated on `--csharp_out` directory path.

_For more examples and usage, please refer to google's protobuf [csharp generated](https://developers.google.com/protocol-buffers/docs/reference/csharp-generated) documentation._

## Installation from source code

```sh
git clone https://github.com/lazarofl/dotnetglobal-protoc.git protoc
cd protoc
dotnet build
dotnet tool install -g --add-source bin\Debug\ protoc
```

## Issues and Sugestions

<https://github.com/lazarofl/dotnetglobal-protoc/issues>

## Contributing

1. Fork it (<https://github.com/lazarofl/dotnetglobal-protoc/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Commit your changes (`git commit -am 'Add some fooBar'`)
4. Push to the branch (`git push origin feature/fooBar`)
5. Create a new Pull Request
