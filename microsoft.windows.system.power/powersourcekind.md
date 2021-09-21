---
-api-id: T:Microsoft.Windows.System.Power.PowerSourceKind
-api-type: winrt enum
---

# Microsoft.Windows.System.Power.PowerSourceKind

<!--
public enum PowerSourceKind
-->


## -description

Defines values that represent the power source of the device.

## -enum-fields

### -field AC: 0

The computer is powered by an AC power source (or similar, such as a laptop powered by a 12V automotive adapter).

### -field DC: 1

The computer is powered by an onboard battery power source.

## -remarks

This enum corresponds to the **GUID_ACDC_POWER_SOURCE** [power setting GUID](/windows/win32/power/power-setting-guids).

## -see-also

[PowerSourceKind property](powermanager_powersourcekind.md), [PowerSourceKindChanged event](powermanager_powersourcekindchanged.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


