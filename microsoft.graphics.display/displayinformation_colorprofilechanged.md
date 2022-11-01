---
-api-id: E:Microsoft.Graphics.Display.DisplayInformation.ColorProfileChanged
-api-type: winrt event
---

# Microsoft.Graphics.Display.DisplayInformation.ColorProfileChanged

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.Graphics.Display.DisplayInformation,object> ColorProfileChanged;
-->

## -description

Occurs when the physical display's color profile changes.

## -remarks

The **ColorProfileChanged** event is triggered only when the display’s color profile changes. You must then call the [DisplayInformation.GetColorProfileAsync](displayinformation_getcolorprofileasync_1815252224.md) method to asynchronously retrieve the new color profile.

## -examples

## -see-also
