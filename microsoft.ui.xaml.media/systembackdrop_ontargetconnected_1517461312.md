---
-api-id: M:Microsoft.UI.Xaml.Media.SystemBackdrop.OnTargetConnected(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Media.SystemBackdrop.OnTargetConnected(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop,Microsoft.UI.Xaml.XamlRoot)

<!--
protected virtual void OnTargetConnected (Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop connectedTarget, Microsoft.UI.Xaml.XamlRoot xamlRoot);
-->

## -description

Called when this object is attached to a valid container; for example, when set on `Window.SystemBackdrop`.

## -parameters

### -param connectedTarget

The target of the backdrop.

### -param xamlRoot

The XAML root of the backdrop target.

## -remarks

This method is called when this [SystemBackdrop](systembackdrop.md) is attached to a valid container; that is, when it's assigned to the [SystemBackdrop](../microsoft.ui.composition/icompositionsupportssystembackdrop_systembackdrop.md) property of an object that implements [ICompositionSupportsSystemBackdrop](../microsoft.ui.composition/icompositionsupportssystembackdrop.md), such as [Window.SystemBackdrop](../microsoft.ui.xaml/window_systembackdrop.md).

Override this method to create and configure the underlying [ISystemBackdropController](../microsoft.ui.composition.systembackdrops/isystembackdropcontroller.md) and its [SystemBackdropConfiguration](../microsoft.ui.composition.systembackdrops/systembackdropconfiguration.md).

## -see-also

[OnTargetDisconnected](systembackdrop_ontargetdisconnected_1510155269.md)

## -examples

See [SystemBackdrop](systembackdrop.md) for the full example.

```csharp
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
```
