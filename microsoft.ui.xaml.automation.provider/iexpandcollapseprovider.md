---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IExpandCollapseProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IExpandCollapseProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that visually expand to display content and that collapse to hide content. Implement this interface in order to support the capabilities that an automation client requests with a [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) call and [PatternInterface.ExpandCollapse](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [ExpandCollapse Control Pattern](/windows/desktop/WinAuto/uiauto-implementingexpandcollapse).

IExpandCollapseProvider is implemented by the existing Windows Runtime automation peer for [ComboBox](../microsoft.ui.xaml.controls/combobox.md) ([ComboBoxAutomationPeer](../microsoft.ui.xaml.automation.peers/comboboxautomationpeer.md)).

Use [ExpandCollapsePatternIdentifiers](../microsoft.ui.xaml.automation/expandcollapsepatternidentifiers.md) if you want to reference the IExpandCollapseProvider pattern properties from control code when you fire automation events or call [AutomationPeer.RaisePropertyChangedEvent](../microsoft.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_482333374.md).

## -examples

## -see-also
[ExpandCollapsePatternIdentifiers](../microsoft.ui.xaml.automation/expandcollapsepatternidentifiers.md), [IExpandCollapseProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-iexpandcollapseprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [ExpandCollapse Control Pattern](/windows/desktop/WinAuto/uiauto-implementingexpandcollapse)
