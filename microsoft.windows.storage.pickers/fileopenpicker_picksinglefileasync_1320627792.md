---
-api-id: M:Microsoft.Windows.Storage.Pickers.FileOpenPicker.PickSingleFileAsync
-api-type: winrt method
---

# Microsoft.Windows.Storage.Pickers.FileOpenPicker.PickSingleFileAsync

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.Windows.Storage.Pickers.PickFileResult> PickSingleFileAsync ();
-->

## -description

Displays a file open picker dialog that allows users to select and open a single file.

## -returns

Returns a [PickFileResult](pickfileresult.md) object containing the path of the selected file.

Returns null if the file dialog was cancelled or closed without selcting a file.

## -remarks

## -see-also

## -examples

The following example demonstrates how to use the **PickSingleFileAsync** method to open a file picker dialog and read the content of the selected file:

```csharp
using Microsoft.Windows.Storage.Pickers;

...

var openPicker = new FileOpenPicker(this.AppWindow.Id);

var result = await openPicker.PickSingleFileAsync();
if (result is not null)
{
    var content = System.IO.File.ReadAllText(result.Path);
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
auto& result{ co_await openPicker.PickSingleFileAsync() };
if (result)
{
    std::ifstream fileReader(result.Path().c_str());
    std::string text((std::istreambuf_iterator<char>(fileReader)), std::istreambuf_iterator<char>());
    winrt::hstring hText = winrt::to_hstring(text);
}
else
{
    // Add error handling logic here
}
```
