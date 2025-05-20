---
-api-id: T:Microsoft.Windows.Storage.Pickers.PickFileResult
-api-type: winrt class
---

# Microsoft.Windows.Storage.Pickers.PickFileResult

<!--
public sealed class PickFileResult
-->

## -description

Represents the result of a file picking operation. This is a lightweight class that contains a **string** attribute representing the file path.

## -remarks

A **PickFileResult** object can be converted to [Windows.Storage.StorageFile](/uwp/api/windows.storage.storagefile) object via [GetFileFromPathAsync](/uwp/api/windows.storage.storagefile.getfilefrompathasync) using the file [Path](pickfileresult_path.md).

## -see-also

## -examples

The following example demonstrates how to use the **PickFileResult** class to get the file path of a selected file:

```csharp
using Microsoft.Windows.Storage.Pickers;

var picker = new FileOpenPicker();
var result = await picker.PickSingleFileAsync();
if (result != null)
{
    // Perform this conversion if you have business logic that uses StorageFile
    var storageFile = await Windows.Storage.StorageFile.GetFileFromPathAsync(result.Path)
    // Continue your business logic with storageFile
}
else
{
    // Add error handling logic here
}
```

```cppwinrt
#include <winrt/Microsoft.Windows.Storage.Pickers.h>
using namespace winrt::Microsoft::Windows::Storage::Pickers;

FileOpenPicker picker;
auto& result{ co_await openPicker.PickSingleFileAsync() };
if (result)
{
    // Perform this conversion if you have business logic that uses StorageFile
    auto& storageFile{ co_await winrt::Windows::Storage::StorageFile::GetFileFromPathAsync(result.Path) }
    // Continue your business logic with storageFile
}
else
{
    // Add error handling logic here
}
```
