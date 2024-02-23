---
-api-id: M:Microsoft.UI.Xaml.Controls.WebView2.EnsureCoreWebView2Async(Microsoft.Web.WebView2.Core.CoreWebView2Environment)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.WebView2.EnsureCoreWebView2Async(Microsoft.Web.WebView2.Core.CoreWebView2Environment)

<!--
public Windows.Foundation.IAsyncAction EnsureCoreWebView2Async (Microsoft.Web.WebView2.Core.CoreWebView2Environment environment);
-->

## -description

Explicitly triggers initialization of the control's CoreWebView2 with the specified environment.

## -parameters

### -param environment

A pre-created `CoreWebView2Environment` that should be used to create the `CoreWebView2`. Creating your own environment gives you control over several options that affect how the `CoreWebView2` is initialized. If you pass `null` then a default environment will be created and used automatically.

## -returns

An asynchronous action that represents the background initialization process. When it completes the [CoreWebView2](webview2_corewebview2.md) property will be available for use (i.e., non-`null`).

## -remarks

## -see-also

## -examples


