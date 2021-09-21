---
-api-id: E:Microsoft.Windows.System.Power.PowerManager.PowerSourceKindChanged
-api-type: winrt event
---

# Microsoft.Windows.System.Power.PowerManager.PowerSourceKindChanged

<!--
public static event System.EventHandler<object> PowerSourceKindChanged;
-->


## -description

Raised when the power source of the device has changed.

## -remarks

To get the current power source of the device in response to this event, use the [PowerSourceKind](powermanager_powersourcekind.md) property. This event corresponds to the **GUID_ACDC_POWER_SOURCE** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[PowerSourceKind property](powermanager_powersourcekind.md), [PowerSourceKind enum](powersourcekind.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


