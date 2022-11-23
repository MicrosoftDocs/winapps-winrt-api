---
-api-id: M:Microsoft.Windows.Widgets.Providers.IWidgetProvider.OnWidgetContextChanged(Microsoft.Windows.Widgets.Providers.WidgetContextChangedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.IWidgetProvider.OnWidgetContextChanged(Microsoft.Windows.Widgets.Providers.WidgetContextChangedArgs)

<!--
public void OnWidgetContextChanged (Microsoft.Windows.Widgets.Providers.WidgetContextChangedArgs contextChangedArgs);
-->


## -description

Called when the configuration of the widget within the widget host changes.

## -parameters

### -param contextChangedArgs

A <xref:Microsoft.Windows.Widgets.Providers.WidgetContextChangedArgs> object providing data for the callback.

## -remarks

In the current release, this event is only raised when the user changes the size of an active widget.

Objects passed into this callback method are only guaranteed to be valid within the callback. You should not store references to these objects because their behavior outside of the context of the callback is undefined.

## -see-also

## -examples


