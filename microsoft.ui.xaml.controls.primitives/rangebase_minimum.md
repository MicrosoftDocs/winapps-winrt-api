---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.RangeBase.Minimum
-api-type: winrt property
---

<!-- Property syntax
public double Minimum { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Primitives.RangeBase.Minimum

## -description
Gets or sets the Minimum possible [Value](rangebase_value.md) of the range element.

## -xaml-syntax
```xaml
<rangeBase┬áMinimum="double"/>
```


## -property-value
Minimum possible [Value](rangebase_value.md) of the range element. The default is 0.

## -remarks
> [!NOTE]
> When binding Minimum and [Maximum](rangebase_maximum.md) values in Extensible Application Markup Language (XAML), declare the [Binding](../microsoft.ui.xaml.data/binding.md) for [Maximum](rangebase_maximum.md) first. If the [Binding](../microsoft.ui.xaml.data/binding.md) for [Maximum](rangebase_maximum.md) is declared after Minimum, the bound value for [Maximum](rangebase_maximum.md) is ignored and the following situations can occur: + If the bound Minimum value is negative, the [Maximum](rangebase_maximum.md) value is set to 0.
+ If the bound Minimum value is greater than the default [Maximum](rangebase_maximum.md) (100 for [Slider](../microsoft.ui.xaml.controls/slider.md) and [ProgressBar](../microsoft.ui.xaml.controls/progressbar.md)), the [Maximum](rangebase_maximum.md) value is set equal to the Minimum value.
To avoid this behavior, declare the [Binding](../microsoft.ui.xaml.data/binding.md) for [Maximum](rangebase_maximum.md) first in your Extensible Application Markup Language (XAML).

These behaviors can also occur if you set the Minimum value without also explicitly setting the [Maximum](rangebase_maximum.md) value.

## -examples

## -see-also
