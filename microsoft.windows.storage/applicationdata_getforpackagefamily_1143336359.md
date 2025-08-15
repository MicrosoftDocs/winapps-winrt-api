---
-api-id: M:Microsoft.Windows.Storage.ApplicationData.GetForPackageFamily(System.String)
-api-type: winrt method
---

# Microsoft.Windows.Storage.ApplicationData.GetForPackageFamily(System.String)

<!--
public static Microsoft.Windows.Storage.ApplicationData GetForPackageFamily (string packageFamilyName);
-->

## -description

Get an instance of [ApplicationData](applicationdata.md) for the specified package family for the current user.

## -parameters

### -param packageFamilyName

## -returns

## -remarks

Note that this method is equivalent to [Windows.Storage.ApplicationDataManager.CreateForPackageFamily()](/uwp/api/windows.management.core.applicationdatamanager.createforpackagefamily).

## -see-also

[ApplicationData](applicationdata.md)

## -examples

The following example shows how to save data to the application data store for a specific package family:

```csharp
void SaveData(string data)
{
    string packageFamilyName = "Fabrikam.Contoso_1234567890abc";
    var applicationData = ApplicationData.GetForPackageFamily(packageFamilyName);
    var filename = Path.Combine(applicationData.LocalPath, "applicationdata.dat");
    File.WriteAllText(filename, data, System.Text.UTF8Encoding);
}
```
