---
-api-id: P:Microsoft.UI.Input.MouseWheelParameters.PageTranslation
-api-type: winrt property
---

# Microsoft.UI.Input.MouseWheelParameters.PageTranslation

<!--
public Windows.Foundation.Point PageTranslation { get; set; }
-->

## -description

Gets or sets the conversion factors for both page width and height units, in device-independent pixel (DIP).

## -property-value

The conversion factors for the page width (x) and height (y).

## -remarks

The following image shows the default control panel settings for the button wheel. These settings map a single detent to a specific unit of distance in the UI (page width and height). PageTranslation provides the means to redefine these distances and specify the size of a page in terms of device-independent pixel (DIP).

:::image type="content" source="images/mouseproperties-buttonwheel.png" alt-text="Screenshot of the Mouse Settings page showing mouse wheel scrolling settings.":::
*Mouse Properties dialog with wheel settings displayed*


If the wheel button is set to scroll one screen (page) at a time for each detent and the value of PageTranslation is set to (1200,800), vertical scrolling is applied at 1 x 800 device-independent pixel (DIP) per detent. Horizontal scrolling distance through the mouse tilt wheel is dependent on the value of [CharTranslation](mousewheelparameters_chartranslation.md).

> [!NOTE]
> If **[ManipulationTranslateY](gesturesettings.md)**/**[ManipulationTranslateRailsY](gesturesettings.md)**  is disabled and **[ManipulationTranslateX](gesturesettings.md)**/**[ManipulationTranslateRailsX](gesturesettings.md)** is enabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the horizontal axis when the button wheel is rotated or tilted. Similarly, if **[ManipulationTranslateY](gesturesettings.md)**/**[ManipulationTranslateRailsY](gesturesettings.md)** is enabled and **[ManipulationTranslateX](gesturesettings.md)**/**[ManipulationTranslateRailsX](gesturesettings.md)** is disabled through [GestureSettings](gesturerecognizer_gesturesettings.md) then scrolling is applied only along the vertical axis when the button wheel is rotated or tilted.

## -see-also

[GestureRecognizer.MouseWheelParameters](gesturerecognizer_mousewheelparameters.md), [CharTranslation](mousewheelparameters_chartranslation.md)

## -examples
