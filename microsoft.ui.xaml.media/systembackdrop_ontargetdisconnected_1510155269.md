---
-api-id: M:Microsoft.UI.Xaml.Media.SystemBackdrop.OnTargetDisconnected(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Media.SystemBackdrop.OnTargetDisconnected(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop)

<!--
protected virtual void OnTargetDisconnected (Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop disconnectedTarget);
-->

## -description

Called when this object is cleared from its container.

## -parameters

### -param disconnectedTarget

The target of the backdrop.

## -remarks

## -see-also

[OnTargetConnected](systembackdrop_ontargetconnected_1517461312.md)

## -examples

See [SystemBackdrop](systembackdrop.md) for the full example.

```csharp
protected override void OnTargetDisconnected(ICompositionSupportsSystemBackdrop disconnectedTarget)
{
    base.OnTargetDisconnected(disconnectedTarget);

    micaController.RemoveSystemBackdropTarget(disconnectedTarget);
    micaController = null;
}
```
