---
-api-id: M:Microsoft.Windows.Widgets.Providers.IWidgetProvider.OnActionInvoked(Microsoft.Windows.Widgets.Providers.WidgetActionInvokedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.IWidgetProvider.OnActionInvoked(Microsoft.Windows.Widgets.Providers.WidgetActionInvokedArgs)

<!--
public void OnActionInvoked (Microsoft.Windows.Widgets.Providers.WidgetActionInvokedArgs actionInvokedArgs);
-->


## -description

Called when an action is invoked on a widget, such as the user clicking on a button.

## -parameters

### -param actionInvokedArgs

A <xref:Microsoft.Windows.Widgets.Providers.WidgetActionInvokedArgs> object providing data for the callback.

## -remarks

Objects passed into this callback method are only guaranteed to be valid within the callback. You should not store references to these objects because their behavior outside of the context of the callback is undefined.

## -see-also

## -examples


