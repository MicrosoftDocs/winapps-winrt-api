---
-api-id: T:Microsoft.Security.Authentication.OAuth.CodeChallengeMethodKind
-api-type: winrt enum
---

# Microsoft.Security.Authentication.OAuth.CodeChallengeMethodKind

<!--
public enum CodeChallengeMethodKind
-->

## -description

An enum that specifies the `code_challenge_method` as described by section 4.3 of [RFC 7636](https://datatracker.ietf.org/doc/html/rfc7636#section-4.3) : Proof Key for Code Exchange by OAuth Public Clients.

## -enum-fields

### -field None: 0

Suppresses the use of a code verifier. An error will be thrown if a code challenge string is set when this option is used.

### -field S256: 1

Challenge method of "S256" (i.e. SHA256). This is the default unless explicitly set.

### -field Plain: 2

Challenge method of "plain" (i.e. send as plain text).

## -remarks

## -see-also

## -examples
