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

This method is typically created automatically when a project is created. You can then modify it or remove it.

## -see-also

[LaunchActivatedEventArgs](launchactivatedeventargs.md)

## -examples

Use `OnLaunched` to create the main window and pass it the first command line argument.

[!code-csharp[DesktopOnLaunchedSample](../microsoft.ui.xaml/code/Application_OnLaunchedSample/MainPage.xaml.cs#SnippetDesktopOnLaunchedSample)]
