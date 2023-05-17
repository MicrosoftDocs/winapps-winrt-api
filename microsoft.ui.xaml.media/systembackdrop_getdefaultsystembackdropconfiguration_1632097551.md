---
-api-id: M:Microsoft.UI.Xaml.Media.SystemBackdrop.GetDefaultSystemBackdropConfiguration(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Media.SystemBackdrop.GetDefaultSystemBackdropConfiguration(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)

<!--
public Microsoft.UI.Composition.SystemBackdrops.SystemBackdropConfiguration GetDefaultSystemBackdropConfiguration (Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop target, Microsoft.UI.Xaml.XamlRoot xamlRoot);
-->

## -description

Retrieves a default `SystemBackdropConfiguration` object that can be passed to `ISystemBackdropControllerWithTargets.SetSystemBackdropConfiguration`.

## -parameters

### -param target

The target of the backdrop.

### -param xamlRoot

The XAML root of the backdrop target.

## -returns

A default `SystemBackdropConfiguration` object.

## -remarks

The default [SystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/systembackdropconfiguration.md) object that's returned is set and maintained automatically for each [SystemBackdrop](systembackdrop.md) usage context (`connectedTarget`), and can be passed to [ISystemBackdropControllerWithTargets.SetSystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/isystembackdropcontrollerwithtargets_setsystembackdropconfiguration_1581057982.md). The values of the properties on the `SystemBackdropConfiguration` that you receive might change over time:

* *Theme*: set based on the `ElementTheme` of the target element (obtained from `xamlRoot.Content`).

    If `FallbackColor`, `LuminosityOpacity`, `TintColor`, or `TintOpacity` are modified by the material's implementation, changes to associated [SystemBackdropConfiguration.Theme](/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.systembackdrops.systembackdropconfiguration.theme) will no longer automatically toggle the controller's theme (because the default Dark and Light configurations are no longer appropriate). In this case, the material's appearance properties need to be manually updated to match the new theme in [SystemBackdrop.OnDefaultSystemBackdropConfigurationChanged](systembackdrop_ondefaultsystembackdropconfigurationchanged_1268525519.md).

* *IsInputActive*: `true` if the target of the `SystemBackdrop` is in the active window; otherwise, `false`.
* *IsHighContrast*: `true` if the target of the `SystemBackdrop` is in high contrast mode; otherwise, `false`.

## -see-also

[OnDefaultSystemBackdropConfigurationChanged](systembackdrop_ondefaultsystembackdropconfigurationchanged_1268525519.md)

## -examples
