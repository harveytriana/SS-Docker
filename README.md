# Blazor WebAssembly and SkiaSharp
This is a simple Blazor WebAssembly application using SkiaSharp which is intended to be containerized. 

![Index](https://github.com/harveytriana/SS-Docker/blob/master/Screens/Index.png)

Try containerize that. The generation of the Docker image is not completed successfully.

The BUG concerns an unfiltered Python dependency for C# in wasm-tool.

Fixed by installing python3 libatomic1 in the Docker image.
