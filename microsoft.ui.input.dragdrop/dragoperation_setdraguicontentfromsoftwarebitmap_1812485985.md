---
-api-id: M:Microsoft.UI.Input.DragDrop.DragOperation.SetDragUIContentFromSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap,Windows.Foundation.Point)
-api-type: winrt method
---

# Microsoft.UI.Input.DragDrop.DragOperation.SetDragUIContentFromSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap,Windows.Foundation.Point)

<!--
public void SetDragUIContentFromSoftwareBitmap (Windows.Graphics.Imaging.SoftwareBitmap bitmap, Windows.Foundation.Point anchorPoint);
-->

## -description

Specifies that a bitmap image should be used as a custom drag visual (displayed at the specified offset from the input pointer) during the drag and drop operation.

## -parameters

### -param bitmap

The bitmap image to use for the custom drag visual during the drag and drop operation.

### -param anchorPoint

The relative position of the drag visual from the input pointer. The anchor point cannot be outside of the content. For example, if the anchor point is (50, 50) and the position of the pointer is (x, y), the top left corner for the visual will be (x - 50, y - 50).

## -remarks

## -see-also

## -examples
