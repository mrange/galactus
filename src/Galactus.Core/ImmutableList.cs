
namespace Galactus.Core
{
  using System;
  using System.Collections;
  using System.Collections.Generic;

  public interface IImmutableList<out T> : IEnumerable<T>
  {
    bool IsEmpty { get; }
  }

  public static class ImmutableList
  {
    sealed class EmptyList<T> : IImmutableList<T>
    {
      bool IsEmpty => true;

      bool IImmutableList<T>.IsEmpty => throw new NotImplementedException();

      public IEnumerator<T> GetEnumerator()
      {
        yield break;
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return GetEnumerator();
      }
    }

    sealed class ConsList<T> : IImmutableList<T>
    {
      // For efficiency reasons these might be mutatated upon creation by various algorithms
      public T                 Head;
      public IImmutableList<T> Tail;

      public ConsList(T head, IImmutableList<T> tail)
      {
        Head = head;
        Tail = tail;
      }

      public bool IsEmpty => false;

      public IEnumerator<T> GetEnumerator()
      {
        var current = this;

        do
        {
          yield return current.Head;
        } while((current = current.Tail as ConsList<T>) != null);
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return GetEnumerator();
      }
    }

    public static IImmutableList<T> Empty<T>() => new EmptyList<T>();
    
    public static IImmutableList<T> Cons<T>(T head, IImmutableList<T> tail) => new ConsList<T>(head, tail ?? Empty<T>());

    public static IImmutableList<T> ToImmutableList<T>(this IEnumerable<T> enumerable)
    {
      if (enumerable != null)
      {
        using (var e = enumerable.GetEnumerator())
        {
          if (e.MoveNext())
          {
            var head    = new ConsList<T>(e.Current, null);
            var current = head;

            while (e.MoveNext())
            {
              var next      = new ConsList<T>(e.Current, null);
              current.Tail  = next;
              current       = next;
            }

            current.Tail = Empty<T>();

            return current;
          }
          else
          {
            return Empty<T>();
          }
        }
      }
      else
      {
        return Empty<T>();
      }
    }

    public static IImmutableList<T> Cons<T>(this IImmutableList<T> t, T h)
    {
      return Cons(h, t);
    }

    public static IImmutableList<T> Reverse<T>(this IImmutableList<T> l)
    {
      var result  = Empty<T>();
      var current = l as ConsList<T>;

      while (current != null)
      {
        result  = Cons(current.Head, result);
        current = current.Tail as ConsList<T>;
      }

      return result;
    }

    public static U Fold<T, U>(this IImmutableList<T> l, Func<U, T, U> f, U z)
    {
      var result  = z;
      var current = l as ConsList<T>;

      while (current != null)
      {
        result  = f(result, current.Head);
        current = current.Tail as ConsList<T>;
      }

      return result;
    }

    public static Maybe<(T head, IImmutableList<T> tail)> Decons<T>(this IImmutableList<T> l)
    {
      var cons = l as ConsList<T>;
      if (cons != null)
      {
        return (cons.Head, cons.Tail).Just();
      }
      else
      {
        return Maybe.Nothing<(T, IImmutableList<T>)>();
      }
    }

    public static U IfElse<T, U>(this IImmutableList<T> l, Func<T, IImmutableList<T>, U> ifCons, Func<U> ifEmpty)
    {
      var cons = l as ConsList<T>;
      if (cons != null)
      {
        return ifCons(cons.Head, cons.Tail);
      }
      else
      {
        return ifEmpty();
      }
    }

  }


}
