---
-api-id: M:Microsoft.UI.Xaml.Media.SystemBackdrop.OnDefaultSystemBackdropConfigurationChanged(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Media.SystemBackdrop.OnDefaultSystemBackdropConfigurationChanged(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)

<!--
protected virtual void OnDefaultSystemBackdropConfigurationChanged (Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop target, Microsoft.UI.Xaml.XamlRoot xamlRoot);
-->

## -description

Override this method to be called when the object returned by `GetDefaultSystemBackdropConfiguration` changes. This is useful if you're using a custom `SystemBackdropConfiguration`.

## -parameters

### -param target

The target of the backdrop.

### -param xamlRoot

The XAML root of the backdrop target.

## -remarks

This method is useful when you implement a custom [SystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/systembackdropconfiguration.md) that incorporates some of the tracked property states but is different in some way from the default policy.

Instead of applying the default backdrop configuration obtained from [GetDefaultSystemBackdropConfiguration](systembackdrop_getdefaultsystembackdropconfiguration_1632097551.md) (by passing it to [SetSystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/isystembackdropcontrollerwithtargets_setsystembackdropconfiguration_1581057982.md)),
override `OnDefaultSystemBackdropConfigurationChanged`. When there is a change to the default policy (like when a user changes the system theme from Light to Dark), this method is called. In this method, create a new [SystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/systembackdropconfiguration.md) object and set it's properties as needed. Then pass the modified `SystemBackdropConfiguration` to [SetSystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/isystembackdropcontrollerwithtargets_setsystembackdropconfiguration_1581057982.md).

## -see-also

## -examples

This example shows a custom system backdrop class that's implemented using [MicaController](../microsoft.ui.composition.systembackdrops/micacontroller.md). The `OnDefaultSystemBackdropConfigurationChanged` method is overridden, and in it the configuration `Theme` is set to always be light.

For example, if the system theme is changed from Light to Dark while the app is running, this method is called, and the backdrop theme is set back to Light rather than changing to Dark with the system theme.

```xaml
<Window
    ... >
    <Window.SystemBackdrop>
        <local:MicaLightSystemBackdrop/>
    </Window.SystemBackdrop>

    <!-- XAML content -->

</Window>
```

```csharp
public class MicaLightSystemBackdrop : SystemBackdrop
{
    MicaController micaController;

    protected override void OnTargetConnected(ICompositionSupportsSystemBackdrop connectedTarget, XamlRoot xamlRoot)
    {
        base.OnTargetConnected(connectedTarget, xamlRoot);

        if (micaController is not null)
        {
            throw new Exception("This controller cannot be shared");
        }

        micaController = new MicaController();
        //_ = GetDefaultSystemBackdropConfiguration(connectedTarget, xamlRoot);

        micaController.AddSystemBackdropTarget(connectedTarget);
    }

    protected override void OnTargetDisconnected(ICompositionSupportsSystemBackdrop disconnectedTarget)
    {
        base.OnTargetDisconnected(disconnectedTarget);

        micaController.RemoveSystemBackdropTarget(disconnectedTarget);
        micaController = null;
    }

    protected override void OnDefaultSystemBackdropConfigurationChanged(ICompositionSupportsSystemBackdrop target, XamlRoot xamlRoot)
    {
        SystemBackdropConfiguration config = new SystemBackdropConfiguration();
        config.Theme = SystemBackdropTheme.Light;

        micaController.SetSystemBackdropConfiguration(config);
    }
}
```
