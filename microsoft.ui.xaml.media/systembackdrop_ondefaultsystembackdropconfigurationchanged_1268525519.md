---
-api-id: M:Microsoft.UI.Xaml.Media.SystemBackdrop.OnDefaultSystemBackdropConfigurationChanged(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Media.SystemBackdrop.OnDefaultSystemBackdropConfigurationChanged(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)

<!--
protected virtual void OnDefaultSystemBackdropConfigurationChanged (Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop target, Microsoft.UI.Xaml.XamlRoot xamlRoot);
-->


## -description

Override this method to be called when the object returned by **GetDefaultSystemBackdropConfiguration** changes. This is useful if you're using a custom **SystemBackdropConfiguration**.

## -parameters

### -param target

### -param xamlRoot

## -remarks

## -see-also

## -examples

This example shows a **MicaBackdrop** that forces the theme to always be light.

```csharp
protected override void OnSystemDefaultBackdropConfigurationChanged(SystemDefaultBackdropChangedEventArgs e)
{
    SetControllerConfig(e.ConnectedTarget, e.AssociatedRoot);
}

void SetControllerConfig(ICompositionSupportsSystemBackdrop connectedTarget, XamlRoot xamlRoot)
{
    var config = GetDefaultSystemBackdropConfiguration(connectedTarget, xamlRoot);
    config.Theme = SystemBackdropTheme.Light;
    _micaController.SetSystemBackdropConfiguration(config);
}
```