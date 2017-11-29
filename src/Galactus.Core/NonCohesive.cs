namespace Galactus.Core
{
  using System;
  using System.Runtime.CompilerServices;
  using System.Windows.Threading;

  public static class NonCohesive
  {
    [MethodImpl (MethodImplOptions.AggressiveInlining)]
    public static (ParentInfo ParentInfo, T Instance) GetInstance<T> (object o)
      where T : class, new ()
    {
      // TODO: Is there a faster way to test that o is exactly type T?
      return o != null && o.GetType () == typeof (T)
        ? (ParentInfo.ReusedInstance, (T)o)
        : (ParentInfo.NewInstance   , new T ())
        ;
    }

    public static void Delay(this Dispatcher dispatcher, Action action)
    {
      if (dispatcher != null)
      {
        // TODO: Handle delayed exceptions
        dispatcher.BeginInvoke (DispatcherPriority.ApplicationIdle, action);
      }
      else
      {
        action ();
      }
    }
  }
}
