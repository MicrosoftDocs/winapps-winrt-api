---
-api-id: M:Microsoft.Windows.Widgets.Providers.IWidgetProvider.CreateWidget(Microsoft.Windows.Widgets.Providers.WidgetContext)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.IWidgetProvider.CreateWidget(Microsoft.Windows.Widgets.Providers.WidgetContext)

<!--
public void CreateWidget (Microsoft.Windows.Widgets.Providers.WidgetContext widgetContext);
-->


## -description

Notifies the widget provider that a new widget has been created, for example, when a user adds a widget to a widget host.

## -parameters

### -param widgetContext

A <xref:Microsoft.Windows.Widgets.Providers.WidgetContext> object that identifies the widget that is being created and provides information about the configuration of the widget.

## -remarks

As soon as this method has been called you can start providing content for that widget and be prepared to handle actions raised as a result of user interaction with your widget.

Objects passed into this callback method are only guaranteed to be valid within the callback. You should not store references to these objects because their behavior outside of the context of the callback is undefined.

## -see-also

## -examples


