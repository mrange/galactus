

namespace Galactus.Standard
{
  using Galactus.Core;
  using System;
  using System.Collections.ObjectModel;
  using System.Windows;
  using System.Windows.Controls;

  public static partial class Properties
  {
    public partial class uIElement
    {
      public static readonly IProperty<UIElement, IPrism> prism = new Property<UIElement, IPrism>(DependencyProperties.PrismProperty);
    }
  }

  public static partial class Controls<TMessage>
  {
    public partial class empty
    {
      public static IView<TMessage> View = new EmptyView<TMessage> ();
    }

    public partial class contentControl
    {
      sealed class ContentViewValue : IViewValue<TMessage, ContentControl>
      {
        readonly IView<TMessage> view;

        public ContentViewValue(IView<TMessage> v)
        {
          view = v ?? empty.View;
        }

        public IView<TMessage> View => view;

        public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
        {
          var tui = (ContentControl)ui;

          var content = tui.Content as UIElement;
          var ncontent= view.Update(ctx, pi, content);
          if (!ReferenceEquals(content, ncontent))
          {
            tui.Content = ncontent;
          }
        }
      }

      public static IValue<TMessage, ContentControl> contentView(IView<TMessage> v) => new ContentViewValue(v);
    }

    public partial class decorator
    {
      sealed class DecoratorViewValue : IViewValue<TMessage, Decorator>
      {
        readonly IView<TMessage> view;

        public DecoratorViewValue(IView<TMessage> v)
        {
          view = v ?? empty.View;
        }

        public IView<TMessage> View => view;

        public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
        {
          var tui = (Decorator)ui;

          var child = tui.Child;
          var nchild = view.Update(ctx, pi, child);
          if (!ReferenceEquals(child, nchild))
          {
            tui.Child = nchild;
          }
        }
      }

      public static IValue<TMessage, Decorator> decoratorView(IView<TMessage> v) => new DecoratorViewValue(v);
    }

   public partial class headeredContentControl
    {
      sealed class HeaderViewValue : IViewValue<TMessage, HeaderedContentControl>
      {
        readonly IView<TMessage> view;

        public HeaderViewValue(IView<TMessage> v)
        {
          view = v ?? empty.View;
        }

        public IView<TMessage> View => view;

        public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
        {
          var tui = (HeaderedContentControl)ui;

          var header  = tui.Header as UIElement;
          var nheader = view.Update(ctx, pi, header);
          if (!ReferenceEquals(header, nheader))
          {
            tui.Header = nheader;
          }
        }
      }

      public static IValue<TMessage, HeaderedContentControl> headerView(IView<TMessage> v) => new HeaderViewValue(v);
    }

    public partial class grid
    {
      static void UpdateRowDefinitions(Grid grid, GridLength[] gridLengths)
      {
        var rows = grid.RowDefinitions;

        var commonCount = Math.Min(gridLengths.Length, rows.Count);

        for (var iter = 0; iter < Math.Min(gridLengths.Length, rows.Count); ++iter)
        {
          rows[0].Height  = gridLengths[iter];
        }

        if (gridLengths.Length < rows.Count)
        {
          rows.RemoveRange(gridLengths.Length, rows.Count - gridLengths.Length);
        }
        else if (gridLengths.Length > rows.Count)
        {
          for (var iter = rows.Count; iter < gridLengths.Length; ++iter)
          {
            rows.Add(new RowDefinition()
              {
                Height = gridLengths[0]
              });
          }
        }
      }

      public static IValue<TMessage, Grid> rowDefinitions(params GridLength[] gridLengths) => new InvokedValue<TMessage, Grid>(
        (ctx, pi, ui) => UpdateRowDefinitions((Grid)ui, gridLengths));

      public static IValue<TMessage, Grid> rowDefinitions(params (double height, GridUnitType unit)[] gridLengths) => new InvokedValue<TMessage, Grid>(
        (ctx, pi, ui) => 
        {
          var gls = new GridLength[gridLengths.Length];
          for (var iter = 0; iter < gridLengths.Length; ++iter)
          {
            var gl    = gridLengths[iter];
            gls[iter] = new GridLength(gl.height, gl.unit);
          }
          UpdateRowDefinitions((Grid)ui, gls);
        });

      static void UpdateColumnDefinitions(Grid grid, GridLength[] gridLengths)
      {
        var columns = grid.ColumnDefinitions;

        var commonCount = Math.Min(gridLengths.Length, columns.Count);

        for (var iter = 0; iter < commonCount; ++iter)
        {
          columns[0].Width  = gridLengths[iter];
        }

        if (gridLengths.Length < columns.Count)
        {
          columns.RemoveRange(gridLengths.Length, columns.Count - gridLengths.Length);
        }
        else if (gridLengths.Length > columns.Count)
        {
          for (var iter = columns.Count; iter < gridLengths.Length; ++iter)
          {
            columns.Add(new ColumnDefinition()
              {
                Width = gridLengths[0]
              });
          }
        }
      }

      public static IValue<TMessage, Grid> columnDefinitions(params GridLength[] gridLengths) => new InvokedValue<TMessage, Grid>(
        (ctx, pi, ui) => UpdateColumnDefinitions((Grid)ui, gridLengths));

      public static IValue<TMessage, Grid> columnDefinitions(params (double width, GridUnitType unit)[] gridLengths) => new InvokedValue<TMessage, Grid>(
        (ctx, pi, ui) => 
        {
          var gls = new GridLength[gridLengths.Length];
          for (var iter = 0; iter < gridLengths.Length; ++iter)
          {
            var gl    = gridLengths[iter];
            gls[iter] = new GridLength(gl.width, gl.unit);
          }
          UpdateRowDefinitions((Grid)ui, gls);
        });

    }

    public partial class itemsControl
    {
      sealed class ItemSourceViewsValue : IViewsValue<TMessage, ItemsControl>
      {
        readonly IView<TMessage>[] views;

        public ItemSourceViewsValue(IView<TMessage>[] vs)
        {
          views = vs;
        }

        public IView<TMessage>[] Views => views;

        public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
        {
          var tui = (ItemsControl)ui;

          // TODO: How to rebuild this more efficiently?

          var children = tui.ItemsSource as ObservableCollection<UIElement>;
          if (children == null)
          {
            children = new ObservableCollection<UIElement>();
            tui.ItemsSource = children;
          }

          var commonCount = Math.Min(views.Length, children.Count);

          for (var iter = 0; iter < commonCount; ++iter)
          {
            var child   = children[iter];
            var view    = views[iter];
            var nchild  = view.Update(ctx, pi, child);
            if (!ReferenceEquals(child, nchild))
            {
              children[iter] = nchild;
            }
          }

          if (views.Length < children.Count)
          {
            for (var iter = views.Length - 1; iter >= children.Count; --iter)
            {
              children.RemoveAt(iter);
            }
          }
          else if (views.Length > children.Count)
          {
            for (var iter = children.Count; iter < views.Length; ++iter)
            {
              var view    = views[iter];
              var nchild  = view.Update(ctx, pi, null);
              children.Add(nchild);
            }
          }

        }
      }

      public static IValue<TMessage, ItemsControl> itemSourceViews(params IView<TMessage>[] vs) => new ItemSourceViewsValue(vs);
    }

    public partial class panel
    {
      sealed class PanelViewsValue : IViewsValue<TMessage, Panel>
      {
        readonly IView<TMessage>[] views;

        public PanelViewsValue(IView<TMessage>[] vs)
        {
          views = vs;
        }

        public IView<TMessage>[] Views => views;

        public void Update(UpdateContext ctx, ParentInfo pi, UIElement ui)
        {
          var tui = (Panel)ui;

          var children = tui.Children;

          var commonCount = Math.Min(views.Length, children.Count);

          for (var iter = 0; iter < commonCount; ++iter)
          {
            var child   = children[iter];
            var view    = views[iter];
            var nchild  = view.Update(ctx, pi, child);
            if (!ReferenceEquals(child, nchild))
            {
              // TODO: How to do this more efficiently?
              Console.WriteLine("Remove/Insert");
              children.RemoveAt(iter);
              children.Insert(iter, nchild);
            }
          }

          if (views.Length < children.Count)
          {
            children.RemoveRange(views.Length, children.Count - views.Length);
          }
          else if (views.Length > children.Count)
          {
            for (var iter = children.Count; iter < views.Length; ++iter)
            {
              var view    = views[iter];
              var nchild  = view.Update(ctx, pi, null);
              children.Add(nchild);
            }
          }

        }
      }

      public static IValue<TMessage, Panel> childViews(params IView<TMessage>[] vs) => new PanelViewsValue(vs);
    }

    public partial class uIElement
    {
      public static IValue<TMessage, UIElement> prism(IPrism v) => new SetValue<TMessage, UIElement, IPrism>(Properties.uIElement.prism, v);
    }

  }
}