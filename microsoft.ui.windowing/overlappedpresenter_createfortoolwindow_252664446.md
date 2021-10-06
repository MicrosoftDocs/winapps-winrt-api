---
-api-id: M:Microsoft.UI.Windowing.OverlappedPresenter.CreateForToolWindow
-api-type: winrt method
---

# Microsoft.UI.Windowing.OverlappedPresenter.CreateForToolWindow

<!--
public static Microsoft.UI.Windowing.OverlappedPresenter CreateForToolWindow ();
-->


## -description

Creates an `OverlappedPresenter` object pre-populated with the values for a tool window.

## -returns

An `OverlappedPresenter` object pre-populated with the values for a tool window.

## -remarks

A tool window is intended to be used as a floating toolbar. It does not appear in the taskbar or in the dialog that appears when the user presses ALT+TAB.

This table shows how configuration properties are set when you create an `OverlappedPresenter` object from the `CreateForToolWindow` method.

| Configuration property | Value |
| -- | -- |
| [HasBorder](overlappedpresenter_hasborder.md) | `true` |
| [HasTitleBar](overlappedpresenter_hastitlebar.md) | `true` |
| [IsAlwaysOnTop](overlappedpresenter_isalwaysontop.md) | `false` |
| [IsMaximizable](overlappedpresenter_ismaximizable.md) | `true` |
| [IsMinimizable](overlappedpresenter_isminimizable.md) | `true` |
| [IsModal](overlappedpresenter_ismodal.md) | `false` |
| [IsResizable](overlappedpresenter_isresizable.md) | `true` |

### Ownership

If you want to set an owner for a Dialog, you have to do so at the time of creating your [AppWindow](appwindow.md).

## -see-also

## -examples


