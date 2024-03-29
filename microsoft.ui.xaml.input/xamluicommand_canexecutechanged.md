---
-api-id: E:Microsoft.UI.Xaml.Input.XamlUICommand.CanExecuteChanged
-api-type: winrt event
---

<!-- Event syntax.
public event EventHandler CanExecuteChanged<object>
-->

# Microsoft.UI.Xaml.Input.XamlUICommand.CanExecuteChanged

## -description

Occurs whenever something happens that affects whether the command can execute.

## -remarks

Call [CanExecute](xamluicommand_canexecute_508446764.md) on the command element when this event occurs.

A command element typically disables itself if the command it is associated with cannot execute. For example, a `MenuItem` associated with the `Paste` command is disabled when the there is nothing on the clipboard to paste.

## -see-also

[NotifyCanExecuteChanged](xamluicommand_notifycanexecutechanged_1647343835.md), [StandardUICommand](standarduicommand.md), [Commanding basics](/windows/uwp/layout/commanding-basics), [Commanding in Windows apps using StandardUICommand, XamlUICommand, and ICommand](/windows/apps/design/controls/commanding)

## -examples
