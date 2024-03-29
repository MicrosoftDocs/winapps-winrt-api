---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IVirtualizedItemProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVirtualizedItemProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IVirtualizedItemProvider

## -description
Exposes a method to support the virtualized item control pattern. Implement this interface in order to support the capabilities that an automation client requests with a [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) call and [PatternInterface.VirtualizedItem](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
Controls that contain a large number of child items can use virtualization to efficiently manage the items. With virtualization, the control maintains full information in memory for only a subset of items at any given time. Typically, the subset includes only those items that are currently visible to the user. Full information about the remaining virtualized items is kept in storage and is loaded into memory, or realized, as the control needs it, for example, as new items become visible to the user. For more info on this pattern, see [VirtualizedItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingvirtualizeditem).

IVirtualizedItemProvider is implemented by the Windows Runtime automation peer base class [ItemAutomationPeer](../microsoft.ui.xaml.automation.peers/itemautomationpeer.md).

The IVirtualizedItemProvider pattern doesn't have a pattern property identifier class, the only API to implement is a method.

## -examples

## -see-also
[IVirtualizedItemProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-ivirtualizeditemprovider), [VirtualizedItem Control Pattern](/windows/desktop/WinAuto/uiauto-implementingvirtualizeditem), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
