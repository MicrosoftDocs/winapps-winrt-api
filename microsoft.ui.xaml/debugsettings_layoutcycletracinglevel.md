---
-api-id: P:Microsoft.UI.Xaml.DebugSettings.LayoutCycleTracingLevel
-api-type: winrt property
---

# Microsoft.UI.Xaml.DebugSettings.LayoutCycleTracingLevel

<!--
public Microsoft.UI.Xaml.LayoutCycleTracingLevel LayoutCycleTracingLevel { get; set; }
-->

## -description

Gets or sets a value that indicates whether layout cycle tracing is written to the native debugger and the level of detail that is recorded.

## -property-value

A value of the enumeration that indicates whether layout cycle tracing is written to the native debugger and the level of detail that is recorded. The default is `None`.

## -remarks

When a layout cycle crash appears imminent, this tracing level is used to determine how much debugging information is preserved in crash dumps and whether to output any information to the native debugger.

- `None` - Minimal layout cycle information is preserved in [stowed exceptions](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/threading#stowed-exceptions) in crash dumps. There is no output to the native debugger.
- `Low` - Minimal layout cycle information is preserved in [stowed exceptions](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/threading#stowed-exceptions) in crash dumps. The same information is also output to the native debugger.
- `High` - More verbose layout cycle information is provided that includes all `Measure` and `Arrange` calls with their `availableSize` and `finalSize` values. The output is preserved in [stowed exceptions](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/threading#stowed-exceptions) in crash dumps. The same information is also output to the native debugger.

You can also set [DebugSettings.LayoutCycleDebugBreakLevel](debugsettings_layoutcycledebugbreaklevel.md) to trigger an attached native debugger to break in during interesting events leading up to a potential layout cycle crash.

### XAML layout

XAML layout is the process where elements are given a size and position. For example, in a vertical `StackPanel` layout, each child is given a position such that they align horizontally and appear sequentially vertically.

Laying out all of the elements in the XAML tree is iterative, where the process of layout can cause a change that triggers another layout pass. This process is expected to converge, with a final layout pass producing a result without triggering any new layout passes. If the process fails to converge (every layout pass triggers another layout pass), the process is terminated and the app crashes with a layout cycle exception.

### Layout cycle errors

By default, XAML apps that experience a layout cycle crash provide minimal information to help you find and fix the problem:

- The [Application.UnhandledException](application_unhandledexception.md) event is raised and informs you that the crash was due to a layout cycle issue.
- Some information is saved in [stowed exceptions](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/threading#stowed-exceptions).

You can set `LayoutCycleTracingLevel` to send layout cycle tracing information to the native debugger output,  which makes it easier to access than using stowed exceptions, and to increase the verbosity of layout cycle logging to provide more information.

Here's some example output for a layout cycle crash involving the [Slider](../microsoft.ui.xaml.controls/slider.md) control:

```text
[LayoutCycleTracing] "SetValue(Width=866.400024)","LayoutCycleCountdown: 7","ClassName: Microsoft.UI.Xaml.Shapes.Rectangle","Name: HorizontalDecreaseRect","Instance: 0x000001C67FB0EE70","TypeIndex: 701"
[LayoutCycleTracing] "DesiredSize changed, old: 865.599976x0.000000 new: 866.400024x0.000000","LayoutCycleCountdown: 6","ClassName: Microsoft.UI.Xaml.Shapes.Rectangle","Name: HorizontalDecreaseRect","Instance: 0x000001C67FB0EE70","TypeIndex: 701"
[LayoutCycleTracing] "SetValue(Width=865.599976)","LayoutCycleCountdown: 4","ClassName: Microsoft.UI.Xaml.Shapes.Rectangle","Name: HorizontalDecreaseRect","Instance: 0x000001C67FB0EE70","TypeIndex: 701"
[LayoutCycleTracing] "DesiredSize changed, old: 866.400024x0.000000 new: 865.599976x0.000000","LayoutCycleCountdown: 3","ClassName: Microsoft.UI.Xaml.Shapes.Rectangle","Name: HorizontalDecreaseRect","Instance: 0x000001C67FB0EE70","TypeIndex: 701"
[LayoutCycleTracing] "SetValue(Width=866.400024)","LayoutCycleCountdown: 1","ClassName: Microsoft.UI.Xaml.Shapes.Rectangle","Name: HorizontalDecreaseRect","Instance: 0x000001C67FB0EE70","TypeIndex: 701"
[LayoutCycleTracing] "DesiredSize changed, old: 865.599976x0.000000 new: 866.400024x0.000000","LayoutCycleCountdown: 0","ClassName: Microsoft.UI.Xaml.Shapes.Rectangle","Name: HorizontalDecreaseRect","Instance: 0x000001C67FB0EE70","TypeIndex: 701"
```

This log output shows that the `Width` (and resulting desired size) of the `HorizontalDecreaseRect` element is toggling between 866.400024 and 865.599976. You can use this information to investigate further, including using [DebugSettings.LayoutCycleDebugBreakLevel](debugsettings_layoutcycledebugbreaklevel.md) to break into the debugger to investigate variables, to find any issues in your layout code.

These are some of the common properties listed in the tracing output:

- **LayoutCycleCountdown:** Specifies the current layout pass count. The layout pass count starts at the maximum allowed passes and counts down to 0. If the layout process doesn't converge by the end of pass 0, then a layout cycle exception occurs.
- **ClassName:** The class name of the `FrameworkElement` subclass associated with the message.
- **Name:** The `FrameworkElement.Name` of the `FrameworkElement` associated with the message, if any.
- **Instance:** The memory address of the internal representation of the `FrameworkElement` associated with the message. This is particularly useful to filter on in order to trace messages for individual instances.
- **TypeIndex:** Represents the internal index of the `FrameworkElement` class type. This can usually be ignored.
- **SetValue:** When a property which affects layout gets set, this lists the name of the property and also lists the new value for some value types.
- **DesiredSize:** When the result of measuring a `FrameworkElement` is a different size than when it was previously measured, this shows the change in desired size.

## -see-also

[DebugSettings.LayoutCycleDebugBreakLevel](debugsettings_layoutcycledebugbreaklevel.md)

## -examples
