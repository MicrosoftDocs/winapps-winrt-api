---
-api-id: M:Microsoft.Security.Authentication.OAuth.OAuth2Manager.RequestTokenAsync(Windows.Foundation.Uri,Microsoft.Security.Authentication.OAuth.TokenRequestParams,Microsoft.Security.Authentication.OAuth.ClientAuthentication)
-api-type: winrt method
---

# Microsoft.Security.Authentication.OAuth.OAuth2Manager.RequestTokenAsync(Windows.Foundation.Uri,Microsoft.Security.Authentication.OAuth.TokenRequestParams,Microsoft.Security.Authentication.OAuth.ClientAuthentication)

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Security.Authentication.OAuth.TokenRequestResult> RequestTokenAsync (System.Uri tokenEndpoint, Microsoft.Security.Authentication.OAuth.TokenRequestParams params, Microsoft.Security.Authentication.OAuth.ClientAuthentication clientAuth);
-->

## -description

Initiates an access token request with client authentication.

## -parameters

### -param tokenEndpoint

The token endpoint Uri for the request.

### -param params

The [TokenRequestParams](tokenrequestparams.md) containing the token request information.

### -param clientAuth

The [ClientAuthentication](clientauthentication.md) containing the client authentication information.

## -returns

An **IAsyncOperation** that returns a [TokenRequestResult](tokenrequestresult.md).

## -remarks

## -see-also

## -examples

See the [Exchange authorization code for access token](/windows/apps/develop/security/oauth2#exchange-authorization-code-for-access-token) section of **Implement OAuth functionality in Windows apps** for an example of how to use this method to request an access token.
