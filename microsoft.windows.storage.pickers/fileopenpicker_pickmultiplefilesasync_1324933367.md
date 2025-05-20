---
-api-id: M:Microsoft.Windows.Storage.Pickers.FileOpenPicker.PickMultipleFilesAsync
-api-type: winrt method
---

# Microsoft.Windows.Storage.Pickers.FileOpenPicker.PickMultipleFilesAsync

<!--
public Windows.Foundation.IAsyncOperation<System.Collections.Generic.IReadOnlyList<Microsoft.Windows.Storage.Pickers.PickFileResult>> PickMultipleFilesAsync ();
-->

## -description

Displays a dialog that allows users to select and open multiple files.

## -returns

Returns a collection of [PickFileResult](pickfileresult.md) objects that has the path of the selected files.

Returns an empty list (**IReadOnlyList.Count** = 0) if the dialog is cancelled or closed without selection.

## -remarks

## -see-also

## -examples

The following example demonstrates how to use the **PickMultipleFilesAsync** method to open a file picker dialog and read the content of the selected files:

```csharp
using Microsoft.Windows.Storage.Pickers;

var openPicker = new FileOpenPicker(this.AppWindow.Id);
var results = await openPicker.PickMultipleFilesAsync();

if (results.Count > 0)
{
    var pickedFilePaths = results.Select(f => f.Path);
    foreach (var path in pickedFilePaths)
    {
        var content = System.IO.File.ReadAllText(path);
    }
}
else
{
    // Add error handling logic here
}
```

```cppwinrt
#include <winrt/Microsoft.Windows.Storage.Pickers.h>
#include <fstream>
#include <string>
using namespace winrt::Microsoft::Windows::Storage::Pickers;

FileOpenPicker openPicker(AppWindow().Id());
auto& results{ co_await openPicker.PickMultipleFilesAsync() };

if (results.Size() > 0)
{
    for (auto const& result : results)
    {
        std::ifstream fileReader(result.Path().c_str());
        std::string text((std::istreambuf_iterator<char>(fileReader)), std::istreambuf_iterator<char>());
        winrt::hstring hText = winrt::to_hstring(text);
    }
}
else
{
    // Add error handling logic here
}
```
