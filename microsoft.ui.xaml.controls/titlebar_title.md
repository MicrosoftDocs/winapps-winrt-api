---
-api-id: P:Microsoft.UI.Xaml.Controls.TitleBar.Title
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TitleBar.Title

<!--
public string Title { get; set; }
-->

## -description

Gets or sets the title text to display in the title bar.

## -property-value

The title text to display in the title bar. The default is an empty string.

## -remarks

The title is typically used to show the app's display name.

When the `TitleBar` is in compact display mode, the `Title` and `Subtitle` elements are not shown.

## -see-also

## -examples

This example shows how to bind the `Title` property to the app's `DisplayName`.

```xaml
xmlns:appmodel="using:Windows.ApplicationModel"

<TitleBar Title="{x:Bind appmodel:AppInfo.Current.DisplayInfo.DisplayName}"/>
```

You can also set it in code.

```csharp
using Windows.ApplicationModel;

TitleBar titleBar = new TitleBar();
titleBar.Title = AppInfo.Current.DisplayInfo.DisplayName;
```

This example shows how to set the `Title` property to a literal string.

```xaml
<TitleBar Title="My App"/>
```

```csharp
TitleBar titleBar = new TitleBar();
titleBar.Title = "My App";
```
