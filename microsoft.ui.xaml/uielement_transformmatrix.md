---
-api-id: P:Microsoft.UI.Xaml.UIElement.TransformMatrix
-api-type: winrt property
---

<!-- Property syntax.
public Matrix4x4 TransformMatrix { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.TransformMatrix

## -description

Gets or sets the transformation matrix to apply to the element.

## -property-value

The transformation matrix to apply to the element.

## -remarks

This property is not compatible with [`ElementCompositionPreview.GetElementVisual`](../microsoft.ui.xaml.hosting/elementcompositionpreview_getelementvisual_580363760.md). Attempting to use `TransformMatrix` after calling `GetElementVisual` will fail with the following error:

> Access denied. Calling TransformMatrix API is not allowed on this object at this time, as this object currently has the ElementCompositionPreview.GetElementVisual property in use.

## -see-also

## -examples
