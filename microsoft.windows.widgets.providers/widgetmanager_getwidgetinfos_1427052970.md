---
-api-id: M:Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfos
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetInfos

<!--
public Microsoft.Windows.Widgets.Providers.WidgetInfo[] GetWidgetInfos ();
-->


## -description

Gets the stored information for all widgets associated with the calling app.

## -returns

An array of <xref:Microsoft.Windows.Widgets.Providers.WidgetInfo> objects containing information about the associated widgets.

## -remarks



## -see-also

## -examples

The following code example demonstrates retrieving the information for all widgets owned by the calling app. This example updates any widgets that have not been updated in a day or longer.

```C++
using namespace std;
using namespace winrt;
using namespace Windows::Foundations;
using namespace Microsoft::Windows::Widgets;
using namespace Microsoft::Windows::Widgets::Providers;

class WidgetManagerOperations
{
    void UpdateWidgetsWith24HourOutdate()
    {
        com_array<WidgetInfo> widgetInfos = WidgetManager::GetDefault().GetWidgetInfos();

        for (const auto widgetInfo : widgetInfos)
        {
            if (widgetInfo.WidgetContext().DefinitionName() == L"clockWidget")
            {
                auto diffInSeconds = static_cast<long long int>(clock::to_time_t(end), clock::to_time_t(beginning));
                auto diffInDays = (((diffInSeconds / 60) / 60) / 24);

                if (diffInDays >= 1)
                {
                    WidgetUpdateRequestOptions options{widgetInfo.WidgetContext().Id()};
                    options.Template(LR"({
                        "type": "AdaptiveCard",
                        "version": "1.5",
                        "body": [
                            {
                                "type": "TextBlock",
                                "text": "Today is: ${date}"
                            }
                        ]
                    })");

                    options.Data(LR"({
                        "date": "05-23-2022"
                    })");

                    widgetManager.UpdateWidget(options);
                }
            }
        }
    }
}
```
