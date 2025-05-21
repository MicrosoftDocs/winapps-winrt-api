---
-api-id: T:Microsoft.Security.Authentication.OAuth.TokenFailureKind
-api-type: winrt enum
---

# Microsoft.Security.Authentication.OAuth.TokenFailureKind

<!--
public enum TokenFailureKind
-->

## -description

An enum that specifies the kind of token failure that occurred.

## -enum-fields

### -field ErrorResponse: 0

The server responded with an error response as described by [RFC 6749](https://www.rfc-editor.org/rfc/rfc6749.html#section-4.1.4) section 5.2. This means that the failure object has an `Error` string and possibly other specified properties.

### -field HttpFailure: 1

The HTTP POST request failed. See the `ErrorCode` property for more details about the reason.

### -field InvalidResponse: 2

The server responded, but its response was improperly formatted. This could be that the server did not send the response as JSON, the response JSON string was improperly formatted, or the response JSON contained unexpected object types (e.g. a number when a string is expected, etc.).

## -remarks

## -see-also

## -examples
