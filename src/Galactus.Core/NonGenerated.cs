

namespace Galactus.Standard
{
  using Galactus.Core;
  using System;
  using System.Windows;
  using System.Windows.Controls;

  public static partial class Properties
  {
    public partial class uIElement
    {
      public static readonly IProperty<UIElement, ILens> lens = new Property<UIElement, ILens>(DependencyProperties.LensProperty);
    }
  }

  public static partial class Controls<TMessage>
  {
    public partial class empty
    {
      public static IView<TMessage> View = new EmptyView<TMessage> ();
    }

    public partial class uIElement
    {
      public static IValue<TMessage, UIElement> lens(ILens v) => new SetValue<TMessage, UIElement, ILens>(Properties.uIElement.lens, v);
    }

    public partial class grid
    {
      static void UpdateRowDefinitions(Grid grid, GridLength[] gridLengths)
      {
        var rows      = grid.RowDefinitions;

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
        var columns   = grid.ColumnDefinitions;

        for (var iter = 0; iter < Math.Min(gridLengths.Length, columns.Count); ++iter)
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
  }
}