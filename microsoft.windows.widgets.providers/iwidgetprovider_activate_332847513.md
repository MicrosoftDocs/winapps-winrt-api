---
-api-id: M:Microsoft.Windows.Widgets.Providers.IWidgetProvider.Activate(Microsoft.Windows.Widgets.Providers.WidgetContext)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.IWidgetProvider.Activate(Microsoft.Windows.Widgets.Providers.WidgetContext)

<!--
public void Activate (Microsoft.Windows.Widgets.Providers.WidgetContext widgetContext);
-->


## -description

Notifies the widget provider that the widget host is currently interested in receiving updated content from the provider.

## -parameters

### -param widgetContext

A <xref:Microsoft.Windows.Widgets.Providers.WidgetContext> object that identifies the widget that is being activated and provides context information.

## -remarks

The <xref:Microsoft.Windows.Widgets.Providers.IWidgetProvider.Deactivate(System.String)> method is called to notify the widget provider that the widget host is no longer requesting content updates. These two methods define a window in which the widget host is most interested in showing the most up-to-date content. Widget providers can send updates to the widget at any time, such as in response to a push notification, but as with any background task, it's important to balance providing up-to-date content with resource concerns like battery life. 

Note that when a widget is first created, as indicated by a call to <xref:Microsoft.Windows.Widgets.Providers.IWidgetProvider.CreateWidget(Microsoft.Windows.Widgets.Providers.WidgetContext>, it is in the active state.

Objects passed into this callback method are only guaranteed to be valid within the callback. You should not store references to these objects because their behavior outside of the context of the callback is undefined.

## -see-also

## -examples


