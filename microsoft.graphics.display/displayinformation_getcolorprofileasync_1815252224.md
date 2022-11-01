---
-api-id: M:Microsoft.Graphics.Display.DisplayInformation.GetColorProfileAsync
-api-type: winrt method
---

# Microsoft.Graphics.Display.DisplayInformation.GetColorProfileAsync

<!--
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> GetColorProfileAsync ();
-->

## -description

Asynchronously retrieves the default International Color Consortium (ICC) color profile that is associated with the physical display.

## -returns

An asynchronous operation object which, when it completes, contains the color profile.

## -remarks

The asynchronous operation fails if no physical display is attached to the computer on which the app is running (for example, if the app is running over Remote Desktop Connection), or if no color profile is associated with the display, or if the profile doesn't match the signature of an ICC color profile.

Your app should catch any exceptions thrown by this API. In such cases, there is no valid ICC color profile associated with the display, and your app should handle that by assuming a default color space, such as sRGB.

## -examples

## -see-also
