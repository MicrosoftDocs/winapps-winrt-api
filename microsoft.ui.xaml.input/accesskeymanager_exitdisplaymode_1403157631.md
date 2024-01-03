---
-api-id: M:Microsoft.UI.Xaml.Input.AccessKeyManager.ExitDisplayMode
-api-type: winrt method
---

<!-- Method syntax
public void ExitDisplayMode()
-->

# Microsoft.UI.Xaml.Input.AccessKeyManager.ExitDisplayMode

## -description

Specifies that keytips for currently valid access keys should not be displayed.

## -remarks

Calling this method has no effect if the scope is not in display mode.

After calling this method, the [IsDisplayModeEnabled](accesskeymanager_isdisplaymodeenabled.md) property will be false.

Call [EnterDisplayMode(Microsoft.UI.Xaml.XamlRoot)](accesskeymanager_enterdisplaymode_473059163.md) to enable display mode.

> [!NOTE]
>
> An access key is a combination of the Alt key and one or more alphanumeric keys used to activate an associated control in an app that supports access keys (such as Word).
>
> Key tips are badges displayed next to controls that support access keys when the user presses the Alt key. Each key tip contains the alphanumeric keys that activate the associated control.
>
> The following image shows the Home tab of Word with access keys activated (note the support for both numbers and multiple keystrokes).
>
> ![Keytip badges for access keys in Microsoft Word.](images/keytip-badges-word.png)
>
> _Keytip badges for access keys in Microsoft Word_
>
> See [Access keys guidelines](/windows/apps/design/input/access-keys) for more details.

## -examples

## -see-also

[EnterDisplayMode(Microsoft.UI.Xaml.XamlRoot)](accesskeymanager_enterdisplaymode_473059163.md), [IsDisplayModeEnabled](accesskeymanager_isdisplaymodeenabled.md), [IsDisplayModeEnabledChanged](accesskeymanager_isdisplaymodeenabledchanged.md), [Access keys guidelines](/windows/apps/design/input/access-keys)
