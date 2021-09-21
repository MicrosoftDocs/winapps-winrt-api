---
-api-id: E:Microsoft.Windows.System.Power.PowerManager.EnergySaverStatusChanged
-api-type: winrt event
---

# Microsoft.Windows.System.Power.PowerManager.EnergySaverStatusChanged

<!--
public static event System.EventHandler<object> EnergySaverStatusChanged;
-->

## -description

Raised when [battery saver](/windows-hardware/design/component-guidelines/battery-saver) has been turned off or on in response to changing power conditions.

## -remarks

To get the current battery saver state in response to this event, use the [EnergySaverStatus](powermanager_energysaverstatus.md) property. This event corresponds to the **GUID_POWER_SAVING_STATUS** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[EnergySaverStatus property](powermanager_energysaverstatus.md), [EnergySaverStatus enum](energysaverstatus.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


