---
-api-id: T:Microsoft.UI.Xaml.Automation.RangeValuePatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class RangeValuePatternIdentifiers : Windows.UI.Xaml.Automation.IRangeValuePatternIdentifiers
-->

# Microsoft.UI.Xaml.Automation.RangeValuePatternIdentifiers

## -description
Contains values used as identifiers by [IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md).

## -remarks
Classes such as RangeValuePatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md) in its [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) implementation. These identifiers are needed for the [AutomationPeer.RaisePropertyChangedEvent](../microsoft.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_482333374.md) calls that you make from control code that references your own peer, or for [Provider.IItemContainerProvider.FindItemByProperty](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_632840925.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [IRangeValueProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irangevalueprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[IRangeValueProvider](../microsoft.ui.xaml.automation.provider/irangevalueprovider.md), [RangeBase](../microsoft.ui.xaml.controls.primitives/rangebase.md), [RangeBaseAutomationPeer](../microsoft.ui.xaml.automation.peers/rangebaseautomationpeer.md), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
