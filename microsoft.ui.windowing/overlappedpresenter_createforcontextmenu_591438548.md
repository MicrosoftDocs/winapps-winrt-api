---
-api-id: M:Microsoft.UI.Windowing.OverlappedPresenter.CreateForContextMenu
-api-type: winrt method
---

# Microsoft.UI.Windowing.OverlappedPresenter.CreateForContextMenu

<!--
public static Microsoft.UI.Windowing.OverlappedPresenter CreateForContextMenu ();
-->


## -description

Creates an `OverlappedPresenter` object pre-populated with the values for a context menu.

## -returns

An `OverlappedPresenter` object pre-populated with the values for a context menu.

## -remarks

This table shows how configuration properties are set when you create an `OverlappedPresenter` object from the `CreateForContextMenu` method.

| Configuration property | Value |
| -- | -- |
| [HasBorder](overlappedpresenter_hasborder.md) | `true` |
| [HasTitleBar](overlappedpresenter_hastitlebar.md) | `false` |
| [IsAlwaysOnTop](overlappedpresenter_isalwaysontop.md) | `false` |
| [IsMaximizable](overlappedpresenter_ismaximizable.md) | `false` |
| [IsMinimizable](overlappedpresenter_isminimizable.md) | `false` |
| [IsModal](overlappedpresenter_ismodal.md) | `false` |
| [IsResizable](overlappedpresenter_isresizable.md) | `false` |

### Ownership

If you want to set an owner for a ContextMenu, you have to do so at the time of creating your [AppWindow](appwindow.md).

## -see-also

## -examples


