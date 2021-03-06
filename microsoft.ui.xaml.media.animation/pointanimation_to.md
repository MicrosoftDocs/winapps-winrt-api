---
-api-id: P:Microsoft.UI.Xaml.Media.Animation.PointAnimation.To
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.Point> To { get;  set; }
-->

# Microsoft.UI.Xaml.Media.Animation.PointAnimation.To

## -description
Gets or sets the animation's ending value.

## -xaml-syntax
```xaml
<PointAnimation┬áTo="x,y"/>
```


## -xaml-values
<dl><dt>x</dt><dd>xThe x-value of the Point that specifies the animation end value.</dd>
<dt>y</dt><dd>yThe y-value of a Point that specifies the animation end value.</dd>
</dl>
## -property-value
The ending value of the animation. The default is **null**.

<!--Projection dochack:-->
If you are programming using C#or Microsoft Visual Basic, the type of this property is projected as **Point?**(a nullable [Point](/uwp/api/windows.foundation.point)).

## -remarks
A [PointAnimation](pointanimation.md) typically has at least one of the [From](pointanimation_from.md), [By](pointanimation_by.md) or To properties set, but never all three. For more info, see Remarks in [PointAnimation](pointanimation.md).

The **null** default value indicates that the base non-animated value is the default value for To, not that the animated value is literally **null**. The base non-animated value is determined at run time by the dependency property system. For more info, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

## -examples

## -see-also
