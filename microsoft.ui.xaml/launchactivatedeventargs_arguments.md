---
-api-id: P:Microsoft.UI.Xaml.LaunchActivatedEventArgs.Arguments
-api-type: winrt property
---

# Microsoft.UI.Xaml.LaunchActivatedEventArgs.Arguments

<!--
public string Arguments { get; }
-->

## -description

Gets the arguments that are passed to the application during launch.

## -property-value

Always an empty string in desktop apps.

## -remarks

> [!IMPORTANT]
> This property is not used and always returns an empty string.

You can retrieve command-line arguments for the current process by calling:

- [C#] <xref:System.Environment.GetCommandLineArgs?displayProperty=nameWithType> (requires full trust to execute)
- [C++] <xref:NF:processenv.GetCommandLineA>

## -see-also

## -examples
