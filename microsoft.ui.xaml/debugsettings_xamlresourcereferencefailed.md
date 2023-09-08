---
-api-id: E:Microsoft.UI.Xaml.DebugSettings.XamlResourceReferenceFailed
-api-type: winrt event
---

# Microsoft.UI.Xaml.DebugSettings.XamlResourceReferenceFailed

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.DebugSettings,Microsoft.UI.Xaml.XamlResourceReferenceFailedEventArgs> XamlResourceReferenceFailed;
-->

## -description

Occurs when a reference to a XAML resource cannot be resolved.

## -remarks

[IsXamlResourceReferenceTracingEnabled](debugsettings_isxamlresourcereferencetracingenabled.md) must be `true` in order for this event to be raised.

Error information is also logged to the native debug output when the event is raised, so attaching a `XamlResourceReferenceFailed` handler yourself is an advanced scenario for getting the raw message programmatically.

See [XamlResourceReferenceFailedEventArgs.Message](xamlresourcereferencefailedeventargs_message.md) for more info about the error information that is provided.

## -see-also

[IsXamlResourceReferenceTracingEnabled](debugsettings_isxamlresourcereferencetracingenabled.md), [XamlResourceReferenceFailedEventArgs.Message](xamlresourcereferencefailedeventargs_message.md), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)

## -examples
