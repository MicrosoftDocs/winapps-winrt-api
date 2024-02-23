---
-api-id: T:Microsoft.UI.Xaml.LayoutCycleTracingLevel
-api-type: winrt enum
---

# Microsoft.UI.Xaml.LayoutCycleTracingLevel

<!--
public enum LayoutCycleTracingLevel
-->

## -description

Defines constants that specify whether layout cycle tracing information is written to the native debugger and the level of detail that is recorded.

## -enum-fields

### -field None: 0

Minimal layout cycle information is recorded in [stowed exceptions](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/threading#stowed-exceptions) in crash dumps. There is no output to the native debugger.

### -field Low: 1

Minimal layout cycle information is recorded in [stowed exceptions](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/threading#stowed-exceptions) in crash dumps. The same information is also output to the native debugger.

### -field High: 2

More verbose layout cycle information is provided that includes all `Measure` and `Arrange` calls with their `availableSize` and `finalSize` values. The output is recorded in [stowed exceptions](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/threading#stowed-exceptions) in crash dumps. The same information is also output to the native debugger.

## -remarks

This enumeration provides values for the [DebugSettings.LayoutCycleTracingLevel](debugsettings_layoutcycletracinglevel.md) property.

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
