---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.GetDeferral
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.GetDeferral

<!--
public Windows.Foundation.Deferral GetDeferral ();
-->


## -description

Informs the system that the resource response task might continue to perform work after the [IFeedResourceProvider.OnResourceRequested](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.ifeedresourceprovider.onresourcerequested))

## -returns

A [Deferral](/uwp/api/windows.foundation.deferral) object.

## -remarks

If the evaluation or the resource for the response is not immediately available, the provider should request a deferral, initiate a background task, and complete the deferral when the resource is available.

## -see-also

## -examples


