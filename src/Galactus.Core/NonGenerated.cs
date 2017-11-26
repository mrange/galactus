

namespace Galactus.Standard
{
  using Galactus.Core;

  public static partial class Controls<TMessage>
  {
    public partial class empty
    {
      public static IView<TMessage> View = new EmptyView<TMessage> ();
    }
  }
}