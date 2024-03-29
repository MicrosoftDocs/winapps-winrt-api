---
-api-id: M:Microsoft.UI.Xaml.Input.FocusManager.TryMoveFocusAsync(Microsoft.UI.Xaml.Input.FocusNavigationDirection)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<FocusMovementResult> FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection)
-->

# Microsoft.UI.Xaml.Input.FocusManager.TryMoveFocusAsync

## -description

Asynchronously attempts to change focus from the current element with focus to the next focusable element in the specified direction.

## -parameters

### -param focusNavigationDirection

The direction that focus moves from element to element within the app UI.

## -returns

The [FocusMovementResult](focusmovementresult.md) that indicates whether focus was successfully set.

## -remarks

- [FocusManager.TryMoveFocus](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.input.focusmanager.trymovefocus) methods return true (success), before the focus change is complete.
- [GetFocusedElement](focusmanager_getfocusedelement_1183614552.md) does not return the newly focused object until the asynchronous operation completes.
- The control losing focus receives its [LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) event synchronously, but does not receive [LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) until the asynchronous operation completes.
- The control getting focus receives its [GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) event synchronously, but does not receive [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) until the asynchronous operation completes.

[TryFocusAsync](focusmanager_tryfocusasync_238985746.md) completes synchronously when called on an element running in the app process.

You can also use either the [FindNextElement(FocusNavigationDirection, FindNextElementOptions)](focusmanager_findnextelement_905966547.md) method or the [FindNextElement(FocusNavigationDirection)](focusmanager_findnextelement_79258569.md) method to programmatically move focus. These methods retrieve the element (as a [DependencyObject](../microsoft.ui.xaml/dependencyobject.md)) that will receive focus based on the specified navigation direction (directional navigation only, cannot be used to emulate tab navigation).

> [!NOTE]
> We recommend using the [FindNextElement](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.input.focusmanager.findnextelement) method instead of `FindNextFocusableElement` because `FindNextFocusableElement` retrieves a `UIElement`, which returns `null` if the next focusable element is not a `UIElement` (such as a [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md) object).

## -examples

Here, we show how to set focus on a WebView object, and, if that fails, restore focus to the original element.

```csharp
async void MoveFocus(WebView webView))
{
    FocusMovementResult result;
    result = await FocusManager.TryFocusAsync(webView, FocusState.Programmatic);
    if (!result.Succeeded)
    {
        // Restore focus to original element.
        this.Focus(FocusState.Programmatic);
    }
}
```

## -see-also

[FocusManager.TryMoveFocusAsync(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)](focusmanager_trymovefocusasync_1528394373.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)
