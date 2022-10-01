---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetContext.IsActive
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetContext.IsActive

<!--
public bool IsActive { get; }
-->


## -description

Gets the activation state of the widget. 

## -property-value

True if the widget is active; otherwise, false.

## -remarks

Widget providers are notified when a widget enters and leaves the active state through the <xref:Microsoft.Windows.Widgets.Providers.IWidgetProvider.Activate(Microsoft.Windows.Widgets.Providers.WidgetContext)?displayProperty=nameWithType> and <xref:Microsoft.Windows.Widgets.Providers.IWidgetProvider.Deactivate(System.String)?displayProperty=nameWithType> methods. Widgets are in an active state immediate after <xref:Microsoft.Windows.Widgets.Providers.IWidgetProvider.CreateWidget(Microsoft.Windows.Widgets.Providers.WidgetContext)?displayProperty=nameWithType> is called.

## -see-also

## -examples


