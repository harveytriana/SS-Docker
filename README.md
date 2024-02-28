# Blazor WebAssembly and SkiaSharp
This is a simple Blazor WebAssembly application using SkiaSharp which is intended to be containerized. 

![Index](https://github.com/harveytriana/SS-Docker/blob/master/Screens/Index.png)

Try containerize that. The generation of the Docker image is not completed successfully.

The file Notes.txt shows the essence of the logs that report the error. In the same repository is included a console application that uses SkiaSharp, in net8, which demonstrates that SkiaSharp does run in a container.

### The Docker log 
Running > docker build -t blazor-wa-ss .
```
[+] Building 26.8s (13/17)                                                                                  ...
 => [internal] load build definition from Dockerfile                                                                                                                           0.0s
 => => transferring dockerfile: 781B
...
Dockerfile:10
--------------------
   8 |     RUN dotnet workload restore
   9 |     COPY . .
  10 | >>> RUN dotnet build BlazorWAApp.csproj -c Release -o /app/build
  11 |
  12 |     FROM build AS publish
--------------------
ERROR: failed to solve: process "/bin/sh -c dotnet build BlazorWAApp.csproj -c Release -o /app/build" did not complete successfully: exit code: 1
...
MSBuild version 17.9.4+90725d08d for .NET
Determining projects to restore...
Restored /src/BlazorWAApp.csproj (in 11.69 sec).
Compiling native assets with emcc with -Oz. This may take a while ...
/usr/share/dotnet/packs/Microsoft.NET.Runtime.WebAssembly.Sdk/8.0.2/Sdk/WasmApp.Native.targets(366,5): error : Failed to compile /usr/share/dotnet/packs/Microsoft.NETCore.App.Runtime.Mono.browser-wasm/8.0.2/runtimes/browser-wasm/native/src/pinvoke.c -> /src/obj/Release/net8.0/wasm/for-build/pinvoke.o [/src/BlazorWAApp.csproj]
/usr/share/dotnet/packs/Microsoft.NET.Runtime.WebAssembly.Sdk/8.0.2/Sdk/WasmApp.Native.targets(366,5): error : unable to find python in $PATH [took 0.01s] [/src/BlazorWAApp.csproj]
/usr/share/dotnet/packs/Microsoft.NET.Runtime.WebAssembly.Sdk/8.0.2/Sdk/WasmApp.Native.targets(366,5): error : Failed to compile /usr/share/dotnet/packs/Microsoft.NETCore.App.Runtime.Mono.browser-wasm/8.0.2/runtimes/browser-wasm/native/src/corebindings.c -> /src/obj/Release/net8.0/wasm/for-build/corebindings.o [/src/BlazorWAApp.csproj]
/usr/share/dotnet/packs/Microsoft.NET.Runtime.WebAssembly.Sdk/8.0.2/Sdk/WasmApp.Native.targets(366,5): error : unable to find python in $PATH [took 0.01s] [/src/BlazorWAApp.csproj]
/usr/share/dotnet/packs/Microsoft.NET.Runtime.WebAssembly.Sdk/8.0.2/Sdk/WasmApp.Native.targets(366,5): error : Failed to compile /usr/share/dotnet/packs/Microsoft.NETCore.App.Runtime.Mono.browser-wasm/8.0.2/runtimes/browser-wasm/native/src/driver.c -> /src/obj/Release/net8.0/wasm/for-build/driver.o [/src/BlazorWAApp.csproj]
/usr/share/dotnet/packs/Microsoft.NET.Runtime.WebAssembly.Sdk/8.0.2/Sdk/WasmApp.Native.targets(366,5): error : unable to find python in $PATH [took 0.02s] [/src/BlazorWAApp.csproj]

Build FAILED.
...
3 Error(s)
```
