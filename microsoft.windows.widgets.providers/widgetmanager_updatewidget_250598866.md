---
-api-id: M:Microsoft.Windows.Widgets.Providers.WidgetManager.UpdateWidget(Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.WidgetManager.UpdateWidget(Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions)

<!--
public void UpdateWidget (Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions widgetUpdateRequestOptions);
-->


## -description

Provides updated content for a widget to the widget host.

## -parameters

### -param widgetUpdateRequestOptions

A <xref:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions> object that contains the content with which to update the widget.

## -remarks

Any variable not set in the **WidgetUpdateRequestOptions** class will not be updated. For example, if you are only interested in updating the widget's data but you want to keep the existing visual template and custom state, then by setting only the <xref:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.Data?displayProperty=nameWithType> property, the widget's data will be updated but the template and custom state will not be modified.

**UpdateWidget** can also be used to clear any stored value iby setting an empty string for the value to be cleared. For example, if you want to clear the widget's stored custom state you can set the <xref:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.CustomState?displayProperty=nameWithType> property to an empty string, which will erase the stored custom state once UpdateWidget is called.

Calling this function to update a widget that has been deleted, a widget not associated with your app, or using a widget ID that does not exist will result in the update being ignored.




## -see-also

## -examples

The following code example demonstrates a typical usage of **UpdateWidget**. <xref:Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfos?displayProperty=nameWithType> is called to get the list of <xref:Microsoft.Windows.Widgets.Providers.WidgetInfo> objects for the active widgets associated with the widget provider. For each widget, a visual template and data template are generated and passed to the **UpdateWidget** call in a **WidgetUpdateRequestOptions** object.

```cpp
using namespace winrt;
using namespace Microsoft::Windows::Widgets;
using namespace Microsoft::Windows::Widgets::Providers;

class WidgetManagerOperations
{
    void InitializeWidgets(hstring myWidgetId)
    {
        WidgetManager widgetManager = WidgetManager::GetDefault();
        com_array<WidgetInfo> widgetInfos = widgetManager.GetWidgetInfos();

        for (const auto& widgetInfo : widgetInfos)
        {
            if (widgetInfo.WidgetContext().IsActive())
            {
                WidgetUpdateRequestOptions options{myWidgetId};
                options.Template(LR"({
                    "type": "AdaptiveCard",
                    "version": "1.5",
                    "body": [
                        {
                            "type": "TextBlock",
                            "text": "${greeting}"
                        }
                    ]
                })");

                options.Data(LR"({
                    "greeting": "Hello"
                })");

                widgetManager.UpdateWidget(options);
            }
        }
    }
}
```
