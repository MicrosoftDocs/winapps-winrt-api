---
-api-id: M:Microsoft.UI.Xaml.Media.SystemBackdrop.GetDefaultSystemBackdropConfiguration(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Media.SystemBackdrop.GetDefaultSystemBackdropConfiguration(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)

<!--
public Microsoft.UI.Composition.SystemBackdrops.SystemBackdropConfiguration GetDefaultSystemBackdropConfiguration (Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop target, Microsoft.UI.Xaml.XamlRoot xamlRoot);
-->


## -description

Retrieves a **SystemBackdropConfiguration** object that's set and maintained automatically, and can be passed to **ISystemBackdropControllerWithTargets.SetSystemBackdropConfiguration**. The values of the properties on the **SystemBackdropConfiguration** that you receive might change over time:

* *Theme*: is set based on the target element's **ElementTheme**.
* *IsInputActive*: `true` if the target of the **SystemBackdrop** is in the active window; otherwise, `false`.
* *IsHighContrast*: `true` if the target of the **SystemBackdrop** is in high contrast mode; otherwise, `false`.

## -parameters

### -param target

The target of the backdrop.

### -param xamlRoot

The XAML root of the backdrop.

## -returns

A **SystemBackdropConfiguration** object.

## -remarks

## -see-also

## -examples
