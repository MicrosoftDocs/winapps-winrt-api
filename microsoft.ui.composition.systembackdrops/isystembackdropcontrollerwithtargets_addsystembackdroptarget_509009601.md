---
-api-id: M:Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets.AddSystemBackdropTarget(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop)
-api-type: winrt method
---

# Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets.AddSystemBackdropTarget(Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop)

<!--
public bool AddSystemBackdropTarget (Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop systemBackdropTarget);
-->


## -description

Adds the specified system backdrop target on which to draw the material.

## -parameters

### -param systemBackdropTarget

The system backdrop target to add.

## -returns

`true` if the controller was able to draw the material on the target; otherwise, `false`.

## -remarks

Re-adding an existing target does nothing.

This method must be called on a thread with a [DispatcherQueue](/uwp/api/windows.system.dispatcherqueue).

## -see-also

## -examples


