---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.FeedManager.SendMessageToContent(System.String,System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedManager.SendMessageToContent(System.String,System.String,System.String)

<!--
public void SendMessageToContent (string feedProviderDefinitionId, string feedDefinitionId, string message);
-->


## -description

Send a string message to the web content in a feed being displayed in the feeds host.

## -parameters

### -param feedProviderDefinitionId

The definition ID of the feed provider. This is the value specified in the *Id* attribute of the **FeedProvider** element in the provider's package manifest file. For more information see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

### -param feedDefinitionId

The definition ID of the feed. This is the value specified in the *Id* attribute of the **Definition** element in the provider's package manifest file. For more information see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

### -param message

A string containing the message to be sent to the feed web content.

## -remarks

 This message string can be simple text or the serialized form of an object interpreted by the web content. For more information, see [PostWebMessageAsString](/dotnet/api/microsoft.web.webview2.core.corewebview2.postwebmessageasstring).

## -see-also

## -examples


