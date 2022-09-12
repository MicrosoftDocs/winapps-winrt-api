---
-api-id: E:Microsoft.UI.Xaml.FrameworkElement.LayoutUpdated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.EventHandler LayoutUpdated<object>
-->

# Microsoft.UI.Xaml.FrameworkElement.LayoutUpdated

## -description

Occurs when the layout of the visual tree changes, due to layout-relevant properties changing value or some other action that refreshes the layout.

## -xaml-syntax

```xaml
<frameworkElement LayoutUpdated="eventhandler"/>
 
```

## -remarks

`LayoutUpdated` is the last object lifetime event to occur in the XAML load sequence before a control is ready for interaction. However, `LayoutUpdated` can also occur at run time during the object lifetime, for a variety of reasons: a property change, a window resizing, or a runtime layout request ([UpdateLayout](uielement_updatelayout_1243658106.md) or a changed control template). The `LayoutUpdated` event is fired after all [SizeChanged](frameworkelement_sizechanged.md) events in a layout sequence occur.

`LayoutUpdated` can occur when the object where the handler is attached does not necessarily change anything in the visual tree under it. For instance, imagine a layout container where there are two child elements sharing space. If the first object changes a property that forces a new layout, both objects fire LayoutUpdated because the second object might be repositioned even if its own subsidiary layout does not change.

When you handle `LayoutUpdated`, do not rely on the *sender* value. For `LayoutUpdated`, *sender* is always `null`, regardless of where the handler is attached. This is to prevent handlers from assigning any meaning to *sender*, such as implying that it was that specific element that fired the event out of the visual tree. `LayoutUpdated` implies that something in the overall visual tree has changed, and each specific object anywhere in the tree has the option of handling this occurrence. If you're familiar with lower-level render API design, you can equate `LayoutUpdated` being fired as similar to a "redraw needed" flag being set as part of an object-driven, retained-mode rendering logic.

Because `LayoutUpdated` fires in many circumstances and isn't always specific to an object that actually changes, consider whether handling the [SizeChanged](frameworkelement_sizechanged.md) event instead is more appropriate for your scenario.

## -examples

## -see-also

[SizeChanged](frameworkelement_sizechanged.md)
