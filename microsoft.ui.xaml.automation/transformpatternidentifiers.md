---
-api-id: T:Microsoft.UI.Xaml.Automation.TransformPatternIdentifiers
-api-type: winrt class
---

<!-- Class syntax.
public class TransformPatternIdentifiers : Windows.UI.Xaml.Automation.ITransformPatternIdentifiers
-->

# Microsoft.UI.Xaml.Automation.TransformPatternIdentifiers

## -description
Contains values used as identifiers by [ITransformProvider](../microsoft.ui.xaml.automation.provider/itransformprovider.md).

## -remarks
Classes such as TransformPatternIdentifiers are the identifiers for the Windows Runtime implementation of a common provider pattern for Microsoft UI Automation. You might use these identifiers if you are implementing a Windows Runtime custom automation peer that reports support for [ITransformProvider](../microsoft.ui.xaml.automation.provider/itransformprovider.md) in its [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) implementation. These identifiers are needed for the [AutomationPeer.RaisePropertyChangedEvent](../microsoft.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_482333374.md) calls that you make from control code that references your own peer, or for [Provider.IItemContainerProvider.FindItemByProperty](../microsoft.ui.xaml.automation.provider/iitemcontainerprovider_finditembyproperty_632840925.md) in an items container peer.

This same pattern is usually exposed to clients in a different way, depending on which technology they use to implement the client and examine the Microsoft UI Automation tree. [ITransformProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-itransformprovider) is also presented as a Component Object Model (COM) interface.

## -examples

## -see-also
[ITransformProvider](../microsoft.ui.xaml.automation.provider/itransformprovider.md), [Control patterns and interfaces](/windows/uwp/accessibility/control-patterns-and-interfaces), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
