---
-api-id: T:Microsoft.UI.Xaml.Controls.Frame
-api-type: winrt class
---

<!-- Class syntax.
public class Frame : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IFrame, Windows.UI.Xaml.Controls.IFrame2, Windows.UI.Xaml.Controls.IFrame3, Windows.UI.Xaml.Controls.IFrame4, Windows.UI.Xaml.Controls.INavigate
-->

# Microsoft.UI.Xaml.Controls.Frame

## -description

Displays [Page](page.md) instances, supports navigation to new pages, and maintains a navigation history to support forward and backward navigation.

## -xaml-syntax

```xaml
<Frame .../>
```

## -remarks

You use the `Frame` control to support navigation to [Page](page.md) instances. You create as many different page types as needed to present the content in your app, and then navigate to those pages by calling the [Navigate](frame_navigate_1557370995.md) method and passing in the type of the page to navigate to. You can also pass in a parameter object to initialize the page to a particular state.

The `Frame` maintains a history of pages it has navigated to. You can get the type of the current page through the [CurrentSourcePageType](frame_currentsourcepagetype.md) property, and navigate forward or backward with the [GoBack](frame_goback_1030386674.md) and [GoForward](frame_goforward_1537152893.md) methods. The [CanGoBack](frame_cangoback.md) and [CanGoForward](frame_cangoforward.md) properties indicate whether a page is available in the desired direction. One common practice is to bind the [IsEnabled](control_isenabled.md) properties of navigation buttons to [CanGoBack](frame_cangoback.md) and [CanGoForward](frame_cangoforward.md) so that users can't navigate to a page that doesn't exist.

You can handle the [Navigating](frame_navigating.md), [Navigated](frame_navigated.md), [NavigationStopped](frame_navigationstopped.md), and [NavigationFailed](frame_navigationfailed.md) events to perform high-level tasks such as starting and stopping a "navigation in progress" animation or displaying an error message. For page-level tasks, override the page [OnNavigatedTo](page_onnavigatedto_1316593960.md), [OnNavigatingFrom](page_onnavigatingfrom_1820075439.md), and [OnNavigatedFrom](page_onnavigatedfrom_1545714785.md) methods. This is useful to perform tasks such as initializing and saving the page state.

By default, each navigation creates a new instance of the specific [Page](page.md) subclass requested, and disposes the previous page instance. This happens even when navigating back to a previously visited page or when the new page type is the same as the previous page type. Apps that involve frequent navigation to the same pages can cache and reuse the page instances to make navigation more efficient. To do this, set the [CacheSize](frame_cachesize.md) property to specify how many pages to cache. For each page type that you want to cache, you must also set the [Page.NavigationCacheMode](page_navigationcachemode.md) property to either **Enabled** or **Required**. Pages with a **Required** cache mode are cached regardless of the [CacheSize](frame_cachesize.md) value, and do not count against the [CacheSize](frame_cachesize.md) total.

### INavigate

The [INavigate](inavigate.md) interface is mainly infrastructure. It's not expected that typical app will implement this interface.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Navigation design basics](/windows/apps/design/basics/navigation-basics).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see NavigationView and Frame in action](winui3gallery://item/NavigationView).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

We recommend using a [NavigationView](navigationview.md) for apps that require navigation between pages. The `Frame` is typically placed as the [Content](contentcontrol_content.md) of the `NavigationView`.

```xaml
<Window ... >
    <Grid>
        <NavigationView ...>
            <NavigationView.MenuItems>
                <NavigationViewItem Icon="Home" Content="Home"/>
                <NavigationViewItem Icon="Download" Content="Downloads Page"/>
            </NavigationView.MenuItems>

            <ScrollViewer>
                <Frame x:Name="contentFrame"/>
            </ScrollViewer>
        </NavigationView>
    </Grid>
</Window>
```

For more detailed examples that demonstrate navigation, see the [NavigationView](navigationview.md) class and [Implement navigation between two pages](/windows/apps/design/basics/navigate-between-two-pages).

## -see-also

[Page](page.md), [ContentControl](contentcontrol.md), [INavigate](inavigate.md), [Navigation design basics](/windows/apps/design/basics/navigation-basics), [Page transitions](/windows/apps/design/motion/page-transitions), [NavigationView](navigationview.md), [Implement navigation between two pages](/windows/apps/design/basics/navigate-between-two-pages)
