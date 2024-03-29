---
-api-id: P:Microsoft.UI.Xaml.UIElement.ManipulationMode
-api-type: winrt property
---

<!-- Property syntax
public Microsoft.UI.Xaml.Input.ManipulationModes ManipulationMode { get;  set; }
-->

# Microsoft.UI.Xaml.UIElement.ManipulationMode

## -description

Gets or sets the [ManipulationModes](../microsoft.ui.xaml.input/manipulationmodes.md) value used for [UIElement](uielement.md) behavior and interaction with gestures. Setting this value enables handling the manipulation events from this element in app code.

## -xaml-syntax

```xaml
<uiElement ManipulationMode="All"/>
-or-
<uiElement ManipulationMode="None"/>
-or-
<uiElement ManipulationMode="singleManipulationModesMemberName"/>
-or-
<uiElement ManipulationMode="relatedManipulationModesNames"/>

```

## -xaml-values
<dl><dt>singleManipulationModesMemberName</dt><dd>singleManipulationModesMemberNameOne of the named constants of the ManipulationModes enumeration. These constrain the manipulation to a single behavior, for example TranslateX.</dd>
<dt>relatedManipulationModesNames</dt><dd>relatedManipulationModesNamesTwo or more ManipulationModes enumeration constant names separated by commas, for example TranslateX,TranslateY. This is the XAML syntax for specifying multiple values of a flagwise enumeration. See "Specifying related manipulation modes" section.</dd>
</dl>
## -property-value
A value or values of the enumeration. The default is typically **System**, but this can vary on specific controls and elements. See Remarks.

## -remarks

You must set the `ManipulationMode` to a value other than `System` or `None` if you want to handle manipulation events such as [ManipulationStarted](uielement_manipulationstarted.md) from UI elements in your app code. For more info on manipulations, see [Handle pointer input](/windows/apps/design/input/handle-pointer-input).

The typical default value of `ManipulationMode` is `System` rather than `None`. When the value is `System`, manipulations that originate from the element can be handled by the Windows Runtime infrastructure, which is based on the [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal)  API. For example, [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) handles user manipulations in its control logic and processes them as scrolling actions for the control. The `System` value also enables personality animations that respond to manipulation events.

[Slider](../microsoft.ui.xaml.controls/slider.md) and [ToggleSwitch](../microsoft.ui.xaml.controls/toggleswitch.md) have default templates that set the ManipulationMode value to `None`, so `None` will be the default value you see at design time.

### Specifying related manipulation modes

You can specify more than one of the flagwise [ManipulationModes](../microsoft.ui.xaml.input/manipulationmodes.md) values as the value of the `ManipulationMode` property. This is possible in XAML using the comma syntax shown in the "XAML Values" section. For example, you can combine `TranslateX`, `TranslateY`, `Rotate`, and `Scale`, or any combination of these. However, not all combinations are valid. Validity is enforced only once `ManipulationModes` is used by a specific control, so issues with setting an invalid combination of `ManipulationModes` might not appear until run-time when values are applied.

+ Don't combine **Translate*** values with **TranslateRails*** values, these are treated as mutually exclusive values.
+ Don't combine the inertial values with the non-inertial values.
+ The **All** value isn't the true additive value of all the flags (if values are compared bitwise). A value of **All** doesn't necessarily indicate that the combination of all the values is valid either, or that any specific value is set.

## -examples

## -see-also

[ManipulationStarted](uielement_manipulationstarted.md), [ManipulationDelta](uielement_manipulationdelta.md), [ManipulationCompleted](uielement_manipulationcompleted.md), [ManipulationModes](../microsoft.ui.xaml.input/manipulationmodes.md), [Handle pointer input](/windows/apps/design/input/handle-pointer-input), [Direct Manipulation Reference](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-reference), [Basic input sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BasicInput)
