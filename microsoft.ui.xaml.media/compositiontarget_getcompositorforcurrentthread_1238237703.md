---
-api-id: M:Microsoft.UI.Xaml.Media.CompositionTarget.GetCompositorForCurrentThread
-api-type: winrt method
---

# Microsoft.UI.Xaml.Media.CompositionTarget.GetCompositorForCurrentThread

<!--
public static Microsoft.UI.Composition.Compositor GetCompositorForCurrentThread ();
-->


## -description

Retrieves the Compositor object for this thread.

## -returns

The Compositor object for this thread.

## -remarks

In XAML apps, we recommend that you call [ElementCompositionPreview.GetElementVisual(UIElement)](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.hosting.elementcompositionpreview.getelementvisual) to get a Composition [Visual](/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.visual), and get the `Compositor` from the visual's inherited [Compositor](/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionobject.compositor) property. In cases where you don't have access to a `UIElement` (for example, if you create a [CompositionBrush](/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositionbrush) in a class library), you can call `CompositionTarget.GetCompositorForCurrentThread` to get the Compositor instead.

## -see-also

## -examples


