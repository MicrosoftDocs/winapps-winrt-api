---
-api-id: T:Microsoft.UI.Xaml.Automation.StylesPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class StylesPatternIdentifiers : Windows.UI.Xaml.Automation.IStylesPatternIdentifiers
-->

# Microsoft.UI.Xaml.Automation.StylesPatternIdentifiers

## -description
Contains values used as identifiers by [IStylesProvider](../microsoft.ui.xaml.automation.provider/istylesprovider.md).

## -remarks
Classes such as StylesPatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IStylesProvider](../microsoft.ui.xaml.automation.provider/istylesprovider.md) in its [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) implementation. These identifiers are needed for the [AutomationPeer.RaisePropertyChangedEvent](../microsoft.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_482333374.md) calls that you make from control code that references your own peer, or for [Microsoft.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer.FindItemByProperty](../microsoft.ui.xaml.automation.peers/itemscontrolautomationpeer_finditembyproperty_632840925.md) in an items container peer. This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IStylesProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-istylesprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IStylesProvider](../microsoft.ui.xaml.automation.provider/istylesprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces)
