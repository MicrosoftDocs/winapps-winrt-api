---
-api-id: T:Microsoft.UI.Xaml.Controls.LightDismissOverlayMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.LightDismissOverlayMode : int
-->

# LightDismissOverlayMode

## -description

Defines constants that specify whether the area outside of a *light-dismiss* UI is darkened.

## -enum-fields

### -field Auto:0

The device-family the app is running on determines whether the area outside of a *light-dismiss* UI is darkened.

### -field On:1

The area outside of a *light-dismiss* UI is darkened for all device families.

### -field Off:2

The area outside of a *light-dismiss* UI is not darkened for all device families.

## -remarks

Transient UI, such as a [Flyout](flyout.md) or the open drop-down of a [ComboBox](combobox.md), closes when you click or tap outside of it. This is called light-dismiss. "Overlay" refers to the area outside of a light-dismiss UI.

By default, the "overlay" is not darkened.

## -examples

## -see-also
