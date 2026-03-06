---
-api-id: T:Microsoft.Windows.AI.Imaging.RecognizedTextBoundingBox
-api-type: winrt struct
---

# Microsoft.Windows.AI.Imaging.RecognizedTextBoundingBox

<!--
public struct RecognizedTextBoundingBox
-->

## -description

Specifies the four points used to define the boundaries of a quadrilateral polygon that surrounds recognized text.

## -struct-fields

### -field BottomLeft

The bottom left corner of the bounding box.

### -field BottomRight

The bottom right corner of the bounding box.

### -field TopLeft

The top left point of the bounding box.

### -field TopRight

The top right point of the bounding box.

## -remarks

When returned as a boundary for a word or line, the *TopLeft*, *TopRight*, *BottomRight*, and *BottomLeft* points are relative to the rotation and skew of the recognized text in the image. The following diagram shows the point layout for different text rotations where 0 is *TopLeft*, 1 is *TopRight*, 2 is *BottomRight*, and 3 is *BottomLeft*, all relative to the text.

:::image type="content" source="images/bounding-box-examples.png" alt-text="Diagram of three bounding box examples showing how corner points are identified based on text rotation.":::

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
