---
-api-id: P:Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.ShouldConstrainPopupsToWorkArea
-api-type: winrt property
---

# Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.ShouldConstrainPopupsToWorkArea

<!--
public bool ShouldConstrainPopupsToWorkArea { get; set; }
-->

## -description

Gets or sets a value that indicates whether controls with popup-like behavior should be constrained to the work area.

## -property-value

`true` to constrain controls with popup-like behavior to the work area; otherwise, `false`. The default value is `true`.

## -remarks

The _[work area](../microsoft.ui.windowing/displayarea_workarea.md)_ of a display is the part of the desktop display that excludes task bars, docked windows, and docked tool bars. Typically, apps constrain themselves to the work area, including any controls that are opened by the app with popup-like behavior; such as Popup, Flyout, ToolTip, or a ComboBox dropdown.

If an app window is intended to be positioned outside the work area (like a docked tool bar), then its popups should _not_ constrain themselves to the work area; otherwise they would be opened too far from the UI elements that they're associated with. This could create situations like ToolTips that open far away from the control they describe or ComboBox dropdowns that open far away from the ComboBox button.

The `ShouldConstrainPopupsToWorkArea` property lets you specify whether popups should be constrained to the work area. The default is `true`; you can specify `false` if your app has controls that should pop up outside the work area.

This property does not apply retroactively to popup-like controls that are already open.

> [!NOTE]
> If a control is constrained to root bounds by setting its [ShouldConstrainToRootBounds](../microsoft.ui.xaml.controls.primitives/flyoutbase_shouldconstraintorootbounds.md) property to `true`, then the root bounds constraint takes priority over the work area constraint, as shown in this table.

| ShouldConstrainPopupsToWorkArea | ShouldConstrainToRootBounds | Actual constraint |
|---------|---------|---------|
| `false` | `false` | Display bounds |
| `false` | `true` | Root bounds |
| `true` | `false` | Work area |
| `true` | `true` | Root bounds |



## -see-also

## -examples


