---
-api-id: T:Microsoft.UI.Xaml.Application
-api-type: winrt class
---

<!-- Class syntax.
public class Application : Windows.UI.Xaml.IApplication, Windows.UI.Xaml.IApplication2, Windows.UI.Xaml.IApplicationOverrides, Windows.UI.Xaml.IApplicationOverrides2
-->

# Microsoft.UI.Xaml.Application

## -description

Represents the current application and its available services.

## -xaml-syntax

```xaml
<Application />
```

## -remarks

The `Application` class encapsulates an app and provides the following services:

- app entry point
- app-scoped resources
- unhandled exception detection

The `Application` object is typically provided in the initial XAML for App.xaml. The default project templates in Visual Studio generate an `App` class that derives from `Application` and provides an entry point where you can add initialization code.

The `App` class associates itself with the corresponding XAML by calling the generated `InitializeComponent` method in its constructor. You can add additional initialization code to the `App` constructor, but you will typically only add code to associate a handler for the [UnhandledException](application_unhandledexception.md) event or set the [RequestedTheme](application_requestedtheme.md). You should put other initialization code in the [OnLaunched](application_onlaunched_1344752508.md) method override.

> [!TIP]
> For more info, see [Windows App SDK app lifecycle](/windows/apps/windows-app-sdk/applifecycle/applifecycle).

Because of its position in the application model, codegen, and activation sequence, `Application` has some restrictions on its XAML usage:

- Other than the xmlns declarations and **x:Class**, no other attribute can appear on the `Application` root tag.
- Don't attempt to change **x:Class** values that come from the project template App.xaml pages, there are additional dependencies on using that naming scheme that exist in the build actions.
- Don't wire the `Application` event handlers in XAML. All event wiring should be done in code (usually in the constructor).
- The only expected properties on an `Application` instance in XAML is the set of elements to populate the [Application.Resources](application_resources.md) property, using a XAML property element usage. For more info, see [Resources](application_resources.md).
- To provide general error handling for any exceptions that your app code doesn't catch, handle the [UnhandledException](application_unhandledexception.md) event.

> [!NOTE]
> The `Application` main file must be named `App.xaml`.

## -examples

## -see-also

[Windows App SDK app lifecycle](/windows/apps/windows-app-sdk/applifecycle/applifecycle), [Window](window.md)
