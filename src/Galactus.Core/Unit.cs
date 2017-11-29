namespace Galactus.Core
{
  using System;

  public sealed class Unit : IEquatable<Unit>
  {
    public readonly static Unit Zero = new Unit ();

    public override int GetHashCode()
    {
      return 0x55555555;
    }

    public override bool Equals(object obj)
    {
      return obj != null && obj is Unit;
    }

    public bool Equals(Unit other)
    {
      return other != null;
    }
  }
}
