---
-api-id: T:Microsoft.UI.Xaml.Media.SystemBackdrop
-api-type: winrt class
---

# Microsoft.UI.Xaml.Media.SystemBackdrop

<!--
public class SystemBackdrop : Microsoft.UI.Xaml.DependencyObject
-->


## -description

Use this class to create a custom system backdrop. You don't create this class directly, but instead subclass it in order to add your custom support.

This class is the base of backdrop classes **MicaBackdrop** and **DesktopAcrylicBackdrop**.

## -remarks

## -see-also

## -examples

This example shows a custom system backdrop class that's implemented using **MicaController**.

```csharp
public class MicaSystemBackdrop : SystemBackdrop
{
    MicaController _micaController;

    protected override void OnTargetConnected(ICompositionSupportsSystemBackdrop connectedTarget, XamlRoot xamlRoot)
    {
        base.OnTargetConnected(connectedTarget, xamlRoot);

        if(_micaController != null)
        {
            throw new Exception("This controller can't be shared");
        }

        SetControllerConfig(connectedTarget, xamlRoot);

        _micaController = new MicaController();
        _micaController.AddSystemBackdropTarget(connectedTarget);
    }

    protected override void OnTargetDisconnected(ICompositionSupportsSystemBackdrop disconnectedTarget)
    {
        base.OnTargetDisconnected(disconnectedTarget);

        _micaController.RemoveSystemBackdropTarget(disconnectedTarget);
        _micaController = null;
    }

    void SetControllerConfig(ICompositionSupportsSystemBackdrop connectedTarget, XamlRoot xamlRoot)
    {
        var config = GetDefaultSystemBackdropConfiguration(connectedTarget, xamlRoot);
        _micaController.SetSystemBackdropConfiguration(config);
    }
}
```
