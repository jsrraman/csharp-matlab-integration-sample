# csharp-matlab-integration-sample
Sample appliaction to show case the integration of MATLAB function in a C# console application 

Refer official MATLAB [documentation](https://in.mathworks.com/help/compiler_sdk/gs/create-a-cc-application-with-matlab-code-1.html) to generate the .NET assembly for the exported MATLAB function (i.e magic function) to be used in the C# application

Also make sure the following things
- The C# application type (32-bit/64-bit) should correspond to the exported MATLAB .NET assembly type (32-bit/64-bit)
- MATLAB generated .NET assembly [does not work with an application targeted for NET v4.5 framework](https://stackoverflow.com/a/17540664/431561) so target the application for .NET v4.0 framework for now