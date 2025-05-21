---
-api-id: N:Microsoft.Windows.Storage.Pickers
-api-type: winrt namespace
---

# Microsoft.Windows.Storage.Pickers

## -description

The **Microsoft.Windows.Storage.Pickers** API in the Windows App SDK lets desktop applications (like WinUI) present a streamlined UI for selecting files or folders, modifying filenames and extensions, and accessing paths — all while integrating seamlessly across Windows desktops.

## -remarks

The file and folder picker APIs ([Windows.Storage.Pickers](/uwp/api/windows.storage.pickers)) in the Windows SDK don't work when apps run as adminstator (elevated mode). To address this gap, the **Microsoft.Windows.Storage.Pickers** APIs are added and support file and folder selection in elevated mode. It's designed for desktop apps and uses a **WindowId** property to link the picker to its host window.

## -see-also

[Windows.Storage.Pickers](/uwp/api/windows.storage.pickers)

## -examples
