---
-api-id: M:Microsoft.UI.Xaml.UIElement.FindSubElementsForTouchTargeting(Windows.Foundation.Point,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IIterable<Windows.Foundation.Point>> FindSubElementsForTouchTargeting(Windows.Foundation.Point point, Windows.Foundation.Rect boundingRect)
-->

# Microsoft.UI.Xaml.UIElement.FindSubElementsForTouchTargeting

## -description

Enables a [UIElement](uielement.md) subclass to expose child elements that assist with resolving touch targeting.

## -parameters

### -param point

The point being touched.

### -param boundingRect

The bounds used for touch tolerance.

## -returns

A set of point sets. These represent the vertices of sub elements that are intersected by the given touch point (plus tolerance).

## -remarks

Points in the list are in descending z-order: topmost in the rendering stack appears first in the list.

[FindElementsInHostCoordinates](../microsoft.ui.xaml.media/visualtreehelper_findelementsinhostcoordinates_1456580452.md) is a similar static-class helper method that is also used for hit testing and general object tree examination. However, `FindSubElementsForTouchTargeting` adds the refinement of a [Rect](/uwp/api/windows.foundation.rect) input to use for touch tolerance.

If you are programming using C#, the return value type of this method is projected as an [IEnumerable](/dotnet/api/system.collections.generic.ienumerable-1) generic collection that contains [UIElement](uielement.md) items.

## -examples

## -see-also

[Handle pointer input](/windows/apps/design/input/handle-pointer-input), [FindElementsInHostCoordinates](../microsoft.ui.xaml.media/visualtreehelper_findelementsinhostcoordinates_1456580452.md)
