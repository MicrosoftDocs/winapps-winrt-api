---
-api-id: T:Microsoft.Windows.Storage.ApplicationDataLocality
-api-type: winrt enum
---

# Microsoft.Windows.Storage.ApplicationDataLocality

<!--
public enum ApplicationDataLocality
-->

## -description

Specifies the type of data store.

## -enum-fields

### -field Local: 0

The data resides in the local application data store.

### -field Temporary: 2

The data resides in the temporary application data store.

### -field LocalCache: 3

The data resides in the local cache for the application data store.

### -field SharedLocal: 4

The data resides in the shared local application data store.

### -field Machine: 1000

The data resides in a machine-specific application data store.

## -remarks

Note that values 0-99 match [Windows.Storage.ApplicationDataLocality](/uwp/api/windows.storage.applicationdatalocality); any values 1000+ are unique to Windows App SDK.

## -see-also

## -examples
