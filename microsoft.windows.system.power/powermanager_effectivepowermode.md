---
-api-id: P:Microsoft.Windows.System.Power.PowerManager.EffectivePowerMode
-api-type: winrt property
---

# Microsoft.Windows.System.Power.PowerManager.EffectivePowerMode

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.System.Power.EffectivePowerMode> EffectivePowerMode { get; }
-->

## -description

Gets the current effective power mode of the device.

## -property-value

The current effective power mode of the device.

## -remarks

This property returns an asynchronous operation that resolves to the current [EffectivePowerMode](effectivepowermode.md). For a synchronous alternative, use [EffectivePowerMode2](powermanager_effectivepowermode2.md).

The effective power mode reflects the combined result of the user's power plan selection, battery saver state, and system policies. Use this value to adjust your app's resource usage — for example, reduce animation quality or defer background processing when the mode is `BatterySaver` or `BetterBattery`.

## -see-also

[EffectivePowerModeChanged event](powermanager_effectivepowermodechanged.md), [EffectivePowerMode enum](effectivepowermode.md), [Power management with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-power), [EffectivePowerMode2](./powermanager_effectivepowermode2.md)

## -examples
