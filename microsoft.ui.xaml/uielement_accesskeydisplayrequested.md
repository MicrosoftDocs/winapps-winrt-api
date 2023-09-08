---
-api-id: E:Microsoft.UI.Xaml.UIElement.AccessKeyDisplayRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccessKeyDisplayRequested<Microsoft.UI.Xaml.UIElement,  Microsoft.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs>
-->

# Microsoft.UI.Xaml.UIElement.AccessKeyDisplayRequested

## -description

Occurs when the user requests that access keys be displayed.

## -xaml-syntax

```xaml
<uiElement AccessKeyDisplayRequested="eventhandler"/>
```

## -remarks

This event notifies an element to show access key visuals.

This event is not raised if the element is under an element with its [Visibility](uielement_visibility.md) property set to `Collapsed`.

## -examples

## -see-also

[AccessKeyDisplayDismissedEventArgs](../microsoft.ui.xaml.input/accesskeydisplayrequestedeventargs.md), [Access keys guidelines](/windows/apps/design/input/access-keys)
