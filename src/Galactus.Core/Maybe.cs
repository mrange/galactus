namespace Galactus.Core
{
  using System;

  public struct Maybe<T>
  {
    readonly internal bool HasValue ;
    readonly internal T    Value    ;

    public Maybe(bool hasValue, T value)
    {
      HasValue  = hasValue;
      Value     = value   ;
    }
  }
   
  public static class Maybe
  {
    public static Maybe<T> Just<T>(this T v) => new Maybe<T>(true, v);

    public static Maybe<T> Nothing<T>() => new Maybe<T>(false, default(T));

    public static Maybe<T> Nothing<T>(this T ignored) => new Maybe<T>(false, default(T));

    public static Maybe<U> Bind<T, U>(this Maybe<T> m, Func<T, Maybe<U>> f)
    {
      if (m.HasValue)
      {
        return f(m.Value);
      }
      else
      {
        return Nothing<U>();
      }
    }

    public static Maybe<U> Combine<T, U>(this Maybe<T> m, Func<Maybe<U>> f)
    {
       
      if (m.HasValue)
      {
        return f();
      }
      else
      {
        return Nothing<U>();
      }
    }

    public static Maybe<(T, U)> And<T, U>(this Maybe<T> l, Maybe<U> r)
    {
      if (l.HasValue && r.HasValue)
      {
        var v = (l.Value, r.Value);
        return Just(v);
      }
      else
      {
        return Nothing<(T, U)>();
      }
    }

    public static Maybe<T> Or<T, U>(this Maybe<T> l, Maybe<T> r)
    {
      if (l.HasValue)
      {
        return l;
      }
      else
      {
        return r;
      }
    }

    public static Maybe<U> Map<T, U>(this Maybe<T> m, Func<T, U> f)
    {
      if (m.HasValue)
      {
        return Just(f(m.Value));
      }
      else
      {
        return Nothing<U>();
      }
    }

    public static T GetOrDefaultTo<T>(this Maybe<T> m, T defaultValue)
    {
      if (m.HasValue)
      {
        return m.Value;
      }
      else
      {
        return defaultValue;
      }
    }

    public static U IfElse<T, U>(this Maybe<T> m, Func<T, U> ifJust, Func<U> ifNothing)
    {
      if (m.HasValue)
      {
        return ifJust(m.Value);
      }
      else
      {
        return ifNothing();
      }
    }

  }
}
