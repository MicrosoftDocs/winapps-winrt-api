---
-api-id: P:Microsoft.UI.Xaml.Controls.TitleBar.Subtitle
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TitleBar.Subtitle

<!--
public string Subtitle { get; set; }
-->

## -description

Gets or sets the subtitle text to display in the title bar.

## -property-value

The subtitle text to display in the title bar. The default is an empty string.

## -remarks

The subtitle is shown to the right of the title. It is typically used to display versioning information, like "Preview" or "Beta".

When the `TitleBar` is in compact display mode, the `Title` and `Subtitle` elements are not shown.

## -see-also

## -examples

This example shows how to set the `Subtitle` property to a literal string.

```xaml
<TitleBar Title="My App" Subtitle="Preview"/>
```

```csharp
TitleBar titleBar = new TitleBar();
titleBar.Title = "My App";
titleBar.Subtitle = "Preview";
```
