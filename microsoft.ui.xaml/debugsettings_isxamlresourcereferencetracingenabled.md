---
-api-id: P:Microsoft.UI.Xaml.DebugSettings.IsXamlResourceReferenceTracingEnabled
-api-type: winrt property
---

# Microsoft.UI.Xaml.DebugSettings.IsXamlResourceReferenceTracingEnabled

<!--
public bool IsXamlResourceReferenceTracingEnabled { get; set; }
-->

## -description

Gets or sets a value that indicates whether to engage the XAML resource reference tracing feature of Microsoft Visual Studio when the app runs. When engaged and a XAML resource reference error occurs, the `XamlResourceReferenceFailed` event is raised and error information is logged in the native debug output.

## -property-value

`true` to engage the XAML resource reference tracing feature of Microsoft Visual Studio; otherwise, `false`. The default is `true`.

## -remarks

This property is `true` by default. When XAML resource reference tracing is enabled and you run your app with the native debugger attached, any  XAML resource reference errors appear in the **Output** window in Microsoft Visual Studio and cause a [XamlResourceReferenceFailed](debugsettings_xamlresourcereferencefailed.md) event to be raised.

See [XamlResourceReferenceFailedEventArgs.Message](xamlresourcereferencefailedeventargs_message.md) for more info about the error information that is provided.

## -see-also

[XamlResourceReferenceFailed](debugsettings_xamlresourcereferencefailed.md), [XamlResourceReferenceFailedEventArgs.Message](xamlresourcereferencefailedeventargs_message.md), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)

## -examples
