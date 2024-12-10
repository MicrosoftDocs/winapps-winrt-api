---
-api-id: M:Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs.GetDeferral
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs.GetDeferral

<!--
public Windows.Foundation.Deferral GetDeferral ();
-->


## -description

Informs the system that the resource response task might continue to perform work after the [IWidgetResourceProvider.OnResourceRequested](iwidgetresourceprovider_onresourcerequested_841047505.md) handler returns.

## -returns

A [Deferral](/uwp/api/windows.foundation.deferral) object.

## -remarks

If the evaluation of the resource for the response is not immediately available, the provider should request a deferral, initiate a background task, and complete the deferral when the resource is available.

## -see-also

## -examples


