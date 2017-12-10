

#pragma warning disable CS0108
namespace Galactus.Standard
{
  using Galactus.Core;


  public static partial class Properties
  {
    public partial class accessText : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.AccessText, System.String> text = new Property<System.Windows.Controls.AccessText, System.String>(System.Windows.Controls.AccessText.TextProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.Media.FontFamily> fontFamily = new Property<System.Windows.Controls.AccessText, System.Windows.Media.FontFamily>(System.Windows.Controls.AccessText.FontFamilyProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.FontStyle> fontStyle = new Property<System.Windows.Controls.AccessText, System.Windows.FontStyle>(System.Windows.Controls.AccessText.FontStyleProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.FontWeight> fontWeight = new Property<System.Windows.Controls.AccessText, System.Windows.FontWeight>(System.Windows.Controls.AccessText.FontWeightProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.FontStretch> fontStretch = new Property<System.Windows.Controls.AccessText, System.Windows.FontStretch>(System.Windows.Controls.AccessText.FontStretchProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Double> fontSize = new Property<System.Windows.Controls.AccessText, System.Double>(System.Windows.Controls.AccessText.FontSizeProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.Media.Brush> foreground = new Property<System.Windows.Controls.AccessText, System.Windows.Media.Brush>(System.Windows.Controls.AccessText.ForegroundProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.AccessText, System.Windows.Media.Brush>(System.Windows.Controls.AccessText.BackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.TextDecorationCollection> textDecorations = new Property<System.Windows.Controls.AccessText, System.Windows.TextDecorationCollection>(System.Windows.Controls.AccessText.TextDecorationsProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.Media.TextEffectCollection> textEffects = new Property<System.Windows.Controls.AccessText, System.Windows.Media.TextEffectCollection>(System.Windows.Controls.AccessText.TextEffectsProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Double> lineHeight = new Property<System.Windows.Controls.AccessText, System.Double>(System.Windows.Controls.AccessText.LineHeightProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.LineStackingStrategy> lineStackingStrategy = new Property<System.Windows.Controls.AccessText, System.Windows.LineStackingStrategy>(System.Windows.Controls.AccessText.LineStackingStrategyProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.TextAlignment> textAlignment = new Property<System.Windows.Controls.AccessText, System.Windows.TextAlignment>(System.Windows.Controls.AccessText.TextAlignmentProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.TextTrimming> textTrimming = new Property<System.Windows.Controls.AccessText, System.Windows.TextTrimming>(System.Windows.Controls.AccessText.TextTrimmingProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Windows.TextWrapping> textWrapping = new Property<System.Windows.Controls.AccessText, System.Windows.TextWrapping>(System.Windows.Controls.AccessText.TextWrappingProperty);
      public static readonly IProperty<System.Windows.Controls.AccessText, System.Double> baselineOffset = new Property<System.Windows.Controls.AccessText, System.Double>(System.Windows.Controls.AccessText.BaselineOffsetProperty);
    }

    public partial class activeXHost : hwndHost
    {
    }

    public partial class adornedElementPlaceholder : frameworkElement
    {
    }

    public partial class adorner : frameworkElement
    {
    }

    public partial class adornerDecorator : decorator
    {
    }

    public partial class adornerLayer : frameworkElement
    {
    }

    public partial class border : decorator
    {
      public static readonly IProperty<System.Windows.Controls.Border, System.Windows.Thickness> borderThickness = new Property<System.Windows.Controls.Border, System.Windows.Thickness>(System.Windows.Controls.Border.BorderThicknessProperty);
      public static readonly IProperty<System.Windows.Controls.Border, System.Windows.Thickness> padding = new Property<System.Windows.Controls.Border, System.Windows.Thickness>(System.Windows.Controls.Border.PaddingProperty);
      public static readonly IProperty<System.Windows.Controls.Border, System.Windows.CornerRadius> cornerRadius = new Property<System.Windows.Controls.Border, System.Windows.CornerRadius>(System.Windows.Controls.Border.CornerRadiusProperty);
      public static readonly IProperty<System.Windows.Controls.Border, System.Windows.Media.Brush> borderBrush = new Property<System.Windows.Controls.Border, System.Windows.Media.Brush>(System.Windows.Controls.Border.BorderBrushProperty);
      public static readonly IProperty<System.Windows.Controls.Border, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.Border, System.Windows.Media.Brush>(System.Windows.Controls.Border.BackgroundProperty);
    }

    public partial class bulletDecorator : decorator
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.BulletDecorator, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.Primitives.BulletDecorator, System.Windows.Media.Brush>(System.Windows.Controls.Primitives.BulletDecorator.BackgroundProperty);
    }

    public partial class button : buttonBase
    {
      public static readonly IProperty<System.Windows.Controls.Button, System.Boolean> isDefault = new Property<System.Windows.Controls.Button, System.Boolean>(System.Windows.Controls.Button.IsDefaultProperty);
      public static readonly IProperty<System.Windows.Controls.Button, System.Boolean> isCancel = new Property<System.Windows.Controls.Button, System.Boolean>(System.Windows.Controls.Button.IsCancelProperty);
    }

    public partial class buttonBase : contentControl
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.ButtonBase, System.Windows.Input.ICommand> command = new Property<System.Windows.Controls.Primitives.ButtonBase, System.Windows.Input.ICommand>(System.Windows.Controls.Primitives.ButtonBase.CommandProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.ButtonBase, System.Object> commandParameter = new Property<System.Windows.Controls.Primitives.ButtonBase, System.Object>(System.Windows.Controls.Primitives.ButtonBase.CommandParameterProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.ButtonBase, System.Windows.IInputElement> commandTarget = new Property<System.Windows.Controls.Primitives.ButtonBase, System.Windows.IInputElement>(System.Windows.Controls.Primitives.ButtonBase.CommandTargetProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.ButtonBase, System.Windows.Controls.ClickMode> clickMode = new Property<System.Windows.Controls.Primitives.ButtonBase, System.Windows.Controls.ClickMode>(System.Windows.Controls.Primitives.ButtonBase.ClickModeProperty);
    }

    public partial class calendar : control
    {
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Windows.Style> calendarButtonStyle = new Property<System.Windows.Controls.Calendar, System.Windows.Style>(System.Windows.Controls.Calendar.CalendarButtonStyleProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Windows.Style> calendarDayButtonStyle = new Property<System.Windows.Controls.Calendar, System.Windows.Style>(System.Windows.Controls.Calendar.CalendarDayButtonStyleProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Windows.Style> calendarItemStyle = new Property<System.Windows.Controls.Calendar, System.Windows.Style>(System.Windows.Controls.Calendar.CalendarItemStyleProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.DateTime> displayDate = new Property<System.Windows.Controls.Calendar, System.DateTime>(System.Windows.Controls.Calendar.DisplayDateProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Nullable<System.DateTime>> displayDateEnd = new Property<System.Windows.Controls.Calendar, System.Nullable<System.DateTime>>(System.Windows.Controls.Calendar.DisplayDateEndProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Nullable<System.DateTime>> displayDateStart = new Property<System.Windows.Controls.Calendar, System.Nullable<System.DateTime>>(System.Windows.Controls.Calendar.DisplayDateStartProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Windows.Controls.CalendarMode> displayMode = new Property<System.Windows.Controls.Calendar, System.Windows.Controls.CalendarMode>(System.Windows.Controls.Calendar.DisplayModeProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.DayOfWeek> firstDayOfWeek = new Property<System.Windows.Controls.Calendar, System.DayOfWeek>(System.Windows.Controls.Calendar.FirstDayOfWeekProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Boolean> isTodayHighlighted = new Property<System.Windows.Controls.Calendar, System.Boolean>(System.Windows.Controls.Calendar.IsTodayHighlightedProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Nullable<System.DateTime>> selectedDate = new Property<System.Windows.Controls.Calendar, System.Nullable<System.DateTime>>(System.Windows.Controls.Calendar.SelectedDateProperty);
      public static readonly IProperty<System.Windows.Controls.Calendar, System.Windows.Controls.CalendarSelectionMode> selectionMode = new Property<System.Windows.Controls.Calendar, System.Windows.Controls.CalendarSelectionMode>(System.Windows.Controls.Calendar.SelectionModeProperty);
    }

    public partial class calendarButton : button
    {
    }

    public partial class calendarDayButton : button
    {
    }

    public partial class calendarItem : control
    {
    }

    public partial class canvas : panel
    {
      public static readonly IProperty<System.Windows.UIElement, System.Double> left = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.Canvas.LeftProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> top = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.Canvas.TopProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> right = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.Canvas.RightProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> bottom = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.Canvas.BottomProperty);
    }

    public partial class checkBox : toggleButton
    {
    }

    public partial class comboBox : selector
    {
      public static readonly IProperty<System.Windows.Controls.ComboBox, System.Double> maxDropDownHeight = new Property<System.Windows.Controls.ComboBox, System.Double>(System.Windows.Controls.ComboBox.MaxDropDownHeightProperty);
      public static readonly IProperty<System.Windows.Controls.ComboBox, System.Boolean> isDropDownOpen = new Property<System.Windows.Controls.ComboBox, System.Boolean>(System.Windows.Controls.ComboBox.IsDropDownOpenProperty);
      public static readonly IProperty<System.Windows.Controls.ComboBox, System.Boolean> shouldPreserveUserEnteredPrefix = new Property<System.Windows.Controls.ComboBox, System.Boolean>(System.Windows.Controls.ComboBox.ShouldPreserveUserEnteredPrefixProperty);
      public static readonly IProperty<System.Windows.Controls.ComboBox, System.Boolean> isEditable = new Property<System.Windows.Controls.ComboBox, System.Boolean>(System.Windows.Controls.ComboBox.IsEditableProperty);
      public static readonly IProperty<System.Windows.Controls.ComboBox, System.String> text = new Property<System.Windows.Controls.ComboBox, System.String>(System.Windows.Controls.ComboBox.TextProperty);
      public static readonly IProperty<System.Windows.Controls.ComboBox, System.Boolean> isReadOnly = new Property<System.Windows.Controls.ComboBox, System.Boolean>(System.Windows.Controls.ComboBox.IsReadOnlyProperty);
      public static readonly IProperty<System.Windows.Controls.ComboBox, System.Boolean> staysOpenOnEdit = new Property<System.Windows.Controls.ComboBox, System.Boolean>(System.Windows.Controls.ComboBox.StaysOpenOnEditProperty);
    }

    public partial class comboBoxItem : listBoxItem
    {
    }

    public partial class contentControl : control
    {
      public static readonly IProperty<System.Windows.Controls.ContentControl, System.Object> content = new Property<System.Windows.Controls.ContentControl, System.Object>(System.Windows.Controls.ContentControl.ContentProperty);
      public static readonly IProperty<System.Windows.Controls.ContentControl, System.Windows.DataTemplate> contentTemplate = new Property<System.Windows.Controls.ContentControl, System.Windows.DataTemplate>(System.Windows.Controls.ContentControl.ContentTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.ContentControl, System.Windows.Controls.DataTemplateSelector> contentTemplateSelector = new Property<System.Windows.Controls.ContentControl, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.ContentControl, System.String> contentStringFormat = new Property<System.Windows.Controls.ContentControl, System.String>(System.Windows.Controls.ContentControl.ContentStringFormatProperty);
    }

    public partial class contentPresenter : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.ContentPresenter, System.Boolean> recognizesAccessKey = new Property<System.Windows.Controls.ContentPresenter, System.Boolean>(System.Windows.Controls.ContentPresenter.RecognizesAccessKeyProperty);
      public static readonly IProperty<System.Windows.Controls.ContentPresenter, System.Object> content = new Property<System.Windows.Controls.ContentPresenter, System.Object>(System.Windows.Controls.ContentPresenter.ContentProperty);
      public static readonly IProperty<System.Windows.Controls.ContentPresenter, System.Windows.DataTemplate> contentTemplate = new Property<System.Windows.Controls.ContentPresenter, System.Windows.DataTemplate>(System.Windows.Controls.ContentPresenter.ContentTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.ContentPresenter, System.Windows.Controls.DataTemplateSelector> contentTemplateSelector = new Property<System.Windows.Controls.ContentPresenter, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.ContentPresenter, System.String> contentStringFormat = new Property<System.Windows.Controls.ContentPresenter, System.String>(System.Windows.Controls.ContentPresenter.ContentStringFormatProperty);
      public static readonly IProperty<System.Windows.Controls.ContentPresenter, System.String> contentSource = new Property<System.Windows.Controls.ContentPresenter, System.String>(System.Windows.Controls.ContentPresenter.ContentSourceProperty);
    }

    public partial class contextMenu : menuBase
    {
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Double> horizontalOffset = new Property<System.Windows.Controls.ContextMenu, System.Double>(System.Windows.Controls.ContextMenu.HorizontalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Double> verticalOffset = new Property<System.Windows.Controls.ContextMenu, System.Double>(System.Windows.Controls.ContextMenu.VerticalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Boolean> isOpen = new Property<System.Windows.Controls.ContextMenu, System.Boolean>(System.Windows.Controls.ContextMenu.IsOpenProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Windows.UIElement> placementTarget = new Property<System.Windows.Controls.ContextMenu, System.Windows.UIElement>(System.Windows.Controls.ContextMenu.PlacementTargetProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Windows.Rect> placementRectangle = new Property<System.Windows.Controls.ContextMenu, System.Windows.Rect>(System.Windows.Controls.ContextMenu.PlacementRectangleProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.PlacementMode> placement = new Property<System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.PlacementMode>(System.Windows.Controls.ContextMenu.PlacementProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Boolean> hasDropShadow = new Property<System.Windows.Controls.ContextMenu, System.Boolean>(System.Windows.Controls.ContextMenu.HasDropShadowProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.CustomPopupPlacementCallback> customPopupPlacementCallback = new Property<System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.CustomPopupPlacementCallback>(System.Windows.Controls.ContextMenu.CustomPopupPlacementCallbackProperty);
      public static readonly IProperty<System.Windows.Controls.ContextMenu, System.Boolean> staysOpen = new Property<System.Windows.Controls.ContextMenu, System.Boolean>(System.Windows.Controls.ContextMenu.StaysOpenProperty);
    }

    public partial class control : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.Media.Brush> borderBrush = new Property<System.Windows.Controls.Control, System.Windows.Media.Brush>(System.Windows.Controls.Control.BorderBrushProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.Thickness> borderThickness = new Property<System.Windows.Controls.Control, System.Windows.Thickness>(System.Windows.Controls.Control.BorderThicknessProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.Control, System.Windows.Media.Brush>(System.Windows.Controls.Control.BackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.Media.Brush> foreground = new Property<System.Windows.Controls.Control, System.Windows.Media.Brush>(System.Windows.Controls.Control.ForegroundProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.Media.FontFamily> fontFamily = new Property<System.Windows.Controls.Control, System.Windows.Media.FontFamily>(System.Windows.Controls.Control.FontFamilyProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Double> fontSize = new Property<System.Windows.Controls.Control, System.Double>(System.Windows.Controls.Control.FontSizeProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.FontStretch> fontStretch = new Property<System.Windows.Controls.Control, System.Windows.FontStretch>(System.Windows.Controls.Control.FontStretchProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.FontStyle> fontStyle = new Property<System.Windows.Controls.Control, System.Windows.FontStyle>(System.Windows.Controls.Control.FontStyleProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.FontWeight> fontWeight = new Property<System.Windows.Controls.Control, System.Windows.FontWeight>(System.Windows.Controls.Control.FontWeightProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.HorizontalAlignment> horizontalContentAlignment = new Property<System.Windows.Controls.Control, System.Windows.HorizontalAlignment>(System.Windows.Controls.Control.HorizontalContentAlignmentProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.VerticalAlignment> verticalContentAlignment = new Property<System.Windows.Controls.Control, System.Windows.VerticalAlignment>(System.Windows.Controls.Control.VerticalContentAlignmentProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Int32> tabIndex = new Property<System.Windows.Controls.Control, System.Int32>(System.Windows.Controls.Control.TabIndexProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Boolean> isTabStop = new Property<System.Windows.Controls.Control, System.Boolean>(System.Windows.Controls.Control.IsTabStopProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.Thickness> padding = new Property<System.Windows.Controls.Control, System.Windows.Thickness>(System.Windows.Controls.Control.PaddingProperty);
      public static readonly IProperty<System.Windows.Controls.Control, System.Windows.Controls.ControlTemplate> template = new Property<System.Windows.Controls.Control, System.Windows.Controls.ControlTemplate>(System.Windows.Controls.Control.TemplateProperty);
    }

    public partial class dataGrid : multiSelector
    {
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> canUserResizeColumns = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.CanUserResizeColumnsProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridLength> columnWidth = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridLength>(System.Windows.Controls.DataGrid.ColumnWidthProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Double> minColumnWidth = new Property<System.Windows.Controls.DataGrid, System.Double>(System.Windows.Controls.DataGrid.MinColumnWidthProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Double> maxColumnWidth = new Property<System.Windows.Controls.DataGrid, System.Double>(System.Windows.Controls.DataGrid.MaxColumnWidthProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridGridLinesVisibility> gridLinesVisibility = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridGridLinesVisibility>(System.Windows.Controls.DataGrid.GridLinesVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Media.Brush> horizontalGridLinesBrush = new Property<System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(System.Windows.Controls.DataGrid.HorizontalGridLinesBrushProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Media.Brush> verticalGridLinesBrush = new Property<System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(System.Windows.Controls.DataGrid.VerticalGridLinesBrushProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Style> rowStyle = new Property<System.Windows.Controls.DataGrid, System.Windows.Style>(System.Windows.Controls.DataGrid.RowStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.ControlTemplate> rowValidationErrorTemplate = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.ControlTemplate>(System.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.StyleSelector> rowStyleSelector = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.StyleSelector>(System.Windows.Controls.DataGrid.RowStyleSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Media.Brush> rowBackground = new Property<System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(System.Windows.Controls.DataGrid.RowBackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Media.Brush> alternatingRowBackground = new Property<System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(System.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Double> rowHeight = new Property<System.Windows.Controls.DataGrid, System.Double>(System.Windows.Controls.DataGrid.RowHeightProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Double> minRowHeight = new Property<System.Windows.Controls.DataGrid, System.Double>(System.Windows.Controls.DataGrid.MinRowHeightProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Double> rowHeaderWidth = new Property<System.Windows.Controls.DataGrid, System.Double>(System.Windows.Controls.DataGrid.RowHeaderWidthProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Double> columnHeaderHeight = new Property<System.Windows.Controls.DataGrid, System.Double>(System.Windows.Controls.DataGrid.ColumnHeaderHeightProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridHeadersVisibility> headersVisibility = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridHeadersVisibility>(System.Windows.Controls.DataGrid.HeadersVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Style> cellStyle = new Property<System.Windows.Controls.DataGrid, System.Windows.Style>(System.Windows.Controls.DataGrid.CellStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Style> columnHeaderStyle = new Property<System.Windows.Controls.DataGrid, System.Windows.Style>(System.Windows.Controls.DataGrid.ColumnHeaderStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Style> rowHeaderStyle = new Property<System.Windows.Controls.DataGrid, System.Windows.Style>(System.Windows.Controls.DataGrid.RowHeaderStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.DataTemplate> rowHeaderTemplate = new Property<System.Windows.Controls.DataGrid, System.Windows.DataTemplate>(System.Windows.Controls.DataGrid.RowHeaderTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector> rowHeaderTemplateSelector = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.DataGrid.HorizontalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.DataGrid.VerticalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> isReadOnly = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.IsReadOnlyProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Object> currentItem = new Property<System.Windows.Controls.DataGrid, System.Object>(System.Windows.Controls.DataGrid.CurrentItemProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridColumn> currentColumn = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridColumn>(System.Windows.Controls.DataGrid.CurrentColumnProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridCellInfo> currentCell = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridCellInfo>(System.Windows.Controls.DataGrid.CurrentCellProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> canUserAddRows = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.CanUserAddRowsProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> canUserDeleteRows = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.CanUserDeleteRowsProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridRowDetailsVisibilityMode> rowDetailsVisibilityMode = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridRowDetailsVisibilityMode>(System.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> areRowDetailsFrozen = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.AreRowDetailsFrozenProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.DataTemplate> rowDetailsTemplate = new Property<System.Windows.Controls.DataGrid, System.Windows.DataTemplate>(System.Windows.Controls.DataGrid.RowDetailsTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector> rowDetailsTemplateSelector = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> canUserResizeRows = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.CanUserResizeRowsProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionMode> selectionMode = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionMode>(System.Windows.Controls.DataGrid.SelectionModeProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionUnit> selectionUnit = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionUnit>(System.Windows.Controls.DataGrid.SelectionUnitProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> canUserSortColumns = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.CanUserSortColumnsProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> autoGenerateColumns = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.AutoGenerateColumnsProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Int32> frozenColumnCount = new Property<System.Windows.Controls.DataGrid, System.Int32>(System.Windows.Controls.DataGrid.FrozenColumnCountProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> enableRowVirtualization = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.EnableRowVirtualizationProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> enableColumnVirtualization = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Boolean> canUserReorderColumns = new Property<System.Windows.Controls.DataGrid, System.Boolean>(System.Windows.Controls.DataGrid.CanUserReorderColumnsProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Style> dragIndicatorStyle = new Property<System.Windows.Controls.DataGrid, System.Windows.Style>(System.Windows.Controls.DataGrid.DragIndicatorStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Style> dropLocationIndicatorStyle = new Property<System.Windows.Controls.DataGrid, System.Windows.Style>(System.Windows.Controls.DataGrid.DropLocationIndicatorStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridClipboardCopyMode> clipboardCopyMode = new Property<System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridClipboardCopyMode>(System.Windows.Controls.DataGrid.ClipboardCopyModeProperty);
    }

    public partial class dataGridCell : contentControl
    {
      public static readonly IProperty<System.Windows.Controls.DataGridCell, System.Boolean> isEditing = new Property<System.Windows.Controls.DataGridCell, System.Boolean>(System.Windows.Controls.DataGridCell.IsEditingProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridCell, System.Boolean> isSelected = new Property<System.Windows.Controls.DataGridCell, System.Boolean>(System.Windows.Controls.DataGridCell.IsSelectedProperty);
    }

    public partial class dataGridCellsPanel : virtualizingPanel
    {
    }

    public partial class dataGridCellsPresenter : itemsControl
    {
    }

    public partial class dataGridColumnHeader : buttonBase
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Media.Brush> separatorBrush = new Property<System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Media.Brush>(System.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorBrushProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Visibility> separatorVisibility = new Property<System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Visibility>(System.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorVisibilityProperty);
    }

    public partial class dataGridColumnHeadersPresenter : itemsControl
    {
    }

    public partial class dataGridDetailsPresenter : contentPresenter
    {
    }

    public partial class dataGridRow : control
    {
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Object> item = new Property<System.Windows.Controls.DataGridRow, System.Object>(System.Windows.Controls.DataGridRow.ItemProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.Controls.ItemsPanelTemplate> itemsPanel = new Property<System.Windows.Controls.DataGridRow, System.Windows.Controls.ItemsPanelTemplate>(System.Windows.Controls.DataGridRow.ItemsPanelProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Object> header = new Property<System.Windows.Controls.DataGridRow, System.Object>(System.Windows.Controls.DataGridRow.HeaderProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.Style> headerStyle = new Property<System.Windows.Controls.DataGridRow, System.Windows.Style>(System.Windows.Controls.DataGridRow.HeaderStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.DataTemplate> headerTemplate = new Property<System.Windows.Controls.DataGridRow, System.Windows.DataTemplate>(System.Windows.Controls.DataGridRow.HeaderTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector> headerTemplateSelector = new Property<System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.Controls.ControlTemplate> validationErrorTemplate = new Property<System.Windows.Controls.DataGridRow, System.Windows.Controls.ControlTemplate>(System.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.DataTemplate> detailsTemplate = new Property<System.Windows.Controls.DataGridRow, System.Windows.DataTemplate>(System.Windows.Controls.DataGridRow.DetailsTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector> detailsTemplateSelector = new Property<System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Windows.Visibility> detailsVisibility = new Property<System.Windows.Controls.DataGridRow, System.Windows.Visibility>(System.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.DataGridRow, System.Boolean> isSelected = new Property<System.Windows.Controls.DataGridRow, System.Boolean>(System.Windows.Controls.DataGridRow.IsSelectedProperty);
    }

    public partial class dataGridRowHeader : buttonBase
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Media.Brush> separatorBrush = new Property<System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Media.Brush>(System.Windows.Controls.Primitives.DataGridRowHeader.SeparatorBrushProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Visibility> separatorVisibility = new Property<System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Visibility>(System.Windows.Controls.Primitives.DataGridRowHeader.SeparatorVisibilityProperty);
    }

    public partial class dataGridRowsPresenter : virtualizingStackPanel
    {
    }

    public partial class datePicker : control
    {
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.Windows.Style> calendarStyle = new Property<System.Windows.Controls.DatePicker, System.Windows.Style>(System.Windows.Controls.DatePicker.CalendarStyleProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.DateTime> displayDate = new Property<System.Windows.Controls.DatePicker, System.DateTime>(System.Windows.Controls.DatePicker.DisplayDateProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>> displayDateEnd = new Property<System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>>(System.Windows.Controls.DatePicker.DisplayDateEndProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>> displayDateStart = new Property<System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>>(System.Windows.Controls.DatePicker.DisplayDateStartProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.DayOfWeek> firstDayOfWeek = new Property<System.Windows.Controls.DatePicker, System.DayOfWeek>(System.Windows.Controls.DatePicker.FirstDayOfWeekProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.Boolean> isDropDownOpen = new Property<System.Windows.Controls.DatePicker, System.Boolean>(System.Windows.Controls.DatePicker.IsDropDownOpenProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.Boolean> isTodayHighlighted = new Property<System.Windows.Controls.DatePicker, System.Boolean>(System.Windows.Controls.DatePicker.IsTodayHighlightedProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>> selectedDate = new Property<System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>>(System.Windows.Controls.DatePicker.SelectedDateProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.Windows.Controls.DatePickerFormat> selectedDateFormat = new Property<System.Windows.Controls.DatePicker, System.Windows.Controls.DatePickerFormat>(System.Windows.Controls.DatePicker.SelectedDateFormatProperty);
      public static readonly IProperty<System.Windows.Controls.DatePicker, System.String> text = new Property<System.Windows.Controls.DatePicker, System.String>(System.Windows.Controls.DatePicker.TextProperty);
    }

    public partial class datePickerTextBox : textBox
    {
    }

    public partial class decorator : frameworkElement
    {
    }

    public partial class dockPanel : panel
    {
      public static readonly IProperty<System.Windows.Controls.DockPanel, System.Boolean> lastChildFill = new Property<System.Windows.Controls.DockPanel, System.Boolean>(System.Windows.Controls.DockPanel.LastChildFillProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.Dock> dock = new Property<System.Windows.UIElement, System.Windows.Controls.Dock>(System.Windows.Controls.DockPanel.DockProperty);
    }

    public partial class documentPageView : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.DocumentPageView, System.Int32> pageNumber = new Property<System.Windows.Controls.Primitives.DocumentPageView, System.Int32>(System.Windows.Controls.Primitives.DocumentPageView.PageNumberProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Media.Stretch> stretch = new Property<System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Media.Stretch>(System.Windows.Controls.Primitives.DocumentPageView.StretchProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Controls.StretchDirection> stretchDirection = new Property<System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Controls.StretchDirection>(System.Windows.Controls.Primitives.DocumentPageView.StretchDirectionProperty);
    }

    public partial class documentReference : frameworkElement
    {
      public static readonly IProperty<System.Windows.Documents.DocumentReference, System.Uri> source = new Property<System.Windows.Documents.DocumentReference, System.Uri>(System.Windows.Documents.DocumentReference.SourceProperty);
    }

    public partial class documentViewer : documentViewerBase
    {
      public static readonly IProperty<System.Windows.Controls.DocumentViewer, System.Double> horizontalOffset = new Property<System.Windows.Controls.DocumentViewer, System.Double>(System.Windows.Controls.DocumentViewer.HorizontalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.DocumentViewer, System.Double> verticalOffset = new Property<System.Windows.Controls.DocumentViewer, System.Double>(System.Windows.Controls.DocumentViewer.VerticalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.DocumentViewer, System.Boolean> showPageBorders = new Property<System.Windows.Controls.DocumentViewer, System.Boolean>(System.Windows.Controls.DocumentViewer.ShowPageBordersProperty);
      public static readonly IProperty<System.Windows.Controls.DocumentViewer, System.Double> zoom = new Property<System.Windows.Controls.DocumentViewer, System.Double>(System.Windows.Controls.DocumentViewer.ZoomProperty);
      public static readonly IProperty<System.Windows.Controls.DocumentViewer, System.Int32> maxPagesAcross = new Property<System.Windows.Controls.DocumentViewer, System.Int32>(System.Windows.Controls.DocumentViewer.MaxPagesAcrossProperty);
      public static readonly IProperty<System.Windows.Controls.DocumentViewer, System.Double> verticalPageSpacing = new Property<System.Windows.Controls.DocumentViewer, System.Double>(System.Windows.Controls.DocumentViewer.VerticalPageSpacingProperty);
      public static readonly IProperty<System.Windows.Controls.DocumentViewer, System.Double> horizontalPageSpacing = new Property<System.Windows.Controls.DocumentViewer, System.Double>(System.Windows.Controls.DocumentViewer.HorizontalPageSpacingProperty);
    }

    public partial class documentViewerBase : control
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.DocumentViewerBase, System.Windows.Documents.IDocumentPaginatorSource> document = new Property<System.Windows.Controls.Primitives.DocumentViewerBase, System.Windows.Documents.IDocumentPaginatorSource>(System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isMasterPage = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.Primitives.DocumentViewerBase.IsMasterPageProperty);
    }

    public partial class ellipse : shape
    {
    }

    public partial class expander : headeredContentControl
    {
      public static readonly IProperty<System.Windows.Controls.Expander, System.Windows.Controls.ExpandDirection> expandDirection = new Property<System.Windows.Controls.Expander, System.Windows.Controls.ExpandDirection>(System.Windows.Controls.Expander.ExpandDirectionProperty);
      public static readonly IProperty<System.Windows.Controls.Expander, System.Boolean> isExpanded = new Property<System.Windows.Controls.Expander, System.Boolean>(System.Windows.Controls.Expander.IsExpandedProperty);
    }

    public partial class fixedPage : frameworkElement
    {
      public static readonly IProperty<System.Windows.Documents.FixedPage, System.Object> printTicket = new Property<System.Windows.Documents.FixedPage, System.Object>(System.Windows.Documents.FixedPage.PrintTicketProperty);
      public static readonly IProperty<System.Windows.Documents.FixedPage, System.Windows.Media.Brush> background = new Property<System.Windows.Documents.FixedPage, System.Windows.Media.Brush>(System.Windows.Documents.FixedPage.BackgroundProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> left = new Property<System.Windows.UIElement, System.Double>(System.Windows.Documents.FixedPage.LeftProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> top = new Property<System.Windows.UIElement, System.Double>(System.Windows.Documents.FixedPage.TopProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> right = new Property<System.Windows.UIElement, System.Double>(System.Windows.Documents.FixedPage.RightProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> bottom = new Property<System.Windows.UIElement, System.Double>(System.Windows.Documents.FixedPage.BottomProperty);
      public static readonly IProperty<System.Windows.Documents.FixedPage, System.Windows.Rect> contentBox = new Property<System.Windows.Documents.FixedPage, System.Windows.Rect>(System.Windows.Documents.FixedPage.ContentBoxProperty);
      public static readonly IProperty<System.Windows.Documents.FixedPage, System.Windows.Rect> bleedBox = new Property<System.Windows.Documents.FixedPage, System.Windows.Rect>(System.Windows.Documents.FixedPage.BleedBoxProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Uri> navigateUri = new Property<System.Windows.UIElement, System.Uri>(System.Windows.Documents.FixedPage.NavigateUriProperty);
    }

    public partial class flowDocumentPageViewer : documentViewerBase
    {
      public static readonly IProperty<System.Windows.Controls.FlowDocumentPageViewer, System.Double> zoom = new Property<System.Windows.Controls.FlowDocumentPageViewer, System.Double>(System.Windows.Controls.FlowDocumentPageViewer.ZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentPageViewer, System.Double> maxZoom = new Property<System.Windows.Controls.FlowDocumentPageViewer, System.Double>(System.Windows.Controls.FlowDocumentPageViewer.MaxZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentPageViewer, System.Double> minZoom = new Property<System.Windows.Controls.FlowDocumentPageViewer, System.Double>(System.Windows.Controls.FlowDocumentPageViewer.MinZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentPageViewer, System.Double> zoomIncrement = new Property<System.Windows.Controls.FlowDocumentPageViewer, System.Double>(System.Windows.Controls.FlowDocumentPageViewer.ZoomIncrementProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentPageViewer, System.Windows.Media.Brush> selectionBrush = new Property<System.Windows.Controls.FlowDocumentPageViewer, System.Windows.Media.Brush>(System.Windows.Controls.FlowDocumentPageViewer.SelectionBrushProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentPageViewer, System.Double> selectionOpacity = new Property<System.Windows.Controls.FlowDocumentPageViewer, System.Double>(System.Windows.Controls.FlowDocumentPageViewer.SelectionOpacityProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentPageViewer, System.Boolean> isInactiveSelectionHighlightEnabled = new Property<System.Windows.Controls.FlowDocumentPageViewer, System.Boolean>(System.Windows.Controls.FlowDocumentPageViewer.IsInactiveSelectionHighlightEnabledProperty);
    }

    public partial class flowDocumentReader : control
    {
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Windows.Controls.FlowDocumentReaderViewingMode> viewingMode = new Property<System.Windows.Controls.FlowDocumentReader, System.Windows.Controls.FlowDocumentReaderViewingMode>(System.Windows.Controls.FlowDocumentReader.ViewingModeProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Boolean> isPageViewEnabled = new Property<System.Windows.Controls.FlowDocumentReader, System.Boolean>(System.Windows.Controls.FlowDocumentReader.IsPageViewEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Boolean> isTwoPageViewEnabled = new Property<System.Windows.Controls.FlowDocumentReader, System.Boolean>(System.Windows.Controls.FlowDocumentReader.IsTwoPageViewEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Boolean> isScrollViewEnabled = new Property<System.Windows.Controls.FlowDocumentReader, System.Boolean>(System.Windows.Controls.FlowDocumentReader.IsScrollViewEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Boolean> isFindEnabled = new Property<System.Windows.Controls.FlowDocumentReader, System.Boolean>(System.Windows.Controls.FlowDocumentReader.IsFindEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Boolean> isPrintEnabled = new Property<System.Windows.Controls.FlowDocumentReader, System.Boolean>(System.Windows.Controls.FlowDocumentReader.IsPrintEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Windows.Documents.FlowDocument> document = new Property<System.Windows.Controls.FlowDocumentReader, System.Windows.Documents.FlowDocument>(System.Windows.Controls.FlowDocumentReader.DocumentProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Double> zoom = new Property<System.Windows.Controls.FlowDocumentReader, System.Double>(System.Windows.Controls.FlowDocumentReader.ZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Double> maxZoom = new Property<System.Windows.Controls.FlowDocumentReader, System.Double>(System.Windows.Controls.FlowDocumentReader.MaxZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Double> minZoom = new Property<System.Windows.Controls.FlowDocumentReader, System.Double>(System.Windows.Controls.FlowDocumentReader.MinZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Double> zoomIncrement = new Property<System.Windows.Controls.FlowDocumentReader, System.Double>(System.Windows.Controls.FlowDocumentReader.ZoomIncrementProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Windows.Media.Brush> selectionBrush = new Property<System.Windows.Controls.FlowDocumentReader, System.Windows.Media.Brush>(System.Windows.Controls.FlowDocumentReader.SelectionBrushProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Double> selectionOpacity = new Property<System.Windows.Controls.FlowDocumentReader, System.Double>(System.Windows.Controls.FlowDocumentReader.SelectionOpacityProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentReader, System.Boolean> isInactiveSelectionHighlightEnabled = new Property<System.Windows.Controls.FlowDocumentReader, System.Boolean>(System.Windows.Controls.FlowDocumentReader.IsInactiveSelectionHighlightEnabledProperty);
    }

    public partial class flowDocumentScrollViewer : control
    {
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Documents.FlowDocument> document = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Documents.FlowDocument>(System.Windows.Controls.FlowDocumentScrollViewer.DocumentProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Double> zoom = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(System.Windows.Controls.FlowDocumentScrollViewer.ZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Double> maxZoom = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(System.Windows.Controls.FlowDocumentScrollViewer.MaxZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Double> minZoom = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(System.Windows.Controls.FlowDocumentScrollViewer.MinZoomProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Double> zoomIncrement = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(System.Windows.Controls.FlowDocumentScrollViewer.ZoomIncrementProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean> isSelectionEnabled = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean>(System.Windows.Controls.FlowDocumentScrollViewer.IsSelectionEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean> isToolBarVisible = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean>(System.Windows.Controls.FlowDocumentScrollViewer.IsToolBarVisibleProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.FlowDocumentScrollViewer.HorizontalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.FlowDocumentScrollViewer.VerticalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Media.Brush> selectionBrush = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Media.Brush>(System.Windows.Controls.FlowDocumentScrollViewer.SelectionBrushProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Double> selectionOpacity = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(System.Windows.Controls.FlowDocumentScrollViewer.SelectionOpacityProperty);
      public static readonly IProperty<System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean> isInactiveSelectionHighlightEnabled = new Property<System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean>(System.Windows.Controls.FlowDocumentScrollViewer.IsInactiveSelectionHighlightEnabledProperty);
    }

    public partial class frame : contentControl
    {
      public static readonly IProperty<System.Windows.Controls.Frame, System.Uri> source = new Property<System.Windows.Controls.Frame, System.Uri>(System.Windows.Controls.Frame.SourceProperty);
      public static readonly IProperty<System.Windows.Controls.Frame, System.Windows.Navigation.NavigationUIVisibility> navigationUIVisibility = new Property<System.Windows.Controls.Frame, System.Windows.Navigation.NavigationUIVisibility>(System.Windows.Controls.Frame.NavigationUIVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.Frame, System.Boolean> sandboxExternalContent = new Property<System.Windows.Controls.Frame, System.Boolean>(System.Windows.Controls.Frame.SandboxExternalContentProperty);
      public static readonly IProperty<System.Windows.Controls.Frame, System.Windows.Navigation.JournalOwnership> journalOwnership = new Property<System.Windows.Controls.Frame, System.Windows.Navigation.JournalOwnership>(System.Windows.Controls.Frame.JournalOwnershipProperty);
    }

    public partial class frameworkElement : uIElement
    {
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Style> style = new Property<System.Windows.FrameworkElement, System.Windows.Style>(System.Windows.FrameworkElement.StyleProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Boolean> overridesDefaultStyle = new Property<System.Windows.FrameworkElement, System.Boolean>(System.Windows.FrameworkElement.OverridesDefaultStyleProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Boolean> useLayoutRounding = new Property<System.Windows.FrameworkElement, System.Boolean>(System.Windows.FrameworkElement.UseLayoutRoundingProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Object> dataContext = new Property<System.Windows.FrameworkElement, System.Object>(System.Windows.FrameworkElement.DataContextProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Data.BindingGroup> bindingGroup = new Property<System.Windows.FrameworkElement, System.Windows.Data.BindingGroup>(System.Windows.FrameworkElement.BindingGroupProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Markup.XmlLanguage> language = new Property<System.Windows.FrameworkElement, System.Windows.Markup.XmlLanguage>(System.Windows.FrameworkElement.LanguageProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.String> name = new Property<System.Windows.FrameworkElement, System.String>(System.Windows.FrameworkElement.NameProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Object> tag = new Property<System.Windows.FrameworkElement, System.Object>(System.Windows.FrameworkElement.TagProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Input.InputScope> inputScope = new Property<System.Windows.FrameworkElement, System.Windows.Input.InputScope>(System.Windows.FrameworkElement.InputScopeProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Media.Transform> layoutTransform = new Property<System.Windows.FrameworkElement, System.Windows.Media.Transform>(System.Windows.FrameworkElement.LayoutTransformProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Double> width = new Property<System.Windows.FrameworkElement, System.Double>(System.Windows.FrameworkElement.WidthProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Double> minWidth = new Property<System.Windows.FrameworkElement, System.Double>(System.Windows.FrameworkElement.MinWidthProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Double> maxWidth = new Property<System.Windows.FrameworkElement, System.Double>(System.Windows.FrameworkElement.MaxWidthProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Double> height = new Property<System.Windows.FrameworkElement, System.Double>(System.Windows.FrameworkElement.HeightProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Double> minHeight = new Property<System.Windows.FrameworkElement, System.Double>(System.Windows.FrameworkElement.MinHeightProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Double> maxHeight = new Property<System.Windows.FrameworkElement, System.Double>(System.Windows.FrameworkElement.MaxHeightProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.FlowDirection> flowDirection = new Property<System.Windows.UIElement, System.Windows.FlowDirection>(System.Windows.FrameworkElement.FlowDirectionProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Thickness> margin = new Property<System.Windows.FrameworkElement, System.Windows.Thickness>(System.Windows.FrameworkElement.MarginProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.HorizontalAlignment> horizontalAlignment = new Property<System.Windows.FrameworkElement, System.Windows.HorizontalAlignment>(System.Windows.FrameworkElement.HorizontalAlignmentProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.VerticalAlignment> verticalAlignment = new Property<System.Windows.FrameworkElement, System.Windows.VerticalAlignment>(System.Windows.FrameworkElement.VerticalAlignmentProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Style> focusVisualStyle = new Property<System.Windows.FrameworkElement, System.Windows.Style>(System.Windows.FrameworkElement.FocusVisualStyleProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Input.Cursor> cursor = new Property<System.Windows.FrameworkElement, System.Windows.Input.Cursor>(System.Windows.FrameworkElement.CursorProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Boolean> forceCursor = new Property<System.Windows.FrameworkElement, System.Boolean>(System.Windows.FrameworkElement.ForceCursorProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Object> toolTip = new Property<System.Windows.FrameworkElement, System.Object>(System.Windows.FrameworkElement.ToolTipProperty);
      public static readonly IProperty<System.Windows.FrameworkElement, System.Windows.Controls.ContextMenu> contextMenu = new Property<System.Windows.FrameworkElement, System.Windows.Controls.ContextMenu>(System.Windows.FrameworkElement.ContextMenuProperty);
    }

    public partial class glyphs : frameworkElement
    {
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Windows.Media.Brush> fill = new Property<System.Windows.Documents.Glyphs, System.Windows.Media.Brush>(System.Windows.Documents.Glyphs.FillProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.String> indices = new Property<System.Windows.Documents.Glyphs, System.String>(System.Windows.Documents.Glyphs.IndicesProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.String> unicodeString = new Property<System.Windows.Documents.Glyphs, System.String>(System.Windows.Documents.Glyphs.UnicodeStringProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.String> caretStops = new Property<System.Windows.Documents.Glyphs, System.String>(System.Windows.Documents.Glyphs.CaretStopsProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Double> fontRenderingEmSize = new Property<System.Windows.Documents.Glyphs, System.Double>(System.Windows.Documents.Glyphs.FontRenderingEmSizeProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Double> originX = new Property<System.Windows.Documents.Glyphs, System.Double>(System.Windows.Documents.Glyphs.OriginXProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Double> originY = new Property<System.Windows.Documents.Glyphs, System.Double>(System.Windows.Documents.Glyphs.OriginYProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Uri> fontUri = new Property<System.Windows.Documents.Glyphs, System.Uri>(System.Windows.Documents.Glyphs.FontUriProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Windows.Media.StyleSimulations> styleSimulations = new Property<System.Windows.Documents.Glyphs, System.Windows.Media.StyleSimulations>(System.Windows.Documents.Glyphs.StyleSimulationsProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Boolean> isSideways = new Property<System.Windows.Documents.Glyphs, System.Boolean>(System.Windows.Documents.Glyphs.IsSidewaysProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.Int32> bidiLevel = new Property<System.Windows.Documents.Glyphs, System.Int32>(System.Windows.Documents.Glyphs.BidiLevelProperty);
      public static readonly IProperty<System.Windows.Documents.Glyphs, System.String> deviceFontName = new Property<System.Windows.Documents.Glyphs, System.String>(System.Windows.Documents.Glyphs.DeviceFontNameProperty);
    }

    public partial class grid : panel
    {
      public static readonly IProperty<System.Windows.Controls.Grid, System.Boolean> showGridLines = new Property<System.Windows.Controls.Grid, System.Boolean>(System.Windows.Controls.Grid.ShowGridLinesProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Int32> column = new Property<System.Windows.UIElement, System.Int32>(System.Windows.Controls.Grid.ColumnProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Int32> row = new Property<System.Windows.UIElement, System.Int32>(System.Windows.Controls.Grid.RowProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Int32> columnSpan = new Property<System.Windows.UIElement, System.Int32>(System.Windows.Controls.Grid.ColumnSpanProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Int32> rowSpan = new Property<System.Windows.UIElement, System.Int32>(System.Windows.Controls.Grid.RowSpanProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isSharedSizeScope = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.Grid.IsSharedSizeScopeProperty);
    }

    public partial class gridSplitter : thumb
    {
      public static readonly IProperty<System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeDirection> resizeDirection = new Property<System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeDirection>(System.Windows.Controls.GridSplitter.ResizeDirectionProperty);
      public static readonly IProperty<System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeBehavior> resizeBehavior = new Property<System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeBehavior>(System.Windows.Controls.GridSplitter.ResizeBehaviorProperty);
      public static readonly IProperty<System.Windows.Controls.GridSplitter, System.Boolean> showsPreview = new Property<System.Windows.Controls.GridSplitter, System.Boolean>(System.Windows.Controls.GridSplitter.ShowsPreviewProperty);
      public static readonly IProperty<System.Windows.Controls.GridSplitter, System.Windows.Style> previewStyle = new Property<System.Windows.Controls.GridSplitter, System.Windows.Style>(System.Windows.Controls.GridSplitter.PreviewStyleProperty);
      public static readonly IProperty<System.Windows.Controls.GridSplitter, System.Double> keyboardIncrement = new Property<System.Windows.Controls.GridSplitter, System.Double>(System.Windows.Controls.GridSplitter.KeyboardIncrementProperty);
      public static readonly IProperty<System.Windows.Controls.GridSplitter, System.Double> dragIncrement = new Property<System.Windows.Controls.GridSplitter, System.Double>(System.Windows.Controls.GridSplitter.DragIncrementProperty);
    }

    public partial class gridViewColumnHeader : buttonBase
    {
    }

    public partial class gridViewHeaderRowPresenter : gridViewRowPresenterBase
    {
      public static readonly IProperty<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Style> columnHeaderContainerStyle = new Property<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Style>(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContainerStyleProperty);
      public static readonly IProperty<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.DataTemplate> columnHeaderTemplate = new Property<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.DataTemplate>(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.DataTemplateSelector> columnHeaderTemplateSelector = new Property<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.GridViewHeaderRowPresenter, System.String> columnHeaderStringFormat = new Property<System.Windows.Controls.GridViewHeaderRowPresenter, System.String>(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderStringFormatProperty);
      public static readonly IProperty<System.Windows.Controls.GridViewHeaderRowPresenter, System.Boolean> allowsColumnReorder = new Property<System.Windows.Controls.GridViewHeaderRowPresenter, System.Boolean>(System.Windows.Controls.GridViewHeaderRowPresenter.AllowsColumnReorderProperty);
      public static readonly IProperty<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.ContextMenu> columnHeaderContextMenu = new Property<System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.ContextMenu>(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContextMenuProperty);
      public static readonly IProperty<System.Windows.Controls.GridViewHeaderRowPresenter, System.Object> columnHeaderToolTip = new Property<System.Windows.Controls.GridViewHeaderRowPresenter, System.Object>(System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderToolTipProperty);
    }

    public partial class gridViewRowPresenter : gridViewRowPresenterBase
    {
      public static readonly IProperty<System.Windows.Controls.GridViewRowPresenter, System.Object> content = new Property<System.Windows.Controls.GridViewRowPresenter, System.Object>(System.Windows.Controls.GridViewRowPresenter.ContentProperty);
    }

    public partial class gridViewRowPresenterBase : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.GridViewRowPresenterBase, System.Windows.Controls.GridViewColumnCollection> columns = new Property<System.Windows.Controls.Primitives.GridViewRowPresenterBase, System.Windows.Controls.GridViewColumnCollection>(System.Windows.Controls.Primitives.GridViewRowPresenterBase.ColumnsProperty);
    }

    public partial class groupBox : headeredContentControl
    {
    }

    public partial class groupItem : contentControl
    {
    }

    public partial class headeredContentControl : contentControl
    {
      public static readonly IProperty<System.Windows.Controls.HeaderedContentControl, System.Object> header = new Property<System.Windows.Controls.HeaderedContentControl, System.Object>(System.Windows.Controls.HeaderedContentControl.HeaderProperty);
      public static readonly IProperty<System.Windows.Controls.HeaderedContentControl, System.Windows.DataTemplate> headerTemplate = new Property<System.Windows.Controls.HeaderedContentControl, System.Windows.DataTemplate>(System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.HeaderedContentControl, System.Windows.Controls.DataTemplateSelector> headerTemplateSelector = new Property<System.Windows.Controls.HeaderedContentControl, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.HeaderedContentControl, System.String> headerStringFormat = new Property<System.Windows.Controls.HeaderedContentControl, System.String>(System.Windows.Controls.HeaderedContentControl.HeaderStringFormatProperty);
    }

    public partial class headeredItemsControl : itemsControl
    {
      public static readonly IProperty<System.Windows.Controls.HeaderedItemsControl, System.Object> header = new Property<System.Windows.Controls.HeaderedItemsControl, System.Object>(System.Windows.Controls.HeaderedItemsControl.HeaderProperty);
      public static readonly IProperty<System.Windows.Controls.HeaderedItemsControl, System.Windows.DataTemplate> headerTemplate = new Property<System.Windows.Controls.HeaderedItemsControl, System.Windows.DataTemplate>(System.Windows.Controls.HeaderedItemsControl.HeaderTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.HeaderedItemsControl, System.Windows.Controls.DataTemplateSelector> headerTemplateSelector = new Property<System.Windows.Controls.HeaderedItemsControl, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.HeaderedItemsControl.HeaderTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.HeaderedItemsControl, System.String> headerStringFormat = new Property<System.Windows.Controls.HeaderedItemsControl, System.String>(System.Windows.Controls.HeaderedItemsControl.HeaderStringFormatProperty);
    }

    public partial class hwndHost : frameworkElement
    {
    }

    public partial class image : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Image, System.Windows.Media.ImageSource> source = new Property<System.Windows.Controls.Image, System.Windows.Media.ImageSource>(System.Windows.Controls.Image.SourceProperty);
      public static readonly IProperty<System.Windows.Controls.Image, System.Windows.Media.Stretch> stretch = new Property<System.Windows.Controls.Image, System.Windows.Media.Stretch>(System.Windows.Controls.Image.StretchProperty);
      public static readonly IProperty<System.Windows.Controls.Image, System.Windows.Controls.StretchDirection> stretchDirection = new Property<System.Windows.Controls.Image, System.Windows.Controls.StretchDirection>(System.Windows.Controls.Image.StretchDirectionProperty);
    }

    public partial class inkCanvas : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.InkCanvas, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.InkCanvas, System.Windows.Media.Brush>(System.Windows.Controls.InkCanvas.BackgroundProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> top = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.InkCanvas.TopProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> bottom = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.InkCanvas.BottomProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> left = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.InkCanvas.LeftProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> right = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.InkCanvas.RightProperty);
      public static readonly IProperty<System.Windows.Controls.InkCanvas, System.Windows.Ink.StrokeCollection> strokes = new Property<System.Windows.Controls.InkCanvas, System.Windows.Ink.StrokeCollection>(System.Windows.Controls.InkCanvas.StrokesProperty);
      public static readonly IProperty<System.Windows.Controls.InkCanvas, System.Windows.Ink.DrawingAttributes> defaultDrawingAttributes = new Property<System.Windows.Controls.InkCanvas, System.Windows.Ink.DrawingAttributes>(System.Windows.Controls.InkCanvas.DefaultDrawingAttributesProperty);
      public static readonly IProperty<System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode> editingMode = new Property<System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode>(System.Windows.Controls.InkCanvas.EditingModeProperty);
      public static readonly IProperty<System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode> editingModeInverted = new Property<System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode>(System.Windows.Controls.InkCanvas.EditingModeInvertedProperty);
    }

    public partial class inkPresenter : decorator
    {
      public static readonly IProperty<System.Windows.Controls.InkPresenter, System.Windows.Ink.StrokeCollection> strokes = new Property<System.Windows.Controls.InkPresenter, System.Windows.Ink.StrokeCollection>(System.Windows.Controls.InkPresenter.StrokesProperty);
    }

    public partial class itemsControl : control
    {
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Collections.IEnumerable> itemsSource = new Property<System.Windows.Controls.ItemsControl, System.Collections.IEnumerable>(System.Windows.Controls.ItemsControl.ItemsSourceProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.String> displayMemberPath = new Property<System.Windows.Controls.ItemsControl, System.String>(System.Windows.Controls.ItemsControl.DisplayMemberPathProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Windows.DataTemplate> itemTemplate = new Property<System.Windows.Controls.ItemsControl, System.Windows.DataTemplate>(System.Windows.Controls.ItemsControl.ItemTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Windows.Controls.DataTemplateSelector> itemTemplateSelector = new Property<System.Windows.Controls.ItemsControl, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.ItemsControl.ItemTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.String> itemStringFormat = new Property<System.Windows.Controls.ItemsControl, System.String>(System.Windows.Controls.ItemsControl.ItemStringFormatProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Windows.Data.BindingGroup> itemBindingGroup = new Property<System.Windows.Controls.ItemsControl, System.Windows.Data.BindingGroup>(System.Windows.Controls.ItemsControl.ItemBindingGroupProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Windows.Style> itemContainerStyle = new Property<System.Windows.Controls.ItemsControl, System.Windows.Style>(System.Windows.Controls.ItemsControl.ItemContainerStyleProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Windows.Controls.StyleSelector> itemContainerStyleSelector = new Property<System.Windows.Controls.ItemsControl, System.Windows.Controls.StyleSelector>(System.Windows.Controls.ItemsControl.ItemContainerStyleSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Windows.Controls.ItemsPanelTemplate> itemsPanel = new Property<System.Windows.Controls.ItemsControl, System.Windows.Controls.ItemsPanelTemplate>(System.Windows.Controls.ItemsControl.ItemsPanelProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Windows.Controls.GroupStyleSelector> groupStyleSelector = new Property<System.Windows.Controls.ItemsControl, System.Windows.Controls.GroupStyleSelector>(System.Windows.Controls.ItemsControl.GroupStyleSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Int32> alternationCount = new Property<System.Windows.Controls.ItemsControl, System.Int32>(System.Windows.Controls.ItemsControl.AlternationCountProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Boolean> isTextSearchEnabled = new Property<System.Windows.Controls.ItemsControl, System.Boolean>(System.Windows.Controls.ItemsControl.IsTextSearchEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.ItemsControl, System.Boolean> isTextSearchCaseSensitive = new Property<System.Windows.Controls.ItemsControl, System.Boolean>(System.Windows.Controls.ItemsControl.IsTextSearchCaseSensitiveProperty);
    }

    public partial class itemsPresenter : frameworkElement
    {
    }

    public partial class label : contentControl
    {
      public static readonly IProperty<System.Windows.Controls.Label, System.Windows.UIElement> target = new Property<System.Windows.Controls.Label, System.Windows.UIElement>(System.Windows.Controls.Label.TargetProperty);
    }

    public partial class line : shape
    {
      public static readonly IProperty<System.Windows.Shapes.Line, System.Double> x1 = new Property<System.Windows.Shapes.Line, System.Double>(System.Windows.Shapes.Line.X1Property);
      public static readonly IProperty<System.Windows.Shapes.Line, System.Double> y1 = new Property<System.Windows.Shapes.Line, System.Double>(System.Windows.Shapes.Line.Y1Property);
      public static readonly IProperty<System.Windows.Shapes.Line, System.Double> x2 = new Property<System.Windows.Shapes.Line, System.Double>(System.Windows.Shapes.Line.X2Property);
      public static readonly IProperty<System.Windows.Shapes.Line, System.Double> y2 = new Property<System.Windows.Shapes.Line, System.Double>(System.Windows.Shapes.Line.Y2Property);
    }

    public partial class listBox : selector
    {
      public static readonly IProperty<System.Windows.Controls.ListBox, System.Windows.Controls.SelectionMode> selectionMode = new Property<System.Windows.Controls.ListBox, System.Windows.Controls.SelectionMode>(System.Windows.Controls.ListBox.SelectionModeProperty);
    }

    public partial class listBoxItem : contentControl
    {
      public static readonly IProperty<System.Windows.Controls.ListBoxItem, System.Boolean> isSelected = new Property<System.Windows.Controls.ListBoxItem, System.Boolean>(System.Windows.Controls.ListBoxItem.IsSelectedProperty);
    }

    public partial class listView : listBox
    {
      public static readonly IProperty<System.Windows.Controls.ListView, System.Windows.Controls.ViewBase> view = new Property<System.Windows.Controls.ListView, System.Windows.Controls.ViewBase>(System.Windows.Controls.ListView.ViewProperty);
    }

    public partial class listViewItem : listBoxItem
    {
    }

    public partial class mediaElement : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Uri> source = new Property<System.Windows.Controls.MediaElement, System.Uri>(System.Windows.Controls.MediaElement.SourceProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Double> volume = new Property<System.Windows.Controls.MediaElement, System.Double>(System.Windows.Controls.MediaElement.VolumeProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Double> balance = new Property<System.Windows.Controls.MediaElement, System.Double>(System.Windows.Controls.MediaElement.BalanceProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Boolean> isMuted = new Property<System.Windows.Controls.MediaElement, System.Boolean>(System.Windows.Controls.MediaElement.IsMutedProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Boolean> scrubbingEnabled = new Property<System.Windows.Controls.MediaElement, System.Boolean>(System.Windows.Controls.MediaElement.ScrubbingEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState> unloadedBehavior = new Property<System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState>(System.Windows.Controls.MediaElement.UnloadedBehaviorProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState> loadedBehavior = new Property<System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState>(System.Windows.Controls.MediaElement.LoadedBehaviorProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Windows.Media.Stretch> stretch = new Property<System.Windows.Controls.MediaElement, System.Windows.Media.Stretch>(System.Windows.Controls.MediaElement.StretchProperty);
      public static readonly IProperty<System.Windows.Controls.MediaElement, System.Windows.Controls.StretchDirection> stretchDirection = new Property<System.Windows.Controls.MediaElement, System.Windows.Controls.StretchDirection>(System.Windows.Controls.MediaElement.StretchDirectionProperty);
    }

    public partial class menu : menuBase
    {
      public static readonly IProperty<System.Windows.Controls.Menu, System.Boolean> isMainMenu = new Property<System.Windows.Controls.Menu, System.Boolean>(System.Windows.Controls.Menu.IsMainMenuProperty);
    }

    public partial class menuBase : itemsControl
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.MenuBase, System.Windows.Controls.ItemContainerTemplateSelector> itemContainerTemplateSelector = new Property<System.Windows.Controls.Primitives.MenuBase, System.Windows.Controls.ItemContainerTemplateSelector>(System.Windows.Controls.Primitives.MenuBase.ItemContainerTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.MenuBase, System.Boolean> usesItemContainerTemplate = new Property<System.Windows.Controls.Primitives.MenuBase, System.Boolean>(System.Windows.Controls.Primitives.MenuBase.UsesItemContainerTemplateProperty);
    }

    public partial class menuItem : headeredItemsControl
    {
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Windows.Input.ICommand> command = new Property<System.Windows.Controls.MenuItem, System.Windows.Input.ICommand>(System.Windows.Controls.MenuItem.CommandProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Object> commandParameter = new Property<System.Windows.Controls.MenuItem, System.Object>(System.Windows.Controls.MenuItem.CommandParameterProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Windows.IInputElement> commandTarget = new Property<System.Windows.Controls.MenuItem, System.Windows.IInputElement>(System.Windows.Controls.MenuItem.CommandTargetProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Boolean> isSubmenuOpen = new Property<System.Windows.Controls.MenuItem, System.Boolean>(System.Windows.Controls.MenuItem.IsSubmenuOpenProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Boolean> isCheckable = new Property<System.Windows.Controls.MenuItem, System.Boolean>(System.Windows.Controls.MenuItem.IsCheckableProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Boolean> isChecked = new Property<System.Windows.Controls.MenuItem, System.Boolean>(System.Windows.Controls.MenuItem.IsCheckedProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Boolean> staysOpenOnClick = new Property<System.Windows.Controls.MenuItem, System.Boolean>(System.Windows.Controls.MenuItem.StaysOpenOnClickProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.String> inputGestureText = new Property<System.Windows.Controls.MenuItem, System.String>(System.Windows.Controls.MenuItem.InputGestureTextProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Object> icon = new Property<System.Windows.Controls.MenuItem, System.Object>(System.Windows.Controls.MenuItem.IconProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Windows.Controls.ItemContainerTemplateSelector> itemContainerTemplateSelector = new Property<System.Windows.Controls.MenuItem, System.Windows.Controls.ItemContainerTemplateSelector>(System.Windows.Controls.MenuItem.ItemContainerTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.MenuItem, System.Boolean> usesItemContainerTemplate = new Property<System.Windows.Controls.MenuItem, System.Boolean>(System.Windows.Controls.MenuItem.UsesItemContainerTemplateProperty);
    }

    public partial class multiSelector : selector
    {
    }

    public partial class navigationWindow : window
    {
      public static readonly IProperty<System.Windows.Navigation.NavigationWindow, System.Boolean> sandboxExternalContent = new Property<System.Windows.Navigation.NavigationWindow, System.Boolean>(System.Windows.Navigation.NavigationWindow.SandboxExternalContentProperty);
      public static readonly IProperty<System.Windows.Navigation.NavigationWindow, System.Boolean> showsNavigationUI = new Property<System.Windows.Navigation.NavigationWindow, System.Boolean>(System.Windows.Navigation.NavigationWindow.ShowsNavigationUIProperty);
      public static readonly IProperty<System.Windows.Navigation.NavigationWindow, System.Uri> source = new Property<System.Windows.Navigation.NavigationWindow, System.Uri>(System.Windows.Navigation.NavigationWindow.SourceProperty);
    }

    public partial class page : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Page, System.Object> content = new Property<System.Windows.Controls.Page, System.Object>(System.Windows.Controls.Page.ContentProperty);
      public static readonly IProperty<System.Windows.Controls.Page, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.Page, System.Windows.Media.Brush>(System.Windows.Controls.Page.BackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.Page, System.String> title = new Property<System.Windows.Controls.Page, System.String>(System.Windows.Controls.Page.TitleProperty);
      public static readonly IProperty<System.Windows.Controls.Page, System.Boolean> keepAlive = new Property<System.Windows.Controls.Page, System.Boolean>(System.Windows.Controls.Page.KeepAliveProperty);
      public static readonly IProperty<System.Windows.Controls.Page, System.Windows.Media.Brush> foreground = new Property<System.Windows.Controls.Page, System.Windows.Media.Brush>(System.Windows.Controls.Page.ForegroundProperty);
      public static readonly IProperty<System.Windows.Controls.Page, System.Windows.Media.FontFamily> fontFamily = new Property<System.Windows.Controls.Page, System.Windows.Media.FontFamily>(System.Windows.Controls.Page.FontFamilyProperty);
      public static readonly IProperty<System.Windows.Controls.Page, System.Double> fontSize = new Property<System.Windows.Controls.Page, System.Double>(System.Windows.Controls.Page.FontSizeProperty);
      public static readonly IProperty<System.Windows.Controls.Page, System.Windows.Controls.ControlTemplate> template = new Property<System.Windows.Controls.Page, System.Windows.Controls.ControlTemplate>(System.Windows.Controls.Page.TemplateProperty);
    }

    public partial class pageContent : frameworkElement
    {
      public static readonly IProperty<System.Windows.Documents.PageContent, System.Uri> source = new Property<System.Windows.Documents.PageContent, System.Uri>(System.Windows.Documents.PageContent.SourceProperty);
    }

    public partial class pageFunctionBase : page
    {
    }

    public partial class panel : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Panel, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.Panel, System.Windows.Media.Brush>(System.Windows.Controls.Panel.BackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.Panel, System.Boolean> isItemsHost = new Property<System.Windows.Controls.Panel, System.Boolean>(System.Windows.Controls.Panel.IsItemsHostProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Int32> zIndex = new Property<System.Windows.UIElement, System.Int32>(System.Windows.Controls.Panel.ZIndexProperty);
    }

    public partial class passwordBox : control
    {
      public static readonly IProperty<System.Windows.Controls.PasswordBox, System.Char> passwordChar = new Property<System.Windows.Controls.PasswordBox, System.Char>(System.Windows.Controls.PasswordBox.PasswordCharProperty);
      public static readonly IProperty<System.Windows.Controls.PasswordBox, System.Int32> maxLength = new Property<System.Windows.Controls.PasswordBox, System.Int32>(System.Windows.Controls.PasswordBox.MaxLengthProperty);
      public static readonly IProperty<System.Windows.Controls.PasswordBox, System.Windows.Media.Brush> selectionBrush = new Property<System.Windows.Controls.PasswordBox, System.Windows.Media.Brush>(System.Windows.Controls.PasswordBox.SelectionBrushProperty);
      public static readonly IProperty<System.Windows.Controls.PasswordBox, System.Double> selectionOpacity = new Property<System.Windows.Controls.PasswordBox, System.Double>(System.Windows.Controls.PasswordBox.SelectionOpacityProperty);
      public static readonly IProperty<System.Windows.Controls.PasswordBox, System.Windows.Media.Brush> caretBrush = new Property<System.Windows.Controls.PasswordBox, System.Windows.Media.Brush>(System.Windows.Controls.PasswordBox.CaretBrushProperty);
      public static readonly IProperty<System.Windows.Controls.PasswordBox, System.Boolean> isInactiveSelectionHighlightEnabled = new Property<System.Windows.Controls.PasswordBox, System.Boolean>(System.Windows.Controls.PasswordBox.IsInactiveSelectionHighlightEnabledProperty);
    }

    public partial class path : shape
    {
      public static readonly IProperty<System.Windows.Shapes.Path, System.Windows.Media.Geometry> data = new Property<System.Windows.Shapes.Path, System.Windows.Media.Geometry>(System.Windows.Shapes.Path.DataProperty);
    }

    public partial class polygon : shape
    {
      public static readonly IProperty<System.Windows.Shapes.Polygon, System.Windows.Media.PointCollection> points = new Property<System.Windows.Shapes.Polygon, System.Windows.Media.PointCollection>(System.Windows.Shapes.Polygon.PointsProperty);
      public static readonly IProperty<System.Windows.Shapes.Polygon, System.Windows.Media.FillRule> fillRule = new Property<System.Windows.Shapes.Polygon, System.Windows.Media.FillRule>(System.Windows.Shapes.Polygon.FillRuleProperty);
    }

    public partial class polyline : shape
    {
      public static readonly IProperty<System.Windows.Shapes.Polyline, System.Windows.Media.PointCollection> points = new Property<System.Windows.Shapes.Polyline, System.Windows.Media.PointCollection>(System.Windows.Shapes.Polyline.PointsProperty);
      public static readonly IProperty<System.Windows.Shapes.Polyline, System.Windows.Media.FillRule> fillRule = new Property<System.Windows.Shapes.Polyline, System.Windows.Media.FillRule>(System.Windows.Shapes.Polyline.FillRuleProperty);
    }

    public partial class popup : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Windows.UIElement> child = new Property<System.Windows.Controls.Primitives.Popup, System.Windows.UIElement>(System.Windows.Controls.Primitives.Popup.ChildProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Boolean> isOpen = new Property<System.Windows.Controls.Primitives.Popup, System.Boolean>(System.Windows.Controls.Primitives.Popup.IsOpenProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PlacementMode> placement = new Property<System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PlacementMode>(System.Windows.Controls.Primitives.Popup.PlacementProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.CustomPopupPlacementCallback> customPopupPlacementCallback = new Property<System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.CustomPopupPlacementCallback>(System.Windows.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Boolean> staysOpen = new Property<System.Windows.Controls.Primitives.Popup, System.Boolean>(System.Windows.Controls.Primitives.Popup.StaysOpenProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Double> horizontalOffset = new Property<System.Windows.Controls.Primitives.Popup, System.Double>(System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Double> verticalOffset = new Property<System.Windows.Controls.Primitives.Popup, System.Double>(System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Windows.UIElement> placementTarget = new Property<System.Windows.Controls.Primitives.Popup, System.Windows.UIElement>(System.Windows.Controls.Primitives.Popup.PlacementTargetProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Windows.Rect> placementRectangle = new Property<System.Windows.Controls.Primitives.Popup, System.Windows.Rect>(System.Windows.Controls.Primitives.Popup.PlacementRectangleProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PopupAnimation> popupAnimation = new Property<System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PopupAnimation>(System.Windows.Controls.Primitives.Popup.PopupAnimationProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Popup, System.Boolean> allowsTransparency = new Property<System.Windows.Controls.Primitives.Popup, System.Boolean>(System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty);
    }

    public partial class progressBar : rangeBase
    {
      public static readonly IProperty<System.Windows.Controls.ProgressBar, System.Boolean> isIndeterminate = new Property<System.Windows.Controls.ProgressBar, System.Boolean>(System.Windows.Controls.ProgressBar.IsIndeterminateProperty);
      public static readonly IProperty<System.Windows.Controls.ProgressBar, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.ProgressBar, System.Windows.Controls.Orientation>(System.Windows.Controls.ProgressBar.OrientationProperty);
    }

    public partial class radioButton : toggleButton
    {
      public static readonly IProperty<System.Windows.Controls.RadioButton, System.String> groupName = new Property<System.Windows.Controls.RadioButton, System.String>(System.Windows.Controls.RadioButton.GroupNameProperty);
    }

    public partial class rangeBase : control
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.RangeBase, System.Double> minimum = new Property<System.Windows.Controls.Primitives.RangeBase, System.Double>(System.Windows.Controls.Primitives.RangeBase.MinimumProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.RangeBase, System.Double> maximum = new Property<System.Windows.Controls.Primitives.RangeBase, System.Double>(System.Windows.Controls.Primitives.RangeBase.MaximumProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.RangeBase, System.Double> value = new Property<System.Windows.Controls.Primitives.RangeBase, System.Double>(System.Windows.Controls.Primitives.RangeBase.ValueProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.RangeBase, System.Double> largeChange = new Property<System.Windows.Controls.Primitives.RangeBase, System.Double>(System.Windows.Controls.Primitives.RangeBase.LargeChangeProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.RangeBase, System.Double> smallChange = new Property<System.Windows.Controls.Primitives.RangeBase, System.Double>(System.Windows.Controls.Primitives.RangeBase.SmallChangeProperty);
    }

    public partial class rectangle : shape
    {
      public static readonly IProperty<System.Windows.Shapes.Rectangle, System.Double> radiusX = new Property<System.Windows.Shapes.Rectangle, System.Double>(System.Windows.Shapes.Rectangle.RadiusXProperty);
      public static readonly IProperty<System.Windows.Shapes.Rectangle, System.Double> radiusY = new Property<System.Windows.Shapes.Rectangle, System.Double>(System.Windows.Shapes.Rectangle.RadiusYProperty);
    }

    public partial class repeatButton : buttonBase
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.RepeatButton, System.Int32> delay = new Property<System.Windows.Controls.Primitives.RepeatButton, System.Int32>(System.Windows.Controls.Primitives.RepeatButton.DelayProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.RepeatButton, System.Int32> interval = new Property<System.Windows.Controls.Primitives.RepeatButton, System.Int32>(System.Windows.Controls.Primitives.RepeatButton.IntervalProperty);
    }

    public partial class resizeGrip : control
    {
    }

    public partial class richTextBox : textBoxBase
    {
      public static readonly IProperty<System.Windows.Controls.RichTextBox, System.Boolean> isDocumentEnabled = new Property<System.Windows.Controls.RichTextBox, System.Boolean>(System.Windows.Controls.RichTextBox.IsDocumentEnabledProperty);
    }

    public partial class scrollBar : rangeBase
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.ScrollBar, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.Primitives.ScrollBar, System.Windows.Controls.Orientation>(System.Windows.Controls.Primitives.ScrollBar.OrientationProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.ScrollBar, System.Double> viewportSize = new Property<System.Windows.Controls.Primitives.ScrollBar, System.Double>(System.Windows.Controls.Primitives.ScrollBar.ViewportSizeProperty);
    }

    public partial class scrollContentPresenter : contentPresenter
    {
      public static readonly IProperty<System.Windows.Controls.ScrollContentPresenter, System.Boolean> canContentScroll = new Property<System.Windows.Controls.ScrollContentPresenter, System.Boolean>(System.Windows.Controls.ScrollContentPresenter.CanContentScrollProperty);
    }

    public partial class scrollViewer : contentControl
    {
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> canContentScroll = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.ScrollViewer.CanContentScrollProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility = new Property<System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility = new Property<System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isDeferredScrollingEnabled = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.PanningMode> panningMode = new Property<System.Windows.UIElement, System.Windows.Controls.PanningMode>(System.Windows.Controls.ScrollViewer.PanningModeProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> panningDeceleration = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.ScrollViewer.PanningDecelerationProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> panningRatio = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.ScrollViewer.PanningRatioProperty);
    }

    public partial class selectiveScrollingGrid : grid
    {
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.SelectiveScrollingOrientation> selectiveScrollingOrientation = new Property<System.Windows.UIElement, System.Windows.Controls.SelectiveScrollingOrientation>(System.Windows.Controls.Primitives.SelectiveScrollingGrid.SelectiveScrollingOrientationProperty);
    }

    public partial class selector : itemsControl
    {
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isSelected = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.Primitives.Selector.IsSelectedProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Selector, System.Nullable<System.Boolean>> isSynchronizedWithCurrentItem = new Property<System.Windows.Controls.Primitives.Selector, System.Nullable<System.Boolean>>(System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItemProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Selector, System.Int32> selectedIndex = new Property<System.Windows.Controls.Primitives.Selector, System.Int32>(System.Windows.Controls.Primitives.Selector.SelectedIndexProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Selector, System.Object> selectedItem = new Property<System.Windows.Controls.Primitives.Selector, System.Object>(System.Windows.Controls.Primitives.Selector.SelectedItemProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Selector, System.Object> selectedValue = new Property<System.Windows.Controls.Primitives.Selector, System.Object>(System.Windows.Controls.Primitives.Selector.SelectedValueProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Selector, System.String> selectedValuePath = new Property<System.Windows.Controls.Primitives.Selector, System.String>(System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty);
    }

    public partial class separator : control
    {
    }

    public partial class shape : frameworkElement
    {
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.Stretch> stretch = new Property<System.Windows.Shapes.Shape, System.Windows.Media.Stretch>(System.Windows.Shapes.Shape.StretchProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.Brush> fill = new Property<System.Windows.Shapes.Shape, System.Windows.Media.Brush>(System.Windows.Shapes.Shape.FillProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.Brush> stroke = new Property<System.Windows.Shapes.Shape, System.Windows.Media.Brush>(System.Windows.Shapes.Shape.StrokeProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Double> strokeThickness = new Property<System.Windows.Shapes.Shape, System.Double>(System.Windows.Shapes.Shape.StrokeThicknessProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap> strokeStartLineCap = new Property<System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap>(System.Windows.Shapes.Shape.StrokeStartLineCapProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap> strokeEndLineCap = new Property<System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap>(System.Windows.Shapes.Shape.StrokeEndLineCapProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap> strokeDashCap = new Property<System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap>(System.Windows.Shapes.Shape.StrokeDashCapProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.PenLineJoin> strokeLineJoin = new Property<System.Windows.Shapes.Shape, System.Windows.Media.PenLineJoin>(System.Windows.Shapes.Shape.StrokeLineJoinProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Double> strokeMiterLimit = new Property<System.Windows.Shapes.Shape, System.Double>(System.Windows.Shapes.Shape.StrokeMiterLimitProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Double> strokeDashOffset = new Property<System.Windows.Shapes.Shape, System.Double>(System.Windows.Shapes.Shape.StrokeDashOffsetProperty);
      public static readonly IProperty<System.Windows.Shapes.Shape, System.Windows.Media.DoubleCollection> strokeDashArray = new Property<System.Windows.Shapes.Shape, System.Windows.Media.DoubleCollection>(System.Windows.Shapes.Shape.StrokeDashArrayProperty);
    }

    public partial class slider : rangeBase
    {
      public static readonly IProperty<System.Windows.Controls.Slider, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.Slider, System.Windows.Controls.Orientation>(System.Windows.Controls.Slider.OrientationProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Boolean> isDirectionReversed = new Property<System.Windows.Controls.Slider, System.Boolean>(System.Windows.Controls.Slider.IsDirectionReversedProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Int32> delay = new Property<System.Windows.Controls.Slider, System.Int32>(System.Windows.Controls.Slider.DelayProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Int32> interval = new Property<System.Windows.Controls.Slider, System.Int32>(System.Windows.Controls.Slider.IntervalProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Windows.Controls.Primitives.AutoToolTipPlacement> autoToolTipPlacement = new Property<System.Windows.Controls.Slider, System.Windows.Controls.Primitives.AutoToolTipPlacement>(System.Windows.Controls.Slider.AutoToolTipPlacementProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Int32> autoToolTipPrecision = new Property<System.Windows.Controls.Slider, System.Int32>(System.Windows.Controls.Slider.AutoToolTipPrecisionProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Boolean> isSnapToTickEnabled = new Property<System.Windows.Controls.Slider, System.Boolean>(System.Windows.Controls.Slider.IsSnapToTickEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Windows.Controls.Primitives.TickPlacement> tickPlacement = new Property<System.Windows.Controls.Slider, System.Windows.Controls.Primitives.TickPlacement>(System.Windows.Controls.Slider.TickPlacementProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Double> tickFrequency = new Property<System.Windows.Controls.Slider, System.Double>(System.Windows.Controls.Slider.TickFrequencyProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Windows.Media.DoubleCollection> ticks = new Property<System.Windows.Controls.Slider, System.Windows.Media.DoubleCollection>(System.Windows.Controls.Slider.TicksProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Boolean> isSelectionRangeEnabled = new Property<System.Windows.Controls.Slider, System.Boolean>(System.Windows.Controls.Slider.IsSelectionRangeEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Double> selectionStart = new Property<System.Windows.Controls.Slider, System.Double>(System.Windows.Controls.Slider.SelectionStartProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Double> selectionEnd = new Property<System.Windows.Controls.Slider, System.Double>(System.Windows.Controls.Slider.SelectionEndProperty);
      public static readonly IProperty<System.Windows.Controls.Slider, System.Boolean> isMoveToPointEnabled = new Property<System.Windows.Controls.Slider, System.Boolean>(System.Windows.Controls.Slider.IsMoveToPointEnabledProperty);
    }

    public partial class stackPanel : panel
    {
      public static readonly IProperty<System.Windows.Controls.StackPanel, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.StackPanel, System.Windows.Controls.Orientation>(System.Windows.Controls.StackPanel.OrientationProperty);
    }

    public partial class statusBar : itemsControl
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.StatusBar, System.Windows.Controls.ItemContainerTemplateSelector> itemContainerTemplateSelector = new Property<System.Windows.Controls.Primitives.StatusBar, System.Windows.Controls.ItemContainerTemplateSelector>(System.Windows.Controls.Primitives.StatusBar.ItemContainerTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.StatusBar, System.Boolean> usesItemContainerTemplate = new Property<System.Windows.Controls.Primitives.StatusBar, System.Boolean>(System.Windows.Controls.Primitives.StatusBar.UsesItemContainerTemplateProperty);
    }

    public partial class statusBarItem : contentControl
    {
    }

    public partial class stickyNoteControl : control
    {
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Boolean> isExpanded = new Property<System.Windows.Controls.StickyNoteControl, System.Boolean>(System.Windows.Controls.StickyNoteControl.IsExpandedProperty);
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Boolean> isActive = new Property<System.Windows.Controls.StickyNoteControl, System.Boolean>(System.Windows.Controls.StickyNoteControl.IsActiveProperty);
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Windows.Media.FontFamily> captionFontFamily = new Property<System.Windows.Controls.StickyNoteControl, System.Windows.Media.FontFamily>(System.Windows.Controls.StickyNoteControl.CaptionFontFamilyProperty);
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Double> captionFontSize = new Property<System.Windows.Controls.StickyNoteControl, System.Double>(System.Windows.Controls.StickyNoteControl.CaptionFontSizeProperty);
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Windows.FontStretch> captionFontStretch = new Property<System.Windows.Controls.StickyNoteControl, System.Windows.FontStretch>(System.Windows.Controls.StickyNoteControl.CaptionFontStretchProperty);
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Windows.FontStyle> captionFontStyle = new Property<System.Windows.Controls.StickyNoteControl, System.Windows.FontStyle>(System.Windows.Controls.StickyNoteControl.CaptionFontStyleProperty);
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Windows.FontWeight> captionFontWeight = new Property<System.Windows.Controls.StickyNoteControl, System.Windows.FontWeight>(System.Windows.Controls.StickyNoteControl.CaptionFontWeightProperty);
      public static readonly IProperty<System.Windows.Controls.StickyNoteControl, System.Double> penWidth = new Property<System.Windows.Controls.StickyNoteControl, System.Double>(System.Windows.Controls.StickyNoteControl.PenWidthProperty);
    }

    public partial class tabControl : selector
    {
      public static readonly IProperty<System.Windows.Controls.TabControl, System.Windows.Controls.Dock> tabStripPlacement = new Property<System.Windows.Controls.TabControl, System.Windows.Controls.Dock>(System.Windows.Controls.TabControl.TabStripPlacementProperty);
      public static readonly IProperty<System.Windows.Controls.TabControl, System.Windows.DataTemplate> contentTemplate = new Property<System.Windows.Controls.TabControl, System.Windows.DataTemplate>(System.Windows.Controls.TabControl.ContentTemplateProperty);
      public static readonly IProperty<System.Windows.Controls.TabControl, System.Windows.Controls.DataTemplateSelector> contentTemplateSelector = new Property<System.Windows.Controls.TabControl, System.Windows.Controls.DataTemplateSelector>(System.Windows.Controls.TabControl.ContentTemplateSelectorProperty);
      public static readonly IProperty<System.Windows.Controls.TabControl, System.String> contentStringFormat = new Property<System.Windows.Controls.TabControl, System.String>(System.Windows.Controls.TabControl.ContentStringFormatProperty);
    }

    public partial class tabItem : headeredContentControl
    {
      public static readonly IProperty<System.Windows.Controls.TabItem, System.Boolean> isSelected = new Property<System.Windows.Controls.TabItem, System.Boolean>(System.Windows.Controls.TabItem.IsSelectedProperty);
    }

    public partial class tabPanel : panel
    {
    }

    public partial class textBlock : frameworkElement
    {
      public static readonly IProperty<System.Windows.UIElement, System.Double> baselineOffset = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.TextBlock.BaselineOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.String> text = new Property<System.Windows.Controls.TextBlock, System.String>(System.Windows.Controls.TextBlock.TextProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.FontFamily> fontFamily = new Property<System.Windows.UIElement, System.Windows.Media.FontFamily>(System.Windows.Controls.TextBlock.FontFamilyProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.FontStyle> fontStyle = new Property<System.Windows.UIElement, System.Windows.FontStyle>(System.Windows.Controls.TextBlock.FontStyleProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.FontWeight> fontWeight = new Property<System.Windows.UIElement, System.Windows.FontWeight>(System.Windows.Controls.TextBlock.FontWeightProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.FontStretch> fontStretch = new Property<System.Windows.UIElement, System.Windows.FontStretch>(System.Windows.Controls.TextBlock.FontStretchProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> fontSize = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.TextBlock.FontSizeProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.Brush> foreground = new Property<System.Windows.UIElement, System.Windows.Media.Brush>(System.Windows.Controls.TextBlock.ForegroundProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.TextBlock, System.Windows.Media.Brush>(System.Windows.Controls.TextBlock.BackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.Windows.TextDecorationCollection> textDecorations = new Property<System.Windows.Controls.TextBlock, System.Windows.TextDecorationCollection>(System.Windows.Controls.TextBlock.TextDecorationsProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.Windows.Media.TextEffectCollection> textEffects = new Property<System.Windows.Controls.TextBlock, System.Windows.Media.TextEffectCollection>(System.Windows.Controls.TextBlock.TextEffectsProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> lineHeight = new Property<System.Windows.UIElement, System.Double>(System.Windows.Controls.TextBlock.LineHeightProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.LineStackingStrategy> lineStackingStrategy = new Property<System.Windows.UIElement, System.Windows.LineStackingStrategy>(System.Windows.Controls.TextBlock.LineStackingStrategyProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.Windows.Thickness> padding = new Property<System.Windows.Controls.TextBlock, System.Windows.Thickness>(System.Windows.Controls.TextBlock.PaddingProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.TextAlignment> textAlignment = new Property<System.Windows.UIElement, System.Windows.TextAlignment>(System.Windows.Controls.TextBlock.TextAlignmentProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.Windows.TextTrimming> textTrimming = new Property<System.Windows.Controls.TextBlock, System.Windows.TextTrimming>(System.Windows.Controls.TextBlock.TextTrimmingProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.Windows.TextWrapping> textWrapping = new Property<System.Windows.Controls.TextBlock, System.Windows.TextWrapping>(System.Windows.Controls.TextBlock.TextWrappingProperty);
      public static readonly IProperty<System.Windows.Controls.TextBlock, System.Boolean> isHyphenationEnabled = new Property<System.Windows.Controls.TextBlock, System.Boolean>(System.Windows.Controls.TextBlock.IsHyphenationEnabledProperty);
    }

    public partial class textBox : textBoxBase
    {
      public static readonly IProperty<System.Windows.Controls.TextBox, System.Windows.TextWrapping> textWrapping = new Property<System.Windows.Controls.TextBox, System.Windows.TextWrapping>(System.Windows.Controls.TextBox.TextWrappingProperty);
      public static readonly IProperty<System.Windows.Controls.TextBox, System.Int32> minLines = new Property<System.Windows.Controls.TextBox, System.Int32>(System.Windows.Controls.TextBox.MinLinesProperty);
      public static readonly IProperty<System.Windows.Controls.TextBox, System.Int32> maxLines = new Property<System.Windows.Controls.TextBox, System.Int32>(System.Windows.Controls.TextBox.MaxLinesProperty);
      public static readonly IProperty<System.Windows.Controls.TextBox, System.String> text = new Property<System.Windows.Controls.TextBox, System.String>(System.Windows.Controls.TextBox.TextProperty);
      public static readonly IProperty<System.Windows.Controls.TextBox, System.Windows.Controls.CharacterCasing> characterCasing = new Property<System.Windows.Controls.TextBox, System.Windows.Controls.CharacterCasing>(System.Windows.Controls.TextBox.CharacterCasingProperty);
      public static readonly IProperty<System.Windows.Controls.TextBox, System.Int32> maxLength = new Property<System.Windows.Controls.TextBox, System.Int32>(System.Windows.Controls.TextBox.MaxLengthProperty);
      public static readonly IProperty<System.Windows.Controls.TextBox, System.Windows.TextAlignment> textAlignment = new Property<System.Windows.Controls.TextBox, System.Windows.TextAlignment>(System.Windows.Controls.TextBox.TextAlignmentProperty);
      public static readonly IProperty<System.Windows.Controls.TextBox, System.Windows.TextDecorationCollection> textDecorations = new Property<System.Windows.Controls.TextBox, System.Windows.TextDecorationCollection>(System.Windows.Controls.TextBox.TextDecorationsProperty);
    }

    public partial class textBoxBase : control
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isReadOnly = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isReadOnlyCaretVisible = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyCaretVisibleProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> acceptsReturn = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(System.Windows.Controls.Primitives.TextBoxBase.AcceptsReturnProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> acceptsTab = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(System.Windows.Controls.Primitives.TextBoxBase.AcceptsTabProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.Primitives.TextBoxBase.HorizontalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility>(System.Windows.Controls.Primitives.TextBoxBase.VerticalScrollBarVisibilityProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isUndoEnabled = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(System.Windows.Controls.Primitives.TextBoxBase.IsUndoEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Int32> undoLimit = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Int32>(System.Windows.Controls.Primitives.TextBoxBase.UndoLimitProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> autoWordSelection = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(System.Windows.Controls.Primitives.TextBoxBase.AutoWordSelectionProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush> selectionBrush = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush>(System.Windows.Controls.Primitives.TextBoxBase.SelectionBrushProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Double> selectionOpacity = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Double>(System.Windows.Controls.Primitives.TextBoxBase.SelectionOpacityProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush> caretBrush = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush>(System.Windows.Controls.Primitives.TextBoxBase.CaretBrushProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isInactiveSelectionHighlightEnabled = new Property<System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(System.Windows.Controls.Primitives.TextBoxBase.IsInactiveSelectionHighlightEnabledProperty);
    }

    public partial class thumb : control
    {
    }

    public partial class tickBar : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Windows.Media.Brush> fill = new Property<System.Windows.Controls.Primitives.TickBar, System.Windows.Media.Brush>(System.Windows.Controls.Primitives.TickBar.FillProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Double> minimum = new Property<System.Windows.Controls.Primitives.TickBar, System.Double>(System.Windows.Controls.Primitives.TickBar.MinimumProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Double> maximum = new Property<System.Windows.Controls.Primitives.TickBar, System.Double>(System.Windows.Controls.Primitives.TickBar.MaximumProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Double> selectionStart = new Property<System.Windows.Controls.Primitives.TickBar, System.Double>(System.Windows.Controls.Primitives.TickBar.SelectionStartProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Double> selectionEnd = new Property<System.Windows.Controls.Primitives.TickBar, System.Double>(System.Windows.Controls.Primitives.TickBar.SelectionEndProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Boolean> isSelectionRangeEnabled = new Property<System.Windows.Controls.Primitives.TickBar, System.Boolean>(System.Windows.Controls.Primitives.TickBar.IsSelectionRangeEnabledProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Double> tickFrequency = new Property<System.Windows.Controls.Primitives.TickBar, System.Double>(System.Windows.Controls.Primitives.TickBar.TickFrequencyProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Windows.Media.DoubleCollection> ticks = new Property<System.Windows.Controls.Primitives.TickBar, System.Windows.Media.DoubleCollection>(System.Windows.Controls.Primitives.TickBar.TicksProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Boolean> isDirectionReversed = new Property<System.Windows.Controls.Primitives.TickBar, System.Boolean>(System.Windows.Controls.Primitives.TickBar.IsDirectionReversedProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Windows.Controls.Primitives.TickBarPlacement> placement = new Property<System.Windows.Controls.Primitives.TickBar, System.Windows.Controls.Primitives.TickBarPlacement>(System.Windows.Controls.Primitives.TickBar.PlacementProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.TickBar, System.Double> reservedSpace = new Property<System.Windows.Controls.Primitives.TickBar, System.Double>(System.Windows.Controls.Primitives.TickBar.ReservedSpaceProperty);
    }

    public partial class toggleButton : buttonBase
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.ToggleButton, System.Nullable<System.Boolean>> isChecked = new Property<System.Windows.Controls.Primitives.ToggleButton, System.Nullable<System.Boolean>>(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.ToggleButton, System.Boolean> isThreeState = new Property<System.Windows.Controls.Primitives.ToggleButton, System.Boolean>(System.Windows.Controls.Primitives.ToggleButton.IsThreeStateProperty);
    }

    public partial class toolBar : headeredItemsControl
    {
      public static readonly IProperty<System.Windows.Controls.ToolBar, System.Int32> band = new Property<System.Windows.Controls.ToolBar, System.Int32>(System.Windows.Controls.ToolBar.BandProperty);
      public static readonly IProperty<System.Windows.Controls.ToolBar, System.Int32> bandIndex = new Property<System.Windows.Controls.ToolBar, System.Int32>(System.Windows.Controls.ToolBar.BandIndexProperty);
      public static readonly IProperty<System.Windows.Controls.ToolBar, System.Boolean> isOverflowOpen = new Property<System.Windows.Controls.ToolBar, System.Boolean>(System.Windows.Controls.ToolBar.IsOverflowOpenProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.OverflowMode> overflowMode = new Property<System.Windows.UIElement, System.Windows.Controls.OverflowMode>(System.Windows.Controls.ToolBar.OverflowModeProperty);
    }

    public partial class toolBarOverflowPanel : panel
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.ToolBarOverflowPanel, System.Double> wrapWidth = new Property<System.Windows.Controls.Primitives.ToolBarOverflowPanel, System.Double>(System.Windows.Controls.Primitives.ToolBarOverflowPanel.WrapWidthProperty);
    }

    public partial class toolBarPanel : stackPanel
    {
    }

    public partial class toolBarTray : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.ToolBarTray, System.Windows.Media.Brush> background = new Property<System.Windows.Controls.ToolBarTray, System.Windows.Media.Brush>(System.Windows.Controls.ToolBarTray.BackgroundProperty);
      public static readonly IProperty<System.Windows.Controls.ToolBarTray, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.ToolBarTray, System.Windows.Controls.Orientation>(System.Windows.Controls.ToolBarTray.OrientationProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isLocked = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.ToolBarTray.IsLockedProperty);
    }

    public partial class toolTip : contentControl
    {
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Double> horizontalOffset = new Property<System.Windows.Controls.ToolTip, System.Double>(System.Windows.Controls.ToolTip.HorizontalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Double> verticalOffset = new Property<System.Windows.Controls.ToolTip, System.Double>(System.Windows.Controls.ToolTip.VerticalOffsetProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Boolean> isOpen = new Property<System.Windows.Controls.ToolTip, System.Boolean>(System.Windows.Controls.ToolTip.IsOpenProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Boolean> hasDropShadow = new Property<System.Windows.Controls.ToolTip, System.Boolean>(System.Windows.Controls.ToolTip.HasDropShadowProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Windows.UIElement> placementTarget = new Property<System.Windows.Controls.ToolTip, System.Windows.UIElement>(System.Windows.Controls.ToolTip.PlacementTargetProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Windows.Rect> placementRectangle = new Property<System.Windows.Controls.ToolTip, System.Windows.Rect>(System.Windows.Controls.ToolTip.PlacementRectangleProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.PlacementMode> placement = new Property<System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.PlacementMode>(System.Windows.Controls.ToolTip.PlacementProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.CustomPopupPlacementCallback> customPopupPlacementCallback = new Property<System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.CustomPopupPlacementCallback>(System.Windows.Controls.ToolTip.CustomPopupPlacementCallbackProperty);
      public static readonly IProperty<System.Windows.Controls.ToolTip, System.Boolean> staysOpen = new Property<System.Windows.Controls.ToolTip, System.Boolean>(System.Windows.Controls.ToolTip.StaysOpenProperty);
    }

    public partial class track : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.Track, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.Primitives.Track, System.Windows.Controls.Orientation>(System.Windows.Controls.Primitives.Track.OrientationProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Track, System.Double> minimum = new Property<System.Windows.Controls.Primitives.Track, System.Double>(System.Windows.Controls.Primitives.Track.MinimumProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Track, System.Double> maximum = new Property<System.Windows.Controls.Primitives.Track, System.Double>(System.Windows.Controls.Primitives.Track.MaximumProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Track, System.Double> value = new Property<System.Windows.Controls.Primitives.Track, System.Double>(System.Windows.Controls.Primitives.Track.ValueProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Track, System.Double> viewportSize = new Property<System.Windows.Controls.Primitives.Track, System.Double>(System.Windows.Controls.Primitives.Track.ViewportSizeProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.Track, System.Boolean> isDirectionReversed = new Property<System.Windows.Controls.Primitives.Track, System.Boolean>(System.Windows.Controls.Primitives.Track.IsDirectionReversedProperty);
    }

    public partial class treeView : itemsControl
    {
      public static readonly IProperty<System.Windows.Controls.TreeView, System.String> selectedValuePath = new Property<System.Windows.Controls.TreeView, System.String>(System.Windows.Controls.TreeView.SelectedValuePathProperty);
    }

    public partial class treeViewItem : headeredItemsControl
    {
      public static readonly IProperty<System.Windows.Controls.TreeViewItem, System.Boolean> isExpanded = new Property<System.Windows.Controls.TreeViewItem, System.Boolean>(System.Windows.Controls.TreeViewItem.IsExpandedProperty);
      public static readonly IProperty<System.Windows.Controls.TreeViewItem, System.Boolean> isSelected = new Property<System.Windows.Controls.TreeViewItem, System.Boolean>(System.Windows.Controls.TreeViewItem.IsSelectedProperty);
    }

    public partial class uIElement
    {
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> allowDrop = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.UIElement.AllowDropProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.Transform> renderTransform = new Property<System.Windows.UIElement, System.Windows.Media.Transform>(System.Windows.UIElement.RenderTransformProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Point> renderTransformOrigin = new Property<System.Windows.UIElement, System.Windows.Point>(System.Windows.UIElement.RenderTransformOriginProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Double> opacity = new Property<System.Windows.UIElement, System.Double>(System.Windows.UIElement.OpacityProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.Brush> opacityMask = new Property<System.Windows.UIElement, System.Windows.Media.Brush>(System.Windows.UIElement.OpacityMaskProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffect> bitmapEffect = new Property<System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffect>(System.Windows.UIElement.BitmapEffectProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.Effects.Effect> effect = new Property<System.Windows.UIElement, System.Windows.Media.Effects.Effect>(System.Windows.UIElement.EffectProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffectInput> bitmapEffectInput = new Property<System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffectInput>(System.Windows.UIElement.BitmapEffectInputProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.CacheMode> cacheMode = new Property<System.Windows.UIElement, System.Windows.Media.CacheMode>(System.Windows.UIElement.CacheModeProperty);
      public static readonly IProperty<System.Windows.UIElement, System.String> uid = new Property<System.Windows.UIElement, System.String>(System.Windows.UIElement.UidProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Visibility> visibility = new Property<System.Windows.UIElement, System.Windows.Visibility>(System.Windows.UIElement.VisibilityProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> clipToBounds = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.UIElement.ClipToBoundsProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Media.Geometry> clip = new Property<System.Windows.UIElement, System.Windows.Media.Geometry>(System.Windows.UIElement.ClipProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> snapsToDevicePixels = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.UIElement.SnapsToDevicePixelsProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isEnabled = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.UIElement.IsEnabledProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isHitTestVisible = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.UIElement.IsHitTestVisibleProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> focusable = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.UIElement.FocusableProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isManipulationEnabled = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.UIElement.IsManipulationEnabledProperty);
    }

    public partial class uniformGrid : panel
    {
      public static readonly IProperty<System.Windows.Controls.Primitives.UniformGrid, System.Int32> firstColumn = new Property<System.Windows.Controls.Primitives.UniformGrid, System.Int32>(System.Windows.Controls.Primitives.UniformGrid.FirstColumnProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.UniformGrid, System.Int32> columns = new Property<System.Windows.Controls.Primitives.UniformGrid, System.Int32>(System.Windows.Controls.Primitives.UniformGrid.ColumnsProperty);
      public static readonly IProperty<System.Windows.Controls.Primitives.UniformGrid, System.Int32> rows = new Property<System.Windows.Controls.Primitives.UniformGrid, System.Int32>(System.Windows.Controls.Primitives.UniformGrid.RowsProperty);
    }

    public partial class userControl : contentControl
    {
    }

    public partial class webBrowser : activeXHost
    {
    }

    public partial class viewbox : decorator
    {
      public static readonly IProperty<System.Windows.Controls.Viewbox, System.Windows.Media.Stretch> stretch = new Property<System.Windows.Controls.Viewbox, System.Windows.Media.Stretch>(System.Windows.Controls.Viewbox.StretchProperty);
      public static readonly IProperty<System.Windows.Controls.Viewbox, System.Windows.Controls.StretchDirection> stretchDirection = new Property<System.Windows.Controls.Viewbox, System.Windows.Controls.StretchDirection>(System.Windows.Controls.Viewbox.StretchDirectionProperty);
    }

    public partial class viewport3D : frameworkElement
    {
      public static readonly IProperty<System.Windows.Controls.Viewport3D, System.Windows.Media.Media3D.Camera> camera = new Property<System.Windows.Controls.Viewport3D, System.Windows.Media.Media3D.Camera>(System.Windows.Controls.Viewport3D.CameraProperty);
    }

    public partial class window : contentControl
    {
      public static readonly IProperty<System.Windows.Window, System.Windows.Shell.TaskbarItemInfo> taskbarItemInfo = new Property<System.Windows.Window, System.Windows.Shell.TaskbarItemInfo>(System.Windows.Window.TaskbarItemInfoProperty);
      public static readonly IProperty<System.Windows.Window, System.Boolean> allowsTransparency = new Property<System.Windows.Window, System.Boolean>(System.Windows.Window.AllowsTransparencyProperty);
      public static readonly IProperty<System.Windows.Window, System.String> title = new Property<System.Windows.Window, System.String>(System.Windows.Window.TitleProperty);
      public static readonly IProperty<System.Windows.Window, System.Windows.Media.ImageSource> icon = new Property<System.Windows.Window, System.Windows.Media.ImageSource>(System.Windows.Window.IconProperty);
      public static readonly IProperty<System.Windows.Window, System.Windows.SizeToContent> sizeToContent = new Property<System.Windows.Window, System.Windows.SizeToContent>(System.Windows.Window.SizeToContentProperty);
      public static readonly IProperty<System.Windows.Window, System.Double> top = new Property<System.Windows.Window, System.Double>(System.Windows.Window.TopProperty);
      public static readonly IProperty<System.Windows.Window, System.Double> left = new Property<System.Windows.Window, System.Double>(System.Windows.Window.LeftProperty);
      public static readonly IProperty<System.Windows.Window, System.Boolean> showInTaskbar = new Property<System.Windows.Window, System.Boolean>(System.Windows.Window.ShowInTaskbarProperty);
      public static readonly IProperty<System.Windows.Window, System.Windows.WindowStyle> windowStyle = new Property<System.Windows.Window, System.Windows.WindowStyle>(System.Windows.Window.WindowStyleProperty);
      public static readonly IProperty<System.Windows.Window, System.Windows.WindowState> windowState = new Property<System.Windows.Window, System.Windows.WindowState>(System.Windows.Window.WindowStateProperty);
      public static readonly IProperty<System.Windows.Window, System.Windows.ResizeMode> resizeMode = new Property<System.Windows.Window, System.Windows.ResizeMode>(System.Windows.Window.ResizeModeProperty);
      public static readonly IProperty<System.Windows.Window, System.Boolean> topmost = new Property<System.Windows.Window, System.Boolean>(System.Windows.Window.TopmostProperty);
      public static readonly IProperty<System.Windows.Window, System.Boolean> showActivated = new Property<System.Windows.Window, System.Boolean>(System.Windows.Window.ShowActivatedProperty);
    }

    public partial class virtualizingPanel : panel
    {
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isVirtualizing = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.VirtualizingPanel.IsVirtualizingProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.VirtualizationMode> virtualizationMode = new Property<System.Windows.UIElement, System.Windows.Controls.VirtualizationMode>(System.Windows.Controls.VirtualizingPanel.VirtualizationModeProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isVirtualizingWhenGrouping = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.VirtualizingPanel.IsVirtualizingWhenGroupingProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.ScrollUnit> scrollUnit = new Property<System.Windows.UIElement, System.Windows.Controls.ScrollUnit>(System.Windows.Controls.VirtualizingPanel.ScrollUnitProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLength> cacheLength = new Property<System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLength>(System.Windows.Controls.VirtualizingPanel.CacheLengthProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLengthUnit> cacheLengthUnit = new Property<System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLengthUnit>(System.Windows.Controls.VirtualizingPanel.CacheLengthUnitProperty);
      public static readonly IProperty<System.Windows.UIElement, System.Boolean> isContainerVirtualizable = new Property<System.Windows.UIElement, System.Boolean>(System.Windows.Controls.VirtualizingPanel.IsContainerVirtualizableProperty);
    }

    public partial class virtualizingStackPanel : virtualizingPanel
    {
      public static readonly IProperty<System.Windows.Controls.VirtualizingStackPanel, System.Boolean> isVirtualizing = new Property<System.Windows.Controls.VirtualizingStackPanel, System.Boolean>(System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty);
      public static readonly IProperty<System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.VirtualizationMode> virtualizationMode = new Property<System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.VirtualizationMode>(System.Windows.Controls.VirtualizingStackPanel.VirtualizationModeProperty);
      public static readonly IProperty<System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.Orientation>(System.Windows.Controls.VirtualizingStackPanel.OrientationProperty);
    }

    public partial class wrapPanel : panel
    {
      public static readonly IProperty<System.Windows.Controls.WrapPanel, System.Double> itemWidth = new Property<System.Windows.Controls.WrapPanel, System.Double>(System.Windows.Controls.WrapPanel.ItemWidthProperty);
      public static readonly IProperty<System.Windows.Controls.WrapPanel, System.Double> itemHeight = new Property<System.Windows.Controls.WrapPanel, System.Double>(System.Windows.Controls.WrapPanel.ItemHeightProperty);
      public static readonly IProperty<System.Windows.Controls.WrapPanel, System.Windows.Controls.Orientation> orientation = new Property<System.Windows.Controls.WrapPanel, System.Windows.Controls.Orientation>(System.Windows.Controls.WrapPanel.OrientationProperty);
    }

  }

  public static partial class Events
  {
    public partial class accessText : frameworkElement
    {
    }

    public partial class activeXHost : hwndHost
    {
    }

    public partial class adornedElementPlaceholder : frameworkElement
    {
    }

    public partial class adorner : frameworkElement
    {
    }

    public partial class adornerDecorator : decorator
    {
    }

    public partial class adornerLayer : frameworkElement
    {
    }

    public partial class border : decorator
    {
    }

    public partial class bulletDecorator : decorator
    {
    }

    public partial class button : buttonBase
    {
    }

    public partial class buttonBase : contentControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> click = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Primitives.ButtonBase.ClickEvent);
    }

    public partial class calendar : control
    {
      public static readonly IEvent<System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> selectedDatesChanged = new Event<System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs>(System.Windows.Controls.Calendar.SelectedDatesChangedEvent);
    }

    public partial class calendarButton : button
    {
    }

    public partial class calendarDayButton : button
    {
    }

    public partial class calendarItem : control
    {
    }

    public partial class canvas : panel
    {
    }

    public partial class checkBox : toggleButton
    {
    }

    public partial class comboBox : selector
    {
    }

    public partial class comboBoxItem : listBoxItem
    {
    }

    public partial class contentControl : control
    {
    }

    public partial class contentPresenter : frameworkElement
    {
    }

    public partial class contextMenu : menuBase
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> opened = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.ContextMenu.OpenedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> closed = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.ContextMenu.ClosedEvent);
    }

    public partial class control : frameworkElement
    {
      public static readonly IEvent<System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> previewMouseDoubleClick = new Event<System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.Controls.Control.PreviewMouseDoubleClickEvent);
      public static readonly IEvent<System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> mouseDoubleClick = new Event<System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.Controls.Control.MouseDoubleClickEvent);
    }

    public partial class dataGrid : multiSelector
    {
    }

    public partial class dataGridCell : contentControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> selected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.DataGridCell.SelectedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unselected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.DataGridCell.UnselectedEvent);
    }

    public partial class dataGridCellsPanel : virtualizingPanel
    {
    }

    public partial class dataGridCellsPresenter : itemsControl
    {
    }

    public partial class dataGridColumnHeader : buttonBase
    {
    }

    public partial class dataGridColumnHeadersPresenter : itemsControl
    {
    }

    public partial class dataGridDetailsPresenter : contentPresenter
    {
    }

    public partial class dataGridRow : control
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> selected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.DataGridRow.SelectedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unselected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.DataGridRow.UnselectedEvent);
    }

    public partial class dataGridRowHeader : buttonBase
    {
    }

    public partial class dataGridRowsPresenter : virtualizingStackPanel
    {
    }

    public partial class datePicker : control
    {
      public static readonly IEvent<System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> selectedDateChanged = new Event<System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs>(System.Windows.Controls.DatePicker.SelectedDateChangedEvent);
    }

    public partial class datePickerTextBox : textBox
    {
    }

    public partial class decorator : frameworkElement
    {
    }

    public partial class dockPanel : panel
    {
    }

    public partial class documentPageView : frameworkElement
    {
    }

    public partial class documentReference : frameworkElement
    {
    }

    public partial class documentViewer : documentViewerBase
    {
    }

    public partial class documentViewerBase : control
    {
    }

    public partial class ellipse : shape
    {
    }

    public partial class expander : headeredContentControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> expanded = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Expander.ExpandedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> collapsed = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Expander.CollapsedEvent);
    }

    public partial class fixedPage : frameworkElement
    {
    }

    public partial class flowDocumentPageViewer : documentViewerBase
    {
    }

    public partial class flowDocumentReader : control
    {
    }

    public partial class flowDocumentScrollViewer : control
    {
    }

    public partial class frame : contentControl
    {
    }

    public partial class frameworkElement : uIElement
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs> requestBringIntoView = new Event<System.Windows.UIElement, System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs>(System.Windows.FrameworkElement.RequestBringIntoViewEvent);
      public static readonly IEvent<System.Windows.FrameworkElement, System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs> sizeChanged = new Event<System.Windows.FrameworkElement, System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs>(System.Windows.FrameworkElement.SizeChangedEvent);
      public static readonly IEvent<System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> loaded = new Event<System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.FrameworkElement.LoadedEvent);
      public static readonly IEvent<System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unloaded = new Event<System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.FrameworkElement.UnloadedEvent);
      public static readonly IEvent<System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> toolTipOpening = new Event<System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(System.Windows.FrameworkElement.ToolTipOpeningEvent);
      public static readonly IEvent<System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> toolTipClosing = new Event<System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(System.Windows.FrameworkElement.ToolTipClosingEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> contextMenuOpening = new Event<System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(System.Windows.FrameworkElement.ContextMenuOpeningEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> contextMenuClosing = new Event<System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(System.Windows.FrameworkElement.ContextMenuClosingEvent);
    }

    public partial class glyphs : frameworkElement
    {
    }

    public partial class grid : panel
    {
    }

    public partial class gridSplitter : thumb
    {
    }

    public partial class gridViewColumnHeader : buttonBase
    {
    }

    public partial class gridViewHeaderRowPresenter : gridViewRowPresenterBase
    {
    }

    public partial class gridViewRowPresenter : gridViewRowPresenterBase
    {
    }

    public partial class gridViewRowPresenterBase : frameworkElement
    {
    }

    public partial class groupBox : headeredContentControl
    {
    }

    public partial class groupItem : contentControl
    {
    }

    public partial class headeredContentControl : contentControl
    {
    }

    public partial class headeredItemsControl : itemsControl
    {
    }

    public partial class hwndHost : frameworkElement
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> dpiChanged = new Event<System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(System.Windows.Interop.HwndHost.DpiChangedEvent);
    }

    public partial class image : frameworkElement
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> dpiChanged = new Event<System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(System.Windows.Controls.Image.DpiChangedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> imageFailed = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(System.Windows.Controls.Image.ImageFailedEvent);
    }

    public partial class inkCanvas : frameworkElement
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> strokeCollected = new Event<System.Windows.UIElement, System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs>(System.Windows.Controls.InkCanvas.StrokeCollectedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs> gesture = new Event<System.Windows.UIElement, System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs>(System.Windows.Controls.InkCanvas.GestureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> activeEditingModeChanged = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.InkCanvas.ActiveEditingModeChangedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> editingModeChanged = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.InkCanvas.EditingModeChangedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> editingModeInvertedChanged = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.InkCanvas.EditingModeInvertedChangedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> strokeErased = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.InkCanvas.StrokeErasedEvent);
    }

    public partial class inkPresenter : decorator
    {
    }

    public partial class itemsControl : control
    {
    }

    public partial class itemsPresenter : frameworkElement
    {
    }

    public partial class label : contentControl
    {
    }

    public partial class line : shape
    {
    }

    public partial class listBox : selector
    {
    }

    public partial class listBoxItem : contentControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> selected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.ListBoxItem.SelectedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unselected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.ListBoxItem.UnselectedEvent);
    }

    public partial class listView : listBox
    {
    }

    public partial class listViewItem : listBoxItem
    {
    }

    public partial class mediaElement : frameworkElement
    {
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> mediaFailed = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(System.Windows.Controls.MediaElement.MediaFailedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> mediaOpened = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MediaElement.MediaOpenedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> bufferingStarted = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MediaElement.BufferingStartedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> bufferingEnded = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MediaElement.BufferingEndedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>, System.Windows.MediaScriptCommandRoutedEventArgs> scriptCommand = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>, System.Windows.MediaScriptCommandRoutedEventArgs>(System.Windows.Controls.MediaElement.ScriptCommandEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> mediaEnded = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MediaElement.MediaEndedEvent);
    }

    public partial class menu : menuBase
    {
    }

    public partial class menuBase : itemsControl
    {
    }

    public partial class menuItem : headeredItemsControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> click = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MenuItem.ClickEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> checked_ = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MenuItem.CheckedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unchecked_ = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MenuItem.UncheckedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> submenuOpened = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MenuItem.SubmenuOpenedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> submenuClosed = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.MenuItem.SubmenuClosedEvent);
    }

    public partial class multiSelector : selector
    {
    }

    public partial class navigationWindow : window
    {
    }

    public partial class page : frameworkElement
    {
    }

    public partial class pageContent : frameworkElement
    {
    }

    public partial class pageFunctionBase : page
    {
    }

    public partial class panel : frameworkElement
    {
    }

    public partial class passwordBox : control
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> passwordChanged = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.PasswordBox.PasswordChangedEvent);
    }

    public partial class path : shape
    {
    }

    public partial class polygon : shape
    {
    }

    public partial class polyline : shape
    {
    }

    public partial class popup : frameworkElement
    {
    }

    public partial class progressBar : rangeBase
    {
    }

    public partial class radioButton : toggleButton
    {
    }

    public partial class rangeBase : control
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>> valueChanged = new Event<System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(System.Windows.Controls.Primitives.RangeBase.ValueChangedEvent);
    }

    public partial class rectangle : shape
    {
    }

    public partial class repeatButton : buttonBase
    {
    }

    public partial class resizeGrip : control
    {
    }

    public partial class richTextBox : textBoxBase
    {
    }

    public partial class scrollBar : rangeBase
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs> scroll = new Event<System.Windows.UIElement, System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs>(System.Windows.Controls.Primitives.ScrollBar.ScrollEvent);
    }

    public partial class scrollContentPresenter : contentPresenter
    {
    }

    public partial class scrollViewer : contentControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs> scrollChanged = new Event<System.Windows.UIElement, System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs>(System.Windows.Controls.ScrollViewer.ScrollChangedEvent);
    }

    public partial class selectiveScrollingGrid : grid
    {
    }

    public partial class selector : itemsControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs> selectionChanged = new Event<System.Windows.UIElement, System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(System.Windows.Controls.Primitives.Selector.SelectionChangedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> selected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Primitives.Selector.SelectedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unselected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Primitives.Selector.UnselectedEvent);
    }

    public partial class separator : control
    {
    }

    public partial class shape : frameworkElement
    {
    }

    public partial class slider : rangeBase
    {
    }

    public partial class stackPanel : panel
    {
    }

    public partial class statusBar : itemsControl
    {
    }

    public partial class statusBarItem : contentControl
    {
    }

    public partial class stickyNoteControl : control
    {
    }

    public partial class tabControl : selector
    {
    }

    public partial class tabItem : headeredContentControl
    {
    }

    public partial class tabPanel : panel
    {
    }

    public partial class textBlock : frameworkElement
    {
    }

    public partial class textBox : textBoxBase
    {
    }

    public partial class textBoxBase : control
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs> textChanged = new Event<System.Windows.UIElement, System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs>(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> selectionChanged = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Primitives.TextBoxBase.SelectionChangedEvent);
    }

    public partial class thumb : control
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs> dragStarted = new Event<System.Windows.UIElement, System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs>(System.Windows.Controls.Primitives.Thumb.DragStartedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs> dragDelta = new Event<System.Windows.UIElement, System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs>(System.Windows.Controls.Primitives.Thumb.DragDeltaEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs> dragCompleted = new Event<System.Windows.UIElement, System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs>(System.Windows.Controls.Primitives.Thumb.DragCompletedEvent);
    }

    public partial class tickBar : frameworkElement
    {
    }

    public partial class toggleButton : buttonBase
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> checked_ = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Primitives.ToggleButton.CheckedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unchecked_ = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Primitives.ToggleButton.UncheckedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> indeterminate = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.Primitives.ToggleButton.IndeterminateEvent);
    }

    public partial class toolBar : headeredItemsControl
    {
    }

    public partial class toolBarOverflowPanel : panel
    {
    }

    public partial class toolBarPanel : stackPanel
    {
    }

    public partial class toolBarTray : frameworkElement
    {
    }

    public partial class toolTip : contentControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> opened = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.ToolTip.OpenedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> closed = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.ToolTip.ClosedEvent);
    }

    public partial class track : frameworkElement
    {
    }

    public partial class treeView : itemsControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>> selectedItemChanged = new Event<System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>>(System.Windows.Controls.TreeView.SelectedItemChangedEvent);
    }

    public partial class treeViewItem : headeredItemsControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> expanded = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.TreeViewItem.ExpandedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> collapsed = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.TreeViewItem.CollapsedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> selected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.TreeViewItem.SelectedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> unselected = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.Controls.TreeViewItem.UnselectedEvent);
    }

    public partial class uIElement
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> previewMouseDown = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.PreviewMouseDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> mouseDown = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.MouseDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> previewMouseUp = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.PreviewMouseUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> mouseUp = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.MouseUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> previewMouseLeftButtonDown = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.PreviewMouseLeftButtonDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> mouseLeftButtonDown = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.MouseLeftButtonDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> previewMouseLeftButtonUp = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.PreviewMouseLeftButtonUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> mouseLeftButtonUp = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.MouseLeftButtonUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> previewMouseRightButtonDown = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.PreviewMouseRightButtonDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> mouseRightButtonDown = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.MouseRightButtonDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> previewMouseRightButtonUp = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.PreviewMouseRightButtonUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> mouseRightButtonUp = new Event<System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(System.Windows.UIElement.MouseRightButtonUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> previewMouseMove = new Event<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(System.Windows.UIElement.PreviewMouseMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> mouseMove = new Event<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(System.Windows.UIElement.MouseMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> previewMouseWheel = new Event<System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(System.Windows.UIElement.PreviewMouseWheelEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> mouseWheel = new Event<System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(System.Windows.UIElement.MouseWheelEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> mouseEnter = new Event<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(System.Windows.UIElement.MouseEnterEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> mouseLeave = new Event<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(System.Windows.UIElement.MouseLeaveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> gotMouseCapture = new Event<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(System.Windows.UIElement.GotMouseCaptureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> lostMouseCapture = new Event<System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(System.Windows.UIElement.LostMouseCaptureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs> queryCursor = new Event<System.Windows.UIElement, System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(System.Windows.UIElement.QueryCursorEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> previewStylusDown = new Event<System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(System.Windows.UIElement.PreviewStylusDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> stylusDown = new Event<System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(System.Windows.UIElement.StylusDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> previewStylusUp = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.PreviewStylusUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> stylusUp = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.StylusUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> previewStylusMove = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.PreviewStylusMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> stylusMove = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.StylusMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> previewStylusInAirMove = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.PreviewStylusInAirMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> stylusInAirMove = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.StylusInAirMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> stylusEnter = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.StylusEnterEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> stylusLeave = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.StylusLeaveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> previewStylusInRange = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.PreviewStylusInRangeEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> stylusInRange = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.StylusInRangeEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> previewStylusOutOfRange = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.PreviewStylusOutOfRangeEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> stylusOutOfRange = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.StylusOutOfRangeEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> previewStylusSystemGesture = new Event<System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(System.Windows.UIElement.PreviewStylusSystemGestureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> stylusSystemGesture = new Event<System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(System.Windows.UIElement.StylusSystemGestureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> gotStylusCapture = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.GotStylusCaptureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> lostStylusCapture = new Event<System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(System.Windows.UIElement.LostStylusCaptureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> stylusButtonDown = new Event<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(System.Windows.UIElement.StylusButtonDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> stylusButtonUp = new Event<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(System.Windows.UIElement.StylusButtonUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> previewStylusButtonDown = new Event<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(System.Windows.UIElement.PreviewStylusButtonDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> previewStylusButtonUp = new Event<System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(System.Windows.UIElement.PreviewStylusButtonUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> previewKeyDown = new Event<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(System.Windows.UIElement.PreviewKeyDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> keyDown = new Event<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(System.Windows.UIElement.KeyDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> previewKeyUp = new Event<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(System.Windows.UIElement.PreviewKeyUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> keyUp = new Event<System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(System.Windows.UIElement.KeyUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> previewGotKeyboardFocus = new Event<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(System.Windows.UIElement.PreviewGotKeyboardFocusEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> gotKeyboardFocus = new Event<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(System.Windows.UIElement.GotKeyboardFocusEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> previewLostKeyboardFocus = new Event<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(System.Windows.UIElement.PreviewLostKeyboardFocusEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> lostKeyboardFocus = new Event<System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(System.Windows.UIElement.LostKeyboardFocusEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> previewTextInput = new Event<System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(System.Windows.UIElement.PreviewTextInputEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> textInput = new Event<System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(System.Windows.UIElement.TextInputEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> previewQueryContinueDrag = new Event<System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(System.Windows.UIElement.PreviewQueryContinueDragEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> queryContinueDrag = new Event<System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(System.Windows.UIElement.QueryContinueDragEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> previewGiveFeedback = new Event<System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(System.Windows.UIElement.PreviewGiveFeedbackEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> giveFeedback = new Event<System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(System.Windows.UIElement.GiveFeedbackEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> previewDragEnter = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.PreviewDragEnterEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> dragEnter = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.DragEnterEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> previewDragOver = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.PreviewDragOverEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> dragOver = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.DragOverEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> previewDragLeave = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.PreviewDragLeaveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> dragLeave = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.DragLeaveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> previewDrop = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.PreviewDropEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> drop = new Event<System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs>(System.Windows.UIElement.DropEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> previewTouchDown = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.PreviewTouchDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> touchDown = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.TouchDownEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> previewTouchMove = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.PreviewTouchMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> touchMove = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.TouchMoveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> previewTouchUp = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.PreviewTouchUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> touchUp = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.TouchUpEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> gotTouchCapture = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.GotTouchCaptureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> lostTouchCapture = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.LostTouchCaptureEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> touchEnter = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.TouchEnterEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> touchLeave = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(System.Windows.UIElement.TouchLeaveEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> gotFocus = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.UIElement.GotFocusEvent);
      public static readonly IEvent<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> lostFocus = new Event<System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(System.Windows.UIElement.LostFocusEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>, System.Windows.Input.ManipulationStartingEventArgs> manipulationStarting = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>, System.Windows.Input.ManipulationStartingEventArgs>(System.Windows.UIElement.ManipulationStartingEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs> manipulationStarted = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs>(System.Windows.UIElement.ManipulationStartedEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs> manipulationDelta = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs>(System.Windows.UIElement.ManipulationDeltaEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>, System.Windows.Input.ManipulationInertiaStartingEventArgs> manipulationInertiaStarting = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>, System.Windows.Input.ManipulationInertiaStartingEventArgs>(System.Windows.UIElement.ManipulationInertiaStartingEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> manipulationBoundaryFeedback = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>(System.Windows.UIElement.ManipulationBoundaryFeedbackEvent);
      public static readonly IEvent<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs> manipulationCompleted = new Event<System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs>(System.Windows.UIElement.ManipulationCompletedEvent);
    }

    public partial class uniformGrid : panel
    {
    }

    public partial class userControl : contentControl
    {
    }

    public partial class webBrowser : activeXHost
    {
    }

    public partial class viewbox : decorator
    {
    }

    public partial class viewport3D : frameworkElement
    {
    }

    public partial class window : contentControl
    {
      public static readonly IEvent<System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> dpiChanged = new Event<System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs>(System.Windows.Window.DpiChangedEvent);
    }

    public partial class virtualizingPanel : panel
    {
    }

    public partial class virtualizingStackPanel : virtualizingPanel
    {
      public static readonly IEvent<System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.CleanUpVirtualizedItemEventHandler, System.Windows.Controls.CleanUpVirtualizedItemEventArgs> cleanUpVirtualizedItem = new Event<System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.CleanUpVirtualizedItemEventHandler, System.Windows.Controls.CleanUpVirtualizedItemEventArgs>(System.Windows.Controls.VirtualizingStackPanel.CleanUpVirtualizedItemEvent);
    }

    public partial class wrapPanel : panel
    {
    }

  }

  public static partial class Controls<TMessage>
  {
    public partial class accessText : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.String> text(System.String v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.String>(Properties.accessText.text, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.FontFamily> fontFamily(System.Windows.Media.FontFamily v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.FontFamily>(Properties.accessText.fontFamily, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.FontStyle> fontStyle(System.Windows.FontStyle v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.FontStyle>(Properties.accessText.fontStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.FontWeight> fontWeight(System.Windows.FontWeight v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.FontWeight>(Properties.accessText.fontWeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.FontStretch> fontStretch(System.Windows.FontStretch v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.FontStretch>(Properties.accessText.fontStretch, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Double> fontSize(System.Double v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Double>(Properties.accessText.fontSize, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.Brush> foreground(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.Brush>(Properties.accessText.foreground, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.Brush>(Properties.accessText.background, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextDecorationCollection> textDecorations(System.Windows.TextDecorationCollection v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextDecorationCollection>(Properties.accessText.textDecorations, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.TextEffectCollection> textEffects(System.Windows.Media.TextEffectCollection v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.Media.TextEffectCollection>(Properties.accessText.textEffects, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Double> lineHeight(System.Double v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Double>(Properties.accessText.lineHeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.LineStackingStrategy> lineStackingStrategy(System.Windows.LineStackingStrategy v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.LineStackingStrategy>(Properties.accessText.lineStackingStrategy, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextAlignment> textAlignment(System.Windows.TextAlignment v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextAlignment>(Properties.accessText.textAlignment, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextTrimming> textTrimming(System.Windows.TextTrimming v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextTrimming>(Properties.accessText.textTrimming, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextWrapping> textWrapping(System.Windows.TextWrapping v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Windows.TextWrapping>(Properties.accessText.textWrapping, v);
      public static ISetValue<TMessage, System.Windows.Controls.AccessText, System.Double> baselineOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.AccessText, System.Double>(Properties.accessText.baselineOffset, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.AccessText>[] vs) => new StandardView<TMessage, System.Windows.Controls.AccessText>(vs);
    }

    public partial class activeXHost : hwndHost
    {


    }

    public partial class adornedElementPlaceholder : frameworkElement
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.AdornedElementPlaceholder>[] vs) => new StandardView<TMessage, System.Windows.Controls.AdornedElementPlaceholder>(vs);
    }

    public partial class adorner : frameworkElement
    {


    }

    public partial class adornerDecorator : decorator
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Documents.AdornerDecorator>[] vs) => new StandardView<TMessage, System.Windows.Documents.AdornerDecorator>(vs);
    }

    public partial class adornerLayer : frameworkElement
    {


    }

    public partial class border : decorator
    {
      public static ISetValue<TMessage, System.Windows.Controls.Border, System.Windows.Thickness> borderThickness(System.Windows.Thickness v) => new SetValue<TMessage, System.Windows.Controls.Border, System.Windows.Thickness>(Properties.border.borderThickness, v);
      public static ISetValue<TMessage, System.Windows.Controls.Border, System.Windows.Thickness> padding(System.Windows.Thickness v) => new SetValue<TMessage, System.Windows.Controls.Border, System.Windows.Thickness>(Properties.border.padding, v);
      public static ISetValue<TMessage, System.Windows.Controls.Border, System.Windows.CornerRadius> cornerRadius(System.Windows.CornerRadius v) => new SetValue<TMessage, System.Windows.Controls.Border, System.Windows.CornerRadius>(Properties.border.cornerRadius, v);
      public static ISetValue<TMessage, System.Windows.Controls.Border, System.Windows.Media.Brush> borderBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Border, System.Windows.Media.Brush>(Properties.border.borderBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.Border, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Border, System.Windows.Media.Brush>(Properties.border.background, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Border>[] vs) => new StandardView<TMessage, System.Windows.Controls.Border>(vs);
    }

    public partial class bulletDecorator : decorator
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.BulletDecorator, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Primitives.BulletDecorator, System.Windows.Media.Brush>(Properties.bulletDecorator.background, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.BulletDecorator>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.BulletDecorator>(vs);
    }

    public partial class button : buttonBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Button, System.Boolean> isDefault(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Button, System.Boolean>(Properties.button.isDefault, v);
      public static ISetValue<TMessage, System.Windows.Controls.Button, System.Boolean> isCancel(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Button, System.Boolean>(Properties.button.isCancel, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Button>[] vs) => new StandardView<TMessage, System.Windows.Controls.Button>(vs);
    }

    public partial class buttonBase : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.Input.ICommand> command(System.Windows.Input.ICommand v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.Input.ICommand>(Properties.buttonBase.command, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Object> commandParameter(System.Object v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Object>(Properties.buttonBase.commandParameter, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.IInputElement> commandTarget(System.Windows.IInputElement v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.IInputElement>(Properties.buttonBase.commandTarget, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.Controls.ClickMode> clickMode(System.Windows.Controls.ClickMode v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.Controls.ClickMode>(Properties.buttonBase.clickMode, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onClick (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.buttonBase.click, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

    }

    public partial class calendar : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Style> calendarButtonStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Style>(Properties.calendar.calendarButtonStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Style> calendarDayButtonStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Style>(Properties.calendar.calendarDayButtonStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Style> calendarItemStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Style>(Properties.calendar.calendarItemStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.DateTime> displayDate(System.DateTime v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.DateTime>(Properties.calendar.displayDate, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Nullable<System.DateTime>> displayDateEnd(System.Nullable<System.DateTime> v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Nullable<System.DateTime>>(Properties.calendar.displayDateEnd, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Nullable<System.DateTime>> displayDateStart(System.Nullable<System.DateTime> v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Nullable<System.DateTime>>(Properties.calendar.displayDateStart, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Controls.CalendarMode> displayMode(System.Windows.Controls.CalendarMode v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Controls.CalendarMode>(Properties.calendar.displayMode, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.DayOfWeek> firstDayOfWeek(System.DayOfWeek v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.DayOfWeek>(Properties.calendar.firstDayOfWeek, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Boolean> isTodayHighlighted(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Boolean>(Properties.calendar.isTodayHighlighted, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Nullable<System.DateTime>> selectedDate(System.Nullable<System.DateTime> v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Nullable<System.DateTime>>(Properties.calendar.selectedDate, v);
      public static ISetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Controls.CalendarSelectionMode> selectionMode(System.Windows.Controls.CalendarSelectionMode v) => new SetValue<TMessage, System.Windows.Controls.Calendar, System.Windows.Controls.CalendarSelectionMode>(Properties.calendar.selectionMode, v);

      public static IOnChangedValue<TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> onSelectedDatesChanged (OnChange<TMessage, System.Windows.Controls.Calendar, System.Windows.Controls.SelectionChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> (Events.calendar.selectedDatesChanged, h => (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Calendar>[] vs) => new StandardView<TMessage, System.Windows.Controls.Calendar>(vs);
    }

    public partial class calendarButton : button
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.CalendarButton>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.CalendarButton>(vs);
    }

    public partial class calendarDayButton : button
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.CalendarDayButton>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.CalendarDayButton>(vs);
    }

    public partial class calendarItem : control
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.CalendarItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.CalendarItem>(vs);
    }

    public partial class canvas : panel
    {
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> left(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.canvas.left, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> top(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.canvas.top, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> right(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.canvas.right, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> bottom(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.canvas.bottom, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Canvas>[] vs) => new StandardView<TMessage, System.Windows.Controls.Canvas>(vs);
    }

    public partial class checkBox : toggleButton
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.CheckBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.CheckBox>(vs);
    }

    public partial class comboBox : selector
    {
      public static ISetValue<TMessage, System.Windows.Controls.ComboBox, System.Double> maxDropDownHeight(System.Double v) => new SetValue<TMessage, System.Windows.Controls.ComboBox, System.Double>(Properties.comboBox.maxDropDownHeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean> isDropDownOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean>(Properties.comboBox.isDropDownOpen, v);
      public static ISetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean> shouldPreserveUserEnteredPrefix(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean>(Properties.comboBox.shouldPreserveUserEnteredPrefix, v);
      public static ISetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean> isEditable(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean>(Properties.comboBox.isEditable, v);
      public static ISetValue<TMessage, System.Windows.Controls.ComboBox, System.String> text(System.String v) => new SetValue<TMessage, System.Windows.Controls.ComboBox, System.String>(Properties.comboBox.text, v);
      public static ISetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean> isReadOnly(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean>(Properties.comboBox.isReadOnly, v);
      public static ISetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean> staysOpenOnEdit(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ComboBox, System.Boolean>(Properties.comboBox.staysOpenOnEdit, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ComboBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.ComboBox>(vs);
    }

    public partial class comboBoxItem : listBoxItem
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ComboBoxItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.ComboBoxItem>(vs);
    }

    public partial class contentControl : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.ContentControl, System.Object> content(System.Object v) => new SetValue<TMessage, System.Windows.Controls.ContentControl, System.Object>(Properties.contentControl.content, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentControl, System.Windows.DataTemplate> contentTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.ContentControl, System.Windows.DataTemplate>(Properties.contentControl.contentTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentControl, System.Windows.Controls.DataTemplateSelector> contentTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.ContentControl, System.Windows.Controls.DataTemplateSelector>(Properties.contentControl.contentTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentControl, System.String> contentStringFormat(System.String v) => new SetValue<TMessage, System.Windows.Controls.ContentControl, System.String>(Properties.contentControl.contentStringFormat, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ContentControl>[] vs) => new StandardView<TMessage, System.Windows.Controls.ContentControl>(vs);
    }

    public partial class contentPresenter : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Boolean> recognizesAccessKey(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Boolean>(Properties.contentPresenter.recognizesAccessKey, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Object> content(System.Object v) => new SetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Object>(Properties.contentPresenter.content, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Windows.DataTemplate> contentTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Windows.DataTemplate>(Properties.contentPresenter.contentTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Windows.Controls.DataTemplateSelector> contentTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.ContentPresenter, System.Windows.Controls.DataTemplateSelector>(Properties.contentPresenter.contentTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentPresenter, System.String> contentStringFormat(System.String v) => new SetValue<TMessage, System.Windows.Controls.ContentPresenter, System.String>(Properties.contentPresenter.contentStringFormat, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContentPresenter, System.String> contentSource(System.String v) => new SetValue<TMessage, System.Windows.Controls.ContentPresenter, System.String>(Properties.contentPresenter.contentSource, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ContentPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.ContentPresenter>(vs);
    }

    public partial class contextMenu : menuBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Double> horizontalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Double>(Properties.contextMenu.horizontalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Double> verticalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Double>(Properties.contextMenu.verticalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Boolean> isOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Boolean>(Properties.contextMenu.isOpen, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.UIElement> placementTarget(System.Windows.UIElement v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.UIElement>(Properties.contextMenu.placementTarget, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.Rect> placementRectangle(System.Windows.Rect v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.Rect>(Properties.contextMenu.placementRectangle, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.PlacementMode> placement(System.Windows.Controls.Primitives.PlacementMode v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.PlacementMode>(Properties.contextMenu.placement, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Boolean> hasDropShadow(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Boolean>(Properties.contextMenu.hasDropShadow, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.CustomPopupPlacementCallback> customPopupPlacementCallback(System.Windows.Controls.Primitives.CustomPopupPlacementCallback v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Windows.Controls.Primitives.CustomPopupPlacementCallback>(Properties.contextMenu.customPopupPlacementCallback, v);
      public static ISetValue<TMessage, System.Windows.Controls.ContextMenu, System.Boolean> staysOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ContextMenu, System.Boolean>(Properties.contextMenu.staysOpen, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onOpened (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.contextMenu.opened, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onClosed (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.contextMenu.closed, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ContextMenu>[] vs) => new StandardView<TMessage, System.Windows.Controls.ContextMenu>(vs);
    }

    public partial class control : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.Brush> borderBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.Brush>(Properties.control.borderBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.Thickness> borderThickness(System.Windows.Thickness v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.Thickness>(Properties.control.borderThickness, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.Brush>(Properties.control.background, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.Brush> foreground(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.Brush>(Properties.control.foreground, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.FontFamily> fontFamily(System.Windows.Media.FontFamily v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.Media.FontFamily>(Properties.control.fontFamily, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Double> fontSize(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Double>(Properties.control.fontSize, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.FontStretch> fontStretch(System.Windows.FontStretch v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.FontStretch>(Properties.control.fontStretch, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.FontStyle> fontStyle(System.Windows.FontStyle v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.FontStyle>(Properties.control.fontStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.FontWeight> fontWeight(System.Windows.FontWeight v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.FontWeight>(Properties.control.fontWeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.HorizontalAlignment> horizontalContentAlignment(System.Windows.HorizontalAlignment v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.HorizontalAlignment>(Properties.control.horizontalContentAlignment, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.VerticalAlignment> verticalContentAlignment(System.Windows.VerticalAlignment v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.VerticalAlignment>(Properties.control.verticalContentAlignment, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Int32> tabIndex(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Int32>(Properties.control.tabIndex, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Boolean> isTabStop(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Boolean>(Properties.control.isTabStop, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.Thickness> padding(System.Windows.Thickness v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.Thickness>(Properties.control.padding, v);
      public static ISetValue<TMessage, System.Windows.Controls.Control, System.Windows.Controls.ControlTemplate> template(System.Windows.Controls.ControlTemplate v) => new SetValue<TMessage, System.Windows.Controls.Control, System.Windows.Controls.ControlTemplate>(Properties.control.template, v);

      public static IOnChangedValue<TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onPreviewMouseDoubleClick (OnChange<TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.control.previewMouseDoubleClick, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onMouseDoubleClick (OnChange<TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.control.mouseDoubleClick, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Control>[] vs) => new StandardView<TMessage, System.Windows.Controls.Control>(vs);
    }

    public partial class dataGrid : multiSelector
    {
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> canUserResizeColumns(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.canUserResizeColumns, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridLength> columnWidth(System.Windows.Controls.DataGridLength v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridLength>(Properties.dataGrid.columnWidth, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Double> minColumnWidth(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Double>(Properties.dataGrid.minColumnWidth, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Double> maxColumnWidth(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Double>(Properties.dataGrid.maxColumnWidth, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridGridLinesVisibility> gridLinesVisibility(System.Windows.Controls.DataGridGridLinesVisibility v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridGridLinesVisibility>(Properties.dataGrid.gridLinesVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush> horizontalGridLinesBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(Properties.dataGrid.horizontalGridLinesBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush> verticalGridLinesBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(Properties.dataGrid.verticalGridLinesBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style> rowStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style>(Properties.dataGrid.rowStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.ControlTemplate> rowValidationErrorTemplate(System.Windows.Controls.ControlTemplate v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.ControlTemplate>(Properties.dataGrid.rowValidationErrorTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.StyleSelector> rowStyleSelector(System.Windows.Controls.StyleSelector v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.StyleSelector>(Properties.dataGrid.rowStyleSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush> rowBackground(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(Properties.dataGrid.rowBackground, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush> alternatingRowBackground(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Media.Brush>(Properties.dataGrid.alternatingRowBackground, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Double> rowHeight(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Double>(Properties.dataGrid.rowHeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Double> minRowHeight(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Double>(Properties.dataGrid.minRowHeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Double> rowHeaderWidth(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Double>(Properties.dataGrid.rowHeaderWidth, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Double> columnHeaderHeight(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Double>(Properties.dataGrid.columnHeaderHeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridHeadersVisibility> headersVisibility(System.Windows.Controls.DataGridHeadersVisibility v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridHeadersVisibility>(Properties.dataGrid.headersVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style> cellStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style>(Properties.dataGrid.cellStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style> columnHeaderStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style>(Properties.dataGrid.columnHeaderStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style> rowHeaderStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style>(Properties.dataGrid.rowHeaderStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.DataTemplate> rowHeaderTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.DataTemplate>(Properties.dataGrid.rowHeaderTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector> rowHeaderTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector>(Properties.dataGrid.rowHeaderTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility>(Properties.dataGrid.horizontalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.ScrollBarVisibility>(Properties.dataGrid.verticalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> isReadOnly(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.isReadOnly, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Object> currentItem(System.Object v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Object>(Properties.dataGrid.currentItem, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridColumn> currentColumn(System.Windows.Controls.DataGridColumn v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridColumn>(Properties.dataGrid.currentColumn, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridCellInfo> currentCell(System.Windows.Controls.DataGridCellInfo v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridCellInfo>(Properties.dataGrid.currentCell, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> canUserAddRows(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.canUserAddRows, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> canUserDeleteRows(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.canUserDeleteRows, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridRowDetailsVisibilityMode> rowDetailsVisibilityMode(System.Windows.Controls.DataGridRowDetailsVisibilityMode v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridRowDetailsVisibilityMode>(Properties.dataGrid.rowDetailsVisibilityMode, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> areRowDetailsFrozen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.areRowDetailsFrozen, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.DataTemplate> rowDetailsTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.DataTemplate>(Properties.dataGrid.rowDetailsTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector> rowDetailsTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataTemplateSelector>(Properties.dataGrid.rowDetailsTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> canUserResizeRows(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.canUserResizeRows, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionMode> selectionMode(System.Windows.Controls.DataGridSelectionMode v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionMode>(Properties.dataGrid.selectionMode, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionUnit> selectionUnit(System.Windows.Controls.DataGridSelectionUnit v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSelectionUnit>(Properties.dataGrid.selectionUnit, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> canUserSortColumns(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.canUserSortColumns, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> autoGenerateColumns(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.autoGenerateColumns, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Int32> frozenColumnCount(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Int32>(Properties.dataGrid.frozenColumnCount, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> enableRowVirtualization(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.enableRowVirtualization, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> enableColumnVirtualization(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.enableColumnVirtualization, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean> canUserReorderColumns(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Boolean>(Properties.dataGrid.canUserReorderColumns, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style> dragIndicatorStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style>(Properties.dataGrid.dragIndicatorStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style> dropLocationIndicatorStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Style>(Properties.dataGrid.dropLocationIndicatorStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridClipboardCopyMode> clipboardCopyMode(System.Windows.Controls.DataGridClipboardCopyMode v) => new SetValue<TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridClipboardCopyMode>(Properties.dataGrid.clipboardCopyMode, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.DataGrid>[] vs) => new StandardView<TMessage, System.Windows.Controls.DataGrid>(vs);
    }

    public partial class dataGridCell : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.DataGridCell, System.Boolean> isEditing(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGridCell, System.Boolean>(Properties.dataGridCell.isEditing, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridCell, System.Boolean> isSelected(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGridCell, System.Boolean>(Properties.dataGridCell.isSelected, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSelected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.dataGridCell.selected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnselected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.dataGridCell.unselected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.DataGridCell>[] vs) => new StandardView<TMessage, System.Windows.Controls.DataGridCell>(vs);
    }

    public partial class dataGridCellsPanel : virtualizingPanel
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.DataGridCellsPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.DataGridCellsPanel>(vs);
    }

    public partial class dataGridCellsPresenter : itemsControl
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DataGridCellsPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DataGridCellsPresenter>(vs);
    }

    public partial class dataGridColumnHeader : buttonBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Media.Brush> separatorBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Media.Brush>(Properties.dataGridColumnHeader.separatorBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Visibility> separatorVisibility(System.Windows.Visibility v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeader, System.Windows.Visibility>(Properties.dataGridColumnHeader.separatorVisibility, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeader>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeader>(vs);
    }

    public partial class dataGridColumnHeadersPresenter : itemsControl
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter>(vs);
    }

    public partial class dataGridDetailsPresenter : contentPresenter
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DataGridDetailsPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DataGridDetailsPresenter>(vs);
    }

    public partial class dataGridRow : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Object> item(System.Object v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Object>(Properties.dataGridRow.item, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.ItemsPanelTemplate> itemsPanel(System.Windows.Controls.ItemsPanelTemplate v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.ItemsPanelTemplate>(Properties.dataGridRow.itemsPanel, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Object> header(System.Object v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Object>(Properties.dataGridRow.header, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Style> headerStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Style>(Properties.dataGridRow.headerStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.DataTemplate> headerTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.DataTemplate>(Properties.dataGridRow.headerTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector> headerTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector>(Properties.dataGridRow.headerTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.ControlTemplate> validationErrorTemplate(System.Windows.Controls.ControlTemplate v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.ControlTemplate>(Properties.dataGridRow.validationErrorTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.DataTemplate> detailsTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.DataTemplate>(Properties.dataGridRow.detailsTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector> detailsTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Controls.DataTemplateSelector>(Properties.dataGridRow.detailsTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Visibility> detailsVisibility(System.Windows.Visibility v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Windows.Visibility>(Properties.dataGridRow.detailsVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.DataGridRow, System.Boolean> isSelected(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DataGridRow, System.Boolean>(Properties.dataGridRow.isSelected, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSelected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.dataGridRow.selected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnselected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.dataGridRow.unselected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.DataGridRow>[] vs) => new StandardView<TMessage, System.Windows.Controls.DataGridRow>(vs);
    }

    public partial class dataGridRowHeader : buttonBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Media.Brush> separatorBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Media.Brush>(Properties.dataGridRowHeader.separatorBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Visibility> separatorVisibility(System.Windows.Visibility v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DataGridRowHeader, System.Windows.Visibility>(Properties.dataGridRowHeader.separatorVisibility, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DataGridRowHeader>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DataGridRowHeader>(vs);
    }

    public partial class dataGridRowsPresenter : virtualizingStackPanel
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DataGridRowsPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DataGridRowsPresenter>(vs);
    }

    public partial class datePicker : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.Windows.Style> calendarStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.Windows.Style>(Properties.datePicker.calendarStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.DateTime> displayDate(System.DateTime v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.DateTime>(Properties.datePicker.displayDate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>> displayDateEnd(System.Nullable<System.DateTime> v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>>(Properties.datePicker.displayDateEnd, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>> displayDateStart(System.Nullable<System.DateTime> v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>>(Properties.datePicker.displayDateStart, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.DayOfWeek> firstDayOfWeek(System.DayOfWeek v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.DayOfWeek>(Properties.datePicker.firstDayOfWeek, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.Boolean> isDropDownOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.Boolean>(Properties.datePicker.isDropDownOpen, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.Boolean> isTodayHighlighted(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.Boolean>(Properties.datePicker.isTodayHighlighted, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>> selectedDate(System.Nullable<System.DateTime> v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.Nullable<System.DateTime>>(Properties.datePicker.selectedDate, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.Windows.Controls.DatePickerFormat> selectedDateFormat(System.Windows.Controls.DatePickerFormat v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.Windows.Controls.DatePickerFormat>(Properties.datePicker.selectedDateFormat, v);
      public static ISetValue<TMessage, System.Windows.Controls.DatePicker, System.String> text(System.String v) => new SetValue<TMessage, System.Windows.Controls.DatePicker, System.String>(Properties.datePicker.text, v);

      public static IOnChangedValue<TMessage, System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> onSelectedDateChanged (OnChange<TMessage, System.Windows.Controls.DatePicker, System.Windows.Controls.SelectionChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> (Events.datePicker.selectedDateChanged, h => (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.DatePicker>[] vs) => new StandardView<TMessage, System.Windows.Controls.DatePicker>(vs);
    }

    public partial class datePickerTextBox : textBox
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DatePickerTextBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DatePickerTextBox>(vs);
    }

    public partial class decorator : frameworkElement
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Decorator>[] vs) => new StandardView<TMessage, System.Windows.Controls.Decorator>(vs);
    }

    public partial class dockPanel : panel
    {
      public static ISetValue<TMessage, System.Windows.Controls.DockPanel, System.Boolean> lastChildFill(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DockPanel, System.Boolean>(Properties.dockPanel.lastChildFill, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Dock> dock(System.Windows.Controls.Dock v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Dock>(Properties.dockPanel.dock, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.DockPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.DockPanel>(vs);
    }

    public partial class documentPageView : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.Int32> pageNumber(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.Int32>(Properties.documentPageView.pageNumber, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Media.Stretch> stretch(System.Windows.Media.Stretch v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Media.Stretch>(Properties.documentPageView.stretch, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Controls.StretchDirection> stretchDirection(System.Windows.Controls.StretchDirection v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.Windows.Controls.StretchDirection>(Properties.documentPageView.stretchDirection, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.DocumentPageView>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.DocumentPageView>(vs);
    }

    public partial class documentReference : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Documents.DocumentReference, System.Uri> source(System.Uri v) => new SetValue<TMessage, System.Windows.Documents.DocumentReference, System.Uri>(Properties.documentReference.source, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Documents.DocumentReference>[] vs) => new StandardView<TMessage, System.Windows.Documents.DocumentReference>(vs);
    }

    public partial class documentViewer : documentViewerBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double> horizontalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double>(Properties.documentViewer.horizontalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double> verticalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double>(Properties.documentViewer.verticalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Boolean> showPageBorders(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Boolean>(Properties.documentViewer.showPageBorders, v);
      public static ISetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double> zoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double>(Properties.documentViewer.zoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Int32> maxPagesAcross(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Int32>(Properties.documentViewer.maxPagesAcross, v);
      public static ISetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double> verticalPageSpacing(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double>(Properties.documentViewer.verticalPageSpacing, v);
      public static ISetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double> horizontalPageSpacing(System.Double v) => new SetValue<TMessage, System.Windows.Controls.DocumentViewer, System.Double>(Properties.documentViewer.horizontalPageSpacing, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.DocumentViewer>[] vs) => new StandardView<TMessage, System.Windows.Controls.DocumentViewer>(vs);
    }

    public partial class documentViewerBase : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.DocumentViewerBase, System.Windows.Documents.IDocumentPaginatorSource> document(System.Windows.Documents.IDocumentPaginatorSource v) => new SetValue<TMessage, System.Windows.Controls.Primitives.DocumentViewerBase, System.Windows.Documents.IDocumentPaginatorSource>(Properties.documentViewerBase.document, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isMasterPage(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.documentViewerBase.isMasterPage, v);


    }

    public partial class ellipse : shape
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Shapes.Ellipse>[] vs) => new StandardView<TMessage, System.Windows.Shapes.Ellipse>(vs);
    }

    public partial class expander : headeredContentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.Expander, System.Windows.Controls.ExpandDirection> expandDirection(System.Windows.Controls.ExpandDirection v) => new SetValue<TMessage, System.Windows.Controls.Expander, System.Windows.Controls.ExpandDirection>(Properties.expander.expandDirection, v);
      public static ISetValue<TMessage, System.Windows.Controls.Expander, System.Boolean> isExpanded(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Expander, System.Boolean>(Properties.expander.isExpanded, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onExpanded (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.expander.expanded, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onCollapsed (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.expander.collapsed, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Expander>[] vs) => new StandardView<TMessage, System.Windows.Controls.Expander>(vs);
    }

    public partial class fixedPage : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Documents.FixedPage, System.Object> printTicket(System.Object v) => new SetValue<TMessage, System.Windows.Documents.FixedPage, System.Object>(Properties.fixedPage.printTicket, v);
      public static ISetValue<TMessage, System.Windows.Documents.FixedPage, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Documents.FixedPage, System.Windows.Media.Brush>(Properties.fixedPage.background, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> left(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.fixedPage.left, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> top(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.fixedPage.top, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> right(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.fixedPage.right, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> bottom(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.fixedPage.bottom, v);
      public static ISetValue<TMessage, System.Windows.Documents.FixedPage, System.Windows.Rect> contentBox(System.Windows.Rect v) => new SetValue<TMessage, System.Windows.Documents.FixedPage, System.Windows.Rect>(Properties.fixedPage.contentBox, v);
      public static ISetValue<TMessage, System.Windows.Documents.FixedPage, System.Windows.Rect> bleedBox(System.Windows.Rect v) => new SetValue<TMessage, System.Windows.Documents.FixedPage, System.Windows.Rect>(Properties.fixedPage.bleedBox, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Uri> navigateUri(System.Uri v) => new SetValue<TMessage, System.Windows.UIElement, System.Uri>(Properties.fixedPage.navigateUri, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Documents.FixedPage>[] vs) => new StandardView<TMessage, System.Windows.Documents.FixedPage>(vs);
    }

    public partial class flowDocumentPageViewer : documentViewerBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double> zoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double>(Properties.flowDocumentPageViewer.zoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double> maxZoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double>(Properties.flowDocumentPageViewer.maxZoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double> minZoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double>(Properties.flowDocumentPageViewer.minZoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double> zoomIncrement(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double>(Properties.flowDocumentPageViewer.zoomIncrement, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Windows.Media.Brush> selectionBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Windows.Media.Brush>(Properties.flowDocumentPageViewer.selectionBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double> selectionOpacity(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Double>(Properties.flowDocumentPageViewer.selectionOpacity, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Boolean> isInactiveSelectionHighlightEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer, System.Boolean>(Properties.flowDocumentPageViewer.isInactiveSelectionHighlightEnabled, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.FlowDocumentPageViewer>[] vs) => new StandardView<TMessage, System.Windows.Controls.FlowDocumentPageViewer>(vs);
    }

    public partial class flowDocumentReader : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Windows.Controls.FlowDocumentReaderViewingMode> viewingMode(System.Windows.Controls.FlowDocumentReaderViewingMode v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Windows.Controls.FlowDocumentReaderViewingMode>(Properties.flowDocumentReader.viewingMode, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean> isPageViewEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean>(Properties.flowDocumentReader.isPageViewEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean> isTwoPageViewEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean>(Properties.flowDocumentReader.isTwoPageViewEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean> isScrollViewEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean>(Properties.flowDocumentReader.isScrollViewEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean> isFindEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean>(Properties.flowDocumentReader.isFindEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean> isPrintEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean>(Properties.flowDocumentReader.isPrintEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Windows.Documents.FlowDocument> document(System.Windows.Documents.FlowDocument v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Windows.Documents.FlowDocument>(Properties.flowDocumentReader.document, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double> zoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double>(Properties.flowDocumentReader.zoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double> maxZoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double>(Properties.flowDocumentReader.maxZoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double> minZoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double>(Properties.flowDocumentReader.minZoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double> zoomIncrement(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double>(Properties.flowDocumentReader.zoomIncrement, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Windows.Media.Brush> selectionBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Windows.Media.Brush>(Properties.flowDocumentReader.selectionBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double> selectionOpacity(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Double>(Properties.flowDocumentReader.selectionOpacity, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean> isInactiveSelectionHighlightEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentReader, System.Boolean>(Properties.flowDocumentReader.isInactiveSelectionHighlightEnabled, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.FlowDocumentReader>[] vs) => new StandardView<TMessage, System.Windows.Controls.FlowDocumentReader>(vs);
    }

    public partial class flowDocumentScrollViewer : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Documents.FlowDocument> document(System.Windows.Documents.FlowDocument v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Documents.FlowDocument>(Properties.flowDocumentScrollViewer.document, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double> zoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(Properties.flowDocumentScrollViewer.zoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double> maxZoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(Properties.flowDocumentScrollViewer.maxZoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double> minZoom(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(Properties.flowDocumentScrollViewer.minZoom, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double> zoomIncrement(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(Properties.flowDocumentScrollViewer.zoomIncrement, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean> isSelectionEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean>(Properties.flowDocumentScrollViewer.isSelectionEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean> isToolBarVisible(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean>(Properties.flowDocumentScrollViewer.isToolBarVisible, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility>(Properties.flowDocumentScrollViewer.horizontalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Controls.ScrollBarVisibility>(Properties.flowDocumentScrollViewer.verticalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Media.Brush> selectionBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Windows.Media.Brush>(Properties.flowDocumentScrollViewer.selectionBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double> selectionOpacity(System.Double v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Double>(Properties.flowDocumentScrollViewer.selectionOpacity, v);
      public static ISetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean> isInactiveSelectionHighlightEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer, System.Boolean>(Properties.flowDocumentScrollViewer.isInactiveSelectionHighlightEnabled, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.FlowDocumentScrollViewer>[] vs) => new StandardView<TMessage, System.Windows.Controls.FlowDocumentScrollViewer>(vs);
    }

    public partial class frame : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.Frame, System.Uri> source(System.Uri v) => new SetValue<TMessage, System.Windows.Controls.Frame, System.Uri>(Properties.frame.source, v);
      public static ISetValue<TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationUIVisibility> navigationUIVisibility(System.Windows.Navigation.NavigationUIVisibility v) => new SetValue<TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationUIVisibility>(Properties.frame.navigationUIVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.Frame, System.Boolean> sandboxExternalContent(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Frame, System.Boolean>(Properties.frame.sandboxExternalContent, v);
      public static ISetValue<TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.JournalOwnership> journalOwnership(System.Windows.Navigation.JournalOwnership v) => new SetValue<TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.JournalOwnership>(Properties.frame.journalOwnership, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Frame>[] vs) => new StandardView<TMessage, System.Windows.Controls.Frame>(vs);
    }

    public partial class frameworkElement : uIElement
    {
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Style> style(System.Windows.Style v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Style>(Properties.frameworkElement.style, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Boolean> overridesDefaultStyle(System.Boolean v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Boolean>(Properties.frameworkElement.overridesDefaultStyle, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Boolean> useLayoutRounding(System.Boolean v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Boolean>(Properties.frameworkElement.useLayoutRounding, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Object> dataContext(System.Object v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Object>(Properties.frameworkElement.dataContext, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Data.BindingGroup> bindingGroup(System.Windows.Data.BindingGroup v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Data.BindingGroup>(Properties.frameworkElement.bindingGroup, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Markup.XmlLanguage> language(System.Windows.Markup.XmlLanguage v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Markup.XmlLanguage>(Properties.frameworkElement.language, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.String> name(System.String v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.String>(Properties.frameworkElement.name, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Object> tag(System.Object v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Object>(Properties.frameworkElement.tag, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Input.InputScope> inputScope(System.Windows.Input.InputScope v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Input.InputScope>(Properties.frameworkElement.inputScope, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Media.Transform> layoutTransform(System.Windows.Media.Transform v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Media.Transform>(Properties.frameworkElement.layoutTransform, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Double> width(System.Double v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Double>(Properties.frameworkElement.width, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Double> minWidth(System.Double v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Double>(Properties.frameworkElement.minWidth, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Double> maxWidth(System.Double v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Double>(Properties.frameworkElement.maxWidth, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Double> height(System.Double v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Double>(Properties.frameworkElement.height, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Double> minHeight(System.Double v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Double>(Properties.frameworkElement.minHeight, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Double> maxHeight(System.Double v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Double>(Properties.frameworkElement.maxHeight, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.FlowDirection> flowDirection(System.Windows.FlowDirection v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.FlowDirection>(Properties.frameworkElement.flowDirection, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Thickness> margin(System.Windows.Thickness v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Thickness>(Properties.frameworkElement.margin, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.HorizontalAlignment> horizontalAlignment(System.Windows.HorizontalAlignment v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.HorizontalAlignment>(Properties.frameworkElement.horizontalAlignment, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.VerticalAlignment> verticalAlignment(System.Windows.VerticalAlignment v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.VerticalAlignment>(Properties.frameworkElement.verticalAlignment, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Style> focusVisualStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Style>(Properties.frameworkElement.focusVisualStyle, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Input.Cursor> cursor(System.Windows.Input.Cursor v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Input.Cursor>(Properties.frameworkElement.cursor, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Boolean> forceCursor(System.Boolean v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Boolean>(Properties.frameworkElement.forceCursor, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Object> toolTip(System.Object v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Object>(Properties.frameworkElement.toolTip, v);
      public static ISetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ContextMenu> contextMenu(System.Windows.Controls.ContextMenu v) => new SetValue<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ContextMenu>(Properties.frameworkElement.contextMenu, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs> onRequestBringIntoView (OnChange<TMessage, System.Windows.UIElement, System.Windows.RequestBringIntoViewEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs> (Events.frameworkElement.requestBringIntoView, h => (System.Windows.RequestBringIntoViewEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs> onSizeChanged (OnChange<TMessage, System.Windows.FrameworkElement, System.Windows.SizeChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs> (Events.frameworkElement.sizeChanged, h => (System.Windows.SizeChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onLoaded (OnChange<TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.frameworkElement.loaded, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnloaded (OnChange<TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.frameworkElement.unloaded, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> onToolTipOpening (OnChange<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> (Events.frameworkElement.toolTipOpening, h => (System.Windows.Controls.ToolTipEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> onToolTipClosing (OnChange<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> (Events.frameworkElement.toolTipClosing, h => (System.Windows.Controls.ToolTipEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> onContextMenuOpening (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.ContextMenuEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> (Events.frameworkElement.contextMenuOpening, h => (System.Windows.Controls.ContextMenuEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> onContextMenuClosing (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.ContextMenuEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> (Events.frameworkElement.contextMenuClosing, h => (System.Windows.Controls.ContextMenuEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.FrameworkElement>[] vs) => new StandardView<TMessage, System.Windows.FrameworkElement>(vs);
    }

    public partial class glyphs : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Windows.Media.Brush> fill(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Windows.Media.Brush>(Properties.glyphs.fill, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.String> indices(System.String v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.String>(Properties.glyphs.indices, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.String> unicodeString(System.String v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.String>(Properties.glyphs.unicodeString, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.String> caretStops(System.String v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.String>(Properties.glyphs.caretStops, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Double> fontRenderingEmSize(System.Double v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Double>(Properties.glyphs.fontRenderingEmSize, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Double> originX(System.Double v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Double>(Properties.glyphs.originX, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Double> originY(System.Double v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Double>(Properties.glyphs.originY, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Uri> fontUri(System.Uri v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Uri>(Properties.glyphs.fontUri, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Windows.Media.StyleSimulations> styleSimulations(System.Windows.Media.StyleSimulations v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Windows.Media.StyleSimulations>(Properties.glyphs.styleSimulations, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Boolean> isSideways(System.Boolean v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Boolean>(Properties.glyphs.isSideways, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.Int32> bidiLevel(System.Int32 v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.Int32>(Properties.glyphs.bidiLevel, v);
      public static ISetValue<TMessage, System.Windows.Documents.Glyphs, System.String> deviceFontName(System.String v) => new SetValue<TMessage, System.Windows.Documents.Glyphs, System.String>(Properties.glyphs.deviceFontName, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Documents.Glyphs>[] vs) => new StandardView<TMessage, System.Windows.Documents.Glyphs>(vs);
    }

    public partial class grid : panel
    {
      public static ISetValue<TMessage, System.Windows.Controls.Grid, System.Boolean> showGridLines(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Grid, System.Boolean>(Properties.grid.showGridLines, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Int32> column(System.Int32 v) => new SetValue<TMessage, System.Windows.UIElement, System.Int32>(Properties.grid.column, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Int32> row(System.Int32 v) => new SetValue<TMessage, System.Windows.UIElement, System.Int32>(Properties.grid.row, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Int32> columnSpan(System.Int32 v) => new SetValue<TMessage, System.Windows.UIElement, System.Int32>(Properties.grid.columnSpan, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Int32> rowSpan(System.Int32 v) => new SetValue<TMessage, System.Windows.UIElement, System.Int32>(Properties.grid.rowSpan, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isSharedSizeScope(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.grid.isSharedSizeScope, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Grid>[] vs) => new StandardView<TMessage, System.Windows.Controls.Grid>(vs);
    }

    public partial class gridSplitter : thumb
    {
      public static ISetValue<TMessage, System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeDirection> resizeDirection(System.Windows.Controls.GridResizeDirection v) => new SetValue<TMessage, System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeDirection>(Properties.gridSplitter.resizeDirection, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeBehavior> resizeBehavior(System.Windows.Controls.GridResizeBehavior v) => new SetValue<TMessage, System.Windows.Controls.GridSplitter, System.Windows.Controls.GridResizeBehavior>(Properties.gridSplitter.resizeBehavior, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridSplitter, System.Boolean> showsPreview(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.GridSplitter, System.Boolean>(Properties.gridSplitter.showsPreview, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridSplitter, System.Windows.Style> previewStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.GridSplitter, System.Windows.Style>(Properties.gridSplitter.previewStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridSplitter, System.Double> keyboardIncrement(System.Double v) => new SetValue<TMessage, System.Windows.Controls.GridSplitter, System.Double>(Properties.gridSplitter.keyboardIncrement, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridSplitter, System.Double> dragIncrement(System.Double v) => new SetValue<TMessage, System.Windows.Controls.GridSplitter, System.Double>(Properties.gridSplitter.dragIncrement, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.GridSplitter>[] vs) => new StandardView<TMessage, System.Windows.Controls.GridSplitter>(vs);
    }

    public partial class gridViewColumnHeader : buttonBase
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.GridViewColumnHeader>[] vs) => new StandardView<TMessage, System.Windows.Controls.GridViewColumnHeader>(vs);
    }

    public partial class gridViewHeaderRowPresenter : gridViewRowPresenterBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Style> columnHeaderContainerStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Style>(Properties.gridViewHeaderRowPresenter.columnHeaderContainerStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.DataTemplate> columnHeaderTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.DataTemplate>(Properties.gridViewHeaderRowPresenter.columnHeaderTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.DataTemplateSelector> columnHeaderTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.DataTemplateSelector>(Properties.gridViewHeaderRowPresenter.columnHeaderTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.String> columnHeaderStringFormat(System.String v) => new SetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.String>(Properties.gridViewHeaderRowPresenter.columnHeaderStringFormat, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Boolean> allowsColumnReorder(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Boolean>(Properties.gridViewHeaderRowPresenter.allowsColumnReorder, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.ContextMenu> columnHeaderContextMenu(System.Windows.Controls.ContextMenu v) => new SetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Windows.Controls.ContextMenu>(Properties.gridViewHeaderRowPresenter.columnHeaderContextMenu, v);
      public static ISetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Object> columnHeaderToolTip(System.Object v) => new SetValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter, System.Object>(Properties.gridViewHeaderRowPresenter.columnHeaderToolTip, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.GridViewHeaderRowPresenter>(vs);
    }

    public partial class gridViewRowPresenter : gridViewRowPresenterBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.GridViewRowPresenter, System.Object> content(System.Object v) => new SetValue<TMessage, System.Windows.Controls.GridViewRowPresenter, System.Object>(Properties.gridViewRowPresenter.content, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.GridViewRowPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.GridViewRowPresenter>(vs);
    }

    public partial class gridViewRowPresenterBase : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.GridViewRowPresenterBase, System.Windows.Controls.GridViewColumnCollection> columns(System.Windows.Controls.GridViewColumnCollection v) => new SetValue<TMessage, System.Windows.Controls.Primitives.GridViewRowPresenterBase, System.Windows.Controls.GridViewColumnCollection>(Properties.gridViewRowPresenterBase.columns, v);


    }

    public partial class groupBox : headeredContentControl
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.GroupBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.GroupBox>(vs);
    }

    public partial class groupItem : contentControl
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.GroupItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.GroupItem>(vs);
    }

    public partial class headeredContentControl : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.Object> header(System.Object v) => new SetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.Object>(Properties.headeredContentControl.header, v);
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.Windows.DataTemplate> headerTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.Windows.DataTemplate>(Properties.headeredContentControl.headerTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.Windows.Controls.DataTemplateSelector> headerTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.Windows.Controls.DataTemplateSelector>(Properties.headeredContentControl.headerTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.String> headerStringFormat(System.String v) => new SetValue<TMessage, System.Windows.Controls.HeaderedContentControl, System.String>(Properties.headeredContentControl.headerStringFormat, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.HeaderedContentControl>[] vs) => new StandardView<TMessage, System.Windows.Controls.HeaderedContentControl>(vs);
    }

    public partial class headeredItemsControl : itemsControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.Object> header(System.Object v) => new SetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.Object>(Properties.headeredItemsControl.header, v);
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.Windows.DataTemplate> headerTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.Windows.DataTemplate>(Properties.headeredItemsControl.headerTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.Windows.Controls.DataTemplateSelector> headerTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.Windows.Controls.DataTemplateSelector>(Properties.headeredItemsControl.headerTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.String> headerStringFormat(System.String v) => new SetValue<TMessage, System.Windows.Controls.HeaderedItemsControl, System.String>(Properties.headeredItemsControl.headerStringFormat, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.HeaderedItemsControl>[] vs) => new StandardView<TMessage, System.Windows.Controls.HeaderedItemsControl>(vs);
    }

    public partial class hwndHost : frameworkElement
    {

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> onDpiChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> (Events.hwndHost.dpiChanged, h => (System.Windows.DpiChangedEventHandler)h.Invoke, onChange);

    }

    public partial class image : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Image, System.Windows.Media.ImageSource> source(System.Windows.Media.ImageSource v) => new SetValue<TMessage, System.Windows.Controls.Image, System.Windows.Media.ImageSource>(Properties.image.source, v);
      public static ISetValue<TMessage, System.Windows.Controls.Image, System.Windows.Media.Stretch> stretch(System.Windows.Media.Stretch v) => new SetValue<TMessage, System.Windows.Controls.Image, System.Windows.Media.Stretch>(Properties.image.stretch, v);
      public static ISetValue<TMessage, System.Windows.Controls.Image, System.Windows.Controls.StretchDirection> stretchDirection(System.Windows.Controls.StretchDirection v) => new SetValue<TMessage, System.Windows.Controls.Image, System.Windows.Controls.StretchDirection>(Properties.image.stretchDirection, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> onDpiChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> (Events.image.dpiChanged, h => (System.Windows.DpiChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> onImageFailed (OnChange<TMessage, System.Windows.UIElement, System.Windows.ExceptionRoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> (Events.image.imageFailed, h => (System.EventHandler<System.Windows.ExceptionRoutedEventArgs>)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Image>[] vs) => new StandardView<TMessage, System.Windows.Controls.Image>(vs);
    }

    public partial class inkCanvas : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Media.Brush>(Properties.inkCanvas.background, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> top(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.inkCanvas.top, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> bottom(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.inkCanvas.bottom, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> left(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.inkCanvas.left, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> right(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.inkCanvas.right, v);
      public static ISetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Ink.StrokeCollection> strokes(System.Windows.Ink.StrokeCollection v) => new SetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Ink.StrokeCollection>(Properties.inkCanvas.strokes, v);
      public static ISetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Ink.DrawingAttributes> defaultDrawingAttributes(System.Windows.Ink.DrawingAttributes v) => new SetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Ink.DrawingAttributes>(Properties.inkCanvas.defaultDrawingAttributes, v);
      public static ISetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode> editingMode(System.Windows.Controls.InkCanvasEditingMode v) => new SetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode>(Properties.inkCanvas.editingMode, v);
      public static ISetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode> editingModeInverted(System.Windows.Controls.InkCanvasEditingMode v) => new SetValue<TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasEditingMode>(Properties.inkCanvas.editingModeInverted, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> onStrokeCollected (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> (Events.inkCanvas.strokeCollected, h => (System.Windows.Controls.InkCanvasStrokeCollectedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs> onGesture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.InkCanvasGestureEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs> (Events.inkCanvas.gesture, h => (System.Windows.Controls.InkCanvasGestureEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onActiveEditingModeChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.inkCanvas.activeEditingModeChanged, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onEditingModeChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.inkCanvas.editingModeChanged, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onEditingModeInvertedChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.inkCanvas.editingModeInvertedChanged, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onStrokeErased (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.inkCanvas.strokeErased, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.InkCanvas>[] vs) => new StandardView<TMessage, System.Windows.Controls.InkCanvas>(vs);
    }

    public partial class inkPresenter : decorator
    {
      public static ISetValue<TMessage, System.Windows.Controls.InkPresenter, System.Windows.Ink.StrokeCollection> strokes(System.Windows.Ink.StrokeCollection v) => new SetValue<TMessage, System.Windows.Controls.InkPresenter, System.Windows.Ink.StrokeCollection>(Properties.inkPresenter.strokes, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.InkPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.InkPresenter>(vs);
    }

    public partial class itemsControl : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Collections.IEnumerable> itemsSource(System.Collections.IEnumerable v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Collections.IEnumerable>(Properties.itemsControl.itemsSource, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.String> displayMemberPath(System.String v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.String>(Properties.itemsControl.displayMemberPath, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.DataTemplate> itemTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.DataTemplate>(Properties.itemsControl.itemTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.DataTemplateSelector> itemTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.DataTemplateSelector>(Properties.itemsControl.itemTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.String> itemStringFormat(System.String v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.String>(Properties.itemsControl.itemStringFormat, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Data.BindingGroup> itemBindingGroup(System.Windows.Data.BindingGroup v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Data.BindingGroup>(Properties.itemsControl.itemBindingGroup, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Style> itemContainerStyle(System.Windows.Style v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Style>(Properties.itemsControl.itemContainerStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.StyleSelector> itemContainerStyleSelector(System.Windows.Controls.StyleSelector v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.StyleSelector>(Properties.itemsControl.itemContainerStyleSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.ItemsPanelTemplate> itemsPanel(System.Windows.Controls.ItemsPanelTemplate v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.ItemsPanelTemplate>(Properties.itemsControl.itemsPanel, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.GroupStyleSelector> groupStyleSelector(System.Windows.Controls.GroupStyleSelector v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Windows.Controls.GroupStyleSelector>(Properties.itemsControl.groupStyleSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Int32> alternationCount(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Int32>(Properties.itemsControl.alternationCount, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Boolean> isTextSearchEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Boolean>(Properties.itemsControl.isTextSearchEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.ItemsControl, System.Boolean> isTextSearchCaseSensitive(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ItemsControl, System.Boolean>(Properties.itemsControl.isTextSearchCaseSensitive, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ItemsControl>[] vs) => new StandardView<TMessage, System.Windows.Controls.ItemsControl>(vs);
    }

    public partial class itemsPresenter : frameworkElement
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ItemsPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.ItemsPresenter>(vs);
    }

    public partial class label : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.Label, System.Windows.UIElement> target(System.Windows.UIElement v) => new SetValue<TMessage, System.Windows.Controls.Label, System.Windows.UIElement>(Properties.label.target, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Label>[] vs) => new StandardView<TMessage, System.Windows.Controls.Label>(vs);
    }

    public partial class line : shape
    {
      public static ISetValue<TMessage, System.Windows.Shapes.Line, System.Double> x1(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Line, System.Double>(Properties.line.x1, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Line, System.Double> y1(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Line, System.Double>(Properties.line.y1, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Line, System.Double> x2(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Line, System.Double>(Properties.line.x2, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Line, System.Double> y2(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Line, System.Double>(Properties.line.y2, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Shapes.Line>[] vs) => new StandardView<TMessage, System.Windows.Shapes.Line>(vs);
    }

    public partial class listBox : selector
    {
      public static ISetValue<TMessage, System.Windows.Controls.ListBox, System.Windows.Controls.SelectionMode> selectionMode(System.Windows.Controls.SelectionMode v) => new SetValue<TMessage, System.Windows.Controls.ListBox, System.Windows.Controls.SelectionMode>(Properties.listBox.selectionMode, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ListBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.ListBox>(vs);
    }

    public partial class listBoxItem : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.ListBoxItem, System.Boolean> isSelected(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ListBoxItem, System.Boolean>(Properties.listBoxItem.isSelected, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSelected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.listBoxItem.selected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnselected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.listBoxItem.unselected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ListBoxItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.ListBoxItem>(vs);
    }

    public partial class listView : listBox
    {
      public static ISetValue<TMessage, System.Windows.Controls.ListView, System.Windows.Controls.ViewBase> view(System.Windows.Controls.ViewBase v) => new SetValue<TMessage, System.Windows.Controls.ListView, System.Windows.Controls.ViewBase>(Properties.listView.view, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ListView>[] vs) => new StandardView<TMessage, System.Windows.Controls.ListView>(vs);
    }

    public partial class listViewItem : listBoxItem
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ListViewItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.ListViewItem>(vs);
    }

    public partial class mediaElement : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Uri> source(System.Uri v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Uri>(Properties.mediaElement.source, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Double> volume(System.Double v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Double>(Properties.mediaElement.volume, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Double> balance(System.Double v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Double>(Properties.mediaElement.balance, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Boolean> isMuted(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Boolean>(Properties.mediaElement.isMuted, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Boolean> scrubbingEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Boolean>(Properties.mediaElement.scrubbingEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState> unloadedBehavior(System.Windows.Controls.MediaState v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState>(Properties.mediaElement.unloadedBehavior, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState> loadedBehavior(System.Windows.Controls.MediaState v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Controls.MediaState>(Properties.mediaElement.loadedBehavior, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Media.Stretch> stretch(System.Windows.Media.Stretch v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Media.Stretch>(Properties.mediaElement.stretch, v);
      public static ISetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Controls.StretchDirection> stretchDirection(System.Windows.Controls.StretchDirection v) => new SetValue<TMessage, System.Windows.Controls.MediaElement, System.Windows.Controls.StretchDirection>(Properties.mediaElement.stretchDirection, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> onMediaFailed (OnChange<TMessage, System.Windows.UIElement, System.Windows.ExceptionRoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> (Events.mediaElement.mediaFailed, h => (System.EventHandler<System.Windows.ExceptionRoutedEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onMediaOpened (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.mediaElement.mediaOpened, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onBufferingStarted (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.mediaElement.bufferingStarted, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onBufferingEnded (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.mediaElement.bufferingEnded, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>, System.Windows.MediaScriptCommandRoutedEventArgs> onScriptCommand (OnChange<TMessage, System.Windows.UIElement, System.Windows.MediaScriptCommandRoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>, System.Windows.MediaScriptCommandRoutedEventArgs> (Events.mediaElement.scriptCommand, h => (System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onMediaEnded (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.mediaElement.mediaEnded, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.MediaElement>[] vs) => new StandardView<TMessage, System.Windows.Controls.MediaElement>(vs);
    }

    public partial class menu : menuBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Menu, System.Boolean> isMainMenu(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Menu, System.Boolean>(Properties.menu.isMainMenu, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Menu>[] vs) => new StandardView<TMessage, System.Windows.Controls.Menu>(vs);
    }

    public partial class menuBase : itemsControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.MenuBase, System.Windows.Controls.ItemContainerTemplateSelector> itemContainerTemplateSelector(System.Windows.Controls.ItemContainerTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.Primitives.MenuBase, System.Windows.Controls.ItemContainerTemplateSelector>(Properties.menuBase.itemContainerTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.MenuBase, System.Boolean> usesItemContainerTemplate(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.MenuBase, System.Boolean>(Properties.menuBase.usesItemContainerTemplate, v);


    }

    public partial class menuItem : headeredItemsControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Windows.Input.ICommand> command(System.Windows.Input.ICommand v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Windows.Input.ICommand>(Properties.menuItem.command, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Object> commandParameter(System.Object v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Object>(Properties.menuItem.commandParameter, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Windows.IInputElement> commandTarget(System.Windows.IInputElement v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Windows.IInputElement>(Properties.menuItem.commandTarget, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean> isSubmenuOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean>(Properties.menuItem.isSubmenuOpen, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean> isCheckable(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean>(Properties.menuItem.isCheckable, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean> isChecked(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean>(Properties.menuItem.isChecked, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean> staysOpenOnClick(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean>(Properties.menuItem.staysOpenOnClick, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.String> inputGestureText(System.String v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.String>(Properties.menuItem.inputGestureText, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Object> icon(System.Object v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Object>(Properties.menuItem.icon, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Windows.Controls.ItemContainerTemplateSelector> itemContainerTemplateSelector(System.Windows.Controls.ItemContainerTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Windows.Controls.ItemContainerTemplateSelector>(Properties.menuItem.itemContainerTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean> usesItemContainerTemplate(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.MenuItem, System.Boolean>(Properties.menuItem.usesItemContainerTemplate, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onClick (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.menuItem.click, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onChecked (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.menuItem.checked_, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnchecked (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.menuItem.unchecked_, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSubmenuOpened (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.menuItem.submenuOpened, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSubmenuClosed (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.menuItem.submenuClosed, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.MenuItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.MenuItem>(vs);
    }

    public partial class multiSelector : selector
    {


    }

    public partial class navigationWindow : window
    {
      public static ISetValue<TMessage, System.Windows.Navigation.NavigationWindow, System.Boolean> sandboxExternalContent(System.Boolean v) => new SetValue<TMessage, System.Windows.Navigation.NavigationWindow, System.Boolean>(Properties.navigationWindow.sandboxExternalContent, v);
      public static ISetValue<TMessage, System.Windows.Navigation.NavigationWindow, System.Boolean> showsNavigationUI(System.Boolean v) => new SetValue<TMessage, System.Windows.Navigation.NavigationWindow, System.Boolean>(Properties.navigationWindow.showsNavigationUI, v);
      public static ISetValue<TMessage, System.Windows.Navigation.NavigationWindow, System.Uri> source(System.Uri v) => new SetValue<TMessage, System.Windows.Navigation.NavigationWindow, System.Uri>(Properties.navigationWindow.source, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Navigation.NavigationWindow>[] vs) => new StandardView<TMessage, System.Windows.Navigation.NavigationWindow>(vs);
    }

    public partial class page : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.Object> content(System.Object v) => new SetValue<TMessage, System.Windows.Controls.Page, System.Object>(Properties.page.content, v);
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Page, System.Windows.Media.Brush>(Properties.page.background, v);
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.String> title(System.String v) => new SetValue<TMessage, System.Windows.Controls.Page, System.String>(Properties.page.title, v);
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.Boolean> keepAlive(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Page, System.Boolean>(Properties.page.keepAlive, v);
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.Windows.Media.Brush> foreground(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Page, System.Windows.Media.Brush>(Properties.page.foreground, v);
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.Windows.Media.FontFamily> fontFamily(System.Windows.Media.FontFamily v) => new SetValue<TMessage, System.Windows.Controls.Page, System.Windows.Media.FontFamily>(Properties.page.fontFamily, v);
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.Double> fontSize(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Page, System.Double>(Properties.page.fontSize, v);
      public static ISetValue<TMessage, System.Windows.Controls.Page, System.Windows.Controls.ControlTemplate> template(System.Windows.Controls.ControlTemplate v) => new SetValue<TMessage, System.Windows.Controls.Page, System.Windows.Controls.ControlTemplate>(Properties.page.template, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Page>[] vs) => new StandardView<TMessage, System.Windows.Controls.Page>(vs);
    }

    public partial class pageContent : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Documents.PageContent, System.Uri> source(System.Uri v) => new SetValue<TMessage, System.Windows.Documents.PageContent, System.Uri>(Properties.pageContent.source, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Documents.PageContent>[] vs) => new StandardView<TMessage, System.Windows.Documents.PageContent>(vs);
    }

    public partial class pageFunctionBase : page
    {


    }

    public partial class panel : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Panel, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Panel, System.Windows.Media.Brush>(Properties.panel.background, v);
      public static ISetValue<TMessage, System.Windows.Controls.Panel, System.Boolean> isItemsHost(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Panel, System.Boolean>(Properties.panel.isItemsHost, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Int32> zIndex(System.Int32 v) => new SetValue<TMessage, System.Windows.UIElement, System.Int32>(Properties.panel.zIndex, v);


    }

    public partial class passwordBox : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.PasswordBox, System.Char> passwordChar(System.Char v) => new SetValue<TMessage, System.Windows.Controls.PasswordBox, System.Char>(Properties.passwordBox.passwordChar, v);
      public static ISetValue<TMessage, System.Windows.Controls.PasswordBox, System.Int32> maxLength(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.PasswordBox, System.Int32>(Properties.passwordBox.maxLength, v);
      public static ISetValue<TMessage, System.Windows.Controls.PasswordBox, System.Windows.Media.Brush> selectionBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.PasswordBox, System.Windows.Media.Brush>(Properties.passwordBox.selectionBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.PasswordBox, System.Double> selectionOpacity(System.Double v) => new SetValue<TMessage, System.Windows.Controls.PasswordBox, System.Double>(Properties.passwordBox.selectionOpacity, v);
      public static ISetValue<TMessage, System.Windows.Controls.PasswordBox, System.Windows.Media.Brush> caretBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.PasswordBox, System.Windows.Media.Brush>(Properties.passwordBox.caretBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.PasswordBox, System.Boolean> isInactiveSelectionHighlightEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.PasswordBox, System.Boolean>(Properties.passwordBox.isInactiveSelectionHighlightEnabled, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onPasswordChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.passwordBox.passwordChanged, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.PasswordBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.PasswordBox>(vs);
    }

    public partial class path : shape
    {
      public static ISetValue<TMessage, System.Windows.Shapes.Path, System.Windows.Media.Geometry> data(System.Windows.Media.Geometry v) => new SetValue<TMessage, System.Windows.Shapes.Path, System.Windows.Media.Geometry>(Properties.path.data, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Shapes.Path>[] vs) => new StandardView<TMessage, System.Windows.Shapes.Path>(vs);
    }

    public partial class polygon : shape
    {
      public static ISetValue<TMessage, System.Windows.Shapes.Polygon, System.Windows.Media.PointCollection> points(System.Windows.Media.PointCollection v) => new SetValue<TMessage, System.Windows.Shapes.Polygon, System.Windows.Media.PointCollection>(Properties.polygon.points, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Polygon, System.Windows.Media.FillRule> fillRule(System.Windows.Media.FillRule v) => new SetValue<TMessage, System.Windows.Shapes.Polygon, System.Windows.Media.FillRule>(Properties.polygon.fillRule, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Shapes.Polygon>[] vs) => new StandardView<TMessage, System.Windows.Shapes.Polygon>(vs);
    }

    public partial class polyline : shape
    {
      public static ISetValue<TMessage, System.Windows.Shapes.Polyline, System.Windows.Media.PointCollection> points(System.Windows.Media.PointCollection v) => new SetValue<TMessage, System.Windows.Shapes.Polyline, System.Windows.Media.PointCollection>(Properties.polyline.points, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Polyline, System.Windows.Media.FillRule> fillRule(System.Windows.Media.FillRule v) => new SetValue<TMessage, System.Windows.Shapes.Polyline, System.Windows.Media.FillRule>(Properties.polyline.fillRule, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Shapes.Polyline>[] vs) => new StandardView<TMessage, System.Windows.Shapes.Polyline>(vs);
    }

    public partial class popup : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.UIElement> child(System.Windows.UIElement v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.UIElement>(Properties.popup.child, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Boolean> isOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Boolean>(Properties.popup.isOpen, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PlacementMode> placement(System.Windows.Controls.Primitives.PlacementMode v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PlacementMode>(Properties.popup.placement, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.CustomPopupPlacementCallback> customPopupPlacementCallback(System.Windows.Controls.Primitives.CustomPopupPlacementCallback v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.CustomPopupPlacementCallback>(Properties.popup.customPopupPlacementCallback, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Boolean> staysOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Boolean>(Properties.popup.staysOpen, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Double> horizontalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Double>(Properties.popup.horizontalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Double> verticalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Double>(Properties.popup.verticalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.UIElement> placementTarget(System.Windows.UIElement v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.UIElement>(Properties.popup.placementTarget, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Rect> placementRectangle(System.Windows.Rect v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Rect>(Properties.popup.placementRectangle, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PopupAnimation> popupAnimation(System.Windows.Controls.Primitives.PopupAnimation v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Windows.Controls.Primitives.PopupAnimation>(Properties.popup.popupAnimation, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Boolean> allowsTransparency(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Popup, System.Boolean>(Properties.popup.allowsTransparency, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.Popup>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.Popup>(vs);
    }

    public partial class progressBar : rangeBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.ProgressBar, System.Boolean> isIndeterminate(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ProgressBar, System.Boolean>(Properties.progressBar.isIndeterminate, v);
      public static ISetValue<TMessage, System.Windows.Controls.ProgressBar, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.ProgressBar, System.Windows.Controls.Orientation>(Properties.progressBar.orientation, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ProgressBar>[] vs) => new StandardView<TMessage, System.Windows.Controls.ProgressBar>(vs);
    }

    public partial class radioButton : toggleButton
    {
      public static ISetValue<TMessage, System.Windows.Controls.RadioButton, System.String> groupName(System.String v) => new SetValue<TMessage, System.Windows.Controls.RadioButton, System.String>(Properties.radioButton.groupName, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.RadioButton>[] vs) => new StandardView<TMessage, System.Windows.Controls.RadioButton>(vs);
    }

    public partial class rangeBase : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double> minimum(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double>(Properties.rangeBase.minimum, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double> maximum(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double>(Properties.rangeBase.maximum, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double> value(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double>(Properties.rangeBase.value, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double> largeChange(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double>(Properties.rangeBase.largeChange, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double> smallChange(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.RangeBase, System.Double>(Properties.rangeBase.smallChange, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>> onValueChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventArgs<System.Double>> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>> (Events.rangeBase.valueChanged, h => (System.Windows.RoutedPropertyChangedEventHandler<System.Double>)h.Invoke, onChange);

    }

    public partial class rectangle : shape
    {
      public static ISetValue<TMessage, System.Windows.Shapes.Rectangle, System.Double> radiusX(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Rectangle, System.Double>(Properties.rectangle.radiusX, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Rectangle, System.Double> radiusY(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Rectangle, System.Double>(Properties.rectangle.radiusY, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Shapes.Rectangle>[] vs) => new StandardView<TMessage, System.Windows.Shapes.Rectangle>(vs);
    }

    public partial class repeatButton : buttonBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.RepeatButton, System.Int32> delay(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.RepeatButton, System.Int32>(Properties.repeatButton.delay, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.RepeatButton, System.Int32> interval(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.RepeatButton, System.Int32>(Properties.repeatButton.interval, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.RepeatButton>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.RepeatButton>(vs);
    }

    public partial class resizeGrip : control
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.ResizeGrip>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.ResizeGrip>(vs);
    }

    public partial class richTextBox : textBoxBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.RichTextBox, System.Boolean> isDocumentEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.RichTextBox, System.Boolean>(Properties.richTextBox.isDocumentEnabled, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.RichTextBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.RichTextBox>(vs);
    }

    public partial class scrollBar : rangeBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ScrollBar, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ScrollBar, System.Windows.Controls.Orientation>(Properties.scrollBar.orientation, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ScrollBar, System.Double> viewportSize(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ScrollBar, System.Double>(Properties.scrollBar.viewportSize, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs> onScroll (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.ScrollEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs> (Events.scrollBar.scroll, h => (System.Windows.Controls.Primitives.ScrollEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.ScrollBar>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.ScrollBar>(vs);
    }

    public partial class scrollContentPresenter : contentPresenter
    {
      public static ISetValue<TMessage, System.Windows.Controls.ScrollContentPresenter, System.Boolean> canContentScroll(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ScrollContentPresenter, System.Boolean>(Properties.scrollContentPresenter.canContentScroll, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ScrollContentPresenter>[] vs) => new StandardView<TMessage, System.Windows.Controls.ScrollContentPresenter>(vs);
    }

    public partial class scrollViewer : contentControl
    {
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> canContentScroll(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.scrollViewer.canContentScroll, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility>(Properties.scrollViewer.horizontalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollBarVisibility>(Properties.scrollViewer.verticalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isDeferredScrollingEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.scrollViewer.isDeferredScrollingEnabled, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.PanningMode> panningMode(System.Windows.Controls.PanningMode v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.PanningMode>(Properties.scrollViewer.panningMode, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> panningDeceleration(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.scrollViewer.panningDeceleration, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> panningRatio(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.scrollViewer.panningRatio, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs> onScrollChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs> (Events.scrollViewer.scrollChanged, h => (System.Windows.Controls.ScrollChangedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ScrollViewer>[] vs) => new StandardView<TMessage, System.Windows.Controls.ScrollViewer>(vs);
    }

    public partial class selectiveScrollingGrid : grid
    {
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.SelectiveScrollingOrientation> selectiveScrollingOrientation(System.Windows.Controls.SelectiveScrollingOrientation v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.SelectiveScrollingOrientation>(Properties.selectiveScrollingGrid.selectiveScrollingOrientation, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.SelectiveScrollingGrid>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.SelectiveScrollingGrid>(vs);
    }

    public partial class selector : itemsControl
    {
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isSelected(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.selector.isSelected, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Nullable<System.Boolean>> isSynchronizedWithCurrentItem(System.Nullable<System.Boolean> v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Nullable<System.Boolean>>(Properties.selector.isSynchronizedWithCurrentItem, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Int32> selectedIndex(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Int32>(Properties.selector.selectedIndex, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Object> selectedItem(System.Object v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Object>(Properties.selector.selectedItem, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Object> selectedValue(System.Object v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.Object>(Properties.selector.selectedValue, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.String> selectedValuePath(System.String v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Selector, System.String>(Properties.selector.selectedValuePath, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs> onSelectionChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.SelectionChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs> (Events.selector.selectionChanged, h => (System.Windows.Controls.SelectionChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSelected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.selector.selected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnselected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.selector.unselected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

    }

    public partial class separator : control
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Separator>[] vs) => new StandardView<TMessage, System.Windows.Controls.Separator>(vs);
    }

    public partial class shape : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.Stretch> stretch(System.Windows.Media.Stretch v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.Stretch>(Properties.shape.stretch, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.Brush> fill(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.Brush>(Properties.shape.fill, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.Brush> stroke(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.Brush>(Properties.shape.stroke, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Double> strokeThickness(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Double>(Properties.shape.strokeThickness, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap> strokeStartLineCap(System.Windows.Media.PenLineCap v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap>(Properties.shape.strokeStartLineCap, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap> strokeEndLineCap(System.Windows.Media.PenLineCap v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap>(Properties.shape.strokeEndLineCap, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap> strokeDashCap(System.Windows.Media.PenLineCap v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineCap>(Properties.shape.strokeDashCap, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineJoin> strokeLineJoin(System.Windows.Media.PenLineJoin v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.PenLineJoin>(Properties.shape.strokeLineJoin, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Double> strokeMiterLimit(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Double>(Properties.shape.strokeMiterLimit, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Double> strokeDashOffset(System.Double v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Double>(Properties.shape.strokeDashOffset, v);
      public static ISetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.DoubleCollection> strokeDashArray(System.Windows.Media.DoubleCollection v) => new SetValue<TMessage, System.Windows.Shapes.Shape, System.Windows.Media.DoubleCollection>(Properties.shape.strokeDashArray, v);


    }

    public partial class slider : rangeBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Controls.Orientation>(Properties.slider.orientation, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Boolean> isDirectionReversed(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Boolean>(Properties.slider.isDirectionReversed, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Int32> delay(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Int32>(Properties.slider.delay, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Int32> interval(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Int32>(Properties.slider.interval, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Controls.Primitives.AutoToolTipPlacement> autoToolTipPlacement(System.Windows.Controls.Primitives.AutoToolTipPlacement v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Controls.Primitives.AutoToolTipPlacement>(Properties.slider.autoToolTipPlacement, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Int32> autoToolTipPrecision(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Int32>(Properties.slider.autoToolTipPrecision, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Boolean> isSnapToTickEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Boolean>(Properties.slider.isSnapToTickEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Controls.Primitives.TickPlacement> tickPlacement(System.Windows.Controls.Primitives.TickPlacement v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Controls.Primitives.TickPlacement>(Properties.slider.tickPlacement, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Double> tickFrequency(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Double>(Properties.slider.tickFrequency, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Media.DoubleCollection> ticks(System.Windows.Media.DoubleCollection v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Windows.Media.DoubleCollection>(Properties.slider.ticks, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Boolean> isSelectionRangeEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Boolean>(Properties.slider.isSelectionRangeEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Double> selectionStart(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Double>(Properties.slider.selectionStart, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Double> selectionEnd(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Double>(Properties.slider.selectionEnd, v);
      public static ISetValue<TMessage, System.Windows.Controls.Slider, System.Boolean> isMoveToPointEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Slider, System.Boolean>(Properties.slider.isMoveToPointEnabled, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Slider>[] vs) => new StandardView<TMessage, System.Windows.Controls.Slider>(vs);
    }

    public partial class stackPanel : panel
    {
      public static ISetValue<TMessage, System.Windows.Controls.StackPanel, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.StackPanel, System.Windows.Controls.Orientation>(Properties.stackPanel.orientation, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.StackPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.StackPanel>(vs);
    }

    public partial class statusBar : itemsControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.StatusBar, System.Windows.Controls.ItemContainerTemplateSelector> itemContainerTemplateSelector(System.Windows.Controls.ItemContainerTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.Primitives.StatusBar, System.Windows.Controls.ItemContainerTemplateSelector>(Properties.statusBar.itemContainerTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.StatusBar, System.Boolean> usesItemContainerTemplate(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.StatusBar, System.Boolean>(Properties.statusBar.usesItemContainerTemplate, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.StatusBar>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.StatusBar>(vs);
    }

    public partial class statusBarItem : contentControl
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.StatusBarItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.StatusBarItem>(vs);
    }

    public partial class stickyNoteControl : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Boolean> isExpanded(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Boolean>(Properties.stickyNoteControl.isExpanded, v);
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Boolean> isActive(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Boolean>(Properties.stickyNoteControl.isActive, v);
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.Media.FontFamily> captionFontFamily(System.Windows.Media.FontFamily v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.Media.FontFamily>(Properties.stickyNoteControl.captionFontFamily, v);
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Double> captionFontSize(System.Double v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Double>(Properties.stickyNoteControl.captionFontSize, v);
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.FontStretch> captionFontStretch(System.Windows.FontStretch v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.FontStretch>(Properties.stickyNoteControl.captionFontStretch, v);
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.FontStyle> captionFontStyle(System.Windows.FontStyle v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.FontStyle>(Properties.stickyNoteControl.captionFontStyle, v);
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.FontWeight> captionFontWeight(System.Windows.FontWeight v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Windows.FontWeight>(Properties.stickyNoteControl.captionFontWeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Double> penWidth(System.Double v) => new SetValue<TMessage, System.Windows.Controls.StickyNoteControl, System.Double>(Properties.stickyNoteControl.penWidth, v);


    }

    public partial class tabControl : selector
    {
      public static ISetValue<TMessage, System.Windows.Controls.TabControl, System.Windows.Controls.Dock> tabStripPlacement(System.Windows.Controls.Dock v) => new SetValue<TMessage, System.Windows.Controls.TabControl, System.Windows.Controls.Dock>(Properties.tabControl.tabStripPlacement, v);
      public static ISetValue<TMessage, System.Windows.Controls.TabControl, System.Windows.DataTemplate> contentTemplate(System.Windows.DataTemplate v) => new SetValue<TMessage, System.Windows.Controls.TabControl, System.Windows.DataTemplate>(Properties.tabControl.contentTemplate, v);
      public static ISetValue<TMessage, System.Windows.Controls.TabControl, System.Windows.Controls.DataTemplateSelector> contentTemplateSelector(System.Windows.Controls.DataTemplateSelector v) => new SetValue<TMessage, System.Windows.Controls.TabControl, System.Windows.Controls.DataTemplateSelector>(Properties.tabControl.contentTemplateSelector, v);
      public static ISetValue<TMessage, System.Windows.Controls.TabControl, System.String> contentStringFormat(System.String v) => new SetValue<TMessage, System.Windows.Controls.TabControl, System.String>(Properties.tabControl.contentStringFormat, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.TabControl>[] vs) => new StandardView<TMessage, System.Windows.Controls.TabControl>(vs);
    }

    public partial class tabItem : headeredContentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.TabItem, System.Boolean> isSelected(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.TabItem, System.Boolean>(Properties.tabItem.isSelected, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.TabItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.TabItem>(vs);
    }

    public partial class tabPanel : panel
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.TabPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.TabPanel>(vs);
    }

    public partial class textBlock : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> baselineOffset(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.textBlock.baselineOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.String> text(System.String v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.String>(Properties.textBlock.text, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.FontFamily> fontFamily(System.Windows.Media.FontFamily v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.FontFamily>(Properties.textBlock.fontFamily, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.FontStyle> fontStyle(System.Windows.FontStyle v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.FontStyle>(Properties.textBlock.fontStyle, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.FontWeight> fontWeight(System.Windows.FontWeight v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.FontWeight>(Properties.textBlock.fontWeight, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.FontStretch> fontStretch(System.Windows.FontStretch v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.FontStretch>(Properties.textBlock.fontStretch, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> fontSize(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.textBlock.fontSize, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Brush> foreground(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Brush>(Properties.textBlock.foreground, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.Media.Brush>(Properties.textBlock.background, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.TextDecorationCollection> textDecorations(System.Windows.TextDecorationCollection v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.TextDecorationCollection>(Properties.textBlock.textDecorations, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.Media.TextEffectCollection> textEffects(System.Windows.Media.TextEffectCollection v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.Media.TextEffectCollection>(Properties.textBlock.textEffects, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> lineHeight(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.textBlock.lineHeight, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.LineStackingStrategy> lineStackingStrategy(System.Windows.LineStackingStrategy v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.LineStackingStrategy>(Properties.textBlock.lineStackingStrategy, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.Thickness> padding(System.Windows.Thickness v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.Thickness>(Properties.textBlock.padding, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.TextAlignment> textAlignment(System.Windows.TextAlignment v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.TextAlignment>(Properties.textBlock.textAlignment, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.TextTrimming> textTrimming(System.Windows.TextTrimming v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.TextTrimming>(Properties.textBlock.textTrimming, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.TextWrapping> textWrapping(System.Windows.TextWrapping v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.Windows.TextWrapping>(Properties.textBlock.textWrapping, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBlock, System.Boolean> isHyphenationEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.TextBlock, System.Boolean>(Properties.textBlock.isHyphenationEnabled, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.TextBlock>[] vs) => new StandardView<TMessage, System.Windows.Controls.TextBlock>(vs);
    }

    public partial class textBox : textBoxBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.TextWrapping> textWrapping(System.Windows.TextWrapping v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.TextWrapping>(Properties.textBox.textWrapping, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.Int32> minLines(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.Int32>(Properties.textBox.minLines, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.Int32> maxLines(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.Int32>(Properties.textBox.maxLines, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.String> text(System.String v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.String>(Properties.textBox.text, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.Controls.CharacterCasing> characterCasing(System.Windows.Controls.CharacterCasing v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.Controls.CharacterCasing>(Properties.textBox.characterCasing, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.Int32> maxLength(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.Int32>(Properties.textBox.maxLength, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.TextAlignment> textAlignment(System.Windows.TextAlignment v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.TextAlignment>(Properties.textBox.textAlignment, v);
      public static ISetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.TextDecorationCollection> textDecorations(System.Windows.TextDecorationCollection v) => new SetValue<TMessage, System.Windows.Controls.TextBox, System.Windows.TextDecorationCollection>(Properties.textBox.textDecorations, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.TextBox>[] vs) => new StandardView<TMessage, System.Windows.Controls.TextBox>(vs);
    }

    public partial class textBoxBase : control
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isReadOnly(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(Properties.textBoxBase.isReadOnly, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isReadOnlyCaretVisible(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(Properties.textBoxBase.isReadOnlyCaretVisible, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> acceptsReturn(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(Properties.textBoxBase.acceptsReturn, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> acceptsTab(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(Properties.textBoxBase.acceptsTab, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility> horizontalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility>(Properties.textBoxBase.horizontalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility> verticalScrollBarVisibility(System.Windows.Controls.ScrollBarVisibility v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.ScrollBarVisibility>(Properties.textBoxBase.verticalScrollBarVisibility, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isUndoEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(Properties.textBoxBase.isUndoEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Int32> undoLimit(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Int32>(Properties.textBoxBase.undoLimit, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> autoWordSelection(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(Properties.textBoxBase.autoWordSelection, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush> selectionBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush>(Properties.textBoxBase.selectionBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Double> selectionOpacity(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Double>(Properties.textBoxBase.selectionOpacity, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush> caretBrush(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Media.Brush>(Properties.textBoxBase.caretBrush, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean> isInactiveSelectionHighlightEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Boolean>(Properties.textBoxBase.isInactiveSelectionHighlightEnabled, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs> onTextChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.TextChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs> (Events.textBoxBase.textChanged, h => (System.Windows.Controls.TextChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSelectionChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.textBoxBase.selectionChanged, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

    }

    public partial class thumb : control
    {

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs> onDragStarted (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragStartedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs> (Events.thumb.dragStarted, h => (System.Windows.Controls.Primitives.DragStartedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs> onDragDelta (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragDeltaEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs> (Events.thumb.dragDelta, h => (System.Windows.Controls.Primitives.DragDeltaEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs> onDragCompleted (OnChange<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragCompletedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs> (Events.thumb.dragCompleted, h => (System.Windows.Controls.Primitives.DragCompletedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.Thumb>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.Thumb>(vs);
    }

    public partial class tickBar : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Windows.Media.Brush> fill(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Windows.Media.Brush>(Properties.tickBar.fill, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double> minimum(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double>(Properties.tickBar.minimum, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double> maximum(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double>(Properties.tickBar.maximum, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double> selectionStart(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double>(Properties.tickBar.selectionStart, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double> selectionEnd(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double>(Properties.tickBar.selectionEnd, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Boolean> isSelectionRangeEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Boolean>(Properties.tickBar.isSelectionRangeEnabled, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double> tickFrequency(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double>(Properties.tickBar.tickFrequency, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Windows.Media.DoubleCollection> ticks(System.Windows.Media.DoubleCollection v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Windows.Media.DoubleCollection>(Properties.tickBar.ticks, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Boolean> isDirectionReversed(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Boolean>(Properties.tickBar.isDirectionReversed, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Windows.Controls.Primitives.TickBarPlacement> placement(System.Windows.Controls.Primitives.TickBarPlacement v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Windows.Controls.Primitives.TickBarPlacement>(Properties.tickBar.placement, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double> reservedSpace(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.TickBar, System.Double>(Properties.tickBar.reservedSpace, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.TickBar>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.TickBar>(vs);
    }

    public partial class toggleButton : buttonBase
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Nullable<System.Boolean>> isChecked(System.Nullable<System.Boolean> v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Nullable<System.Boolean>>(Properties.toggleButton.isChecked, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Boolean> isThreeState(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Boolean>(Properties.toggleButton.isThreeState, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onChecked (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.toggleButton.checked_, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnchecked (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.toggleButton.unchecked_, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onIndeterminate (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.toggleButton.indeterminate, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.ToggleButton>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.ToggleButton>(vs);
    }

    public partial class toolBar : headeredItemsControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.ToolBar, System.Int32> band(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.ToolBar, System.Int32>(Properties.toolBar.band, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolBar, System.Int32> bandIndex(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.ToolBar, System.Int32>(Properties.toolBar.bandIndex, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolBar, System.Boolean> isOverflowOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ToolBar, System.Boolean>(Properties.toolBar.isOverflowOpen, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.OverflowMode> overflowMode(System.Windows.Controls.OverflowMode v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.OverflowMode>(Properties.toolBar.overflowMode, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ToolBar>[] vs) => new StandardView<TMessage, System.Windows.Controls.ToolBar>(vs);
    }

    public partial class toolBarOverflowPanel : panel
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.ToolBarOverflowPanel, System.Double> wrapWidth(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.ToolBarOverflowPanel, System.Double>(Properties.toolBarOverflowPanel.wrapWidth, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.ToolBarOverflowPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.ToolBarOverflowPanel>(vs);
    }

    public partial class toolBarPanel : stackPanel
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.ToolBarPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.ToolBarPanel>(vs);
    }

    public partial class toolBarTray : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.ToolBarTray, System.Windows.Media.Brush> background(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.Controls.ToolBarTray, System.Windows.Media.Brush>(Properties.toolBarTray.background, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolBarTray, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.ToolBarTray, System.Windows.Controls.Orientation>(Properties.toolBarTray.orientation, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isLocked(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.toolBarTray.isLocked, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ToolBarTray>[] vs) => new StandardView<TMessage, System.Windows.Controls.ToolBarTray>(vs);
    }

    public partial class toolTip : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Double> horizontalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Double>(Properties.toolTip.horizontalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Double> verticalOffset(System.Double v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Double>(Properties.toolTip.verticalOffset, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Boolean> isOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Boolean>(Properties.toolTip.isOpen, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Boolean> hasDropShadow(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Boolean>(Properties.toolTip.hasDropShadow, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.UIElement> placementTarget(System.Windows.UIElement v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.UIElement>(Properties.toolTip.placementTarget, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.Rect> placementRectangle(System.Windows.Rect v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.Rect>(Properties.toolTip.placementRectangle, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.PlacementMode> placement(System.Windows.Controls.Primitives.PlacementMode v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.PlacementMode>(Properties.toolTip.placement, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.CustomPopupPlacementCallback> customPopupPlacementCallback(System.Windows.Controls.Primitives.CustomPopupPlacementCallback v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Windows.Controls.Primitives.CustomPopupPlacementCallback>(Properties.toolTip.customPopupPlacementCallback, v);
      public static ISetValue<TMessage, System.Windows.Controls.ToolTip, System.Boolean> staysOpen(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.ToolTip, System.Boolean>(Properties.toolTip.staysOpen, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onOpened (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.toolTip.opened, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onClosed (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.toolTip.closed, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.ToolTip>[] vs) => new StandardView<TMessage, System.Windows.Controls.ToolTip>(vs);
    }

    public partial class track : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Windows.Controls.Orientation>(Properties.track.orientation, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double> minimum(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double>(Properties.track.minimum, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double> maximum(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double>(Properties.track.maximum, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double> value(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double>(Properties.track.value, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double> viewportSize(System.Double v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Double>(Properties.track.viewportSize, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Boolean> isDirectionReversed(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.Primitives.Track, System.Boolean>(Properties.track.isDirectionReversed, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.Track>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.Track>(vs);
    }

    public partial class treeView : itemsControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.TreeView, System.String> selectedValuePath(System.String v) => new SetValue<TMessage, System.Windows.Controls.TreeView, System.String>(Properties.treeView.selectedValuePath, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>> onSelectedItemChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventArgs<System.Object>> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>> (Events.treeView.selectedItemChanged, h => (System.Windows.RoutedPropertyChangedEventHandler<System.Object>)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.TreeView>[] vs) => new StandardView<TMessage, System.Windows.Controls.TreeView>(vs);
    }

    public partial class treeViewItem : headeredItemsControl
    {
      public static ISetValue<TMessage, System.Windows.Controls.TreeViewItem, System.Boolean> isExpanded(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.TreeViewItem, System.Boolean>(Properties.treeViewItem.isExpanded, v);
      public static ISetValue<TMessage, System.Windows.Controls.TreeViewItem, System.Boolean> isSelected(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.TreeViewItem, System.Boolean>(Properties.treeViewItem.isSelected, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onExpanded (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.treeViewItem.expanded, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onCollapsed (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.treeViewItem.collapsed, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onSelected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.treeViewItem.selected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onUnselected (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.treeViewItem.unselected, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.TreeViewItem>[] vs) => new StandardView<TMessage, System.Windows.Controls.TreeViewItem>(vs);
    }

    public partial class uIElement
    {
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> allowDrop(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.uIElement.allowDrop, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Transform> renderTransform(System.Windows.Media.Transform v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Transform>(Properties.uIElement.renderTransform, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Point> renderTransformOrigin(System.Windows.Point v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Point>(Properties.uIElement.renderTransformOrigin, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Double> opacity(System.Double v) => new SetValue<TMessage, System.Windows.UIElement, System.Double>(Properties.uIElement.opacity, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Brush> opacityMask(System.Windows.Media.Brush v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Brush>(Properties.uIElement.opacityMask, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffect> bitmapEffect(System.Windows.Media.Effects.BitmapEffect v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffect>(Properties.uIElement.bitmapEffect, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Effects.Effect> effect(System.Windows.Media.Effects.Effect v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Effects.Effect>(Properties.uIElement.effect, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffectInput> bitmapEffectInput(System.Windows.Media.Effects.BitmapEffectInput v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Effects.BitmapEffectInput>(Properties.uIElement.bitmapEffectInput, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.CacheMode> cacheMode(System.Windows.Media.CacheMode v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.CacheMode>(Properties.uIElement.cacheMode, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.String> uid(System.String v) => new SetValue<TMessage, System.Windows.UIElement, System.String>(Properties.uIElement.uid, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Visibility> visibility(System.Windows.Visibility v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Visibility>(Properties.uIElement.visibility, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> clipToBounds(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.uIElement.clipToBounds, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Geometry> clip(System.Windows.Media.Geometry v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Media.Geometry>(Properties.uIElement.clip, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> snapsToDevicePixels(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.uIElement.snapsToDevicePixels, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.uIElement.isEnabled, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isHitTestVisible(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.uIElement.isHitTestVisible, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> focusable(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.uIElement.focusable, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isManipulationEnabled(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.uIElement.isManipulationEnabled, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onPreviewMouseDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.previewMouseDown, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onMouseDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.mouseDown, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onPreviewMouseUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.previewMouseUp, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onMouseUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.mouseUp, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onPreviewMouseLeftButtonDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.previewMouseLeftButtonDown, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onMouseLeftButtonDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.mouseLeftButtonDown, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onPreviewMouseLeftButtonUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.previewMouseLeftButtonUp, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onMouseLeftButtonUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.mouseLeftButtonUp, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onPreviewMouseRightButtonDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.previewMouseRightButtonDown, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onMouseRightButtonDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.mouseRightButtonDown, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onPreviewMouseRightButtonUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.previewMouseRightButtonUp, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> onMouseRightButtonUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (Events.uIElement.mouseRightButtonUp, h => (System.Windows.Input.MouseButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> onPreviewMouseMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (Events.uIElement.previewMouseMove, h => (System.Windows.Input.MouseEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> onMouseMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (Events.uIElement.mouseMove, h => (System.Windows.Input.MouseEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> onPreviewMouseWheel (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> (Events.uIElement.previewMouseWheel, h => (System.Windows.Input.MouseWheelEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> onMouseWheel (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> (Events.uIElement.mouseWheel, h => (System.Windows.Input.MouseWheelEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> onMouseEnter (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (Events.uIElement.mouseEnter, h => (System.Windows.Input.MouseEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> onMouseLeave (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (Events.uIElement.mouseLeave, h => (System.Windows.Input.MouseEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> onGotMouseCapture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (Events.uIElement.gotMouseCapture, h => (System.Windows.Input.MouseEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> onLostMouseCapture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (Events.uIElement.lostMouseCapture, h => (System.Windows.Input.MouseEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs> onQueryCursor (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.QueryCursorEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs> (Events.uIElement.queryCursor, h => (System.Windows.Input.QueryCursorEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> onPreviewStylusDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> (Events.uIElement.previewStylusDown, h => (System.Windows.Input.StylusDownEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> onStylusDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> (Events.uIElement.stylusDown, h => (System.Windows.Input.StylusDownEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onPreviewStylusUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.previewStylusUp, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onStylusUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.stylusUp, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onPreviewStylusMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.previewStylusMove, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onStylusMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.stylusMove, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onPreviewStylusInAirMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.previewStylusInAirMove, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onStylusInAirMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.stylusInAirMove, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onStylusEnter (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.stylusEnter, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onStylusLeave (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.stylusLeave, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onPreviewStylusInRange (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.previewStylusInRange, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onStylusInRange (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.stylusInRange, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onPreviewStylusOutOfRange (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.previewStylusOutOfRange, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onStylusOutOfRange (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.stylusOutOfRange, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> onPreviewStylusSystemGesture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> (Events.uIElement.previewStylusSystemGesture, h => (System.Windows.Input.StylusSystemGestureEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> onStylusSystemGesture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> (Events.uIElement.stylusSystemGesture, h => (System.Windows.Input.StylusSystemGestureEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onGotStylusCapture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.gotStylusCapture, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> onLostStylusCapture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (Events.uIElement.lostStylusCapture, h => (System.Windows.Input.StylusEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> onStylusButtonDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (Events.uIElement.stylusButtonDown, h => (System.Windows.Input.StylusButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> onStylusButtonUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (Events.uIElement.stylusButtonUp, h => (System.Windows.Input.StylusButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> onPreviewStylusButtonDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (Events.uIElement.previewStylusButtonDown, h => (System.Windows.Input.StylusButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> onPreviewStylusButtonUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (Events.uIElement.previewStylusButtonUp, h => (System.Windows.Input.StylusButtonEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> onPreviewKeyDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (Events.uIElement.previewKeyDown, h => (System.Windows.Input.KeyEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> onKeyDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (Events.uIElement.keyDown, h => (System.Windows.Input.KeyEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> onPreviewKeyUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (Events.uIElement.previewKeyUp, h => (System.Windows.Input.KeyEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> onKeyUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (Events.uIElement.keyUp, h => (System.Windows.Input.KeyEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> onPreviewGotKeyboardFocus (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (Events.uIElement.previewGotKeyboardFocus, h => (System.Windows.Input.KeyboardFocusChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> onGotKeyboardFocus (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (Events.uIElement.gotKeyboardFocus, h => (System.Windows.Input.KeyboardFocusChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> onPreviewLostKeyboardFocus (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (Events.uIElement.previewLostKeyboardFocus, h => (System.Windows.Input.KeyboardFocusChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> onLostKeyboardFocus (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (Events.uIElement.lostKeyboardFocus, h => (System.Windows.Input.KeyboardFocusChangedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> onPreviewTextInput (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> (Events.uIElement.previewTextInput, h => (System.Windows.Input.TextCompositionEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> onTextInput (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> (Events.uIElement.textInput, h => (System.Windows.Input.TextCompositionEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> onPreviewQueryContinueDrag (OnChange<TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> (Events.uIElement.previewQueryContinueDrag, h => (System.Windows.QueryContinueDragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> onQueryContinueDrag (OnChange<TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> (Events.uIElement.queryContinueDrag, h => (System.Windows.QueryContinueDragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> onPreviewGiveFeedback (OnChange<TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> (Events.uIElement.previewGiveFeedback, h => (System.Windows.GiveFeedbackEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> onGiveFeedback (OnChange<TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> (Events.uIElement.giveFeedback, h => (System.Windows.GiveFeedbackEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onPreviewDragEnter (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.previewDragEnter, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onDragEnter (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.dragEnter, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onPreviewDragOver (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.previewDragOver, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onDragOver (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.dragOver, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onPreviewDragLeave (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.previewDragLeave, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onDragLeave (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.dragLeave, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onPreviewDrop (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.previewDrop, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> onDrop (OnChange<TMessage, System.Windows.UIElement, System.Windows.DragEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (Events.uIElement.drop, h => (System.Windows.DragEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onPreviewTouchDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.previewTouchDown, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onTouchDown (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.touchDown, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onPreviewTouchMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.previewTouchMove, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onTouchMove (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.touchMove, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onPreviewTouchUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.previewTouchUp, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onTouchUp (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.touchUp, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onGotTouchCapture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.gotTouchCapture, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onLostTouchCapture (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.lostTouchCapture, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onTouchEnter (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.touchEnter, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> onTouchLeave (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.TouchEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (Events.uIElement.touchLeave, h => (System.EventHandler<System.Windows.Input.TouchEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onGotFocus (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.uIElement.gotFocus, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> onLostFocus (OnChange<TMessage, System.Windows.UIElement, System.Windows.RoutedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (Events.uIElement.lostFocus, h => (System.Windows.RoutedEventHandler)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>, System.Windows.Input.ManipulationStartingEventArgs> onManipulationStarting (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.ManipulationStartingEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>, System.Windows.Input.ManipulationStartingEventArgs> (Events.uIElement.manipulationStarting, h => (System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs> onManipulationStarted (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.ManipulationStartedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs> (Events.uIElement.manipulationStarted, h => (System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs> onManipulationDelta (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.ManipulationDeltaEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs> (Events.uIElement.manipulationDelta, h => (System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>, System.Windows.Input.ManipulationInertiaStartingEventArgs> onManipulationInertiaStarting (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.ManipulationInertiaStartingEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>, System.Windows.Input.ManipulationInertiaStartingEventArgs> (Events.uIElement.manipulationInertiaStarting, h => (System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> onManipulationBoundaryFeedback (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> (Events.uIElement.manipulationBoundaryFeedback, h => (System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>)h.Invoke, onChange);
      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs> onManipulationCompleted (OnChange<TMessage, System.Windows.UIElement, System.Windows.Input.ManipulationCompletedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs> (Events.uIElement.manipulationCompleted, h => (System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.UIElement>[] vs) => new StandardView<TMessage, System.Windows.UIElement>(vs);
    }

    public partial class uniformGrid : panel
    {
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.UniformGrid, System.Int32> firstColumn(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.UniformGrid, System.Int32>(Properties.uniformGrid.firstColumn, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.UniformGrid, System.Int32> columns(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.UniformGrid, System.Int32>(Properties.uniformGrid.columns, v);
      public static ISetValue<TMessage, System.Windows.Controls.Primitives.UniformGrid, System.Int32> rows(System.Int32 v) => new SetValue<TMessage, System.Windows.Controls.Primitives.UniformGrid, System.Int32>(Properties.uniformGrid.rows, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Primitives.UniformGrid>[] vs) => new StandardView<TMessage, System.Windows.Controls.Primitives.UniformGrid>(vs);
    }

    public partial class userControl : contentControl
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.UserControl>[] vs) => new StandardView<TMessage, System.Windows.Controls.UserControl>(vs);
    }

    public partial class webBrowser : activeXHost
    {


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.WebBrowser>[] vs) => new StandardView<TMessage, System.Windows.Controls.WebBrowser>(vs);
    }

    public partial class viewbox : decorator
    {
      public static ISetValue<TMessage, System.Windows.Controls.Viewbox, System.Windows.Media.Stretch> stretch(System.Windows.Media.Stretch v) => new SetValue<TMessage, System.Windows.Controls.Viewbox, System.Windows.Media.Stretch>(Properties.viewbox.stretch, v);
      public static ISetValue<TMessage, System.Windows.Controls.Viewbox, System.Windows.Controls.StretchDirection> stretchDirection(System.Windows.Controls.StretchDirection v) => new SetValue<TMessage, System.Windows.Controls.Viewbox, System.Windows.Controls.StretchDirection>(Properties.viewbox.stretchDirection, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Viewbox>[] vs) => new StandardView<TMessage, System.Windows.Controls.Viewbox>(vs);
    }

    public partial class viewport3D : frameworkElement
    {
      public static ISetValue<TMessage, System.Windows.Controls.Viewport3D, System.Windows.Media.Media3D.Camera> camera(System.Windows.Media.Media3D.Camera v) => new SetValue<TMessage, System.Windows.Controls.Viewport3D, System.Windows.Media.Media3D.Camera>(Properties.viewport3D.camera, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.Viewport3D>[] vs) => new StandardView<TMessage, System.Windows.Controls.Viewport3D>(vs);
    }

    public partial class window : contentControl
    {
      public static ISetValue<TMessage, System.Windows.Window, System.Windows.Shell.TaskbarItemInfo> taskbarItemInfo(System.Windows.Shell.TaskbarItemInfo v) => new SetValue<TMessage, System.Windows.Window, System.Windows.Shell.TaskbarItemInfo>(Properties.window.taskbarItemInfo, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Boolean> allowsTransparency(System.Boolean v) => new SetValue<TMessage, System.Windows.Window, System.Boolean>(Properties.window.allowsTransparency, v);
      public static ISetValue<TMessage, System.Windows.Window, System.String> title(System.String v) => new SetValue<TMessage, System.Windows.Window, System.String>(Properties.window.title, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Windows.Media.ImageSource> icon(System.Windows.Media.ImageSource v) => new SetValue<TMessage, System.Windows.Window, System.Windows.Media.ImageSource>(Properties.window.icon, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Windows.SizeToContent> sizeToContent(System.Windows.SizeToContent v) => new SetValue<TMessage, System.Windows.Window, System.Windows.SizeToContent>(Properties.window.sizeToContent, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Double> top(System.Double v) => new SetValue<TMessage, System.Windows.Window, System.Double>(Properties.window.top, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Double> left(System.Double v) => new SetValue<TMessage, System.Windows.Window, System.Double>(Properties.window.left, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Boolean> showInTaskbar(System.Boolean v) => new SetValue<TMessage, System.Windows.Window, System.Boolean>(Properties.window.showInTaskbar, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Windows.WindowStyle> windowStyle(System.Windows.WindowStyle v) => new SetValue<TMessage, System.Windows.Window, System.Windows.WindowStyle>(Properties.window.windowStyle, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Windows.WindowState> windowState(System.Windows.WindowState v) => new SetValue<TMessage, System.Windows.Window, System.Windows.WindowState>(Properties.window.windowState, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Windows.ResizeMode> resizeMode(System.Windows.ResizeMode v) => new SetValue<TMessage, System.Windows.Window, System.Windows.ResizeMode>(Properties.window.resizeMode, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Boolean> topmost(System.Boolean v) => new SetValue<TMessage, System.Windows.Window, System.Boolean>(Properties.window.topmost, v);
      public static ISetValue<TMessage, System.Windows.Window, System.Boolean> showActivated(System.Boolean v) => new SetValue<TMessage, System.Windows.Window, System.Boolean>(Properties.window.showActivated, v);

      public static IOnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> onDpiChanged (OnChange<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.UIElement, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> (Events.window.dpiChanged, h => (System.Windows.DpiChangedEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Window>[] vs) => new StandardView<TMessage, System.Windows.Window>(vs);
    }

    public partial class virtualizingPanel : panel
    {
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isVirtualizing(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.virtualizingPanel.isVirtualizing, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.VirtualizationMode> virtualizationMode(System.Windows.Controls.VirtualizationMode v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.VirtualizationMode>(Properties.virtualizingPanel.virtualizationMode, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isVirtualizingWhenGrouping(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.virtualizingPanel.isVirtualizingWhenGrouping, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollUnit> scrollUnit(System.Windows.Controls.ScrollUnit v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.ScrollUnit>(Properties.virtualizingPanel.scrollUnit, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLength> cacheLength(System.Windows.Controls.VirtualizationCacheLength v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLength>(Properties.virtualizingPanel.cacheLength, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLengthUnit> cacheLengthUnit(System.Windows.Controls.VirtualizationCacheLengthUnit v) => new SetValue<TMessage, System.Windows.UIElement, System.Windows.Controls.VirtualizationCacheLengthUnit>(Properties.virtualizingPanel.cacheLengthUnit, v);
      public static ISetValue<TMessage, System.Windows.UIElement, System.Boolean> isContainerVirtualizable(System.Boolean v) => new SetValue<TMessage, System.Windows.UIElement, System.Boolean>(Properties.virtualizingPanel.isContainerVirtualizable, v);


    }

    public partial class virtualizingStackPanel : virtualizingPanel
    {
      public static ISetValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Boolean> isVirtualizing(System.Boolean v) => new SetValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Boolean>(Properties.virtualizingStackPanel.isVirtualizing, v);
      public static ISetValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.VirtualizationMode> virtualizationMode(System.Windows.Controls.VirtualizationMode v) => new SetValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.VirtualizationMode>(Properties.virtualizingStackPanel.virtualizationMode, v);
      public static ISetValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.Orientation>(Properties.virtualizingStackPanel.orientation, v);

      public static IOnChangedValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.CleanUpVirtualizedItemEventHandler, System.Windows.Controls.CleanUpVirtualizedItemEventArgs> onCleanUpVirtualizedItem (OnChange<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.CleanUpVirtualizedItemEventArgs> onChange) =>
        new OnChangedValue<TMessage, System.Windows.Controls.VirtualizingStackPanel, System.Windows.Controls.CleanUpVirtualizedItemEventHandler, System.Windows.Controls.CleanUpVirtualizedItemEventArgs> (Events.virtualizingStackPanel.cleanUpVirtualizedItem, h => (System.Windows.Controls.CleanUpVirtualizedItemEventHandler)h.Invoke, onChange);

      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.VirtualizingStackPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.VirtualizingStackPanel>(vs);
    }

    public partial class wrapPanel : panel
    {
      public static ISetValue<TMessage, System.Windows.Controls.WrapPanel, System.Double> itemWidth(System.Double v) => new SetValue<TMessage, System.Windows.Controls.WrapPanel, System.Double>(Properties.wrapPanel.itemWidth, v);
      public static ISetValue<TMessage, System.Windows.Controls.WrapPanel, System.Double> itemHeight(System.Double v) => new SetValue<TMessage, System.Windows.Controls.WrapPanel, System.Double>(Properties.wrapPanel.itemHeight, v);
      public static ISetValue<TMessage, System.Windows.Controls.WrapPanel, System.Windows.Controls.Orientation> orientation(System.Windows.Controls.Orientation v) => new SetValue<TMessage, System.Windows.Controls.WrapPanel, System.Windows.Controls.Orientation>(Properties.wrapPanel.orientation, v);


      public static IView<TMessage> View(params IValue<TMessage, System.Windows.Controls.WrapPanel>[] vs) => new StandardView<TMessage, System.Windows.Controls.WrapPanel>(vs);
    }

  }
}
#pragma warning enable CS0108
