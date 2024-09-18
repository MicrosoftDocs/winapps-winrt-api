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

Query the currently displayed size of widget by calling [Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfo](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.widgetmanager.getwidgetinfo(system.string)) or [Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfos](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.widgetmanager.getwidgetinfos). The [Microsoft.Windows.Widgets.Providers.IWidgetProvider.OnWidgetContextChanged](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.iwidgetprovider.onwidgetcontextchanged(microsoft.windows.widgets.providers.widgetcontextchangedargs)) callback is called when the current display size of the widget changes.

## -see-also

## -examples


