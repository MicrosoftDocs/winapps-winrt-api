---
-api-id: M:Microsoft.UI.Xaml.Controls.WebView2.EnsureCoreWebView2Async(Microsoft.Web.WebView2.Core.CoreWebView2Environment,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.WebView2.EnsureCoreWebView2Async(Microsoft.Web.WebView2.Core.CoreWebView2Environment,Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions)

<!--
public Windows.Foundation.IAsyncAction EnsureCoreWebView2Async (Microsoft.Web.WebView2.Core.CoreWebView2Environment environment, Microsoft.Web.WebView2.Core.CoreWebView2ControllerOptions controllerOptions);
-->

## -description

Explicitly triggers initialization of the control's CoreWebView2 with the specified environment and controller options.

## -parameters

### -param environment

A pre-created `CoreWebView2Environment` that should be used to create the `CoreWebView2`. Creating your own environment gives you control over several options that affect how the `CoreWebView2` is initialized. If you pass `null` then a default environment will be created and used automatically.

### -param controllerOptions

A pre-created `CoreWebView2ControllerOptions` that should be used to create the `CoreWebView2`. Creating your own controller options gives you control over several options that affect how the `CoreWebView2` is initialized. If you pass a `controllerOptions` to this method then it will override any settings specified on the [CreationProperties](/dotnet/api/microsoft.web.webview2.winforms.webview2.creationproperties) property. If you pass `null` (the default value) and no value has been set to `CreationProperties` then a default `controllerOptions` will be created and used automatically.

## -returns

An asynchronous action that represents the background initialization process. When it completes the [CoreWebView2](webview2_corewebview2.md) property will be available for use (i.e., non-`null`).

## -remarks

## -see-also

## -examples


