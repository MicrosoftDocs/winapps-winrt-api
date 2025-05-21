---
-api-id: M:Microsoft.Security.Authentication.OAuth.AuthRequestParams.CreateForAuthorizationCodeRequest(System.String,Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Security.Authentication.OAuth.AuthRequestParams.CreateForAuthorizationCodeRequest(System.String,Windows.Foundation.Uri)

<!--
public static Microsoft.Security.Authentication.OAuth.AuthRequestParams CreateForAuthorizationCodeRequest (string clientId, System.Uri redirectUri);
-->

## -description

Helper method to create an authorization code grant request (`code` response type) with the required parameters.

## -parameters

### -param clientId

The client ID for the request.

### -param redirectUri

The redirect URI for the request.

## -returns

The created [AuthRequestParams](authrequestparams.md) object.

## -remarks

## -see-also

## -examples

See the [Authorization code request](/windows/apps/develop/security/oauth2#authorization-code-request) section of **Implement OAuth functionality in Windows apps** for an example of how to use this method to create an authorization code request.
