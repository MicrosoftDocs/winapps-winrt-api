---
-api-id: T:Microsoft.UI.Xaml.Automation.GridItemPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class GridItemPatternIdentifiers : Windows.UI.Xaml.Automation.IGridItemPatternIdentifiers
-->

# Microsoft.UI.Xaml.Automation.GridItemPatternIdentifiers

## -description
Contains values used as identifiers by [IGridItemProvider](../microsoft.ui.xaml.automation.provider/igriditemprovider.md).

## -remarks
Classes such as GridItemPatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IGridItemProvider](../microsoft.ui.xaml.automation.provider/igriditemprovider.md) in its [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) implementation. These identifiers are needed for the [AutomationPeer.RaisePropertyChangedEvent](../microsoft.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_482333374.md) calls that you make from control code that references your own peer, or for [Provider.IItemContainerProvider.FindItemByProperty](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_632840925.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IGridItemProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-igriditemprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IGridItemProvider](../microsoft.ui.xaml.automation.provider/igriditemprovider.md), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
