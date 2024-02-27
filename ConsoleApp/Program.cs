#nullable disable
// from https://github.com/mattleibow/SkiaSharp-Docker
// update to net8

using System.Reflection;
using System.Runtime.InteropServices;

using SkiaSharp;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine($"Starting the app...");

            var os = RuntimeInformation.OSDescription;
            Console.WriteLine($"Your operating system is {os}.");

            var assembly = typeof(SKImageInfo).Assembly;
            var attributes = assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute));
            var versionAttr = (AssemblyInformationalVersionAttribute)attributes.FirstOrDefault();
            Console.WriteLine($"You are using SkiaSharp version {versionAttr?.InformationalVersion}.");

            var colorType = SKImageInfo.PlatformColorType;
            Console.WriteLine($"The color type for your platform is {colorType}.");

            Console.WriteLine($"All done.");
        }
    }
}
