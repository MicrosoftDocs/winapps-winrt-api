---
-api-id: T:Microsoft.UI.Xaml.LaunchActivatedEventArgs
-api-type: winrt class
---

# Microsoft.UI.Xaml.LaunchActivatedEventArgs

<!--
public sealed class LaunchActivatedEventArgs
-->

## -description

Provides event information for the [Application.OnLaunched](application_onlaunched_1344752508.md) event.

## -remarks

The `Arguments` and `UWPLaunchActivatedEventArgs` properties are not supported in Windows App SDK apps.

You can retrieve command-line arguments for the current process by calling:

- [C#] <xref:System.Environment.GetCommandLineArgs?displayProperty=nameWithType> (requires full trust to execute)
- [C++] <xref:NF:processenv.GetCommandLineA>

## -see-also

## -examples
