---
-api-id: M:Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfo(System.String)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfo(System.String)

<!--
public Microsoft.Windows.Widgets.Providers.WidgetInfo GetWidgetInfo (string widgetId);
-->


## -description

Gets a <xref:Microsoft.Windows.Widgets.Providers.WidgetInfo> object containing information about the widget with the provided widget ID, including the visual template, data template, custom state, the last update time, and context information from the widget host.

## -parameters

### -param widgetId

The unique identifier of the widget for which information is retrieved.

## -returns

A **WidgetInfo** object, if the specified ID is associated with a widget associated with the calling app that has not been deleted; otherwise, null.

## -remarks

This method can be used by widget providers when handling a request associated with an unrecognized widget in order to recover the last known state. For example, if you are storing your widgets' states in the <xref:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.CustomState?displayProperty=nameWithType> property, you can use this method during your widget provider's initialization to regenerate the state of your widgets.



## -see-also

## -examples

The following example demonstrates retrieving widget information for one of the widgets owned by the calling app.

```cpp
/*
* Sample output:
* Id: {5E3D9EDF-13A6-4185-902B-5997AE0411A5}
* Template: {
    "type": "AdaptiveCard",
    "$schema": "http://adaptivecards.io/schemas/adaptive-card.json",
    "version": "1.5"
    "body": [
        {
            "type": "TextBlock",
            "text": "${greeting}!"
        }
    ]
}
* Data: {"count": "3"}
* CustomState: 3
* DefinitionName: clickCounter
*/
using namespace std;
using namespace winrt;
using namespace Microsoft::Windows::Widgets::Providers;

class WidgetManagerOperations
{
    void PrintInfoOfWidget(hstring myWidgetId)
    {
        WidgetManager widgetManager = WidgetManager::GetDefault();

        WidgetInfo widgetInfo = widgetManager.GetWidgetInfo(myWidgetId);
        wcout << L"Id - " << L": " << widgetInfo.WidgetContext().Id().c_str() << endl;
        wcout << L"Template: " << widgetInfo.Template().c_str() << endl;
        wcout << L"Data: " << widgetInfo.Data().c_str() << endl;
        wcout << L"CustomState: " << widgetInfo.CustomState().c_str() << endl;
        wcout << L"DefinitionName: " << widgetInfo.WidgetContext().DefinitionName().c_str() << endl;
    }
}
```
