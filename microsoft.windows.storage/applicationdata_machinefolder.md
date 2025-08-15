---
-api-id: P:Microsoft.Windows.Storage.ApplicationData.MachineFolder
-api-type: winrt property
---

# Microsoft.Windows.Storage.ApplicationData.MachineFolder

<!--
public Windows.Storage.StorageFolder MachineFolder { get; }
-->

## -description

A [StorageFolder](/uwp/api/windows.storage.storagefolder) for the machine data store.

## -property-value

Returns a **StorageFolder** for the machine data store.

## -remarks

## -see-also

This location is per-machine, not per-user like the other Folder properties. A `null` value is returned if machine data store is not supported.

## -examples
