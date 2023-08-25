---
-api-id: M:Microsoft.Windows.Security.AccessControl.SecurityDescriptorHelpers.GetSecurityDescriptorBytesFromAppContainerNames(Microsoft.Windows.Security.AccessControl.AppContainerNameAndAccess[],System.String,System.UInt32)
-api-type: winrt method
---

# Microsoft.Windows.Security.AccessControl.SecurityDescriptorHelpers.GetSecurityDescriptorBytesFromAppContainerNames(Microsoft.Windows.Security.AccessControl.AppContainerNameAndAccess[],System.String,System.UInt32)

<!--
public static byte[] GetSecurityDescriptorBytesFromAppContainerNames (Microsoft.Windows.Security.AccessControl.AppContainerNameAndAccess[] accessRequests, string principalStringSid, uint principalAccessMask);
-->

## -description

Gets the security descriptor for the specified Package Family Names (PFNs).

## -parameters

### -param accessRequests

An array of [AppContainerNameAndAccess](appcontainernameandaccess.md) structs that specify the PFNs and access rights.

### -param principalStringSid

The security identifier (SID) of the principal. This parameter is optional and can be `null`.

### -param principalAccessMask

The access rights for the principal.

## -returns

Returns the security descriptor as a byte array.

## -remarks

If the *principalStringSid* parameter is `null`, the principal of the current thread is used.

## -see-also

[AppContainerNameAndAccess](appcontainernameandaccess.md), [ConvertSidToStringSidW](/windows/win32/api/sddl/nf-sddl-convertsidtostringsidw), [EventWaitHandleRights](/dotnet/api/system.security.accesscontrol.eventwaithandlerights)

## -examples
