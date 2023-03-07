---
-api-id: P:Microsoft.UI.Xaml.Controls.Page.BottomAppBar
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.AppBar BottomAppBar { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Page.BottomAppBar

## -description

Gets or sets the [AppBar](appbar.md) displayed at the bottom of the page.

## -xaml-syntax

```xaml
<Page ...>
  <Page.BottomAppBar>
    <AppBar .../>
  </Page.BottomAppBar>
</Page>
```


## -property-value

A reference to an [AppBar](appbar.md) displayed at the top of the page, if any; otherwise, `null`.

## -remarks

> [!NOTE]
> For apps in Windows 10 or later, placing commands in the `TopAppBar` and `BottomAppBar` is not recommended.
>
> - For the latest guidance regarding general app commands, see [Command bar](/windows/apps/design/controls/command-bar).
> - For the latest guidance regarding navigation commands, see [Navigation design basics for Windows apps](/windows/apps/design/basics/navigation-basics).

In XAML, make sure you specify the `Page.BottomAppBar` property element in the same area as other property elements that may already be defined, like `Page.TopAppBar` or `Page.Resources`. The XAML language enforces that you can't mix the property elements between the XAML content that is setting [Content](usercontrol_content.md), such as the typical root [Grid](grid.md) element. For more info on XAML syntax, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

## -examples

## -see-also

[Command bar](/windows/apps/design/controls/command-bar), [Navigation design basics for Windows apps](/windows/apps/design/basics/navigation-basics)
