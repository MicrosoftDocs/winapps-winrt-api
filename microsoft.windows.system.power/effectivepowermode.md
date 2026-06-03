---
-api-id: T:Microsoft.Windows.System.Power.EffectivePowerMode
-api-type: winrt enum
---

# Microsoft.Windows.System.Power.EffectivePowerMode

<!--
public enum EffectivePowerMode
-->


## -description

Defines values that represent the effective power mode of the device.

## -enum-fields

### -field BatterySaver: 0

The device is in battery saver mode.

### -field BetterBattery: 1

The device is in the better battery effective power mode.

### -field Balanced: 2

The device is in the balanced effective power mode.

### -field HighPerformance: 3

The device is in the high performance effective power mode.

### -field MaxPerformance: 4

The device is in the maximum performance effective power mode.

### -field GameMode: 5

The device is in game mode power mode.

### -field MixedReality: 6

The device is in the windows mixed reality power mode.

## -remarks

The effective power mode reflects the combined result of the user's power plan selection, battery saver state, and other system policies. The values are ordered from lowest power consumption (`BatterySaver`) to highest (`MaxPerformance`), with `GameMode` and `MixedReality` representing specialized modes for those workloads.

Use this enum with the [EffectivePowerMode](powermanager_effectivepowermode.md) or [EffectivePowerMode2](powermanager_effectivepowermode2.md) property to adapt your app's behavior to the current power mode.

## -see-also

[EffectivePowerMode property](powermanager_effectivepowermode.md), [EffectivePowerModeChanged event](powermanager_effectivepowermodechanged.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power)

## -examples


