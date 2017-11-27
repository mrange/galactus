using System;

namespace Galactus.App
{
  public static class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      //MutableModel.Program.Run();
      ImmutableModel.Program.Run();
    }
  }
}
