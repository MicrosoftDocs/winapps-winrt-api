---
-api-id: T:Microsoft.Windows.System.Power.EnergySaverStatus
-api-type: winrt enum
---

# Microsoft.Windows.System.Power.EnergySaverStatus

<!--
public enum EnergySaverStatus
-->


## -description

Defines values that represent the [battery saver](/windows-hardware/design/component-guidelines/battery-saver) states of the device.

## -enum-fields

### -field Uninitialized: 0

Battery saver is uninitialized.

### -field Disabled: 1

Battery saver is disabled.

### -field Off: 2

Battery saver is off.

### -field On: 3

Battery saver is on.

## -remarks

This enum corresponds to the **GUID_POWER_SAVING_STATUS** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[EnergySaverStatus property](powermanager_energysaverstatus.md), [EnergySaverStatusChanged event](powermanager_energysaverstatuschanged.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


