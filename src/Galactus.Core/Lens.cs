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

  sealed class ToLens<O, I, P> : Lens<O, P>
  {
    readonly Lens<O, I> outer;
    readonly Lens<I, P> inner;

    public ToLens(Lens<O, I> o, Lens<I, P> i)
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

  sealed class MapLens<M, P, PP> : Lens<M, PP>
  {
    readonly Lens<M, P>   lens;
    readonly Func<P, PP>  to  ;
    readonly Func<PP, P>  from;

    public MapLens(Lens<M, P> l, Func<P, PP> t, Func<PP, P> f)
    {
      // TODO: handle nulls
      lens = l;
      to   = t;
      from = f;
    }

    public override PP Get(M m)
    {
      return to(lens.Get(m));
    }

    public override M Set(M m, PP p)
    {
      return lens.Set(m, from(p));
    }

    public override void BuildPath(StringBuilder sb)
    {
      lens.BuildPath(sb);
    }
  }

  public static class LensExtensions
  {
    public static Lens<O, P> To<O, I, P>(this Lens<O, I> o, Lens<I, P> i)
    {
      return new ToLens<O, I, P>(o, i);
    }

    public static M Update<M, P>(this Lens<M, P> l, M m, Func<P, P> f)
    {
      return l.Set(m, f(l.Get(m)));
    }

    public static Lens<M, PP> Map<M, P, PP>(this Lens<M, P> l, Func<P, PP> to, Func<PP, P> from)
    {
      return new MapLens<M, P, PP>(l, to, from);
    }
  }
}
