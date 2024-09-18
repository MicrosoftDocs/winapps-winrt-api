---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.UnsetValue
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.UnsetValue

<!--
public static string UnsetValue { get; }
-->


## -description

Gets a sentinel value indicating that the associated property is unset.

## -property-value

A sentinel value indicating that the associated property is unset.

## -remarks

This is the default value for the <ref:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.CustomState>, [Data](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.widgetupdaterequestoptions.data), and [Template](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.widgetupdaterequestoptions.template) properties. If you don't set any value on these properties, they will be treated as unset. Set the properties to empty string to clear the previously set value.

## -see-also

## -examples


