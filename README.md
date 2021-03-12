# Run an External Executable in ASP.NET Core

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>

## [Medium Post](https://codeburst.io/run-an-external-executable-in-asp-net-core-5c2f8b6cacd9)

This post will go over an example use case that a `helloworld.exe` (in _Windows_) is executed from an ASP.NET Core Web API endpoint. This solution might need to be slightly modified if your application works in another OS.

## Solution Structure

- `HelloWorld`

  This project creates a contrived program called `helloworld.exe` in .NET 4.6.2 framework or in an older version. This `helloworld.exe` simulates the external program that will be triggered by an ASP.NET Core Web API project.

- `WebApi`

  In the `ValuesController`, an API executes the `helloworld.exe`.

## License

Feel free to use the code in this repository as it is under MIT license.

<a href='https://ko-fi.com/changhuixu' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi3.png?v=2' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>
