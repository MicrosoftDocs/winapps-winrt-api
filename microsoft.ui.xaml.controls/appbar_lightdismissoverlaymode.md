---
-api-id: P:Microsoft.UI.Xaml.Controls.AppBar.LightDismissOverlayMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.LightDismissOverlayMode LightDismissOverlayMode { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.AppBar.LightDismissOverlayMode

## -description
Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.

## -xaml-syntax
```xaml
<appBar LightDismissOverlayMode="lightDismissOverlayModeMemberName" />
```


## -xaml-values
<dl><dt>lightDismissOverlayModeMemberName</dt><dd>lightDismissOverlayModeMemberNameA named constant of the LightDismissOverlayMode enumeration; for example, On or Off.</dd>
</dl>
## -property-value
A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.

## -remarks

Transient UI, such as a [MenuFlyout](menuflyout.md) or secondary menu in a command bar, closes when you click or tap outside of it. This is called light-dismiss. "Overlay" refers to the area outside of a light-dismiss UI.

By default, the "overlay" is not darkened.

## -examples

## -see-also
