---
-api-id: E:Microsoft.UI.Xaml.Controls.TabView.TabDroppedOutside
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TabView.TabDroppedOutside

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TabView,Microsoft.UI.Xaml.Controls.TabViewTabDroppedOutsideEventArgs> TabDroppedOutside;
-->

## -description

Occurs when the user completes a drag and drop operation by dropping a tab outside of the TabStrip area. 

## -remarks

You can use this event to create a new window. 

There are different ways that content can be hosted inside an app. The [Show multiple views for an app](/windows/apps/design/layout/show-multiple-views) documentation outlines the various technologies for displaying multiple views or windows. 

The example below uses AppWindow, which is available starting in Windows 10, version 1903 (SDK 18362). AppWindow simplifies the creation of multi-window UWP apps because it operates on the same UI thread that it's created from.

If your app targets Windows 10 versions less than 1903, you will need to use CoreWindow/ApplicationView. The Windows Community Toolkit [TabView tear out sample](https://github.com/windows-toolkit/Sample-TabView-TearOff/tree/master/TabViewTear) demonstrates how to create a multi-window application using CoreWindow/ApplicationView.

## -see-also

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [TabView](/windows/apps/design/controls/tab-view).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the TabView in action](winui3gallery:/item/TabView)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

```xaml
<TabView TabDroppedOutside="TabView_TabDroppedOutside">
```

```csharp
// NOTE: The app is responsible for writing this code. A full sample can be found in the Xaml Controls Gallery.
private async void TabView_TabDroppedOutside(TabView sender, TabDroppedOutsideEventArgs e)
{
    // Create a new AppWindow
    AppWindow newWindow = await AppWindow.TryCreateAsync();

    // Create the content for the new window
    var newPage = new MainPage();

    // Remove tab from existing list
    Tabs.TabItems.Remove(e.Tab);

    // Add tab to list of Tabs on new page
    newPage.AddItemToTabs(e.Tab);

    // Set the Window's content to the new page
    ElementCompositionPreview.SetAppWindowContent(newWindow, newPage);

    // Show the window
    await newWindow.TryShowAsync();
}
```

