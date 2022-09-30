---
-api-id: M:Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetIds
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.WidgetManager.GetWidgetIds

<!--
public string[] GetWidgetIds ();
-->


## -description

Gets all of the widget IDs for widgets associated with the calling provider app.

## -returns

An array of strings containing the widget IDs for widgets associated with the calling provider app.

## -remarks



## -see-also

## -examples

The following code sample demonstrates the retrieval of the widgets IDs associated with the calling widget provider. In this example, the IDs are printed to the console.

```cpp
/*
* Sample output:
* This is the list of widgetIds associated with my app
* WidgetId - 0 : {5E3D9EDF-13A6-4185-902B-5997AE0411A5}
* WidgetId - 1 : {D8FEC89F-9A89-44B1-A52D-F04C515B0141}
*/
using namespace std;
using namespace winrt;
using namespace Microsoft::Windows::Widgets::Providers;

class WidgetManagerOperations
{
    void PrintMyWidgetIds()
    {
        com_array<hstring> widgetIds = WidgetManager::GetDefault().GetWidgetIds();

        cout << "This is the list of widgetIds associated with my app" << endl;
        for (int i{}; i < widgetIds.size(); ++i)
        {
            hstring widgetId = widgetIds.at(i);
            wcout << L"WidgetId - " << i << L" : " << widgetId.c_str() << endl;
        }
    }
}

```
