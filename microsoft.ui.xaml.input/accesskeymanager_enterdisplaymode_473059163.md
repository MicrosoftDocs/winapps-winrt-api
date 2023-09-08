---
-api-id: M:Microsoft.UI.Xaml.Input.AccessKeyManager.EnterDisplayMode(Microsoft.UI.Xaml.XamlRoot)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Input.AccessKeyManager.EnterDisplayMode(Microsoft.UI.Xaml.XamlRoot)

<!--
public static void EnterDisplayMode (Microsoft.UI.Xaml.XamlRoot XamlRoot);
-->

## -description

Specifies that keytips for currently valid access keys should be displayed and the access keys enabled.

## -parameters

### -param XamlRoot

The XamlRoot for the currently focused element. Cannot be **null**.

## -remarks

Calling this method has no effect if the scope is already in display mode. If another scope is in display mode, it will be exited.

After calling this method, the [IsDisplayModeEnabled](accesskeymanager_isdisplaymodeenabled.md) property will be true.

Call [ExitDisplayMode](accesskeymanager_exitdisplaymode_1403157631.md) to disable display mode.

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

## -see-also

[ExitDisplayMode](accesskeymanager_exitdisplaymode_1403157631.md), [IsDisplayModeEnabled](accesskeymanager_isdisplaymodeenabled.md), [IsDisplayModeEnabledChanged](accesskeymanager_isdisplaymodeenabledchanged.md), [UIElement.KeyTipPlacementMode](../microsoft.ui.xaml/uielement_keytipplacementmode.md), [Access keys guidelines](/windows/apps/design/input/access-keys)

## -examples
