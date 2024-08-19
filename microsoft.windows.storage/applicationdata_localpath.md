---
-api-id: P:Microsoft.Windows.Storage.ApplicationData.LocalPath
-api-type: winrt property
---

# Microsoft.Windows.Storage.ApplicationData.LocalPath

<!--
public string LocalPath { get; }
-->

## -description

A string value that represents the path for the local data store. This location is backed up to the cloud.

## -property-value

Returns the path for the local data store.

## -remarks

This is equivalent to [Windows.Storage.ApplicationData.LocalFolder().Path](/uwp/api/windows.storage.storagefolder.path).

## -see-also

## -examples

The following example shows how to save data to the local data store:

```csharp
void SaveData(string data)
{
    var applicationData = ApplicationData.GetDefault();
    var filename = Path.Combine(applicationData.LocalPath, "applicationdata.dat");
    File.WriteAllText(filename, data, System.Text.UTF8Encoding);
}
```
