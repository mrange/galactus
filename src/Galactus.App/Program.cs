using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Galactus.App
{
  public static class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      //MutableModel.Program.Run();
      ImmutableModel.Program.Run();
      //Demo.Program.Run();
    }
  }
}
