---
-api-id: M:Microsoft.Windows.Storage.ApplicationData.GetDefault
-api-type: winrt method
---

# Microsoft.Windows.Storage.ApplicationData.GetDefault

<!--
public static Microsoft.Windows.Storage.ApplicationData GetDefault ();
-->

## -description

Gets an instance of [ApplicationData](applicationdata.md) for the current user.

## -returns

## -remarks

>[!NOTE}
>Using this method requires the current process has package identity.

Note that this method is equivalent to [Windows.Storage.ApplicationData.Current](/uwp/api/windows.storage.applicationdata.current) if running in an AppContainer. When not running in an AppContainer, this method is equivalent to [Windows.Management.Core.ApplicationDataManager.CreateForPackageFamily(GetCurrentPackageFamilyName())](/uwp/api/windows.management.core.applicationdatamanager.createforpackagefamily).

## -see-also

[ApplicationData](applicationdata.md)

## -examples
