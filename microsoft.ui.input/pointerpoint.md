---
-api-id: T:Microsoft.UI.Input.PointerPoint
-api-type: winrt class
---

# Microsoft.UI.Input.PointerPoint

<!--
public sealed class PointerPoint
-->

## -description

Provides basic properties for the input pointer associated with a single mouse, pen/stylus, or touch contact.

## -remarks

See [PointerPointProperties](pointerpointproperties.md) for extended properties accessible through [Properties](pointerpoint_properties.md).

The PointerPoint coordinate space is dependent on the context in which it is retrieved. When retrieved from [PointerRoutedEventArgs.GetCurrentPoint](../microsoft.ui.xaml.input/pointerroutedeventargs_getcurrentpoint_293890010.md), the coordinates of the pointer will be relative to the provided [UIElement](../microsoft.ui.xaml/uielement.md) in device independent pixels.

## -see-also

[PointerPointProperties](pointerpointproperties.md), [Microsoft.UI.Xaml.Input.PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md)

## -examples

In the following example, we query various pointer properties using a PointerPoint object.

```csharp
private string queryPointer(PointerPoint ptrPt)
{
    String details = "";

    switch (ptrPt.PointerDeviceType)
    {
        case PointerDeviceType.Mouse:
            details += "\nPointer type: mouse";
            break;
        case PointerDeviceType.Pen:
            details += "\nPointer type: pen";
            if (ptrPt.IsInContact)
            {
                details += "\nPressure: " + ptrPt.Properties.Pressure;
                details += "\nrotation: " + ptrPt.Properties.Orientation;
                details += "\nTilt X: " + ptrPt.Properties.XTilt;
                details += "\nTilt Y: " + ptrPt.Properties.YTilt;
                details += "\nBarrel button pressed: " + ptrPt.Properties.IsBarrelButtonPressed;
            }
            break;
        case PointerDeviceType.Touch:
            details += "\nPointer type: touch";
            details += "\nrotation: " + ptrPt.Properties.Orientation;
            details += "\nTilt X: " + ptrPt.Properties.XTilt;
            details += "\nTilt Y: " + ptrPt.Properties.YTilt;
            break;
        default:
            details += "\nPointer type: n/a";
            break;
    }

    details += "\nPointer Id: " + ptrPt.PointerId.ToString() +
        "\nPointer location: " + ptrPt.Position.X + ", " + ptrPt.Position.Y;

    return details;
}
```
