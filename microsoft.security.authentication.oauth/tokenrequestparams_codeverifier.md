---
-api-id: P:Microsoft.Security.Authentication.OAuth.TokenRequestParams.CodeVerifier
-api-type: winrt property
---

# Microsoft.Security.Authentication.OAuth.TokenRequestParams.CodeVerifier

<!--
public string CodeVerifier { get; set; }
-->

## -description

Specifies the `code_verifier` parameter of the token request. This property is required when the grant type is "authorization_code" and a code challenge was included in the authorization request. This is described by the section 4.1 of [RFC 7636](https://www.rfc-editor.org/rfc/rfc7636#section-4.1).

## -property-value

A **string** that specifies the `code_verifier` parameter of the token request.

## -remarks

## -see-also

## -examples
