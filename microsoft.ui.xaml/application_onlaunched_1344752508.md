---
-api-id: M:Microsoft.UI.Xaml.Application.OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Application.OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs)

<!--
protected virtual void OnLaunched (Microsoft.UI.Xaml.LaunchActivatedEventArgs args);
-->

## -description

Invoked when the application is launched. Override this method to perform application initialization and to create a new window.

## -parameters

### -param args

## -remarks

## -see-also

[LaunchActivatedEventArgs](launchactivatedeventargs.md)

## -examples

Use `OnLaunched` to create and activate the main window. (This code is provided by the Visual Studio project templates when you create a WinUI 3 app.)

```csharp
private Window m_window;

protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
{
    m_window = new MainWindow();
    m_window.Activate();
}
```
