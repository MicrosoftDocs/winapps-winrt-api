---
-api-id: M:Microsoft.Windows.Storage.Pickers.FolderPicker.PickSingleFolderAsync
-api-type: winrt method
---

# Microsoft.Windows.Storage.Pickers.FolderPicker.PickSingleFolderAsync

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.Windows.Storage.Pickers.PickFolderResult> PickSingleFolderAsync ();
-->

## -description

Displays a dialog that allows the user to select a folder.

## -returns

Returns a [PickFolderResult](pickfolderresult.md) object that contains the path of the picked folder.

Returns `null` if the folder dialog was cancelled or closed without selection.

## -remarks

## -see-also

[PickFolderResult](pickfolderresult.md)

## -examples

The following example demonstrates how to use the **PickSingleFolderAsync** method to open a folder picker dialog and select a folder:

```csharp
using Microsoft.Windows.Storage.Pickers;

var folderPicker = new FolderPicker(this.AppWindow.Id);
var result = await folderPicker.PickSingleFolderAsync();
if (result is not null)
{
    var path = result.Path;
}
else
{
    // Add error handling logic here
}
```

```cppwinrt
#include <winrt/Microsoft.Windows.Storage.Pickers.h>
using namespace winrt::Microsoft::Windows::Storage::Pickers;

FolderPicker folderPicker(AppWindow().Id());
auto& result{ co_await folderPicker.PickSingleFolderAsync() };
if (result)
{
    auto path{ result.Path() };
}
else
{
    // Add error handling logic here
}
```
