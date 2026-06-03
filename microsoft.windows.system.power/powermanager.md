---
-api-id: T:Microsoft.Windows.System.Power.PowerManager
-api-type: winrt class
---

# Microsoft.Windows.System.Power.PowerManager

<!--
public static class PowerManager
-->


## -description

Provides static events that notify your app of changes to the devices power state and static properties that provide access to current power state information.

## -remarks

**PowerManager** is a static class — you do not instantiate it. Read its properties to query the current power state and subscribe to its events to be notified when the state changes.

All properties and events are available in both packaged and unpackaged Windows App SDK desktop apps. The class wraps the underlying Win32 [power setting GUIDs](/windows/win32/power/power-setting-guids) into a strongly-typed WinRT surface.

For more information, see [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power).

## -see-also

[Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples

The following example checks whether the device is on battery and subscribes to power-state change events.

```csharp
using Microsoft.Windows.System.Power;

// Check current power source
if (PowerManager.PowerSourceKind == PowerSourceKind.DC)
{
    // Running on battery — defer non-essential work
    int chargePercent = PowerManager.RemainingChargePercent;
    System.Diagnostics.Debug.WriteLine($"On battery: {chargePercent}% remaining");
}

// React to battery status changes
PowerManager.BatteryStatusChanged += (sender, args) =>
{
    BatteryStatus status = PowerManager.BatteryStatus;
    if (status == BatteryStatus.Discharging)
    {
        // Reduce background activity
    }
};

// React to energy saver (battery saver) changes
PowerManager.EnergySaverStatusChanged += (sender, args) =>
{
    if (PowerManager.EnergySaverStatus == EnergySaverStatus.On)
    {
        // Minimize resource usage
    }
};
```
