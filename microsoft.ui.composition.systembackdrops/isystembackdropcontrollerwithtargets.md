---
-api-id: T:Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets
-api-type: winrt interface
---

# Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets

<!--
public interface ISystemBackdropControllerWithTargets : Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropController, System.IDisposable
-->


## -description

Extends the [ISystemBackdropController](isystembackdropcontroller.md) interface with the ability to manage system backdrop targets, their configuration, and state changes.

## -remarks

A _system backdrop_ is essentially a [CompositionBrush](../microsoft.ui.composition/compositionbrush.md) that defines a [UI material](/windows/apps/design/signature-experiences/materials) such as [Acrylic](/windows/apps/design/style/acrylic) or [Mica](/windows/apps/design/style/mica). This brush is drawn by the system compositor. A _system backdrop controller_ is an object that encapsulates both the rendering of the system backdrop material as well as the handling of system policy for the given material. Each material has its own controller.

The `ISystemBackdropControllerWithTargets` interface provides more granular control of [ICompositionSupportsSystemBackdrop](/uwp/api/windows.ui.composition.icompositionsupportssystembackdrop) targets. Targets may be added and removed at any time. All targets must share the same [Compositor](../microsoft.ui.composition/compositor.md). Adding a target that expects a different `Compositor` will cause an invalid argument exception to be thrown and the new target will not be added.

The [ISystemBackdropController](isystembackdropcontroller.md) interface does not provide a mechanism for you to provide app-specific material policy information, and instead requires the application window object. In contrast, the `ISystemBackdropControllerWithTargets` interface requires a [SystemBackdropConfiguration](systembackdropconfiguration.md) object that lets you specify your own app-specific material policy.

A system backdrop controller will only render a material if it has been provided a `SystemBackdropConfiguration` object along with at least one target. If not, it will not render anything. Removing a target will make it stop rendering the material. Removing all targets will disable the controller until at least one target is added.

## -see-also

## -examples


