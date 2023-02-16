---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.Popup.ShouldConstrainToRootBounds
-api-type: winrt property
---

<!-- Property syntax.
public bool ShouldConstrainToRootBounds { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.Popup.ShouldConstrainToRootBounds

## -description

Gets or sets a value that indicates whether the popup should be shown within the bounds of the XAML root. This property is ignored in Windows App SDK apps.

## -property-value

**true** if the popup should be shown within the bounds of the XAML root; otherwise, **false**. The default is **true**. This value is ignored in Windows App SDK apps.

## -remarks

This property does not have an effect in Windows App SDK apps. The [IsConstrainedToRootBounds](popup_isconstrainedtorootbounds.md) property is always **true**.

## -see-also

[IsConstrainedToRootBounds](popup_isconstrainedtorootbounds.md), [FlyoutBase ShouldConstrainToRootBounds](flyoutbase_shouldconstraintorootbounds.md)

## -examples

