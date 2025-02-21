---
-api-id: P:Microsoft.Windows.Media.Capture.CameraCaptureUIVideoCaptureSettings.AllowTrimming
-api-type: winrt property
---

# Microsoft.Windows.Media.Capture.CameraCaptureUIVideoCaptureSettings.AllowTrimming

<!--
public bool AllowTrimming { get; set; }
-->


## -description

Gets or sets a value specifying whether the **CameraCaptureUI** provides controls that allow the user to trim a video after it has been captured.

## -property-value

True if the user is allowed to trim the video; otherwise, false.

## -remarks

**AllowTrimming** is true by default.

Setting a value for [MaxDurationInSeconds](cameracaptureuivideocapturesettings_maxdurationinseconds.md) when **AllowTrimming** is set to false will result in an invalid argument exception.

## -see-also

## -examples


