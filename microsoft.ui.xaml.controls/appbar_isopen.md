---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBar.IsOpen
-api-type: winrt property
---

<!-- Property syntax
public bool IsOpen { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBar.IsOpen

## -description

Gets or sets a value that indicates whether the [AppBar](appbar.md) is open.

## -xaml-syntax

```xaml
<AppBar IsOpen="bool"/>
```

## -property-value

**true** if the app bar is open; otherwise, **false**.

## -remarks

How the app bar is displayed when it's closed depends on the [ClosedDisplayMode](appbar_closeddisplaymode.md) property setting. For more info, see [Command bar](/windows/apps/design/controls/command-bar).

You can open and close the app bar programmatically by setting the IsOpen property. You can use the [Opening](appbar_opening.md), [Opened](appbar_opened.md), [Closing](appbar_closing.md), and [Closed](appbar_closed.md) events to respond to the app bar being opened or closed.

## -examples

## -see-also

[Command bar](/windows/apps/design/controls/command-bar)
