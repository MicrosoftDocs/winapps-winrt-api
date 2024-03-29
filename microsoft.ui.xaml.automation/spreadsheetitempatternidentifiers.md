---
-api-id: T:Microsoft.UI.Xaml.Automation.SpreadsheetItemPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class SpreadsheetItemPatternIdentifiers : Windows.UI.Xaml.Automation.ISpreadsheetItemPatternIdentifiers
-->

# Microsoft.UI.Xaml.Automation.SpreadsheetItemPatternIdentifiers

## -description
Contains values used as automation property identifiers for properties of the [ISpreadsheetItemProvider](../microsoft.ui.xaml.automation.provider/ispreadsheetitemprovider.md) pattern.

## -remarks
Classes such as SpreadsheetItemPatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [ISpreadsheetItemProvider](../microsoft.ui.xaml.automation.provider/ispreadsheetitemprovider.md) in its [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) implementation. These identifiers are needed for the [AutomationPeer.RaisePropertyChangedEvent](../microsoft.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_482333374.md) calls that you make from control code that references your own peer, or for [Microsoft.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer.FindItemByProperty](../microsoft.ui.xaml.automation.peers/itemscontrolautomationpeer_finditembyproperty_632840925.md) in an items container peer. This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [ISpreadsheetItemProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-ispreadsheetitemprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[ISpreadsheetItemProvider](../microsoft.ui.xaml.automation.provider/ispreadsheetitemprovider.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces)
