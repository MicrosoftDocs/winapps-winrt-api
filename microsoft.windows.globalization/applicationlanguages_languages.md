---
-api-id: P:Microsoft.Windows.Globalization.ApplicationLanguages.Languages
-api-type: winrt property
---

# Microsoft.Windows.Globalization.ApplicationLanguages.Languages

<!--
public static System.Collections.Generic.IReadOnlyList<string> Languages { get; }
-->

## -description

Gets a ranked list of supported languages.

## -property-value

The intersection of supported languages declared by the app (see [ManifestLanguages](applicationlanguages_manifestlanguages.md)) and the list of languages for which the user has declared a preference (the user profile language list). If this intersection is empty, the app's default language is used.

For more detail, see [Understand user profile languages and app manifest languages](/windows/apps/design/globalizing/manage-language-and-region).

## -remarks

## -see-also

## -examples
