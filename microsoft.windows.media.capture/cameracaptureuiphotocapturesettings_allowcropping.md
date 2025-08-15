---
-api-id: P:Microsoft.Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.AllowCropping
-api-type: winrt property
---

# Microsoft.Windows.Media.Capture.CameraCaptureUIPhotoCaptureSettings.AllowCropping

<!--
public bool AllowCropping { get; set; }
-->


## -description

Gets or sets a value specifying whether the **CameraCaptureUI** provides controls that allow the user to crop a photo after it has been captured.

## -property-value

True if the user is allowed to crop the photo; otherwise, false.

## -remarks

**AllowCropping** is true by default.

Use [CroppedAspectRatio](cameracaptureuiphotocapturesettings_croppedaspectratio.md) or [CroppedSizeInPixels](cameracaptureuiphotocapturesettings_croppedsizeinpixels.md) to set constraints on the dimensions of the cropped photo. You must only specify a value for one of these properties. Specifying both the size in pixels and the aspect ratio will result in an invalid argument exception. Setting a value for **CroppedAspectRatio** or **CroppedSizeInPixels** when **AllowCropping** is set to false will result in an invalid argument exception.

## -see-also

## -examples


