---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator.DescribeAsync(Microsoft.Graphics.Imaging.ImageBuffer,Microsoft.Windows.AI.Imaging.ImageDescriptionKind,Microsoft.Windows.AI.ContentSafety.ContentFilterOptions)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator.DescribeAsync(Microsoft.Graphics.Imaging.ImageBuffer,Microsoft.Windows.AI.Imaging.ImageDescriptionKind,Microsoft.Windows.AI.ContentSafety.ContentFilterOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.Imaging.ImageDescriptionResult,string> DescribeAsync (Microsoft.Graphics.Imaging.ImageBuffer image, Microsoft.Windows.AI.Imaging.ImageDescriptionKind kind, Microsoft.Windows.AI.ContentSafety.ContentFilterOptions contentFilterOptions);
-->

## -description

Asynchronously generates a description of the contents of an image.

## -parameters

### -param image

The uncompressed bitmap to describe, optimized for AI Foundry on Windows.

### -param kind

The type of image being described.

### -param contentFilterOptions

Options that affect how the language model filters responses to the prompt.

## -returns

An asynchronous operation with progress object which, when it completes, contains the result of an image description operation.

## -remarks

The [ImageDescriptionKind](imagedescriptionkind.md) parameter controls the format and detail level of the description. Choose `BriefDescription` for a short caption, `DetailedDescription` for more thorough coverage, `DiagramDescription` for diagrams and charts, or `AccessibleDescription` for accessibility-optimized alt text.

The [ContentFilterOptions](../microsoft.windows.ai.contentsafety/contentfilteroptions.md) parameter lets you configure the content moderation severity levels.

The returned [ImageDescriptionResult](imagedescriptionresult.md) contains the generated [Description](imagedescriptionresult_description.md) text and a [Status](imagedescriptionresult_status.md) code.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
