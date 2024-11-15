---
-api-id: M:Microsoft.Windows.Widgets.Providers.WidgetManager.SendMessageToContent(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.WidgetManager.SendMessageToContent(System.String,System.String)

<!--
public void SendMessageToContent (string widgetId, string message);
-->


## -description

Send a string message to the web content in a widget being displayed in the widgets host.

## -parameters

### -param widgetId

The ID of the widget. This is the value specified in the *Id* attribute of the **Definition** element in the provider's package manifest file. For more information see [Widget provider package manifest XML format](/windows/apps/develop/widgets/widget-provider-manifest).

### -param message

A string containing the message to be sent to the widget web content.

## -remarks

The message string can be simple text or the serialized form of an object interpreted by the web content. For more information, see [PostWebMessageAsString](/dotnet/api/microsoft.web.webview2.core.corewebview2.postwebmessageasstring).

## -see-also

## -examples


