---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase
-api-type: winrt class
---

<!-- Class syntax.
public class FlyoutBase : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Controls.Primitives.IFlyoutBase, Windows.UI.Xaml.Controls.Primitives.IFlyoutBase2, Windows.UI.Xaml.Controls.Primitives.IFlyoutBase3, Windows.UI.Xaml.Controls.Primitives.IFlyoutBaseOverrides
-->

# Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase

## -description

Represents the base class for flyout controls, such as [Flyout](../microsoft.ui.xaml.controls/flyout.md) and [MenuFlyout](../microsoft.ui.xaml.controls/menuflyout.md).

## -remarks

> [!NOTE]
> When used with [XAML Islands](/windows/apps/desktop/modernize/xaml-islands) ([DesktopWindowXamlSource](../microsoft.ui.xaml.hosting/desktopwindowxamlsource.md)): By default, this control is automatically constrained within the _[work area](../microsoft.ui.windowing/displayarea_workarea.md)_ of its display. To change this behavior, set the [DesktopWindowXamlSource.ShouldConstrainPopupsToWorkArea](../microsoft.ui.xaml.hosting/desktopwindowxamlsource_shouldconstrainpopupstoworkarea.md) property of the XAML island that contains this control.

### **FlyoutBase** derived classes

FlyoutBase is the parent class for [Flyout](../microsoft.ui.xaml.controls/flyout.md) and [MenuFlyout](../microsoft.ui.xaml.controls/menuflyout.md).

### XAML attached properties

FlyoutBase is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../microsoft.ui.xaml/dependencyobject_getvalue_229640130.md) or [SetValue](../microsoft.ui.xaml/dependencyobject_setvalue_1212521140.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| AttachedFlyout | Gets or sets the flyout attached to a [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md).<ul><li>Type: FlyoutBase</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.attachedflyoutproperty">AttachedFlyoutProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.getattachedflyout">GetAttachedFlyout</a>, <a href="/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.setattachedflyout">SetAttachedFlyout</a></li></ul>To attach a flyout to a Button, use [Button.Flyout](../microsoft.ui.xaml.controls/button_flyout.md) instead.|

## -examples

## -see-also

[DependencyObject](../microsoft.ui.xaml/dependencyobject.md), [Flyout](../microsoft.ui.xaml.controls/flyout.md), [MenuFlyout](../microsoft.ui.xaml.controls/menuflyout.md), [Button.Flyout](../microsoft.ui.xaml.controls/button_flyout.md), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
