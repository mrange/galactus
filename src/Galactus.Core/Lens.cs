namespace Galactus.Core
{
  using System;
  using System.Text;

  public abstract class Lens<M, P>
  {
    public abstract P Get(M m);
    public abstract M Set(M m, P p);

    public abstract void BuildPath(StringBuilder sb);

    public sealed override string ToString()
    {
      var sb = new StringBuilder(16);
      sb.Append("Lens ");
      BuildPath(sb);
      return sb.ToString();
    }
  }

  public sealed class FollowLens<O, I, P> : Lens<O, P>
  {
    readonly Lens<O, I> outer;
    readonly Lens<I, P> inner;

    public FollowLens(Lens<O, I> o, Lens<I, P> i)
    {
      // TODO: handle nulls
      outer = o;
      inner = i;
    }

    public override P Get(O m)
    {
      return inner.Get(outer.Get(m));
    }

    public override O Set(O m, P p)
    {
      return outer.Set(m, inner.Set(outer.Get(m), p));
    }

    public override void BuildPath(StringBuilder sb)
    {
      outer.BuildPath(sb);
      sb.Append("->");
      inner.BuildPath(sb);
    }
  }

  public static class LensExtensions
  {
    public static Lens<O, P> Follow<O, I, P>(this Lens<O, I> o, Lens<I, P> i)
    {
      return new FollowLens<O, I, P>(o, i);
    }

    public static M Map<M, P>(this Lens<M, P> l, M m, Func<P, P> f)
    {
      return l.Set(m, f(l.Get(m)));
    }
  }
}
