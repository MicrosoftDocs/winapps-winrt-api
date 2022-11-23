---
-api-id: E:Microsoft.Graphics.Display.DisplayInformation.AdvancedColorInfoChanged
-api-type: winrt event
---

# Microsoft.Graphics.Display.DisplayInformation.AdvancedColorInfoChanged

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.Graphics.Display.DisplayInformation,object> AdvancedColorInfoChanged;
-->

## -description

Raised when the advanced color information is changed.

## -remarks

This is an event-registration API that will register an event notification so that your app will be notified whenever there is any change in the Advanced Color info on the monitor corresponding to your window. Your app can then call the GetAdvancedColorInfo API to know the latest capabilities and state. Your app needs to track which values have changed, and respond accordingly if needed. The event API doesn't indicate which values have changed. 

> [!NOTE]
> This event removes any existing event handler that your app previously registered for changes to Advanced Color info.

## -see-also

## -examples
