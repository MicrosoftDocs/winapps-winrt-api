---
-api-id: T:Microsoft.UI.Xaml.Controls.AppBar
-api-type: winrt class
---

<!-- Class syntax.
public class AppBar : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IAppBar, Windows.UI.Xaml.Controls.IAppBar2, Windows.UI.Xaml.Controls.IAppBar3, Windows.UI.Xaml.Controls.IAppBar4, Windows.UI.Xaml.Controls.IAppBarOverrides, Windows.UI.Xaml.Controls.IAppBarOverrides3
-->

# Microsoft.UI.Xaml.Controls.AppBar

## -description

Represents the container control that holds app UI components for commanding and experiences.

## -xaml-syntax

```xaml
<AppBar .../>
-or-
<AppBar>
  content
</AppBar>
```

## -remarks

> [!IMPORTANT]
> `AppBar` is the base class for [CommandBar](commandbar.md), which provides greater functionality. We recommend using the [CommandBar](commandbar.md) control in your apps instead of `AppBar`.

You can open and close the app bar programmatically by setting the [IsOpen](appbar_isopen.md) property. You can use the [Opening](appbar_opening.md), [Opened](appbar_opened.md), [Closing](appbar_closing.md), and [Closed](appbar_closed.md) events to respond to the app bar being opened or closed.

By default, the app bar is dismissed (closed) when the user interacts with the app anywhere outside of the app bar. Closing the app bar this way is called *light dismiss*. You can control how the app bar is dismissed by setting the [IsSticky](appbar_issticky.md) property. When the app bar is *sticky*, it's not closed by a *light dismiss* gesture. The app bar remains visible until the user right clicks or presses the ellipsis [***].

## -see-also

[Command bar](/windows/apps/design/controls/command-bar), [AppBarButton](appbarbutton.md), [CommandBar](commandbar.md)
