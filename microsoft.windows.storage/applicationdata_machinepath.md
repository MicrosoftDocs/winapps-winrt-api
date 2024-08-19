---
-api-id: P:Microsoft.Windows.Storage.ApplicationData.MachinePath
-api-type: winrt property
---

# Microsoft.Windows.Storage.ApplicationData.MachinePath

<!--
public string MachinePath { get; }
-->

## -description

A value that represents the path for the machine data store.

## -property-value

Returns the path for the machine data store.

## -remarks

This location is per-machine, not per-user like the other Path properties. An empty string is returned if machine data store is not supported.

## -see-also

## -examples

The following example shows how to save data to the machine data store:

```csharp
void SaveData(string data)
{
    var applicationData = ApplicationData.GetDefault();
    var filename = Path.Combine(applicationData.MachinePath, "applicationdata.dat");
    File.WriteAllText(filename, data, System.Text.UTF8Encoding);
}
```
