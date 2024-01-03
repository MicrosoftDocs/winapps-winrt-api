---
-api-id: M:Microsoft.UI.Xaml.Controls.Layout.SetIndexBasedLayoutOrientation(Microsoft.UI.Xaml.Controls.IndexBasedLayoutOrientation)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Layout.SetIndexBasedLayoutOrientation(Microsoft.UI.Xaml.Controls.IndexBasedLayoutOrientation)

<!--
protected void SetIndexBasedLayoutOrientation (Microsoft.UI.Xaml.Controls.IndexBasedLayoutOrientation orientation);
-->

## -description

Sets the value of the `IndexBasedLayoutOrientation` property.

## -parameters

### -param orientation

A value of the enumeration that indicates the orientation, if any, in which items are laid out based on their index in the source collection.

## -remarks

## -see-also

[IndexBasedLayoutOrientation](layout_indexbasedlayoutorientation.md)

## -examples

```csharp
public class MyHorizontalLayout : NonVirtualizingLayout
{
    public class MyHorizontalLayout()
    {
        SetIndexBasedLayoutOrientation(IndexBasedLayoutOrientation.LeftToRight);
        Debug.Assert(this.IndexBasedLayoutOrientation == IndexBasedLayoutOrientation.LeftToRight);
    }
}
```
