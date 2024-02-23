---
-api-id: T:Microsoft.UI.Xaml.LayoutCycleDebugBreakLevel
-api-type: winrt enum
---

# Microsoft.UI.Xaml.LayoutCycleDebugBreakLevel

<!--
public enum LayoutCycleDebugBreakLevel
-->

## -description

Defines constants that specify which level of layout cycle tracing events should trigger a debugger breakpoint
when a layout cycle crash appears imminent.

## -enum-fields

### -field None: 0

A debugger breakpoint is never triggered.

### -field Low: 1

A debugger breakpoint is triggered only at the minimal level.

### -field High: 2

A debugger breakpoint is triggered on more events than the `Low` setting, including all `Measure` and `Arrange` calls.

## -remarks

This enumeration provides values for the [DebugSettings.LayoutCycleDebugBreakLevel](debugsettings_layoutcycledebugbreaklevel.md) property.

These levels match the levels in [LayoutCycleTracingLevel](layoutcycletracinglevel.md). If layout cycle tracing is also enabled, the debugger breakpoint is triggered after the trace message is output.

## -see-also

[DebugSettings.LayoutCycleDebugBreakLevel](debugsettings_layoutcycledebugbreaklevel.md), [DebugSettings.LayoutCycleTracingLevel](debugsettings_layoutcycletracinglevel.md), [LayoutCycleTracingLevel](layoutcycletracinglevel.md)

## -examples


