---
-api-id: E:Microsoft.UI.Xaml.Window.SizeChanged
-api-type: winrt event
no-loc: [Bounds, Height, Width, Window]
---

<!-- Event syntax
public event Microsoft.UI.Xaml.WindowSizeChangedEventHandler SizeChanged
-->

# Microsoft.UI.Xaml.Window.SizeChanged

## -description

Occurs when the rendering size of the window has changed.

## -remarks

This event occurs whenever there are changes in the [Bounds](window_bounds.md) values for the window. This might be because the user resizes your app or changes the display orientation while the app is maximized. Another trigger is if the user moves your app to a new display that has a different resolution.

Handle the `SizeChanged` event for managing things in your app UI, like moving elements around when the window size changes. XAML uses _effective pixels_ (epx), not actual physical pixels. Effective pixels are a virtual unit of measurement, and they're used to express layout dimensions and spacing, independent of screen density. The Bounds Height and Width values are the same as the [WindowSizeChangedEventArgs](windowsizechangedeventargs.md) Height and Width values, so you can use either in the event handler.

For more info, see [Windowing overview for WinUI and Windows App SDK](/windows/apps/develop/ui-input/windowing-overview).

If you attach a handler for `SizeChanged` at the [Page](../microsoft.ui.xaml.controls/page.md) level within a handler for the [FrameworkElement.Loaded](frameworkelement_loaded.md) event, you should detach the handler in a [FrameworkElement.Unloaded](frameworkelement_unloaded.md) event handler from that [Page](../microsoft.ui.xaml.controls/page.md). The [Window](window.md) instance remains active between page navigations and should only have a handler active for the most current page code.

### Orientation

You may want to detect that the window has changed from landscape to portrait orientation or vice versa. The window orientation might influence how you want the individual controls within the app to appear. For example, you might want to display data lists in a [ListView](../microsoft.ui.xaml.controls/listview.md) for portrait orientation, but in a [GridView](../microsoft.ui.xaml.controls/gridview.md) for landscape orientation. Typically you would compare the ratio of `Width` to `Height` in order to determine the orientation based on the Window [Bounds](window_bounds.md), and you'd do this whenever `Window.SizeChanged` occurs. Exactly how you interpret `Width`/`Height` ratios is up to you.

### Minimum and maximum size

Don't use the `SizeChanged` handler to enforce the minimum or maximum size that your app can be resized to. Instead, use these [OverlappedPresenter](../microsoft.ui.windowing/overlappedpresenter.md) properties:

- [PreferredMinimumHeight](../microsoft.ui.windowing/overlappedpresenter_preferredminimumheight.md)
- [PreferredMinimumWidth](../microsoft.ui.windowing/overlappedpresenter_preferredminimumwidth.md)
- [PreferredMaximumHeight](../microsoft.ui.windowing/overlappedpresenter_preferredmaximumheight.md)
- [PreferredMaximumWidth](../microsoft.ui.windowing/overlappedpresenter_preferredmaximumwidth.md)

However, your logic for changing the visual states should be able to load a state that's designed for the minimum width you intend, and you'd typically use the [Bounds](window_bounds.md) values and `Window.SizeChanged` handling to detect when the app window is using minimum width.

For more info on how to use W`indow.SizeChanged` to detect changes in the app window environment and load the appropriate visual states for your app, see [Responsive layouts with XAML](/windows/apps/design/layout/layouts-with-xaml#adaptive-layouts-with-visual-states-and-state-triggers).

### Other size changed events

There are several other events that you can use to detect size changes.

#### AppWindow

The [AppWindow](../microsoft.ui.windowing/appwindow.md) class has a [Changed](../microsoft.ui.windowing/appwindow_changed.md) event with the [DidSizeChange](../microsoft.ui.windowing/appwindowchangedeventargs_didsizechange.md) value for the event args.

Unlike the XAML Window class, AppWindow uses the [Window Coordinate System](/windows/win32/gdi/window-coordinate-system), where the basic unit of measurement is physical device pixels. So use the the AppWindow APIs for windowing actions, like resizing the window or moving it in relation to something else on the screen.

#### FrameworkElement

There's another event named [SizeChanged](frameworkelement_sizechanged.md) that exists on [FrameworkElement](frameworkelement.md) derived types ([Window](window.md) is not a [FrameworkElement](frameworkelement.md) type). [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) events might occur in many of the same circumstances that cause `Window.SizeChanged` to occur. An app window size change can cause the root visual element (typically a [Page](../microsoft.ui.xaml.controls/page.md) or panel) to change its size. This sets off a cascade of layout invalidations for any sub-elements that use adaptive layout to fill available space. Each element that has new dimensions because of a layout pass will fire its own [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) event.

<!--More work to do here. How does FE.SizeChanged relate? For device orientation change, should be pointing to DisplayInformation.OrientationChanged? It may be that a mix of all three events is what's really needed to account for all resize scenarios.-->

<!--The data in WindowSizeChangedEventArgs seems pretty useless for most scenarios especially if you use Window.Current.Bounds instead of WindowSizeChangedEventArgs.Size. And when would you set to Handled, what does that even do?-->

## -examples

## -see-also

 [WindowSizeChangedEventArgs](windowsizechangedeventargs.md), [Window.Bounds](window_bounds.md), [Window.Content](window_content.md), [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md), [Windowing overview for WinUI and Windows App SDK](/windows/apps/develop/ui-input/windowing-overview), [Responsive layouts with XAML](/windows/apps/design/layout/layouts-with-xaml#adaptive-layouts-with-visual-states-and-state-triggers)
