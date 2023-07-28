---
-api-id: P:Microsoft.UI.Xaml.Input.AccessKeyManager.IsDisplayModeEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsDisplayModeEnabled { get; }
-->

# Microsoft.UI.Xaml.Input.AccessKeyManager.IsDisplayModeEnabled

## -description

Gets a value that indicates whether keytips for currently valid access keys are displayed and the access keys enabled.

## -property-value

`true` if keytips are displayed and access keys enabled; otherwise, `false`.

## -remarks

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

[IsDisplayModeEnabledChanged](accesskeymanager_isdisplaymodeenabledchanged.md), [EnterDisplayMode(Microsoft.UI.Xaml.XamlRoot)](accesskeymanager_enterdisplaymode_473059163.md), [ExitDisplayMode](accesskeymanager_exitdisplaymode_1403157631.md), [Access keys guidelines](/windows/apps/design/input/access-keys)
