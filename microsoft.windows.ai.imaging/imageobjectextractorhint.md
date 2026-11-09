---
-api-id: T:Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint

<!--
public sealed class ImageObjectExtractorHint
-->

## -description

Represents an object that helps an [ImageObjectExtractor](imageobjectextractor.md) identify the intended artifact to extract.

## -remarks

Use **ImageObjectExtractorHint** to guide an [ImageObjectExtractor](imageobjectextractor.md) toward the object you want to segment. You can specify points that should be included in the extracted region through [IncludePoints](imageobjectextractorhint_includepoints.md), points that should be excluded through [ExcludePoints](imageobjectextractorhint_excludepoints.md), and rectangular regions that contain the target object through [IncludeRects](imageobjectextractorhint_includerects.md).

Combining include and exclude points gives you fine-grained control when multiple objects are close together.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
