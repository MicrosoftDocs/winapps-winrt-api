---
-api-id: M:Microsoft.Windows.Storage.Pickers.FileSavePicker.PickSaveFileAsync
-api-type: winrt method
---

# Microsoft.Windows.Storage.Pickers.FileSavePicker.PickSaveFileAsync

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.Windows.Storage.Pickers.PickFileResult> PickSaveFileAsync ();
-->

## -description

Displays a dialog that allows the user to configure the file path to save.

## -returns

Returns a [PickFileResult](pickfileresult.md) object that contains the path of the saved file.

Returns `null` if the file dialog was cancelled or closed without selecting a saved file.

## -remarks

## -see-also

[PickFileResult](pickfileresult.md)

## -examples

The following example demonstrates how to use the **PickSaveFileAsync** method to open a file picker dialog and save a file:

```csharp
using Microsoft.Windows.Storage.Pickers;

var savePicker = new FileSavePicker(this.AppWindow.Id);
var result = await savePicker.PickSaveFileAsync();

if (result is not null)
{
    System.IO.File.WriteAllText(result.Path, "Hello world.");
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

FileSavePicker savePicker(AppWindow().Id());
auto& result{ co_await savePicker.PickSaveFileAsync() };
if (result)
{
    std::ofstream outFile(result.Path().c_str());
    outFile << "Hello world.";
    outFile.close();
}
else
{
    // Add error handling logic here
}
```
