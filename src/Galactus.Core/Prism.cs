namespace Galactus.Core
{
  using System;
  using System.Text;

  public interface IPrism
  {

  }

  public abstract class Prism<M, P> : IPrism
  {
    public abstract Maybe<P> Get(M m);
    public abstract M Set(M m, P p);

    public abstract void BuildPath(StringBuilder sb);

    public sealed override string ToString()
    {
      var sb = new StringBuilder(16);
      sb.Append("Prism ");
      BuildPath(sb);
      return sb.ToString();
    }
  }

  sealed class ToPrism<O, I, P> : Prism<O, P>
  {
    readonly Prism<O, I> outer;
    readonly Prism<I, P> inner;

    public ToPrism(Prism<O, I> o, Prism<I, P> i)
    {
      // TODO: handle nulls
      outer = o;
      inner = i;
    }

    public override Maybe<P> Get(O m)
    {
      var om = outer.Get(m);
      return om.HasValue ? inner.Get(om.Value) : Maybe.Nothing<P>();
    }

    public override O Set(O m, P p)
    {
      var om = outer.Get(m);
      return om.HasValue ? outer.Set(m, inner.Set(om.Value, p)) : m;
    }

    public override void BuildPath(StringBuilder sb)
    {
      outer.BuildPath(sb);
      sb.Append("->");
      inner.BuildPath(sb);
    }
  }

  public delegate M DelayedSet<M>(M m);

  public static class Prism
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

  public static class PrismExtensions
  {
    public static DelayedSet<M> Set<M, P>(this Prism<M, P> l, P v)
    {
      return m => l.Set(m, v);
    }

    public static DelayedSet<M> Set<M, P>(this Prism<M, P> l, DelayedSet<P> p)
    {
      return m =>
        {
          var lm = l.Get(m);
          return lm.HasValue ? l.Set(m, p(lm.Value)) : m;
        };
    }

    public static Prism<O, P> To<O, I, P>(this Prism<O, I> o, Prism<I, P> i)
    {
      return new ToPrism<O, I, P>(o, i);
    }

    public static M Update<M, P>(this Prism<M, P> l, M m, Func<P, P> f)
    {
      var lm = l.Get(m);
      return lm.HasValue ? l.Set(m, f(lm.Value)) : m;
    }

    public static DelayedSet<M> Update<M, P>(this Prism<M, P> l, Func<P, P> f)
    {
      return m =>
        {
          var lm = l.Get(m);
          return lm.HasValue ? l.Set(m, f(lm.Value)) : m;
        };
    }
  }
}
