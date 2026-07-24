---
-api-id: N:Microsoft.Windows.System.Power
-api-type: winrt namespace
---

# Microsoft.Windows.System.Power

## -description

Provides a set of power management APIs that allow visibility into how an app affects the device's power state, and enable the app to make intelligent decisions about resource usage. For example, an app might use this API to postpone resource-intensive background tasks while the device is running on battery power.

For more information, see [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power).

## -remarks

The **Microsoft.Windows.System.Power** namespace is part of the Windows App SDK. The [PowerManager](powermanager.md) class provides static properties to query the current power state and static events to react when the state changes. The namespace also defines enums such as [BatteryStatus](batterystatus.md), [EffectivePowerMode](effectivepowermode.md), and [PowerSourceKind](powersourcekind.md) that represent the possible values for those properties.

Common scenarios include deferring background work when the device is on battery, reducing visual effects in power-saver mode, and pausing activity when the user is away or the display is off.

## -see-also

[Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples
