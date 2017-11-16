namespace Galactus

open System.Windows
open System.Windows.Controls
open System.Windows.Controls.Primitives
open System.Windows.Documents
open System.Windows.Navigation
open System.Windows.Shapes

open Galactus.Core

module Generated =
  module Dummy =
    open System

  module Properties =
    module AccessText = 
      open Dummy
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
      open Dummy

    module AdornedElementPlaceholder = 
      open Dummy

    module Adorner = 
      open Dummy

    module AdornerDecorator = 
      open Dummy

    module AdornerLayer = 
      open Dummy

    module Border = 
      open Dummy
      let borderThickness                          = Property<System.Windows.Thickness> System.Windows.Controls.Border.BorderThicknessProperty
      let padding                                  = Property<System.Windows.Thickness> System.Windows.Controls.Border.PaddingProperty
      let cornerRadius                             = Property<System.Windows.CornerRadius> System.Windows.Controls.Border.CornerRadiusProperty
      let borderBrush                              = Property<System.Windows.Media.Brush> System.Windows.Controls.Border.BorderBrushProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Border.BackgroundProperty

    module BulletDecorator = 
      open Dummy
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.BulletDecorator.BackgroundProperty

    module Button = 
      open Dummy
      let isDefault                                = Property<System.Boolean> System.Windows.Controls.Button.IsDefaultProperty
      let isCancel                                 = Property<System.Boolean> System.Windows.Controls.Button.IsCancelProperty
      let isDefaulted                              = Property<System.Boolean> System.Windows.Controls.Button.IsDefaultedProperty

    module ButtonBase = 
      open Dummy
      let command                                  = Property<System.Windows.Input.ICommand> System.Windows.Controls.Primitives.ButtonBase.CommandProperty
      let commandParameter                         = Property<System.Object> System.Windows.Controls.Primitives.ButtonBase.CommandParameterProperty
      let commandTarget                            = Property<System.Windows.IInputElement> System.Windows.Controls.Primitives.ButtonBase.CommandTargetProperty
      let isPressed                                = Property<System.Boolean> System.Windows.Controls.Primitives.ButtonBase.IsPressedProperty
      let clickMode                                = Property<System.Windows.Controls.ClickMode> System.Windows.Controls.Primitives.ButtonBase.ClickModeProperty

    module Calendar = 
      open Dummy
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
      open Dummy
      let hasSelectedDays                          = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarButton.HasSelectedDaysProperty
      let isInactive                               = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarButton.IsInactiveProperty

    module CalendarDayButton = 
      open Dummy
      let isToday                                  = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsTodayProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsSelectedProperty
      let isInactive                               = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsInactiveProperty
      let isBlackedOut                             = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsBlackedOutProperty
      let isHighlighted                            = Property<System.Boolean> System.Windows.Controls.Primitives.CalendarDayButton.IsHighlightedProperty

    module CalendarItem = 
      open Dummy

    module Canvas = 
      open Dummy
      let left                                     = Property<System.Double> System.Windows.Controls.Canvas.LeftProperty
      let top                                      = Property<System.Double> System.Windows.Controls.Canvas.TopProperty
      let right                                    = Property<System.Double> System.Windows.Controls.Canvas.RightProperty
      let bottom                                   = Property<System.Double> System.Windows.Controls.Canvas.BottomProperty

    module CheckBox = 
      open Dummy

    module ComboBox = 
      open Dummy
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
      open Dummy
      let isHighlighted                            = Property<System.Boolean> System.Windows.Controls.ComboBoxItem.IsHighlightedProperty

    module ContentControl = 
      open Dummy
      let content                                  = Property<System.Object> System.Windows.Controls.ContentControl.ContentProperty
      let hasContent                               = Property<System.Boolean> System.Windows.Controls.ContentControl.HasContentProperty
      let contentTemplate                          = Property<System.Windows.DataTemplate> System.Windows.Controls.ContentControl.ContentTemplateProperty
      let contentTemplateSelector                  = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty
      let contentStringFormat                      = Property<System.String> System.Windows.Controls.ContentControl.ContentStringFormatProperty

    module ContentPresenter = 
      open Dummy
      let recognizesAccessKey                      = Property<System.Boolean> System.Windows.Controls.ContentPresenter.RecognizesAccessKeyProperty
      let content                                  = Property<System.Object> System.Windows.Controls.ContentPresenter.ContentProperty
      let contentTemplate                          = Property<System.Windows.DataTemplate> System.Windows.Controls.ContentPresenter.ContentTemplateProperty
      let contentTemplateSelector                  = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.ContentPresenter.ContentTemplateSelectorProperty
      let contentStringFormat                      = Property<System.String> System.Windows.Controls.ContentPresenter.ContentStringFormatProperty
      let contentSource                            = Property<System.String> System.Windows.Controls.ContentPresenter.ContentSourceProperty

    module ContextMenu = 
      open Dummy
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
      open Dummy
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
      open Dummy
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
      open Dummy
      let column                                   = Property<System.Windows.Controls.DataGridColumn> System.Windows.Controls.DataGridCell.ColumnProperty
      let isEditing                                = Property<System.Boolean> System.Windows.Controls.DataGridCell.IsEditingProperty
      let isReadOnly                               = Property<System.Boolean> System.Windows.Controls.DataGridCell.IsReadOnlyProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.DataGridCell.IsSelectedProperty

    module DataGridCellsPanel = 
      open Dummy

    module DataGridCellsPresenter = 
      open Dummy

    module DataGridColumnHeader = 
      open Dummy
      let separatorBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorBrushProperty
      let separatorVisibility                      = Property<System.Windows.Visibility> System.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorVisibilityProperty
      let displayIndex                             = Property<System.Int32> System.Windows.Controls.Primitives.DataGridColumnHeader.DisplayIndexProperty
      let canUserSort                              = Property<System.Boolean> System.Windows.Controls.Primitives.DataGridColumnHeader.CanUserSortProperty
      let sortDirection                            = Property<System.Nullable<System.ComponentModel.ListSortDirection>> System.Windows.Controls.Primitives.DataGridColumnHeader.SortDirectionProperty
      let isFrozen                                 = Property<System.Boolean> System.Windows.Controls.Primitives.DataGridColumnHeader.IsFrozenProperty

    module DataGridColumnHeadersPresenter = 
      open Dummy

    module DataGridDetailsPresenter = 
      open Dummy

    module DataGridRow = 
      open Dummy
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
      open Dummy
      let separatorBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.Primitives.DataGridRowHeader.SeparatorBrushProperty
      let separatorVisibility                      = Property<System.Windows.Visibility> System.Windows.Controls.Primitives.DataGridRowHeader.SeparatorVisibilityProperty
      let isRowSelected                            = Property<System.Boolean> System.Windows.Controls.Primitives.DataGridRowHeader.IsRowSelectedProperty

    module DataGridRowsPresenter = 
      open Dummy

    module DatePicker = 
      open Dummy
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
      open Dummy

    module Decorator = 
      open Dummy

    module DockPanel = 
      open Dummy
      let lastChildFill                            = Property<System.Boolean> System.Windows.Controls.DockPanel.LastChildFillProperty
      let dock                                     = Property<System.Windows.Controls.Dock> System.Windows.Controls.DockPanel.DockProperty

    module DocumentPageView = 
      open Dummy
      let pageNumber                               = Property<System.Int32> System.Windows.Controls.Primitives.DocumentPageView.PageNumberProperty
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Controls.Primitives.DocumentPageView.StretchProperty
      let stretchDirection                         = Property<System.Windows.Controls.StretchDirection> System.Windows.Controls.Primitives.DocumentPageView.StretchDirectionProperty

    module DocumentReference = 
      open Dummy
      let source                                   = Property<System.Uri> System.Windows.Documents.DocumentReference.SourceProperty

    module DocumentViewer = 
      open Dummy
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
      open Dummy
      let document                                 = Property<System.Windows.Documents.IDocumentPaginatorSource> System.Windows.Controls.Primitives.DocumentViewerBase.DocumentProperty
      let pageCount                                = Property<System.Int32> System.Windows.Controls.Primitives.DocumentViewerBase.PageCountProperty
      let masterPageNumber                         = Property<System.Int32> System.Windows.Controls.Primitives.DocumentViewerBase.MasterPageNumberProperty
      let canGoToPreviousPage                      = Property<System.Boolean> System.Windows.Controls.Primitives.DocumentViewerBase.CanGoToPreviousPageProperty
      let canGoToNextPage                          = Property<System.Boolean> System.Windows.Controls.Primitives.DocumentViewerBase.CanGoToNextPageProperty
      let isMasterPage                             = Property<System.Boolean> System.Windows.Controls.Primitives.DocumentViewerBase.IsMasterPageProperty

    module Ellipse = 
      open Dummy

    module Expander = 
      open Dummy
      let expandDirection                          = Property<System.Windows.Controls.ExpandDirection> System.Windows.Controls.Expander.ExpandDirectionProperty
      let isExpanded                               = Property<System.Boolean> System.Windows.Controls.Expander.IsExpandedProperty

    module FixedPage = 
      open Dummy
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
      open Dummy
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
      open Dummy
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
      open Dummy
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
      open Dummy
      let source                                   = Property<System.Uri> System.Windows.Controls.Frame.SourceProperty
      let canGoBack                                = Property<System.Boolean> System.Windows.Controls.Frame.CanGoBackProperty
      let canGoForward                             = Property<System.Boolean> System.Windows.Controls.Frame.CanGoForwardProperty
      let backStack                                = Property<System.Collections.IEnumerable> System.Windows.Controls.Frame.BackStackProperty
      let forwardStack                             = Property<System.Collections.IEnumerable> System.Windows.Controls.Frame.ForwardStackProperty
      let navigationUIVisibility                   = Property<System.Windows.Navigation.NavigationUIVisibility> System.Windows.Controls.Frame.NavigationUIVisibilityProperty
      let sandboxExternalContent                   = Property<System.Boolean> System.Windows.Controls.Frame.SandboxExternalContentProperty
      let journalOwnership                         = Property<System.Windows.Navigation.JournalOwnership> System.Windows.Controls.Frame.JournalOwnershipProperty

    module FrameworkElement = 
      open Dummy
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
      open Dummy
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
      open Dummy
      let showGridLines                            = Property<System.Boolean> System.Windows.Controls.Grid.ShowGridLinesProperty
      let column                                   = Property<System.Int32> System.Windows.Controls.Grid.ColumnProperty
      let row                                      = Property<System.Int32> System.Windows.Controls.Grid.RowProperty
      let columnSpan                               = Property<System.Int32> System.Windows.Controls.Grid.ColumnSpanProperty
      let rowSpan                                  = Property<System.Int32> System.Windows.Controls.Grid.RowSpanProperty
      let isSharedSizeScope                        = Property<System.Boolean> System.Windows.Controls.Grid.IsSharedSizeScopeProperty

    module GridSplitter = 
      open Dummy
      let resizeDirection                          = Property<System.Windows.Controls.GridResizeDirection> System.Windows.Controls.GridSplitter.ResizeDirectionProperty
      let resizeBehavior                           = Property<System.Windows.Controls.GridResizeBehavior> System.Windows.Controls.GridSplitter.ResizeBehaviorProperty
      let showsPreview                             = Property<System.Boolean> System.Windows.Controls.GridSplitter.ShowsPreviewProperty
      let previewStyle                             = Property<System.Windows.Style> System.Windows.Controls.GridSplitter.PreviewStyleProperty
      let keyboardIncrement                        = Property<System.Double> System.Windows.Controls.GridSplitter.KeyboardIncrementProperty
      let dragIncrement                            = Property<System.Double> System.Windows.Controls.GridSplitter.DragIncrementProperty

    module GridViewColumnHeader = 
      open Dummy
      let column                                   = Property<System.Windows.Controls.GridViewColumn> System.Windows.Controls.GridViewColumnHeader.ColumnProperty
      let role                                     = Property<System.Windows.Controls.GridViewColumnHeaderRole> System.Windows.Controls.GridViewColumnHeader.RoleProperty

    module GridViewHeaderRowPresenter = 
      open Dummy
      let columnHeaderContainerStyle               = Property<System.Windows.Style> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContainerStyleProperty
      let columnHeaderTemplate                     = Property<System.Windows.DataTemplate> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateProperty
      let columnHeaderTemplateSelector             = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderTemplateSelectorProperty
      let columnHeaderStringFormat                 = Property<System.String> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderStringFormatProperty
      let allowsColumnReorder                      = Property<System.Boolean> System.Windows.Controls.GridViewHeaderRowPresenter.AllowsColumnReorderProperty
      let columnHeaderContextMenu                  = Property<System.Windows.Controls.ContextMenu> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderContextMenuProperty
      let columnHeaderToolTip                      = Property<System.Object> System.Windows.Controls.GridViewHeaderRowPresenter.ColumnHeaderToolTipProperty

    module GridViewRowPresenter = 
      open Dummy
      let content                                  = Property<System.Object> System.Windows.Controls.GridViewRowPresenter.ContentProperty

    module GridViewRowPresenterBase = 
      open Dummy
      let columns                                  = Property<System.Windows.Controls.GridViewColumnCollection> System.Windows.Controls.Primitives.GridViewRowPresenterBase.ColumnsProperty

    module GroupBox = 
      open Dummy

    module GroupItem = 
      open Dummy

    module HeaderedContentControl = 
      open Dummy
      let header                                   = Property<System.Object> System.Windows.Controls.HeaderedContentControl.HeaderProperty
      let hasHeader                                = Property<System.Boolean> System.Windows.Controls.HeaderedContentControl.HasHeaderProperty
      let headerTemplate                           = Property<System.Windows.DataTemplate> System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty
      let headerTemplateSelector                   = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty
      let headerStringFormat                       = Property<System.String> System.Windows.Controls.HeaderedContentControl.HeaderStringFormatProperty

    module HeaderedItemsControl = 
      open Dummy
      let header                                   = Property<System.Object> System.Windows.Controls.HeaderedItemsControl.HeaderProperty
      let hasHeader                                = Property<System.Boolean> System.Windows.Controls.HeaderedItemsControl.HasHeaderProperty
      let headerTemplate                           = Property<System.Windows.DataTemplate> System.Windows.Controls.HeaderedItemsControl.HeaderTemplateProperty
      let headerTemplateSelector                   = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.HeaderedItemsControl.HeaderTemplateSelectorProperty
      let headerStringFormat                       = Property<System.String> System.Windows.Controls.HeaderedItemsControl.HeaderStringFormatProperty

    module Image = 
      open Dummy
      let source                                   = Property<System.Windows.Media.ImageSource> System.Windows.Controls.Image.SourceProperty
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Controls.Image.StretchProperty
      let stretchDirection                         = Property<System.Windows.Controls.StretchDirection> System.Windows.Controls.Image.StretchDirectionProperty

    module InkCanvas = 
      open Dummy
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
      open Dummy
      let strokes                                  = Property<System.Windows.Ink.StrokeCollection> System.Windows.Controls.InkPresenter.StrokesProperty

    module ItemsControl = 
      open Dummy
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
      open Dummy

    module Label = 
      open Dummy
      let target                                   = Property<System.Windows.UIElement> System.Windows.Controls.Label.TargetProperty

    module Line = 
      open Dummy
      let x1                                       = Property<System.Double> System.Windows.Shapes.Line.X1Property
      let y1                                       = Property<System.Double> System.Windows.Shapes.Line.Y1Property
      let x2                                       = Property<System.Double> System.Windows.Shapes.Line.X2Property
      let y2                                       = Property<System.Double> System.Windows.Shapes.Line.Y2Property

    module ListBox = 
      open Dummy
      let selectionMode                            = Property<System.Windows.Controls.SelectionMode> System.Windows.Controls.ListBox.SelectionModeProperty
      let selectedItems                            = Property<System.Collections.IList> System.Windows.Controls.ListBox.SelectedItemsProperty

    module ListBoxItem = 
      open Dummy
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.ListBoxItem.IsSelectedProperty

    module ListView = 
      open Dummy
      let view                                     = Property<System.Windows.Controls.ViewBase> System.Windows.Controls.ListView.ViewProperty

    module ListViewItem = 
      open Dummy

    module MediaElement = 
      open Dummy
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
      open Dummy
      let isMainMenu                               = Property<System.Boolean> System.Windows.Controls.Menu.IsMainMenuProperty

    module MenuBase = 
      open Dummy
      let itemContainerTemplateSelector            = Property<System.Windows.Controls.ItemContainerTemplateSelector> System.Windows.Controls.Primitives.MenuBase.ItemContainerTemplateSelectorProperty
      let usesItemContainerTemplate                = Property<System.Boolean> System.Windows.Controls.Primitives.MenuBase.UsesItemContainerTemplateProperty

    module MenuItem = 
      open Dummy
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
      open Dummy

    module NavigationWindow = 
      open Dummy
      let sandboxExternalContent                   = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.SandboxExternalContentProperty
      let showsNavigationUI                        = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.ShowsNavigationUIProperty
      let backStack                                = Property<System.Collections.IEnumerable> System.Windows.Navigation.NavigationWindow.BackStackProperty
      let forwardStack                             = Property<System.Collections.IEnumerable> System.Windows.Navigation.NavigationWindow.ForwardStackProperty
      let canGoBack                                = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.CanGoBackProperty
      let canGoForward                             = Property<System.Boolean> System.Windows.Navigation.NavigationWindow.CanGoForwardProperty
      let source                                   = Property<System.Uri> System.Windows.Navigation.NavigationWindow.SourceProperty

    module Page = 
      open Dummy
      let content                                  = Property<System.Object> System.Windows.Controls.Page.ContentProperty
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Page.BackgroundProperty
      let title                                    = Property<System.String> System.Windows.Controls.Page.TitleProperty
      let keepAlive                                = Property<System.Boolean> System.Windows.Controls.Page.KeepAliveProperty
      let foreground                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Page.ForegroundProperty
      let fontFamily                               = Property<System.Windows.Media.FontFamily> System.Windows.Controls.Page.FontFamilyProperty
      let fontSize                                 = Property<System.Double> System.Windows.Controls.Page.FontSizeProperty
      let template                                 = Property<System.Windows.Controls.ControlTemplate> System.Windows.Controls.Page.TemplateProperty

    module PageContent = 
      open Dummy
      let source                                   = Property<System.Uri> System.Windows.Documents.PageContent.SourceProperty

    module PageFunctionBase = 
      open Dummy

    module Panel = 
      open Dummy
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.Panel.BackgroundProperty
      let isItemsHost                              = Property<System.Boolean> System.Windows.Controls.Panel.IsItemsHostProperty
      let zIndex                                   = Property<System.Int32> System.Windows.Controls.Panel.ZIndexProperty

    module PasswordBox = 
      open Dummy
      let passwordChar                             = Property<System.Char> System.Windows.Controls.PasswordBox.PasswordCharProperty
      let maxLength                                = Property<System.Int32> System.Windows.Controls.PasswordBox.MaxLengthProperty
      let selectionBrush                           = Property<System.Windows.Media.Brush> System.Windows.Controls.PasswordBox.SelectionBrushProperty
      let selectionOpacity                         = Property<System.Double> System.Windows.Controls.PasswordBox.SelectionOpacityProperty
      let caretBrush                               = Property<System.Windows.Media.Brush> System.Windows.Controls.PasswordBox.CaretBrushProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.PasswordBox.IsSelectionActiveProperty
      let isInactiveSelectionHighlightEnabled      = Property<System.Boolean> System.Windows.Controls.PasswordBox.IsInactiveSelectionHighlightEnabledProperty

    module Path = 
      open Dummy
      let data                                     = Property<System.Windows.Media.Geometry> System.Windows.Shapes.Path.DataProperty

    module Polygon = 
      open Dummy
      let points                                   = Property<System.Windows.Media.PointCollection> System.Windows.Shapes.Polygon.PointsProperty
      let fillRule                                 = Property<System.Windows.Media.FillRule> System.Windows.Shapes.Polygon.FillRuleProperty

    module Polyline = 
      open Dummy
      let points                                   = Property<System.Windows.Media.PointCollection> System.Windows.Shapes.Polyline.PointsProperty
      let fillRule                                 = Property<System.Windows.Media.FillRule> System.Windows.Shapes.Polyline.FillRuleProperty

    module Popup = 
      open Dummy
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
      open Dummy
      let isIndeterminate                          = Property<System.Boolean> System.Windows.Controls.ProgressBar.IsIndeterminateProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.ProgressBar.OrientationProperty

    module RadioButton = 
      open Dummy
      let groupName                                = Property<System.String> System.Windows.Controls.RadioButton.GroupNameProperty

    module RangeBase = 
      open Dummy
      let minimum                                  = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.MinimumProperty
      let maximum                                  = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.MaximumProperty
      let value                                    = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.ValueProperty
      let largeChange                              = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.LargeChangeProperty
      let smallChange                              = Property<System.Double> System.Windows.Controls.Primitives.RangeBase.SmallChangeProperty

    module Rectangle = 
      open Dummy
      let radiusX                                  = Property<System.Double> System.Windows.Shapes.Rectangle.RadiusXProperty
      let radiusY                                  = Property<System.Double> System.Windows.Shapes.Rectangle.RadiusYProperty

    module RepeatButton = 
      open Dummy
      let delay                                    = Property<System.Int32> System.Windows.Controls.Primitives.RepeatButton.DelayProperty
      let interval                                 = Property<System.Int32> System.Windows.Controls.Primitives.RepeatButton.IntervalProperty

    module ResizeGrip = 
      open Dummy

    module RichTextBox = 
      open Dummy
      let isDocumentEnabled                        = Property<System.Boolean> System.Windows.Controls.RichTextBox.IsDocumentEnabledProperty

    module ScrollBar = 
      open Dummy
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.Primitives.ScrollBar.OrientationProperty
      let viewportSize                             = Property<System.Double> System.Windows.Controls.Primitives.ScrollBar.ViewportSizeProperty

    module ScrollContentPresenter = 
      open Dummy
      let canContentScroll                         = Property<System.Boolean> System.Windows.Controls.ScrollContentPresenter.CanContentScrollProperty

    module ScrollViewer = 
      open Dummy
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
      open Dummy
      let selectiveScrollingOrientation            = Property<System.Windows.Controls.SelectiveScrollingOrientation> System.Windows.Controls.Primitives.SelectiveScrollingGrid.SelectiveScrollingOrientationProperty

    module Selector = 
      open Dummy
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.Primitives.Selector.IsSelectionActiveProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.Primitives.Selector.IsSelectedProperty
      let isSynchronizedWithCurrentItem            = Property<System.Nullable<System.Boolean>> System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItemProperty
      let selectedIndex                            = Property<System.Int32> System.Windows.Controls.Primitives.Selector.SelectedIndexProperty
      let selectedItem                             = Property<System.Object> System.Windows.Controls.Primitives.Selector.SelectedItemProperty
      let selectedValue                            = Property<System.Object> System.Windows.Controls.Primitives.Selector.SelectedValueProperty
      let selectedValuePath                        = Property<System.String> System.Windows.Controls.Primitives.Selector.SelectedValuePathProperty

    module Separator = 
      open Dummy

    module Shape = 
      open Dummy
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
      open Dummy
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
      open Dummy
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.StackPanel.OrientationProperty

    module StatusBar = 
      open Dummy
      let itemContainerTemplateSelector            = Property<System.Windows.Controls.ItemContainerTemplateSelector> System.Windows.Controls.Primitives.StatusBar.ItemContainerTemplateSelectorProperty
      let usesItemContainerTemplate                = Property<System.Boolean> System.Windows.Controls.Primitives.StatusBar.UsesItemContainerTemplateProperty

    module StatusBarItem = 
      open Dummy

    module StickyNoteControl = 
      open Dummy
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
      open Dummy
      let tabStripPlacement                        = Property<System.Windows.Controls.Dock> System.Windows.Controls.TabControl.TabStripPlacementProperty
      let selectedContent                          = Property<System.Object> System.Windows.Controls.TabControl.SelectedContentProperty
      let selectedContentTemplate                  = Property<System.Windows.DataTemplate> System.Windows.Controls.TabControl.SelectedContentTemplateProperty
      let selectedContentTemplateSelector          = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.TabControl.SelectedContentTemplateSelectorProperty
      let selectedContentStringFormat              = Property<System.String> System.Windows.Controls.TabControl.SelectedContentStringFormatProperty
      let contentTemplate                          = Property<System.Windows.DataTemplate> System.Windows.Controls.TabControl.ContentTemplateProperty
      let contentTemplateSelector                  = Property<System.Windows.Controls.DataTemplateSelector> System.Windows.Controls.TabControl.ContentTemplateSelectorProperty
      let contentStringFormat                      = Property<System.String> System.Windows.Controls.TabControl.ContentStringFormatProperty

    module TabItem = 
      open Dummy
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.TabItem.IsSelectedProperty
      let tabStripPlacement                        = Property<System.Windows.Controls.Dock> System.Windows.Controls.TabItem.TabStripPlacementProperty

    module TabPanel = 
      open Dummy

    module TextBlock = 
      open Dummy
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
      open Dummy
      let textWrapping                             = Property<System.Windows.TextWrapping> System.Windows.Controls.TextBox.TextWrappingProperty
      let minLines                                 = Property<System.Int32> System.Windows.Controls.TextBox.MinLinesProperty
      let maxLines                                 = Property<System.Int32> System.Windows.Controls.TextBox.MaxLinesProperty
      let text                                     = Property<System.String> System.Windows.Controls.TextBox.TextProperty
      let characterCasing                          = Property<System.Windows.Controls.CharacterCasing> System.Windows.Controls.TextBox.CharacterCasingProperty
      let maxLength                                = Property<System.Int32> System.Windows.Controls.TextBox.MaxLengthProperty
      let textAlignment                            = Property<System.Windows.TextAlignment> System.Windows.Controls.TextBox.TextAlignmentProperty
      let textDecorations                          = Property<System.Windows.TextDecorationCollection> System.Windows.Controls.TextBox.TextDecorationsProperty

    module TextBoxBase = 
      open Dummy
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
      open Dummy
      let isDragging                               = Property<System.Boolean> System.Windows.Controls.Primitives.Thumb.IsDraggingProperty

    module TickBar = 
      open Dummy
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
      open Dummy
      let isChecked                                = Property<System.Nullable<System.Boolean>> System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty
      let isThreeState                             = Property<System.Boolean> System.Windows.Controls.Primitives.ToggleButton.IsThreeStateProperty

    module ToolBar = 
      open Dummy
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.ToolBar.OrientationProperty
      let band                                     = Property<System.Int32> System.Windows.Controls.ToolBar.BandProperty
      let bandIndex                                = Property<System.Int32> System.Windows.Controls.ToolBar.BandIndexProperty
      let isOverflowOpen                           = Property<System.Boolean> System.Windows.Controls.ToolBar.IsOverflowOpenProperty
      let hasOverflowItems                         = Property<System.Boolean> System.Windows.Controls.ToolBar.HasOverflowItemsProperty
      let isOverflowItem                           = Property<System.Boolean> System.Windows.Controls.ToolBar.IsOverflowItemProperty
      let overflowMode                             = Property<System.Windows.Controls.OverflowMode> System.Windows.Controls.ToolBar.OverflowModeProperty

    module ToolBarOverflowPanel = 
      open Dummy
      let wrapWidth                                = Property<System.Double> System.Windows.Controls.Primitives.ToolBarOverflowPanel.WrapWidthProperty

    module ToolBarPanel = 
      open Dummy

    module ToolBarTray = 
      open Dummy
      let background                               = Property<System.Windows.Media.Brush> System.Windows.Controls.ToolBarTray.BackgroundProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.ToolBarTray.OrientationProperty
      let isLocked                                 = Property<System.Boolean> System.Windows.Controls.ToolBarTray.IsLockedProperty

    module ToolTip = 
      open Dummy
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
      open Dummy
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.Primitives.Track.OrientationProperty
      let minimum                                  = Property<System.Double> System.Windows.Controls.Primitives.Track.MinimumProperty
      let maximum                                  = Property<System.Double> System.Windows.Controls.Primitives.Track.MaximumProperty
      let value                                    = Property<System.Double> System.Windows.Controls.Primitives.Track.ValueProperty
      let viewportSize                             = Property<System.Double> System.Windows.Controls.Primitives.Track.ViewportSizeProperty
      let isDirectionReversed                      = Property<System.Boolean> System.Windows.Controls.Primitives.Track.IsDirectionReversedProperty

    module TreeView = 
      open Dummy
      let selectedItem                             = Property<System.Object> System.Windows.Controls.TreeView.SelectedItemProperty
      let selectedValue                            = Property<System.Object> System.Windows.Controls.TreeView.SelectedValueProperty
      let selectedValuePath                        = Property<System.String> System.Windows.Controls.TreeView.SelectedValuePathProperty

    module TreeViewItem = 
      open Dummy
      let isExpanded                               = Property<System.Boolean> System.Windows.Controls.TreeViewItem.IsExpandedProperty
      let isSelected                               = Property<System.Boolean> System.Windows.Controls.TreeViewItem.IsSelectedProperty
      let isSelectionActive                        = Property<System.Boolean> System.Windows.Controls.TreeViewItem.IsSelectionActiveProperty

    module UIElement = 
      open Dummy
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
      open Dummy
      let firstColumn                              = Property<System.Int32> System.Windows.Controls.Primitives.UniformGrid.FirstColumnProperty
      let columns                                  = Property<System.Int32> System.Windows.Controls.Primitives.UniformGrid.ColumnsProperty
      let rows                                     = Property<System.Int32> System.Windows.Controls.Primitives.UniformGrid.RowsProperty

    module UserControl = 
      open Dummy

    module Viewbox = 
      open Dummy
      let stretch                                  = Property<System.Windows.Media.Stretch> System.Windows.Controls.Viewbox.StretchProperty
      let stretchDirection                         = Property<System.Windows.Controls.StretchDirection> System.Windows.Controls.Viewbox.StretchDirectionProperty

    module Viewport3D = 
      open Dummy
      let camera                                   = Property<System.Windows.Media.Media3D.Camera> System.Windows.Controls.Viewport3D.CameraProperty
      let children                                 = Property<System.Windows.Media.Media3D.Visual3DCollection> System.Windows.Controls.Viewport3D.ChildrenProperty

    module VirtualizingPanel = 
      open Dummy
      let isVirtualizing                           = Property<System.Boolean> System.Windows.Controls.VirtualizingPanel.IsVirtualizingProperty
      let virtualizationMode                       = Property<System.Windows.Controls.VirtualizationMode> System.Windows.Controls.VirtualizingPanel.VirtualizationModeProperty
      let isVirtualizingWhenGrouping               = Property<System.Boolean> System.Windows.Controls.VirtualizingPanel.IsVirtualizingWhenGroupingProperty
      let scrollUnit                               = Property<System.Windows.Controls.ScrollUnit> System.Windows.Controls.VirtualizingPanel.ScrollUnitProperty
      let cacheLength                              = Property<System.Windows.Controls.VirtualizationCacheLength> System.Windows.Controls.VirtualizingPanel.CacheLengthProperty
      let cacheLengthUnit                          = Property<System.Windows.Controls.VirtualizationCacheLengthUnit> System.Windows.Controls.VirtualizingPanel.CacheLengthUnitProperty
      let isContainerVirtualizable                 = Property<System.Boolean> System.Windows.Controls.VirtualizingPanel.IsContainerVirtualizableProperty

    module VirtualizingStackPanel = 
      open Dummy
      let isVirtualizing                           = Property<System.Boolean> System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty
      let virtualizationMode                       = Property<System.Windows.Controls.VirtualizationMode> System.Windows.Controls.VirtualizingStackPanel.VirtualizationModeProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.VirtualizingStackPanel.OrientationProperty

    module WebBrowser = 
      open Dummy

    module Window = 
      open Dummy
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
      open Dummy
      let itemWidth                                = Property<System.Double> System.Windows.Controls.WrapPanel.ItemWidthProperty
      let itemHeight                               = Property<System.Double> System.Windows.Controls.WrapPanel.ItemHeightProperty
      let orientation                              = Property<System.Windows.Controls.Orientation> System.Windows.Controls.WrapPanel.OrientationProperty

  module Controls =
    let accessText                               values =
      StandardView<AccessText> (values) :> View
    module AccessText = 
      open Dummy
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
      open Dummy

    let adornedElementPlaceholder                values =
      StandardView<AdornedElementPlaceholder> (values) :> View
    module AdornedElementPlaceholder = 
      open Dummy

    module Adorner = 
      open Dummy

    let adornerDecorator                         values =
      StandardView<AdornerDecorator> (values) :> View
    module AdornerDecorator = 
      open Dummy

    module AdornerLayer = 
      open Dummy

    let border                                   values =
      StandardView<Border> (values) :> View
    module Border = 
      open Dummy
      let borderThickness                          v = SetConstantValue<_> (Properties.Border.borderThickness, v)
      let padding                                  v = SetConstantValue<_> (Properties.Border.padding, v)
      let cornerRadius                             v = SetConstantValue<_> (Properties.Border.cornerRadius, v)
      let borderBrush                              v = SetConstantValue<_> (Properties.Border.borderBrush, v)
      let background                               v = SetConstantValue<_> (Properties.Border.background, v)

    let bulletDecorator                          values =
      StandardView<BulletDecorator> (values) :> View
    module BulletDecorator = 
      open Dummy
      let background                               v = SetConstantValue<_> (Properties.BulletDecorator.background, v)

    let button                                   values child =
      StandardContentView<Button> (values, child) :> View
    module Button = 
      open Dummy
      let isDefault                                v = SetConstantValue<_> (Properties.Button.isDefault, v)
      let isCancel                                 v = SetConstantValue<_> (Properties.Button.isCancel, v)
      let isDefaulted                              v = SetConstantValue<_> (Properties.Button.isDefaulted, v)

    module ButtonBase = 
      open Dummy
      let command                                  v = SetConstantValue<_> (Properties.ButtonBase.command, v)
      let commandParameter                         v = SetConstantValue<_> (Properties.ButtonBase.commandParameter, v)
      let commandTarget                            v = SetConstantValue<_> (Properties.ButtonBase.commandTarget, v)
      let isPressed                                v = SetConstantValue<_> (Properties.ButtonBase.isPressed, v)
      let clickMode                                v = SetConstantValue<_> (Properties.ButtonBase.clickMode, v)
      
      let private onClick_r (o : System.Windows.Controls.Primitives.ButtonBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onClick_u (o : System.Windows.Controls.Primitives.ButtonBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onClick_rf = onClick_r
      let private onClick_uf = onClick_u
      let onClick                                  (f : System.Windows.Controls.Primitives.ButtonBase -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ButtonBase, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onClick_rf, onClick_uf, f)

    let calendar                                 values =
      StandardView<Calendar> (values) :> View
    module Calendar = 
      open Dummy
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
      
      let private onSelectedDatesChanged_r (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDatesChanged.AddHandler    (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
      let private onSelectedDatesChanged_u (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDatesChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
      let private onSelectedDatesChanged_rf = onSelectedDatesChanged_r
      let private onSelectedDatesChanged_uf = onSelectedDatesChanged_u
      let onSelectedDatesChanged                   (f : System.Windows.Controls.Calendar -> System.Windows.Controls.SelectionChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> (onSelectedDatesChanged_rf, onSelectedDatesChanged_uf, f)
      
      let private onDisplayDateChanged_r (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarDateChangedEventArgs -> unit) = o.DisplayDateChanged.AddHandler    (System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs> h)
      let private onDisplayDateChanged_u (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarDateChangedEventArgs -> unit) = o.DisplayDateChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs> h)
      let private onDisplayDateChanged_rf = onDisplayDateChanged_r
      let private onDisplayDateChanged_uf = onDisplayDateChanged_u
      let onDisplayDateChanged                     (f : System.Windows.Controls.Calendar -> System.Windows.Controls.CalendarDateChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs>, System.Windows.Controls.CalendarDateChangedEventArgs> (onDisplayDateChanged_rf, onDisplayDateChanged_uf, f)
      
      let private onDisplayModeChanged_r (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarModeChangedEventArgs -> unit) = o.DisplayModeChanged.AddHandler    (System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs> h)
      let private onDisplayModeChanged_u (o : System.Windows.Controls.Calendar) (h : obj -> System.Windows.Controls.CalendarModeChangedEventArgs -> unit) = o.DisplayModeChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs> h)
      let private onDisplayModeChanged_rf = onDisplayModeChanged_r
      let private onDisplayModeChanged_uf = onDisplayModeChanged_u
      let onDisplayModeChanged                     (f : System.Windows.Controls.Calendar -> System.Windows.Controls.CalendarModeChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs>, System.Windows.Controls.CalendarModeChangedEventArgs> (onDisplayModeChanged_rf, onDisplayModeChanged_uf, f)
      
      let private onSelectionModeChanged_r (o : System.Windows.Controls.Calendar) (h : obj -> System.EventArgs -> unit) = o.SelectionModeChanged.AddHandler    (System.EventHandler<System.EventArgs> h)
      let private onSelectionModeChanged_u (o : System.Windows.Controls.Calendar) (h : obj -> System.EventArgs -> unit) = o.SelectionModeChanged.RemoveHandler (System.EventHandler<System.EventArgs> h)
      let private onSelectionModeChanged_rf = onSelectionModeChanged_r
      let private onSelectionModeChanged_uf = onSelectionModeChanged_u
      let onSelectionModeChanged                   (f : System.Windows.Controls.Calendar -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Calendar, System.EventHandler<System.EventArgs>, System.EventArgs> (onSelectionModeChanged_rf, onSelectionModeChanged_uf, f)

    let calendarButton                           values child =
      StandardContentView<CalendarButton> (values, child) :> View
    module CalendarButton = 
      open Dummy
      let hasSelectedDays                          v = SetConstantValue<_> (Properties.CalendarButton.hasSelectedDays, v)
      let isInactive                               v = SetConstantValue<_> (Properties.CalendarButton.isInactive, v)

    let calendarDayButton                        values child =
      StandardContentView<CalendarDayButton> (values, child) :> View
    module CalendarDayButton = 
      open Dummy
      let isToday                                  v = SetConstantValue<_> (Properties.CalendarDayButton.isToday, v)
      let isSelected                               v = SetConstantValue<_> (Properties.CalendarDayButton.isSelected, v)
      let isInactive                               v = SetConstantValue<_> (Properties.CalendarDayButton.isInactive, v)
      let isBlackedOut                             v = SetConstantValue<_> (Properties.CalendarDayButton.isBlackedOut, v)
      let isHighlighted                            v = SetConstantValue<_> (Properties.CalendarDayButton.isHighlighted, v)

    let calendarItem                             values =
      StandardView<CalendarItem> (values) :> View
    module CalendarItem = 
      open Dummy

    let canvas                                   values children =
      StandardPanelView<Canvas> (values, children) :> View
    module Canvas = 
      open Dummy
      let left                                     v = SetConstantValue<_> (Properties.Canvas.left, v)
      let top                                      v = SetConstantValue<_> (Properties.Canvas.top, v)
      let right                                    v = SetConstantValue<_> (Properties.Canvas.right, v)
      let bottom                                   v = SetConstantValue<_> (Properties.Canvas.bottom, v)

    let checkBox                                 values child =
      StandardContentView<CheckBox> (values, child) :> View
    module CheckBox = 
      open Dummy

    let comboBox                                 values =
      StandardView<ComboBox> (values) :> View
    module ComboBox = 
      open Dummy
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
      
      let private onDropDownOpened_r (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownOpened.AddHandler    (System.EventHandler h)
      let private onDropDownOpened_u (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownOpened.RemoveHandler (System.EventHandler h)
      let private onDropDownOpened_rf = onDropDownOpened_r
      let private onDropDownOpened_uf = onDropDownOpened_u
      let onDropDownOpened                         (f : System.Windows.Controls.ComboBox -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ComboBox, System.EventHandler, System.EventArgs> (onDropDownOpened_rf, onDropDownOpened_uf, f)
      
      let private onDropDownClosed_r (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownClosed.AddHandler    (System.EventHandler h)
      let private onDropDownClosed_u (o : System.Windows.Controls.ComboBox) (h : obj -> System.EventArgs -> unit) = o.DropDownClosed.RemoveHandler (System.EventHandler h)
      let private onDropDownClosed_rf = onDropDownClosed_r
      let private onDropDownClosed_uf = onDropDownClosed_u
      let onDropDownClosed                         (f : System.Windows.Controls.ComboBox -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ComboBox, System.EventHandler, System.EventArgs> (onDropDownClosed_rf, onDropDownClosed_uf, f)

    let comboBoxItem                             values child =
      StandardContentView<ComboBoxItem> (values, child) :> View
    module ComboBoxItem = 
      open Dummy
      let isHighlighted                            v = SetConstantValue<_> (Properties.ComboBoxItem.isHighlighted, v)

    let contentControl                           values =
      StandardView<ContentControl> (values) :> View
    module ContentControl = 
      open Dummy
      let content                                  v = SetConstantValue<_> (Properties.ContentControl.content, v)
      let hasContent                               v = SetConstantValue<_> (Properties.ContentControl.hasContent, v)
      let contentTemplate                          v = SetConstantValue<_> (Properties.ContentControl.contentTemplate, v)
      let contentTemplateSelector                  v = SetConstantValue<_> (Properties.ContentControl.contentTemplateSelector, v)
      let contentStringFormat                      v = SetConstantValue<_> (Properties.ContentControl.contentStringFormat, v)

    let contentPresenter                         values =
      StandardView<ContentPresenter> (values) :> View
    module ContentPresenter = 
      open Dummy
      let recognizesAccessKey                      v = SetConstantValue<_> (Properties.ContentPresenter.recognizesAccessKey, v)
      let content                                  v = SetConstantValue<_> (Properties.ContentPresenter.content, v)
      let contentTemplate                          v = SetConstantValue<_> (Properties.ContentPresenter.contentTemplate, v)
      let contentTemplateSelector                  v = SetConstantValue<_> (Properties.ContentPresenter.contentTemplateSelector, v)
      let contentStringFormat                      v = SetConstantValue<_> (Properties.ContentPresenter.contentStringFormat, v)
      let contentSource                            v = SetConstantValue<_> (Properties.ContentPresenter.contentSource, v)

    let contextMenu                              values =
      StandardView<ContextMenu> (values) :> View
    module ContextMenu = 
      open Dummy
      let horizontalOffset                         v = SetConstantValue<_> (Properties.ContextMenu.horizontalOffset, v)
      let verticalOffset                           v = SetConstantValue<_> (Properties.ContextMenu.verticalOffset, v)
      let isOpen                                   v = SetConstantValue<_> (Properties.ContextMenu.isOpen, v)
      let placementTarget                          v = SetConstantValue<_> (Properties.ContextMenu.placementTarget, v)
      let placementRectangle                       v = SetConstantValue<_> (Properties.ContextMenu.placementRectangle, v)
      let placement                                v = SetConstantValue<_> (Properties.ContextMenu.placement, v)
      let hasDropShadow                            v = SetConstantValue<_> (Properties.ContextMenu.hasDropShadow, v)
      let customPopupPlacementCallback             v = SetConstantValue<_> (Properties.ContextMenu.customPopupPlacementCallback, v)
      let staysOpen                                v = SetConstantValue<_> (Properties.ContextMenu.staysOpen, v)
      
      let private onOpened_r (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onOpened_u (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onOpened_rf = onOpened_r
      let private onOpened_uf = onOpened_u
      let onOpened                                 (f : System.Windows.Controls.ContextMenu -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ContextMenu, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onOpened_rf, onOpened_uf, f)
      
      let private onClosed_r (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onClosed_u (o : System.Windows.Controls.ContextMenu) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onClosed_rf = onClosed_r
      let private onClosed_uf = onClosed_u
      let onClosed                                 (f : System.Windows.Controls.ContextMenu -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ContextMenu, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onClosed_rf, onClosed_uf, f)

    let control                                  values =
      StandardView<Control> (values) :> View
    module Control = 
      open Dummy
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
      
      let private onPreviewMouseDoubleClick_r (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDoubleClick.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseDoubleClick_u (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDoubleClick.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseDoubleClick_rf = onPreviewMouseDoubleClick_r
      let private onPreviewMouseDoubleClick_uf = onPreviewMouseDoubleClick_u
      let onPreviewMouseDoubleClick                (f : System.Windows.Controls.Control -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onPreviewMouseDoubleClick_rf, onPreviewMouseDoubleClick_uf, f)
      
      let private onMouseDoubleClick_r (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDoubleClick.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseDoubleClick_u (o : System.Windows.Controls.Control) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDoubleClick.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseDoubleClick_rf = onMouseDoubleClick_r
      let private onMouseDoubleClick_uf = onMouseDoubleClick_u
      let onMouseDoubleClick                       (f : System.Windows.Controls.Control -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Control, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onMouseDoubleClick_rf, onMouseDoubleClick_uf, f)

    let dataGrid                                 values =
      StandardView<DataGrid> (values) :> View
    module DataGrid = 
      open Dummy
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
      
      let private onColumnDisplayIndexChanged_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnDisplayIndexChanged.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
      let private onColumnDisplayIndexChanged_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnDisplayIndexChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
      let private onColumnDisplayIndexChanged_rf = onColumnDisplayIndexChanged_r
      let private onColumnDisplayIndexChanged_uf = onColumnDisplayIndexChanged_u
      let onColumnDisplayIndexChanged              (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridColumnEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs>, System.Windows.Controls.DataGridColumnEventArgs> (onColumnDisplayIndexChanged_rf, onColumnDisplayIndexChanged_uf, f)
      
      let private onLoadingRow_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.LoadingRow.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
      let private onLoadingRow_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.LoadingRow.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
      let private onLoadingRow_rf = onLoadingRow_r
      let private onLoadingRow_uf = onLoadingRow_u
      let onLoadingRow                             (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>, System.Windows.Controls.DataGridRowEventArgs> (onLoadingRow_rf, onLoadingRow_uf, f)
      
      let private onUnloadingRow_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.UnloadingRow.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
      let private onUnloadingRow_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEventArgs -> unit) = o.UnloadingRow.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowEventArgs> h)
      let private onUnloadingRow_rf = onUnloadingRow_r
      let private onUnloadingRow_uf = onUnloadingRow_u
      let onUnloadingRow                           (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>, System.Windows.Controls.DataGridRowEventArgs> (onUnloadingRow_rf, onUnloadingRow_uf, f)
      
      let private onRowEditEnding_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEditEndingEventArgs -> unit) = o.RowEditEnding.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs> h)
      let private onRowEditEnding_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowEditEndingEventArgs -> unit) = o.RowEditEnding.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs> h)
      let private onRowEditEnding_rf = onRowEditEnding_r
      let private onRowEditEnding_uf = onRowEditEnding_u
      let onRowEditEnding                          (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowEditEndingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>, System.Windows.Controls.DataGridRowEditEndingEventArgs> (onRowEditEnding_rf, onRowEditEnding_uf, f)
      
      let private onCellEditEnding_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridCellEditEndingEventArgs -> unit) = o.CellEditEnding.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs> h)
      let private onCellEditEnding_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridCellEditEndingEventArgs -> unit) = o.CellEditEnding.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs> h)
      let private onCellEditEnding_rf = onCellEditEnding_r
      let private onCellEditEnding_uf = onCellEditEnding_u
      let onCellEditEnding                         (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridCellEditEndingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>, System.Windows.Controls.DataGridCellEditEndingEventArgs> (onCellEditEnding_rf, onCellEditEnding_uf, f)
      
      let private onCurrentCellChanged_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.CurrentCellChanged.AddHandler    (System.EventHandler<System.EventArgs> h)
      let private onCurrentCellChanged_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.CurrentCellChanged.RemoveHandler (System.EventHandler<System.EventArgs> h)
      let private onCurrentCellChanged_rf = onCurrentCellChanged_r
      let private onCurrentCellChanged_uf = onCurrentCellChanged_u
      let onCurrentCellChanged                     (f : System.Windows.Controls.DataGrid -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.EventArgs>, System.EventArgs> (onCurrentCellChanged_rf, onCurrentCellChanged_uf, f)
      
      let private onBeginningEdit_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridBeginningEditEventArgs -> unit) = o.BeginningEdit.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs> h)
      let private onBeginningEdit_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridBeginningEditEventArgs -> unit) = o.BeginningEdit.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs> h)
      let private onBeginningEdit_rf = onBeginningEdit_r
      let private onBeginningEdit_uf = onBeginningEdit_u
      let onBeginningEdit                          (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridBeginningEditEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>, System.Windows.Controls.DataGridBeginningEditEventArgs> (onBeginningEdit_rf, onBeginningEdit_uf, f)
      
      let private onPreparingCellForEdit_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridPreparingCellForEditEventArgs -> unit) = o.PreparingCellForEdit.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs> h)
      let private onPreparingCellForEdit_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridPreparingCellForEditEventArgs -> unit) = o.PreparingCellForEdit.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs> h)
      let private onPreparingCellForEdit_rf = onPreparingCellForEdit_r
      let private onPreparingCellForEdit_uf = onPreparingCellForEdit_u
      let onPreparingCellForEdit                   (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridPreparingCellForEditEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>, System.Windows.Controls.DataGridPreparingCellForEditEventArgs> (onPreparingCellForEdit_rf, onPreparingCellForEdit_uf, f)
      
      let private onAddingNewItem_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.AddingNewItemEventArgs -> unit) = o.AddingNewItem.AddHandler    (System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs> h)
      let private onAddingNewItem_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.AddingNewItemEventArgs -> unit) = o.AddingNewItem.RemoveHandler (System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs> h)
      let private onAddingNewItem_rf = onAddingNewItem_r
      let private onAddingNewItem_uf = onAddingNewItem_u
      let onAddingNewItem                          (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.AddingNewItemEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs>, System.Windows.Controls.AddingNewItemEventArgs> (onAddingNewItem_rf, onAddingNewItem_uf, f)
      
      let private onInitializingNewItem_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.InitializingNewItemEventArgs -> unit) = o.InitializingNewItem.AddHandler    (System.Windows.Controls.InitializingNewItemEventHandler h)
      let private onInitializingNewItem_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.InitializingNewItemEventArgs -> unit) = o.InitializingNewItem.RemoveHandler (System.Windows.Controls.InitializingNewItemEventHandler h)
      let private onInitializingNewItem_rf = onInitializingNewItem_r
      let private onInitializingNewItem_uf = onInitializingNewItem_u
      let onInitializingNewItem                    (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.InitializingNewItemEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.InitializingNewItemEventHandler, System.Windows.Controls.InitializingNewItemEventArgs> (onInitializingNewItem_rf, onInitializingNewItem_uf, f)
      
      let private onLoadingRowDetails_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.LoadingRowDetails.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
      let private onLoadingRowDetails_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.LoadingRowDetails.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
      let private onLoadingRowDetails_rf = onLoadingRowDetails_r
      let private onLoadingRowDetails_uf = onLoadingRowDetails_u
      let onLoadingRowDetails                      (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowDetailsEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs> (onLoadingRowDetails_rf, onLoadingRowDetails_uf, f)
      
      let private onUnloadingRowDetails_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.UnloadingRowDetails.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
      let private onUnloadingRowDetails_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.UnloadingRowDetails.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
      let private onUnloadingRowDetails_rf = onUnloadingRowDetails_r
      let private onUnloadingRowDetails_uf = onUnloadingRowDetails_u
      let onUnloadingRowDetails                    (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowDetailsEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs> (onUnloadingRowDetails_rf, onUnloadingRowDetails_uf, f)
      
      let private onRowDetailsVisibilityChanged_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.RowDetailsVisibilityChanged.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
      let private onRowDetailsVisibilityChanged_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowDetailsEventArgs -> unit) = o.RowDetailsVisibilityChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs> h)
      let private onRowDetailsVisibilityChanged_rf = onRowDetailsVisibilityChanged_r
      let private onRowDetailsVisibilityChanged_uf = onRowDetailsVisibilityChanged_u
      let onRowDetailsVisibilityChanged            (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowDetailsEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs> (onRowDetailsVisibilityChanged_rf, onRowDetailsVisibilityChanged_uf, f)
      
      let private onSelectedCellsChanged_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.SelectedCellsChangedEventArgs -> unit) = o.SelectedCellsChanged.AddHandler    (System.Windows.Controls.SelectedCellsChangedEventHandler h)
      let private onSelectedCellsChanged_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.SelectedCellsChangedEventArgs -> unit) = o.SelectedCellsChanged.RemoveHandler (System.Windows.Controls.SelectedCellsChangedEventHandler h)
      let private onSelectedCellsChanged_rf = onSelectedCellsChanged_r
      let private onSelectedCellsChanged_uf = onSelectedCellsChanged_u
      let onSelectedCellsChanged                   (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.SelectedCellsChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.SelectedCellsChangedEventHandler, System.Windows.Controls.SelectedCellsChangedEventArgs> (onSelectedCellsChanged_rf, onSelectedCellsChanged_uf, f)
      
      let private onSorting_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridSortingEventArgs -> unit) = o.Sorting.AddHandler    (System.Windows.Controls.DataGridSortingEventHandler h)
      let private onSorting_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridSortingEventArgs -> unit) = o.Sorting.RemoveHandler (System.Windows.Controls.DataGridSortingEventHandler h)
      let private onSorting_rf = onSorting_r
      let private onSorting_uf = onSorting_u
      let onSorting                                (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridSortingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.Windows.Controls.DataGridSortingEventHandler, System.Windows.Controls.DataGridSortingEventArgs> (onSorting_rf, onSorting_uf, f)
      
      let private onAutoGeneratedColumns_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.AutoGeneratedColumns.AddHandler    (System.EventHandler h)
      let private onAutoGeneratedColumns_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.EventArgs -> unit) = o.AutoGeneratedColumns.RemoveHandler (System.EventHandler h)
      let private onAutoGeneratedColumns_rf = onAutoGeneratedColumns_r
      let private onAutoGeneratedColumns_uf = onAutoGeneratedColumns_u
      let onAutoGeneratedColumns                   (f : System.Windows.Controls.DataGrid -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler, System.EventArgs> (onAutoGeneratedColumns_rf, onAutoGeneratedColumns_uf, f)
      
      let private onAutoGeneratingColumn_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs -> unit) = o.AutoGeneratingColumn.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> h)
      let private onAutoGeneratingColumn_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs -> unit) = o.AutoGeneratingColumn.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> h)
      let private onAutoGeneratingColumn_rf = onAutoGeneratingColumn_r
      let private onAutoGeneratingColumn_uf = onAutoGeneratingColumn_u
      let onAutoGeneratingColumn                   (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> (onAutoGeneratingColumn_rf, onAutoGeneratingColumn_uf, f)
      
      let private onColumnReordering_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnReorderingEventArgs -> unit) = o.ColumnReordering.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridColumnReorderingEventArgs> h)
      let private onColumnReordering_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnReorderingEventArgs -> unit) = o.ColumnReordering.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridColumnReorderingEventArgs> h)
      let private onColumnReordering_rf = onColumnReordering_r
      let private onColumnReordering_uf = onColumnReordering_u
      let onColumnReordering                       (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridColumnReorderingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridColumnReorderingEventArgs>, System.Windows.Controls.DataGridColumnReorderingEventArgs> (onColumnReordering_rf, onColumnReordering_uf, f)
      
      let private onColumnHeaderDragStarted_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.ColumnHeaderDragStarted.AddHandler    (System.EventHandler<System.Windows.Controls.Primitives.DragStartedEventArgs> h)
      let private onColumnHeaderDragStarted_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.ColumnHeaderDragStarted.RemoveHandler (System.EventHandler<System.Windows.Controls.Primitives.DragStartedEventArgs> h)
      let private onColumnHeaderDragStarted_rf = onColumnHeaderDragStarted_r
      let private onColumnHeaderDragStarted_uf = onColumnHeaderDragStarted_u
      let onColumnHeaderDragStarted                (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.Primitives.DragStartedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.Primitives.DragStartedEventArgs>, System.Windows.Controls.Primitives.DragStartedEventArgs> (onColumnHeaderDragStarted_rf, onColumnHeaderDragStarted_uf, f)
      
      let private onColumnHeaderDragDelta_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.ColumnHeaderDragDelta.AddHandler    (System.EventHandler<System.Windows.Controls.Primitives.DragDeltaEventArgs> h)
      let private onColumnHeaderDragDelta_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.ColumnHeaderDragDelta.RemoveHandler (System.EventHandler<System.Windows.Controls.Primitives.DragDeltaEventArgs> h)
      let private onColumnHeaderDragDelta_rf = onColumnHeaderDragDelta_r
      let private onColumnHeaderDragDelta_uf = onColumnHeaderDragDelta_u
      let onColumnHeaderDragDelta                  (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.Primitives.DragDeltaEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.Primitives.DragDeltaEventArgs>, System.Windows.Controls.Primitives.DragDeltaEventArgs> (onColumnHeaderDragDelta_rf, onColumnHeaderDragDelta_uf, f)
      
      let private onColumnHeaderDragCompleted_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.ColumnHeaderDragCompleted.AddHandler    (System.EventHandler<System.Windows.Controls.Primitives.DragCompletedEventArgs> h)
      let private onColumnHeaderDragCompleted_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.ColumnHeaderDragCompleted.RemoveHandler (System.EventHandler<System.Windows.Controls.Primitives.DragCompletedEventArgs> h)
      let private onColumnHeaderDragCompleted_rf = onColumnHeaderDragCompleted_r
      let private onColumnHeaderDragCompleted_uf = onColumnHeaderDragCompleted_u
      let onColumnHeaderDragCompleted              (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.Primitives.DragCompletedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.Primitives.DragCompletedEventArgs>, System.Windows.Controls.Primitives.DragCompletedEventArgs> (onColumnHeaderDragCompleted_rf, onColumnHeaderDragCompleted_uf, f)
      
      let private onColumnReordered_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnReordered.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
      let private onColumnReordered_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridColumnEventArgs -> unit) = o.ColumnReordered.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs> h)
      let private onColumnReordered_rf = onColumnReordered_r
      let private onColumnReordered_uf = onColumnReordered_u
      let onColumnReordered                        (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridColumnEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs>, System.Windows.Controls.DataGridColumnEventArgs> (onColumnReordered_rf, onColumnReordered_uf, f)
      
      let private onCopyingRowClipboardContent_r (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowClipboardEventArgs -> unit) = o.CopyingRowClipboardContent.AddHandler    (System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs> h)
      let private onCopyingRowClipboardContent_u (o : System.Windows.Controls.DataGrid) (h : obj -> System.Windows.Controls.DataGridRowClipboardEventArgs -> unit) = o.CopyingRowClipboardContent.RemoveHandler (System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs> h)
      let private onCopyingRowClipboardContent_rf = onCopyingRowClipboardContent_r
      let private onCopyingRowClipboardContent_uf = onCopyingRowClipboardContent_u
      let onCopyingRowClipboardContent             (f : System.Windows.Controls.DataGrid -> System.Windows.Controls.DataGridRowClipboardEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGrid, System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs>, System.Windows.Controls.DataGridRowClipboardEventArgs> (onCopyingRowClipboardContent_rf, onCopyingRowClipboardContent_uf, f)

    let dataGridCell                             values child =
      StandardContentView<DataGridCell> (values, child) :> View
    module DataGridCell = 
      open Dummy
      let column                                   v = SetConstantValue<_> (Properties.DataGridCell.column, v)
      let isEditing                                v = SetConstantValue<_> (Properties.DataGridCell.isEditing, v)
      let isReadOnly                               v = SetConstantValue<_> (Properties.DataGridCell.isReadOnly, v)
      let isSelected                               v = SetConstantValue<_> (Properties.DataGridCell.isSelected, v)
      
      let private onSelected_r (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onSelected_u (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onSelected_rf = onSelected_r
      let private onSelected_uf = onSelected_u
      let onSelected                               (f : System.Windows.Controls.DataGridCell -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridCell, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onSelected_rf, onSelected_uf, f)
      
      let private onUnselected_r (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onUnselected_u (o : System.Windows.Controls.DataGridCell) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onUnselected_rf = onUnselected_r
      let private onUnselected_uf = onUnselected_u
      let onUnselected                             (f : System.Windows.Controls.DataGridCell -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridCell, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onUnselected_rf, onUnselected_uf, f)

    let dataGridCellsPanel                       values children =
      StandardPanelView<DataGridCellsPanel> (values, children) :> View
    module DataGridCellsPanel = 
      open Dummy

    let dataGridCellsPresenter                   values =
      StandardView<DataGridCellsPresenter> (values) :> View
    module DataGridCellsPresenter = 
      open Dummy

    let dataGridColumnHeader                     values child =
      StandardContentView<DataGridColumnHeader> (values, child) :> View
    module DataGridColumnHeader = 
      open Dummy
      let separatorBrush                           v = SetConstantValue<_> (Properties.DataGridColumnHeader.separatorBrush, v)
      let separatorVisibility                      v = SetConstantValue<_> (Properties.DataGridColumnHeader.separatorVisibility, v)
      let displayIndex                             v = SetConstantValue<_> (Properties.DataGridColumnHeader.displayIndex, v)
      let canUserSort                              v = SetConstantValue<_> (Properties.DataGridColumnHeader.canUserSort, v)
      let sortDirection                            v = SetConstantValue<_> (Properties.DataGridColumnHeader.sortDirection, v)
      let isFrozen                                 v = SetConstantValue<_> (Properties.DataGridColumnHeader.isFrozen, v)

    let dataGridColumnHeadersPresenter           values =
      StandardView<DataGridColumnHeadersPresenter> (values) :> View
    module DataGridColumnHeadersPresenter = 
      open Dummy

    let dataGridDetailsPresenter                 values =
      StandardView<DataGridDetailsPresenter> (values) :> View
    module DataGridDetailsPresenter = 
      open Dummy

    let dataGridRow                              values =
      StandardView<DataGridRow> (values) :> View
    module DataGridRow = 
      open Dummy
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
      
      let private onSelected_r (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onSelected_u (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onSelected_rf = onSelected_r
      let private onSelected_uf = onSelected_u
      let onSelected                               (f : System.Windows.Controls.DataGridRow -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridRow, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onSelected_rf, onSelected_uf, f)
      
      let private onUnselected_r (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onUnselected_u (o : System.Windows.Controls.DataGridRow) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onUnselected_rf = onUnselected_r
      let private onUnselected_uf = onUnselected_u
      let onUnselected                             (f : System.Windows.Controls.DataGridRow -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DataGridRow, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onUnselected_rf, onUnselected_uf, f)

    let dataGridRowHeader                        values child =
      StandardContentView<DataGridRowHeader> (values, child) :> View
    module DataGridRowHeader = 
      open Dummy
      let separatorBrush                           v = SetConstantValue<_> (Properties.DataGridRowHeader.separatorBrush, v)
      let separatorVisibility                      v = SetConstantValue<_> (Properties.DataGridRowHeader.separatorVisibility, v)
      let isRowSelected                            v = SetConstantValue<_> (Properties.DataGridRowHeader.isRowSelected, v)

    let dataGridRowsPresenter                    values children =
      StandardPanelView<DataGridRowsPresenter> (values, children) :> View
    module DataGridRowsPresenter = 
      open Dummy

    let datePicker                               values =
      StandardView<DatePicker> (values) :> View
    module DatePicker = 
      open Dummy
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
      
      let private onCalendarClosed_r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarClosed.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onCalendarClosed_u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarClosed.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onCalendarClosed_rf = onCalendarClosed_r
      let private onCalendarClosed_uf = onCalendarClosed_u
      let onCalendarClosed                         (f : System.Windows.Controls.DatePicker -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onCalendarClosed_rf, onCalendarClosed_uf, f)
      
      let private onCalendarOpened_r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarOpened.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onCalendarOpened_u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.CalendarOpened.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onCalendarOpened_rf = onCalendarOpened_r
      let private onCalendarOpened_uf = onCalendarOpened_u
      let onCalendarOpened                         (f : System.Windows.Controls.DatePicker -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onCalendarOpened_rf, onCalendarOpened_uf, f)
      
      let private onDateValidationError_r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.DatePickerDateValidationErrorEventArgs -> unit) = o.DateValidationError.AddHandler    (System.EventHandler<System.Windows.Controls.DatePickerDateValidationErrorEventArgs> h)
      let private onDateValidationError_u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.DatePickerDateValidationErrorEventArgs -> unit) = o.DateValidationError.RemoveHandler (System.EventHandler<System.Windows.Controls.DatePickerDateValidationErrorEventArgs> h)
      let private onDateValidationError_rf = onDateValidationError_r
      let private onDateValidationError_uf = onDateValidationError_u
      let onDateValidationError                    (f : System.Windows.Controls.DatePicker -> System.Windows.Controls.DatePickerDateValidationErrorEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.DatePickerDateValidationErrorEventArgs>, System.Windows.Controls.DatePickerDateValidationErrorEventArgs> (onDateValidationError_rf, onDateValidationError_uf, f)
      
      let private onSelectedDateChanged_r (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDateChanged.AddHandler    (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
      let private onSelectedDateChanged_u (o : System.Windows.Controls.DatePicker) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectedDateChanged.RemoveHandler (System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs> h)
      let private onSelectedDateChanged_rf = onSelectedDateChanged_r
      let private onSelectedDateChanged_uf = onSelectedDateChanged_u
      let onSelectedDateChanged                    (f : System.Windows.Controls.DatePicker -> System.Windows.Controls.SelectionChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.DatePicker, System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs> (onSelectedDateChanged_rf, onSelectedDateChanged_uf, f)

    let datePickerTextBox                        values =
      StandardView<DatePickerTextBox> (values) :> View
    module DatePickerTextBox = 
      open Dummy

    let decorator                                values =
      StandardView<Decorator> (values) :> View
    module Decorator = 
      open Dummy

    let dockPanel                                values children =
      StandardPanelView<DockPanel> (values, children) :> View
    module DockPanel = 
      open Dummy
      let lastChildFill                            v = SetConstantValue<_> (Properties.DockPanel.lastChildFill, v)
      let dock                                     v = SetConstantValue<_> (Properties.DockPanel.dock, v)

    let documentPageView                         values =
      StandardView<DocumentPageView> (values) :> View
    module DocumentPageView = 
      open Dummy
      let pageNumber                               v = SetConstantValue<_> (Properties.DocumentPageView.pageNumber, v)
      let stretch                                  v = SetConstantValue<_> (Properties.DocumentPageView.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.DocumentPageView.stretchDirection, v)
      
      let private onPageConnected_r (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageConnected.AddHandler    (System.EventHandler h)
      let private onPageConnected_u (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageConnected.RemoveHandler (System.EventHandler h)
      let private onPageConnected_rf = onPageConnected_r
      let private onPageConnected_uf = onPageConnected_u
      let onPageConnected                          (f : System.Windows.Controls.Primitives.DocumentPageView -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.EventHandler, System.EventArgs> (onPageConnected_rf, onPageConnected_uf, f)
      
      let private onPageDisconnected_r (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageDisconnected.AddHandler    (System.EventHandler h)
      let private onPageDisconnected_u (o : System.Windows.Controls.Primitives.DocumentPageView) (h : obj -> System.EventArgs -> unit) = o.PageDisconnected.RemoveHandler (System.EventHandler h)
      let private onPageDisconnected_rf = onPageDisconnected_r
      let private onPageDisconnected_uf = onPageDisconnected_u
      let onPageDisconnected                       (f : System.Windows.Controls.Primitives.DocumentPageView -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.DocumentPageView, System.EventHandler, System.EventArgs> (onPageDisconnected_rf, onPageDisconnected_uf, f)

    let documentReference                        values =
      StandardView<DocumentReference> (values) :> View
    module DocumentReference = 
      open Dummy
      let source                                   v = SetConstantValue<_> (Properties.DocumentReference.source, v)

    let documentViewer                           values =
      StandardView<DocumentViewer> (values) :> View
    module DocumentViewer = 
      open Dummy
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
      open Dummy
      let document                                 v = SetConstantValue<_> (Properties.DocumentViewerBase.document, v)
      let pageCount                                v = SetConstantValue<_> (Properties.DocumentViewerBase.pageCount, v)
      let masterPageNumber                         v = SetConstantValue<_> (Properties.DocumentViewerBase.masterPageNumber, v)
      let canGoToPreviousPage                      v = SetConstantValue<_> (Properties.DocumentViewerBase.canGoToPreviousPage, v)
      let canGoToNextPage                          v = SetConstantValue<_> (Properties.DocumentViewerBase.canGoToNextPage, v)
      let isMasterPage                             v = SetConstantValue<_> (Properties.DocumentViewerBase.isMasterPage, v)
      
      let private onPageViewsChanged_r (o : System.Windows.Controls.Primitives.DocumentViewerBase) (h : obj -> System.EventArgs -> unit) = o.PageViewsChanged.AddHandler    (System.EventHandler h)
      let private onPageViewsChanged_u (o : System.Windows.Controls.Primitives.DocumentViewerBase) (h : obj -> System.EventArgs -> unit) = o.PageViewsChanged.RemoveHandler (System.EventHandler h)
      let private onPageViewsChanged_rf = onPageViewsChanged_r
      let private onPageViewsChanged_uf = onPageViewsChanged_u
      let onPageViewsChanged                       (f : System.Windows.Controls.Primitives.DocumentViewerBase -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.DocumentViewerBase, System.EventHandler, System.EventArgs> (onPageViewsChanged_rf, onPageViewsChanged_uf, f)

    let ellipse                                  values =
      StandardView<Ellipse> (values) :> View
    module Ellipse = 
      open Dummy

    let expander                                 values child =
      StandardContentView<Expander> (values, child) :> View
    module Expander = 
      open Dummy
      let expandDirection                          v = SetConstantValue<_> (Properties.Expander.expandDirection, v)
      let isExpanded                               v = SetConstantValue<_> (Properties.Expander.isExpanded, v)
      
      let private onExpanded_r (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onExpanded_u (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onExpanded_rf = onExpanded_r
      let private onExpanded_uf = onExpanded_u
      let onExpanded                               (f : System.Windows.Controls.Expander -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Expander, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onExpanded_rf, onExpanded_uf, f)
      
      let private onCollapsed_r (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onCollapsed_u (o : System.Windows.Controls.Expander) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onCollapsed_rf = onCollapsed_r
      let private onCollapsed_uf = onCollapsed_u
      let onCollapsed                              (f : System.Windows.Controls.Expander -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Expander, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onCollapsed_rf, onCollapsed_uf, f)

    let fixedPage                                values =
      StandardView<FixedPage> (values) :> View
    module FixedPage = 
      open Dummy
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
      open Dummy
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
      open Dummy
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
      open Dummy
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
      open Dummy
      let source                                   v = SetConstantValue<_> (Properties.Frame.source, v)
      let canGoBack                                v = SetConstantValue<_> (Properties.Frame.canGoBack, v)
      let canGoForward                             v = SetConstantValue<_> (Properties.Frame.canGoForward, v)
      let backStack                                v = SetConstantValue<_> (Properties.Frame.backStack, v)
      let forwardStack                             v = SetConstantValue<_> (Properties.Frame.forwardStack, v)
      let navigationUIVisibility                   v = SetConstantValue<_> (Properties.Frame.navigationUIVisibility, v)
      let sandboxExternalContent                   v = SetConstantValue<_> (Properties.Frame.sandboxExternalContent, v)
      let journalOwnership                         v = SetConstantValue<_> (Properties.Frame.journalOwnership, v)
      
      let private onContentRendered_r (o : System.Windows.Controls.Frame) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.AddHandler    (System.EventHandler h)
      let private onContentRendered_u (o : System.Windows.Controls.Frame) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.RemoveHandler (System.EventHandler h)
      let private onContentRendered_rf = onContentRendered_r
      let private onContentRendered_uf = onContentRendered_u
      let onContentRendered                        (f : System.Windows.Controls.Frame -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.EventHandler, System.EventArgs> (onContentRendered_rf, onContentRendered_uf, f)
      
      let private onNavigating_r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.AddHandler    (System.Windows.Navigation.NavigatingCancelEventHandler h)
      let private onNavigating_u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.RemoveHandler (System.Windows.Navigation.NavigatingCancelEventHandler h)
      let private onNavigating_rf = onNavigating_r
      let private onNavigating_uf = onNavigating_u
      let onNavigating                             (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigatingCancelEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs> (onNavigating_rf, onNavigating_uf, f)
      
      let private onNavigationProgress_r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.AddHandler    (System.Windows.Navigation.NavigationProgressEventHandler h)
      let private onNavigationProgress_u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.RemoveHandler (System.Windows.Navigation.NavigationProgressEventHandler h)
      let private onNavigationProgress_rf = onNavigationProgress_r
      let private onNavigationProgress_uf = onNavigationProgress_u
      let onNavigationProgress                     (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationProgressEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs> (onNavigationProgress_rf, onNavigationProgress_uf, f)
      
      let private onNavigationFailed_r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.AddHandler    (System.Windows.Navigation.NavigationFailedEventHandler h)
      let private onNavigationFailed_u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.RemoveHandler (System.Windows.Navigation.NavigationFailedEventHandler h)
      let private onNavigationFailed_rf = onNavigationFailed_r
      let private onNavigationFailed_uf = onNavigationFailed_u
      let onNavigationFailed                       (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationFailedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs> (onNavigationFailed_rf, onNavigationFailed_uf, f)
      
      let private onNavigated_r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.AddHandler    (System.Windows.Navigation.NavigatedEventHandler h)
      let private onNavigated_u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.RemoveHandler (System.Windows.Navigation.NavigatedEventHandler h)
      let private onNavigated_rf = onNavigated_r
      let private onNavigated_uf = onNavigated_u
      let onNavigated                              (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onNavigated_rf, onNavigated_uf, f)
      
      let private onLoadCompleted_r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.AddHandler    (System.Windows.Navigation.LoadCompletedEventHandler h)
      let private onLoadCompleted_u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.RemoveHandler (System.Windows.Navigation.LoadCompletedEventHandler h)
      let private onLoadCompleted_rf = onLoadCompleted_r
      let private onLoadCompleted_uf = onLoadCompleted_u
      let onLoadCompleted                          (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onLoadCompleted_rf, onLoadCompleted_uf, f)
      
      let private onNavigationStopped_r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.AddHandler    (System.Windows.Navigation.NavigationStoppedEventHandler h)
      let private onNavigationStopped_u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.RemoveHandler (System.Windows.Navigation.NavigationStoppedEventHandler h)
      let private onNavigationStopped_rf = onNavigationStopped_r
      let private onNavigationStopped_uf = onNavigationStopped_u
      let onNavigationStopped                      (f : System.Windows.Controls.Frame -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onNavigationStopped_rf, onNavigationStopped_uf, f)
      
      let private onFragmentNavigation_r (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.AddHandler    (System.Windows.Navigation.FragmentNavigationEventHandler h)
      let private onFragmentNavigation_u (o : System.Windows.Controls.Frame) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.RemoveHandler (System.Windows.Navigation.FragmentNavigationEventHandler h)
      let private onFragmentNavigation_rf = onFragmentNavigation_r
      let private onFragmentNavigation_uf = onFragmentNavigation_u
      let onFragmentNavigation                     (f : System.Windows.Controls.Frame -> System.Windows.Navigation.FragmentNavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Frame, System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs> (onFragmentNavigation_rf, onFragmentNavigation_uf, f)

    let frameworkElement                         values =
      StandardView<FrameworkElement> (values) :> View
    module FrameworkElement = 
      open Dummy
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
      
      let private onTargetUpdated_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.TargetUpdated.AddHandler    (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
      let private onTargetUpdated_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.TargetUpdated.RemoveHandler (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
      let private onTargetUpdated_rf = onTargetUpdated_r
      let private onTargetUpdated_uf = onTargetUpdated_u
      let onTargetUpdated                          (f : System.Windows.FrameworkElement -> System.Windows.Data.DataTransferEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs> (onTargetUpdated_rf, onTargetUpdated_uf, f)
      
      let private onSourceUpdated_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.SourceUpdated.AddHandler    (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
      let private onSourceUpdated_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Data.DataTransferEventArgs -> unit) = o.SourceUpdated.RemoveHandler (System.EventHandler<System.Windows.Data.DataTransferEventArgs> h)
      let private onSourceUpdated_rf = onSourceUpdated_r
      let private onSourceUpdated_uf = onSourceUpdated_u
      let onSourceUpdated                          (f : System.Windows.FrameworkElement -> System.Windows.Data.DataTransferEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs> (onSourceUpdated_rf, onSourceUpdated_uf, f)
      
      let private onDataContextChanged_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.DataContextChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onDataContextChanged_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.DataContextChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onDataContextChanged_rf = onDataContextChanged_r
      let private onDataContextChanged_uf = onDataContextChanged_u
      let onDataContextChanged                     (f : System.Windows.FrameworkElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onDataContextChanged_rf, onDataContextChanged_uf, f)
      
      let private onRequestBringIntoView_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RequestBringIntoViewEventArgs -> unit) = o.RequestBringIntoView.AddHandler    (System.Windows.RequestBringIntoViewEventHandler h)
      let private onRequestBringIntoView_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RequestBringIntoViewEventArgs -> unit) = o.RequestBringIntoView.RemoveHandler (System.Windows.RequestBringIntoViewEventHandler h)
      let private onRequestBringIntoView_rf = onRequestBringIntoView_r
      let private onRequestBringIntoView_uf = onRequestBringIntoView_u
      let onRequestBringIntoView                   (f : System.Windows.FrameworkElement -> System.Windows.RequestBringIntoViewEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs> (onRequestBringIntoView_rf, onRequestBringIntoView_uf, f)
      
      let private onSizeChanged_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.SizeChangedEventArgs -> unit) = o.SizeChanged.AddHandler    (System.Windows.SizeChangedEventHandler h)
      let private onSizeChanged_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.SizeChangedEventArgs -> unit) = o.SizeChanged.RemoveHandler (System.Windows.SizeChangedEventHandler h)
      let private onSizeChanged_rf = onSizeChanged_r
      let private onSizeChanged_uf = onSizeChanged_u
      let onSizeChanged                            (f : System.Windows.FrameworkElement -> System.Windows.SizeChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs> (onSizeChanged_rf, onSizeChanged_uf, f)
      
      let private onInitialized_r (o : System.Windows.FrameworkElement) (h : obj -> System.EventArgs -> unit) = o.Initialized.AddHandler    (System.EventHandler h)
      let private onInitialized_u (o : System.Windows.FrameworkElement) (h : obj -> System.EventArgs -> unit) = o.Initialized.RemoveHandler (System.EventHandler h)
      let private onInitialized_rf = onInitialized_r
      let private onInitialized_uf = onInitialized_u
      let onInitialized                            (f : System.Windows.FrameworkElement -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.EventHandler, System.EventArgs> (onInitialized_rf, onInitialized_uf, f)
      
      let private onLoaded_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Loaded.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onLoaded_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Loaded.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onLoaded_rf = onLoaded_r
      let private onLoaded_uf = onLoaded_u
      let onLoaded                                 (f : System.Windows.FrameworkElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onLoaded_rf, onLoaded_uf, f)
      
      let private onUnloaded_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unloaded.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onUnloaded_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unloaded.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onUnloaded_rf = onUnloaded_r
      let private onUnloaded_uf = onUnloaded_u
      let onUnloaded                               (f : System.Windows.FrameworkElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onUnloaded_rf, onUnloaded_uf, f)
      
      let private onToolTipOpening_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipOpening.AddHandler    (System.Windows.Controls.ToolTipEventHandler h)
      let private onToolTipOpening_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipOpening.RemoveHandler (System.Windows.Controls.ToolTipEventHandler h)
      let private onToolTipOpening_rf = onToolTipOpening_r
      let private onToolTipOpening_uf = onToolTipOpening_u
      let onToolTipOpening                         (f : System.Windows.FrameworkElement -> System.Windows.Controls.ToolTipEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> (onToolTipOpening_rf, onToolTipOpening_uf, f)
      
      let private onToolTipClosing_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipClosing.AddHandler    (System.Windows.Controls.ToolTipEventHandler h)
      let private onToolTipClosing_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ToolTipEventArgs -> unit) = o.ToolTipClosing.RemoveHandler (System.Windows.Controls.ToolTipEventHandler h)
      let private onToolTipClosing_rf = onToolTipClosing_r
      let private onToolTipClosing_uf = onToolTipClosing_u
      let onToolTipClosing                         (f : System.Windows.FrameworkElement -> System.Windows.Controls.ToolTipEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs> (onToolTipClosing_rf, onToolTipClosing_uf, f)
      
      let private onContextMenuOpening_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuOpening.AddHandler    (System.Windows.Controls.ContextMenuEventHandler h)
      let private onContextMenuOpening_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuOpening.RemoveHandler (System.Windows.Controls.ContextMenuEventHandler h)
      let private onContextMenuOpening_rf = onContextMenuOpening_r
      let private onContextMenuOpening_uf = onContextMenuOpening_u
      let onContextMenuOpening                     (f : System.Windows.FrameworkElement -> System.Windows.Controls.ContextMenuEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> (onContextMenuOpening_rf, onContextMenuOpening_uf, f)
      
      let private onContextMenuClosing_r (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuClosing.AddHandler    (System.Windows.Controls.ContextMenuEventHandler h)
      let private onContextMenuClosing_u (o : System.Windows.FrameworkElement) (h : obj -> System.Windows.Controls.ContextMenuEventArgs -> unit) = o.ContextMenuClosing.RemoveHandler (System.Windows.Controls.ContextMenuEventHandler h)
      let private onContextMenuClosing_rf = onContextMenuClosing_r
      let private onContextMenuClosing_uf = onContextMenuClosing_u
      let onContextMenuClosing                     (f : System.Windows.FrameworkElement -> System.Windows.Controls.ContextMenuEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.FrameworkElement, System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs> (onContextMenuClosing_rf, onContextMenuClosing_uf, f)

    let glyphs                                   values =
      StandardView<Glyphs> (values) :> View
    module Glyphs = 
      open Dummy
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
      open Dummy
      let showGridLines                            v = SetConstantValue<_> (Properties.Grid.showGridLines, v)
      let column                                   v = SetConstantValue<_> (Properties.Grid.column, v)
      let row                                      v = SetConstantValue<_> (Properties.Grid.row, v)
      let columnSpan                               v = SetConstantValue<_> (Properties.Grid.columnSpan, v)
      let rowSpan                                  v = SetConstantValue<_> (Properties.Grid.rowSpan, v)
      let isSharedSizeScope                        v = SetConstantValue<_> (Properties.Grid.isSharedSizeScope, v)

    let gridSplitter                             values =
      StandardView<GridSplitter> (values) :> View
    module GridSplitter = 
      open Dummy
      let resizeDirection                          v = SetConstantValue<_> (Properties.GridSplitter.resizeDirection, v)
      let resizeBehavior                           v = SetConstantValue<_> (Properties.GridSplitter.resizeBehavior, v)
      let showsPreview                             v = SetConstantValue<_> (Properties.GridSplitter.showsPreview, v)
      let previewStyle                             v = SetConstantValue<_> (Properties.GridSplitter.previewStyle, v)
      let keyboardIncrement                        v = SetConstantValue<_> (Properties.GridSplitter.keyboardIncrement, v)
      let dragIncrement                            v = SetConstantValue<_> (Properties.GridSplitter.dragIncrement, v)

    let gridViewColumnHeader                     values child =
      StandardContentView<GridViewColumnHeader> (values, child) :> View
    module GridViewColumnHeader = 
      open Dummy
      let column                                   v = SetConstantValue<_> (Properties.GridViewColumnHeader.column, v)
      let role                                     v = SetConstantValue<_> (Properties.GridViewColumnHeader.role, v)

    let gridViewHeaderRowPresenter               values =
      StandardView<GridViewHeaderRowPresenter> (values) :> View
    module GridViewHeaderRowPresenter = 
      open Dummy
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
      open Dummy
      let content                                  v = SetConstantValue<_> (Properties.GridViewRowPresenter.content, v)

    module GridViewRowPresenterBase = 
      open Dummy
      let columns                                  v = SetConstantValue<_> (Properties.GridViewRowPresenterBase.columns, v)

    let groupBox                                 values child =
      StandardContentView<GroupBox> (values, child) :> View
    module GroupBox = 
      open Dummy

    let groupItem                                values child =
      StandardContentView<GroupItem> (values, child) :> View
    module GroupItem = 
      open Dummy

    let headeredContentControl                   values child =
      StandardContentView<HeaderedContentControl> (values, child) :> View
    module HeaderedContentControl = 
      open Dummy
      let header                                   v = SetConstantValue<_> (Properties.HeaderedContentControl.header, v)
      let hasHeader                                v = SetConstantValue<_> (Properties.HeaderedContentControl.hasHeader, v)
      let headerTemplate                           v = SetConstantValue<_> (Properties.HeaderedContentControl.headerTemplate, v)
      let headerTemplateSelector                   v = SetConstantValue<_> (Properties.HeaderedContentControl.headerTemplateSelector, v)
      let headerStringFormat                       v = SetConstantValue<_> (Properties.HeaderedContentControl.headerStringFormat, v)

    let headeredItemsControl                     values =
      StandardView<HeaderedItemsControl> (values) :> View
    module HeaderedItemsControl = 
      open Dummy
      let header                                   v = SetConstantValue<_> (Properties.HeaderedItemsControl.header, v)
      let hasHeader                                v = SetConstantValue<_> (Properties.HeaderedItemsControl.hasHeader, v)
      let headerTemplate                           v = SetConstantValue<_> (Properties.HeaderedItemsControl.headerTemplate, v)
      let headerTemplateSelector                   v = SetConstantValue<_> (Properties.HeaderedItemsControl.headerTemplateSelector, v)
      let headerStringFormat                       v = SetConstantValue<_> (Properties.HeaderedItemsControl.headerStringFormat, v)

    let image                                    values =
      StandardView<Image> (values) :> View
    module Image = 
      open Dummy
      let source                                   v = SetConstantValue<_> (Properties.Image.source, v)
      let stretch                                  v = SetConstantValue<_> (Properties.Image.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.Image.stretchDirection, v)
      
      let private onImageFailed_r (o : System.Windows.Controls.Image) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.ImageFailed.AddHandler    (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
      let private onImageFailed_u (o : System.Windows.Controls.Image) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.ImageFailed.RemoveHandler (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
      let private onImageFailed_rf = onImageFailed_r
      let private onImageFailed_uf = onImageFailed_u
      let onImageFailed                            (f : System.Windows.Controls.Image -> System.Windows.ExceptionRoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Image, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> (onImageFailed_rf, onImageFailed_uf, f)
      
      let private onDpiChanged_r (o : System.Windows.Controls.Image) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.AddHandler    (System.Windows.DpiChangedEventHandler h)
      let private onDpiChanged_u (o : System.Windows.Controls.Image) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.RemoveHandler (System.Windows.DpiChangedEventHandler h)
      let private onDpiChanged_rf = onDpiChanged_r
      let private onDpiChanged_uf = onDpiChanged_u
      let onDpiChanged                             (f : System.Windows.Controls.Image -> System.Windows.DpiChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Image, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> (onDpiChanged_rf, onDpiChanged_uf, f)

    let inkCanvas                                values =
      StandardView<InkCanvas> (values) :> View
    module InkCanvas = 
      open Dummy
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
      
      let private onStrokeCollected_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeCollectedEventArgs -> unit) = o.StrokeCollected.AddHandler    (System.Windows.Controls.InkCanvasStrokeCollectedEventHandler h)
      let private onStrokeCollected_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeCollectedEventArgs -> unit) = o.StrokeCollected.RemoveHandler (System.Windows.Controls.InkCanvasStrokeCollectedEventHandler h)
      let private onStrokeCollected_rf = onStrokeCollected_r
      let private onStrokeCollected_uf = onStrokeCollected_u
      let onStrokeCollected                        (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasStrokeCollectedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> (onStrokeCollected_rf, onStrokeCollected_uf, f)
      
      let private onGesture_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasGestureEventArgs -> unit) = o.Gesture.AddHandler    (System.Windows.Controls.InkCanvasGestureEventHandler h)
      let private onGesture_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasGestureEventArgs -> unit) = o.Gesture.RemoveHandler (System.Windows.Controls.InkCanvasGestureEventHandler h)
      let private onGesture_rf = onGesture_r
      let private onGesture_uf = onGesture_u
      let onGesture                                (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasGestureEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs> (onGesture_rf, onGesture_uf, f)
      
      let private onStrokesReplaced_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokesReplacedEventArgs -> unit) = o.StrokesReplaced.AddHandler    (System.Windows.Controls.InkCanvasStrokesReplacedEventHandler h)
      let private onStrokesReplaced_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokesReplacedEventArgs -> unit) = o.StrokesReplaced.RemoveHandler (System.Windows.Controls.InkCanvasStrokesReplacedEventHandler h)
      let private onStrokesReplaced_rf = onStrokesReplaced_r
      let private onStrokesReplaced_uf = onStrokesReplaced_u
      let onStrokesReplaced                        (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasStrokesReplacedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasStrokesReplacedEventHandler, System.Windows.Controls.InkCanvasStrokesReplacedEventArgs> (onStrokesReplaced_rf, onStrokesReplaced_uf, f)
      
      let private onDefaultDrawingAttributesReplaced_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Ink.DrawingAttributesReplacedEventArgs -> unit) = o.DefaultDrawingAttributesReplaced.AddHandler    (System.Windows.Ink.DrawingAttributesReplacedEventHandler h)
      let private onDefaultDrawingAttributesReplaced_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Ink.DrawingAttributesReplacedEventArgs -> unit) = o.DefaultDrawingAttributesReplaced.RemoveHandler (System.Windows.Ink.DrawingAttributesReplacedEventHandler h)
      let private onDefaultDrawingAttributesReplaced_rf = onDefaultDrawingAttributesReplaced_r
      let private onDefaultDrawingAttributesReplaced_uf = onDefaultDrawingAttributesReplaced_u
      let onDefaultDrawingAttributesReplaced       (f : System.Windows.Controls.InkCanvas -> System.Windows.Ink.DrawingAttributesReplacedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Ink.DrawingAttributesReplacedEventHandler, System.Windows.Ink.DrawingAttributesReplacedEventArgs> (onDefaultDrawingAttributesReplaced_rf, onDefaultDrawingAttributesReplaced_uf, f)
      
      let private onActiveEditingModeChanged_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.ActiveEditingModeChanged.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onActiveEditingModeChanged_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.ActiveEditingModeChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onActiveEditingModeChanged_rf = onActiveEditingModeChanged_r
      let private onActiveEditingModeChanged_uf = onActiveEditingModeChanged_u
      let onActiveEditingModeChanged               (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onActiveEditingModeChanged_rf, onActiveEditingModeChanged_uf, f)
      
      let private onEditingModeChanged_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeChanged.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onEditingModeChanged_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onEditingModeChanged_rf = onEditingModeChanged_r
      let private onEditingModeChanged_uf = onEditingModeChanged_u
      let onEditingModeChanged                     (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onEditingModeChanged_rf, onEditingModeChanged_uf, f)
      
      let private onEditingModeInvertedChanged_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeInvertedChanged.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onEditingModeInvertedChanged_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.EditingModeInvertedChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onEditingModeInvertedChanged_rf = onEditingModeInvertedChanged_r
      let private onEditingModeInvertedChanged_uf = onEditingModeInvertedChanged_u
      let onEditingModeInvertedChanged             (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onEditingModeInvertedChanged_rf, onEditingModeInvertedChanged_uf, f)
      
      let private onSelectionMoving_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionMoving.AddHandler    (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
      let private onSelectionMoving_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionMoving.RemoveHandler (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
      let private onSelectionMoving_rf = onSelectionMoving_r
      let private onSelectionMoving_uf = onSelectionMoving_u
      let onSelectionMoving                        (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs> (onSelectionMoving_rf, onSelectionMoving_uf, f)
      
      let private onSelectionMoved_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionMoved.AddHandler    (System.EventHandler h)
      let private onSelectionMoved_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionMoved.RemoveHandler (System.EventHandler h)
      let private onSelectionMoved_rf = onSelectionMoved_r
      let private onSelectionMoved_uf = onSelectionMoved_u
      let onSelectionMoved                         (f : System.Windows.Controls.InkCanvas -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.EventHandler, System.EventArgs> (onSelectionMoved_rf, onSelectionMoved_uf, f)
      
      let private onStrokeErasing_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeErasingEventArgs -> unit) = o.StrokeErasing.AddHandler    (System.Windows.Controls.InkCanvasStrokeErasingEventHandler h)
      let private onStrokeErasing_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasStrokeErasingEventArgs -> unit) = o.StrokeErasing.RemoveHandler (System.Windows.Controls.InkCanvasStrokeErasingEventHandler h)
      let private onStrokeErasing_rf = onStrokeErasing_r
      let private onStrokeErasing_uf = onStrokeErasing_u
      let onStrokeErasing                          (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasStrokeErasingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasStrokeErasingEventHandler, System.Windows.Controls.InkCanvasStrokeErasingEventArgs> (onStrokeErasing_rf, onStrokeErasing_uf, f)
      
      let private onStrokeErased_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.StrokeErased.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onStrokeErased_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.StrokeErased.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onStrokeErased_rf = onStrokeErased_r
      let private onStrokeErased_uf = onStrokeErased_u
      let onStrokeErased                           (f : System.Windows.Controls.InkCanvas -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onStrokeErased_rf, onStrokeErased_uf, f)
      
      let private onSelectionResizing_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionResizing.AddHandler    (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
      let private onSelectionResizing_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs -> unit) = o.SelectionResizing.RemoveHandler (System.Windows.Controls.InkCanvasSelectionEditingEventHandler h)
      let private onSelectionResizing_rf = onSelectionResizing_r
      let private onSelectionResizing_uf = onSelectionResizing_u
      let onSelectionResizing                      (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasSelectionEditingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs> (onSelectionResizing_rf, onSelectionResizing_uf, f)
      
      let private onSelectionResized_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionResized.AddHandler    (System.EventHandler h)
      let private onSelectionResized_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionResized.RemoveHandler (System.EventHandler h)
      let private onSelectionResized_rf = onSelectionResized_r
      let private onSelectionResized_uf = onSelectionResized_u
      let onSelectionResized                       (f : System.Windows.Controls.InkCanvas -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.EventHandler, System.EventArgs> (onSelectionResized_rf, onSelectionResized_uf, f)
      
      let private onSelectionChanging_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionChangingEventArgs -> unit) = o.SelectionChanging.AddHandler    (System.Windows.Controls.InkCanvasSelectionChangingEventHandler h)
      let private onSelectionChanging_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.Windows.Controls.InkCanvasSelectionChangingEventArgs -> unit) = o.SelectionChanging.RemoveHandler (System.Windows.Controls.InkCanvasSelectionChangingEventHandler h)
      let private onSelectionChanging_rf = onSelectionChanging_r
      let private onSelectionChanging_uf = onSelectionChanging_u
      let onSelectionChanging                      (f : System.Windows.Controls.InkCanvas -> System.Windows.Controls.InkCanvasSelectionChangingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.Windows.Controls.InkCanvasSelectionChangingEventHandler, System.Windows.Controls.InkCanvasSelectionChangingEventArgs> (onSelectionChanging_rf, onSelectionChanging_uf, f)
      
      let private onSelectionChanged_r (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionChanged.AddHandler    (System.EventHandler h)
      let private onSelectionChanged_u (o : System.Windows.Controls.InkCanvas) (h : obj -> System.EventArgs -> unit) = o.SelectionChanged.RemoveHandler (System.EventHandler h)
      let private onSelectionChanged_rf = onSelectionChanged_r
      let private onSelectionChanged_uf = onSelectionChanged_u
      let onSelectionChanged                       (f : System.Windows.Controls.InkCanvas -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.InkCanvas, System.EventHandler, System.EventArgs> (onSelectionChanged_rf, onSelectionChanged_uf, f)

    let inkPresenter                             values =
      StandardView<InkPresenter> (values) :> View
    module InkPresenter = 
      open Dummy
      let strokes                                  v = SetConstantValue<_> (Properties.InkPresenter.strokes, v)

    let itemsControl                             values =
      StandardView<ItemsControl> (values) :> View
    module ItemsControl = 
      open Dummy
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
      open Dummy

    let label                                    values child =
      StandardContentView<Label> (values, child) :> View
    module Label = 
      open Dummy
      let target                                   v = SetConstantValue<_> (Properties.Label.target, v)

    let line                                     values =
      StandardView<Line> (values) :> View
    module Line = 
      open Dummy
      let x1                                       v = SetConstantValue<_> (Properties.Line.x1, v)
      let y1                                       v = SetConstantValue<_> (Properties.Line.y1, v)
      let x2                                       v = SetConstantValue<_> (Properties.Line.x2, v)
      let y2                                       v = SetConstantValue<_> (Properties.Line.y2, v)

    let listBox                                  values =
      StandardView<ListBox> (values) :> View
    module ListBox = 
      open Dummy
      let selectionMode                            v = SetConstantValue<_> (Properties.ListBox.selectionMode, v)
      let selectedItems                            v = SetConstantValue<_> (Properties.ListBox.selectedItems, v)

    let listBoxItem                              values child =
      StandardContentView<ListBoxItem> (values, child) :> View
    module ListBoxItem = 
      open Dummy
      let isSelected                               v = SetConstantValue<_> (Properties.ListBoxItem.isSelected, v)
      
      let private onSelected_r (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onSelected_u (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onSelected_rf = onSelected_r
      let private onSelected_uf = onSelected_u
      let onSelected                               (f : System.Windows.Controls.ListBoxItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ListBoxItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onSelected_rf, onSelected_uf, f)
      
      let private onUnselected_r (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onUnselected_u (o : System.Windows.Controls.ListBoxItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onUnselected_rf = onUnselected_r
      let private onUnselected_uf = onUnselected_u
      let onUnselected                             (f : System.Windows.Controls.ListBoxItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ListBoxItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onUnselected_rf, onUnselected_uf, f)

    let listView                                 values =
      StandardView<ListView> (values) :> View
    module ListView = 
      open Dummy
      let view                                     v = SetConstantValue<_> (Properties.ListView.view, v)

    let listViewItem                             values child =
      StandardContentView<ListViewItem> (values, child) :> View
    module ListViewItem = 
      open Dummy

    let mediaElement                             values =
      StandardView<MediaElement> (values) :> View
    module MediaElement = 
      open Dummy
      let source                                   v = SetConstantValue<_> (Properties.MediaElement.source, v)
      let volume                                   v = SetConstantValue<_> (Properties.MediaElement.volume, v)
      let balance                                  v = SetConstantValue<_> (Properties.MediaElement.balance, v)
      let isMuted                                  v = SetConstantValue<_> (Properties.MediaElement.isMuted, v)
      let scrubbingEnabled                         v = SetConstantValue<_> (Properties.MediaElement.scrubbingEnabled, v)
      let unloadedBehavior                         v = SetConstantValue<_> (Properties.MediaElement.unloadedBehavior, v)
      let loadedBehavior                           v = SetConstantValue<_> (Properties.MediaElement.loadedBehavior, v)
      let stretch                                  v = SetConstantValue<_> (Properties.MediaElement.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.MediaElement.stretchDirection, v)
      
      let private onMediaFailed_r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.MediaFailed.AddHandler    (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
      let private onMediaFailed_u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.ExceptionRoutedEventArgs -> unit) = o.MediaFailed.RemoveHandler (System.EventHandler<System.Windows.ExceptionRoutedEventArgs> h)
      let private onMediaFailed_rf = onMediaFailed_r
      let private onMediaFailed_uf = onMediaFailed_u
      let onMediaFailed                            (f : System.Windows.Controls.MediaElement -> System.Windows.ExceptionRoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs> (onMediaFailed_rf, onMediaFailed_uf, f)
      
      let private onMediaOpened_r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaOpened.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onMediaOpened_u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaOpened.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onMediaOpened_rf = onMediaOpened_r
      let private onMediaOpened_uf = onMediaOpened_u
      let onMediaOpened                            (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onMediaOpened_rf, onMediaOpened_uf, f)
      
      let private onBufferingStarted_r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingStarted.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onBufferingStarted_u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingStarted.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onBufferingStarted_rf = onBufferingStarted_r
      let private onBufferingStarted_uf = onBufferingStarted_u
      let onBufferingStarted                       (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onBufferingStarted_rf, onBufferingStarted_uf, f)
      
      let private onBufferingEnded_r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingEnded.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onBufferingEnded_u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.BufferingEnded.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onBufferingEnded_rf = onBufferingEnded_r
      let private onBufferingEnded_uf = onBufferingEnded_u
      let onBufferingEnded                         (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onBufferingEnded_rf, onBufferingEnded_uf, f)
      
      let private onScriptCommand_r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.MediaScriptCommandRoutedEventArgs -> unit) = o.ScriptCommand.AddHandler    (System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs> h)
      let private onScriptCommand_u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.MediaScriptCommandRoutedEventArgs -> unit) = o.ScriptCommand.RemoveHandler (System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs> h)
      let private onScriptCommand_rf = onScriptCommand_r
      let private onScriptCommand_uf = onScriptCommand_u
      let onScriptCommand                          (f : System.Windows.Controls.MediaElement -> System.Windows.MediaScriptCommandRoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>, System.Windows.MediaScriptCommandRoutedEventArgs> (onScriptCommand_rf, onScriptCommand_uf, f)
      
      let private onMediaEnded_r (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaEnded.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onMediaEnded_u (o : System.Windows.Controls.MediaElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.MediaEnded.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onMediaEnded_rf = onMediaEnded_r
      let private onMediaEnded_uf = onMediaEnded_u
      let onMediaEnded                             (f : System.Windows.Controls.MediaElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MediaElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onMediaEnded_rf, onMediaEnded_uf, f)

    let menu                                     values =
      StandardView<Menu> (values) :> View
    module Menu = 
      open Dummy
      let isMainMenu                               v = SetConstantValue<_> (Properties.Menu.isMainMenu, v)

    module MenuBase = 
      open Dummy
      let itemContainerTemplateSelector            v = SetConstantValue<_> (Properties.MenuBase.itemContainerTemplateSelector, v)
      let usesItemContainerTemplate                v = SetConstantValue<_> (Properties.MenuBase.usesItemContainerTemplate, v)

    let menuItem                                 values =
      StandardView<MenuItem> (values) :> View
    module MenuItem = 
      open Dummy
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
      
      let private onClick_r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onClick_u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Click.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onClick_rf = onClick_r
      let private onClick_uf = onClick_u
      let onClick                                  (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onClick_rf, onClick_uf, f)
      
      let private onChecked_r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onChecked_u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onChecked_rf = onChecked_r
      let private onChecked_uf = onChecked_u
      let onChecked                                (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onChecked_rf, onChecked_uf, f)
      
      let private onUnchecked_r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onUnchecked_u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onUnchecked_rf = onUnchecked_r
      let private onUnchecked_uf = onUnchecked_u
      let onUnchecked                              (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onUnchecked_rf, onUnchecked_uf, f)
      
      let private onSubmenuOpened_r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuOpened.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onSubmenuOpened_u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuOpened.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onSubmenuOpened_rf = onSubmenuOpened_r
      let private onSubmenuOpened_uf = onSubmenuOpened_u
      let onSubmenuOpened                          (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onSubmenuOpened_rf, onSubmenuOpened_uf, f)
      
      let private onSubmenuClosed_r (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuClosed.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onSubmenuClosed_u (o : System.Windows.Controls.MenuItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SubmenuClosed.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onSubmenuClosed_rf = onSubmenuClosed_r
      let private onSubmenuClosed_uf = onSubmenuClosed_u
      let onSubmenuClosed                          (f : System.Windows.Controls.MenuItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.MenuItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onSubmenuClosed_rf, onSubmenuClosed_uf, f)

    module MultiSelector = 
      open Dummy

    let navigationWindow                         values child =
      StandardContentView<NavigationWindow> (values, child) :> View
    module NavigationWindow = 
      open Dummy
      let sandboxExternalContent                   v = SetConstantValue<_> (Properties.NavigationWindow.sandboxExternalContent, v)
      let showsNavigationUI                        v = SetConstantValue<_> (Properties.NavigationWindow.showsNavigationUI, v)
      let backStack                                v = SetConstantValue<_> (Properties.NavigationWindow.backStack, v)
      let forwardStack                             v = SetConstantValue<_> (Properties.NavigationWindow.forwardStack, v)
      let canGoBack                                v = SetConstantValue<_> (Properties.NavigationWindow.canGoBack, v)
      let canGoForward                             v = SetConstantValue<_> (Properties.NavigationWindow.canGoForward, v)
      let source                                   v = SetConstantValue<_> (Properties.NavigationWindow.source, v)
      
      let private onNavigating_r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.AddHandler    (System.Windows.Navigation.NavigatingCancelEventHandler h)
      let private onNavigating_u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.RemoveHandler (System.Windows.Navigation.NavigatingCancelEventHandler h)
      let private onNavigating_rf = onNavigating_r
      let private onNavigating_uf = onNavigating_u
      let onNavigating                             (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigatingCancelEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs> (onNavigating_rf, onNavigating_uf, f)
      
      let private onNavigationProgress_r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.AddHandler    (System.Windows.Navigation.NavigationProgressEventHandler h)
      let private onNavigationProgress_u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationProgressEventArgs -> unit) = o.NavigationProgress.RemoveHandler (System.Windows.Navigation.NavigationProgressEventHandler h)
      let private onNavigationProgress_rf = onNavigationProgress_r
      let private onNavigationProgress_uf = onNavigationProgress_u
      let onNavigationProgress                     (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationProgressEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs> (onNavigationProgress_rf, onNavigationProgress_uf, f)
      
      let private onNavigationFailed_r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.AddHandler    (System.Windows.Navigation.NavigationFailedEventHandler h)
      let private onNavigationFailed_u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationFailedEventArgs -> unit) = o.NavigationFailed.RemoveHandler (System.Windows.Navigation.NavigationFailedEventHandler h)
      let private onNavigationFailed_rf = onNavigationFailed_r
      let private onNavigationFailed_uf = onNavigationFailed_u
      let onNavigationFailed                       (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationFailedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs> (onNavigationFailed_rf, onNavigationFailed_uf, f)
      
      let private onNavigated_r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.AddHandler    (System.Windows.Navigation.NavigatedEventHandler h)
      let private onNavigated_u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.RemoveHandler (System.Windows.Navigation.NavigatedEventHandler h)
      let private onNavigated_rf = onNavigated_r
      let private onNavigated_uf = onNavigated_u
      let onNavigated                              (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onNavigated_rf, onNavigated_uf, f)
      
      let private onLoadCompleted_r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.AddHandler    (System.Windows.Navigation.LoadCompletedEventHandler h)
      let private onLoadCompleted_u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.RemoveHandler (System.Windows.Navigation.LoadCompletedEventHandler h)
      let private onLoadCompleted_rf = onLoadCompleted_r
      let private onLoadCompleted_uf = onLoadCompleted_u
      let onLoadCompleted                          (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onLoadCompleted_rf, onLoadCompleted_uf, f)
      
      let private onNavigationStopped_r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.AddHandler    (System.Windows.Navigation.NavigationStoppedEventHandler h)
      let private onNavigationStopped_u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.NavigationStopped.RemoveHandler (System.Windows.Navigation.NavigationStoppedEventHandler h)
      let private onNavigationStopped_rf = onNavigationStopped_r
      let private onNavigationStopped_uf = onNavigationStopped_u
      let onNavigationStopped                      (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onNavigationStopped_rf, onNavigationStopped_uf, f)
      
      let private onFragmentNavigation_r (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.AddHandler    (System.Windows.Navigation.FragmentNavigationEventHandler h)
      let private onFragmentNavigation_u (o : System.Windows.Navigation.NavigationWindow) (h : obj -> System.Windows.Navigation.FragmentNavigationEventArgs -> unit) = o.FragmentNavigation.RemoveHandler (System.Windows.Navigation.FragmentNavigationEventHandler h)
      let private onFragmentNavigation_rf = onFragmentNavigation_r
      let private onFragmentNavigation_uf = onFragmentNavigation_u
      let onFragmentNavigation                     (f : System.Windows.Navigation.NavigationWindow -> System.Windows.Navigation.FragmentNavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Navigation.NavigationWindow, System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs> (onFragmentNavigation_rf, onFragmentNavigation_uf, f)

    let page                                     values =
      StandardView<Page> (values) :> View
    module Page = 
      open Dummy
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
      open Dummy
      let source                                   v = SetConstantValue<_> (Properties.PageContent.source, v)
      
      let private onGetPageRootCompleted_r (o : System.Windows.Documents.PageContent) (h : obj -> System.Windows.Documents.GetPageRootCompletedEventArgs -> unit) = o.GetPageRootCompleted.AddHandler    (System.Windows.Documents.GetPageRootCompletedEventHandler h)
      let private onGetPageRootCompleted_u (o : System.Windows.Documents.PageContent) (h : obj -> System.Windows.Documents.GetPageRootCompletedEventArgs -> unit) = o.GetPageRootCompleted.RemoveHandler (System.Windows.Documents.GetPageRootCompletedEventHandler h)
      let private onGetPageRootCompleted_rf = onGetPageRootCompleted_r
      let private onGetPageRootCompleted_uf = onGetPageRootCompleted_u
      let onGetPageRootCompleted                   (f : System.Windows.Documents.PageContent -> System.Windows.Documents.GetPageRootCompletedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Documents.PageContent, System.Windows.Documents.GetPageRootCompletedEventHandler, System.Windows.Documents.GetPageRootCompletedEventArgs> (onGetPageRootCompleted_rf, onGetPageRootCompleted_uf, f)

    module PageFunctionBase = 
      open Dummy

    module Panel = 
      open Dummy
      let background                               v = SetConstantValue<_> (Properties.Panel.background, v)
      let isItemsHost                              v = SetConstantValue<_> (Properties.Panel.isItemsHost, v)
      let zIndex                                   v = SetConstantValue<_> (Properties.Panel.zIndex, v)

    let passwordBox                              values =
      StandardView<PasswordBox> (values) :> View
    module PasswordBox = 
      open Dummy
      let passwordChar                             v = SetConstantValue<_> (Properties.PasswordBox.passwordChar, v)
      let maxLength                                v = SetConstantValue<_> (Properties.PasswordBox.maxLength, v)
      let selectionBrush                           v = SetConstantValue<_> (Properties.PasswordBox.selectionBrush, v)
      let selectionOpacity                         v = SetConstantValue<_> (Properties.PasswordBox.selectionOpacity, v)
      let caretBrush                               v = SetConstantValue<_> (Properties.PasswordBox.caretBrush, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.PasswordBox.isSelectionActive, v)
      let isInactiveSelectionHighlightEnabled      v = SetConstantValue<_> (Properties.PasswordBox.isInactiveSelectionHighlightEnabled, v)
      
      let private onPasswordChanged_r (o : System.Windows.Controls.PasswordBox) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.PasswordChanged.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onPasswordChanged_u (o : System.Windows.Controls.PasswordBox) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.PasswordChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onPasswordChanged_rf = onPasswordChanged_r
      let private onPasswordChanged_uf = onPasswordChanged_u
      let onPasswordChanged                        (f : System.Windows.Controls.PasswordBox -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.PasswordBox, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onPasswordChanged_rf, onPasswordChanged_uf, f)

    let path                                     values =
      StandardView<Path> (values) :> View
    module Path = 
      open Dummy
      let data                                     v = SetConstantValue<_> (Properties.Path.data, v)

    let polygon                                  values =
      StandardView<Polygon> (values) :> View
    module Polygon = 
      open Dummy
      let points                                   v = SetConstantValue<_> (Properties.Polygon.points, v)
      let fillRule                                 v = SetConstantValue<_> (Properties.Polygon.fillRule, v)

    let polyline                                 values =
      StandardView<Polyline> (values) :> View
    module Polyline = 
      open Dummy
      let points                                   v = SetConstantValue<_> (Properties.Polyline.points, v)
      let fillRule                                 v = SetConstantValue<_> (Properties.Polyline.fillRule, v)

    let popup                                    values =
      StandardView<Popup> (values) :> View
    module Popup = 
      open Dummy
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
      
      let private onOpened_r (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Opened.AddHandler    (System.EventHandler h)
      let private onOpened_u (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Opened.RemoveHandler (System.EventHandler h)
      let private onOpened_rf = onOpened_r
      let private onOpened_uf = onOpened_u
      let onOpened                                 (f : System.Windows.Controls.Primitives.Popup -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Popup, System.EventHandler, System.EventArgs> (onOpened_rf, onOpened_uf, f)
      
      let private onClosed_r (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Closed.AddHandler    (System.EventHandler h)
      let private onClosed_u (o : System.Windows.Controls.Primitives.Popup) (h : obj -> System.EventArgs -> unit) = o.Closed.RemoveHandler (System.EventHandler h)
      let private onClosed_rf = onClosed_r
      let private onClosed_uf = onClosed_u
      let onClosed                                 (f : System.Windows.Controls.Primitives.Popup -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Popup, System.EventHandler, System.EventArgs> (onClosed_rf, onClosed_uf, f)

    let progressBar                              values =
      StandardView<ProgressBar> (values) :> View
    module ProgressBar = 
      open Dummy
      let isIndeterminate                          v = SetConstantValue<_> (Properties.ProgressBar.isIndeterminate, v)
      let orientation                              v = SetConstantValue<_> (Properties.ProgressBar.orientation, v)

    let radioButton                              values child =
      StandardContentView<RadioButton> (values, child) :> View
    module RadioButton = 
      open Dummy
      let groupName                                v = SetConstantValue<_> (Properties.RadioButton.groupName, v)

    module RangeBase = 
      open Dummy
      let minimum                                  v = SetConstantValue<_> (Properties.RangeBase.minimum, v)
      let maximum                                  v = SetConstantValue<_> (Properties.RangeBase.maximum, v)
      let value                                    v = SetConstantValue<_> (Properties.RangeBase.value, v)
      let largeChange                              v = SetConstantValue<_> (Properties.RangeBase.largeChange, v)
      let smallChange                              v = SetConstantValue<_> (Properties.RangeBase.smallChange, v)
      
      let private onValueChanged_r (o : System.Windows.Controls.Primitives.RangeBase) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Double> -> unit) = o.ValueChanged.AddHandler    (System.Windows.RoutedPropertyChangedEventHandler<System.Double> h)
      let private onValueChanged_u (o : System.Windows.Controls.Primitives.RangeBase) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Double> -> unit) = o.ValueChanged.RemoveHandler (System.Windows.RoutedPropertyChangedEventHandler<System.Double> h)
      let private onValueChanged_rf = onValueChanged_r
      let private onValueChanged_uf = onValueChanged_u
      let onValueChanged                           (f : System.Windows.Controls.Primitives.RangeBase -> System.Windows.RoutedPropertyChangedEventArgs<System.Double>-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.RangeBase, System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>> (onValueChanged_rf, onValueChanged_uf, f)

    let rectangle                                values =
      StandardView<Rectangle> (values) :> View
    module Rectangle = 
      open Dummy
      let radiusX                                  v = SetConstantValue<_> (Properties.Rectangle.radiusX, v)
      let radiusY                                  v = SetConstantValue<_> (Properties.Rectangle.radiusY, v)

    let repeatButton                             values child =
      StandardContentView<RepeatButton> (values, child) :> View
    module RepeatButton = 
      open Dummy
      let delay                                    v = SetConstantValue<_> (Properties.RepeatButton.delay, v)
      let interval                                 v = SetConstantValue<_> (Properties.RepeatButton.interval, v)

    let resizeGrip                               values =
      StandardView<ResizeGrip> (values) :> View
    module ResizeGrip = 
      open Dummy

    let richTextBox                              values =
      StandardView<RichTextBox> (values) :> View
    module RichTextBox = 
      open Dummy
      let isDocumentEnabled                        v = SetConstantValue<_> (Properties.RichTextBox.isDocumentEnabled, v)

    let scrollBar                                values =
      StandardView<ScrollBar> (values) :> View
    module ScrollBar = 
      open Dummy
      let orientation                              v = SetConstantValue<_> (Properties.ScrollBar.orientation, v)
      let viewportSize                             v = SetConstantValue<_> (Properties.ScrollBar.viewportSize, v)
      
      let private onScroll_r (o : System.Windows.Controls.Primitives.ScrollBar) (h : obj -> System.Windows.Controls.Primitives.ScrollEventArgs -> unit) = o.Scroll.AddHandler    (System.Windows.Controls.Primitives.ScrollEventHandler h)
      let private onScroll_u (o : System.Windows.Controls.Primitives.ScrollBar) (h : obj -> System.Windows.Controls.Primitives.ScrollEventArgs -> unit) = o.Scroll.RemoveHandler (System.Windows.Controls.Primitives.ScrollEventHandler h)
      let private onScroll_rf = onScroll_r
      let private onScroll_uf = onScroll_u
      let onScroll                                 (f : System.Windows.Controls.Primitives.ScrollBar -> System.Windows.Controls.Primitives.ScrollEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ScrollBar, System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs> (onScroll_rf, onScroll_uf, f)

    let scrollContentPresenter                   values =
      StandardView<ScrollContentPresenter> (values) :> View
    module ScrollContentPresenter = 
      open Dummy
      let canContentScroll                         v = SetConstantValue<_> (Properties.ScrollContentPresenter.canContentScroll, v)

    let scrollViewer                             values child =
      StandardContentView<ScrollViewer> (values, child) :> View
    module ScrollViewer = 
      open Dummy
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
      
      let private onScrollChanged_r (o : System.Windows.Controls.ScrollViewer) (h : obj -> System.Windows.Controls.ScrollChangedEventArgs -> unit) = o.ScrollChanged.AddHandler    (System.Windows.Controls.ScrollChangedEventHandler h)
      let private onScrollChanged_u (o : System.Windows.Controls.ScrollViewer) (h : obj -> System.Windows.Controls.ScrollChangedEventArgs -> unit) = o.ScrollChanged.RemoveHandler (System.Windows.Controls.ScrollChangedEventHandler h)
      let private onScrollChanged_rf = onScrollChanged_r
      let private onScrollChanged_uf = onScrollChanged_u
      let onScrollChanged                          (f : System.Windows.Controls.ScrollViewer -> System.Windows.Controls.ScrollChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ScrollViewer, System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs> (onScrollChanged_rf, onScrollChanged_uf, f)

    let selectiveScrollingGrid                   values children =
      StandardPanelView<SelectiveScrollingGrid> (values, children) :> View
    module SelectiveScrollingGrid = 
      open Dummy
      let selectiveScrollingOrientation            v = SetConstantValue<_> (Properties.SelectiveScrollingGrid.selectiveScrollingOrientation, v)

    module Selector = 
      open Dummy
      let isSelectionActive                        v = SetConstantValue<_> (Properties.Selector.isSelectionActive, v)
      let isSelected                               v = SetConstantValue<_> (Properties.Selector.isSelected, v)
      let isSynchronizedWithCurrentItem            v = SetConstantValue<_> (Properties.Selector.isSynchronizedWithCurrentItem, v)
      let selectedIndex                            v = SetConstantValue<_> (Properties.Selector.selectedIndex, v)
      let selectedItem                             v = SetConstantValue<_> (Properties.Selector.selectedItem, v)
      let selectedValue                            v = SetConstantValue<_> (Properties.Selector.selectedValue, v)
      let selectedValuePath                        v = SetConstantValue<_> (Properties.Selector.selectedValuePath, v)
      
      let private onSelectionChanged_r (o : System.Windows.Controls.Primitives.Selector) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectionChanged.AddHandler    (System.Windows.Controls.SelectionChangedEventHandler h)
      let private onSelectionChanged_u (o : System.Windows.Controls.Primitives.Selector) (h : obj -> System.Windows.Controls.SelectionChangedEventArgs -> unit) = o.SelectionChanged.RemoveHandler (System.Windows.Controls.SelectionChangedEventHandler h)
      let private onSelectionChanged_rf = onSelectionChanged_r
      let private onSelectionChanged_uf = onSelectionChanged_u
      let onSelectionChanged                       (f : System.Windows.Controls.Primitives.Selector -> System.Windows.Controls.SelectionChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Selector, System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs> (onSelectionChanged_rf, onSelectionChanged_uf, f)

    let separator                                values =
      StandardView<Separator> (values) :> View
    module Separator = 
      open Dummy

    module Shape = 
      open Dummy
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
      open Dummy
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
      open Dummy
      let orientation                              v = SetConstantValue<_> (Properties.StackPanel.orientation, v)

    let statusBar                                values =
      StandardView<StatusBar> (values) :> View
    module StatusBar = 
      open Dummy
      let itemContainerTemplateSelector            v = SetConstantValue<_> (Properties.StatusBar.itemContainerTemplateSelector, v)
      let usesItemContainerTemplate                v = SetConstantValue<_> (Properties.StatusBar.usesItemContainerTemplate, v)

    let statusBarItem                            values child =
      StandardContentView<StatusBarItem> (values, child) :> View
    module StatusBarItem = 
      open Dummy

    module StickyNoteControl = 
      open Dummy
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
      open Dummy
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
      open Dummy
      let isSelected                               v = SetConstantValue<_> (Properties.TabItem.isSelected, v)
      let tabStripPlacement                        v = SetConstantValue<_> (Properties.TabItem.tabStripPlacement, v)

    let tabPanel                                 values children =
      StandardPanelView<TabPanel> (values, children) :> View
    module TabPanel = 
      open Dummy

    let textBlock                                values =
      StandardView<TextBlock> (values) :> View
    module TextBlock = 
      open Dummy
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
      open Dummy
      let textWrapping                             v = SetConstantValue<_> (Properties.TextBox.textWrapping, v)
      let minLines                                 v = SetConstantValue<_> (Properties.TextBox.minLines, v)
      let maxLines                                 v = SetConstantValue<_> (Properties.TextBox.maxLines, v)
      let text                                     v = SetConstantValue<_> (Properties.TextBox.text, v)
      let characterCasing                          v = SetConstantValue<_> (Properties.TextBox.characterCasing, v)
      let maxLength                                v = SetConstantValue<_> (Properties.TextBox.maxLength, v)
      let textAlignment                            v = SetConstantValue<_> (Properties.TextBox.textAlignment, v)
      let textDecorations                          v = SetConstantValue<_> (Properties.TextBox.textDecorations, v)

    module TextBoxBase = 
      open Dummy
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
      
      let private onTextChanged_r (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.Controls.TextChangedEventArgs -> unit) = o.TextChanged.AddHandler    (System.Windows.Controls.TextChangedEventHandler h)
      let private onTextChanged_u (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.Controls.TextChangedEventArgs -> unit) = o.TextChanged.RemoveHandler (System.Windows.Controls.TextChangedEventHandler h)
      let private onTextChanged_rf = onTextChanged_r
      let private onTextChanged_uf = onTextChanged_u
      let onTextChanged                            (f : System.Windows.Controls.Primitives.TextBoxBase -> System.Windows.Controls.TextChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs> (onTextChanged_rf, onTextChanged_uf, f)
      
      let private onSelectionChanged_r (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SelectionChanged.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onSelectionChanged_u (o : System.Windows.Controls.Primitives.TextBoxBase) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.SelectionChanged.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onSelectionChanged_rf = onSelectionChanged_r
      let private onSelectionChanged_uf = onSelectionChanged_u
      let onSelectionChanged                       (f : System.Windows.Controls.Primitives.TextBoxBase -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.TextBoxBase, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onSelectionChanged_rf, onSelectionChanged_uf, f)

    let thumb                                    values =
      StandardView<Thumb> (values) :> View
    module Thumb = 
      open Dummy
      let isDragging                               v = SetConstantValue<_> (Properties.Thumb.isDragging, v)
      
      let private onDragStarted_r (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.DragStarted.AddHandler    (System.Windows.Controls.Primitives.DragStartedEventHandler h)
      let private onDragStarted_u (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragStartedEventArgs -> unit) = o.DragStarted.RemoveHandler (System.Windows.Controls.Primitives.DragStartedEventHandler h)
      let private onDragStarted_rf = onDragStarted_r
      let private onDragStarted_uf = onDragStarted_u
      let onDragStarted                            (f : System.Windows.Controls.Primitives.Thumb -> System.Windows.Controls.Primitives.DragStartedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Thumb, System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs> (onDragStarted_rf, onDragStarted_uf, f)
      
      let private onDragDelta_r (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.DragDelta.AddHandler    (System.Windows.Controls.Primitives.DragDeltaEventHandler h)
      let private onDragDelta_u (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragDeltaEventArgs -> unit) = o.DragDelta.RemoveHandler (System.Windows.Controls.Primitives.DragDeltaEventHandler h)
      let private onDragDelta_rf = onDragDelta_r
      let private onDragDelta_uf = onDragDelta_u
      let onDragDelta                              (f : System.Windows.Controls.Primitives.Thumb -> System.Windows.Controls.Primitives.DragDeltaEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Thumb, System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs> (onDragDelta_rf, onDragDelta_uf, f)
      
      let private onDragCompleted_r (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.DragCompleted.AddHandler    (System.Windows.Controls.Primitives.DragCompletedEventHandler h)
      let private onDragCompleted_u (o : System.Windows.Controls.Primitives.Thumb) (h : obj -> System.Windows.Controls.Primitives.DragCompletedEventArgs -> unit) = o.DragCompleted.RemoveHandler (System.Windows.Controls.Primitives.DragCompletedEventHandler h)
      let private onDragCompleted_rf = onDragCompleted_r
      let private onDragCompleted_uf = onDragCompleted_u
      let onDragCompleted                          (f : System.Windows.Controls.Primitives.Thumb -> System.Windows.Controls.Primitives.DragCompletedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.Thumb, System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs> (onDragCompleted_rf, onDragCompleted_uf, f)

    let tickBar                                  values =
      StandardView<TickBar> (values) :> View
    module TickBar = 
      open Dummy
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
      open Dummy
      let isChecked                                v = SetConstantValue<_> (Properties.ToggleButton.isChecked, v)
      let isThreeState                             v = SetConstantValue<_> (Properties.ToggleButton.isThreeState, v)
      
      let private onChecked_r (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onChecked_u (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Checked.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onChecked_rf = onChecked_r
      let private onChecked_uf = onChecked_u
      let onChecked                                (f : System.Windows.Controls.Primitives.ToggleButton -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onChecked_rf, onChecked_uf, f)
      
      let private onUnchecked_r (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onUnchecked_u (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unchecked.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onUnchecked_rf = onUnchecked_r
      let private onUnchecked_uf = onUnchecked_u
      let onUnchecked                              (f : System.Windows.Controls.Primitives.ToggleButton -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onUnchecked_rf, onUnchecked_uf, f)
      
      let private onIndeterminate_r (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Indeterminate.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onIndeterminate_u (o : System.Windows.Controls.Primitives.ToggleButton) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Indeterminate.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onIndeterminate_rf = onIndeterminate_r
      let private onIndeterminate_uf = onIndeterminate_u
      let onIndeterminate                          (f : System.Windows.Controls.Primitives.ToggleButton -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.Primitives.ToggleButton, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onIndeterminate_rf, onIndeterminate_uf, f)

    let toolBar                                  values =
      StandardView<ToolBar> (values) :> View
    module ToolBar = 
      open Dummy
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
      open Dummy
      let wrapWidth                                v = SetConstantValue<_> (Properties.ToolBarOverflowPanel.wrapWidth, v)

    let toolBarPanel                             values children =
      StandardPanelView<ToolBarPanel> (values, children) :> View
    module ToolBarPanel = 
      open Dummy

    let toolBarTray                              values =
      StandardView<ToolBarTray> (values) :> View
    module ToolBarTray = 
      open Dummy
      let background                               v = SetConstantValue<_> (Properties.ToolBarTray.background, v)
      let orientation                              v = SetConstantValue<_> (Properties.ToolBarTray.orientation, v)
      let isLocked                                 v = SetConstantValue<_> (Properties.ToolBarTray.isLocked, v)

    let toolTip                                  values child =
      StandardContentView<ToolTip> (values, child) :> View
    module ToolTip = 
      open Dummy
      let horizontalOffset                         v = SetConstantValue<_> (Properties.ToolTip.horizontalOffset, v)
      let verticalOffset                           v = SetConstantValue<_> (Properties.ToolTip.verticalOffset, v)
      let isOpen                                   v = SetConstantValue<_> (Properties.ToolTip.isOpen, v)
      let hasDropShadow                            v = SetConstantValue<_> (Properties.ToolTip.hasDropShadow, v)
      let placementTarget                          v = SetConstantValue<_> (Properties.ToolTip.placementTarget, v)
      let placementRectangle                       v = SetConstantValue<_> (Properties.ToolTip.placementRectangle, v)
      let placement                                v = SetConstantValue<_> (Properties.ToolTip.placement, v)
      let customPopupPlacementCallback             v = SetConstantValue<_> (Properties.ToolTip.customPopupPlacementCallback, v)
      let staysOpen                                v = SetConstantValue<_> (Properties.ToolTip.staysOpen, v)
      
      let private onOpened_r (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onOpened_u (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Opened.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onOpened_rf = onOpened_r
      let private onOpened_uf = onOpened_u
      let onOpened                                 (f : System.Windows.Controls.ToolTip -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ToolTip, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onOpened_rf, onOpened_uf, f)
      
      let private onClosed_r (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onClosed_u (o : System.Windows.Controls.ToolTip) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Closed.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onClosed_rf = onClosed_r
      let private onClosed_uf = onClosed_u
      let onClosed                                 (f : System.Windows.Controls.ToolTip -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.ToolTip, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onClosed_rf, onClosed_uf, f)

    let track                                    values =
      StandardView<Track> (values) :> View
    module Track = 
      open Dummy
      let orientation                              v = SetConstantValue<_> (Properties.Track.orientation, v)
      let minimum                                  v = SetConstantValue<_> (Properties.Track.minimum, v)
      let maximum                                  v = SetConstantValue<_> (Properties.Track.maximum, v)
      let value                                    v = SetConstantValue<_> (Properties.Track.value, v)
      let viewportSize                             v = SetConstantValue<_> (Properties.Track.viewportSize, v)
      let isDirectionReversed                      v = SetConstantValue<_> (Properties.Track.isDirectionReversed, v)

    let treeView                                 values =
      StandardView<TreeView> (values) :> View
    module TreeView = 
      open Dummy
      let selectedItem                             v = SetConstantValue<_> (Properties.TreeView.selectedItem, v)
      let selectedValue                            v = SetConstantValue<_> (Properties.TreeView.selectedValue, v)
      let selectedValuePath                        v = SetConstantValue<_> (Properties.TreeView.selectedValuePath, v)
      
      let private onSelectedItemChanged_r (o : System.Windows.Controls.TreeView) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Object> -> unit) = o.SelectedItemChanged.AddHandler    (System.Windows.RoutedPropertyChangedEventHandler<System.Object> h)
      let private onSelectedItemChanged_u (o : System.Windows.Controls.TreeView) (h : obj -> System.Windows.RoutedPropertyChangedEventArgs<System.Object> -> unit) = o.SelectedItemChanged.RemoveHandler (System.Windows.RoutedPropertyChangedEventHandler<System.Object> h)
      let private onSelectedItemChanged_rf = onSelectedItemChanged_r
      let private onSelectedItemChanged_uf = onSelectedItemChanged_u
      let onSelectedItemChanged                    (f : System.Windows.Controls.TreeView -> System.Windows.RoutedPropertyChangedEventArgs<System.Object>-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.TreeView, System.Windows.RoutedPropertyChangedEventHandler<System.Object>, System.Windows.RoutedPropertyChangedEventArgs<System.Object>> (onSelectedItemChanged_rf, onSelectedItemChanged_uf, f)

    let treeViewItem                             values =
      StandardView<TreeViewItem> (values) :> View
    module TreeViewItem = 
      open Dummy
      let isExpanded                               v = SetConstantValue<_> (Properties.TreeViewItem.isExpanded, v)
      let isSelected                               v = SetConstantValue<_> (Properties.TreeViewItem.isSelected, v)
      let isSelectionActive                        v = SetConstantValue<_> (Properties.TreeViewItem.isSelectionActive, v)
      
      let private onExpanded_r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onExpanded_u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Expanded.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onExpanded_rf = onExpanded_r
      let private onExpanded_uf = onExpanded_u
      let onExpanded                               (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onExpanded_rf, onExpanded_uf, f)
      
      let private onCollapsed_r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onCollapsed_u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Collapsed.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onCollapsed_rf = onCollapsed_r
      let private onCollapsed_uf = onCollapsed_u
      let onCollapsed                              (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onCollapsed_rf, onCollapsed_uf, f)
      
      let private onSelected_r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onSelected_u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Selected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onSelected_rf = onSelected_r
      let private onSelected_uf = onSelected_u
      let onSelected                               (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onSelected_rf, onSelected_uf, f)
      
      let private onUnselected_r (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onUnselected_u (o : System.Windows.Controls.TreeViewItem) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.Unselected.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onUnselected_rf = onUnselected_r
      let private onUnselected_uf = onUnselected_u
      let onUnselected                             (f : System.Windows.Controls.TreeViewItem -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.TreeViewItem, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onUnselected_rf, onUnselected_uf, f)

    let uIElement                                values =
      StandardView<UIElement> (values) :> View
    module UIElement = 
      open Dummy
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
      
      let private onPreviewMouseDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseDown_rf = onPreviewMouseDown_r
      let private onPreviewMouseDown_uf = onPreviewMouseDown_u
      let onPreviewMouseDown                       (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onPreviewMouseDown_rf, onPreviewMouseDown_uf, f)
      
      let private onMouseDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseDown_rf = onMouseDown_r
      let private onMouseDown_uf = onMouseDown_u
      let onMouseDown                              (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onMouseDown_rf, onMouseDown_uf, f)
      
      let private onPreviewMouseUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseUp_rf = onPreviewMouseUp_r
      let private onPreviewMouseUp_uf = onPreviewMouseUp_u
      let onPreviewMouseUp                         (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onPreviewMouseUp_rf, onPreviewMouseUp_uf, f)
      
      let private onMouseUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseUp_rf = onMouseUp_r
      let private onMouseUp_uf = onMouseUp_u
      let onMouseUp                                (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onMouseUp_rf, onMouseUp_uf, f)
      
      let private onPreviewMouseLeftButtonDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseLeftButtonDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseLeftButtonDown_rf = onPreviewMouseLeftButtonDown_r
      let private onPreviewMouseLeftButtonDown_uf = onPreviewMouseLeftButtonDown_u
      let onPreviewMouseLeftButtonDown             (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onPreviewMouseLeftButtonDown_rf, onPreviewMouseLeftButtonDown_uf, f)
      
      let private onMouseLeftButtonDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseLeftButtonDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseLeftButtonDown_rf = onMouseLeftButtonDown_r
      let private onMouseLeftButtonDown_uf = onMouseLeftButtonDown_u
      let onMouseLeftButtonDown                    (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onMouseLeftButtonDown_rf, onMouseLeftButtonDown_uf, f)
      
      let private onPreviewMouseLeftButtonUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseLeftButtonUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseLeftButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseLeftButtonUp_rf = onPreviewMouseLeftButtonUp_r
      let private onPreviewMouseLeftButtonUp_uf = onPreviewMouseLeftButtonUp_u
      let onPreviewMouseLeftButtonUp               (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onPreviewMouseLeftButtonUp_rf, onPreviewMouseLeftButtonUp_uf, f)
      
      let private onMouseLeftButtonUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseLeftButtonUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseLeftButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseLeftButtonUp_rf = onMouseLeftButtonUp_r
      let private onMouseLeftButtonUp_uf = onMouseLeftButtonUp_u
      let onMouseLeftButtonUp                      (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onMouseLeftButtonUp_rf, onMouseLeftButtonUp_uf, f)
      
      let private onPreviewMouseRightButtonDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseRightButtonDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseRightButtonDown_rf = onPreviewMouseRightButtonDown_r
      let private onPreviewMouseRightButtonDown_uf = onPreviewMouseRightButtonDown_u
      let onPreviewMouseRightButtonDown            (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onPreviewMouseRightButtonDown_rf, onPreviewMouseRightButtonDown_uf, f)
      
      let private onMouseRightButtonDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonDown.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseRightButtonDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonDown.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseRightButtonDown_rf = onMouseRightButtonDown_r
      let private onMouseRightButtonDown_uf = onMouseRightButtonDown_u
      let onMouseRightButtonDown                   (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onMouseRightButtonDown_rf, onMouseRightButtonDown_uf, f)
      
      let private onPreviewMouseRightButtonUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseRightButtonUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.PreviewMouseRightButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onPreviewMouseRightButtonUp_rf = onPreviewMouseRightButtonUp_r
      let private onPreviewMouseRightButtonUp_uf = onPreviewMouseRightButtonUp_u
      let onPreviewMouseRightButtonUp              (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onPreviewMouseRightButtonUp_rf, onPreviewMouseRightButtonUp_uf, f)
      
      let private onMouseRightButtonUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonUp.AddHandler    (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseRightButtonUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseButtonEventArgs -> unit) = o.MouseRightButtonUp.RemoveHandler (System.Windows.Input.MouseButtonEventHandler h)
      let private onMouseRightButtonUp_rf = onMouseRightButtonUp_r
      let private onMouseRightButtonUp_uf = onMouseRightButtonUp_u
      let onMouseRightButtonUp                     (f : System.Windows.UIElement -> System.Windows.Input.MouseButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs> (onMouseRightButtonUp_rf, onMouseRightButtonUp_uf, f)
      
      let private onPreviewMouseMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.PreviewMouseMove.AddHandler    (System.Windows.Input.MouseEventHandler h)
      let private onPreviewMouseMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.PreviewMouseMove.RemoveHandler (System.Windows.Input.MouseEventHandler h)
      let private onPreviewMouseMove_rf = onPreviewMouseMove_r
      let private onPreviewMouseMove_uf = onPreviewMouseMove_u
      let onPreviewMouseMove                       (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (onPreviewMouseMove_rf, onPreviewMouseMove_uf, f)
      
      let private onMouseMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseMove.AddHandler    (System.Windows.Input.MouseEventHandler h)
      let private onMouseMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseMove.RemoveHandler (System.Windows.Input.MouseEventHandler h)
      let private onMouseMove_rf = onMouseMove_r
      let private onMouseMove_uf = onMouseMove_u
      let onMouseMove                              (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (onMouseMove_rf, onMouseMove_uf, f)
      
      let private onPreviewMouseWheel_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.PreviewMouseWheel.AddHandler    (System.Windows.Input.MouseWheelEventHandler h)
      let private onPreviewMouseWheel_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.PreviewMouseWheel.RemoveHandler (System.Windows.Input.MouseWheelEventHandler h)
      let private onPreviewMouseWheel_rf = onPreviewMouseWheel_r
      let private onPreviewMouseWheel_uf = onPreviewMouseWheel_u
      let onPreviewMouseWheel                      (f : System.Windows.UIElement -> System.Windows.Input.MouseWheelEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> (onPreviewMouseWheel_rf, onPreviewMouseWheel_uf, f)
      
      let private onMouseWheel_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.MouseWheel.AddHandler    (System.Windows.Input.MouseWheelEventHandler h)
      let private onMouseWheel_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseWheelEventArgs -> unit) = o.MouseWheel.RemoveHandler (System.Windows.Input.MouseWheelEventHandler h)
      let private onMouseWheel_rf = onMouseWheel_r
      let private onMouseWheel_uf = onMouseWheel_u
      let onMouseWheel                             (f : System.Windows.UIElement -> System.Windows.Input.MouseWheelEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs> (onMouseWheel_rf, onMouseWheel_uf, f)
      
      let private onMouseEnter_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseEnter.AddHandler    (System.Windows.Input.MouseEventHandler h)
      let private onMouseEnter_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseEnter.RemoveHandler (System.Windows.Input.MouseEventHandler h)
      let private onMouseEnter_rf = onMouseEnter_r
      let private onMouseEnter_uf = onMouseEnter_u
      let onMouseEnter                             (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (onMouseEnter_rf, onMouseEnter_uf, f)
      
      let private onMouseLeave_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseLeave.AddHandler    (System.Windows.Input.MouseEventHandler h)
      let private onMouseLeave_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.MouseLeave.RemoveHandler (System.Windows.Input.MouseEventHandler h)
      let private onMouseLeave_rf = onMouseLeave_r
      let private onMouseLeave_uf = onMouseLeave_u
      let onMouseLeave                             (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (onMouseLeave_rf, onMouseLeave_uf, f)
      
      let private onGotMouseCapture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.GotMouseCapture.AddHandler    (System.Windows.Input.MouseEventHandler h)
      let private onGotMouseCapture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.GotMouseCapture.RemoveHandler (System.Windows.Input.MouseEventHandler h)
      let private onGotMouseCapture_rf = onGotMouseCapture_r
      let private onGotMouseCapture_uf = onGotMouseCapture_u
      let onGotMouseCapture                        (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (onGotMouseCapture_rf, onGotMouseCapture_uf, f)
      
      let private onLostMouseCapture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.LostMouseCapture.AddHandler    (System.Windows.Input.MouseEventHandler h)
      let private onLostMouseCapture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.MouseEventArgs -> unit) = o.LostMouseCapture.RemoveHandler (System.Windows.Input.MouseEventHandler h)
      let private onLostMouseCapture_rf = onLostMouseCapture_r
      let private onLostMouseCapture_uf = onLostMouseCapture_u
      let onLostMouseCapture                       (f : System.Windows.UIElement -> System.Windows.Input.MouseEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs> (onLostMouseCapture_rf, onLostMouseCapture_uf, f)
      
      let private onQueryCursor_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.QueryCursorEventArgs -> unit) = o.QueryCursor.AddHandler    (System.Windows.Input.QueryCursorEventHandler h)
      let private onQueryCursor_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.QueryCursorEventArgs -> unit) = o.QueryCursor.RemoveHandler (System.Windows.Input.QueryCursorEventHandler h)
      let private onQueryCursor_rf = onQueryCursor_r
      let private onQueryCursor_uf = onQueryCursor_u
      let onQueryCursor                            (f : System.Windows.UIElement -> System.Windows.Input.QueryCursorEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs> (onQueryCursor_rf, onQueryCursor_uf, f)
      
      let private onPreviewStylusDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.PreviewStylusDown.AddHandler    (System.Windows.Input.StylusDownEventHandler h)
      let private onPreviewStylusDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.PreviewStylusDown.RemoveHandler (System.Windows.Input.StylusDownEventHandler h)
      let private onPreviewStylusDown_rf = onPreviewStylusDown_r
      let private onPreviewStylusDown_uf = onPreviewStylusDown_u
      let onPreviewStylusDown                      (f : System.Windows.UIElement -> System.Windows.Input.StylusDownEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> (onPreviewStylusDown_rf, onPreviewStylusDown_uf, f)
      
      let private onStylusDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.StylusDown.AddHandler    (System.Windows.Input.StylusDownEventHandler h)
      let private onStylusDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusDownEventArgs -> unit) = o.StylusDown.RemoveHandler (System.Windows.Input.StylusDownEventHandler h)
      let private onStylusDown_rf = onStylusDown_r
      let private onStylusDown_uf = onStylusDown_u
      let onStylusDown                             (f : System.Windows.UIElement -> System.Windows.Input.StylusDownEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs> (onStylusDown_rf, onStylusDown_uf, f)
      
      let private onPreviewStylusUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusUp.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusUp.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusUp_rf = onPreviewStylusUp_r
      let private onPreviewStylusUp_uf = onPreviewStylusUp_u
      let onPreviewStylusUp                        (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onPreviewStylusUp_rf, onPreviewStylusUp_uf, f)
      
      let private onStylusUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusUp.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onStylusUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusUp.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onStylusUp_rf = onStylusUp_r
      let private onStylusUp_uf = onStylusUp_u
      let onStylusUp                               (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onStylusUp_rf, onStylusUp_uf, f)
      
      let private onPreviewStylusMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusMove_rf = onPreviewStylusMove_r
      let private onPreviewStylusMove_uf = onPreviewStylusMove_u
      let onPreviewStylusMove                      (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onPreviewStylusMove_rf, onPreviewStylusMove_uf, f)
      
      let private onStylusMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onStylusMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onStylusMove_rf = onStylusMove_r
      let private onStylusMove_uf = onStylusMove_u
      let onStylusMove                             (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onStylusMove_rf, onStylusMove_uf, f)
      
      let private onPreviewStylusInAirMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInAirMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusInAirMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInAirMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusInAirMove_rf = onPreviewStylusInAirMove_r
      let private onPreviewStylusInAirMove_uf = onPreviewStylusInAirMove_u
      let onPreviewStylusInAirMove                 (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onPreviewStylusInAirMove_rf, onPreviewStylusInAirMove_uf, f)
      
      let private onStylusInAirMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInAirMove.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onStylusInAirMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInAirMove.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onStylusInAirMove_rf = onStylusInAirMove_r
      let private onStylusInAirMove_uf = onStylusInAirMove_u
      let onStylusInAirMove                        (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onStylusInAirMove_rf, onStylusInAirMove_uf, f)
      
      let private onStylusEnter_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusEnter.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onStylusEnter_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusEnter.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onStylusEnter_rf = onStylusEnter_r
      let private onStylusEnter_uf = onStylusEnter_u
      let onStylusEnter                            (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onStylusEnter_rf, onStylusEnter_uf, f)
      
      let private onStylusLeave_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusLeave.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onStylusLeave_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusLeave.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onStylusLeave_rf = onStylusLeave_r
      let private onStylusLeave_uf = onStylusLeave_u
      let onStylusLeave                            (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onStylusLeave_rf, onStylusLeave_uf, f)
      
      let private onPreviewStylusInRange_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusInRange_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusInRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusInRange_rf = onPreviewStylusInRange_r
      let private onPreviewStylusInRange_uf = onPreviewStylusInRange_u
      let onPreviewStylusInRange                   (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onPreviewStylusInRange_rf, onPreviewStylusInRange_uf, f)
      
      let private onStylusInRange_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onStylusInRange_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusInRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onStylusInRange_rf = onStylusInRange_r
      let private onStylusInRange_uf = onStylusInRange_u
      let onStylusInRange                          (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onStylusInRange_rf, onStylusInRange_uf, f)
      
      let private onPreviewStylusOutOfRange_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusOutOfRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusOutOfRange_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.PreviewStylusOutOfRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onPreviewStylusOutOfRange_rf = onPreviewStylusOutOfRange_r
      let private onPreviewStylusOutOfRange_uf = onPreviewStylusOutOfRange_u
      let onPreviewStylusOutOfRange                (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onPreviewStylusOutOfRange_rf, onPreviewStylusOutOfRange_uf, f)
      
      let private onStylusOutOfRange_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusOutOfRange.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onStylusOutOfRange_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.StylusOutOfRange.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onStylusOutOfRange_rf = onStylusOutOfRange_r
      let private onStylusOutOfRange_uf = onStylusOutOfRange_u
      let onStylusOutOfRange                       (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onStylusOutOfRange_rf, onStylusOutOfRange_uf, f)
      
      let private onPreviewStylusSystemGesture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.PreviewStylusSystemGesture.AddHandler    (System.Windows.Input.StylusSystemGestureEventHandler h)
      let private onPreviewStylusSystemGesture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.PreviewStylusSystemGesture.RemoveHandler (System.Windows.Input.StylusSystemGestureEventHandler h)
      let private onPreviewStylusSystemGesture_rf = onPreviewStylusSystemGesture_r
      let private onPreviewStylusSystemGesture_uf = onPreviewStylusSystemGesture_u
      let onPreviewStylusSystemGesture             (f : System.Windows.UIElement -> System.Windows.Input.StylusSystemGestureEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> (onPreviewStylusSystemGesture_rf, onPreviewStylusSystemGesture_uf, f)
      
      let private onStylusSystemGesture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.StylusSystemGesture.AddHandler    (System.Windows.Input.StylusSystemGestureEventHandler h)
      let private onStylusSystemGesture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusSystemGestureEventArgs -> unit) = o.StylusSystemGesture.RemoveHandler (System.Windows.Input.StylusSystemGestureEventHandler h)
      let private onStylusSystemGesture_rf = onStylusSystemGesture_r
      let private onStylusSystemGesture_uf = onStylusSystemGesture_u
      let onStylusSystemGesture                    (f : System.Windows.UIElement -> System.Windows.Input.StylusSystemGestureEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs> (onStylusSystemGesture_rf, onStylusSystemGesture_uf, f)
      
      let private onGotStylusCapture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.GotStylusCapture.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onGotStylusCapture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.GotStylusCapture.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onGotStylusCapture_rf = onGotStylusCapture_r
      let private onGotStylusCapture_uf = onGotStylusCapture_u
      let onGotStylusCapture                       (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onGotStylusCapture_rf, onGotStylusCapture_uf, f)
      
      let private onLostStylusCapture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.LostStylusCapture.AddHandler    (System.Windows.Input.StylusEventHandler h)
      let private onLostStylusCapture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusEventArgs -> unit) = o.LostStylusCapture.RemoveHandler (System.Windows.Input.StylusEventHandler h)
      let private onLostStylusCapture_rf = onLostStylusCapture_r
      let private onLostStylusCapture_uf = onLostStylusCapture_u
      let onLostStylusCapture                      (f : System.Windows.UIElement -> System.Windows.Input.StylusEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs> (onLostStylusCapture_rf, onLostStylusCapture_uf, f)
      
      let private onStylusButtonDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonDown.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
      let private onStylusButtonDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonDown.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
      let private onStylusButtonDown_rf = onStylusButtonDown_r
      let private onStylusButtonDown_uf = onStylusButtonDown_u
      let onStylusButtonDown                       (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (onStylusButtonDown_rf, onStylusButtonDown_uf, f)
      
      let private onStylusButtonUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonUp.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
      let private onStylusButtonUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.StylusButtonUp.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
      let private onStylusButtonUp_rf = onStylusButtonUp_r
      let private onStylusButtonUp_uf = onStylusButtonUp_u
      let onStylusButtonUp                         (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (onStylusButtonUp_rf, onStylusButtonUp_uf, f)
      
      let private onPreviewStylusButtonDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonDown.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
      let private onPreviewStylusButtonDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonDown.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
      let private onPreviewStylusButtonDown_rf = onPreviewStylusButtonDown_r
      let private onPreviewStylusButtonDown_uf = onPreviewStylusButtonDown_u
      let onPreviewStylusButtonDown                (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (onPreviewStylusButtonDown_rf, onPreviewStylusButtonDown_uf, f)
      
      let private onPreviewStylusButtonUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonUp.AddHandler    (System.Windows.Input.StylusButtonEventHandler h)
      let private onPreviewStylusButtonUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.StylusButtonEventArgs -> unit) = o.PreviewStylusButtonUp.RemoveHandler (System.Windows.Input.StylusButtonEventHandler h)
      let private onPreviewStylusButtonUp_rf = onPreviewStylusButtonUp_r
      let private onPreviewStylusButtonUp_uf = onPreviewStylusButtonUp_u
      let onPreviewStylusButtonUp                  (f : System.Windows.UIElement -> System.Windows.Input.StylusButtonEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs> (onPreviewStylusButtonUp_rf, onPreviewStylusButtonUp_uf, f)
      
      let private onPreviewKeyDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyDown.AddHandler    (System.Windows.Input.KeyEventHandler h)
      let private onPreviewKeyDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyDown.RemoveHandler (System.Windows.Input.KeyEventHandler h)
      let private onPreviewKeyDown_rf = onPreviewKeyDown_r
      let private onPreviewKeyDown_uf = onPreviewKeyDown_u
      let onPreviewKeyDown                         (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (onPreviewKeyDown_rf, onPreviewKeyDown_uf, f)
      
      let private onKeyDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyDown.AddHandler    (System.Windows.Input.KeyEventHandler h)
      let private onKeyDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyDown.RemoveHandler (System.Windows.Input.KeyEventHandler h)
      let private onKeyDown_rf = onKeyDown_r
      let private onKeyDown_uf = onKeyDown_u
      let onKeyDown                                (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (onKeyDown_rf, onKeyDown_uf, f)
      
      let private onPreviewKeyUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyUp.AddHandler    (System.Windows.Input.KeyEventHandler h)
      let private onPreviewKeyUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.PreviewKeyUp.RemoveHandler (System.Windows.Input.KeyEventHandler h)
      let private onPreviewKeyUp_rf = onPreviewKeyUp_r
      let private onPreviewKeyUp_uf = onPreviewKeyUp_u
      let onPreviewKeyUp                           (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (onPreviewKeyUp_rf, onPreviewKeyUp_uf, f)
      
      let private onKeyUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyUp.AddHandler    (System.Windows.Input.KeyEventHandler h)
      let private onKeyUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyEventArgs -> unit) = o.KeyUp.RemoveHandler (System.Windows.Input.KeyEventHandler h)
      let private onKeyUp_rf = onKeyUp_r
      let private onKeyUp_uf = onKeyUp_u
      let onKeyUp                                  (f : System.Windows.UIElement -> System.Windows.Input.KeyEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs> (onKeyUp_rf, onKeyUp_uf, f)
      
      let private onPreviewGotKeyboardFocus_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewGotKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onPreviewGotKeyboardFocus_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewGotKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onPreviewGotKeyboardFocus_rf = onPreviewGotKeyboardFocus_r
      let private onPreviewGotKeyboardFocus_uf = onPreviewGotKeyboardFocus_u
      let onPreviewGotKeyboardFocus                (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (onPreviewGotKeyboardFocus_rf, onPreviewGotKeyboardFocus_uf, f)
      
      let private onGotKeyboardFocus_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.GotKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onGotKeyboardFocus_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.GotKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onGotKeyboardFocus_rf = onGotKeyboardFocus_r
      let private onGotKeyboardFocus_uf = onGotKeyboardFocus_u
      let onGotKeyboardFocus                       (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (onGotKeyboardFocus_rf, onGotKeyboardFocus_uf, f)
      
      let private onPreviewLostKeyboardFocus_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewLostKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onPreviewLostKeyboardFocus_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.PreviewLostKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onPreviewLostKeyboardFocus_rf = onPreviewLostKeyboardFocus_r
      let private onPreviewLostKeyboardFocus_uf = onPreviewLostKeyboardFocus_u
      let onPreviewLostKeyboardFocus               (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (onPreviewLostKeyboardFocus_rf, onPreviewLostKeyboardFocus_uf, f)
      
      let private onLostKeyboardFocus_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.LostKeyboardFocus.AddHandler    (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onLostKeyboardFocus_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.KeyboardFocusChangedEventArgs -> unit) = o.LostKeyboardFocus.RemoveHandler (System.Windows.Input.KeyboardFocusChangedEventHandler h)
      let private onLostKeyboardFocus_rf = onLostKeyboardFocus_r
      let private onLostKeyboardFocus_uf = onLostKeyboardFocus_u
      let onLostKeyboardFocus                      (f : System.Windows.UIElement -> System.Windows.Input.KeyboardFocusChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs> (onLostKeyboardFocus_rf, onLostKeyboardFocus_uf, f)
      
      let private onPreviewTextInput_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.PreviewTextInput.AddHandler    (System.Windows.Input.TextCompositionEventHandler h)
      let private onPreviewTextInput_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.PreviewTextInput.RemoveHandler (System.Windows.Input.TextCompositionEventHandler h)
      let private onPreviewTextInput_rf = onPreviewTextInput_r
      let private onPreviewTextInput_uf = onPreviewTextInput_u
      let onPreviewTextInput                       (f : System.Windows.UIElement -> System.Windows.Input.TextCompositionEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> (onPreviewTextInput_rf, onPreviewTextInput_uf, f)
      
      let private onTextInput_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.TextInput.AddHandler    (System.Windows.Input.TextCompositionEventHandler h)
      let private onTextInput_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TextCompositionEventArgs -> unit) = o.TextInput.RemoveHandler (System.Windows.Input.TextCompositionEventHandler h)
      let private onTextInput_rf = onTextInput_r
      let private onTextInput_uf = onTextInput_u
      let onTextInput                              (f : System.Windows.UIElement -> System.Windows.Input.TextCompositionEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs> (onTextInput_rf, onTextInput_uf, f)
      
      let private onPreviewQueryContinueDrag_r (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.PreviewQueryContinueDrag.AddHandler    (System.Windows.QueryContinueDragEventHandler h)
      let private onPreviewQueryContinueDrag_u (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.PreviewQueryContinueDrag.RemoveHandler (System.Windows.QueryContinueDragEventHandler h)
      let private onPreviewQueryContinueDrag_rf = onPreviewQueryContinueDrag_r
      let private onPreviewQueryContinueDrag_uf = onPreviewQueryContinueDrag_u
      let onPreviewQueryContinueDrag               (f : System.Windows.UIElement -> System.Windows.QueryContinueDragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> (onPreviewQueryContinueDrag_rf, onPreviewQueryContinueDrag_uf, f)
      
      let private onQueryContinueDrag_r (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.QueryContinueDrag.AddHandler    (System.Windows.QueryContinueDragEventHandler h)
      let private onQueryContinueDrag_u (o : System.Windows.UIElement) (h : obj -> System.Windows.QueryContinueDragEventArgs -> unit) = o.QueryContinueDrag.RemoveHandler (System.Windows.QueryContinueDragEventHandler h)
      let private onQueryContinueDrag_rf = onQueryContinueDrag_r
      let private onQueryContinueDrag_uf = onQueryContinueDrag_u
      let onQueryContinueDrag                      (f : System.Windows.UIElement -> System.Windows.QueryContinueDragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs> (onQueryContinueDrag_rf, onQueryContinueDrag_uf, f)
      
      let private onPreviewGiveFeedback_r (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.PreviewGiveFeedback.AddHandler    (System.Windows.GiveFeedbackEventHandler h)
      let private onPreviewGiveFeedback_u (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.PreviewGiveFeedback.RemoveHandler (System.Windows.GiveFeedbackEventHandler h)
      let private onPreviewGiveFeedback_rf = onPreviewGiveFeedback_r
      let private onPreviewGiveFeedback_uf = onPreviewGiveFeedback_u
      let onPreviewGiveFeedback                    (f : System.Windows.UIElement -> System.Windows.GiveFeedbackEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> (onPreviewGiveFeedback_rf, onPreviewGiveFeedback_uf, f)
      
      let private onGiveFeedback_r (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.GiveFeedback.AddHandler    (System.Windows.GiveFeedbackEventHandler h)
      let private onGiveFeedback_u (o : System.Windows.UIElement) (h : obj -> System.Windows.GiveFeedbackEventArgs -> unit) = o.GiveFeedback.RemoveHandler (System.Windows.GiveFeedbackEventHandler h)
      let private onGiveFeedback_rf = onGiveFeedback_r
      let private onGiveFeedback_uf = onGiveFeedback_u
      let onGiveFeedback                           (f : System.Windows.UIElement -> System.Windows.GiveFeedbackEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs> (onGiveFeedback_rf, onGiveFeedback_uf, f)
      
      let private onPreviewDragEnter_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragEnter.AddHandler    (System.Windows.DragEventHandler h)
      let private onPreviewDragEnter_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragEnter.RemoveHandler (System.Windows.DragEventHandler h)
      let private onPreviewDragEnter_rf = onPreviewDragEnter_r
      let private onPreviewDragEnter_uf = onPreviewDragEnter_u
      let onPreviewDragEnter                       (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onPreviewDragEnter_rf, onPreviewDragEnter_uf, f)
      
      let private onDragEnter_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragEnter.AddHandler    (System.Windows.DragEventHandler h)
      let private onDragEnter_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragEnter.RemoveHandler (System.Windows.DragEventHandler h)
      let private onDragEnter_rf = onDragEnter_r
      let private onDragEnter_uf = onDragEnter_u
      let onDragEnter                              (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onDragEnter_rf, onDragEnter_uf, f)
      
      let private onPreviewDragOver_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragOver.AddHandler    (System.Windows.DragEventHandler h)
      let private onPreviewDragOver_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragOver.RemoveHandler (System.Windows.DragEventHandler h)
      let private onPreviewDragOver_rf = onPreviewDragOver_r
      let private onPreviewDragOver_uf = onPreviewDragOver_u
      let onPreviewDragOver                        (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onPreviewDragOver_rf, onPreviewDragOver_uf, f)
      
      let private onDragOver_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragOver.AddHandler    (System.Windows.DragEventHandler h)
      let private onDragOver_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragOver.RemoveHandler (System.Windows.DragEventHandler h)
      let private onDragOver_rf = onDragOver_r
      let private onDragOver_uf = onDragOver_u
      let onDragOver                               (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onDragOver_rf, onDragOver_uf, f)
      
      let private onPreviewDragLeave_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragLeave.AddHandler    (System.Windows.DragEventHandler h)
      let private onPreviewDragLeave_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDragLeave.RemoveHandler (System.Windows.DragEventHandler h)
      let private onPreviewDragLeave_rf = onPreviewDragLeave_r
      let private onPreviewDragLeave_uf = onPreviewDragLeave_u
      let onPreviewDragLeave                       (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onPreviewDragLeave_rf, onPreviewDragLeave_uf, f)
      
      let private onDragLeave_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragLeave.AddHandler    (System.Windows.DragEventHandler h)
      let private onDragLeave_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.DragLeave.RemoveHandler (System.Windows.DragEventHandler h)
      let private onDragLeave_rf = onDragLeave_r
      let private onDragLeave_uf = onDragLeave_u
      let onDragLeave                              (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onDragLeave_rf, onDragLeave_uf, f)
      
      let private onPreviewDrop_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDrop.AddHandler    (System.Windows.DragEventHandler h)
      let private onPreviewDrop_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.PreviewDrop.RemoveHandler (System.Windows.DragEventHandler h)
      let private onPreviewDrop_rf = onPreviewDrop_r
      let private onPreviewDrop_uf = onPreviewDrop_u
      let onPreviewDrop                            (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onPreviewDrop_rf, onPreviewDrop_uf, f)
      
      let private onDrop_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.Drop.AddHandler    (System.Windows.DragEventHandler h)
      let private onDrop_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DragEventArgs -> unit) = o.Drop.RemoveHandler (System.Windows.DragEventHandler h)
      let private onDrop_rf = onDrop_r
      let private onDrop_uf = onDrop_u
      let onDrop                                   (f : System.Windows.UIElement -> System.Windows.DragEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DragEventHandler, System.Windows.DragEventArgs> (onDrop_rf, onDrop_uf, f)
      
      let private onPreviewTouchDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchDown.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onPreviewTouchDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchDown.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onPreviewTouchDown_rf = onPreviewTouchDown_r
      let private onPreviewTouchDown_uf = onPreviewTouchDown_u
      let onPreviewTouchDown                       (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onPreviewTouchDown_rf, onPreviewTouchDown_uf, f)
      
      let private onTouchDown_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchDown.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchDown_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchDown.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchDown_rf = onTouchDown_r
      let private onTouchDown_uf = onTouchDown_u
      let onTouchDown                              (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onTouchDown_rf, onTouchDown_uf, f)
      
      let private onPreviewTouchMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchMove.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onPreviewTouchMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchMove.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onPreviewTouchMove_rf = onPreviewTouchMove_r
      let private onPreviewTouchMove_uf = onPreviewTouchMove_u
      let onPreviewTouchMove                       (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onPreviewTouchMove_rf, onPreviewTouchMove_uf, f)
      
      let private onTouchMove_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchMove.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchMove_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchMove.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchMove_rf = onTouchMove_r
      let private onTouchMove_uf = onTouchMove_u
      let onTouchMove                              (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onTouchMove_rf, onTouchMove_uf, f)
      
      let private onPreviewTouchUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchUp.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onPreviewTouchUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.PreviewTouchUp.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onPreviewTouchUp_rf = onPreviewTouchUp_r
      let private onPreviewTouchUp_uf = onPreviewTouchUp_u
      let onPreviewTouchUp                         (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onPreviewTouchUp_rf, onPreviewTouchUp_uf, f)
      
      let private onTouchUp_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchUp.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchUp_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchUp.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchUp_rf = onTouchUp_r
      let private onTouchUp_uf = onTouchUp_u
      let onTouchUp                                (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onTouchUp_rf, onTouchUp_uf, f)
      
      let private onGotTouchCapture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.GotTouchCapture.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onGotTouchCapture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.GotTouchCapture.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onGotTouchCapture_rf = onGotTouchCapture_r
      let private onGotTouchCapture_uf = onGotTouchCapture_u
      let onGotTouchCapture                        (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onGotTouchCapture_rf, onGotTouchCapture_uf, f)
      
      let private onLostTouchCapture_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.LostTouchCapture.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onLostTouchCapture_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.LostTouchCapture.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onLostTouchCapture_rf = onLostTouchCapture_r
      let private onLostTouchCapture_uf = onLostTouchCapture_u
      let onLostTouchCapture                       (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onLostTouchCapture_rf, onLostTouchCapture_uf, f)
      
      let private onTouchEnter_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchEnter.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchEnter_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchEnter.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchEnter_rf = onTouchEnter_r
      let private onTouchEnter_uf = onTouchEnter_u
      let onTouchEnter                             (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onTouchEnter_rf, onTouchEnter_uf, f)
      
      let private onTouchLeave_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchLeave.AddHandler    (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchLeave_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.TouchEventArgs -> unit) = o.TouchLeave.RemoveHandler (System.EventHandler<System.Windows.Input.TouchEventArgs> h)
      let private onTouchLeave_rf = onTouchLeave_r
      let private onTouchLeave_uf = onTouchLeave_u
      let onTouchLeave                             (f : System.Windows.UIElement -> System.Windows.Input.TouchEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs> (onTouchLeave_rf, onTouchLeave_uf, f)
      
      let private onIsMouseDirectlyOverChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseDirectlyOverChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsMouseDirectlyOverChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseDirectlyOverChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsMouseDirectlyOverChanged_rf = onIsMouseDirectlyOverChanged_r
      let private onIsMouseDirectlyOverChanged_uf = onIsMouseDirectlyOverChanged_u
      let onIsMouseDirectlyOverChanged             (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsMouseDirectlyOverChanged_rf, onIsMouseDirectlyOverChanged_uf, f)
      
      let private onIsKeyboardFocusWithinChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusWithinChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsKeyboardFocusWithinChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusWithinChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsKeyboardFocusWithinChanged_rf = onIsKeyboardFocusWithinChanged_r
      let private onIsKeyboardFocusWithinChanged_uf = onIsKeyboardFocusWithinChanged_u
      let onIsKeyboardFocusWithinChanged           (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsKeyboardFocusWithinChanged_rf, onIsKeyboardFocusWithinChanged_uf, f)
      
      let private onIsMouseCapturedChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCapturedChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsMouseCapturedChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCapturedChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsMouseCapturedChanged_rf = onIsMouseCapturedChanged_r
      let private onIsMouseCapturedChanged_uf = onIsMouseCapturedChanged_u
      let onIsMouseCapturedChanged                 (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsMouseCapturedChanged_rf, onIsMouseCapturedChanged_uf, f)
      
      let private onIsMouseCaptureWithinChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCaptureWithinChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsMouseCaptureWithinChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsMouseCaptureWithinChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsMouseCaptureWithinChanged_rf = onIsMouseCaptureWithinChanged_r
      let private onIsMouseCaptureWithinChanged_uf = onIsMouseCaptureWithinChanged_u
      let onIsMouseCaptureWithinChanged            (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsMouseCaptureWithinChanged_rf, onIsMouseCaptureWithinChanged_uf, f)
      
      let private onIsStylusDirectlyOverChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusDirectlyOverChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsStylusDirectlyOverChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusDirectlyOverChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsStylusDirectlyOverChanged_rf = onIsStylusDirectlyOverChanged_r
      let private onIsStylusDirectlyOverChanged_uf = onIsStylusDirectlyOverChanged_u
      let onIsStylusDirectlyOverChanged            (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsStylusDirectlyOverChanged_rf, onIsStylusDirectlyOverChanged_uf, f)
      
      let private onIsStylusCapturedChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCapturedChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsStylusCapturedChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCapturedChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsStylusCapturedChanged_rf = onIsStylusCapturedChanged_r
      let private onIsStylusCapturedChanged_uf = onIsStylusCapturedChanged_u
      let onIsStylusCapturedChanged                (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsStylusCapturedChanged_rf, onIsStylusCapturedChanged_uf, f)
      
      let private onIsStylusCaptureWithinChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCaptureWithinChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsStylusCaptureWithinChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsStylusCaptureWithinChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsStylusCaptureWithinChanged_rf = onIsStylusCaptureWithinChanged_r
      let private onIsStylusCaptureWithinChanged_uf = onIsStylusCaptureWithinChanged_u
      let onIsStylusCaptureWithinChanged           (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsStylusCaptureWithinChanged_rf, onIsStylusCaptureWithinChanged_uf, f)
      
      let private onIsKeyboardFocusedChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusedChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsKeyboardFocusedChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsKeyboardFocusedChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsKeyboardFocusedChanged_rf = onIsKeyboardFocusedChanged_r
      let private onIsKeyboardFocusedChanged_uf = onIsKeyboardFocusedChanged_u
      let onIsKeyboardFocusedChanged               (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsKeyboardFocusedChanged_rf, onIsKeyboardFocusedChanged_uf, f)
      
      let private onLayoutUpdated_r (o : System.Windows.UIElement) (h : obj -> System.EventArgs -> unit) = o.LayoutUpdated.AddHandler    (System.EventHandler h)
      let private onLayoutUpdated_u (o : System.Windows.UIElement) (h : obj -> System.EventArgs -> unit) = o.LayoutUpdated.RemoveHandler (System.EventHandler h)
      let private onLayoutUpdated_rf = onLayoutUpdated_r
      let private onLayoutUpdated_uf = onLayoutUpdated_u
      let onLayoutUpdated                          (f : System.Windows.UIElement -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler, System.EventArgs> (onLayoutUpdated_rf, onLayoutUpdated_uf, f)
      
      let private onGotFocus_r (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.GotFocus.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onGotFocus_u (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.GotFocus.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onGotFocus_rf = onGotFocus_r
      let private onGotFocus_uf = onGotFocus_u
      let onGotFocus                               (f : System.Windows.UIElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onGotFocus_rf, onGotFocus_uf, f)
      
      let private onLostFocus_r (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.LostFocus.AddHandler    (System.Windows.RoutedEventHandler h)
      let private onLostFocus_u (o : System.Windows.UIElement) (h : obj -> System.Windows.RoutedEventArgs -> unit) = o.LostFocus.RemoveHandler (System.Windows.RoutedEventHandler h)
      let private onLostFocus_rf = onLostFocus_r
      let private onLostFocus_uf = onLostFocus_u
      let onLostFocus                              (f : System.Windows.UIElement -> System.Windows.RoutedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs> (onLostFocus_rf, onLostFocus_uf, f)
      
      let private onIsEnabledChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsEnabledChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsEnabledChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsEnabledChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsEnabledChanged_rf = onIsEnabledChanged_r
      let private onIsEnabledChanged_uf = onIsEnabledChanged_u
      let onIsEnabledChanged                       (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsEnabledChanged_rf, onIsEnabledChanged_uf, f)
      
      let private onIsHitTestVisibleChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsHitTestVisibleChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsHitTestVisibleChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsHitTestVisibleChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsHitTestVisibleChanged_rf = onIsHitTestVisibleChanged_r
      let private onIsHitTestVisibleChanged_uf = onIsHitTestVisibleChanged_u
      let onIsHitTestVisibleChanged                (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsHitTestVisibleChanged_rf, onIsHitTestVisibleChanged_uf, f)
      
      let private onIsVisibleChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsVisibleChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsVisibleChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.IsVisibleChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onIsVisibleChanged_rf = onIsVisibleChanged_r
      let private onIsVisibleChanged_uf = onIsVisibleChanged_u
      let onIsVisibleChanged                       (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onIsVisibleChanged_rf, onIsVisibleChanged_uf, f)
      
      let private onFocusableChanged_r (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.FocusableChanged.AddHandler    (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onFocusableChanged_u (o : System.Windows.UIElement) (h : obj -> System.Windows.DependencyPropertyChangedEventArgs -> unit) = o.FocusableChanged.RemoveHandler (System.Windows.DependencyPropertyChangedEventHandler h)
      let private onFocusableChanged_rf = onFocusableChanged_r
      let private onFocusableChanged_uf = onFocusableChanged_u
      let onFocusableChanged                       (f : System.Windows.UIElement -> System.Windows.DependencyPropertyChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs> (onFocusableChanged_rf, onFocusableChanged_uf, f)
      
      let private onManipulationStarting_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartingEventArgs -> unit) = o.ManipulationStarting.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs> h)
      let private onManipulationStarting_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartingEventArgs -> unit) = o.ManipulationStarting.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs> h)
      let private onManipulationStarting_rf = onManipulationStarting_r
      let private onManipulationStarting_uf = onManipulationStarting_u
      let onManipulationStarting                   (f : System.Windows.UIElement -> System.Windows.Input.ManipulationStartingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>, System.Windows.Input.ManipulationStartingEventArgs> (onManipulationStarting_rf, onManipulationStarting_uf, f)
      
      let private onManipulationStarted_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartedEventArgs -> unit) = o.ManipulationStarted.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs> h)
      let private onManipulationStarted_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationStartedEventArgs -> unit) = o.ManipulationStarted.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs> h)
      let private onManipulationStarted_rf = onManipulationStarted_r
      let private onManipulationStarted_uf = onManipulationStarted_u
      let onManipulationStarted                    (f : System.Windows.UIElement -> System.Windows.Input.ManipulationStartedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs> (onManipulationStarted_rf, onManipulationStarted_uf, f)
      
      let private onManipulationDelta_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationDeltaEventArgs -> unit) = o.ManipulationDelta.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs> h)
      let private onManipulationDelta_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationDeltaEventArgs -> unit) = o.ManipulationDelta.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs> h)
      let private onManipulationDelta_rf = onManipulationDelta_r
      let private onManipulationDelta_uf = onManipulationDelta_u
      let onManipulationDelta                      (f : System.Windows.UIElement -> System.Windows.Input.ManipulationDeltaEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs> (onManipulationDelta_rf, onManipulationDelta_uf, f)
      
      let private onManipulationInertiaStarting_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationInertiaStartingEventArgs -> unit) = o.ManipulationInertiaStarting.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs> h)
      let private onManipulationInertiaStarting_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationInertiaStartingEventArgs -> unit) = o.ManipulationInertiaStarting.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs> h)
      let private onManipulationInertiaStarting_rf = onManipulationInertiaStarting_r
      let private onManipulationInertiaStarting_uf = onManipulationInertiaStarting_u
      let onManipulationInertiaStarting            (f : System.Windows.UIElement -> System.Windows.Input.ManipulationInertiaStartingEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>, System.Windows.Input.ManipulationInertiaStartingEventArgs> (onManipulationInertiaStarting_rf, onManipulationInertiaStarting_uf, f)
      
      let private onManipulationBoundaryFeedback_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationBoundaryFeedbackEventArgs -> unit) = o.ManipulationBoundaryFeedback.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> h)
      let private onManipulationBoundaryFeedback_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationBoundaryFeedbackEventArgs -> unit) = o.ManipulationBoundaryFeedback.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> h)
      let private onManipulationBoundaryFeedback_rf = onManipulationBoundaryFeedback_r
      let private onManipulationBoundaryFeedback_uf = onManipulationBoundaryFeedback_u
      let onManipulationBoundaryFeedback           (f : System.Windows.UIElement -> System.Windows.Input.ManipulationBoundaryFeedbackEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> (onManipulationBoundaryFeedback_rf, onManipulationBoundaryFeedback_uf, f)
      
      let private onManipulationCompleted_r (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationCompletedEventArgs -> unit) = o.ManipulationCompleted.AddHandler    (System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs> h)
      let private onManipulationCompleted_u (o : System.Windows.UIElement) (h : obj -> System.Windows.Input.ManipulationCompletedEventArgs -> unit) = o.ManipulationCompleted.RemoveHandler (System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs> h)
      let private onManipulationCompleted_rf = onManipulationCompleted_r
      let private onManipulationCompleted_uf = onManipulationCompleted_u
      let onManipulationCompleted                  (f : System.Windows.UIElement -> System.Windows.Input.ManipulationCompletedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.UIElement, System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs> (onManipulationCompleted_rf, onManipulationCompleted_uf, f)

    let uniformGrid                              values children =
      StandardPanelView<UniformGrid> (values, children) :> View
    module UniformGrid = 
      open Dummy
      let firstColumn                              v = SetConstantValue<_> (Properties.UniformGrid.firstColumn, v)
      let columns                                  v = SetConstantValue<_> (Properties.UniformGrid.columns, v)
      let rows                                     v = SetConstantValue<_> (Properties.UniformGrid.rows, v)

    let userControl                              values child =
      StandardContentView<UserControl> (values, child) :> View
    module UserControl = 
      open Dummy

    let viewbox                                  values =
      StandardView<Viewbox> (values) :> View
    module Viewbox = 
      open Dummy
      let stretch                                  v = SetConstantValue<_> (Properties.Viewbox.stretch, v)
      let stretchDirection                         v = SetConstantValue<_> (Properties.Viewbox.stretchDirection, v)

    let viewport3D                               values =
      StandardView<Viewport3D> (values) :> View
    module Viewport3D = 
      open Dummy
      let camera                                   v = SetConstantValue<_> (Properties.Viewport3D.camera, v)
      let children                                 v = SetConstantValue<_> (Properties.Viewport3D.children, v)

    module VirtualizingPanel = 
      open Dummy
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
      open Dummy
      let isVirtualizing                           v = SetConstantValue<_> (Properties.VirtualizingStackPanel.isVirtualizing, v)
      let virtualizationMode                       v = SetConstantValue<_> (Properties.VirtualizingStackPanel.virtualizationMode, v)
      let orientation                              v = SetConstantValue<_> (Properties.VirtualizingStackPanel.orientation, v)

    let webBrowser                               values =
      StandardView<WebBrowser> (values) :> View
    module WebBrowser = 
      open Dummy
      
      let private onNavigating_r (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.AddHandler    (System.Windows.Navigation.NavigatingCancelEventHandler h)
      let private onNavigating_u (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigatingCancelEventArgs -> unit) = o.Navigating.RemoveHandler (System.Windows.Navigation.NavigatingCancelEventHandler h)
      let private onNavigating_rf = onNavigating_r
      let private onNavigating_uf = onNavigating_u
      let onNavigating                             (f : System.Windows.Controls.WebBrowser -> System.Windows.Navigation.NavigatingCancelEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.WebBrowser, System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs> (onNavigating_rf, onNavigating_uf, f)
      
      let private onNavigated_r (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.AddHandler    (System.Windows.Navigation.NavigatedEventHandler h)
      let private onNavigated_u (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.Navigated.RemoveHandler (System.Windows.Navigation.NavigatedEventHandler h)
      let private onNavigated_rf = onNavigated_r
      let private onNavigated_uf = onNavigated_u
      let onNavigated                              (f : System.Windows.Controls.WebBrowser -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.WebBrowser, System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onNavigated_rf, onNavigated_uf, f)
      
      let private onLoadCompleted_r (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.AddHandler    (System.Windows.Navigation.LoadCompletedEventHandler h)
      let private onLoadCompleted_u (o : System.Windows.Controls.WebBrowser) (h : obj -> System.Windows.Navigation.NavigationEventArgs -> unit) = o.LoadCompleted.RemoveHandler (System.Windows.Navigation.LoadCompletedEventHandler h)
      let private onLoadCompleted_rf = onLoadCompleted_r
      let private onLoadCompleted_uf = onLoadCompleted_u
      let onLoadCompleted                          (f : System.Windows.Controls.WebBrowser -> System.Windows.Navigation.NavigationEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Controls.WebBrowser, System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs> (onLoadCompleted_rf, onLoadCompleted_uf, f)

    let window                                   values child =
      StandardContentView<Window> (values, child) :> View
    module Window = 
      open Dummy
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
      
      let private onSourceInitialized_r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.SourceInitialized.AddHandler    (System.EventHandler h)
      let private onSourceInitialized_u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.SourceInitialized.RemoveHandler (System.EventHandler h)
      let private onSourceInitialized_rf = onSourceInitialized_r
      let private onSourceInitialized_uf = onSourceInitialized_u
      let onSourceInitialized                      (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (onSourceInitialized_rf, onSourceInitialized_uf, f)
      
      let private onDpiChanged_r (o : System.Windows.Window) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.AddHandler    (System.Windows.DpiChangedEventHandler h)
      let private onDpiChanged_u (o : System.Windows.Window) (h : obj -> System.Windows.DpiChangedEventArgs -> unit) = o.DpiChanged.RemoveHandler (System.Windows.DpiChangedEventHandler h)
      let private onDpiChanged_rf = onDpiChanged_r
      let private onDpiChanged_uf = onDpiChanged_u
      let onDpiChanged                             (f : System.Windows.Window -> System.Windows.DpiChangedEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.Windows.DpiChangedEventHandler, System.Windows.DpiChangedEventArgs> (onDpiChanged_rf, onDpiChanged_uf, f)
      
      let private onActivated_r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Activated.AddHandler    (System.EventHandler h)
      let private onActivated_u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Activated.RemoveHandler (System.EventHandler h)
      let private onActivated_rf = onActivated_r
      let private onActivated_uf = onActivated_u
      let onActivated                              (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (onActivated_rf, onActivated_uf, f)
      
      let private onDeactivated_r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Deactivated.AddHandler    (System.EventHandler h)
      let private onDeactivated_u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Deactivated.RemoveHandler (System.EventHandler h)
      let private onDeactivated_rf = onDeactivated_r
      let private onDeactivated_uf = onDeactivated_u
      let onDeactivated                            (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (onDeactivated_rf, onDeactivated_uf, f)
      
      let private onStateChanged_r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.StateChanged.AddHandler    (System.EventHandler h)
      let private onStateChanged_u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.StateChanged.RemoveHandler (System.EventHandler h)
      let private onStateChanged_rf = onStateChanged_r
      let private onStateChanged_uf = onStateChanged_u
      let onStateChanged                           (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (onStateChanged_rf, onStateChanged_uf, f)
      
      let private onLocationChanged_r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.LocationChanged.AddHandler    (System.EventHandler h)
      let private onLocationChanged_u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.LocationChanged.RemoveHandler (System.EventHandler h)
      let private onLocationChanged_rf = onLocationChanged_r
      let private onLocationChanged_uf = onLocationChanged_u
      let onLocationChanged                        (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (onLocationChanged_rf, onLocationChanged_uf, f)
      
      let private onClosing_r (o : System.Windows.Window) (h : obj -> System.ComponentModel.CancelEventArgs -> unit) = o.Closing.AddHandler    (System.ComponentModel.CancelEventHandler h)
      let private onClosing_u (o : System.Windows.Window) (h : obj -> System.ComponentModel.CancelEventArgs -> unit) = o.Closing.RemoveHandler (System.ComponentModel.CancelEventHandler h)
      let private onClosing_rf = onClosing_r
      let private onClosing_uf = onClosing_u
      let onClosing                                (f : System.Windows.Window -> System.ComponentModel.CancelEventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs> (onClosing_rf, onClosing_uf, f)
      
      let private onClosed_r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Closed.AddHandler    (System.EventHandler h)
      let private onClosed_u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.Closed.RemoveHandler (System.EventHandler h)
      let private onClosed_rf = onClosed_r
      let private onClosed_uf = onClosed_u
      let onClosed                                 (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (onClosed_rf, onClosed_uf, f)
      
      let private onContentRendered_r (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.AddHandler    (System.EventHandler h)
      let private onContentRendered_u (o : System.Windows.Window) (h : obj -> System.EventArgs -> unit) = o.ContentRendered.RemoveHandler (System.EventHandler h)
      let private onContentRendered_rf = onContentRendered_r
      let private onContentRendered_uf = onContentRendered_u
      let onContentRendered                        (f : System.Windows.Window -> System.EventArgs-> 'TMessage) = 
        OnChangedValue<'TMessage, System.Windows.Window, System.EventHandler, System.EventArgs> (onContentRendered_rf, onContentRendered_uf, f)

    let wrapPanel                                values children =
      StandardPanelView<WrapPanel> (values, children) :> View
    module WrapPanel = 
      open Dummy
      let itemWidth                                v = SetConstantValue<_> (Properties.WrapPanel.itemWidth, v)
      let itemHeight                               v = SetConstantValue<_> (Properties.WrapPanel.itemHeight, v)
      let orientation                              v = SetConstantValue<_> (Properties.WrapPanel.orientation, v)

