---
-api-id: T:Microsoft.UI.Xaml.Media.SystemBackdrop
-api-type: winrt class
---

# Microsoft.UI.Xaml.Media.SystemBackdrop

<!--
public class SystemBackdrop : Microsoft.UI.Xaml.DependencyObject
-->

## -description

Base class for custom system backdrops used to render materials like Mica and Acrylic.

## -remarks

Use this class to create a custom system backdrop. You don't create this class directly (note the protected constructor). Instead, subclass it in order to add your custom support. You can also use one of the built-in derived classes, [MicaBackdrop](micabackdrop.md) and [DesktopAcrylicBackdrop](desktopacrylicbackdrop.md).

Generally, the custom material overrides [OnTargetConnected](systembackdrop_ontargetconnected_1517461312.md) to create and configure a backing [ISystemBackdropController](../microsoft.ui.composition.systembackdrops/isystembackdropcontroller.md), which will manage the [CompositionBrush](../microsoft.ui.composition/compositionbrush.md) used to fill the backdrop region. The brush's ultimate pixel rendering is affected by:

- the environment/policy set via [SystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/systembackdropconfiguration.md)
- the material's appearance parameters, exposed via general properties like [ISystemBackdropControllerWithTargets.State](../microsoft.ui.composition.systembackdrops/isystembackdropcontrollerwithtargets_state.md) (`Active`/`Fallback`/`HighContrast`) and material-specific properties like [MicaController.Kind](../microsoft.ui.composition.systembackdrops/micacontroller_kind.md) (`Base`/`BaseAlt`).

The built-in controllers ([MicaController](../microsoft.ui.composition.systembackdrops/micacontroller.md) and [DesktopAcrylicController](../microsoft.ui.composition.systembackdrops/desktopacryliccontroller.md)) support the following parameters for customizing their appearance: `FallbackColor`, `LuminosityOpacity`, `TintColor`, and `TintOpacity`. The built-in system backdrops ([MicaBackdrop](micabackdrop.md) and [DesktopAcrylicBackdrop](desktopacrylicbackdrop.md)) do not expose `FallbackColor` or the material customization properties (`TintOpacity`, etc). Instead, they rely on the default Light/Dark configurations of the underlying `MicaController` and `DesktopAcrylicController`. To customize these properties, create a custom material class that derives from `SystemBackdrop` and expose the desired properties.

## -see-also

[Mica material](/windows/apps/design/style/mica), [Acrylic material](/windows/apps/design/style/acrylic)

## -examples

This example shows a custom system backdrop class that's implemented using [MicaController](../microsoft.ui.composition.systembackdrops/micacontroller.md).

Calling the base [OnTargetConnected](systembackdrop_ontargetconnected_1517461312.md) method initializes the default configuration object returned by [GetDefaultSystemBackdropConfiguration](systembackdrop_getdefaultsystembackdropconfiguration_1632097551.md) to reflect environment changes that affect this `SystemBackdrop` instance (specified by `connectedTarget, XamlRoot`).

Although the example on this page does not support sharing `MicaSystemBackdrop` instances (for example, `Window1.SystemBackdrop = Window2.SystemBackdrop = myMicaSystemBackdrop`), such sharing is possible and is supported by the built-in `MicaBackdrop` and `DesktopAcrylicBackdrop` materials. To implement sharing in a custom material, vectorize the backing [ISystemBackdropController](../microsoft.ui.composition.systembackdrops/isystembackdropcontroller.md) storage to keep a separate instance for each usage context (for example, via a map keyed on `connectedTarget`). Note that `SystemBackdrop` similarly vectorizes the associated default configuration objects returned by [GetDefaultSystemBackdropConfiguration](systembackdrop_getdefaultsystembackdropconfiguration_1632097551.md), ensuring the configuration reflects each usage context when `SystemBackdrop` is shared.

```xaml
<Window
    ... >
    <Window.SystemBackdrop>
        <local:MicaSystemBackdrop/>
    </Window.SystemBackdrop>

    <!-- XAML content -->

</Window>
```

```csharp
public class MicaSystemBackdrop : SystemBackdrop
{
    MicaController micaController;

    protected override void OnTargetConnected(ICompositionSupportsSystemBackdrop connectedTarget, XamlRoot xamlRoot)
    {
        // Call the base method to initialize the default configuration object.
        base.OnTargetConnected(connectedTarget, xamlRoot);

        // This example does not support sharing MicaSystemBackdrop instances.
        if (micaController is not null)
        {
            throw new Exception("This controller cannot be shared");
        }

        micaController = new MicaController();
        // Set configuration.
        SystemBackdropConfiguration defaultConfig = GetDefaultSystemBackdropConfiguration(connectedTarget, xamlRoot);
        micaController.SetSystemBackdropConfiguration(defaultConfig);
        // Add target.
        micaController.AddSystemBackdropTarget(connectedTarget);
    }

    protected override void OnTargetDisconnected(ICompositionSupportsSystemBackdrop disconnectedTarget)
    {
        base.OnTargetDisconnected(disconnectedTarget);

        micaController.RemoveSystemBackdropTarget(disconnectedTarget);
        micaController = null;
    }
}
```
