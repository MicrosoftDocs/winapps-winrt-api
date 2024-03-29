---
-api-id: M:Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetPatternCore(Microsoft.UI.Xaml.Automation.Peers.PatternInterface)
-api-type: winrt method
---

<!-- Method syntax
virtual protected object GetPatternCore(Windows.UI.Xaml.Automation.Peers.PatternInterface patternInterface)
-->

# Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.GetPatternCore

## -description

Provides the peer's behavior when a Microsoft UI Automation client calls [GetPattern](automationpeer_getpattern_1700082720.md) or an equivalent Microsoft UI Automation client API.

## -parameters

### -param patternInterface

A value from the [PatternInterface](patterninterface.md) enumeration.

## -returns

The object that implements the pattern interface; **null** if the peer does not support this interface.

## -remarks

The standard implementation at the [AutomationPeer](automationpeer.md) level returns **null**, because the basic peer class doesn't support any patterns. The majority of existing Windows Runtime peer classes override this method to report the patterns that a particular peer supports.

Overriding this method to return the implementation of patterns that your peer class supports is one of the most common scenarios for implementing an automation peer. See [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers).

See the [XAML accessibility sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/XAML%20accessibility%20sample) (*note that this sample is not maintained and might not compile*) for an implementation of [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) that defines the custom peer returned by [OnCreateAutomationPeer](../microsoft.ui.xaml/uielement_oncreateautomationpeer_1478162674.md) (the peer implementation can be found in Scenario 3 of the sample).

### Windows 8 behavior

Windows 8 peer-selection behavior is potentially impacted by whether the control is intended to display data as items. The automation logic for Windows 8 might select a dedicated data peer and use its patterns, even if there is a peer indicated for the overall control and that peer overrides GetPatternCore. For example, you might have the [ListViewAutomationPeer](listviewautomationpeer.md) override for patterns, but in Windows 8 the acting patterns for data items might take precedence, for example the default implementation of [ListViewItemDataAutomationPeer](listviewitemdataautomationpeer.md) might be used and will handle the scrolling pattern when UI Automation looks for patterns in items. This is different starting with Windows 8.1; if there is pattern support indicated in a GetPatternCore implementation for the overall control, that implementation is used instead of internal item data peers.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it means that your items control pattern support may be used for data items too, and you might have to add behavior for item scrolling, for instance.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also

[FrameworkElementAutomationPeer](frameworkelementautomationpeer.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Accessibility](/windows/uwp/accessibility/accessibility), [Code samples for resolving common programmatic accessibility issues in Windows desktop apps](/accessibility-tools-docs/)
