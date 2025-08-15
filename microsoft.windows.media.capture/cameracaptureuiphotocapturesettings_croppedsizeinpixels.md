---
-api-id: P:Microsoft.Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedSizeInPixels
-api-type: winrt property
---

# Microsoft.Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedSizeInPixels

<!--
public Windows.Foundation.Size CroppedSizeInPixels { get; set; }
-->


## -description

Gets or sets the exact size constraint, in pixels, when cropping the captured photo.

## -property-value

The exact size constraint when cropping the captured photo.

## -remarks

You must only specify a value for **CroppedSizeInPixels** or [CroppedAspectRatio](cameracaptureuiphotocapturesettings_croppedaspectratio.md). Specifying both the size in pixels and the aspect ratio will result in an invalid argument exception. Setting **CroppedAspectRatio** or **CroppedSizeInPixels** when [AllowCropping](cameracaptureuiphotocapturesettings_allowcropping.md) is set to false will result in an invalid argument exception.

## -see-also

## -examples


