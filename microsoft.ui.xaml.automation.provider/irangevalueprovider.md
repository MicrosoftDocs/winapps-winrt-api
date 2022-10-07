---
-api-id: T:Microsoft.UI.Xaml.Automation.Provider.IRangeValueProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IRangeValueProvider : 
-->

# Microsoft.UI.Xaml.Automation.Provider.IRangeValueProvider

## -description
Exposes methods and properties to support access by a Microsoft UI Automation client to controls that can be set to a value within a range. Implement this interface in order to support the capabilities that an automation client requests with a [AutomationPeer.GetPattern](../microsoft.ui.xaml.automation.peers/automationpeer_getpattern_1700082720.md) call and [PatternInterface.RangeValue](../microsoft.ui.xaml.automation.peers/patterninterface.md).

## -remarks
This pattern has guidelines and conventions that aren't fully documented here. For more info on what this pattern is for, see [RangeValue Control Pattern](/windows/desktop/WinAuto/uiauto-implementingrangevalue).

IRangeValueProvider is implemented by the existing Windows Runtime class [RangeBaseAutomationPeer](../microsoft.ui.xaml.automation.peers/rangebaseautomationpeer.md). This is the base class for peers for [Slider](../microsoft.ui.xaml.controls/slider.md), [ScrollBar](../microsoft.ui.xaml.controls.primitives/scrollbar.md) and [ProgressBar](../microsoft.ui.xaml.controls/progressbar.md). [ProgressBarAutomationPeer](../microsoft.ui.xaml.automation.peers/progressbarautomationpeer.md) adds an override such that it won't support the pattern if the value of [IsIndeterminate](../microsoft.ui.xaml.controls/progressbar_isindeterminate.md) on the owner control is **false**.

Use [RangeValuePatternIdentifiers](../microsoft.ui.xaml.automation/rangevaluepatternidentifiers.md) if you want to reference the IRangeValueProvider pattern properties from control code when you fire automation events or call [AutomationPeer.RaisePropertyChangedEvent](../microsoft.ui.xaml.automation.peers/automationpeer_raisepropertychangedevent_482333374.md).

## -examples

## -see-also
[RangeValuePatternIdentifiers](../microsoft.ui.xaml.automation/rangevaluepatternidentifiers.md), [IRangeValueProvider (COM interface)](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-irangevalueprovider), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [RangeValue Control Pattern](/windows/desktop/WinAuto/uiauto-implementingrangevalue)
