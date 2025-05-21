---
-api-id: M:Microsoft.Security.Authentication.OAuth.OAuth2Manager.RequestAuthWithParamsAsync(Microsoft.UI.WindowId,Windows.Foundation.Uri,Microsoft.Security.Authentication.OAuth.AuthRequestParams)
-api-type: winrt method
---

# Microsoft.Security.Authentication.OAuth.OAuth2Manager.RequestAuthWithParamsAsync(Microsoft.UI.WindowId,Windows.Foundation.Uri,Microsoft.Security.Authentication.OAuth.AuthRequestParams)

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Security.Authentication.OAuth.AuthRequestResult> RequestAuthWithParamsAsync (Microsoft.UI.WindowId parentWindowId, System.Uri authEndpoint, Microsoft.Security.Authentication.OAuth.AuthRequestParams params);
-->

## -description

Initiates an auth request for a user in the user's default browser through a client app.

## -parameters

### -param parentWindowId

The parent window for the auth request.

### -param authEndpoint

The auth endpoint for the request.

### -param params

The [AuthRequestParams](authrequestparams.md) containing the auth information for the request.

## -returns

An **IAsyncOperation** that returns an [AuthRequestResult](authrequestresult.md).

## -remarks

## -see-also

## -examples

See the [Authorization code request](/windows/apps/develop/security/oauth2#authorization-code-request) section of **Implement OAuth functionality in Windows apps** for an example of how to use this method to initiate an authorization code request.
