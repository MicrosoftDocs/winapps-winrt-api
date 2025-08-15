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

Widget providers are notified when a widget enters and leaves the active state through the [Microsoft.Windows.Widgets.Providers.IWidgetProvider.Activate](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.iwidgetprovider.activate) and [Microsoft.Windows.Widgets.Providers.IWidgetProvider.Deactivate](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.iwidgetprovider.deactivate) methods. Widgets are in an active state immediate after [Microsoft.Windows.Widgets.Providers.IWidgetProvider.CreateWidget](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.iwidgetprovider.createwidget) is called.

## -see-also

## -examples


