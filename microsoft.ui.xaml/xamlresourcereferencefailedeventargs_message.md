---
-api-id: P:Microsoft.UI.Xaml.XamlResourceReferenceFailedEventArgs.Message
-api-type: winrt property
---

# Microsoft.UI.Xaml.XamlResourceReferenceFailedEventArgs.Message

<!--
public string Message { get; }
-->

## -description

Gets a human-readable description (in English) of the XAML resource reference failure.

## -property-value

A human-readable description (in English) of the XAML resource reference failure.

## -remarks

The message in the event data contains the following information about the failed XAML resource reference:

- The URI of the XAML page that contains each [ResourceDictionary](resourcedictionary.md) that was searched.
- The order in which the `ResourceDictionary`s were searched.

You can use this information to investigate why the XAML resource reference could not be resolved. For example, maybe the `ResourceDictionary` that contains the resource was not in the list of `ResourceDictionary`s that was searched; or perhaps that `ResourceDictionary` was searched, which could indicate that an incorrect resource key was specified.

## -see-also

[IsXamlResourceReferenceTracingEnabled](debugsettings_isxamlresourcereferencetracingenabled.md), [XamlResourceReferenceFailed](debugsettings_xamlresourcereferencefailed.md), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)

## -examples

Here is an example message from the WinUI Gallery sample app after an incorrect resource reference
(`OutputTextBlockStyl` rather than `OutputTextBlockStyle`) was deliberately inserted. If you know
that the desired resource is defined in `App.xaml`, then the failure to locate it in there is a
strong indicator of an erroneous reference.

> [!CAUTION]
> This example output is for illustrative purposes only. The precise format of the message is implementation-defined and may change in the future. Applications should not attempt to parse the message.

```
Beginning search for resource with key 'OutputTextBlockStyl'.
  Searching dictionary 'ms-appx:///Controls/ControlExample.xaml' for resource with key 'OutputTextBlockStyl'.
  Finished searching dictionary 'ms-appx:///Controls/ControlExample.xaml'.
  Searching dictionary 'Framework-defined colors' for resource with key 'OutputTextBlockStyl'.
  Finished searching dictionary 'Framework-defined colors'.
  Searching dictionary 'Framework ThemeResources.xbf' for resource with key 'OutputTextBlockStyl'.
    Searching theme dictionary (active theme: 'Light') for resource with key 'OutputTextBlockStyl'.
      Searching dictionary '<anonymous dictionary>' for resource with key 'OutputTextBlockStyl'.
      Finished searching dictionary '<anonymous dictionary>'.
    Finished searching theme dictionary (active theme: 'Light').
  Finished searching dictionary 'Framework ThemeResources.xbf'.
  Searching dictionary 'ms-appx:///App.xaml' for resource with key 'OutputTextBlockStyl'.
    Searching merged dictionary with index '1' for resource with key 'OutputTextBlockStyl'.
      Searching dictionary 'ms-appx:///Microsoft.UI.Xaml/Themes/themeresources.xaml' for resource with key 'OutputTextBlockStyl'.
        Searching theme dictionary (active theme: 'Light') for resource with key 'OutputTextBlockStyl'.
          Searching dictionary 'ms-appx:///Microsoft.UI.Xaml/Themes/themeresources.xaml' for resource with key 'OutputTextBlockStyl'.
          Finished searching dictionary 'ms-appx:///Microsoft.UI.Xaml/Themes/themeresources.xaml'.
        Finished searching theme dictionary (active theme: 'Light').
      Finished searching dictionary 'ms-appx:///Microsoft.UI.Xaml/Themes/themeresources.xaml'.
    Finished searching merged dictionary with index '1'.
    Searching merged dictionary with index '0' for resource with key 'OutputTextBlockStyl'.
      Searching dictionary 'ms-appx:///ItemTemplates.xaml' for resource with key 'OutputTextBlockStyl'.
      Finished searching dictionary 'ms-appx:///ItemTemplates.xaml'.
    Finished searching merged dictionary with index '0'.
    Searching theme dictionary (active theme: 'Light') for resource with key 'OutputTextBlockStyl'.
      Searching dictionary 'ms-appx:///App.xaml' for resource with key 'OutputTextBlockStyl'.
      Finished searching dictionary 'ms-appx:///App.xaml'.
    Finished searching theme dictionary (active theme: 'Light').
  Finished searching dictionary 'ms-appx:///App.xaml'.
Finished search for resource with key 'OutputTextBlockStyl'.
```
