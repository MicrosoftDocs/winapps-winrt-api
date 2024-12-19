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

The ID of the widget. This is the value provided in the [Id](widgetcontext_id.md) property of the [WidgetContext](widgetcontext.md) object passed into the provider's implementation of [IWidgetProvider.CreateWidget](iwidgetprovider_createwidget_1336245033.md).

### -param message

A string containing the message to be sent to the widget web content.

## -remarks

The message string can be simple text or the serialized form of an object interpreted by the web content. For more information, see [PostWebMessageAsString](/dotnet/api/microsoft.web.webview2.core.corewebview2.postwebmessageasstring).

## -see-also

## -examples


