---
-api-id: T:Microsoft.Windows.Widgets.WidgetSize
-api-type: winrt enum
---

# Microsoft.Windows.Widgets.WidgetSize

<!--
public enum WidgetSize
-->


## -description

Specifies the display size of a widget within the widget host.

## -enum-fields

### -field Small: 0

Small.

### -field Medium: 1

Medium.

### -field Large: 2

Large.

## -remarks

Query the currently displayed size of widget by calling <xref:Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfo(System.String)?displayProperty=nameWithType> or <xref:Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfos?displayProperty=nameWithType>. The <xref:Microsoft.Windows.Widgets.Providers.IWidgetProvider.OnWidgetContextChanged(Microsoft.Windows.Widgets.Providers.WidgetContextChangedArgs)?displayProperty=nameWithType> callback is called when the current display size of the widget changes.

## -see-also

## -examples


