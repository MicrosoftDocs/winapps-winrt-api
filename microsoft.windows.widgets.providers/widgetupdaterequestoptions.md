---
-api-id: T:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions
-api-type: winrt class
---

# Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions

<!--
public sealed class WidgetUpdateRequestOptions
-->


## -description

Provides data for calls to <xref:Microsoft.Windows.Widgets.Providers.WidgetManager.UpdateWidget(Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions)?displayProperty=nameWithType>.

## -remarks

Any variable not set in the **WidgetUpdateRequestOptions** class will not be updated. For example, if you are only interested in updating the widget's data but you want to keep the existing visual template and custom state, then by setting only the <xref:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.Data?displayProperty=nameWithType> property, the widget's data will be updated but the template and custom state will not be modified.

**UpdateWidget** can also be used to clear any stored value by setting an empty string for the value to be cleared. For example, if you want to clear the widget's stored custom state you can set the <xref:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.CustomState?displayProperty=nameWithType> property to an empty string, which will erase the stored custom state once UpdateWidget is called.

## -see-also

## -examples


