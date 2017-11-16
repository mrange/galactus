namespace Galactus

open System.Windows
open System.Windows.Controls
open System.Windows.Controls.Primitives
open System.Windows.Documents
open System.Windows.Navigation
open System.Windows.Shapes

open Galactus.Core

module Generated =

  module Properties =
    module AccessText = 
      let dummy = ()
      let text                                     = Property<System.String> System.Windows.Controls.AccessText.TextProperty
      let fontFamily                               = Property<System.Windows.Media.FontFamily> System.Windows.Controls.AccessText.FontFamilyProperty
      let fontStyle                                = Property<System.Windows.FontStyle> System.Windows.Controls.AccessText.FontStyleProperty
      let fontWeight                               = Property<System.Windows.FontWeight> System.Windows.Controls.AccessText.FontWeightProperty
      let fontStretch                              = Property<System.Windows.FontStretch> System.Windows.Controls.AccessText.FontStretchProperty
      let fontSize                                 = Property<System.Double> System.Windows.Controls.AccessText.FontSizeProperty
      let foreground                               = Property<System.Windows.Media.Brush> System.Windows.Controls.AccessText.ForegroundProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.AccessText.BackgroundProperty
      let textDecorations                          = Property<System.Windows.TextDecorationCollection> System.Windows.Controls.AccessText.TextDecorationsProperty
      let textEffects                              = Property<System.Windows.Media.TextEffectCollection> System.Windows.Controls.AccessText.TextEffectsProperty
      let lineHeight                               = Property<System.Double> System.Windows.Controls.AccessText.LineHeightProperty
      let lineStackingStrategy                     = Property<System.Windows.LineStackingStrategy> System.Windows.Controls.AccessText.LineStackingStrategyProperty
      let textAlignment                            = Property<System.Windows.TextAlignment> System.Windows.Controls.AccessText.TextAlignmentProperty
      let textTrimming                             = Property<System.Windows.TextTrimming> System.Windows.Controls.AccessText.TextTrimmingProperty
      let textWrapping                             = Property<System.Windows.TextWrapping> System.Windows.Controls.AccessText.TextWrappingProperty
      let baselineOffset                           = Property<System.Double> System.Windows.Controls.AccessText.BaselineOffsetProperty

    module ActiveXHost = 
      let dummy = ()

    module AdornedElementPlaceholder = 
      let dummy = ()

    module Adorner = 
      let dummy = ()

    module AdornerDecorator = 
      let dummy = ()

    module AdornerLayer = 
      let dummy = ()

    module Border = 
      let dummy = ()
      let borderThickness                          = Property<System.Windows.Thickness> System.Windows.Controls.Border.BorderThicknessProperty
      let padding                                  = Property<System.Windows.Thickness> System.Windows.Controls.Border.PaddingProperty
      let cornerRadius                             = Property<System.Windows.CornerRadius> System.Windows.Controls.Border.CornerRadiusProperty
      let borderBrush                              = Property<System.Windows.Media.Brush> System.Windows.Controls.Border.BorderBrushProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Border.BackgroundProperty

    module BulletDecorator = 
      let dummy = ()
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.BulletDecorator.BackgroundProperty

    module Button = 
      let dummy = ()
      let isDefault                                = Property<System.Boolean> System.Windows.Controls.Button.IsDefaultProperty
      let isCancel                                 = Property<System.Boolean> System.Windows.Controls.Button.IsCancelProperty
      let isDefaulted                              = Property<System.Boolean> System.Windows.Controls.Button.IsDefaultedProperty

    module ButtonBase = 
      let dummy = ()
      let command                                  = Property<System.Windows.Input.ICommand> System.Windows.Controls.Primitives.ButtonBase.CommandProperty
      let commandParameter                         = Property<System.Object> System.Windows.Controls.Primitives.ButtonBase.CommandParameterProperty
      let commandTarget                            = Property<System.Windows.IInputElement> System.Windows.Controls.Primitives.ButtonBase.CommandTargetProperty
      let isPressed                                = Property<System.Boolean> System.Windows.Controls.Primitives.ButtonBase.IsPressedProperty
      let clickMode                                = Property<System.Windows.Controls.ClickMode> System.Windows.Controls.Primitives.ButtonBase.ClickModeProperty

    module Calendar = 
      let dummy = ()
      let calendarButtonStyle                      = Property<System.Windows.Style> System.Windows.Controls.Calendar.CalendarButtonStyleProperty
      let calendarDayButtonStyle                   = Property<System.Windows.Style> System.Windows.Controls.Calendar.CalendarDayButtonStyleProperty
      let calendarItemStyle                        = Property<System.Windows.Style> System.Windows.Controls.Calendar.CalendarItemStyleProperty
      let displayDate                              = Property<System.DateTime> System.Windows.Controls.Calendar.DisplayDateProperty
      let displayDateEnd                           = Property<System.Nullable<System.DateTime>> System.Windows.Controls.Calendar.DisplayDateEndProperty
      let displayDateStart                         = Property<System.Nullable<System.DateTime>> System.Windows.Controls.Calendar.DisplayDateStartProperty
      let displayMode                              = Property<System.Windows.Controls.CalendarMode> System.Windows.Controls.Calendar.DisplayModeProperty
      let firstDayOfWeek                           = Property<System.DayOfWeek> System.Windows.Controls.Calendar.FirstDayOfWeekProperty
      let isTodayHighlighted                       = Property<System.Boolean> System.Windows.Controls.Calendar.IsTodayHighlightedProperty
      let selectedDate                             = Property<System.Nullable<System.DateTime>> System.Windows.Controls.Calendar.SelectedDateProperty
      let selectionMode                            = Property<System.Windows.Controls.CalendarSelectionMode> System.Windows.Controls.Calendar.SelectionModeProperty

    module CalendarButton = 
      let dummy = ()
      let hasSelectedDays                          = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarButton.HasSelectedDaysProperty
      let isInactive                               = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarButton.IsInactiveProperty

    module CalendarDayButton = 
      let dummy = ()
      let isToday                                  = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsTodayProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsSelectedProperty
      let isInactive                               = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsInactiveProperty
      let isBlackedOut                             = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsBlackedOutProperty
      let isHighlighted                            = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsHighlightedProperty

    module CalendarItem = 
      let dummy = ()

    module Canvas = 
      let dummy = ()
      let left                                     = Property<System.Double> System.Windows.Controls.Canvas.LeftProperty
      let top                                      = Property<System.Double> System.Windows.Controls.Canvas.TopProperty
      let right                                    = Property<System.Double> System.Windows.Controls.Canvas.RightProperty
      let bottom                                   = Property<System.Double> System.Windows.Controls.Canvas.BottomProperty

    module CheckBox = 
      let dummy = ()

    module ComboBox = 
      let dummy = ()
      let maxDropDownHeight                        = Property<System.Double> System.Windows.Controls.ComboBox.MaxDropDownHeightProperty
      let isDropDownOpen                           = Property<System.Boolean> System.Windows.Controls.ComboBox.IsDropDownOpenProperty
      let shouldPreserveUserEnteredPrefix          = Property<System.Boolean> System.Windows.Controls.ComboBox.ShouldPreserveUserEnteredPrefixProperty
      let isEditable                               = Property<System.Boolean> System.Windows.Controls.ComboBox.IsEditableProperty
      let text                                     = Property<System.String> System.Windows.Controls.ComboBox.TextProperty
      let isReadOnly                               = Property<System.Boolean> System.Windows.Controls.ComboBox.IsReadOnlyProperty
      let selectionBoxItem                         = Property<System.Object> System.Windows.Controls.ComboBox.SelectionBoxItemProperty
      let selectionBoxItemTemplate                 = Property<System.Windows.DataTemplate> System.Windows.Controls.ComboBox.SelectionBoxItemTemplateProperty
      let selectionBoxItemStringFormat             = Property<System.String> System.Windows.Controls.ComboBox.SelectionBoxItemStringFormatProperty
      let staysOpenOnEdit                          = Property<System.Boolean> System.Windows.Controls.ComboBox.StaysOpenOnEditProperty

    module ComboBoxItem = 
      let dummy = ()
      let isHighlighted                            = Property<System.Boolean> System.Windows.Controls.ComboBoxItem.IsHighlightedProperty

    module ContentControl = 
      let dummy = ()
      let content                                  = Property<System.Object> System.Windows.Controls.ContentControl.ContentProperty
      let hasContent                               = Property<System.Boolean> System.Windows.Controls.ContentControl.HasContentProperty
      let contentTemplate                          = Property<System.Windows.DataTemplate> System.Windows.Controls.ContentControl.ContentTemplateProperty
      let contentTemplateSelector                  = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty
      let contentStringFormat                      = Property<System.String> System.Windows.Controls.ContentControl.ContentStringFormatProperty

    module ContentPresenter = 
      let dummy = ()
      let recognizesAccessKey                      = Property<System.Boolean> System.Windows.Controls.ContentPresenter.RecognizesAccessKeyProperty
      let content                                  = Property<System.Object> System.Windows.Controls.ContentPresenter.ContentProperty
      let contentTemplate                          = Property<System.Windows.DataTemplate> System.Windows.Controls.ContentPresenter.ContentTemplateProperty
      let contentTemplateSelector                  = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty
      let contentStringFormat                      = Property<System.String> System.Windows.Controls.ContentPresenter.ContentStringFormatProperty
      let contentSource                            = Property<System.String> System.Windows.Controls.ContentPresenter.ContentSourceProperty

    module ContextMenu = 
      let dummy = ()
      let horizontalOffset                         = Property<System.Double> System.Windows.Controls.ContextMenu.HorizontalOffsetProperty
      let verticalOffset                           = Property<System.Double> System.Windows.Controls.ContextMenu.VerticalOffsetProperty
      let isOpen                                   = Property<System.Boolean> System.Windows.Controls.ContextMenu.IsOpenProperty
      let placementTarget                          = Property<System.Windows.UIElement> System.Windows.Controls.ContextMenu.PlacementTargetProperty
      let placementRectangle                       = Property<System.Windows.Rect> System.Windows.Controls.ContextMenu.PlacementRectangleProperty
      let placement                                = Property<System.Windows.Controls.Primitives.PlacementMode> System.Windows.Controls.ContextMenu.PlacementProperty
      let hasDropShadow                            = Property<System.Boolean> System.Windows.Controls.ContextMenu.HasDropShadowProperty
      let customPopupPlacementCallback             = Property<System.Windows.Controls.Primitives.CustomPopupPlacementCallback> System.Windows.Controls.ContextMenu.CustomPopupPlacementCallbackProperty
      let staysOpen                                = Property<System.Boolean> System.Windows.Controls.ContextMenu.StaysOpenProperty

    module Control = 
      let dummy = ()
      let borderBrush                              = Property<System.Windows.Media.Brush> System.Windows.Controls.Control.BorderBrushProperty
      let borderThickness                          = Property<System.Windows.Thickness> System.Windows.Controls.Control.BorderThicknessProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Control.BackgroundProperty
      let foreground                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Control.ForegroundProperty
      let fontFamily                               = Property<System.Windows.Media.FontFamily> System.Windows.Controls.Control.FontFamilyProperty
      let fontSize                                 = Property<System.Double> System.Windows.Controls.Control.FontSizeProperty
      let fontStretch                              = Property<System.Windows.FontStretch> System.Windows.Controls.Control.FontStretchProperty
      let fontStyle                                = Property<System.Windows.FontStyle> System.Windows.Controls.Control.FontStyleProperty
      let fontWeight                               = Property<System.Windows.FontWeight> System.Windows.Controls.Control.FontWeightProperty
      let horizontalContentAlignment               = Property<System.Windows.HorizontalAlignment> System.Windows.Controls.Control.HorizontalContentAlignmentProperty
      let verticalContentAlignment                 = Property<System.Windows.VerticalAlignment> System.Windows.Controls.Control.VerticalContentAlignmentProperty
      let tabIndex                                 = Property<System.Int32> System.Windows.Controls.Control.TabIndexProperty
      let isTabStop                                = Property<System.Boolean> System.Windows.Controls.Control.IsTabStopProperty
      let padding                                  = Property<System.Windows.Thickness> System.Windows.Controls.Control.PaddingProperty
      let template                                 = Property<System.Windows.Controls.ControlTemplate> System.Windows.Controls.Control.TemplateProperty

    module DataGrid = 
      let dummy = ()
      let canUserResizeColumns                     = Property<System.Boolean> System.Windows.Controls.DataGrid.CanUserResizeColumnsProperty
      let columnWidth                              = Property<System.Windows.Controls.DataGridLength> System.Windows.Controls.DataGrid.ColumnWidthProperty
      let minColumnWidth                           = Property<System.Double> System.Windows.Controls.DataGrid.MinColumnWidthProperty
      let maxColumnWidth                           = Property<System.Double> System.Windows.Controls.DataGrid.MaxColumnWidthProperty
      let gridLinesVisibility                      = Property<System.Windows.Controls.DataGridGridLinesVisibility> System.Windows.Controls.DataGrid.GridLinesVisibilityProperty
      let horizontalGridLinesBrush                 = Property<System.Windows.Media.Brush> System.Windows.Controls.DataGrid.HorizontalGridLinesBrushProperty
      let verticalGridLinesBrush                   = Property<System.Windows.Media.Brush> System.Windows.Controls.DataGrid.VerticalGridLinesBrushProperty
      let rowStyle                                 = Property<System.Windows.Style> System.Windows.Controls.DataGrid.RowStyleProperty
      let rowValidationErrorTemplate               = Property<System.Windows.Controls.ControlTemplate> System.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty
      let rowStyleSelector                         = Property<System.Windows.Controls.StyleSelector> System.Windows.Controls.DataGrid.RowStyleSelectorProperty
      let rowBackground                            = Property<System.Windows.Media.Brush> System.Windows.Controls.DataGrid.RowBackgroundProperty
      let alternatingRowBackground                 = Property<System.Windows.Media.Brush> System.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty
      let rowHeight                                = Property<System.Double> System.Windows.Controls.DataGrid.RowHeightProperty
      let minRowHeight                             = Property<System.Double> System.Windows.Controls.DataGrid.MinRowHeightProperty
      let rowHeaderWidth                           = Property<System.Double> System.Windows.Controls.DataGrid.RowHeaderWidthProperty
      let rowHeaderActualWidth                     = Property<System.Double> System.Windows.Controls.DataGrid.RowHeaderActualWidthProperty
      let columnHeaderHeight                       = Property<System.Double> System.Windows.Controls.DataGrid.ColumnHeaderHeightProperty
      let headersVisibility                        = Property<System.Windows.Controls.DataGridHeadersVisibility> System.Windows.Controls.DataGrid.HeadersVisibilityProperty
      let cellStyle                                = Property<System.Windows.Style> System.Windows.Controls.DataGrid.CellStyleProperty
      let columnHeaderStyle                        = Property<System.Windows.Style> System.Windows.Controls.DataGrid.ColumnHeaderStyleProperty
      let rowHeaderStyle                           = Property<System.Windows.Style> System.Windows.Controls.DataGrid.RowHeaderStyleProperty
      let rowHeaderTemplate                        = Property<System.Windows.DataTemplate> System.Windows.Controls.DataGrid.RowHeaderTemplateProperty
      let rowHeaderTemplateSelector                = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty
      let horizontalScrollBarVisibility            = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.DataGrid.HorizontalScrollBarVisibilityProperty
      let verticalScrollBarVisibility              = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.DataGrid.VerticalScrollBarVisibilityProperty
      let isReadOnly                               = Property<System.Boolean> System.Windows.Controls.DataGrid.IsReadOnlyProperty
      let currentItem                              = Property<System.Object> System.Windows.Controls.DataGrid.CurrentItemProperty
      let currentColumn                            = Property<System.Windows.Controls.DataGridColumn> System.Windows.Controls.DataGrid.CurrentColumnProperty
      let currentCell                              = Property<System.Windows.Controls.DataGridCellInfo> System.Windows.Controls.DataGrid.CurrentCellProperty
      let canUserAddRows                           = Property<System.Boolean> System.Windows.Controls.DataGrid.CanUserAddRowsProperty
      let canUserDeleteRows                        = Property<System.Boolean> System.Windows.Controls.DataGrid.CanUserDeleteRowsProperty
      let rowDetailsVisibilityMode                 = Property<System.Windows.Controls.DataGridRowDetailsVisibilityMode> System.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty
      let areRowDetailsFrozen                      = Property<System.Boolean> System.Windows.Controls.DataGrid.AreRowDetailsFrozenProperty
      let rowDetailsTemplate                       = Property<System.Windows.DataTemplate> System.Windows.Controls.DataGrid.RowDetailsTemplateProperty
      let rowDetailsTemplateSelector               = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty
      let canUserResizeRows                        = Property<System.Boolean> System.Windows.Controls.DataGrid.CanUserResizeRowsProperty
      let newItemMargin                            = Property<System.Windows.Thickness> System.Windows.Controls.DataGrid.NewItemMarginProperty
      let selectionMode                            = Property<System.Windows.Controls.DataGridSelectionMode> System.Windows.Controls.DataGrid.SelectionModeProperty
      let selectionUnit                            = Property<System.Windows.Controls.DataGridSelectionUnit> System.Windows.Controls.DataGrid.SelectionUnitProperty
      let canUserSortColumns                       = Property<System.Boolean> System.Windows.Controls.DataGrid.CanUserSortColumnsProperty
      let autoGenerateColumns                      = Property<System.Boolean> System.Windows.Controls.DataGrid.AutoGenerateColumnsProperty
      let frozenColumnCount                        = Property<System.Int32> System.Windows.Controls.DataGrid.FrozenColumnCountProperty
      let nonFrozenColumnsViewportHorizontalOffset = Property<System.Double> System.Windows.Controls.DataGrid.NonFrozenColumnsViewportHorizontalOffsetProperty
      let enableRowVirtualization                  = Property<System.Boolean> System.Windows.Controls.DataGrid.EnableRowVirtualizationProperty
      let enableColumnVirtualization               = Property<System.Boolean> System.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty
      let canUserReorderColumns                    = Property<System.Boolean> System.Windows.Controls.DataGrid.CanUserReorderColumnsProperty
      let dragIndicatorStyle                       = Property<System.Windows.Style> System.Windows.Controls.DataGrid.DragIndicatorStyleProperty
      let dropLocationIndicatorStyle               = Property<System.Windows.Style> System.Windows.Controls.DataGrid.DropLocationIndicatorStyleProperty
      let clipboardCopyMode                        = Property<System.Windows.Controls.DataGridClipboardCopyMode> System.Windows.Controls.DataGrid.ClipboardCopyModeProperty
      let cellsPanelHorizontalOffset               = Property<System.Double> System.Windows.Controls.DataGrid.CellsPanelHorizontalOffsetProperty

    module DataGridCell = 
      let dummy = ()
      let column                                   = Property<System.Windows.Controls.DataGridColumn> System.Windows.Controls.DataGridCell.ColumnProperty
      let isEditing                                = Property<System.Boolean> System.Windows.Controls.DataGridCell.IsEditingProperty
      let isReadOnly                               = Property<System.Boolean> System.Windows.Controls.DataGridCell.IsReadOnlyProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.DataGridCell.IsSelectedProperty

    module DataGridCellsPanel = 
      let dummy = ()

    module DataGridCellsPresenter = 
      let dummy = ()

    module DataGridColumnHeader = 
      let dummy = ()
      let separatorBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorBrushProperty
      let separatorVisibility                      = Property<System.Windows.Visibility> System.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorVisibilityProperty
      let displayIndex                             = Property<System.Int32> System.Windows.Controls.Primitives.DataGridColumnHeader.DisplayIndexProperty
      let canUserSort                              = Property<System.Boolean> System.Windows.Controls.Primitives.DataGridColumnHeader.CanUserSortProperty
      let sortDirection                            = Property<System.Nullable<System.ComponentModel.ListSortDirection>> System.Windows.Controls.Primitives.DataGridColumnHeader.SortDirectionProperty
      let isFrozen                                 = Property<System.Boolean> System.Windows.Controls.Primitives.DataGridColumnHeader.IsFrozenProperty

    module DataGridColumnHeadersPresenter = 
      let dummy = ()

    module DataGridDetailsPresenter = 
      let dummy = ()

    module DataGridRow = 
      let dummy = ()
      let item                                     = Property<System.Object> System.Windows.Controls.DataGridRow.ItemProperty
      let itemsPanel                               = Property<System.Windows.Controls.ItemsPanelTemplate> System.Windows.Controls.DataGridRow.ItemsPanelProperty
      let header                                   = Property<System.Object> System.Windows.Controls.DataGridRow.HeaderProperty
      let headerStyle                              = Property<System.Windows.Style> System.Windows.Controls.DataGridRow.HeaderStyleProperty
      let headerTemplate                           = Property<System.Windows.DataTemplate> System.Windows.Controls.DataGridRow.HeaderTemplateProperty
      let headerTemplateSelector                   = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty
      let validationErrorTemplate                  = Property<System.Windows.Controls.ControlTemplate> System.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty
      let detailsTemplate                          = Property<System.Windows.DataTemplate> System.Windows.Controls.DataGridRow.DetailsTemplateProperty
      let detailsTemplateSelector                  = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty
      let detailsVisibility                        = Property<System.Windows.Visibility> System.Windows.Controls.DataGridRow.DetailsVisibilityProperty
      let alternationIndex                         = Property<System.Int32> System.Windows.Controls.DataGridRow.AlternationIndexProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.DataGridRow.IsSelectedProperty
      let isEditing                                = Property<System.Boolean> System.Windows.Controls.DataGridRow.IsEditingProperty
      let isNewItem                                = Property<System.Boolean> System.Windows.Controls.DataGridRow.IsNewItemProperty

    module DataGridRowHeader = 
      let dummy = ()
      let separatorBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.DataGridRowHeader.SeparatorBrushProperty
      let separatorVisibility                      = Property<System.Windows.Visibility> System.Windows.Controls.Primitives.DataGridRowHeader.SeparatorVisibilityProperty
      let isRowSelected                            = Property<System.Boolean> System.Windows.Controls.Primitives.DataGridRowHeader.IsRowSelectedProperty

    module DataGridRowsPresenter = 
      let dummy = ()

    module DatePicker = 
      let dummy = ()
      let calendarStyle                            = Property<System.Windows.Style> System.Windows.Controls.DatePicker.CalendarStyleProperty
      let displayDate                              = Property<System.DateTime> System.Windows.Controls.DatePicker.DisplayDateProperty
      let displayDateEnd                           = Property<System.Nullable<System.DateTime>> System.Windows.Controls.DatePicker.DisplayDateEndProperty
      let displayDateStart                         = Property<System.Nullable<System.DateTime>> System.Windows.Controls.DatePicker.DisplayDateStartProperty
      let firstDayOfWeek                           = Property<System.DayOfWeek> System.Windows.Controls.DatePicker.FirstDayOfWeekProperty
      let isDropDownOpen                           = Property<System.Boolean> System.Windows.Controls.DatePicker.IsDropDownOpenProperty
      let isTodayHighlighted                       = Property<System.Boolean> System.Windows.Controls.DatePicker.IsTodayHighlightedProperty
      let selectedDate                             = Property<System.Nullable<System.DateTime>> System.Windows.Controls.DatePicker.SelectedDateProperty
      let selectedDateFormat                       = Property<System.Windows.Controls.DatePickerFormat> System.Windows.Controls.DatePicker.SelectedDateFormatProperty
      let text                                     = Property<System.String> System.Windows.Controls.DatePicker.TextProperty

    module DatePickerTextBox = 
      let dummy = ()

    module Decorator = 
      let dummy = ()

    module DockPanel = 
      let dummy = ()
      let lastChildFill                            = Property<System.Boolean> System.Windows.Controls.DockPanel.LastChildFillProperty
      let dock                                     = Property<System.Windows.Controls.Dock> System.Windows.Controls.DockPanel.DockProperty

    module DocumentPageView = 
      let dummy = ()
      let pageNumber                               = Property<System.Int32> System.Windows.Controls.Primitives.DocumentPageView.PageNumberProperty
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Controls.Primitives.DocumentPageView.StretchProperty
      let stretchDirection                         = Property<System.Windows.Controls.StretchDirection> System.Windows.Controls.Primitives.DocumentPageView.StretchDirectionProperty

    module DocumentReference = 
      let dummy = ()
      let source                                   = Property<System.Uri> System.Windows.Documents.DocumentReference.SourceProperty

    module DocumentViewer = 
      let dummy = ()
      let horizontalOffset                         = Property<System.Double> System.Windows.Controls.DocumentViewer.HorizontalOffsetProperty
      let verticalOffset                           = Property<System.Double> System.Windows.Controls.DocumentViewer.VerticalOffsetProperty
      let extentWidth                              = Property<System.Double> System.Windows.Controls.DocumentViewer.ExtentWidthProperty
      let extentHeight                             = Property<System.Double> System.Windows.Controls.DocumentViewer.ExtentHeightProperty
      let viewportWidth                            = Property<System.Double> System.Windows.Controls.DocumentViewer.ViewportWidthProperty
      let viewportHeight                           = Property<System.Double> System.Windows.Controls.DocumentViewer.ViewportHeightProperty
      let showPageBorders                          = Property<System.Boolean> System.Windows.Controls.DocumentViewer.ShowPageBordersProperty
      let zoom                                     = Property<System.Double> System.Windows.Controls.DocumentViewer.ZoomProperty
      let maxPagesAcross                           = Property<System.Int32> System.Windows.Controls.DocumentViewer.MaxPagesAcrossProperty
      let verticalPageSpacing                      = Property<System.Double> System.Windows.Controls.DocumentViewer.VerticalPageSpacingProperty
      let horizontalPageSpacing                    = Property<System.Double> System.Windows.Controls.DocumentViewer.HorizontalPageSpacingProperty
      let canMoveUp                                = Property<System.Boolean> System.Windows.Controls.DocumentViewer.CanMoveUpProperty
      let canMoveDown                              = Property<System.Boolean> System.Windows.Controls.DocumentViewer.CanMoveDownProperty
      let canMoveLeft                              = Property<System.Boolean> System.Windows.Controls.DocumentViewer.CanMoveLeftProperty
      let canMoveRight                             = Property<System.Boolean> System.Windows.Controls.DocumentViewer.CanMoveRightProperty
      let canIncreaseZoom                          = Property<System.Boolean> System.Windows.Controls.DocumentViewer.CanIncreaseZoomProperty
      let canDecreaseZoom                          = Property<System.Boolean> System.Windows.Controls.DocumentViewer.CanDecreaseZoomProperty

    module DocumentViewerBase = 
      let dummy = ()
      let document                                 = Property<System.Windows.Documents.IDocumentPaginatorSource> System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty
      let pageCount                                = Property<System.Int32> System.Windows.Controls.Primitives.DocumentViewerBase.PageCountProperty
      let masterPageNumber                         = Property<System.Int32> System.Windows.Controls.Primitives.DocumentViewerBase.MasterPageNumberProperty
      let canGoToPreviousPage                      = Property<System.Boolean> System.Windows.Controls.Primitives.DocumentViewerBase.CanGoToPreviousPageProperty
      let canGoToNextPage                          = Property<System.Boolean> System.Windows.Controls.Primitives.DocumentViewerBase.CanGoToNextPageProperty
      let isMasterPage                             = Property<System.Boolean> System.Windows.Controls.Primitives.DocumentViewerBase.IsMasterPageProperty

    module Ellipse = 
      let dummy = ()

    module Expander = 
      let dummy = ()
      let expandDirection                          = Property<System.Windows.Controls.ExpandDirection> System.Windows.Controls.Expander.ExpandDirectionProperty
      let isExpanded                               = Property<System.Boolean> System.Windows.Controls.Expander.IsExpandedProperty

    module FixedPage = 
      let dummy = ()
      let printTicket                              = Property<System.Object> System.Windows.Documents.FixedPage.PrintTicketProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Documents.FixedPage.BackgroundProperty
      let left                                     = Property<System.Double> System.Windows.Documents.FixedPage.LeftProperty
      let top                                      = Property<System.Double> System.Windows.Documents.FixedPage.TopProperty
      let right                                    = Property<System.Double> System.Windows.Documents.FixedPage.RightProperty
      let bottom                                   = Property<System.Double> System.Windows.Documents.FixedPage.BottomProperty
      let contentBox                               = Property<System.Windows.Rect> System.Windows.Documents.FixedPage.ContentBoxProperty
      let bleedBox                                 = Property<System.Windows.Rect> System.Windows.Documents.FixedPage.BleedBoxProperty
      let navigateUri                              = Property<System.Uri> System.Windows.Documents.FixedPage.NavigateUriProperty

    module FlowDocumentPageViewer = 
      let dummy = ()
      let zoom                                     = Property<System.Double> System.Windows.Controls.FlowDocumentPageViewer.ZoomProperty
      let maxZoom                                  = Property<System.Double> System.Windows.Controls.FlowDocumentPageViewer.MaxZoomProperty
      let minZoom                                  = Property<System.Double> System.Windows.Controls.FlowDocumentPageViewer.MinZoomProperty
      let zoomIncrement                            = Property<System.Double> System.Windows.Controls.FlowDocumentPageViewer.ZoomIncrementProperty
      let canIncreaseZoom                          = Property<System.Boolean> System.Windows.Controls.FlowDocumentPageViewer.CanIncreaseZoomProperty
      let canDecreaseZoom                          = Property<System.Boolean> System.Windows.Controls.FlowDocumentPageViewer.CanDecreaseZoomProperty
      let selectionBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.FlowDocumentPageViewer.SelectionBrushProperty
      let selectionOpacity                         = Property<System.Double> System.Windows.Controls.FlowDocumentPageViewer.SelectionOpacityProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.FlowDocumentPageViewer.IsSelectionActiveProperty
      let isInactiveSelectionHighlightEnabled      = Property<System.Boolean> System.Windows.Controls.FlowDocumentPageViewer.IsInactiveSelectionHighlightEnabledProperty

    module FlowDocumentReader = 
      let dummy = ()
      let viewingMode                              = Property<System.Windows.Controls.FlowDocumentReaderViewingMode> System.Windows.Controls.FlowDocumentReader.ViewingModeProperty
      let isPageViewEnabled                        = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.IsPageViewEnabledProperty
      let isTwoPageViewEnabled                     = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.IsTwoPageViewEnabledProperty
      let isScrollViewEnabled                      = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.IsScrollViewEnabledProperty
      let pageCount                                = Property<System.Int32> System.Windows.Controls.FlowDocumentReader.PageCountProperty
      let pageNumber                               = Property<System.Int32> System.Windows.Controls.FlowDocumentReader.PageNumberProperty
      let canGoToPreviousPage                      = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.CanGoToPreviousPageProperty
      let canGoToNextPage                          = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.CanGoToNextPageProperty
      let isFindEnabled                            = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.IsFindEnabledProperty
      let isPrintEnabled                           = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.IsPrintEnabledProperty
      let document                                 = Property<System.Windows.Documents.FlowDocument> System.Windows.Controls.FlowDocumentReader.DocumentProperty
      let zoom                                     = Property<System.Double> System.Windows.Controls.FlowDocumentReader.ZoomProperty
      let maxZoom                                  = Property<System.Double> System.Windows.Controls.FlowDocumentReader.MaxZoomProperty
      let minZoom                                  = Property<System.Double> System.Windows.Controls.FlowDocumentReader.MinZoomProperty
      let zoomIncrement                            = Property<System.Double> System.Windows.Controls.FlowDocumentReader.ZoomIncrementProperty
      let canIncreaseZoom                          = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.CanIncreaseZoomProperty
      let canDecreaseZoom                          = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.CanDecreaseZoomProperty
      let selectionBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.FlowDocumentReader.SelectionBrushProperty
      let selectionOpacity                         = Property<System.Double> System.Windows.Controls.FlowDocumentReader.SelectionOpacityProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.IsSelectionActiveProperty
      let isInactiveSelectionHighlightEnabled      = Property<System.Boolean> System.Windows.Controls.FlowDocumentReader.IsInactiveSelectionHighlightEnabledProperty

    module FlowDocumentScrollViewer = 
      let dummy = ()
      let document                                 = Property<System.Windows.Documents.FlowDocument> System.Windows.Controls.FlowDocumentScrollViewer.DocumentProperty
      let zoom                                     = Property<System.Double> System.Windows.Controls.FlowDocumentScrollViewer.ZoomProperty
      let maxZoom                                  = Property<System.Double> System.Windows.Controls.FlowDocumentScrollViewer.MaxZoomProperty
      let minZoom                                  = Property<System.Double> System.Windows.Controls.FlowDocumentScrollViewer.MinZoomProperty
      let zoomIncrement                            = Property<System.Double> System.Windows.Controls.FlowDocumentScrollViewer.ZoomIncrementProperty
      let canIncreaseZoom                          = Property<System.Boolean> System.Windows.Controls.FlowDocumentScrollViewer.CanIncreaseZoomProperty
      let canDecreaseZoom                          = Property<System.Boolean> System.Windows.Controls.FlowDocumentScrollViewer.CanDecreaseZoomProperty
      let isSelectionEnabled                       = Property<System.Boolean> System.Windows.Controls.FlowDocumentScrollViewer.IsSelectionEnabledProperty
      let isToolBarVisible                         = Property<System.Boolean> System.Windows.Controls.FlowDocumentScrollViewer.IsToolBarVisibleProperty
      let horizontalScrollBarVisibility            = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.FlowDocumentScrollViewer.HorizontalScrollBarVisibilityProperty
      let verticalScrollBarVisibility              = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.FlowDocumentScrollViewer.VerticalScrollBarVisibilityProperty
      let selectionBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.FlowDocumentScrollViewer.SelectionBrushProperty
      let selectionOpacity                         = Property<System.Double> System.Windows.Controls.FlowDocumentScrollViewer.SelectionOpacityProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.FlowDocumentScrollViewer.IsSelectionActiveProperty
      let isInactiveSelectionHighlightEnabled      = Property<System.Boolean> System.Windows.Controls.FlowDocumentScrollViewer.IsInactiveSelectionHighlightEnabledProperty

    module Frame = 
      let dummy = ()
      let source                                   = Property<System.Uri> System.Windows.Controls.Frame.SourceProperty
      let canGoBack                                = Property<System.Boolean> System.Windows.Controls.Frame.CanGoBackProperty
      let canGoForward                             = Property<System.Boolean> System.Windows.Controls.Frame.CanGoForwardProperty
      let backStack                                = Property<System.Collections.IEnumerable> System.Windows.Controls.Frame.BackStackProperty
      let forwardStack                             = Property<System.Collections.IEnumerable> System.Windows.Controls.Frame.ForwardStackProperty
      let navigationUIVisibility                   = Property<System.Windows.Navigation.NavigationUIVisibility> System.Windows.Controls.Frame.NavigationUIVisibilityProperty
      let sandboxExternalContent                   = Property<System.Boolean> System.Windows.Controls.Frame.SandboxExternalContentProperty
      let journalOwnership                         = Property<System.Windows.Navigation.JournalOwnership> System.Windows.Controls.Frame.JournalOwnershipProperty

    module FrameworkElement = 
      let dummy = ()
      let style                                    = Property<System.Windows.Style> System.Windows.FrameworkElement.StyleProperty
      let overridesDefaultStyle                    = Property<System.Boolean> System.Windows.FrameworkElement.OverridesDefaultStyleProperty
      let useLayoutRounding                        = Property<System.Boolean> System.Windows.FrameworkElement.UseLayoutRoundingProperty
      let dataContext                              = Property<System.Object> System.Windows.FrameworkElement.DataContextProperty
      let bindingGroup                             = Property<System.Windows.Data.BindingGroup> System.Windows.FrameworkElement.BindingGroupProperty
      let language                                 = Property<System.Windows.Markup.XmlLanguage> System.Windows.FrameworkElement.LanguageProperty
      let name                                     = Property<System.String> System.Windows.FrameworkElement.NameProperty
      let tag                                      = Property<System.Object> System.Windows.FrameworkElement.TagProperty
      let inputScope                               = Property<System.Windows.Input.InputScope> System.Windows.FrameworkElement.InputScopeProperty
      let actualWidth                              = Property<System.Double> System.Windows.FrameworkElement.ActualWidthProperty
      let actualHeight                             = Property<System.Double> System.Windows.FrameworkElement.ActualHeightProperty
      let layoutTransform                          = Property<System.Windows.Media.Transform> System.Windows.FrameworkElement.LayoutTransformProperty
      let width                                    = Property<System.Double> System.Windows.FrameworkElement.WidthProperty
      let minWidth                                 = Property<System.Double> System.Windows.FrameworkElement.MinWidthProperty
      let maxWidth                                 = Property<System.Double> System.Windows.FrameworkElement.MaxWidthProperty
      let height                                   = Property<System.Double> System.Windows.FrameworkElement.HeightProperty
      let minHeight                                = Property<System.Double> System.Windows.FrameworkElement.MinHeightProperty
      let maxHeight                                = Property<System.Double> System.Windows.FrameworkElement.MaxHeightProperty
      let flowDirection                            = Property<System.Windows.FlowDirection> System.Windows.FrameworkElement.FlowDirectionProperty
      let margin                                   = Property<System.Windows.Thickness> System.Windows.FrameworkElement.MarginProperty
      let horizontalAlignment                      = Property<System.Windows.HorizontalAlignment> System.Windows.FrameworkElement.HorizontalAlignmentProperty
      let verticalAlignment                        = Property<System.Windows.VerticalAlignment> System.Windows.FrameworkElement.VerticalAlignmentProperty
      let focusVisualStyle                         = Property<System.Windows.Style> System.Windows.FrameworkElement.FocusVisualStyleProperty
      let cursor                                   = Property<System.Windows.Input.Cursor> System.Windows.FrameworkElement.CursorProperty
      let forceCursor                              = Property<System.Boolean> System.Windows.FrameworkElement.ForceCursorProperty
      let toolTip                                  = Property<System.Object> System.Windows.FrameworkElement.ToolTipProperty
      let contextMenu                              = Property<System.Windows.Controls.ContextMenu> System.Windows.FrameworkElement.ContextMenuProperty

    module Glyphs = 
      let dummy = ()
      let fill                                     = Property<System.Windows.Media.Brush> System.Windows.Documents.Glyphs.FillProperty
      let indices                                  = Property<System.String> System.Windows.Documents.Glyphs.IndicesProperty
      let unicodeString                            = Property<System.String> System.Windows.Documents.Glyphs.UnicodeStringProperty
      let caretStops                               = Property<System.String> System.Windows.Documents.Glyphs.CaretStopsProperty
      let fontRenderingEmSize                      = Property<System.Double> System.Windows.Documents.Glyphs.FontRenderingEmSizeProperty
      let originX                                  = Property<System.Double> System.Windows.Documents.Glyphs.OriginXProperty
      let originY                                  = Property<System.Double> System.Windows.Documents.Glyphs.OriginYProperty
      let fontUri                                  = Property<System.Uri> System.Windows.Documents.Glyphs.FontUriProperty
      let styleSimulations                         = Property<System.Windows.Media.StyleSimulations> System.Windows.Documents.Glyphs.StyleSimulationsProperty
      let isSideways                               = Property<System.Boolean> System.Windows.Documents.Glyphs.IsSidewaysProperty
      let bidiLevel                                = Property<System.Int32> System.Windows.Documents.Glyphs.BidiLevelProperty
      let deviceFontName                           = Property<System.String> System.Windows.Documents.Glyphs.DeviceFontNameProperty

    module Grid = 
      let dummy = ()
      let showGridLines                            = Property<System.Boolean> System.Windows.Controls.Grid.ShowGridLinesProperty
      let column                                   = Property<System.Int32> System.Windows.Controls.Grid.ColumnProperty
      let row                                      = Property<System.Int32> System.Windows.Controls.Grid.RowProperty
      let columnSpan                               = Property<System.Int32> System.Windows.Controls.Grid.ColumnSpanProperty
      let rowSpan                                  = Property<System.Int32> System.Windows.Controls.Grid.RowSpanProperty
      let isSharedSizeScope                        = Property<System.Boolean> System.Windows.Controls.Grid.IsSharedSizeScopeProperty

    module GridSplitter = 
      let dummy = ()
      let resizeDirection                          = Property<System.Windows.Controls.GridResizeDirection> System.Windows.Controls.GridSplitter.ResizeDirectionProperty
      let resizeBehavior                           = Property<System.Windows.Controls.GridResizeBehavior> System.Windows.Controls.GridSplitter.ResizeBehaviorProperty
      let showsPreview                             = Property<System.Boolean> System.Windows.Controls.GridSplitter.ShowsPreviewProperty
      let previewStyle                             = Property<System.Windows.Style> System.Windows.Controls.GridSplitter.PreviewStyleProperty
      let keyboardIncrement                        = Property<System.Double> System.Windows.Controls.GridSplitter.KeyboardIncrementProperty
      let dragIncrement                            = Property<System.Double> System.Windows.Controls.GridSplitter.DragIncrementProperty

    module GridViewColumnHeader = 
      let dummy = ()
      let column                                   = Property<System.Windows.Controls.GridViewColumn> System.Windows.Controls.GridViewColumnHeader.ColumnProperty
      let role                                     = Property<System.Windows.Controls.GridViewColumnHeaderRole> System.Windows.Controls.GridViewColumnHeader.RoleProperty

    module GridViewHeaderRowPresenter = 
      let dummy = ()
      let columnHeaderContainerStyle               = Property<System.Windows.Style> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContainerStyleProperty
      let columnHeaderTemplate                     = Property<System.Windows.DataTemplate> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateProperty
      let columnHeaderTemplateSelector             = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateSelectorProperty
      let columnHeaderStringFormat                 = Property<System.String> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderStringFormatProperty
      let allowsColumnReorder                      = Property<System.Boolean> System.Windows.Controls.GridViewHeaderRowPresenter.AllowsColumnReorderProperty
      let columnHeaderContextMenu                  = Property<System.Windows.Controls.ContextMenu> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContextMenuProperty
      let columnHeaderToolTip                      = Property<System.Object> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderToolTipProperty

    module GridViewRowPresenter = 
      let dummy = ()
      let content                                  = Property<System.Object> System.Windows.Controls.GridViewRowPresenter.ContentProperty

    module GridViewRowPresenterBase = 
      let dummy = ()
      let columns                                  = Property<System.Windows.Controls.GridViewColumnCollection> System.Windows.Controls.Primitives.GridViewRowPresenterBase.ColumnsProperty

    module GroupBox = 
      let dummy = ()

    module GroupItem = 
      let dummy = ()

    module HeaderedContentControl = 
      let dummy = ()
      let header                                   = Property<System.Object> System.Windows.Controls.HeaderedContentControl.HeaderProperty
      let hasHeader                                = Property<System.Boolean> System.Windows.Controls.HeaderedContentControl.HasHeaderProperty
      let headerTemplate                           = Property<System.Windows.DataTemplate> System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty
      let headerTemplateSelector                   = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty
      let headerStringFormat                       = Property<System.String> System.Windows.Controls.HeaderedContentControl.HeaderStringFormatProperty

    module HeaderedItemsControl = 
      let dummy = ()
      let header                                   = Property<System.Object> System.Windows.Controls.HeaderedItemsControl.HeaderProperty
      let hasHeader                                = Property<System.Boolean> System.Windows.Controls.HeaderedItemsControl.HasHeaderProperty
      let headerTemplate                           = Property<System.Windows.DataTemplate> System.Windows.Controls.HeaderedItemsControl.HeaderTemplateProperty
      let headerTemplateSelector                   = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.HeaderedItemsControl.HeaderTemplateSelectorProperty
      let headerStringFormat                       = Property<System.String> System.Windows.Controls.HeaderedItemsControl.HeaderStringFormatProperty

    module Image = 
      let dummy = ()
      let source                                   = Property<System.Windows.Media.ImageSource> System.Windows.Controls.Image.SourceProperty
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Controls.Image.StretchProperty
      let stretchDirection                         = Property<System.Windows.Controls.StretchDirection> System.Windows.Controls.Image.StretchDirectionProperty

    module InkCanvas = 
      let dummy = ()
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.InkCanvas.BackgroundProperty
      let top                                      = Property<System.Double> System.Windows.Controls.InkCanvas.TopProperty
      let bottom                                   = Property<System.Double> System.Windows.Controls.InkCanvas.BottomProperty
      let left                                     = Property<System.Double> System.Windows.Controls.InkCanvas.LeftProperty
      let right                                    = Property<System.Double> System.Windows.Controls.InkCanvas.RightProperty
      let strokes                                  = Property<System.Windows.Ink.StrokeCollection> System.Windows.Controls.InkCanvas.StrokesProperty
      let defaultDrawingAttributes                 = Property<System.Windows.Ink.DrawingAttributes> System.Windows.Controls.InkCanvas.DefaultDrawingAttributesProperty
      let activeEditingMode                        = Property<System.Windows.Controls.InkCanvasEditingMode> System.Windows.Controls.InkCanvas.ActiveEditingModeProperty
      let editingMode                              = Property<System.Windows.Controls.InkCanvasEditingMode> System.Windows.Controls.InkCanvas.EditingModeProperty
      let editingModeInverted                      = Property<System.Windows.Controls.InkCanvasEditingMode> System.Windows.Controls.InkCanvas.EditingModeInvertedProperty

    module InkPresenter = 
      let dummy = ()
      let strokes                                  = Property<System.Windows.Ink.StrokeCollection> System.Windows.Controls.InkPresenter.StrokesProperty

    module ItemsControl = 
      let dummy = ()
      let itemsSource                              = Property<System.Collections.IEnumerable> System.Windows.Controls.ItemsControl.ItemsSourceProperty
      let hasItems                                 = Property<System.Boolean> System.Windows.Controls.ItemsControl.HasItemsProperty
      let displayMemberPath                        = Property<System.String> System.Windows.Controls.ItemsControl.DisplayMemberPathProperty
      let itemTemplate                             = Property<System.Windows.DataTemplate> System.Windows.Controls.ItemsControl.ItemTemplateProperty
      let itemTemplateSelector                     = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.ItemsControl.ItemTemplateSelectorProperty
      let itemStringFormat                         = Property<System.String> System.Windows.Controls.ItemsControl.ItemStringFormatProperty
      let itemBindingGroup                         = Property<System.Windows.Data.BindingGroup> System.Windows.Controls.ItemsControl.ItemBindingGroupProperty
      let itemContainerStyle                       = Property<System.Windows.Style> System.Windows.Controls.ItemsControl.ItemContainerStyleProperty
      let itemContainerStyleSelector               = Property<System.Windows.Controls.StyleSelector> System.Windows.Controls.ItemsControl.ItemContainerStyleSelectorProperty
      let itemsPanel                               = Property<System.Windows.Controls.ItemsPanelTemplate> System.Windows.Controls.ItemsControl.ItemsPanelProperty
      let isGrouping                               = Property<System.Boolean> System.Windows.Controls.ItemsControl.IsGroupingProperty
      let groupStyleSelector                       = Property<System.Windows.Controls.GroupStyleSelector> System.Windows.Controls.ItemsControl.GroupStyleSelectorProperty
      let alternationCount                         = Property<System.Int32> System.Windows.Controls.ItemsControl.AlternationCountProperty
      let alternationIndex                         = Property<System.Int32> System.Windows.Controls.ItemsControl.AlternationIndexProperty
      let isTextSearchEnabled                      = Property<System.Boolean> System.Windows.Controls.ItemsControl.IsTextSearchEnabledProperty
      let isTextSearchCaseSensitive                = Property<System.Boolean> System.Windows.Controls.ItemsControl.IsTextSearchCaseSensitiveProperty

    module ItemsPresenter = 
      let dummy = ()

    module Label = 
      let dummy = ()
      let target                                   = Property<System.Windows.UIElement> System.Windows.Controls.Label.TargetProperty

    module Line = 
      let dummy = ()
      let x1                                       = Property<System.Double> System.Windows.Shapes.Line.X1Property
      let y1                                       = Property<System.Double> System.Windows.Shapes.Line.Y1Property
      let x2                                       = Property<System.Double> System.Windows.Shapes.Line.X2Property
      let y2                                       = Property<System.Double> System.Windows.Shapes.Line.Y2Property

    module ListBox = 
      let dummy = ()
      let selectionMode                            = Property<System.Windows.Controls.SelectionMode> System.Windows.Controls.ListBox.SelectionModeProperty
      let selectedItems                            = Property<System.Collections.IList> System.Windows.Controls.ListBox.SelectedItemsProperty

    module ListBoxItem = 
      let dummy = ()
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.ListBoxItem.IsSelectedProperty

    module ListView = 
      let dummy = ()
      let view                                     = Property<System.Windows.Controls.ViewBase> System.Windows.Controls.ListView.ViewProperty

    module ListViewItem = 
      let dummy = ()

    module MediaElement = 
      let dummy = ()
      let source                                   = Property<System.Uri> System.Windows.Controls.MediaElement.SourceProperty
      let volume                                   = Property<System.Double> System.Windows.Controls.MediaElement.VolumeProperty
      let balance                                  = Property<System.Double> System.Windows.Controls.MediaElement.BalanceProperty
      let isMuted                                  = Property<System.Boolean> System.Windows.Controls.MediaElement.IsMutedProperty
      let scrubbingEnabled                         = Property<System.Boolean> System.Windows.Controls.MediaElement.ScrubbingEnabledProperty
      let unloadedBehavior                         = Property<System.Windows.Controls.MediaState> System.Windows.Controls.MediaElement.UnloadedBehaviorProperty
      let loadedBehavior                           = Property<System.Windows.Controls.MediaState> System.Windows.Controls.MediaElement.LoadedBehaviorProperty
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Controls.MediaElement.StretchProperty
      let stretchDirection                         = Property<System.Windows.Controls.StretchDirection> System.Windows.Controls.MediaElement.StretchDirectionProperty

    module Menu = 
      let dummy = ()
      let isMainMenu                               = Property<System.Boolean> System.Windows.Controls.Menu.IsMainMenuProperty

    module MenuBase = 
      let dummy = ()
      let itemContainerTemplateSelector            = Property<System.Windows.Controls.ItemContainerTemplateSelector> System.Windows.Controls.Primitives.MenuBase.ItemContainerTemplateSelectorProperty
      let usesItemContainerTemplate                = Property<System.Boolean> System.Windows.Controls.Primitives.MenuBase.UsesItemContainerTemplateProperty

    module MenuItem = 
      let dummy = ()
      let command                                  = Property<System.Windows.Input.ICommand> System.Windows.Controls.MenuItem.CommandProperty
      let commandParameter                         = Property<System.Object> System.Windows.Controls.MenuItem.CommandParameterProperty
      let commandTarget                            = Property<System.Windows.IInputElement> System.Windows.Controls.MenuItem.CommandTargetProperty
      let isSubmenuOpen                            = Property<System.Boolean> System.Windows.Controls.MenuItem.IsSubmenuOpenProperty
      let role                                     = Property<System.Windows.Controls.MenuItemRole> System.Windows.Controls.MenuItem.RoleProperty
      let isCheckable                              = Property<System.Boolean> System.Windows.Controls.MenuItem.IsCheckableProperty
      let isPressed                                = Property<System.Boolean> System.Windows.Controls.MenuItem.IsPressedProperty
      let isHighlighted                            = Property<System.Boolean> System.Windows.Controls.MenuItem.IsHighlightedProperty
      let isChecked                                = Property<System.Boolean> System.Windows.Controls.MenuItem.IsCheckedProperty
      let staysOpenOnClick                         = Property<System.Boolean> System.Windows.Controls.MenuItem.StaysOpenOnClickProperty
      let inputGestureText                         = Property<System.String> System.Windows.Controls.MenuItem.InputGestureTextProperty
      let icon                                     = Property<System.Object> System.Windows.Controls.MenuItem.IconProperty
      let isSuspendingPopupAnimation               = Property<System.Boolean> System.Windows.Controls.MenuItem.IsSuspendingPopupAnimationProperty
      let itemContainerTemplateSelector            = Property<System.Windows.Controls.ItemContainerTemplateSelector> System.Windows.Controls.MenuItem.ItemContainerTemplateSelectorProperty
      let usesItemContainerTemplate                = Property<System.Boolean> System.Windows.Controls.MenuItem.UsesItemContainerTemplateProperty

    module MultiSelector = 
      let dummy = ()

    module NavigationWindow = 
      let dummy = ()
      let sandboxExternalContent                   = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.SandboxExternalContentProperty
      let showsNavigationUI                        = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.ShowsNavigationUIProperty
      let backStack                                = Property<System.Collections.IEnumerable> System.Windows.Navigation.NavigationWindow.BackStackProperty
      let forwardStack                             = Property<System.Collections.IEnumerable> System.Windows.Navigation.NavigationWindow.ForwardStackProperty
      let canGoBack                                = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.CanGoBackProperty
      let canGoForward                             = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.CanGoForwardProperty
      let source                                   = Property<System.Uri> System.Windows.Navigation.NavigationWindow.SourceProperty

    module Page = 
      let dummy = ()
      let content                                  = Property<System.Object> System.Windows.Controls.Page.ContentProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Page.BackgroundProperty
      let title                                    = Property<System.String> System.Windows.Controls.Page.TitleProperty
      let keepAlive                                = Property<System.Boolean> System.Windows.Controls.Page.KeepAliveProperty
      let foreground                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Page.ForegroundProperty
      let fontFamily                               = Property<System.Windows.Media.FontFamily> System.Windows.Controls.Page.FontFamilyProperty
      let fontSize                                 = Property<System.Double> System.Windows.Controls.Page.FontSizeProperty
      let template                                 = Property<System.Windows.Controls.ControlTemplate> System.Windows.Controls.Page.TemplateProperty

    module PageContent = 
      let dummy = ()
      let source                                   = Property<System.Uri> System.Windows.Documents.PageContent.SourceProperty

    module PageFunctionBase = 
      let dummy = ()

    module Panel = 
      let dummy = ()
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Panel.BackgroundProperty
      let isItemsHost                              = Property<System.Boolean> System.Windows.Controls.Panel.IsItemsHostProperty
      let zIndex                                   = Property<System.Int32> System.Windows.Controls.Panel.ZIndexProperty

    module PasswordBox = 
      let dummy = ()
      let passwordChar                             = Property<System.Char> System.Windows.Controls.PasswordBox.PasswordCharProperty
      let maxLength                                = Property<System.Int32> System.Windows.Controls.PasswordBox.MaxLengthProperty
      let selectionBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.PasswordBox.SelectionBrushProperty
      let selectionOpacity                         = Property<System.Double> System.Windows.Controls.PasswordBox.SelectionOpacityProperty
      let caretBrush                               = Property<System.Windows.Media.Brush> System.Windows.Controls.PasswordBox.CaretBrushProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.PasswordBox.IsSelectionActiveProperty
      let isInactiveSelectionHighlightEnabled      = Property<System.Boolean> System.Windows.Controls.PasswordBox.IsInactiveSelectionHighlightEnabledProperty

    module Path = 
      let dummy = ()
      let data                                     = Property<System.Windows.Media.Geometry> System.Windows.Shapes.Path.DataProperty

    module Polygon = 
      let dummy = ()
      let points                                   = Property<System.Windows.Media.PointCollection> System.Windows.Shapes.Polygon.PointsProperty
      let fillRule                                 = Property<System.Windows.Media.FillRule> System.Windows.Shapes.Polygon.FillRuleProperty

    module Polyline = 
      let dummy = ()
      let points                                   = Property<System.Windows.Media.PointCollection> System.Windows.Shapes.Polyline.PointsProperty
      let fillRule                                 = Property<System.Windows.Media.FillRule> System.Windows.Shapes.Polyline.FillRuleProperty

    module Popup = 
      let dummy = ()
      let child                                    = Property<System.Windows.UIElement> System.Windows.Controls.Primitives.Popup.ChildProperty
      let isOpen                                   = Property<System.Boolean> System.Windows.Controls.Primitives.Popup.IsOpenProperty
      let placement                                = Property<System.Windows.Controls.Primitives.PlacementMode> System.Windows.Controls.Primitives.Popup.PlacementProperty
      let customPopupPlacementCallback             = Property<System.Windows.Controls.Primitives.CustomPopupPlacementCallback> System.Windows.Controls.Primitives.Popup.CustomPopupPlacementCallbackProperty
      let staysOpen                                = Property<System.Boolean> System.Windows.Controls.Primitives.Popup.StaysOpenProperty
      let horizontalOffset                         = Property<System.Double> System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty
      let verticalOffset                           = Property<System.Double> System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty
      let placementTarget                          = Property<System.Windows.UIElement> System.Windows.Controls.Primitives.Popup.PlacementTargetProperty
      let placementRectangle                       = Property<System.Windows.Rect> System.Windows.Controls.Primitives.Popup.PlacementRectangleProperty
      let popupAnimation                           = Property<System.Windows.Controls.Primitives.PopupAnimation> System.Windows.Controls.Primitives.Popup.PopupAnimationProperty
      let allowsTransparency                       = Property<System.Boolean> System.Windows.Controls.Primitives.Popup.AllowsTransparencyProperty
      let hasDropShadow                            = Property<System.Boolean> System.Windows.Controls.Primitives.Popup.HasDropShadowProperty

    module ProgressBar = 
      let dummy = ()
      let isIndeterminate                          = Property<System.Boolean> System.Windows.Controls.ProgressBar.IsIndeterminateProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.ProgressBar.OrientationProperty

    module RadioButton = 
      let dummy = ()
      let groupName                                = Property<System.String> System.Windows.Controls.RadioButton.GroupNameProperty

    module RangeBase = 
      let dummy = ()
      let minimum                                  = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.MinimumProperty
      let maximum                                  = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.MaximumProperty
      let value                                    = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.ValueProperty
      let largeChange                              = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.LargeChangeProperty
      let smallChange                              = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.SmallChangeProperty

    module Rectangle = 
      let dummy = ()
      let radiusX                                  = Property<System.Double> System.Windows.Shapes.Rectangle.RadiusXProperty
      let radiusY                                  = Property<System.Double> System.Windows.Shapes.Rectangle.RadiusYProperty

    module RepeatButton = 
      let dummy = ()
      let delay                                    = Property<System.Int32> System.Windows.Controls.Primitives.RepeatButton.DelayProperty
      let interval                                 = Property<System.Int32> System.Windows.Controls.Primitives.RepeatButton.IntervalProperty

    module ResizeGrip = 
      let dummy = ()

    module RichTextBox = 
      let dummy = ()
      let isDocumentEnabled                        = Property<System.Boolean> System.Windows.Controls.RichTextBox.IsDocumentEnabledProperty

    module ScrollBar = 
      let dummy = ()
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.Primitives.ScrollBar.OrientationProperty
      let viewportSize                             = Property<System.Double> System.Windows.Controls.Primitives.ScrollBar.ViewportSizeProperty

    module ScrollContentPresenter = 
      let dummy = ()
      let canContentScroll                         = Property<System.Boolean> System.Windows.Controls.ScrollContentPresenter.CanContentScrollProperty

    module ScrollViewer = 
      let dummy = ()
      let canContentScroll                         = Property<System.Boolean> System.Windows.Controls.ScrollViewer.CanContentScrollProperty
      let horizontalScrollBarVisibility            = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty
      let verticalScrollBarVisibility              = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty
      let computedHorizontalScrollBarVisibility    = Property<System.Windows.Visibility> System.Windows.Controls.ScrollViewer.ComputedHorizontalScrollBarVisibilityProperty
      let computedVerticalScrollBarVisibility      = Property<System.Windows.Visibility> System.Windows.Controls.ScrollViewer.ComputedVerticalScrollBarVisibilityProperty
      let verticalOffset                           = Property<System.Double> System.Windows.Controls.ScrollViewer.VerticalOffsetProperty
      let horizontalOffset                         = Property<System.Double> System.Windows.Controls.ScrollViewer.HorizontalOffsetProperty
      let contentVerticalOffset                    = Property<System.Double> System.Windows.Controls.ScrollViewer.ContentVerticalOffsetProperty
      let contentHorizontalOffset                  = Property<System.Double> System.Windows.Controls.ScrollViewer.ContentHorizontalOffsetProperty
      let extentWidth                              = Property<System.Double> System.Windows.Controls.ScrollViewer.ExtentWidthProperty
      let extentHeight                             = Property<System.Double> System.Windows.Controls.ScrollViewer.ExtentHeightProperty
      let scrollableWidth                          = Property<System.Double> System.Windows.Controls.ScrollViewer.ScrollableWidthProperty
      let scrollableHeight                         = Property<System.Double> System.Windows.Controls.ScrollViewer.ScrollableHeightProperty
      let viewportWidth                            = Property<System.Double> System.Windows.Controls.ScrollViewer.ViewportWidthProperty
      let viewportHeight                           = Property<System.Double> System.Windows.Controls.ScrollViewer.ViewportHeightProperty
      let isDeferredScrollingEnabled               = Property<System.Boolean> System.Windows.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty
      let panningMode                              = Property<System.Windows.Controls.PanningMode> System.Windows.Controls.ScrollViewer.PanningModeProperty
      let panningDeceleration                      = Property<System.Double> System.Windows.Controls.ScrollViewer.PanningDecelerationProperty
      let panningRatio                             = Property<System.Double> System.Windows.Controls.ScrollViewer.PanningRatioProperty

    module SelectiveScrollingGrid = 
      let dummy = ()
      let selectiveScrollingOrientation            = Property<System.Windows.Controls.SelectiveScrollingOrientation> System.Windows.Controls.Primitives.SelectiveScrollingGrid.SelectiveScrollingOrientationProperty

    module Selector = 
      let dummy = ()
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.Primitives.Selector.IsSelectionActiveProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.Primitives.Selector.IsSelectedProperty
      let isSynchronizedWithCurrentItem            = Property<System.Nullable<System.Boolean>> System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItemProperty
      let selectedIndex                            = Property<System.Int32> System.Windows.Controls.Primitives.Selector.SelectedIndexProperty
      let selectedItem                             = Property<System.Object> System.Windows.Controls.Primitives.Selector.SelectedItemProperty
      let selectedValue                            = Property<System.Object> System.Windows.Controls.Primitives.Selector.SelectedValueProperty
      let selectedValuePath                        = Property<System.String> System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty

    module Separator = 
      let dummy = ()

    module Shape = 
      let dummy = ()
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Shapes.Shape.StretchProperty
      let fill                                     = Property<System.Windows.Media.Brush> System.Windows.Shapes.Shape.FillProperty
      let stroke                                   = Property<System.Windows.Media.Brush> System.Windows.Shapes.Shape.StrokeProperty
      let strokeThickness                          = Property<System.Double> System.Windows.Shapes.Shape.StrokeThicknessProperty
      let strokeStartLineCap                       = Property<System.Windows.Media.PenLineCap> System.Windows.Shapes.Shape.StrokeStartLineCapProperty
      let strokeEndLineCap                         = Property<System.Windows.Media.PenLineCap> System.Windows.Shapes.Shape.StrokeEndLineCapProperty
      let strokeDashCap                            = Property<System.Windows.Media.PenLineCap> System.Windows.Shapes.Shape.StrokeDashCapProperty
      let strokeLineJoin                           = Property<System.Windows.Media.PenLineJoin> System.Windows.Shapes.Shape.StrokeLineJoinProperty
      let strokeMiterLimit                         = Property<System.Double> System.Windows.Shapes.Shape.StrokeMiterLimitProperty
      let strokeDashOffset                         = Property<System.Double> System.Windows.Shapes.Shape.StrokeDashOffsetProperty
      let strokeDashArray                          = Property<System.Windows.Media.DoubleCollection> System.Windows.Shapes.Shape.StrokeDashArrayProperty

    module Slider = 
      let dummy = ()
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.Slider.OrientationProperty
      let isDirectionReversed                      = Property<System.Boolean> System.Windows.Controls.Slider.IsDirectionReversedProperty
      let delay                                    = Property<System.Int32> System.Windows.Controls.Slider.DelayProperty
      let interval                                 = Property<System.Int32> System.Windows.Controls.Slider.IntervalProperty
      let autoToolTipPlacement                     = Property<System.Windows.Controls.Primitives.AutoToolTipPlacement> System.Windows.Controls.Slider.AutoToolTipPlacementProperty
      let autoToolTipPrecision                     = Property<System.Int32> System.Windows.Controls.Slider.AutoToolTipPrecisionProperty
      let isSnapToTickEnabled                      = Property<System.Boolean> System.Windows.Controls.Slider.IsSnapToTickEnabledProperty
      let tickPlacement                            = Property<System.Windows.Controls.Primitives.TickPlacement> System.Windows.Controls.Slider.TickPlacementProperty
      let tickFrequency                            = Property<System.Double> System.Windows.Controls.Slider.TickFrequencyProperty
      let ticks                                    = Property<System.Windows.Media.DoubleCollection> System.Windows.Controls.Slider.TicksProperty
      let isSelectionRangeEnabled                  = Property<System.Boolean> System.Windows.Controls.Slider.IsSelectionRangeEnabledProperty
      let selectionStart                           = Property<System.Double> System.Windows.Controls.Slider.SelectionStartProperty
      let selectionEnd                             = Property<System.Double> System.Windows.Controls.Slider.SelectionEndProperty
      let isMoveToPointEnabled                     = Property<System.Boolean> System.Windows.Controls.Slider.IsMoveToPointEnabledProperty

    module StackPanel = 
      let dummy = ()
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.StackPanel.OrientationProperty

    module StatusBar = 
      let dummy = ()
      let itemContainerTemplateSelector            = Property<System.Windows.Controls.ItemContainerTemplateSelector> System.Windows.Controls.Primitives.StatusBar.ItemContainerTemplateSelectorProperty
      let usesItemContainerTemplate                = Property<System.Boolean> System.Windows.Controls.Primitives.StatusBar.UsesItemContainerTemplateProperty

    module StatusBarItem = 
      let dummy = ()

    module StickyNoteControl = 
      let dummy = ()
      let author                                   = Property<System.String> System.Windows.Controls.StickyNoteControl.AuthorProperty
      let isExpanded                               = Property<System.Boolean> System.Windows.Controls.StickyNoteControl.IsExpandedProperty
      let isActive                                 = Property<System.Boolean> System.Windows.Controls.StickyNoteControl.IsActiveProperty
      let isMouseOverAnchor                        = Property<System.Boolean> System.Windows.Controls.StickyNoteControl.IsMouseOverAnchorProperty
      let captionFontFamily                        = Property<System.Windows.Media.FontFamily> System.Windows.Controls.StickyNoteControl.CaptionFontFamilyProperty
      let captionFontSize                          = Property<System.Double> System.Windows.Controls.StickyNoteControl.CaptionFontSizeProperty
      let captionFontStretch                       = Property<System.Windows.FontStretch> System.Windows.Controls.StickyNoteControl.CaptionFontStretchProperty
      let captionFontStyle                         = Property<System.Windows.FontStyle> System.Windows.Controls.StickyNoteControl.CaptionFontStyleProperty
      let captionFontWeight                        = Property<System.Windows.FontWeight> System.Windows.Controls.StickyNoteControl.CaptionFontWeightProperty
      let penWidth                                 = Property<System.Double> System.Windows.Controls.StickyNoteControl.PenWidthProperty
      let stickyNoteType                           = Property<System.Windows.Controls.StickyNoteType> System.Windows.Controls.StickyNoteControl.StickyNoteTypeProperty

    module TabControl = 
      let dummy = ()
      let tabStripPlacement                        = Property<System.Windows.Controls.Dock> System.Windows.Controls.TabControl.TabStripPlacementProperty
      let selectedContent                          = Property<System.Object> System.Windows.Controls.TabControl.SelectedContentProperty
      let selectedContentTemplate                  = Property<System.Windows.DataTemplate> System.Windows.Controls.TabControl.SelectedContentTemplateProperty
      let selectedContentTemplateSelector          = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.TabControl.SelectedContentTemplateSelectorProperty
      let selectedContentStringFormat              = Property<System.String> System.Windows.Controls.TabControl.SelectedContentStringFormatProperty
      let contentTemplate                          = Property<System.Windows.DataTemplate> System.Windows.Controls.TabControl.ContentTemplateProperty
      let contentTemplateSelector                  = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.TabControl.ContentTemplateSelectorProperty
      let contentStringFormat                      = Property<System.String> System.Windows.Controls.TabControl.ContentStringFormatProperty

    module TabItem = 
      let dummy = ()
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.TabItem.IsSelectedProperty
      let tabStripPlacement                        = Property<System.Windows.Controls.Dock> System.Windows.Controls.TabItem.TabStripPlacementProperty

    module TabPanel = 
      let dummy = ()

    module TextBlock = 
      let dummy = ()
      let baselineOffset                           = Property<System.Double> System.Windows.Controls.TextBlock.BaselineOffsetProperty
      let text                                     = Property<System.String> System.Windows.Controls.TextBlock.TextProperty
      let fontFamily                               = Property<System.Windows.Media.FontFamily> System.Windows.Controls.TextBlock.FontFamilyProperty
      let fontStyle                                = Property<System.Windows.FontStyle> System.Windows.Controls.TextBlock.FontStyleProperty
      let fontWeight                               = Property<System.Windows.FontWeight> System.Windows.Controls.TextBlock.FontWeightProperty
      let fontStretch                              = Property<System.Windows.FontStretch> System.Windows.Controls.TextBlock.FontStretchProperty
      let fontSize                                 = Property<System.Double> System.Windows.Controls.TextBlock.FontSizeProperty
      let foreground                               = Property<System.Windows.Media.Brush> System.Windows.Controls.TextBlock.ForegroundProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.TextBlock.BackgroundProperty
      let textDecorations                          = Property<System.Windows.TextDecorationCollection> System.Windows.Controls.TextBlock.TextDecorationsProperty
      let textEffects                              = Property<System.Windows.Media.TextEffectCollection> System.Windows.Controls.TextBlock.TextEffectsProperty
      let lineHeight                               = Property<System.Double> System.Windows.Controls.TextBlock.LineHeightProperty
      let lineStackingStrategy                     = Property<System.Windows.LineStackingStrategy> System.Windows.Controls.TextBlock.LineStackingStrategyProperty
      let padding                                  = Property<System.Windows.Thickness> System.Windows.Controls.TextBlock.PaddingProperty
      let textAlignment                            = Property<System.Windows.TextAlignment> System.Windows.Controls.TextBlock.TextAlignmentProperty
      let textTrimming                             = Property<System.Windows.TextTrimming> System.Windows.Controls.TextBlock.TextTrimmingProperty
      let textWrapping                             = Property<System.Windows.TextWrapping> System.Windows.Controls.TextBlock.TextWrappingProperty
      let isHyphenationEnabled                     = Property<System.Boolean> System.Windows.Controls.TextBlock.IsHyphenationEnabledProperty

    module TextBox = 
      let dummy = ()
      let textWrapping                             = Property<System.Windows.TextWrapping> System.Windows.Controls.TextBox.TextWrappingProperty
      let minLines                                 = Property<System.Int32> System.Windows.Controls.TextBox.MinLinesProperty
      let maxLines                                 = Property<System.Int32> System.Windows.Controls.TextBox.MaxLinesProperty
      let text                                     = Property<System.String> System.Windows.Controls.TextBox.TextProperty
      let characterCasing                          = Property<System.Windows.Controls.CharacterCasing> System.Windows.Controls.TextBox.CharacterCasingProperty
      let maxLength                                = Property<System.Int32> System.Windows.Controls.TextBox.MaxLengthProperty
      let textAlignment                            = Property<System.Windows.TextAlignment> System.Windows.Controls.TextBox.TextAlignmentProperty
      let textDecorations                          = Property<System.Windows.TextDecorationCollection> System.Windows.Controls.TextBox.TextDecorationsProperty

    module TextBoxBase = 
      let dummy = ()
      let isReadOnly                               = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyProperty
      let isReadOnlyCaretVisible                   = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyCaretVisibleProperty
      let acceptsReturn                            = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.AcceptsReturnProperty
      let acceptsTab                               = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.AcceptsTabProperty
      let horizontalScrollBarVisibility            = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.Primitives.TextBoxBase.HorizontalScrollBarVisibilityProperty
      let verticalScrollBarVisibility              = Property<System.Windows.Controls.ScrollBarVisibility> System.Windows.Controls.Primitives.TextBoxBase.VerticalScrollBarVisibilityProperty
      let isUndoEnabled                            = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.IsUndoEnabledProperty
      let undoLimit                                = Property<System.Int32> System.Windows.Controls.Primitives.TextBoxBase.UndoLimitProperty
      let autoWordSelection                        = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.AutoWordSelectionProperty
      let selectionBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.TextBoxBase.SelectionBrushProperty
      let selectionOpacity                         = Property<System.Double> System.Windows.Controls.Primitives.TextBoxBase.SelectionOpacityProperty
      let caretBrush                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.TextBoxBase.CaretBrushProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.IsSelectionActiveProperty
      let isInactiveSelectionHighlightEnabled      = Property<System.Boolean> System.Windows.Controls.Primitives.TextBoxBase.IsInactiveSelectionHighlightEnabledProperty

    module Thumb = 
      let dummy = ()
      let isDragging                               = Property<System.Boolean> System.Windows.Controls.Primitives.Thumb.IsDraggingProperty

    module TickBar = 
      let dummy = ()
      let fill                                     = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.TickBar.FillProperty
      let minimum                                  = Property<System.Double> System.Windows.Controls.Primitives.TickBar.MinimumProperty
      let maximum                                  = Property<System.Double> System.Windows.Controls.Primitives.TickBar.MaximumProperty
      let selectionStart                           = Property<System.Double> System.Windows.Controls.Primitives.TickBar.SelectionStartProperty
      let selectionEnd                             = Property<System.Double> System.Windows.Controls.Primitives.TickBar.SelectionEndProperty
      let isSelectionRangeEnabled                  = Property<System.Boolean> System.Windows.Controls.Primitives.TickBar.IsSelectionRangeEnabledProperty
      let tickFrequency                            = Property<System.Double> System.Windows.Controls.Primitives.TickBar.TickFrequencyProperty
      let ticks                                    = Property<System.Windows.Media.DoubleCollection> System.Windows.Controls.Primitives.TickBar.TicksProperty
      let isDirectionReversed                      = Property<System.Boolean> System.Windows.Controls.Primitives.TickBar.IsDirectionReversedProperty
      let placement                                = Property<System.Windows.Controls.Primitives.TickBarPlacement> System.Windows.Controls.Primitives.TickBar.PlacementProperty
      let reservedSpace                            = Property<System.Double> System.Windows.Controls.Primitives.TickBar.ReservedSpaceProperty

    module ToggleButton = 
      let dummy = ()
      let isChecked                                = Property<System.Nullable<System.Boolean>> System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty
      let isThreeState                             = Property<System.Boolean> System.Windows.Controls.Primitives.ToggleButton.IsThreeStateProperty

    module ToolBar = 
      let dummy = ()
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.ToolBar.OrientationProperty
      let band                                     = Property<System.Int32> System.Windows.Controls.ToolBar.BandProperty
      let bandIndex                                = Property<System.Int32> System.Windows.Controls.ToolBar.BandIndexProperty
      let isOverflowOpen                           = Property<System.Boolean> System.Windows.Controls.ToolBar.IsOverflowOpenProperty
      let hasOverflowItems                         = Property<System.Boolean> System.Windows.Controls.ToolBar.HasOverflowItemsProperty
      let isOverflowItem                           = Property<System.Boolean> System.Windows.Controls.ToolBar.IsOverflowItemProperty
      let overflowMode                             = Property<System.Windows.Controls.OverflowMode> System.Windows.Controls.ToolBar.OverflowModeProperty

    module ToolBarOverflowPanel = 
      let dummy = ()
      let wrapWidth                                = Property<System.Double> System.Windows.Controls.Primitives.ToolBarOverflowPanel.WrapWidthProperty

    module ToolBarPanel = 
      let dummy = ()

    module ToolBarTray = 
      let dummy = ()
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.ToolBarTray.BackgroundProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.ToolBarTray.OrientationProperty
      let isLocked                                 = Property<System.Boolean> System.Windows.Controls.ToolBarTray.IsLockedProperty

    module ToolTip = 
      let dummy = ()
      let horizontalOffset                         = Property<System.Double> System.Windows.Controls.ToolTip.HorizontalOffsetProperty
      let verticalOffset                           = Property<System.Double> System.Windows.Controls.ToolTip.VerticalOffsetProperty
      let isOpen                                   = Property<System.Boolean> System.Windows.Controls.ToolTip.IsOpenProperty
      let hasDropShadow                            = Property<System.Boolean> System.Windows.Controls.ToolTip.HasDropShadowProperty
      let placementTarget                          = Property<System.Windows.UIElement> System.Windows.Controls.ToolTip.PlacementTargetProperty
      let placementRectangle                       = Property<System.Windows.Rect> System.Windows.Controls.ToolTip.PlacementRectangleProperty
      let placement                                = Property<System.Windows.Controls.Primitives.PlacementMode> System.Windows.Controls.ToolTip.PlacementProperty
      let customPopupPlacementCallback             = Property<System.Windows.Controls.Primitives.CustomPopupPlacementCallback> System.Windows.Controls.ToolTip.CustomPopupPlacementCallbackProperty
      let staysOpen                                = Property<System.Boolean> System.Windows.Controls.ToolTip.StaysOpenProperty

    module Track = 
      let dummy = ()
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.Primitives.Track.OrientationProperty
      let minimum                                  = Property<System.Double> System.Windows.Controls.Primitives.Track.MinimumProperty
      let maximum                                  = Property<System.Double> System.Windows.Controls.Primitives.Track.MaximumProperty
      let value                                    = Property<System.Double> System.Windows.Controls.Primitives.Track.ValueProperty
      let viewportSize                             = Property<System.Double> System.Windows.Controls.Primitives.Track.ViewportSizeProperty
      let isDirectionReversed                      = Property<System.Boolean> System.Windows.Controls.Primitives.Track.IsDirectionReversedProperty

    module TreeView = 
      let dummy = ()
      let selectedItem                             = Property<System.Object> System.Windows.Controls.TreeView.SelectedItemProperty
      let selectedValue                            = Property<System.Object> System.Windows.Controls.TreeView.SelectedValueProperty
      let selectedValuePath                        = Property<System.String> System.Windows.Controls.TreeView.SelectedValuePathProperty

    module TreeViewItem = 
      let dummy = ()
      let isExpanded                               = Property<System.Boolean> System.Windows.Controls.TreeViewItem.IsExpandedProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.TreeViewItem.IsSelectedProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.TreeViewItem.IsSelectionActiveProperty

    module UIElement = 
      let dummy = ()
      let isMouseDirectlyOver                      = Property<System.Boolean> System.Windows.UIElement.IsMouseDirectlyOverProperty
      let isMouseOver                              = Property<System.Boolean> System.Windows.UIElement.IsMouseOverProperty
      let isStylusOver                             = Property<System.Boolean> System.Windows.UIElement.IsStylusOverProperty
      let isKeyboardFocusWithin                    = Property<System.Boolean> System.Windows.UIElement.IsKeyboardFocusWithinProperty
      let isMouseCaptured                          = Property<System.Boolean> System.Windows.UIElement.IsMouseCapturedProperty
      let isMouseCaptureWithin                     = Property<System.Boolean> System.Windows.UIElement.IsMouseCaptureWithinProperty
      let isStylusDirectlyOver                     = Property<System.Boolean> System.Windows.UIElement.IsStylusDirectlyOverProperty
      let isStylusCaptured                         = Property<System.Boolean> System.Windows.UIElement.IsStylusCapturedProperty
      let isStylusCaptureWithin                    = Property<System.Boolean> System.Windows.UIElement.IsStylusCaptureWithinProperty
      let isKeyboardFocused                        = Property<System.Boolean> System.Windows.UIElement.IsKeyboardFocusedProperty
      let areAnyTouchesDirectlyOver                = Property<System.Boolean> System.Windows.UIElement.AreAnyTouchesDirectlyOverProperty
      let areAnyTouchesOver                        = Property<System.Boolean> System.Windows.UIElement.AreAnyTouchesOverProperty
      let areAnyTouchesCaptured                    = Property<System.Boolean> System.Windows.UIElement.AreAnyTouchesCapturedProperty
      let areAnyTouchesCapturedWithin              = Property<System.Boolean> System.Windows.UIElement.AreAnyTouchesCapturedWithinProperty
      let allowDrop                                = Property<System.Boolean> System.Windows.UIElement.AllowDropProperty
      let renderTransform                          = Property<System.Windows.Media.Transform> System.Windows.UIElement.RenderTransformProperty
      let renderTransformOrigin                    = Property<System.Windows.Point> System.Windows.UIElement.RenderTransformOriginProperty
      let opacity                                  = Property<System.Double> System.Windows.UIElement.OpacityProperty
      let opacityMask                              = Property<System.Windows.Media.Brush> System.Windows.UIElement.OpacityMaskProperty
      let bitmapEffect                             = Property<System.Windows.Media.Effects.BitmapEffect> System.Windows.UIElement.BitmapEffectProperty
      let effect                                   = Property<System.Windows.Media.Effects.Effect> System.Windows.UIElement.EffectProperty
      let bitmapEffectInput                        = Property<System.Windows.Media.Effects.BitmapEffectInput> System.Windows.UIElement.BitmapEffectInputProperty
      let cacheMode                                = Property<System.Windows.Media.CacheMode> System.Windows.UIElement.CacheModeProperty
      let uid                                      = Property<System.String> System.Windows.UIElement.UidProperty
      let visibility                               = Property<System.Windows.Visibility> System.Windows.UIElement.VisibilityProperty
      let clipToBounds                             = Property<System.Boolean> System.Windows.UIElement.ClipToBoundsProperty
      let clip                                     = Property<System.Windows.Media.Geometry> System.Windows.UIElement.ClipProperty
      let snapsToDevicePixels                      = Property<System.Boolean> System.Windows.UIElement.SnapsToDevicePixelsProperty
      let isFocused                                = Property<System.Boolean> System.Windows.UIElement.IsFocusedProperty
      let isEnabled                                = Property<System.Boolean> System.Windows.UIElement.IsEnabledProperty
      let isHitTestVisible                         = Property<System.Boolean> System.Windows.UIElement.IsHitTestVisibleProperty
      let isVisible                                = Property<System.Boolean> System.Windows.UIElement.IsVisibleProperty
      let focusable                                = Property<System.Boolean> System.Windows.UIElement.FocusableProperty
      let isManipulationEnabled                    = Property<System.Boolean> System.Windows.UIElement.IsManipulationEnabledProperty

    module UniformGrid = 
      let dummy = ()
      let firstColumn                              = Property<System.Int32> System.Windows.Controls.Primitives.UniformGrid.FirstColumnProperty
      let columns                                  = Property<System.Int32> System.Windows.Controls.Primitives.UniformGrid.ColumnsProperty
      let rows                                     = Property<System.Int32> System.Windows.Controls.Primitives.UniformGrid.RowsProperty

    module UserControl = 
      let dummy = ()

    module Viewbox = 
      let dummy = ()
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Controls.Viewbox.StretchProperty
      let stretchDirection                         = Property<System.Windows.Controls.StretchDirection> System.Windows.Controls.Viewbox.StretchDirectionProperty

    module Viewport3D = 
      let dummy = ()
      let camera                                   = Property<System.Windows.Media.Media3D.Camera> System.Windows.Controls.Viewport3D.CameraProperty
      let children                                 = Property<System.Windows.Media.Media3D.Visual3DCollection> System.Windows.Controls.Viewport3D.ChildrenProperty

    module VirtualizingPanel = 
      let dummy = ()
      let isVirtualizing                           = Property<System.Boolean> System.Windows.Controls.VirtualizingPanel.IsVirtualizingProperty
      let virtualizationMode                       = Property<System.Windows.Controls.VirtualizationMode> System.Windows.Controls.VirtualizingPanel.VirtualizationModeProperty
      let isVirtualizingWhenGrouping               = Property<System.Boolean> System.Windows.Controls.VirtualizingPanel.IsVirtualizingWhenGroupingProperty
      let scrollUnit                               = Property<System.Windows.Controls.ScrollUnit> System.Windows.Controls.VirtualizingPanel.ScrollUnitProperty
      let cacheLength                              = Property<System.Windows.Controls.VirtualizationCacheLength> System.Windows.Controls.VirtualizingPanel.CacheLengthProperty
      let cacheLengthUnit                          = Property<System.Windows.Controls.VirtualizationCacheLengthUnit> System.Windows.Controls.VirtualizingPanel.CacheLengthUnitProperty
      let isContainerVirtualizable                 = Property<System.Boolean> System.Windows.Controls.VirtualizingPanel.IsContainerVirtualizableProperty

    module VirtualizingStackPanel = 
      let dummy = ()
      let isVirtualizing                           = Property<System.Boolean> System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty
      let virtualizationMode                       = Property<System.Windows.Controls.VirtualizationMode> System.Windows.Controls.VirtualizingStackPanel.VirtualizationModeProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.VirtualizingStackPanel.OrientationProperty

    module WebBrowser = 
      let dummy = ()

    module Window = 
      let dummy = ()
      let taskbarItemInfo                          = Property<System.Windows.Shell.TaskbarItemInfo> System.Windows.Window.TaskbarItemInfoProperty
      let allowsTransparency                       = Property<System.Boolean> System.Windows.Window.AllowsTransparencyProperty
      let title                                    = Property<System.String> System.Windows.Window.TitleProperty
      let icon                                     = Property<System.Windows.Media.ImageSource> System.Windows.Window.IconProperty
      let sizeToContent                            = Property<System.Windows.SizeToContent> System.Windows.Window.SizeToContentProperty
      let top                                      = Property<System.Double> System.Windows.Window.TopProperty
      let left                                     = Property<System.Double> System.Windows.Window.LeftProperty
      let showInTaskbar                            = Property<System.Boolean> System.Windows.Window.ShowInTaskbarProperty
      let isActive                                 = Property<System.Boolean> System.Windows.Window.IsActiveProperty
      let windowStyle                              = Property<System.Windows.WindowStyle> System.Windows.Window.WindowStyleProperty
      let windowState                              = Property<System.Windows.WindowState> System.Windows.Window.WindowStateProperty
      let resizeMode                               = Property<System.Windows.ResizeMode> System.Windows.Window.ResizeModeProperty
      let topmost                                  = Property<System.Boolean> System.Windows.Window.TopmostProperty
      let showActivated                            = Property<System.Boolean> System.Windows.Window.ShowActivatedProperty

    module WrapPanel = 
      let dummy = ()
      let itemWidth                                = Property<System.Double> System.Windows.Controls.WrapPanel.ItemWidthProperty
      let itemHeight                               = Property<System.Double> System.Windows.Controls.WrapPanel.ItemHeightProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.WrapPanel.OrientationProperty

  module Controls =
    let accessText                               values =
      StandardView<AccessText> (values) :> View
    module AccessText = 
      let dummy = ()
      let text                                     v = SetConstantValue<_> (Properties.AccessText.text, v)
      let fontFamily                               v = SetConstantValue<_> (Properties.AccessText.fontFamily, v)
      let fontStyle                                v = SetConstantValue<_> (Properties.AccessText.fontStyle, v)
      let fontWeight                               v = SetConstantValue<_> (Properties.AccessText.fontWeight, v)
      let fontStretch                              v = SetConstantValue<_> (Properties.AccessText.fontStretch, v)
      let fontSize                                 v = SetConstantValue<_> (Properties.AccessText.fontSize, v)
      let foreground                               v = SetConstantValue<_> (Properties.AccessText.foreground, v)
      let background                               v = SetConstantValue<_> (Properties.AccessText.background, v)
      let textDecorations                          v = SetConstantValue<_> (Properties.AccessText.textDecorations, v)
      let textEffects                              v = SetConstantValue<_> (Properties.AccessText.textEffects, v)
      let lineHeight                               v = SetConstantValue<_> (Properties.AccessText.lineHeight, v)
      let lineStackingStrategy                     v = SetConstantValue<_> (Properties.AccessText.lineStackingStrategy, v)
      let textAlignment                            v = SetConstantValue<_> (Properties.AccessText.textAlignment, v)
      let textTrimming                             v = SetConstantValue<_> (Properties.AccessText.textTrimming, v)
      let textWrapping                             v = SetConstantValue<_> (Properties.AccessText.textWrapping, v)
      let baselineOffset                           v = SetConstantValue<_> (Properties.AccessText.baselineOffset, v)

    module ActiveXHost = 
      let dummy = ()

    let adornedElementPlaceholder                values =
      StandardView<AdornedElementPlaceholder> (values) :> View
    module AdornedElementPlaceholder = 
      let dummy = ()

    module Adorner = 
      let dummy = ()

    let adornerDecorator                         values =
      StandardView<AdornerDecorator> (values) :> View
    module AdornerDecorator = 
      let dummy = ()

    module AdornerLayer = 
      let dummy = ()

    let border                                   values =
      StandardView<Border> (values) :> View
    module Border = 
      let dummy = ()
      let borderThickness                          v = SetConstantValue<_> (Properties.Border.borderThickness, v)
      let padding                                  v = SetConstantValue<_> (Properties.Border.padding, v)
      let cornerRadius                             v = SetConstantValue<_> (Properties.Border.cornerRadius, v)
      let borderBrush                              v = SetConstantValue<_> (Properties.Border.borderBrush, v)
      let background                               v = SetConstantValue<_> (Properties.Border.background, v)

    let bulletDecorator                          values =
      StandardView<BulletDecorator> (values) :> View
    module BulletDecorator = 
      let dummy = ()
      let background                               v = SetConstantValue<_> (Properties.BulletDecorator.background, v)

    let button                                   values child =
      StandardContentView<Button> (values, child) :> View
    module Button = 
      let dummy = ()
      let isDefault                                v = SetConstantValue<_> (Properties.Button.isDefault, v)
      let isCancel                                 v = SetConstantValue<_> (Properties.Button.isCancel, v)
      let isDefaulted                              v = SetConstantValue<_> (Properties.Button.isDefaulted, v)

    module ButtonBase = 
      let dummy = ()
      let command                                  v = SetConstantValue<_> (Properties.ButtonBase.command, v)
      let commandParameter                         v = SetConstantValue<_> (Properties.ButtonBase.commandParameter, v)
      let commandTarget                            v = SetConstantValue<_> (Properties.ButtonBase.commandTarget, v)
      let isPressed                                v = SetConstantValue<_> (Properties.ButtonBase.isPressed, v)
      let clickMode                                v = SetConstantValue<_> (Properties.ButtonBase.clickMode, v)
      let onClick                                  (f : System.Windows.Controls.Primitives.ButtonBase -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.ButtonBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.ButtonBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let calendar                                 values =
      StandardView<Calendar> (values) :> View
    module Calendar = 
      let dummy = ()
      let calendarButtonStyle                      v = SetConstantValue<_> (Properties.Calendar.calendarButtonStyle, v)
      let calendarDayButtonStyle                   v = SetConstantValue<_> (Properties.Calendar.calendarDayButtonStyle, v)
      let calendarItemStyle                        v = SetConstantValue<_> (Properties.Calendar.calendarItemStyle, v)
      let displayDate                              v = SetConstantValue<_> (Properties.Calendar.displayDate, v)
      let displayDateEnd                           v = SetConstantValue<_> (Properties.Calendar.displayDateEnd, v)
      let displayDateStart                         v = SetConstantValue<_> (Properties.Calendar.displayDateStart, v)
      let displayMode                              v = SetConstantValue<_> (Properties.Calendar.displayMode, v)
      let firstDayOfWeek                           v = SetConstantValue<_> (Properties.Calendar.firstDayOfWeek, v)
      let isTodayHighlighted                       v = SetConstantValue<_> (Properties.Calendar.isTodayHighlighted, v)
      let selectedDate                             v = SetConstantValue<_> (Properties.Calendar.selectedDate, v)
      let selectionMode                            v = SetConstantValue<_> (Properties.Calendar.selectionMode, v)
      let onSelectedDatesChanged                   (f : System.Windows.Controls.Calendar -> System.Windows.Controls.SelectionChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDatesChanged.AddHandler    (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
        let u (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDatesChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> (r, u, f)
      let onDisplayDateChanged                     (f : System.Windows.Controls.Calendar -> System.Windows.Controls.CalendarDateChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarDateChangedEventArgs -> unit) = o.DisplayDateChanged.AddHandler    (System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs> h)
        let u (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarDateChangedEventArgs -> unit) = o.DisplayDateChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs>, System.Windows.Controls.CalendarDateChangedEventArgs> (r, u, f)
      let onDisplayModeChanged                     (f : System.Windows.Controls.Calendar -> System.Windows.Controls.CalendarModeChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarModeChangedEventArgs -> unit) = o.DisplayModeChanged.AddHandler    (System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs> h)
        let u (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarModeChangedEventArgs -> unit) = o.DisplayModeChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs>, System.Windows.Controls.CalendarModeChangedEventArgs> (r, u, f)
      let onSelectionModeChanged                   (f : System.Windows.Controls.Calendar -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Calendar) (h : obj -> System.EventArgs -> unit) = o.SelectionModeChanged.AddHandler    (System.EventHandler<System.EventArgs> h)
        let u (o : System.Windows.Controls.Calendar) (h : obj -> System.EventArgs -> unit) = o.SelectionModeChanged.RemoveHandler (System.EventHandler<System.EventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.EventArgs>, System.EventArgs> (r, u, f)

    let calendarButton                           values child =
      StandardContentView<CalendarButton> (values, child) :> View
    module CalendarButton = 
      let dummy = ()
      let hasSelectedDays                          v = SetConstantValue<_> (Properties.CalendarButton.hasSelectedDays, v)
      let isInactive                               v = SetConstantValue<_> (Properties.CalendarButton.isInactive, v)

    let calendarDayButton                        values child =
      StandardContentView<CalendarDayButton> (values, child) :> View
    module CalendarDayButton = 
      let dummy = ()
      let isToday                                  v = SetConstantValue<_> (Properties.CalendarDayButton.isToday, v)
      let isSelected                               v = SetConstantValue<_> (Properties.CalendarDayButton.isSelected, v)
      let isInactive                               v = SetConstantValue<_> (Properties.CalendarDayButton.isInactive, v)
      let isBlackedOut                             v = SetConstantValue<_> (Properties.CalendarDayButton.isBlackedOut, v)
      let isHighlighted                            v = SetConstantValue<_> (Properties.CalendarDayButton.isHighlighted, v)

    let calendarItem                             values =
      StandardView<CalendarItem> (values) :> View
    module CalendarItem = 
      let dummy = ()

    let canvas                                   values children =
      StandardPanelView<Canvas> (values, children) :> View
    module Canvas = 
      let dummy = ()
      let left                                     v = SetConstantValue<_> (Properties.Canvas.left, v)
      let top                                      v = SetConstantValue<_> (Properties.Canvas.top, v)
      let right                                    v = SetConstantValue<_> (Properties.Canvas.right, v)
      let bottom                                   v = SetConstantValue<_> (Properties.Canvas.bottom, v)

    let checkBox                                 values child =
      StandardContentView<CheckBox> (values, child) :> View
    module CheckBox = 
      let dummy = ()

    let comboBox                                 values =
      StandardView<ComboBox> (values) :> View
    module ComboBox = 
      let dummy = ()
      let maxDropDownHeight                        v = SetConstantValue<_> (Properties.ComboBox.maxDropDownHeight, v)
      let isDropDownOpen                           v = SetConstantValue<_> (Properties.ComboBox.isDropDownOpen, v)
      let shouldPreserveUserEnteredPrefix          v = SetConstantValue<_> (Properties.ComboBox.shouldPreserveUserEnteredPrefix, v)
      let isEditable                               v = SetConstantValue<_> (Properties.ComboBox.isEditable, v)
      let text                                     v = SetConstantValue<_> (Properties.ComboBox.text, v)
      let isReadOnly                               v = SetConstantValue<_> (Properties.ComboBox.isReadOnly, v)
      let selectionBoxItem                         v = SetConstantValue<_> (Properties.ComboBox.selectionBoxItem, v)
      let selectionBoxItemTemplate                 v = SetConstantValue<_> (Properties.ComboBox.selectionBoxItemTemplate, v)
      let selectionBoxItemStringFormat             v = SetConstantValue<_> (Properties.ComboBox.selectionBoxItemStringFormat, v)
      let staysOpenOnEdit                          v = SetConstantValue<_> (Properties.ComboBox.staysOpenOnEdit, v)
      let onDropDownOpened                         (f : System.Windows.Controls.ComboBox -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownOpened.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownOpened.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ComboBox, System.EventHandler, System.EventArgs> (r, u, f)
      let onDropDownClosed                         (f : System.Windows.Controls.ComboBox -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownClosed.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownClosed.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ComboBox, System.EventHandler, System.EventArgs> (r, u, f)

    let comboBoxItem                             values child =
      StandardContentView<ComboBoxItem> (values, child) :> View
    module ComboBoxItem = 
      let dummy = ()
      let isHighlighted                            v = SetConstantValue<_> (Properties.ComboBoxItem.isHighlighted, v)

    let contentControl                           values =
      StandardView<ContentControl> (values) :> View
    module ContentControl = 
      let dummy = ()
      let content                                  v = SetConstantValue<_> (Properties.ContentControl.content, v)
      let hasContent                               v = SetConstantValue<_> (Properties.ContentControl.hasContent, v)
      let contentTemplate                          v = SetConstantValue<_> (Properties.ContentControl.contentTemplate, v)
      let contentTemplateSelector                  v = SetConstantValue<_> (Properties.ContentControl.contentTemplateSelector, v)
      let contentStringFormat                      v = SetConstantValue<_> (Properties.ContentControl.contentStringFormat, v)

    let contentPresenter                         values =
      StandardView<ContentPresenter> (values) :> View
    module ContentPresenter = 
      let dummy = ()
      let recognizesAccessKey                      v = SetConstantValue<_> (Properties.ContentPresenter.recognizesAccessKey, v)
      let content                                  v = SetConstantValue<_> (Properties.ContentPresenter.content, v)
      let contentTemplate                          v = SetConstantValue<_> (Properties.ContentPresenter.contentTemplate, v)
      let contentTemplateSelector                  v = SetConstantValue<_> (Properties.ContentPresenter.contentTemplateSelector, v)
      let contentStringFormat                      v = SetConstantValue<_> (Properties.ContentPresenter.contentStringFormat, v)
      let contentSource                            v = SetConstantValue<_> (Properties.ContentPresenter.contentSource, v)

    let contextMenu                              values =
      StandardView<ContextMenu> (values) :> View
    module ContextMenu = 
      let dummy = ()
      let horizontalOffset                         v = SetConstantValue<_> (Properties.ContextMenu.horizontalOffset, v)
      let verticalOffset                           v = SetConstantValue<_> (Properties.ContextMenu.verticalOffset, v)
      let isOpen                                   v = SetConstantValue<_> (Properties.ContextMenu.isOpen, v)
      let placementTarget                          v = SetConstantValue<_> (Properties.ContextMenu.placementTarget, v)
      let placementRectangle                       v = SetConstantValue<_> (Properties.ContextMenu.placementRectangle, v)
      let placement                                v = SetConstantValue<_> (Properties.ContextMenu.placement, v)
      let hasDropShadow                            v = SetConstantValue<_> (Properties.ContextMenu.hasDropShadow, v)
      let customPopupPlacementCallback             v = SetConstantValue<_> (Properties.ContextMenu.customPopupPlacementCallback, v)
      let staysOpen                                v = SetConstantValue<_> (Properties.ContextMenu.staysOpen, v)
      let onOpened                                 (f : System.Windows.Controls.ContextMenu -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ContextMenu, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onClosed                                 (f : System.Windows.Controls.ContextMenu -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ContextMenu, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let control                                  values =
      StandardView<Control> (values) :> View
    module Control = 
      let dummy = ()
      let borderBrush                              v = SetConstantValue<_> (Properties.Control.borderBrush, v)
      let borderThickness                          v = SetConstantValue<_> (Properties.Control.borderThickness, v)
      let background                               v = SetConstantValue<_> (Properties.Control.background, v)
      let foreground                               v = SetConstantValue<_> (Properties.Control.foreground, v)
      let fontFamily                               v = SetConstantValue<_> (Properties.Control.fontFamily, v)
      let fontSize                                 v = SetConstantValue<_> (Properties.Control.fontSize, v)
      let fontStretch                              v = SetConstantValue<_> (Properties.Control.fontStretch, v)
      let fontStyle                                v = SetConstantValue<_> (Properties.Control.fontStyle, v)
      let fontWeight                               v = SetConstantValue<_> (Properties.Control.fontWeight, v)
      let horizontalContentAlignment               v = SetConstantValue<_> (Properties.Control.horizontalContentAlignment, v)
      let verticalContentAlignment                 v = SetConstantValue<_> (Properties.Control.verticalContentAlignment, v)
      let tabIndex                                 v = SetConstantValue<_> (Properties.Control.tabIndex, v)
      let isTabStop                                v = SetConstantValue<_> (Properties.Control.isTabStop, v)
      let padding                                  v = SetConstantValue<_> (Properties.Control.padding, v)
      let template                                 v = SetConstantValue<_> (Properties.Control.template, v)
      let onPreviewMouseDoubleClick                (f : System.Windows.Controls.Control -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDoubleClick.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDoubleClick.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onMouseDoubleClick                       (f : System.Windows.Controls.Control -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDoubleClick.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDoubleClick.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)

    let dataGrid                                 values =
      StandardView<DataGrid> (values) :> View
    module DataGrid = 
      let dummy = ()
      let canUserResizeColumns                     v = SetConstantValue<_> (Properties.DataGrid.canUserResizeColumns, v)
      let columnWidth                              v = SetConstantValue<_> (Properties.DataGrid.columnWidth, v)
      let minColumnWidth                           v = SetConstantValue<_> (Properties.DataGrid.minColumnWidth, v)
      let maxColumnWidth                           v = SetConstantValue<_> (Properties.DataGrid.maxColumnWidth, v)
      let gridLinesVisibility                      v = SetConstantValue<_> (Properties.DataGrid.gridLinesVisibility, v)
      let horizontalGridLinesBrush                 v = SetConstantValue<_> (Properties.DataGrid.horizontalGridLinesBrush, v)
      let verticalGridLinesBrush                   v = SetConstantValue<_> (Properties.DataGrid.verticalGridLinesBrush, v)
      let rowStyle                                 v = SetConstantValue<_> (Properties.DataGrid.rowStyle, v)
      let rowValidationErrorTemplate               v = SetConstantValue<_> (Properties.DataGrid.rowValidationErrorTemplate, v)
      let rowStyleSelector                         v = SetConstantValue<_> (Properties.DataGrid.rowStyleSelector, v)
      let rowBackground                            v = SetConstantValue<_> (Properties.DataGrid.rowBackground, v)
      let alternatingRowBackground                 v = SetConstantValue<_> (Properties.DataGrid.alternatingRowBackground, v)
      let rowHeight                                v = SetConstantValue<_> (Properties.DataGrid.rowHeight, v)
      let minRowHeight                             v = SetConstantValue<_> (Properties.DataGrid.minRowHeight, v)
      let rowHeaderWidth                           v = SetConstantValue<_> (Properties.DataGrid.rowHeaderWidth, v)
      let rowHeaderActualWidth                     v = SetConstantValue<_> (Properties.DataGrid.rowHeaderActualWidth, v)
      let columnHeaderHeight                       v = SetConstantValue<_> (Properties.DataGrid.columnHeaderHeight, v)
      let headersVisibility                        v = SetConstantValue<_> (Properties.DataGrid.headersVisibility, v)
      let cellStyle                                v = SetConstantValue<_> (Properties.DataGrid.cellStyle, v)
      let columnHeaderStyle                        v = SetConstantValue<_> (Properties.DataGrid.columnHeaderStyle, v)
      let rowHeaderStyle                           v = SetConstantValue<_> (Properties.DataGrid.rowHeaderStyle, v)
      let rowHeaderTemplate                        v = SetConstantValue<_> (Properties.DataGrid.rowHeaderTemplate, v)
      let rowHeaderTemplateSelector                v = SetConstantValue<_> (Properties.DataGrid.rowHeaderTemplateSelector, v)
      let horizontalScrollBarVisibility            v = SetConstantValue<_> (Properties.DataGrid.horizontalScrollBarVisibility, v)
      let verticalScrollBarVisibility              v = SetConstantValue<_> (Properties.DataGrid.verticalScrollBarVisibility, v)
      let isReadOnly                               v = SetConstantValue<_> (Properties.DataGrid.isReadOnly, v)
      let currentItem                              v = SetConstantValue<_> (Properties.DataGrid.currentItem, v)
      let currentColumn                            v = SetConstantValue<_> (Properties.DataGrid.currentColumn, v)
      let currentCell                              v = SetConstantValue<_> (Properties.DataGrid.currentCell, v)
      let canUserAddRows                           v = SetConstantValue<_> (Properties.DataGrid.canUserAddRows, v)
      let canUserDeleteRows                        v = SetConstantValue<_> (Properties.DataGrid.canUserDeleteRows, v)
      let rowDetailsVisibilityMode                 v = SetConstantValue<_> (Properties.DataGrid.rowDetailsVisibilityMode, v)
      let areRowDetailsFrozen                      v = SetConstantValue<_> (Properties.DataGrid.areRowDetailsFrozen, v)
      let rowDetailsTemplate                       v = SetConstantValue<_> (Properties.DataGrid.rowDetailsTemplate, v)
      let rowDetailsTemplateSelector               v = SetConstantValue<_> (Properties.DataGrid.rowDetailsTemplateSelector, v)
      let canUserResizeRows                        v = SetConstantValue<_> (Properties.DataGrid.canUserResizeRows, v)
      let newItemMargin                            v = SetConstantValue<_> (Properties.DataGrid.newItemMargin, v)
      let selectionMode                            v = SetConstantValue<_> (Properties.DataGrid.selectionMode, v)
      let selectionUnit                            v = SetConstantValue<_> (Properties.DataGrid.selectionUnit, v)
      let canUserSortColumns                       v = SetConstantValue<_> (Properties.DataGrid.canUserSortColumns, v)
      let autoGenerateColumns                      v = SetConstantValue<_> (Properties.DataGrid.autoGenerateColumns, v)
      let frozenColumnCount                        v = SetConstantValue<_> (Properties.DataGrid.frozenColumnCount, v)
      let nonFrozenColumnsViewportHorizontalOffset v = SetConstantValue<_> (Properties.DataGrid.nonFrozenColumnsViewportHorizontalOffset, v)
      let enableRowVirtualization                  v = SetConstantValue<_> (Properties.DataGrid.enableRowVirtualization, v)
      let enableColumnVirtualization               v = SetConstantValue<_> (Properties.DataGrid.enableColumnVirtualization, v)
      let canUserReorderColumns                    v = SetConstantValue<_> (Properties.DataGrid.canUserReorderColumns, v)
      let dragIndicatorStyle                       v = SetConstantValue<_> (Properties.DataGrid.dragIndicatorStyle, v)
      let dropLocationIndicatorStyle               v = SetConstantValue<_> (Properties.DataGrid.dropLocationIndicatorStyle, v)
      let clipboardCopyMode                        v = SetConstantValue<_> (Properties.DataGrid.clipboardCopyMode, v)
      let cellsPanelHorizontalOffset               v = SetConstantValue<_> (Properties.DataGrid.cellsPanelHorizontalOffset, v)
      let onColumnDisplayIndexChanged              (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridColumnEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnDisplayIndexChanged.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnDisplayIndexChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs>, System.Windows.Controls.DataGridColumnEventArgs> (r, u, f)
      let onLoadingRow                             (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.LoadingRow.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.LoadingRow.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>, System.Windows.Controls.DataGridRowEventArgs> (r, u, f)
      let onUnloadingRow                           (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.UnloadingRow.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.UnloadingRow.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>, System.Windows.Controls.DataGridRowEventArgs> (r, u, f)
      let onRowEditEnding                          (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowEditEndingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEditEndingEventArgs -> unit) = o.RowEditEnding.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEditEndingEventArgs -> unit) = o.RowEditEnding.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>, System.Windows.Controls.DataGridRowEditEndingEventArgs> (r, u, f)
      let onCellEditEnding                         (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridCellEditEndingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridCellEditEndingEventArgs -> unit) = o.CellEditEnding.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridCellEditEndingEventArgs -> unit) = o.CellEditEnding.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>, System.Windows.Controls.DataGridCellEditEndingEventArgs> (r, u, f)
      let onCurrentCellChanged                     (f : System.Windows.Controls.DataGrid -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.CurrentCellChanged.AddHandler    (System.EventHandler<System.EventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.CurrentCellChanged.RemoveHandler (System.EventHandler<System.EventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.EventArgs>, System.EventArgs> (r, u, f)
      let onBeginningEdit                          (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridBeginningEditEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridBeginningEditEventArgs -> unit) = o.BeginningEdit.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridBeginningEditEventArgs -> unit) = o.BeginningEdit.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>, System.Windows.Controls.DataGridBeginningEditEventArgs> (r, u, f)
      let onPreparingCellForEdit                   (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridPreparingCellForEditEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridPreparingCellForEditEventArgs -> unit) = o.PreparingCellForEdit.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridPreparingCellForEditEventArgs -> unit) = o.PreparingCellForEdit.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>, System.Windows.Controls.DataGridPreparingCellForEditEventArgs> (r, u, f)
      let onAddingNewItem                          (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.AddingNewItemEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.AddingNewItemEventArgs -> unit) = o.AddingNewItem.AddHandler    (System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.AddingNewItemEventArgs -> unit) = o.AddingNewItem.RemoveHandler (System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs>, System.Windows.Controls.AddingNewItemEventArgs> (r, u, f)
      let onInitializingNewItem                    (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.InitializingNewItemEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.InitializingNewItemEventArgs -> unit) = o.InitializingNewItem.AddHandler    (System.Windows.Controls.InitializingNewItemEventHandler h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.InitializingNewItemEventArgs -> unit) = o.InitializingNewItem.RemoveHandler (System.Windows.Controls.InitializingNewItemEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.InitializingNewItemEventHandler, System.Windows.Controls.InitializingNewItemEventArgs> (r, u, f)
      let onLoadingRowDetails                      (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowDetailsEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.LoadingRowDetails.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.LoadingRowDetails.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs> (r, u, f)
      let onUnloadingRowDetails                    (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowDetailsEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.UnloadingRowDetails.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.UnloadingRowDetails.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs> (r, u, f)
      let onRowDetailsVisibilityChanged            (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowDetailsEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.RowDetailsVisibilityChanged.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.RowDetailsVisibilityChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs> (r, u, f)
      let onSelectedCellsChanged                   (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.SelectedCellsChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.SelectedCellsChangedEventArgs -> unit) = o.SelectedCellsChanged.AddHandler    (System.Windows.Controls.SelectedCellsChangedEventHandler h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.SelectedCellsChangedEventArgs -> unit) = o.SelectedCellsChanged.RemoveHandler (System.Windows.Controls.SelectedCellsChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.SelectedCellsChangedEventHandler, System.Windows.Controls.SelectedCellsChangedEventArgs> (r, u, f)
      let onSorting                                (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridSortingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridSortingEventArgs -> unit) = o.Sorting.AddHandler    (System.Windows.Controls.DataGridSortingEventHandler h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridSortingEventArgs -> unit) = o.Sorting.RemoveHandler (System.Windows.Controls.DataGridSortingEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSortingEventHandler, System.Windows.Controls.DataGridSortingEventArgs> (r, u, f)
      let onAutoGeneratedColumns                   (f : System.Windows.Controls.DataGrid -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.AutoGeneratedColumns.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.AutoGeneratedColumns.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler, System.EventArgs> (r, u, f)
      let onAutoGeneratingColumn                   (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs -> unit) = o.AutoGeneratingColumn.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs -> unit) = o.AutoGeneratingColumn.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> (r, u, f)
      let onColumnReordering                       (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridColumnReorderingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnReorderingEventArgs -> unit) = o.ColumnReordering.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridColumnReorderingEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnReorderingEventArgs -> unit) = o.ColumnReordering.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridColumnReorderingEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridColumnReorderingEventArgs>, System.Windows.Controls.DataGridColumnReorderingEventArgs> (r, u, f)
      let onColumnHeaderDragStarted                (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.Primitives.DragStartedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.ColumnHeaderDragStarted.AddHandler    (System.EventHandler<System.Windows.Controls.Primitives.DragStartedEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.ColumnHeaderDragStarted.RemoveHandler (System.EventHandler<System.Windows.Controls.Primitives.DragStartedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.Primitives.DragStartedEventArgs>, System.Windows.Controls.Primitives.DragStartedEventArgs> (r, u, f)
      let onColumnHeaderDragDelta                  (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.Primitives.DragDeltaEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.ColumnHeaderDragDelta.AddHandler    (System.EventHandler<System.Windows.Controls.Primitives.DragDeltaEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.ColumnHeaderDragDelta.RemoveHandler (System.EventHandler<System.Windows.Controls.Primitives.DragDeltaEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.Primitives.DragDeltaEventArgs>, System.Windows.Controls.Primitives.DragDeltaEventArgs> (r, u, f)
      let onColumnHeaderDragCompleted              (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.Primitives.DragCompletedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.ColumnHeaderDragCompleted.AddHandler    (System.EventHandler<System.Windows.Controls.Primitives.DragCompletedEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.ColumnHeaderDragCompleted.RemoveHandler (System.EventHandler<System.Windows.Controls.Primitives.DragCompletedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.Primitives.DragCompletedEventArgs>, System.Windows.Controls.Primitives.DragCompletedEventArgs> (r, u, f)
      let onColumnReordered                        (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridColumnEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnReordered.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnReordered.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs>, System.Windows.Controls.DataGridColumnEventArgs> (r, u, f)
      let onCopyingRowClipboardContent             (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowClipboardEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowClipboardEventArgs -> unit) = o.CopyingRowClipboardContent.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs> h)
        let u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowClipboardEventArgs -> unit) = o.CopyingRowClipboardContent.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs>, System.Windows.Controls.DataGridRowClipboardEventArgs> (r, u, f)

    let dataGridCell                             values child =
      StandardContentView<DataGridCell> (values, child) :> View
    module DataGridCell = 
      let dummy = ()
      let column                                   v = SetConstantValue<_> (Properties.DataGridCell.column, v)
      let isEditing                                v = SetConstantValue<_> (Properties.DataGridCell.isEditing, v)
      let isReadOnly                               v = SetConstantValue<_> (Properties.DataGridCell.isReadOnly, v)
      let isSelected                               v = SetConstantValue<_> (Properties.DataGridCell.isSelected, v)
      let onSelected                               (f : System.Windows.Controls.DataGridCell -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridCell, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onUnselected                             (f : System.Windows.Controls.DataGridCell -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridCell, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let dataGridCellsPanel                       values children =
      StandardPanelView<DataGridCellsPanel> (values, children) :> View
    module DataGridCellsPanel = 
      let dummy = ()

    let dataGridCellsPresenter                   values =
      StandardView<DataGridCellsPresenter> (values) :> View
    module DataGridCellsPresenter = 
      let dummy = ()

    let dataGridColumnHeader                     values child =
      StandardContentView<DataGridColumnHeader> (values, child) :> View
    module DataGridColumnHeader = 
      let dummy = ()
      let separatorBrush                           v = SetConstantValue<_> (Properties.DataGridColumnHeader.separatorBrush, v)
      let separatorVisibility                      v = SetConstantValue<_> (Properties.DataGridColumnHeader.separatorVisibility, v)
      let displayIndex                             v = SetConstantValue<_> (Properties.DataGridColumnHeader.displayIndex, v)
      let canUserSort                              v = SetConstantValue<_> (Properties.DataGridColumnHeader.canUserSort, v)
      let sortDirection                            v = SetConstantValue<_> (Properties.DataGridColumnHeader.sortDirection, v)
      let isFrozen                                 v = SetConstantValue<_> (Properties.DataGridColumnHeader.isFrozen, v)

    let dataGridColumnHeadersPresenter           values =
      StandardView<DataGridColumnHeadersPresenter> (values) :> View
    module DataGridColumnHeadersPresenter = 
      let dummy = ()

    let dataGridDetailsPresenter                 values =
      StandardView<DataGridDetailsPresenter> (values) :> View
    module DataGridDetailsPresenter = 
      let dummy = ()

    let dataGridRow                              values =
      StandardView<DataGridRow> (values) :> View
    module DataGridRow = 
      let dummy = ()
      let item                                     v = SetConstantValue<_> (Properties.DataGridRow.item, v)
      let itemsPanel                               v = SetConstantValue<_> (Properties.DataGridRow.itemsPanel, v)
      let header                                   v = SetConstantValue<_> (Properties.DataGridRow.header, v)
      let headerStyle                              v = SetConstantValue<_> (Properties.DataGridRow.headerStyle, v)
      let headerTemplate                           v = SetConstantValue<_> (Properties.DataGridRow.headerTemplate, v)
      let headerTemplateSelector                   v = SetConstantValue<_> (Properties.DataGridRow.headerTemplateSelector, v)
      let validationErrorTemplate                  v = SetConstantValue<_> (Properties.DataGridRow.validationErrorTemplate, v)
      let detailsTemplate                          v = SetConstantValue<_> (Properties.DataGridRow.detailsTemplate, v)
      let detailsTemplateSelector                  v = SetConstantValue<_> (Properties.DataGridRow.detailsTemplateSelector, v)
      let detailsVisibility                        v = SetConstantValue<_> (Properties.DataGridRow.detailsVisibility, v)
      let alternationIndex                         v = SetConstantValue<_> (Properties.DataGridRow.alternationIndex, v)
      let isSelected                               v = SetConstantValue<_> (Properties.DataGridRow.isSelected, v)
      let isEditing                                v = SetConstantValue<_> (Properties.DataGridRow.isEditing, v)
      let isNewItem                                v = SetConstantValue<_> (Properties.DataGridRow.isNewItem, v)
      let onSelected                               (f : System.Windows.Controls.DataGridRow -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridRow, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onUnselected                             (f : System.Windows.Controls.DataGridRow -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridRow, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let dataGridRowHeader                        values child =
      StandardContentView<DataGridRowHeader> (values, child) :> View
    module DataGridRowHeader = 
      let dummy = ()
      let separatorBrush                           v = SetConstantValue<_> (Properties.DataGridRowHeader.separatorBrush, v)
      let separatorVisibility                      v = SetConstantValue<_> (Properties.DataGridRowHeader.separatorVisibility, v)
      let isRowSelected                            v = SetConstantValue<_> (Properties.DataGridRowHeader.isRowSelected, v)

    let dataGridRowsPresenter                    values children =
      StandardPanelView<DataGridRowsPresenter> (values, children) :> View
    module DataGridRowsPresenter = 
      let dummy = ()

    let datePicker                               values =
      StandardView<DatePicker> (values) :> View
    module DatePicker = 
      let dummy = ()
      let calendarStyle                            v = SetConstantValue<_> (Properties.DatePicker.calendarStyle, v)
      let displayDate                              v = SetConstantValue<_> (Properties.DatePicker.displayDate, v)
      let displayDateEnd                           v = SetConstantValue<_> (Properties.DatePicker.displayDateEnd, v)
      let displayDateStart                         v = SetConstantValue<_> (Properties.DatePicker.displayDateStart, v)
      let firstDayOfWeek                           v = SetConstantValue<_> (Properties.DatePicker.firstDayOfWeek, v)
      let isDropDownOpen                           v = SetConstantValue<_> (Properties.DatePicker.isDropDownOpen, v)
      let isTodayHighlighted                       v = SetConstantValue<_> (Properties.DatePicker.isTodayHighlighted, v)
      let selectedDate                             v = SetConstantValue<_> (Properties.DatePicker.selectedDate, v)
      let selectedDateFormat                       v = SetConstantValue<_> (Properties.DatePicker.selectedDateFormat, v)
      let text                                     v = SetConstantValue<_> (Properties.DatePicker.text, v)
      let onCalendarClosed                         (f : System.Windows.Controls.DatePicker -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarClosed.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarClosed.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onCalendarOpened                         (f : System.Windows.Controls.DatePicker -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarOpened.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarOpened.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onDateValidationError                    (f : System.Windows.Controls.DatePicker -> System.Windows.Controls.DatePickerDateValidationErrorEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.DatePickerDateValidationErrorEventArgs -> unit) = o.DateValidationError.AddHandler    (System.EventHandler<System.Windows.Controls.DatePickerDateValidationErrorEventArgs> h)
        let u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.DatePickerDateValidationErrorEventArgs -> unit) = o.DateValidationError.RemoveHandler (System.EventHandler<System.Windows.Controls.DatePickerDateValidationErrorEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.DatePickerDateValidationErrorEventArgs>, System.Windows.Controls.DatePickerDateValidationErrorEventArgs> (r, u, f)
      let onSelectedDateChanged                    (f : System.Windows.Controls.DatePicker -> System.Windows.Controls.SelectionChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDateChanged.AddHandler    (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
        let u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDateChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> (r, u, f)

    let datePickerTextBox                        values =
      StandardView<DatePickerTextBox> (values) :> View
    module DatePickerTextBox = 
      let dummy = ()

    let decorator                                values =
      StandardView<Decorator> (values) :> View
    module Decorator = 
      let dummy = ()

    let dockPanel                                values children =
      StandardPanelView<DockPanel> (values, children) :> View
    module DockPanel = 
      let dummy = ()
      let lastChildFill                            v = SetConstantValue<_> (Properties.DockPanel.lastChildFill, v)
      let dock                                     v = SetConstantValue<_> (Properties.DockPanel.dock, v)

    let documentPageView                         values =
      StandardView<DocumentPageView> (values) :> View
    module DocumentPageView = 
      let dummy = ()
      let pageNumber                               v = SetConstantValue<_> (Properties.DocumentPageView.pageNumber, v)
      let stretch                                  v = SetConstantValue<_> (Properties.DocumentPageView.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.DocumentPageView.stretchDirection, v)
      let onPageConnected                          (f : System.Windows.Controls.Primitives.DocumentPageView -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageConnected.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageConnected.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.EventHandler, System.EventArgs> (r, u, f)
      let onPageDisconnected                       (f : System.Windows.Controls.Primitives.DocumentPageView -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageDisconnected.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageDisconnected.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.EventHandler, System.EventArgs> (r, u, f)

    let documentReference                        values =
      StandardView<DocumentReference> (values) :> View
    module DocumentReference = 
      let dummy = ()
      let source                                   v = SetConstantValue<_> (Properties.DocumentReference.source, v)

    let documentViewer                           values =
      StandardView<DocumentViewer> (values) :> View
    module DocumentViewer = 
      let dummy = ()
      let horizontalOffset                         v = SetConstantValue<_> (Properties.DocumentViewer.horizontalOffset, v)
      let verticalOffset                           v = SetConstantValue<_> (Properties.DocumentViewer.verticalOffset, v)
      let extentWidth                              v = SetConstantValue<_> (Properties.DocumentViewer.extentWidth, v)
      let extentHeight                             v = SetConstantValue<_> (Properties.DocumentViewer.extentHeight, v)
      let viewportWidth                            v = SetConstantValue<_> (Properties.DocumentViewer.viewportWidth, v)
      let viewportHeight                           v = SetConstantValue<_> (Properties.DocumentViewer.viewportHeight, v)
      let showPageBorders                          v = SetConstantValue<_> (Properties.DocumentViewer.showPageBorders, v)
      let zoom                                     v = SetConstantValue<_> (Properties.DocumentViewer.zoom, v)
      let maxPagesAcross                           v = SetConstantValue<_> (Properties.DocumentViewer.maxPagesAcross, v)
      let verticalPageSpacing                      v = SetConstantValue<_> (Properties.DocumentViewer.verticalPageSpacing, v)
      let horizontalPageSpacing                    v = SetConstantValue<_> (Properties.DocumentViewer.horizontalPageSpacing, v)
      let canMoveUp                                v = SetConstantValue<_> (Properties.DocumentViewer.canMoveUp, v)
      let canMoveDown                              v = SetConstantValue<_> (Properties.DocumentViewer.canMoveDown, v)
      let canMoveLeft                              v = SetConstantValue<_> (Properties.DocumentViewer.canMoveLeft, v)
      let canMoveRight                             v = SetConstantValue<_> (Properties.DocumentViewer.canMoveRight, v)
      let canIncreaseZoom                          v = SetConstantValue<_> (Properties.DocumentViewer.canIncreaseZoom, v)
      let canDecreaseZoom                          v = SetConstantValue<_> (Properties.DocumentViewer.canDecreaseZoom, v)

    module DocumentViewerBase = 
      let dummy = ()
      let document                                 v = SetConstantValue<_> (Properties.DocumentViewerBase.document, v)
      let pageCount                                v = SetConstantValue<_> (Properties.DocumentViewerBase.pageCount, v)
      let masterPageNumber                         v = SetConstantValue<_> (Properties.DocumentViewerBase.masterPageNumber, v)
      let canGoToPreviousPage                      v = SetConstantValue<_> (Properties.DocumentViewerBase.canGoToPreviousPage, v)
      let canGoToNextPage                          v = SetConstantValue<_> (Properties.DocumentViewerBase.canGoToNextPage, v)
      let isMasterPage                             v = SetConstantValue<_> (Properties.DocumentViewerBase.isMasterPage, v)
      let onPageViewsChanged                       (f : System.Windows.Controls.Primitives.DocumentViewerBase -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.DocumentViewerBase) (h : obj -> System.EventArgs -> unit) = o.PageViewsChanged.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.Primitives.DocumentViewerBase) (h : obj -> System.EventArgs -> unit) = o.PageViewsChanged.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.DocumentViewerBase, System.EventHandler, System.EventArgs> (r, u, f)

    let ellipse                                  values =
      StandardView<Ellipse> (values) :> View
    module Ellipse = 
      let dummy = ()

    let expander                                 values child =
      StandardContentView<Expander> (values, child) :> View
    module Expander = 
      let dummy = ()
      let expandDirection                          v = SetConstantValue<_> (Properties.Expander.expandDirection, v)
      let isExpanded                               v = SetConstantValue<_> (Properties.Expander.isExpanded, v)
      let onExpanded                               (f : System.Windows.Controls.Expander -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Expander, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onCollapsed                              (f : System.Windows.Controls.Expander -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Expander, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let fixedPage                                values =
      StandardView<FixedPage> (values) :> View
    module FixedPage = 
      let dummy = ()
      let printTicket                              v = SetConstantValue<_> (Properties.FixedPage.printTicket, v)
      let background                               v = SetConstantValue<_> (Properties.FixedPage.background, v)
      let left                                     v = SetConstantValue<_> (Properties.FixedPage.left, v)
      let top                                      v = SetConstantValue<_> (Properties.FixedPage.top, v)
      let right                                    v = SetConstantValue<_> (Properties.FixedPage.right, v)
      let bottom                                   v = SetConstantValue<_> (Properties.FixedPage.bottom, v)
      let contentBox                               v = SetConstantValue<_> (Properties.FixedPage.contentBox, v)
      let bleedBox                                 v = SetConstantValue<_> (Properties.FixedPage.bleedBox, v)
      let navigateUri                              v = SetConstantValue<_> (Properties.FixedPage.navigateUri, v)

    let flowDocumentPageViewer                   values =
      StandardView<FlowDocumentPageViewer> (values) :> View
    module FlowDocumentPageViewer = 
      let dummy = ()
      let zoom                                     v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.zoom, v)
      let maxZoom                                  v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.maxZoom, v)
      let minZoom                                  v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.minZoom, v)
      let zoomIncrement                            v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.zoomIncrement, v)
      let canIncreaseZoom                          v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.canIncreaseZoom, v)
      let canDecreaseZoom                          v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.canDecreaseZoom, v)
      let selectionBrush                           v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.selectionBrush, v)
      let selectionOpacity                         v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.selectionOpacity, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.isSelectionActive, v)
      let isInactiveSelectionHighlightEnabled      v = SetConstantValue<_> (Properties.FlowDocumentPageViewer.isInactiveSelectionHighlightEnabled, v)

    let flowDocumentReader                       values =
      StandardView<FlowDocumentReader> (values) :> View
    module FlowDocumentReader = 
      let dummy = ()
      let viewingMode                              v = SetConstantValue<_> (Properties.FlowDocumentReader.viewingMode, v)
      let isPageViewEnabled                        v = SetConstantValue<_> (Properties.FlowDocumentReader.isPageViewEnabled, v)
      let isTwoPageViewEnabled                     v = SetConstantValue<_> (Properties.FlowDocumentReader.isTwoPageViewEnabled, v)
      let isScrollViewEnabled                      v = SetConstantValue<_> (Properties.FlowDocumentReader.isScrollViewEnabled, v)
      let pageCount                                v = SetConstantValue<_> (Properties.FlowDocumentReader.pageCount, v)
      let pageNumber                               v = SetConstantValue<_> (Properties.FlowDocumentReader.pageNumber, v)
      let canGoToPreviousPage                      v = SetConstantValue<_> (Properties.FlowDocumentReader.canGoToPreviousPage, v)
      let canGoToNextPage                          v = SetConstantValue<_> (Properties.FlowDocumentReader.canGoToNextPage, v)
      let isFindEnabled                            v = SetConstantValue<_> (Properties.FlowDocumentReader.isFindEnabled, v)
      let isPrintEnabled                           v = SetConstantValue<_> (Properties.FlowDocumentReader.isPrintEnabled, v)
      let document                                 v = SetConstantValue<_> (Properties.FlowDocumentReader.document, v)
      let zoom                                     v = SetConstantValue<_> (Properties.FlowDocumentReader.zoom, v)
      let maxZoom                                  v = SetConstantValue<_> (Properties.FlowDocumentReader.maxZoom, v)
      let minZoom                                  v = SetConstantValue<_> (Properties.FlowDocumentReader.minZoom, v)
      let zoomIncrement                            v = SetConstantValue<_> (Properties.FlowDocumentReader.zoomIncrement, v)
      let canIncreaseZoom                          v = SetConstantValue<_> (Properties.FlowDocumentReader.canIncreaseZoom, v)
      let canDecreaseZoom                          v = SetConstantValue<_> (Properties.FlowDocumentReader.canDecreaseZoom, v)
      let selectionBrush                           v = SetConstantValue<_> (Properties.FlowDocumentReader.selectionBrush, v)
      let selectionOpacity                         v = SetConstantValue<_> (Properties.FlowDocumentReader.selectionOpacity, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.FlowDocumentReader.isSelectionActive, v)
      let isInactiveSelectionHighlightEnabled      v = SetConstantValue<_> (Properties.FlowDocumentReader.isInactiveSelectionHighlightEnabled, v)

    let flowDocumentScrollViewer                 values =
      StandardView<FlowDocumentScrollViewer> (values) :> View
    module FlowDocumentScrollViewer = 
      let dummy = ()
      let document                                 v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.document, v)
      let zoom                                     v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.zoom, v)
      let maxZoom                                  v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.maxZoom, v)
      let minZoom                                  v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.minZoom, v)
      let zoomIncrement                            v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.zoomIncrement, v)
      let canIncreaseZoom                          v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.canIncreaseZoom, v)
      let canDecreaseZoom                          v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.canDecreaseZoom, v)
      let isSelectionEnabled                       v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.isSelectionEnabled, v)
      let isToolBarVisible                         v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.isToolBarVisible, v)
      let horizontalScrollBarVisibility            v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.horizontalScrollBarVisibility, v)
      let verticalScrollBarVisibility              v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.verticalScrollBarVisibility, v)
      let selectionBrush                           v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.selectionBrush, v)
      let selectionOpacity                         v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.selectionOpacity, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.isSelectionActive, v)
      let isInactiveSelectionHighlightEnabled      v = SetConstantValue<_> (Properties.FlowDocumentScrollViewer.isInactiveSelectionHighlightEnabled, v)

    let frame                                    values child =
      StandardContentView<Frame> (values, child) :> View
    module Frame = 
      let dummy = ()
      let source                                   v = SetConstantValue<_> (Properties.Frame.source, v)
      let canGoBack                                v = SetConstantValue<_> (Properties.Frame.canGoBack, v)
      let canGoForward                             v = SetConstantValue<_> (Properties.Frame.canGoForward, v)
      let backStack                                v = SetConstantValue<_> (Properties.Frame.backStack, v)
      let forwardStack                             v = SetConstantValue<_> (Properties.Frame.forwardStack, v)
      let navigationUIVisibility                   v = SetConstantValue<_> (Properties.Frame.navigationUIVisibility, v)
      let sandboxExternalContent                   v = SetConstantValue<_> (Properties.Frame.sandboxExternalContent, v)
      let journalOwnership                         v = SetConstantValue<_> (Properties.Frame.journalOwnership, v)
      let onContentRendered                        (f : System.Windows.Controls.Frame -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.EventHandler, System.EventArgs> (r, u, f)
      let onNavigating                             (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigatingCancelEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.AddHandler    (System.Windows.Navigation.NavigatingCancelEventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.RemoveHandler (System.Windows.Navigation.NavigatingCancelEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs> (r, u, f)
      let onNavigationProgress                     (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationProgressEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.AddHandler    (System.Windows.Navigation.NavigationProgressEventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.RemoveHandler (System.Windows.Navigation.NavigationProgressEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs> (r, u, f)
      let onNavigationFailed                       (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationFailedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.AddHandler    (System.Windows.Navigation.NavigationFailedEventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.RemoveHandler (System.Windows.Navigation.NavigationFailedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs> (r, u, f)
      let onNavigated                              (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.AddHandler    (System.Windows.Navigation.NavigatedEventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.RemoveHandler (System.Windows.Navigation.NavigatedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)
      let onLoadCompleted                          (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.AddHandler    (System.Windows.Navigation.LoadCompletedEventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.RemoveHandler (System.Windows.Navigation.LoadCompletedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)
      let onNavigationStopped                      (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.AddHandler    (System.Windows.Navigation.NavigationStoppedEventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.RemoveHandler (System.Windows.Navigation.NavigationStoppedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)
      let onFragmentNavigation                     (f : System.Windows.Controls.Frame -> System.Windows.Navigation.FragmentNavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.AddHandler    (System.Windows.Navigation.FragmentNavigationEventHandler h)
        let u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.RemoveHandler (System.Windows.Navigation.FragmentNavigationEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs> (r, u, f)

    let frameworkElement                         values =
      StandardView<FrameworkElement> (values) :> View
    module FrameworkElement = 
      let dummy = ()
      let style                                    v = SetConstantValue<_> (Properties.FrameworkElement.style, v)
      let overridesDefaultStyle                    v = SetConstantValue<_> (Properties.FrameworkElement.overridesDefaultStyle, v)
      let useLayoutRounding                        v = SetConstantValue<_> (Properties.FrameworkElement.useLayoutRounding, v)
      let dataContext                              v = SetConstantValue<_> (Properties.FrameworkElement.dataContext, v)
      let bindingGroup                             v = SetConstantValue<_> (Properties.FrameworkElement.bindingGroup, v)
      let language                                 v = SetConstantValue<_> (Properties.FrameworkElement.language, v)
      let name                                     v = SetConstantValue<_> (Properties.FrameworkElement.name, v)
      let tag                                      v = SetConstantValue<_> (Properties.FrameworkElement.tag, v)
      let inputScope                               v = SetConstantValue<_> (Properties.FrameworkElement.inputScope, v)
      let actualWidth                              v = SetConstantValue<_> (Properties.FrameworkElement.actualWidth, v)
      let actualHeight                             v = SetConstantValue<_> (Properties.FrameworkElement.actualHeight, v)
      let layoutTransform                          v = SetConstantValue<_> (Properties.FrameworkElement.layoutTransform, v)
      let width                                    v = SetConstantValue<_> (Properties.FrameworkElement.width, v)
      let minWidth                                 v = SetConstantValue<_> (Properties.FrameworkElement.minWidth, v)
      let maxWidth                                 v = SetConstantValue<_> (Properties.FrameworkElement.maxWidth, v)
      let height                                   v = SetConstantValue<_> (Properties.FrameworkElement.height, v)
      let minHeight                                v = SetConstantValue<_> (Properties.FrameworkElement.minHeight, v)
      let maxHeight                                v = SetConstantValue<_> (Properties.FrameworkElement.maxHeight, v)
      let flowDirection                            v = SetConstantValue<_> (Properties.FrameworkElement.flowDirection, v)
      let margin                                   v = SetConstantValue<_> (Properties.FrameworkElement.margin, v)
      let horizontalAlignment                      v = SetConstantValue<_> (Properties.FrameworkElement.horizontalAlignment, v)
      let verticalAlignment                        v = SetConstantValue<_> (Properties.FrameworkElement.verticalAlignment, v)
      let focusVisualStyle                         v = SetConstantValue<_> (Properties.FrameworkElement.focusVisualStyle, v)
      let cursor                                   v = SetConstantValue<_> (Properties.FrameworkElement.cursor, v)
      let forceCursor                              v = SetConstantValue<_> (Properties.FrameworkElement.forceCursor, v)
      let toolTip                                  v = SetConstantValue<_> (Properties.FrameworkElement.toolTip, v)
      let contextMenu                              v = SetConstantValue<_> (Properties.FrameworkElement.contextMenu, v)
      let onTargetUpdated                          (f : System.Windows.FrameworkElement -> System.Windows.Data.DataTransferEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.TargetUpdated.AddHandler    (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.TargetUpdated.RemoveHandler (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs> (r, u, f)
      let onSourceUpdated                          (f : System.Windows.FrameworkElement -> System.Windows.Data.DataTransferEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.SourceUpdated.AddHandler    (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.SourceUpdated.RemoveHandler (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs> (r, u, f)
      let onDataContextChanged                     (f : System.Windows.FrameworkElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.DataContextChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.DataContextChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onRequestBringIntoView                   (f : System.Windows.FrameworkElement -> System.Windows.RequestBringIntoViewEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RequestBringIntoViewEventArgs -> unit) = o.RequestBringIntoView.AddHandler    (System.Windows.RequestBringIntoViewEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RequestBringIntoViewEventArgs -> unit) = o.RequestBringIntoView.RemoveHandler (System.Windows.RequestBringIntoViewEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs> (r, u, f)
      let onSizeChanged                            (f : System.Windows.FrameworkElement -> System.Windows.SizeChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.SizeChangedEventArgs -> unit) = o.SizeChanged.AddHandler    (System.Windows.SizeChangedEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.SizeChangedEventArgs -> unit) = o.SizeChanged.RemoveHandler (System.Windows.SizeChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs> (r, u, f)
      let onInitialized                            (f : System.Windows.FrameworkElement -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.EventArgs -> unit) = o.Initialized.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.EventArgs -> unit) = o.Initialized.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.EventHandler, System.EventArgs> (r, u, f)
      let onLoaded                                 (f : System.Windows.FrameworkElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Loaded.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Loaded.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onUnloaded                               (f : System.Windows.FrameworkElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unloaded.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unloaded.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onToolTipOpening                         (f : System.Windows.FrameworkElement -> System.Windows.Controls.ToolTipEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipOpening.AddHandler    (System.Windows.Controls.ToolTipEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipOpening.RemoveHandler (System.Windows.Controls.ToolTipEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> (r, u, f)
      let onToolTipClosing                         (f : System.Windows.FrameworkElement -> System.Windows.Controls.ToolTipEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipClosing.AddHandler    (System.Windows.Controls.ToolTipEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipClosing.RemoveHandler (System.Windows.Controls.ToolTipEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> (r, u, f)
      let onContextMenuOpening                     (f : System.Windows.FrameworkElement -> System.Windows.Controls.ContextMenuEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuOpening.AddHandler    (System.Windows.Controls.ContextMenuEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuOpening.RemoveHandler (System.Windows.Controls.ContextMenuEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> (r, u, f)
      let onContextMenuClosing                     (f : System.Windows.FrameworkElement -> System.Windows.Controls.ContextMenuEventArgs-> 'TMessage) = 
        let r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuClosing.AddHandler    (System.Windows.Controls.ContextMenuEventHandler h)
        let u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuClosing.RemoveHandler (System.Windows.Controls.ContextMenuEventHandler h)
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> (r, u, f)

    let glyphs                                   values =
      StandardView<Glyphs> (values) :> View
    module Glyphs = 
      let dummy = ()
      let fill                                     v = SetConstantValue<_> (Properties.Glyphs.fill, v)
      let indices                                  v = SetConstantValue<_> (Properties.Glyphs.indices, v)
      let unicodeString                            v = SetConstantValue<_> (Properties.Glyphs.unicodeString, v)
      let caretStops                               v = SetConstantValue<_> (Properties.Glyphs.caretStops, v)
      let fontRenderingEmSize                      v = SetConstantValue<_> (Properties.Glyphs.fontRenderingEmSize, v)
      let originX                                  v = SetConstantValue<_> (Properties.Glyphs.originX, v)
      let originY                                  v = SetConstantValue<_> (Properties.Glyphs.originY, v)
      let fontUri                                  v = SetConstantValue<_> (Properties.Glyphs.fontUri, v)
      let styleSimulations                         v = SetConstantValue<_> (Properties.Glyphs.styleSimulations, v)
      let isSideways                               v = SetConstantValue<_> (Properties.Glyphs.isSideways, v)
      let bidiLevel                                v = SetConstantValue<_> (Properties.Glyphs.bidiLevel, v)
      let deviceFontName                           v = SetConstantValue<_> (Properties.Glyphs.deviceFontName, v)

    let grid                                     values children =
      StandardPanelView<Grid> (values, children) :> View
    module Grid = 
      let dummy = ()
      let showGridLines                            v = SetConstantValue<_> (Properties.Grid.showGridLines, v)
      let column                                   v = SetConstantValue<_> (Properties.Grid.column, v)
      let row                                      v = SetConstantValue<_> (Properties.Grid.row, v)
      let columnSpan                               v = SetConstantValue<_> (Properties.Grid.columnSpan, v)
      let rowSpan                                  v = SetConstantValue<_> (Properties.Grid.rowSpan, v)
      let isSharedSizeScope                        v = SetConstantValue<_> (Properties.Grid.isSharedSizeScope, v)

    let gridSplitter                             values =
      StandardView<GridSplitter> (values) :> View
    module GridSplitter = 
      let dummy = ()
      let resizeDirection                          v = SetConstantValue<_> (Properties.GridSplitter.resizeDirection, v)
      let resizeBehavior                           v = SetConstantValue<_> (Properties.GridSplitter.resizeBehavior, v)
      let showsPreview                             v = SetConstantValue<_> (Properties.GridSplitter.showsPreview, v)
      let previewStyle                             v = SetConstantValue<_> (Properties.GridSplitter.previewStyle, v)
      let keyboardIncrement                        v = SetConstantValue<_> (Properties.GridSplitter.keyboardIncrement, v)
      let dragIncrement                            v = SetConstantValue<_> (Properties.GridSplitter.dragIncrement, v)

    let gridViewColumnHeader                     values child =
      StandardContentView<GridViewColumnHeader> (values, child) :> View
    module GridViewColumnHeader = 
      let dummy = ()
      let column                                   v = SetConstantValue<_> (Properties.GridViewColumnHeader.column, v)
      let role                                     v = SetConstantValue<_> (Properties.GridViewColumnHeader.role, v)

    let gridViewHeaderRowPresenter               values =
      StandardView<GridViewHeaderRowPresenter> (values) :> View
    module GridViewHeaderRowPresenter = 
      let dummy = ()
      let columnHeaderContainerStyle               v = SetConstantValue<_> (Properties.GridViewHeaderRowPresenter.columnHeaderContainerStyle, v)
      let columnHeaderTemplate                     v = SetConstantValue<_> (Properties.GridViewHeaderRowPresenter.columnHeaderTemplate, v)
      let columnHeaderTemplateSelector             v = SetConstantValue<_> (Properties.GridViewHeaderRowPresenter.columnHeaderTemplateSelector, v)
      let columnHeaderStringFormat                 v = SetConstantValue<_> (Properties.GridViewHeaderRowPresenter.columnHeaderStringFormat, v)
      let allowsColumnReorder                      v = SetConstantValue<_> (Properties.GridViewHeaderRowPresenter.allowsColumnReorder, v)
      let columnHeaderContextMenu                  v = SetConstantValue<_> (Properties.GridViewHeaderRowPresenter.columnHeaderContextMenu, v)
      let columnHeaderToolTip                      v = SetConstantValue<_> (Properties.GridViewHeaderRowPresenter.columnHeaderToolTip, v)

    let gridViewRowPresenter                     values =
      StandardView<GridViewRowPresenter> (values) :> View
    module GridViewRowPresenter = 
      let dummy = ()
      let content                                  v = SetConstantValue<_> (Properties.GridViewRowPresenter.content, v)

    module GridViewRowPresenterBase = 
      let dummy = ()
      let columns                                  v = SetConstantValue<_> (Properties.GridViewRowPresenterBase.columns, v)

    let groupBox                                 values child =
      StandardContentView<GroupBox> (values, child) :> View
    module GroupBox = 
      let dummy = ()

    let groupItem                                values child =
      StandardContentView<GroupItem> (values, child) :> View
    module GroupItem = 
      let dummy = ()

    let headeredContentControl                   values child =
      StandardContentView<HeaderedContentControl> (values, child) :> View
    module HeaderedContentControl = 
      let dummy = ()
      let header                                   v = SetConstantValue<_> (Properties.HeaderedContentControl.header, v)
      let hasHeader                                v = SetConstantValue<_> (Properties.HeaderedContentControl.hasHeader, v)
      let headerTemplate                           v = SetConstantValue<_> (Properties.HeaderedContentControl.headerTemplate, v)
      let headerTemplateSelector                   v = SetConstantValue<_> (Properties.HeaderedContentControl.headerTemplateSelector, v)
      let headerStringFormat                       v = SetConstantValue<_> (Properties.HeaderedContentControl.headerStringFormat, v)

    let headeredItemsControl                     values =
      StandardView<HeaderedItemsControl> (values) :> View
    module HeaderedItemsControl = 
      let dummy = ()
      let header                                   v = SetConstantValue<_> (Properties.HeaderedItemsControl.header, v)
      let hasHeader                                v = SetConstantValue<_> (Properties.HeaderedItemsControl.hasHeader, v)
      let headerTemplate                           v = SetConstantValue<_> (Properties.HeaderedItemsControl.headerTemplate, v)
      let headerTemplateSelector                   v = SetConstantValue<_> (Properties.HeaderedItemsControl.headerTemplateSelector, v)
      let headerStringFormat                       v = SetConstantValue<_> (Properties.HeaderedItemsControl.headerStringFormat, v)

    let image                                    values =
      StandardView<Image> (values) :> View
    module Image = 
      let dummy = ()
      let source                                   v = SetConstantValue<_> (Properties.Image.source, v)
      let stretch                                  v = SetConstantValue<_> (Properties.Image.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.Image.stretchDirection, v)
      let onImageFailed                            (f : System.Windows.Controls.Image -> System.Windows.ExceptionRoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Image) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.ImageFailed.AddHandler    (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
        let u (o : System.Windows.Controls.Image) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.ImageFailed.RemoveHandler (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.Image, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> (r, u, f)
      let onDpiChanged                             (f : System.Windows.Controls.Image -> System.Windows.DpiChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Image) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.AddHandler    (System.Windows.DpiChangedEventHandler h)
        let u (o : System.Windows.Controls.Image) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.RemoveHandler (System.Windows.DpiChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Image, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> (r, u, f)

    let inkCanvas                                values =
      StandardView<InkCanvas> (values) :> View
    module InkCanvas = 
      let dummy = ()
      let background                               v = SetConstantValue<_> (Properties.InkCanvas.background, v)
      let top                                      v = SetConstantValue<_> (Properties.InkCanvas.top, v)
      let bottom                                   v = SetConstantValue<_> (Properties.InkCanvas.bottom, v)
      let left                                     v = SetConstantValue<_> (Properties.InkCanvas.left, v)
      let right                                    v = SetConstantValue<_> (Properties.InkCanvas.right, v)
      let strokes                                  v = SetConstantValue<_> (Properties.InkCanvas.strokes, v)
      let defaultDrawingAttributes                 v = SetConstantValue<_> (Properties.InkCanvas.defaultDrawingAttributes, v)
      let activeEditingMode                        v = SetConstantValue<_> (Properties.InkCanvas.activeEditingMode, v)
      let editingMode                              v = SetConstantValue<_> (Properties.InkCanvas.editingMode, v)
      let editingModeInverted                      v = SetConstantValue<_> (Properties.InkCanvas.editingModeInverted, v)
      let onStrokeCollected                        (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasStrokeCollectedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeCollectedEventArgs -> unit) = o.StrokeCollected.AddHandler    (System.Windows.Controls.InkCanvasStrokeCollectedEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeCollectedEventArgs -> unit) = o.StrokeCollected.RemoveHandler (System.Windows.Controls.InkCanvasStrokeCollectedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> (r, u, f)
      let onGesture                                (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasGestureEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasGestureEventArgs -> unit) = o.Gesture.AddHandler    (System.Windows.Controls.InkCanvasGestureEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasGestureEventArgs -> unit) = o.Gesture.RemoveHandler (System.Windows.Controls.InkCanvasGestureEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs> (r, u, f)
      let onStrokesReplaced                        (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasStrokesReplacedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokesReplacedEventArgs -> unit) = o.StrokesReplaced.AddHandler    (System.Windows.Controls.InkCanvasStrokesReplacedEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokesReplacedEventArgs -> unit) = o.StrokesReplaced.RemoveHandler (System.Windows.Controls.InkCanvasStrokesReplacedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasStrokesReplacedEventHandler, System.Windows.Controls.InkCanvasStrokesReplacedEventArgs> (r, u, f)
      let onDefaultDrawingAttributesReplaced       (f : System.Windows.Controls.InkCanvas -> System.Windows.Ink.DrawingAttributesReplacedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Ink.DrawingAttributesReplacedEventArgs -> unit) = o.DefaultDrawingAttributesReplaced.AddHandler    (System.Windows.Ink.DrawingAttributesReplacedEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Ink.DrawingAttributesReplacedEventArgs -> unit) = o.DefaultDrawingAttributesReplaced.RemoveHandler (System.Windows.Ink.DrawingAttributesReplacedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Ink.DrawingAttributesReplacedEventHandler, System.Windows.Ink.DrawingAttributesReplacedEventArgs> (r, u, f)
      let onActiveEditingModeChanged               (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.ActiveEditingModeChanged.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.ActiveEditingModeChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onEditingModeChanged                     (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeChanged.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onEditingModeInvertedChanged             (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeInvertedChanged.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeInvertedChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onSelectionMoving                        (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionMoving.AddHandler    (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionMoving.RemoveHandler (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs> (r, u, f)
      let onSelectionMoved                         (f : System.Windows.Controls.InkCanvas -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionMoved.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionMoved.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.EventHandler, System.EventArgs> (r, u, f)
      let onStrokeErasing                          (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasStrokeErasingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeErasingEventArgs -> unit) = o.StrokeErasing.AddHandler    (System.Windows.Controls.InkCanvasStrokeErasingEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeErasingEventArgs -> unit) = o.StrokeErasing.RemoveHandler (System.Windows.Controls.InkCanvasStrokeErasingEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasStrokeErasingEventHandler, System.Windows.Controls.InkCanvasStrokeErasingEventArgs> (r, u, f)
      let onStrokeErased                           (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.StrokeErased.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.StrokeErased.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onSelectionResizing                      (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionResizing.AddHandler    (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionResizing.RemoveHandler (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs> (r, u, f)
      let onSelectionResized                       (f : System.Windows.Controls.InkCanvas -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionResized.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionResized.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.EventHandler, System.EventArgs> (r, u, f)
      let onSelectionChanging                      (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasSelectionChangingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionChangingEventArgs -> unit) = o.SelectionChanging.AddHandler    (System.Windows.Controls.InkCanvasSelectionChangingEventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionChangingEventArgs -> unit) = o.SelectionChanging.RemoveHandler (System.Windows.Controls.InkCanvasSelectionChangingEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasSelectionChangingEventHandler, System.Windows.Controls.InkCanvasSelectionChangingEventArgs> (r, u, f)
      let onSelectionChanged                       (f : System.Windows.Controls.InkCanvas -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionChanged.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionChanged.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.EventHandler, System.EventArgs> (r, u, f)

    let inkPresenter                             values =
      StandardView<InkPresenter> (values) :> View
    module InkPresenter = 
      let dummy = ()
      let strokes                                  v = SetConstantValue<_> (Properties.InkPresenter.strokes, v)

    let itemsControl                             values =
      StandardView<ItemsControl> (values) :> View
    module ItemsControl = 
      let dummy = ()
      let itemsSource                              v = SetConstantValue<_> (Properties.ItemsControl.itemsSource, v)
      let hasItems                                 v = SetConstantValue<_> (Properties.ItemsControl.hasItems, v)
      let displayMemberPath                        v = SetConstantValue<_> (Properties.ItemsControl.displayMemberPath, v)
      let itemTemplate                             v = SetConstantValue<_> (Properties.ItemsControl.itemTemplate, v)
      let itemTemplateSelector                     v = SetConstantValue<_> (Properties.ItemsControl.itemTemplateSelector, v)
      let itemStringFormat                         v = SetConstantValue<_> (Properties.ItemsControl.itemStringFormat, v)
      let itemBindingGroup                         v = SetConstantValue<_> (Properties.ItemsControl.itemBindingGroup, v)
      let itemContainerStyle                       v = SetConstantValue<_> (Properties.ItemsControl.itemContainerStyle, v)
      let itemContainerStyleSelector               v = SetConstantValue<_> (Properties.ItemsControl.itemContainerStyleSelector, v)
      let itemsPanel                               v = SetConstantValue<_> (Properties.ItemsControl.itemsPanel, v)
      let isGrouping                               v = SetConstantValue<_> (Properties.ItemsControl.isGrouping, v)
      let groupStyleSelector                       v = SetConstantValue<_> (Properties.ItemsControl.groupStyleSelector, v)
      let alternationCount                         v = SetConstantValue<_> (Properties.ItemsControl.alternationCount, v)
      let alternationIndex                         v = SetConstantValue<_> (Properties.ItemsControl.alternationIndex, v)
      let isTextSearchEnabled                      v = SetConstantValue<_> (Properties.ItemsControl.isTextSearchEnabled, v)
      let isTextSearchCaseSensitive                v = SetConstantValue<_> (Properties.ItemsControl.isTextSearchCaseSensitive, v)

    let itemsPresenter                           values =
      StandardView<ItemsPresenter> (values) :> View
    module ItemsPresenter = 
      let dummy = ()

    let label                                    values child =
      StandardContentView<Label> (values, child) :> View
    module Label = 
      let dummy = ()
      let target                                   v = SetConstantValue<_> (Properties.Label.target, v)

    let line                                     values =
      StandardView<Line> (values) :> View
    module Line = 
      let dummy = ()
      let x1                                       v = SetConstantValue<_> (Properties.Line.x1, v)
      let y1                                       v = SetConstantValue<_> (Properties.Line.y1, v)
      let x2                                       v = SetConstantValue<_> (Properties.Line.x2, v)
      let y2                                       v = SetConstantValue<_> (Properties.Line.y2, v)

    let listBox                                  values =
      StandardView<ListBox> (values) :> View
    module ListBox = 
      let dummy = ()
      let selectionMode                            v = SetConstantValue<_> (Properties.ListBox.selectionMode, v)
      let selectedItems                            v = SetConstantValue<_> (Properties.ListBox.selectedItems, v)

    let listBoxItem                              values child =
      StandardContentView<ListBoxItem> (values, child) :> View
    module ListBoxItem = 
      let dummy = ()
      let isSelected                               v = SetConstantValue<_> (Properties.ListBoxItem.isSelected, v)
      let onSelected                               (f : System.Windows.Controls.ListBoxItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ListBoxItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onUnselected                             (f : System.Windows.Controls.ListBoxItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ListBoxItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let listView                                 values =
      StandardView<ListView> (values) :> View
    module ListView = 
      let dummy = ()
      let view                                     v = SetConstantValue<_> (Properties.ListView.view, v)

    let listViewItem                             values child =
      StandardContentView<ListViewItem> (values, child) :> View
    module ListViewItem = 
      let dummy = ()

    let mediaElement                             values =
      StandardView<MediaElement> (values) :> View
    module MediaElement = 
      let dummy = ()
      let source                                   v = SetConstantValue<_> (Properties.MediaElement.source, v)
      let volume                                   v = SetConstantValue<_> (Properties.MediaElement.volume, v)
      let balance                                  v = SetConstantValue<_> (Properties.MediaElement.balance, v)
      let isMuted                                  v = SetConstantValue<_> (Properties.MediaElement.isMuted, v)
      let scrubbingEnabled                         v = SetConstantValue<_> (Properties.MediaElement.scrubbingEnabled, v)
      let unloadedBehavior                         v = SetConstantValue<_> (Properties.MediaElement.unloadedBehavior, v)
      let loadedBehavior                           v = SetConstantValue<_> (Properties.MediaElement.loadedBehavior, v)
      let stretch                                  v = SetConstantValue<_> (Properties.MediaElement.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.MediaElement.stretchDirection, v)
      let onMediaFailed                            (f : System.Windows.Controls.MediaElement -> System.Windows.ExceptionRoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.MediaFailed.AddHandler    (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
        let u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.MediaFailed.RemoveHandler (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> (r, u, f)
      let onMediaOpened                            (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaOpened.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaOpened.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onBufferingStarted                       (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingStarted.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingStarted.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onBufferingEnded                         (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingEnded.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingEnded.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onScriptCommand                          (f : System.Windows.Controls.MediaElement -> System.Windows.MediaScriptCommandRoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.MediaScriptCommandRoutedEventArgs -> unit) = o.ScriptCommand.AddHandler    (System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs> h)
        let u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.MediaScriptCommandRoutedEventArgs -> unit) = o.ScriptCommand.RemoveHandler (System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>, System.Windows.MediaScriptCommandRoutedEventArgs> (r, u, f)
      let onMediaEnded                             (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaEnded.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaEnded.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let menu                                     values =
      StandardView<Menu> (values) :> View
    module Menu = 
      let dummy = ()
      let isMainMenu                               v = SetConstantValue<_> (Properties.Menu.isMainMenu, v)

    module MenuBase = 
      let dummy = ()
      let itemContainerTemplateSelector            v = SetConstantValue<_> (Properties.MenuBase.itemContainerTemplateSelector, v)
      let usesItemContainerTemplate                v = SetConstantValue<_> (Properties.MenuBase.usesItemContainerTemplate, v)

    let menuItem                                 values =
      StandardView<MenuItem> (values) :> View
    module MenuItem = 
      let dummy = ()
      let command                                  v = SetConstantValue<_> (Properties.MenuItem.command, v)
      let commandParameter                         v = SetConstantValue<_> (Properties.MenuItem.commandParameter, v)
      let commandTarget                            v = SetConstantValue<_> (Properties.MenuItem.commandTarget, v)
      let isSubmenuOpen                            v = SetConstantValue<_> (Properties.MenuItem.isSubmenuOpen, v)
      let role                                     v = SetConstantValue<_> (Properties.MenuItem.role, v)
      let isCheckable                              v = SetConstantValue<_> (Properties.MenuItem.isCheckable, v)
      let isPressed                                v = SetConstantValue<_> (Properties.MenuItem.isPressed, v)
      let isHighlighted                            v = SetConstantValue<_> (Properties.MenuItem.isHighlighted, v)
      let isChecked                                v = SetConstantValue<_> (Properties.MenuItem.isChecked, v)
      let staysOpenOnClick                         v = SetConstantValue<_> (Properties.MenuItem.staysOpenOnClick, v)
      let inputGestureText                         v = SetConstantValue<_> (Properties.MenuItem.inputGestureText, v)
      let icon                                     v = SetConstantValue<_> (Properties.MenuItem.icon, v)
      let isSuspendingPopupAnimation               v = SetConstantValue<_> (Properties.MenuItem.isSuspendingPopupAnimation, v)
      let itemContainerTemplateSelector            v = SetConstantValue<_> (Properties.MenuItem.itemContainerTemplateSelector, v)
      let usesItemContainerTemplate                v = SetConstantValue<_> (Properties.MenuItem.usesItemContainerTemplate, v)
      let onClick                                  (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onChecked                                (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onUnchecked                              (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onSubmenuOpened                          (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuOpened.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuOpened.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onSubmenuClosed                          (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuClosed.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuClosed.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    module MultiSelector = 
      let dummy = ()

    let navigationWindow                         values child =
      StandardContentView<NavigationWindow> (values, child) :> View
    module NavigationWindow = 
      let dummy = ()
      let sandboxExternalContent                   v = SetConstantValue<_> (Properties.NavigationWindow.sandboxExternalContent, v)
      let showsNavigationUI                        v = SetConstantValue<_> (Properties.NavigationWindow.showsNavigationUI, v)
      let backStack                                v = SetConstantValue<_> (Properties.NavigationWindow.backStack, v)
      let forwardStack                             v = SetConstantValue<_> (Properties.NavigationWindow.forwardStack, v)
      let canGoBack                                v = SetConstantValue<_> (Properties.NavigationWindow.canGoBack, v)
      let canGoForward                             v = SetConstantValue<_> (Properties.NavigationWindow.canGoForward, v)
      let source                                   v = SetConstantValue<_> (Properties.NavigationWindow.source, v)
      let onNavigating                             (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigatingCancelEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.AddHandler    (System.Windows.Navigation.NavigatingCancelEventHandler h)
        let u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.RemoveHandler (System.Windows.Navigation.NavigatingCancelEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs> (r, u, f)
      let onNavigationProgress                     (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationProgressEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.AddHandler    (System.Windows.Navigation.NavigationProgressEventHandler h)
        let u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.RemoveHandler (System.Windows.Navigation.NavigationProgressEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs> (r, u, f)
      let onNavigationFailed                       (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationFailedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.AddHandler    (System.Windows.Navigation.NavigationFailedEventHandler h)
        let u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.RemoveHandler (System.Windows.Navigation.NavigationFailedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs> (r, u, f)
      let onNavigated                              (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.AddHandler    (System.Windows.Navigation.NavigatedEventHandler h)
        let u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.RemoveHandler (System.Windows.Navigation.NavigatedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)
      let onLoadCompleted                          (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.AddHandler    (System.Windows.Navigation.LoadCompletedEventHandler h)
        let u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.RemoveHandler (System.Windows.Navigation.LoadCompletedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)
      let onNavigationStopped                      (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.AddHandler    (System.Windows.Navigation.NavigationStoppedEventHandler h)
        let u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.RemoveHandler (System.Windows.Navigation.NavigationStoppedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)
      let onFragmentNavigation                     (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.FragmentNavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.AddHandler    (System.Windows.Navigation.FragmentNavigationEventHandler h)
        let u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.RemoveHandler (System.Windows.Navigation.FragmentNavigationEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs> (r, u, f)

    let page                                     values =
      StandardView<Page> (values) :> View
    module Page = 
      let dummy = ()
      let content                                  v = SetConstantValue<_> (Properties.Page.content, v)
      let background                               v = SetConstantValue<_> (Properties.Page.background, v)
      let title                                    v = SetConstantValue<_> (Properties.Page.title, v)
      let keepAlive                                v = SetConstantValue<_> (Properties.Page.keepAlive, v)
      let foreground                               v = SetConstantValue<_> (Properties.Page.foreground, v)
      let fontFamily                               v = SetConstantValue<_> (Properties.Page.fontFamily, v)
      let fontSize                                 v = SetConstantValue<_> (Properties.Page.fontSize, v)
      let template                                 v = SetConstantValue<_> (Properties.Page.template, v)

    let pageContent                              values =
      StandardView<PageContent> (values) :> View
    module PageContent = 
      let dummy = ()
      let source                                   v = SetConstantValue<_> (Properties.PageContent.source, v)
      let onGetPageRootCompleted                   (f : System.Windows.Documents.PageContent -> System.Windows.Documents.GetPageRootCompletedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Documents.PageContent) (h : obj -> System.Windows.Documents.GetPageRootCompletedEventArgs -> unit) = o.GetPageRootCompleted.AddHandler    (System.Windows.Documents.GetPageRootCompletedEventHandler h)
        let u (o : System.Windows.Documents.PageContent) (h : obj -> System.Windows.Documents.GetPageRootCompletedEventArgs -> unit) = o.GetPageRootCompleted.RemoveHandler (System.Windows.Documents.GetPageRootCompletedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Documents.PageContent, System.Windows.Documents.GetPageRootCompletedEventHandler, System.Windows.Documents.GetPageRootCompletedEventArgs> (r, u, f)

    module PageFunctionBase = 
      let dummy = ()

    module Panel = 
      let dummy = ()
      let background                               v = SetConstantValue<_> (Properties.Panel.background, v)
      let isItemsHost                              v = SetConstantValue<_> (Properties.Panel.isItemsHost, v)
      let zIndex                                   v = SetConstantValue<_> (Properties.Panel.zIndex, v)

    let passwordBox                              values =
      StandardView<PasswordBox> (values) :> View
    module PasswordBox = 
      let dummy = ()
      let passwordChar                             v = SetConstantValue<_> (Properties.PasswordBox.passwordChar, v)
      let maxLength                                v = SetConstantValue<_> (Properties.PasswordBox.maxLength, v)
      let selectionBrush                           v = SetConstantValue<_> (Properties.PasswordBox.selectionBrush, v)
      let selectionOpacity                         v = SetConstantValue<_> (Properties.PasswordBox.selectionOpacity, v)
      let caretBrush                               v = SetConstantValue<_> (Properties.PasswordBox.caretBrush, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.PasswordBox.isSelectionActive, v)
      let isInactiveSelectionHighlightEnabled      v = SetConstantValue<_> (Properties.PasswordBox.isInactiveSelectionHighlightEnabled, v)
      let onPasswordChanged                        (f : System.Windows.Controls.PasswordBox -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.PasswordBox) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.PasswordChanged.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.PasswordBox) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.PasswordChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.PasswordBox, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let path                                     values =
      StandardView<Path> (values) :> View
    module Path = 
      let dummy = ()
      let data                                     v = SetConstantValue<_> (Properties.Path.data, v)

    let polygon                                  values =
      StandardView<Polygon> (values) :> View
    module Polygon = 
      let dummy = ()
      let points                                   v = SetConstantValue<_> (Properties.Polygon.points, v)
      let fillRule                                 v = SetConstantValue<_> (Properties.Polygon.fillRule, v)

    let polyline                                 values =
      StandardView<Polyline> (values) :> View
    module Polyline = 
      let dummy = ()
      let points                                   v = SetConstantValue<_> (Properties.Polyline.points, v)
      let fillRule                                 v = SetConstantValue<_> (Properties.Polyline.fillRule, v)

    let popup                                    values =
      StandardView<Popup> (values) :> View
    module Popup = 
      let dummy = ()
      let child                                    v = SetConstantValue<_> (Properties.Popup.child, v)
      let isOpen                                   v = SetConstantValue<_> (Properties.Popup.isOpen, v)
      let placement                                v = SetConstantValue<_> (Properties.Popup.placement, v)
      let customPopupPlacementCallback             v = SetConstantValue<_> (Properties.Popup.customPopupPlacementCallback, v)
      let staysOpen                                v = SetConstantValue<_> (Properties.Popup.staysOpen, v)
      let horizontalOffset                         v = SetConstantValue<_> (Properties.Popup.horizontalOffset, v)
      let verticalOffset                           v = SetConstantValue<_> (Properties.Popup.verticalOffset, v)
      let placementTarget                          v = SetConstantValue<_> (Properties.Popup.placementTarget, v)
      let placementRectangle                       v = SetConstantValue<_> (Properties.Popup.placementRectangle, v)
      let popupAnimation                           v = SetConstantValue<_> (Properties.Popup.popupAnimation, v)
      let allowsTransparency                       v = SetConstantValue<_> (Properties.Popup.allowsTransparency, v)
      let hasDropShadow                            v = SetConstantValue<_> (Properties.Popup.hasDropShadow, v)
      let onOpened                                 (f : System.Windows.Controls.Primitives.Popup -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Opened.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Opened.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Popup, System.EventHandler, System.EventArgs> (r, u, f)
      let onClosed                                 (f : System.Windows.Controls.Primitives.Popup -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Closed.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Closed.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Popup, System.EventHandler, System.EventArgs> (r, u, f)

    let progressBar                              values =
      StandardView<ProgressBar> (values) :> View
    module ProgressBar = 
      let dummy = ()
      let isIndeterminate                          v = SetConstantValue<_> (Properties.ProgressBar.isIndeterminate, v)
      let orientation                              v = SetConstantValue<_> (Properties.ProgressBar.orientation, v)

    let radioButton                              values child =
      StandardContentView<RadioButton> (values, child) :> View
    module RadioButton = 
      let dummy = ()
      let groupName                                v = SetConstantValue<_> (Properties.RadioButton.groupName, v)

    module RangeBase = 
      let dummy = ()
      let minimum                                  v = SetConstantValue<_> (Properties.RangeBase.minimum, v)
      let maximum                                  v = SetConstantValue<_> (Properties.RangeBase.maximum, v)
      let value                                    v = SetConstantValue<_> (Properties.RangeBase.value, v)
      let largeChange                              v = SetConstantValue<_> (Properties.RangeBase.largeChange, v)
      let smallChange                              v = SetConstantValue<_> (Properties.RangeBase.smallChange, v)
      let onValueChanged                           (f : System.Windows.Controls.Primitives.RangeBase -> System.Windows.RoutedPropertyChangedEventArgs<System.Double>-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.RangeBase) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Double> -> unit) = o.ValueChanged.AddHandler    (System.Windows.RoutedPropertyChangedEventHandler<System.Double> h)
        let u (o : System.Windows.Controls.Primitives.RangeBase) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Double> -> unit) = o.ValueChanged.RemoveHandler (System.Windows.RoutedPropertyChangedEventHandler<System.Double> h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.RangeBase, System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>> (r, u, f)

    let rectangle                                values =
      StandardView<Rectangle> (values) :> View
    module Rectangle = 
      let dummy = ()
      let radiusX                                  v = SetConstantValue<_> (Properties.Rectangle.radiusX, v)
      let radiusY                                  v = SetConstantValue<_> (Properties.Rectangle.radiusY, v)

    let repeatButton                             values child =
      StandardContentView<RepeatButton> (values, child) :> View
    module RepeatButton = 
      let dummy = ()
      let delay                                    v = SetConstantValue<_> (Properties.RepeatButton.delay, v)
      let interval                                 v = SetConstantValue<_> (Properties.RepeatButton.interval, v)

    let resizeGrip                               values =
      StandardView<ResizeGrip> (values) :> View
    module ResizeGrip = 
      let dummy = ()

    let richTextBox                              values =
      StandardView<RichTextBox> (values) :> View
    module RichTextBox = 
      let dummy = ()
      let isDocumentEnabled                        v = SetConstantValue<_> (Properties.RichTextBox.isDocumentEnabled, v)

    let scrollBar                                values =
      StandardView<ScrollBar> (values) :> View
    module ScrollBar = 
      let dummy = ()
      let orientation                              v = SetConstantValue<_> (Properties.ScrollBar.orientation, v)
      let viewportSize                             v = SetConstantValue<_> (Properties.ScrollBar.viewportSize, v)
      let onScroll                                 (f : System.Windows.Controls.Primitives.ScrollBar -> System.Windows.Controls.Primitives.ScrollEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.ScrollBar) (h : obj -> System.Windows.Controls.Primitives.ScrollEventArgs -> unit) = o.Scroll.AddHandler    (System.Windows.Controls.Primitives.ScrollEventHandler h)
        let u (o : System.Windows.Controls.Primitives.ScrollBar) (h : obj -> System.Windows.Controls.Primitives.ScrollEventArgs -> unit) = o.Scroll.RemoveHandler (System.Windows.Controls.Primitives.ScrollEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ScrollBar, System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs> (r, u, f)

    let scrollContentPresenter                   values =
      StandardView<ScrollContentPresenter> (values) :> View
    module ScrollContentPresenter = 
      let dummy = ()
      let canContentScroll                         v = SetConstantValue<_> (Properties.ScrollContentPresenter.canContentScroll, v)

    let scrollViewer                             values child =
      StandardContentView<ScrollViewer> (values, child) :> View
    module ScrollViewer = 
      let dummy = ()
      let canContentScroll                         v = SetConstantValue<_> (Properties.ScrollViewer.canContentScroll, v)
      let horizontalScrollBarVisibility            v = SetConstantValue<_> (Properties.ScrollViewer.horizontalScrollBarVisibility, v)
      let verticalScrollBarVisibility              v = SetConstantValue<_> (Properties.ScrollViewer.verticalScrollBarVisibility, v)
      let computedHorizontalScrollBarVisibility    v = SetConstantValue<_> (Properties.ScrollViewer.computedHorizontalScrollBarVisibility, v)
      let computedVerticalScrollBarVisibility      v = SetConstantValue<_> (Properties.ScrollViewer.computedVerticalScrollBarVisibility, v)
      let verticalOffset                           v = SetConstantValue<_> (Properties.ScrollViewer.verticalOffset, v)
      let horizontalOffset                         v = SetConstantValue<_> (Properties.ScrollViewer.horizontalOffset, v)
      let contentVerticalOffset                    v = SetConstantValue<_> (Properties.ScrollViewer.contentVerticalOffset, v)
      let contentHorizontalOffset                  v = SetConstantValue<_> (Properties.ScrollViewer.contentHorizontalOffset, v)
      let extentWidth                              v = SetConstantValue<_> (Properties.ScrollViewer.extentWidth, v)
      let extentHeight                             v = SetConstantValue<_> (Properties.ScrollViewer.extentHeight, v)
      let scrollableWidth                          v = SetConstantValue<_> (Properties.ScrollViewer.scrollableWidth, v)
      let scrollableHeight                         v = SetConstantValue<_> (Properties.ScrollViewer.scrollableHeight, v)
      let viewportWidth                            v = SetConstantValue<_> (Properties.ScrollViewer.viewportWidth, v)
      let viewportHeight                           v = SetConstantValue<_> (Properties.ScrollViewer.viewportHeight, v)
      let isDeferredScrollingEnabled               v = SetConstantValue<_> (Properties.ScrollViewer.isDeferredScrollingEnabled, v)
      let panningMode                              v = SetConstantValue<_> (Properties.ScrollViewer.panningMode, v)
      let panningDeceleration                      v = SetConstantValue<_> (Properties.ScrollViewer.panningDeceleration, v)
      let panningRatio                             v = SetConstantValue<_> (Properties.ScrollViewer.panningRatio, v)
      let onScrollChanged                          (f : System.Windows.Controls.ScrollViewer -> System.Windows.Controls.ScrollChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ScrollViewer) (h : obj -> System.Windows.Controls.ScrollChangedEventArgs -> unit) = o.ScrollChanged.AddHandler    (System.Windows.Controls.ScrollChangedEventHandler h)
        let u (o : System.Windows.Controls.ScrollViewer) (h : obj -> System.Windows.Controls.ScrollChangedEventArgs -> unit) = o.ScrollChanged.RemoveHandler (System.Windows.Controls.ScrollChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ScrollViewer, System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs> (r, u, f)

    let selectiveScrollingGrid                   values children =
      StandardPanelView<SelectiveScrollingGrid> (values, children) :> View
    module SelectiveScrollingGrid = 
      let dummy = ()
      let selectiveScrollingOrientation            v = SetConstantValue<_> (Properties.SelectiveScrollingGrid.selectiveScrollingOrientation, v)

    module Selector = 
      let dummy = ()
      let isSelectionActive                        v = SetConstantValue<_> (Properties.Selector.isSelectionActive, v)
      let isSelected                               v = SetConstantValue<_> (Properties.Selector.isSelected, v)
      let isSynchronizedWithCurrentItem            v = SetConstantValue<_> (Properties.Selector.isSynchronizedWithCurrentItem, v)
      let selectedIndex                            v = SetConstantValue<_> (Properties.Selector.selectedIndex, v)
      let selectedItem                             v = SetConstantValue<_> (Properties.Selector.selectedItem, v)
      let selectedValue                            v = SetConstantValue<_> (Properties.Selector.selectedValue, v)
      let selectedValuePath                        v = SetConstantValue<_> (Properties.Selector.selectedValuePath, v)
      let onSelectionChanged                       (f : System.Windows.Controls.Primitives.Selector -> System.Windows.Controls.SelectionChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.Selector) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectionChanged.AddHandler    (System.Windows.Controls.SelectionChangedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.Selector) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectionChanged.RemoveHandler (System.Windows.Controls.SelectionChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Selector, System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs> (r, u, f)

    let separator                                values =
      StandardView<Separator> (values) :> View
    module Separator = 
      let dummy = ()

    module Shape = 
      let dummy = ()
      let stretch                                  v = SetConstantValue<_> (Properties.Shape.stretch, v)
      let fill                                     v = SetConstantValue<_> (Properties.Shape.fill, v)
      let stroke                                   v = SetConstantValue<_> (Properties.Shape.stroke, v)
      let strokeThickness                          v = SetConstantValue<_> (Properties.Shape.strokeThickness, v)
      let strokeStartLineCap                       v = SetConstantValue<_> (Properties.Shape.strokeStartLineCap, v)
      let strokeEndLineCap                         v = SetConstantValue<_> (Properties.Shape.strokeEndLineCap, v)
      let strokeDashCap                            v = SetConstantValue<_> (Properties.Shape.strokeDashCap, v)
      let strokeLineJoin                           v = SetConstantValue<_> (Properties.Shape.strokeLineJoin, v)
      let strokeMiterLimit                         v = SetConstantValue<_> (Properties.Shape.strokeMiterLimit, v)
      let strokeDashOffset                         v = SetConstantValue<_> (Properties.Shape.strokeDashOffset, v)
      let strokeDashArray                          v = SetConstantValue<_> (Properties.Shape.strokeDashArray, v)

    let slider                                   values =
      StandardView<Slider> (values) :> View
    module Slider = 
      let dummy = ()
      let orientation                              v = SetConstantValue<_> (Properties.Slider.orientation, v)
      let isDirectionReversed                      v = SetConstantValue<_> (Properties.Slider.isDirectionReversed, v)
      let delay                                    v = SetConstantValue<_> (Properties.Slider.delay, v)
      let interval                                 v = SetConstantValue<_> (Properties.Slider.interval, v)
      let autoToolTipPlacement                     v = SetConstantValue<_> (Properties.Slider.autoToolTipPlacement, v)
      let autoToolTipPrecision                     v = SetConstantValue<_> (Properties.Slider.autoToolTipPrecision, v)
      let isSnapToTickEnabled                      v = SetConstantValue<_> (Properties.Slider.isSnapToTickEnabled, v)
      let tickPlacement                            v = SetConstantValue<_> (Properties.Slider.tickPlacement, v)
      let tickFrequency                            v = SetConstantValue<_> (Properties.Slider.tickFrequency, v)
      let ticks                                    v = SetConstantValue<_> (Properties.Slider.ticks, v)
      let isSelectionRangeEnabled                  v = SetConstantValue<_> (Properties.Slider.isSelectionRangeEnabled, v)
      let selectionStart                           v = SetConstantValue<_> (Properties.Slider.selectionStart, v)
      let selectionEnd                             v = SetConstantValue<_> (Properties.Slider.selectionEnd, v)
      let isMoveToPointEnabled                     v = SetConstantValue<_> (Properties.Slider.isMoveToPointEnabled, v)

    let stackPanel                               values children =
      StandardPanelView<StackPanel> (values, children) :> View
    module StackPanel = 
      let dummy = ()
      let orientation                              v = SetConstantValue<_> (Properties.StackPanel.orientation, v)

    let statusBar                                values =
      StandardView<StatusBar> (values) :> View
    module StatusBar = 
      let dummy = ()
      let itemContainerTemplateSelector            v = SetConstantValue<_> (Properties.StatusBar.itemContainerTemplateSelector, v)
      let usesItemContainerTemplate                v = SetConstantValue<_> (Properties.StatusBar.usesItemContainerTemplate, v)

    let statusBarItem                            values child =
      StandardContentView<StatusBarItem> (values, child) :> View
    module StatusBarItem = 
      let dummy = ()

    module StickyNoteControl = 
      let dummy = ()
      let author                                   v = SetConstantValue<_> (Properties.StickyNoteControl.author, v)
      let isExpanded                               v = SetConstantValue<_> (Properties.StickyNoteControl.isExpanded, v)
      let isActive                                 v = SetConstantValue<_> (Properties.StickyNoteControl.isActive, v)
      let isMouseOverAnchor                        v = SetConstantValue<_> (Properties.StickyNoteControl.isMouseOverAnchor, v)
      let captionFontFamily                        v = SetConstantValue<_> (Properties.StickyNoteControl.captionFontFamily, v)
      let captionFontSize                          v = SetConstantValue<_> (Properties.StickyNoteControl.captionFontSize, v)
      let captionFontStretch                       v = SetConstantValue<_> (Properties.StickyNoteControl.captionFontStretch, v)
      let captionFontStyle                         v = SetConstantValue<_> (Properties.StickyNoteControl.captionFontStyle, v)
      let captionFontWeight                        v = SetConstantValue<_> (Properties.StickyNoteControl.captionFontWeight, v)
      let penWidth                                 v = SetConstantValue<_> (Properties.StickyNoteControl.penWidth, v)
      let stickyNoteType                           v = SetConstantValue<_> (Properties.StickyNoteControl.stickyNoteType, v)

    let tabControl                               values =
      StandardView<TabControl> (values) :> View
    module TabControl = 
      let dummy = ()
      let tabStripPlacement                        v = SetConstantValue<_> (Properties.TabControl.tabStripPlacement, v)
      let selectedContent                          v = SetConstantValue<_> (Properties.TabControl.selectedContent, v)
      let selectedContentTemplate                  v = SetConstantValue<_> (Properties.TabControl.selectedContentTemplate, v)
      let selectedContentTemplateSelector          v = SetConstantValue<_> (Properties.TabControl.selectedContentTemplateSelector, v)
      let selectedContentStringFormat              v = SetConstantValue<_> (Properties.TabControl.selectedContentStringFormat, v)
      let contentTemplate                          v = SetConstantValue<_> (Properties.TabControl.contentTemplate, v)
      let contentTemplateSelector                  v = SetConstantValue<_> (Properties.TabControl.contentTemplateSelector, v)
      let contentStringFormat                      v = SetConstantValue<_> (Properties.TabControl.contentStringFormat, v)

    let tabItem                                  values child =
      StandardContentView<TabItem> (values, child) :> View
    module TabItem = 
      let dummy = ()
      let isSelected                               v = SetConstantValue<_> (Properties.TabItem.isSelected, v)
      let tabStripPlacement                        v = SetConstantValue<_> (Properties.TabItem.tabStripPlacement, v)

    let tabPanel                                 values children =
      StandardPanelView<TabPanel> (values, children) :> View
    module TabPanel = 
      let dummy = ()

    let textBlock                                values =
      StandardView<TextBlock> (values) :> View
    module TextBlock = 
      let dummy = ()
      let baselineOffset                           v = SetConstantValue<_> (Properties.TextBlock.baselineOffset, v)
      let text                                     v = SetConstantValue<_> (Properties.TextBlock.text, v)
      let fontFamily                               v = SetConstantValue<_> (Properties.TextBlock.fontFamily, v)
      let fontStyle                                v = SetConstantValue<_> (Properties.TextBlock.fontStyle, v)
      let fontWeight                               v = SetConstantValue<_> (Properties.TextBlock.fontWeight, v)
      let fontStretch                              v = SetConstantValue<_> (Properties.TextBlock.fontStretch, v)
      let fontSize                                 v = SetConstantValue<_> (Properties.TextBlock.fontSize, v)
      let foreground                               v = SetConstantValue<_> (Properties.TextBlock.foreground, v)
      let background                               v = SetConstantValue<_> (Properties.TextBlock.background, v)
      let textDecorations                          v = SetConstantValue<_> (Properties.TextBlock.textDecorations, v)
      let textEffects                              v = SetConstantValue<_> (Properties.TextBlock.textEffects, v)
      let lineHeight                               v = SetConstantValue<_> (Properties.TextBlock.lineHeight, v)
      let lineStackingStrategy                     v = SetConstantValue<_> (Properties.TextBlock.lineStackingStrategy, v)
      let padding                                  v = SetConstantValue<_> (Properties.TextBlock.padding, v)
      let textAlignment                            v = SetConstantValue<_> (Properties.TextBlock.textAlignment, v)
      let textTrimming                             v = SetConstantValue<_> (Properties.TextBlock.textTrimming, v)
      let textWrapping                             v = SetConstantValue<_> (Properties.TextBlock.textWrapping, v)
      let isHyphenationEnabled                     v = SetConstantValue<_> (Properties.TextBlock.isHyphenationEnabled, v)

    let textBox                                  values =
      StandardView<TextBox> (values) :> View
    module TextBox = 
      let dummy = ()
      let textWrapping                             v = SetConstantValue<_> (Properties.TextBox.textWrapping, v)
      let minLines                                 v = SetConstantValue<_> (Properties.TextBox.minLines, v)
      let maxLines                                 v = SetConstantValue<_> (Properties.TextBox.maxLines, v)
      let text                                     v = SetConstantValue<_> (Properties.TextBox.text, v)
      let characterCasing                          v = SetConstantValue<_> (Properties.TextBox.characterCasing, v)
      let maxLength                                v = SetConstantValue<_> (Properties.TextBox.maxLength, v)
      let textAlignment                            v = SetConstantValue<_> (Properties.TextBox.textAlignment, v)
      let textDecorations                          v = SetConstantValue<_> (Properties.TextBox.textDecorations, v)

    module TextBoxBase = 
      let dummy = ()
      let isReadOnly                               v = SetConstantValue<_> (Properties.TextBoxBase.isReadOnly, v)
      let isReadOnlyCaretVisible                   v = SetConstantValue<_> (Properties.TextBoxBase.isReadOnlyCaretVisible, v)
      let acceptsReturn                            v = SetConstantValue<_> (Properties.TextBoxBase.acceptsReturn, v)
      let acceptsTab                               v = SetConstantValue<_> (Properties.TextBoxBase.acceptsTab, v)
      let horizontalScrollBarVisibility            v = SetConstantValue<_> (Properties.TextBoxBase.horizontalScrollBarVisibility, v)
      let verticalScrollBarVisibility              v = SetConstantValue<_> (Properties.TextBoxBase.verticalScrollBarVisibility, v)
      let isUndoEnabled                            v = SetConstantValue<_> (Properties.TextBoxBase.isUndoEnabled, v)
      let undoLimit                                v = SetConstantValue<_> (Properties.TextBoxBase.undoLimit, v)
      let autoWordSelection                        v = SetConstantValue<_> (Properties.TextBoxBase.autoWordSelection, v)
      let selectionBrush                           v = SetConstantValue<_> (Properties.TextBoxBase.selectionBrush, v)
      let selectionOpacity                         v = SetConstantValue<_> (Properties.TextBoxBase.selectionOpacity, v)
      let caretBrush                               v = SetConstantValue<_> (Properties.TextBoxBase.caretBrush, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.TextBoxBase.isSelectionActive, v)
      let isInactiveSelectionHighlightEnabled      v = SetConstantValue<_> (Properties.TextBoxBase.isInactiveSelectionHighlightEnabled, v)
      let onTextChanged                            (f : System.Windows.Controls.Primitives.TextBoxBase -> System.Windows.Controls.TextChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.Controls.TextChangedEventArgs -> unit) = o.TextChanged.AddHandler    (System.Windows.Controls.TextChangedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.Controls.TextChangedEventArgs -> unit) = o.TextChanged.RemoveHandler (System.Windows.Controls.TextChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs> (r, u, f)
      let onSelectionChanged                       (f : System.Windows.Controls.Primitives.TextBoxBase -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SelectionChanged.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SelectionChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let thumb                                    values =
      StandardView<Thumb> (values) :> View
    module Thumb = 
      let dummy = ()
      let isDragging                               v = SetConstantValue<_> (Properties.Thumb.isDragging, v)
      let onDragStarted                            (f : System.Windows.Controls.Primitives.Thumb -> System.Windows.Controls.Primitives.DragStartedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.DragStarted.AddHandler    (System.Windows.Controls.Primitives.DragStartedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.DragStarted.RemoveHandler (System.Windows.Controls.Primitives.DragStartedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Thumb, System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs> (r, u, f)
      let onDragDelta                              (f : System.Windows.Controls.Primitives.Thumb -> System.Windows.Controls.Primitives.DragDeltaEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.DragDelta.AddHandler    (System.Windows.Controls.Primitives.DragDeltaEventHandler h)
        let u (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.DragDelta.RemoveHandler (System.Windows.Controls.Primitives.DragDeltaEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Thumb, System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs> (r, u, f)
      let onDragCompleted                          (f : System.Windows.Controls.Primitives.Thumb -> System.Windows.Controls.Primitives.DragCompletedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.DragCompleted.AddHandler    (System.Windows.Controls.Primitives.DragCompletedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.DragCompleted.RemoveHandler (System.Windows.Controls.Primitives.DragCompletedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Thumb, System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs> (r, u, f)

    let tickBar                                  values =
      StandardView<TickBar> (values) :> View
    module TickBar = 
      let dummy = ()
      let fill                                     v = SetConstantValue<_> (Properties.TickBar.fill, v)
      let minimum                                  v = SetConstantValue<_> (Properties.TickBar.minimum, v)
      let maximum                                  v = SetConstantValue<_> (Properties.TickBar.maximum, v)
      let selectionStart                           v = SetConstantValue<_> (Properties.TickBar.selectionStart, v)
      let selectionEnd                             v = SetConstantValue<_> (Properties.TickBar.selectionEnd, v)
      let isSelectionRangeEnabled                  v = SetConstantValue<_> (Properties.TickBar.isSelectionRangeEnabled, v)
      let tickFrequency                            v = SetConstantValue<_> (Properties.TickBar.tickFrequency, v)
      let ticks                                    v = SetConstantValue<_> (Properties.TickBar.ticks, v)
      let isDirectionReversed                      v = SetConstantValue<_> (Properties.TickBar.isDirectionReversed, v)
      let placement                                v = SetConstantValue<_> (Properties.TickBar.placement, v)
      let reservedSpace                            v = SetConstantValue<_> (Properties.TickBar.reservedSpace, v)

    let toggleButton                             values child =
      StandardContentView<ToggleButton> (values, child) :> View
    module ToggleButton = 
      let dummy = ()
      let isChecked                                v = SetConstantValue<_> (Properties.ToggleButton.isChecked, v)
      let isThreeState                             v = SetConstantValue<_> (Properties.ToggleButton.isThreeState, v)
      let onChecked                                (f : System.Windows.Controls.Primitives.ToggleButton -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onUnchecked                              (f : System.Windows.Controls.Primitives.ToggleButton -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onIndeterminate                          (f : System.Windows.Controls.Primitives.ToggleButton -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Indeterminate.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Indeterminate.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let toolBar                                  values =
      StandardView<ToolBar> (values) :> View
    module ToolBar = 
      let dummy = ()
      let orientation                              v = SetConstantValue<_> (Properties.ToolBar.orientation, v)
      let band                                     v = SetConstantValue<_> (Properties.ToolBar.band, v)
      let bandIndex                                v = SetConstantValue<_> (Properties.ToolBar.bandIndex, v)
      let isOverflowOpen                           v = SetConstantValue<_> (Properties.ToolBar.isOverflowOpen, v)
      let hasOverflowItems                         v = SetConstantValue<_> (Properties.ToolBar.hasOverflowItems, v)
      let isOverflowItem                           v = SetConstantValue<_> (Properties.ToolBar.isOverflowItem, v)
      let overflowMode                             v = SetConstantValue<_> (Properties.ToolBar.overflowMode, v)

    let toolBarOverflowPanel                     values children =
      StandardPanelView<ToolBarOverflowPanel> (values, children) :> View
    module ToolBarOverflowPanel = 
      let dummy = ()
      let wrapWidth                                v = SetConstantValue<_> (Properties.ToolBarOverflowPanel.wrapWidth, v)

    let toolBarPanel                             values children =
      StandardPanelView<ToolBarPanel> (values, children) :> View
    module ToolBarPanel = 
      let dummy = ()

    let toolBarTray                              values =
      StandardView<ToolBarTray> (values) :> View
    module ToolBarTray = 
      let dummy = ()
      let background                               v = SetConstantValue<_> (Properties.ToolBarTray.background, v)
      let orientation                              v = SetConstantValue<_> (Properties.ToolBarTray.orientation, v)
      let isLocked                                 v = SetConstantValue<_> (Properties.ToolBarTray.isLocked, v)

    let toolTip                                  values child =
      StandardContentView<ToolTip> (values, child) :> View
    module ToolTip = 
      let dummy = ()
      let horizontalOffset                         v = SetConstantValue<_> (Properties.ToolTip.horizontalOffset, v)
      let verticalOffset                           v = SetConstantValue<_> (Properties.ToolTip.verticalOffset, v)
      let isOpen                                   v = SetConstantValue<_> (Properties.ToolTip.isOpen, v)
      let hasDropShadow                            v = SetConstantValue<_> (Properties.ToolTip.hasDropShadow, v)
      let placementTarget                          v = SetConstantValue<_> (Properties.ToolTip.placementTarget, v)
      let placementRectangle                       v = SetConstantValue<_> (Properties.ToolTip.placementRectangle, v)
      let placement                                v = SetConstantValue<_> (Properties.ToolTip.placement, v)
      let customPopupPlacementCallback             v = SetConstantValue<_> (Properties.ToolTip.customPopupPlacementCallback, v)
      let staysOpen                                v = SetConstantValue<_> (Properties.ToolTip.staysOpen, v)
      let onOpened                                 (f : System.Windows.Controls.ToolTip -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ToolTip, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onClosed                                 (f : System.Windows.Controls.ToolTip -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.ToolTip, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let track                                    values =
      StandardView<Track> (values) :> View
    module Track = 
      let dummy = ()
      let orientation                              v = SetConstantValue<_> (Properties.Track.orientation, v)
      let minimum                                  v = SetConstantValue<_> (Properties.Track.minimum, v)
      let maximum                                  v = SetConstantValue<_> (Properties.Track.maximum, v)
      let value                                    v = SetConstantValue<_> (Properties.Track.value, v)
      let viewportSize                             v = SetConstantValue<_> (Properties.Track.viewportSize, v)
      let isDirectionReversed                      v = SetConstantValue<_> (Properties.Track.isDirectionReversed, v)

    let treeView                                 values =
      StandardView<TreeView> (values) :> View
    module TreeView = 
      let dummy = ()
      let selectedItem                             v = SetConstantValue<_> (Properties.TreeView.selectedItem, v)
      let selectedValue                            v = SetConstantValue<_> (Properties.TreeView.selectedValue, v)
      let selectedValuePath                        v = SetConstantValue<_> (Properties.TreeView.selectedValuePath, v)
      let onSelectedItemChanged                    (f : System.Windows.Controls.TreeView -> System.Windows.RoutedPropertyChangedEventArgs<System.Object>-> 'TMessage) = 
        let r (o : System.Windows.Controls.TreeView) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Object> -> unit) = o.SelectedItemChanged.AddHandler    (System.Windows.RoutedPropertyChangedEventHandler<System.Object> h)
        let u (o : System.Windows.Controls.TreeView) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Object> -> unit) = o.SelectedItemChanged.RemoveHandler (System.Windows.RoutedPropertyChangedEventHandler<System.Object> h)
        OnChangedValue<'TMessage, System.Windows.Controls.TreeView, System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>> (r, u, f)

    let treeViewItem                             values =
      StandardView<TreeViewItem> (values) :> View
    module TreeViewItem = 
      let dummy = ()
      let isExpanded                               v = SetConstantValue<_> (Properties.TreeViewItem.isExpanded, v)
      let isSelected                               v = SetConstantValue<_> (Properties.TreeViewItem.isSelected, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.TreeViewItem.isSelectionActive, v)
      let onExpanded                               (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onCollapsed                              (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onSelected                               (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onUnselected                             (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)

    let uIElement                                values =
      StandardView<UIElement> (values) :> View
    module UIElement = 
      let dummy = ()
      let isMouseDirectlyOver                      v = SetConstantValue<_> (Properties.UIElement.isMouseDirectlyOver, v)
      let isMouseOver                              v = SetConstantValue<_> (Properties.UIElement.isMouseOver, v)
      let isStylusOver                             v = SetConstantValue<_> (Properties.UIElement.isStylusOver, v)
      let isKeyboardFocusWithin                    v = SetConstantValue<_> (Properties.UIElement.isKeyboardFocusWithin, v)
      let isMouseCaptured                          v = SetConstantValue<_> (Properties.UIElement.isMouseCaptured, v)
      let isMouseCaptureWithin                     v = SetConstantValue<_> (Properties.UIElement.isMouseCaptureWithin, v)
      let isStylusDirectlyOver                     v = SetConstantValue<_> (Properties.UIElement.isStylusDirectlyOver, v)
      let isStylusCaptured                         v = SetConstantValue<_> (Properties.UIElement.isStylusCaptured, v)
      let isStylusCaptureWithin                    v = SetConstantValue<_> (Properties.UIElement.isStylusCaptureWithin, v)
      let isKeyboardFocused                        v = SetConstantValue<_> (Properties.UIElement.isKeyboardFocused, v)
      let areAnyTouchesDirectlyOver                v = SetConstantValue<_> (Properties.UIElement.areAnyTouchesDirectlyOver, v)
      let areAnyTouchesOver                        v = SetConstantValue<_> (Properties.UIElement.areAnyTouchesOver, v)
      let areAnyTouchesCaptured                    v = SetConstantValue<_> (Properties.UIElement.areAnyTouchesCaptured, v)
      let areAnyTouchesCapturedWithin              v = SetConstantValue<_> (Properties.UIElement.areAnyTouchesCapturedWithin, v)
      let allowDrop                                v = SetConstantValue<_> (Properties.UIElement.allowDrop, v)
      let renderTransform                          v = SetConstantValue<_> (Properties.UIElement.renderTransform, v)
      let renderTransformOrigin                    v = SetConstantValue<_> (Properties.UIElement.renderTransformOrigin, v)
      let opacity                                  v = SetConstantValue<_> (Properties.UIElement.opacity, v)
      let opacityMask                              v = SetConstantValue<_> (Properties.UIElement.opacityMask, v)
      let bitmapEffect                             v = SetConstantValue<_> (Properties.UIElement.bitmapEffect, v)
      let effect                                   v = SetConstantValue<_> (Properties.UIElement.effect, v)
      let bitmapEffectInput                        v = SetConstantValue<_> (Properties.UIElement.bitmapEffectInput, v)
      let cacheMode                                v = SetConstantValue<_> (Properties.UIElement.cacheMode, v)
      let uid                                      v = SetConstantValue<_> (Properties.UIElement.uid, v)
      let visibility                               v = SetConstantValue<_> (Properties.UIElement.visibility, v)
      let clipToBounds                             v = SetConstantValue<_> (Properties.UIElement.clipToBounds, v)
      let clip                                     v = SetConstantValue<_> (Properties.UIElement.clip, v)
      let snapsToDevicePixels                      v = SetConstantValue<_> (Properties.UIElement.snapsToDevicePixels, v)
      let isFocused                                v = SetConstantValue<_> (Properties.UIElement.isFocused, v)
      let isEnabled                                v = SetConstantValue<_> (Properties.UIElement.isEnabled, v)
      let isHitTestVisible                         v = SetConstantValue<_> (Properties.UIElement.isHitTestVisible, v)
      let isVisible                                v = SetConstantValue<_> (Properties.UIElement.isVisible, v)
      let focusable                                v = SetConstantValue<_> (Properties.UIElement.focusable, v)
      let isManipulationEnabled                    v = SetConstantValue<_> (Properties.UIElement.isManipulationEnabled, v)
      let onPreviewMouseDown                       (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onMouseDown                              (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onPreviewMouseUp                         (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onMouseUp                                (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onPreviewMouseLeftButtonDown             (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onMouseLeftButtonDown                    (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onPreviewMouseLeftButtonUp               (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onMouseLeftButtonUp                      (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onPreviewMouseRightButtonDown            (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onMouseRightButtonDown                   (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onPreviewMouseRightButtonUp              (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onMouseRightButtonUp                     (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (r, u, f)
      let onPreviewMouseMove                       (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.PreviewMouseMove.AddHandler    (System.Windows.Input.MouseEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.PreviewMouseMove.RemoveHandler (System.Windows.Input.MouseEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (r, u, f)
      let onMouseMove                              (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseMove.AddHandler    (System.Windows.Input.MouseEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseMove.RemoveHandler (System.Windows.Input.MouseEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (r, u, f)
      let onPreviewMouseWheel                      (f : System.Windows.UIElement -> System.Windows.Input.MouseWheelEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.PreviewMouseWheel.AddHandler    (System.Windows.Input.MouseWheelEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.PreviewMouseWheel.RemoveHandler (System.Windows.Input.MouseWheelEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> (r, u, f)
      let onMouseWheel                             (f : System.Windows.UIElement -> System.Windows.Input.MouseWheelEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.MouseWheel.AddHandler    (System.Windows.Input.MouseWheelEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.MouseWheel.RemoveHandler (System.Windows.Input.MouseWheelEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> (r, u, f)
      let onMouseEnter                             (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseEnter.AddHandler    (System.Windows.Input.MouseEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseEnter.RemoveHandler (System.Windows.Input.MouseEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (r, u, f)
      let onMouseLeave                             (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseLeave.AddHandler    (System.Windows.Input.MouseEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseLeave.RemoveHandler (System.Windows.Input.MouseEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (r, u, f)
      let onGotMouseCapture                        (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.GotMouseCapture.AddHandler    (System.Windows.Input.MouseEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.GotMouseCapture.RemoveHandler (System.Windows.Input.MouseEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (r, u, f)
      let onLostMouseCapture                       (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.LostMouseCapture.AddHandler    (System.Windows.Input.MouseEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.LostMouseCapture.RemoveHandler (System.Windows.Input.MouseEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (r, u, f)
      let onQueryCursor                            (f : System.Windows.UIElement -> System.Windows.Input.QueryCursorEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.QueryCursorEventArgs -> unit) = o.QueryCursor.AddHandler    (System.Windows.Input.QueryCursorEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.QueryCursorEventArgs -> unit) = o.QueryCursor.RemoveHandler (System.Windows.Input.QueryCursorEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs> (r, u, f)
      let onPreviewStylusDown                      (f : System.Windows.UIElement -> System.Windows.Input.StylusDownEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.PreviewStylusDown.AddHandler    (System.Windows.Input.StylusDownEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.PreviewStylusDown.RemoveHandler (System.Windows.Input.StylusDownEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> (r, u, f)
      let onStylusDown                             (f : System.Windows.UIElement -> System.Windows.Input.StylusDownEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.StylusDown.AddHandler    (System.Windows.Input.StylusDownEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.StylusDown.RemoveHandler (System.Windows.Input.StylusDownEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> (r, u, f)
      let onPreviewStylusUp                        (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusUp.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusUp.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusUp                               (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusUp.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusUp.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onPreviewStylusMove                      (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusMove                             (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onPreviewStylusInAirMove                 (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInAirMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInAirMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusInAirMove                        (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInAirMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInAirMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusEnter                            (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusEnter.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusEnter.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusLeave                            (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusLeave.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusLeave.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onPreviewStylusInRange                   (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusInRange                          (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onPreviewStylusOutOfRange                (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusOutOfRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusOutOfRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusOutOfRange                       (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusOutOfRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusOutOfRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onPreviewStylusSystemGesture             (f : System.Windows.UIElement -> System.Windows.Input.StylusSystemGestureEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.PreviewStylusSystemGesture.AddHandler    (System.Windows.Input.StylusSystemGestureEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.PreviewStylusSystemGesture.RemoveHandler (System.Windows.Input.StylusSystemGestureEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> (r, u, f)
      let onStylusSystemGesture                    (f : System.Windows.UIElement -> System.Windows.Input.StylusSystemGestureEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.StylusSystemGesture.AddHandler    (System.Windows.Input.StylusSystemGestureEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.StylusSystemGesture.RemoveHandler (System.Windows.Input.StylusSystemGestureEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> (r, u, f)
      let onGotStylusCapture                       (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.GotStylusCapture.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.GotStylusCapture.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onLostStylusCapture                      (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.LostStylusCapture.AddHandler    (System.Windows.Input.StylusEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.LostStylusCapture.RemoveHandler (System.Windows.Input.StylusEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (r, u, f)
      let onStylusButtonDown                       (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonDown.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonDown.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (r, u, f)
      let onStylusButtonUp                         (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonUp.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonUp.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (r, u, f)
      let onPreviewStylusButtonDown                (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonDown.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonDown.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (r, u, f)
      let onPreviewStylusButtonUp                  (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonUp.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonUp.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (r, u, f)
      let onPreviewKeyDown                         (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyDown.AddHandler    (System.Windows.Input.KeyEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyDown.RemoveHandler (System.Windows.Input.KeyEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (r, u, f)
      let onKeyDown                                (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyDown.AddHandler    (System.Windows.Input.KeyEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyDown.RemoveHandler (System.Windows.Input.KeyEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (r, u, f)
      let onPreviewKeyUp                           (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyUp.AddHandler    (System.Windows.Input.KeyEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyUp.RemoveHandler (System.Windows.Input.KeyEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (r, u, f)
      let onKeyUp                                  (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyUp.AddHandler    (System.Windows.Input.KeyEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyUp.RemoveHandler (System.Windows.Input.KeyEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (r, u, f)
      let onPreviewGotKeyboardFocus                (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewGotKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewGotKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (r, u, f)
      let onGotKeyboardFocus                       (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.GotKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.GotKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (r, u, f)
      let onPreviewLostKeyboardFocus               (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewLostKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewLostKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (r, u, f)
      let onLostKeyboardFocus                      (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.LostKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.LostKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (r, u, f)
      let onPreviewTextInput                       (f : System.Windows.UIElement -> System.Windows.Input.TextCompositionEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.PreviewTextInput.AddHandler    (System.Windows.Input.TextCompositionEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.PreviewTextInput.RemoveHandler (System.Windows.Input.TextCompositionEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> (r, u, f)
      let onTextInput                              (f : System.Windows.UIElement -> System.Windows.Input.TextCompositionEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.TextInput.AddHandler    (System.Windows.Input.TextCompositionEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.TextInput.RemoveHandler (System.Windows.Input.TextCompositionEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> (r, u, f)
      let onPreviewQueryContinueDrag               (f : System.Windows.UIElement -> System.Windows.QueryContinueDragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.PreviewQueryContinueDrag.AddHandler    (System.Windows.QueryContinueDragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.PreviewQueryContinueDrag.RemoveHandler (System.Windows.QueryContinueDragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> (r, u, f)
      let onQueryContinueDrag                      (f : System.Windows.UIElement -> System.Windows.QueryContinueDragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.QueryContinueDrag.AddHandler    (System.Windows.QueryContinueDragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.QueryContinueDrag.RemoveHandler (System.Windows.QueryContinueDragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> (r, u, f)
      let onPreviewGiveFeedback                    (f : System.Windows.UIElement -> System.Windows.GiveFeedbackEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.PreviewGiveFeedback.AddHandler    (System.Windows.GiveFeedbackEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.PreviewGiveFeedback.RemoveHandler (System.Windows.GiveFeedbackEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> (r, u, f)
      let onGiveFeedback                           (f : System.Windows.UIElement -> System.Windows.GiveFeedbackEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.GiveFeedback.AddHandler    (System.Windows.GiveFeedbackEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.GiveFeedback.RemoveHandler (System.Windows.GiveFeedbackEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> (r, u, f)
      let onPreviewDragEnter                       (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragEnter.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragEnter.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onDragEnter                              (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragEnter.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragEnter.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onPreviewDragOver                        (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragOver.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragOver.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onDragOver                               (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragOver.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragOver.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onPreviewDragLeave                       (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragLeave.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragLeave.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onDragLeave                              (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragLeave.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragLeave.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onPreviewDrop                            (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDrop.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDrop.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onDrop                                   (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.Drop.AddHandler    (System.Windows.DragEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.Drop.RemoveHandler (System.Windows.DragEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (r, u, f)
      let onPreviewTouchDown                       (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchDown.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchDown.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onTouchDown                              (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchDown.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchDown.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onPreviewTouchMove                       (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchMove.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchMove.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onTouchMove                              (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchMove.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchMove.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onPreviewTouchUp                         (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchUp.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchUp.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onTouchUp                                (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchUp.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchUp.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onGotTouchCapture                        (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.GotTouchCapture.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.GotTouchCapture.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onLostTouchCapture                       (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.LostTouchCapture.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.LostTouchCapture.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onTouchEnter                             (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchEnter.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchEnter.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onTouchLeave                             (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchLeave.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchLeave.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (r, u, f)
      let onIsMouseDirectlyOverChanged             (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseDirectlyOverChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseDirectlyOverChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsKeyboardFocusWithinChanged           (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusWithinChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusWithinChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsMouseCapturedChanged                 (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCapturedChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCapturedChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsMouseCaptureWithinChanged            (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCaptureWithinChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCaptureWithinChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsStylusDirectlyOverChanged            (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusDirectlyOverChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusDirectlyOverChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsStylusCapturedChanged                (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCapturedChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCapturedChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsStylusCaptureWithinChanged           (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCaptureWithinChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCaptureWithinChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsKeyboardFocusedChanged               (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusedChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusedChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onLayoutUpdated                          (f : System.Windows.UIElement -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.EventArgs -> unit) = o.LayoutUpdated.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.EventArgs -> unit) = o.LayoutUpdated.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler, System.EventArgs> (r, u, f)
      let onGotFocus                               (f : System.Windows.UIElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.GotFocus.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.GotFocus.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onLostFocus                              (f : System.Windows.UIElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.LostFocus.AddHandler    (System.Windows.RoutedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.LostFocus.RemoveHandler (System.Windows.RoutedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (r, u, f)
      let onIsEnabledChanged                       (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsEnabledChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsEnabledChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsHitTestVisibleChanged                (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsHitTestVisibleChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsHitTestVisibleChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onIsVisibleChanged                       (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsVisibleChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsVisibleChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onFocusableChanged                       (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.FocusableChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.FocusableChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (r, u, f)
      let onManipulationStarting                   (f : System.Windows.UIElement -> System.Windows.Input.ManipulationStartingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartingEventArgs -> unit) = o.ManipulationStarting.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartingEventArgs -> unit) = o.ManipulationStarting.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>, System.Windows.Input.ManipulationStartingEventArgs> (r, u, f)
      let onManipulationStarted                    (f : System.Windows.UIElement -> System.Windows.Input.ManipulationStartedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartedEventArgs -> unit) = o.ManipulationStarted.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartedEventArgs -> unit) = o.ManipulationStarted.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs> (r, u, f)
      let onManipulationDelta                      (f : System.Windows.UIElement -> System.Windows.Input.ManipulationDeltaEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationDeltaEventArgs -> unit) = o.ManipulationDelta.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationDeltaEventArgs -> unit) = o.ManipulationDelta.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs> (r, u, f)
      let onManipulationInertiaStarting            (f : System.Windows.UIElement -> System.Windows.Input.ManipulationInertiaStartingEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationInertiaStartingEventArgs -> unit) = o.ManipulationInertiaStarting.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationInertiaStartingEventArgs -> unit) = o.ManipulationInertiaStarting.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>, System.Windows.Input.ManipulationInertiaStartingEventArgs> (r, u, f)
      let onManipulationBoundaryFeedback           (f : System.Windows.UIElement -> System.Windows.Input.ManipulationBoundaryFeedbackEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationBoundaryFeedbackEventArgs -> unit) = o.ManipulationBoundaryFeedback.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationBoundaryFeedbackEventArgs -> unit) = o.ManipulationBoundaryFeedback.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> (r, u, f)
      let onManipulationCompleted                  (f : System.Windows.UIElement -> System.Windows.Input.ManipulationCompletedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationCompletedEventArgs -> unit) = o.ManipulationCompleted.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs> h)
        let u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationCompletedEventArgs -> unit) = o.ManipulationCompleted.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs> h)
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs> (r, u, f)

    let uniformGrid                              values children =
      StandardPanelView<UniformGrid> (values, children) :> View
    module UniformGrid = 
      let dummy = ()
      let firstColumn                              v = SetConstantValue<_> (Properties.UniformGrid.firstColumn, v)
      let columns                                  v = SetConstantValue<_> (Properties.UniformGrid.columns, v)
      let rows                                     v = SetConstantValue<_> (Properties.UniformGrid.rows, v)

    let userControl                              values child =
      StandardContentView<UserControl> (values, child) :> View
    module UserControl = 
      let dummy = ()

    let viewbox                                  values =
      StandardView<Viewbox> (values) :> View
    module Viewbox = 
      let dummy = ()
      let stretch                                  v = SetConstantValue<_> (Properties.Viewbox.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.Viewbox.stretchDirection, v)

    let viewport3D                               values =
      StandardView<Viewport3D> (values) :> View
    module Viewport3D = 
      let dummy = ()
      let camera                                   v = SetConstantValue<_> (Properties.Viewport3D.camera, v)
      let children                                 v = SetConstantValue<_> (Properties.Viewport3D.children, v)

    module VirtualizingPanel = 
      let dummy = ()
      let isVirtualizing                           v = SetConstantValue<_> (Properties.VirtualizingPanel.isVirtualizing, v)
      let virtualizationMode                       v = SetConstantValue<_> (Properties.VirtualizingPanel.virtualizationMode, v)
      let isVirtualizingWhenGrouping               v = SetConstantValue<_> (Properties.VirtualizingPanel.isVirtualizingWhenGrouping, v)
      let scrollUnit                               v = SetConstantValue<_> (Properties.VirtualizingPanel.scrollUnit, v)
      let cacheLength                              v = SetConstantValue<_> (Properties.VirtualizingPanel.cacheLength, v)
      let cacheLengthUnit                          v = SetConstantValue<_> (Properties.VirtualizingPanel.cacheLengthUnit, v)
      let isContainerVirtualizable                 v = SetConstantValue<_> (Properties.VirtualizingPanel.isContainerVirtualizable, v)

    let virtualizingStackPanel                   values children =
      StandardPanelView<VirtualizingStackPanel> (values, children) :> View
    module VirtualizingStackPanel = 
      let dummy = ()
      let isVirtualizing                           v = SetConstantValue<_> (Properties.VirtualizingStackPanel.isVirtualizing, v)
      let virtualizationMode                       v = SetConstantValue<_> (Properties.VirtualizingStackPanel.virtualizationMode, v)
      let orientation                              v = SetConstantValue<_> (Properties.VirtualizingStackPanel.orientation, v)

    let webBrowser                               values =
      StandardView<WebBrowser> (values) :> View
    module WebBrowser = 
      let dummy = ()
      let onNavigating                             (f : System.Windows.Controls.WebBrowser -> System.Windows.Navigation.NavigatingCancelEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.AddHandler    (System.Windows.Navigation.NavigatingCancelEventHandler h)
        let u (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.RemoveHandler (System.Windows.Navigation.NavigatingCancelEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.WebBrowser, System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs> (r, u, f)
      let onNavigated                              (f : System.Windows.Controls.WebBrowser -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.AddHandler    (System.Windows.Navigation.NavigatedEventHandler h)
        let u (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.RemoveHandler (System.Windows.Navigation.NavigatedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.WebBrowser, System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)
      let onLoadCompleted                          (f : System.Windows.Controls.WebBrowser -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.AddHandler    (System.Windows.Navigation.LoadCompletedEventHandler h)
        let u (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.RemoveHandler (System.Windows.Navigation.LoadCompletedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Controls.WebBrowser, System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs> (r, u, f)

    let window                                   values child =
      StandardContentView<Window> (values, child) :> View
    module Window = 
      let dummy = ()
      let taskbarItemInfo                          v = SetConstantValue<_> (Properties.Window.taskbarItemInfo, v)
      let allowsTransparency                       v = SetConstantValue<_> (Properties.Window.allowsTransparency, v)
      let title                                    v = SetConstantValue<_> (Properties.Window.title, v)
      let icon                                     v = SetConstantValue<_> (Properties.Window.icon, v)
      let sizeToContent                            v = SetConstantValue<_> (Properties.Window.sizeToContent, v)
      let top                                      v = SetConstantValue<_> (Properties.Window.top, v)
      let left                                     v = SetConstantValue<_> (Properties.Window.left, v)
      let showInTaskbar                            v = SetConstantValue<_> (Properties.Window.showInTaskbar, v)
      let isActive                                 v = SetConstantValue<_> (Properties.Window.isActive, v)
      let windowStyle                              v = SetConstantValue<_> (Properties.Window.windowStyle, v)
      let windowState                              v = SetConstantValue<_> (Properties.Window.windowState, v)
      let resizeMode                               v = SetConstantValue<_> (Properties.Window.resizeMode, v)
      let topmost                                  v = SetConstantValue<_> (Properties.Window.topmost, v)
      let showActivated                            v = SetConstantValue<_> (Properties.Window.showActivated, v)
      let onSourceInitialized                      (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.SourceInitialized.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.SourceInitialized.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (r, u, f)
      let onDpiChanged                             (f : System.Windows.Window -> System.Windows.DpiChangedEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.AddHandler    (System.Windows.DpiChangedEventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.RemoveHandler (System.Windows.DpiChangedEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> (r, u, f)
      let onActivated                              (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Activated.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Activated.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (r, u, f)
      let onDeactivated                            (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Deactivated.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Deactivated.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (r, u, f)
      let onStateChanged                           (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.StateChanged.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.StateChanged.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (r, u, f)
      let onLocationChanged                        (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.LocationChanged.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.LocationChanged.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (r, u, f)
      let onClosing                                (f : System.Windows.Window -> System.ComponentModel.CancelEventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.ComponentModel.CancelEventArgs -> unit) = o.Closing.AddHandler    (System.ComponentModel.CancelEventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.ComponentModel.CancelEventArgs -> unit) = o.Closing.RemoveHandler (System.ComponentModel.CancelEventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs> (r, u, f)
      let onClosed                                 (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Closed.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Closed.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (r, u, f)
      let onContentRendered                        (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        let r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.AddHandler    (System.EventHandler h)
        let u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.RemoveHandler (System.EventHandler h)
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (r, u, f)

    let wrapPanel                                values children =
      StandardPanelView<WrapPanel> (values, children) :> View
    module WrapPanel = 
      let dummy = ()
      let itemWidth                                v = SetConstantValue<_> (Properties.WrapPanel.itemWidth, v)
      let itemHeight                               v = SetConstantValue<_> (Properties.WrapPanel.itemHeight, v)
      let orientation                              v = SetConstantValue<_> (Properties.WrapPanel.orientation, v)

