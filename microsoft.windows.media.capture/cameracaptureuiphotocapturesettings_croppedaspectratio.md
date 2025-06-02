---
-api-id: P:Microsoft.Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedAspectRatio
-api-type: winrt property
---

# Microsoft.Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.CroppedAspectRatio

<!--
public Windows.Foundation.Size CroppedAspectRatio { get; set; }
-->


## -description

Gets or sets the aspect ratio constraint when cropping the captured photo.

## -property-value

The aspect ratio constraint when cropping the captured photo.

## -remarks

You must only specify a value for **CroppedAspectRatio** or [CroppedSizeInPixels](cameracaptureuiphotocapturesettings_croppedsizeinpixels.md). Specifying both the size in pixels and the aspect ratio will result in an invalid argument exception. Setting **CroppedAspectRatio** or **CroppedSizeInPixels** when [AllowCropping](cameracaptureuiphotocapturesettings_allowcropping.md) is set to false will result in an invalid argument exception.

## -see-also

## -examples


