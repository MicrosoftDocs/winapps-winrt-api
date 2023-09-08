---
-api-id: T:Microsoft.Windows.Security.AccessControl.AppContainerNameAndAccess
-api-type: winrt struct
---

# Microsoft.Windows.Security.AccessControl.AppContainerNameAndAccess

<!--
public struct AppContainerNameAndAccess
-->

## -description

A struct that holds a Package Family Name (PFN) and access mask.

## -struct-fields

### -field accessMask

The access control rights to be applied to the app container.

### -field appContainerName

Specifies the Package Family Name (PFN).

## -remarks

The *accessMask* supports a bitwise combination of its member values.

## -see-also

[EventWaitHandleRights](/dotnet/api/system.security.accesscontrol.eventwaithandlerights), [GetSecurityDescriptorBytesFromAppContainerNames](securitydescriptorhelpers_getsecuritydescriptorbytesfromappcontainernames_1884241070.md), [GetSddlForAppContainerNames](securitydescriptorhelpers_getsddlforappcontainernames_1922682616.md)

## -examples

```csharp
var access = new AppContainerNameAndAccess[]
{
    new AppContainerNameAndAccess("Contoso.Test.App_12345678",
        (uint)(EventWaitHandleRights.Modify |
                EventWaitHandleRights.Synchronize));
};
```
