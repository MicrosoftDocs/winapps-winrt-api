---
-api-id: P:Microsoft.UI.Content.ContentIslandAutomationProviderRequestedEventArgs.Handled
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIslandAutomationProviderRequestedEventArgs.Handled

<!--
public bool Handled { get; set; }
-->

## -description

Gets or sets whether the <xref:Microsoft.UI.Content.ContentIsland.AutomationProviderRequested> event was handled.

## -property-value

True, if the event has been handled; otherwise, false. The default is false.

## -remarks

Any value returned by the <xref:Microsoft.UI.Content.ContentIslandAutomationProviderRequestedEventArgs.AutomationProvider> property (whether it's null or a valid AutomationProvider instance) is only taken into account if Handled is set to true.

By marking this event as Handled, and leaving AutomationProvider null, any previous automation provider is removed.

## -see-also

## -examples
