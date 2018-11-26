using System;
using System.Diagnostics;
using System.Reflection;

namespace protoc
{
  class Program
  {
    private const string PROTOC_EXE_PATH = @"\protoc\protoc.exe";

    static void Main(string[] args)
    {
      string currentDirectory = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      string protocPath = System.IO.Path.GetFullPath($"{currentDirectory}{PROTOC_EXE_PATH}");

      Console.WriteLine("-------------------------------");
      Console.WriteLine("Protoc dotnet global tool");
      Console.WriteLine("-------------------------------");
      Console.WriteLine("");

      var proc = new Process
      {
        StartInfo = new ProcessStartInfo
        {
          FileName = protocPath,
          Arguments = string.Join(" ", args),
          UseShellExecute = false,
          RedirectStandardOutput = true,
          RedirectStandardError = true,
          CreateNoWindow = true
        }
      };

      proc.Start();

      while (!proc.StandardOutput.EndOfStream)
        Console.WriteLine(proc.StandardOutput.ReadLine());

      while (!proc.StandardError.EndOfStream)
        Console.WriteLine(proc.StandardError.ReadLine());
    }
  }
}
