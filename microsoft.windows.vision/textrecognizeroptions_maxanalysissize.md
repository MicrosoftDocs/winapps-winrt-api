---
-api-id: P:Microsoft.Windows.Vision.TextRecognizerOptions.MaxAnalysisSize
-api-type: winrt property
---

# Microsoft.Windows.Vision.TextRecognizerOptions.MaxAnalysisSize

<!--
public Windows.Graphics.SizeInt32 MaxAnalysisSize { get; set; }
-->

## -description

Gets or sets the maximum image size.

## -property-value

The maximum image size. Default value is 1152 width and 768 height.

## -remarks

This size is a suggestion, and might not always be honored.

If the source image is larger than the maximum size, it will automatically be scaled down to the upper size limits.

## -see-also

## -examples
