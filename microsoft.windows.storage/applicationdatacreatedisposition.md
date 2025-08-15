---
-api-id: T:Microsoft.Windows.Storage.ApplicationDataCreateDisposition
-api-type: winrt enum
---

# Microsoft.Windows.Storage.ApplicationDataCreateDisposition

<!--
public enum ApplicationDataCreateDisposition
-->

## -description

Specifies options for creating application data containers or returning existing containers.

## -enum-fields

### -field Always: 0

Always returns the specified container. Creates the container if it doesn't exist.

### -field Existing: 1

Returns the specified container only if it already exists. Raises an exception of type **System.Exception** if the specified container doesn't exist.

## -remarks

## -see-also

## -examples
