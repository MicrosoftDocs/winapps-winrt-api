---
-api-id: M:Microsoft.UI.Xaml.Application.LoadComponent(System.Object,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public void LoadComponent(System.Object component, Windows.Foundation.Uri resourceLocator)
-->

# Microsoft.UI.Xaml.Application.LoadComponent

## -description

Loads a XAML file that is located at the specified relative location, and converts it to an instance of the object that is specified by the root element of the XAML file.

## -parameters

### -param component

An object of the same type as the root element of the XAML content to be loaded.

### -param resourceLocator

An object describing the Uniform Resource Identifier (URI) path to the resource to load.

## -remarks

`LoadComponent` exists mainly for infrastructure. You can see `LoadComponent` as part of the generated `InitializeComponent` logic that integrates the partial classes of a XAML page and its code-behind.

`LoadComponent` sometimes is cited in a call stack for an exception that is ultimately because your app is trying to parse bad XAML. In this case there's nothing that app code can do to change how [LoadComponent](application_loadcomponent_1179704692.md) is used, and the way to fix the problem is to check your XAML source in an XML editor and fix it. What might be helpful from the stack trace message is confirming which XAML file is not loading. In scenarios where you have merged resources or other multiple XAML sources being combined, it's not always the obvious page-level XAML that is failing to parse.

Most app scenarios that involve loading XAML content and producing an object tree should use [XamlReader.Load](../microsoft.ui.xaml.markup/xamlreader_load_1077941801.md) instead.

## -examples

## -see-also

[LoadComponent(Object, Uri, ComponentResourceLocation)](application_loadcomponent_1179704692.md)
