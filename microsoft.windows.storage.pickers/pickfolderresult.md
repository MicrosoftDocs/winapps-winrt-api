---
-api-id: T:Microsoft.Windows.Storage.Pickers.PickFolderResult
-api-type: winrt class
---

# Microsoft.Windows.Storage.Pickers.PickFolderResult

<!--
public sealed class PickFolderResult
-->

## -description

Represents the result of a folder picking operation. This is a lightweight class that contains a string attribute representing the folder path.

## -remarks

A **PickFolderResult** object can be converted to a [Windows.Storage.StorageFolder](/uwp/api/windows.storage.storagefolder) object by calling [Windows.Storage.StorageFolder.GetFolderFromPathAsync](/uwp/api/windows.storage.storagefolder.getfolderfrompathasync) with the folder [Path](pickfolderresult_path.md).

## -see-also

[Windows.Storage.StorageFolder](/uwp/api/windows.storage.storagefolder)

## -examples

The following example demonstrates how to use the **PickFolderResult** class to get the folder path of a selected folder:

```csharp
using Microsoft.Windows.Storage.Pickers;

var picker = new FolderPicker();
var result = await picker.PickFolderAsync();
if (result != null)
{
    // Perform this conversion if you have business logic that uses StorageFolder
    var storageFolder = await Windows.Storage.StorageFolder.GetFolderFromPathAsync(result.Path)
    // Continue your business logic with storageFolder
}
else
{
    // Add error handling logic here
}
```

```cppwinrt
#include <winrt/Microsoft.Windows.Storage.Pickers.h>
using namespace winrt::Microsoft::Windows::Storage::Pickers;

FolderPicker picker;
auto& result{ co_await openPicker.PickSingleFolderAsync() };
if (result)
{
    // Perform this conversion if you have business logic that uses StorageFolder
    auto& storageFolder{ co_await winrt::Windows::Storage::StorageFolder::GetFolderFromPathAsync(result.Path) }
    // Continue your business logic with storageFolder
}
else
{
    // Add error handling logic here
}
```
