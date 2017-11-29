namespace Galactus.Core
{
  using System;
  using System.Text;

  public interface ILens
  {

  }

  public abstract class Lens<M, P> : ILens
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

  sealed class AndLens<M, L, R> : Lens<M, (L left, R right)>
  {
    readonly Lens<M, L> left  ;
    readonly Lens<M, R> right ;

    public AndLens(Lens<M, L> l, Lens<M, R> r)
    {
      // TODO: Handle nulls
      left  = l;
      right = r;
    }

    public override void BuildPath(StringBuilder sb)
    {
      sb.Append('(');
      left.BuildPath(sb);
      sb.Append(',');
      right.BuildPath(sb);
      sb.Append(')');
    }

    public override (L left, R right) Get(M m)
    {
      return (left.Get(m), right.Get(m));
    }

    public override M Set(M m, (L left, R right) p)
    {
      return right.Set(left.Set(m, p.left), p.right);
    }
  }

  sealed class MapLens<M, P, PP> : Lens<M, PP>
  {
    readonly Lens<M, P>   lens;
    readonly Func<P, PP>  to  ;
    readonly Func<PP, P>  from;

    (int, string) Hello()
    {
      return (1, "");
    }

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

  public delegate M DelayedSet<M>(M m);

  public static class Lens
  {
    public static M SetAll<M>(M m, params DelayedSet<M>[] setters)
    {
      var s = m;
      foreach (var setter in setters)
      {
        s = setter(s);
      }
      return s;
    }

    public static DelayedSet<M> SetAll<M>(params DelayedSet<M>[] setters)
    {
      return m => SetAll(m, setters);
    }
  }

  public static class LensExtensions
  {
    public static Lens<M, (L left, R right)> And<M, L, R>(this Lens<M, L> l, Lens<M, R> r)
    {
      return new AndLens<M, L ,R>(l, r);
    }

    public static Lens<M, PP> Map<M, P, PP>(this Lens<M, P> l, Func<P, PP> to, Func<PP, P> from)
    {
      return new MapLens<M, P, PP>(l, to, from);
    }

    public static DelayedSet<M> Set<M, P>(this Lens<M, P> l, P v)
    {
      return m => l.Set(m, v);
    }

    public static DelayedSet<M> Set<M, P>(this Lens<M, P> l, DelayedSet<P> p)
    {
      return m => l.Set(m, p(l.Get(m)));
    }

    public static Lens<O, P> To<O, I, P>(this Lens<O, I> o, Lens<I, P> i)
    {
      return new ToLens<O, I, P>(o, i);
    }

    public static M Update<M, P>(this Lens<M, P> l, M m, Func<P, P> f)
    {
      return l.Set(m, f(l.Get(m)));
    }

    public static DelayedSet<M> Update<M, P>(this Lens<M, P> l, Func<P, P> f)
    {
      return m => l.Set(m, f(l.Get(m)));
    }
  }
}
