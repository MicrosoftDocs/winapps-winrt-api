---
-api-id: M:Microsoft.Graphics.Display.DisplayInformation.GetColorProfile
-api-type: winrt method
---

# Microsoft.Graphics.Display.DisplayInformation.GetColorProfile

<!--
public Windows.Storage.Streams.IRandomAccessStream GetColorProfile ();
-->


## -description

Retrieves the default International Color Consortium (ICC) color profile that is associated with the physical display.

## -returns

The default International Color Consortium (ICC) color profile that is associated with the physical display.

## -remarks

The method returns `null` if no physical display is attached to the computer on which the app is running (for example, if the app is running over Remote Desktop Connection), or if no color profile is associated with the display, or if the profile doesn't match the signature of an ICC color profile.

If there's no valid ICC color profile associated with the display, then your app should handle that by assuming a default color space, such as sRGB.

## -see-also

## -examples
