---
-api-id: P:Microsoft.UI.Xaml.DebugSettings.LayoutCycleDebugBreakLevel
-api-type: winrt property
---

# Microsoft.UI.Xaml.DebugSettings.LayoutCycleDebugBreakLevel

<!--
public Microsoft.UI.Xaml.LayoutCycleDebugBreakLevel LayoutCycleDebugBreakLevel { get; set; }
-->

## -description

Gets or sets a value that indicates the level of layout cycle tracing events that trigger a debugger breakpoint.

## -property-value

A value of the enumeration that indicates the level of layout cycle tracing events that trigger a debugger breakpoint. The default is `None`.

## -remarks

This debug break level corresponds to the [DebugSettings.LayoutCycleTracingLevel](debugsettings_layoutcycletracinglevel.md). The tracing and break levels can be set independently to enable the common scenario of wanting a higher tracing level than debug break level.

When a layout cycle crash appears imminent, this debug break level is used to determine when a native debugger breakpoint will be triggered for layout-related operations.

A debugger breakpoint will only be triggered if a native debugger is attached to the process to avoid crashing the process when not run under a debugger or when only attached with a managed debugger.

## -see-also

[DebugSettings.LayoutCycleTracingLevel](debugsettings_layoutcycletracinglevel.md)

## -examples

public App()
{
    this.InitializeComponent();

#if DEBUG
    DebugSettings.LayoutCycleTracingLevel = LayoutCycleTracingLevel.High;
    DebugSettings.LayoutCycleDebugBreakLevel = LayoutCycleDebugBreakLevel.Low;
#endif
}
