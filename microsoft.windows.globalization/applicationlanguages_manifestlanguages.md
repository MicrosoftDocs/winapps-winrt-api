---
-api-id: P:Microsoft.Windows.Globalization.ApplicationLanguages.ManifestLanguages
-api-type: winrt property
---

# Microsoft.Windows.Globalization.ApplicationLanguages.ManifestLanguages

<!--
public static System.Collections.Generic.IReadOnlyList<string> ManifestLanguages { get; }
-->

## -description

Gets the collection of supported languages declared in the app manifest.

## -property-value

The collection of supported languages declared in the app manifest.

> [!IMPORTANT]
> For unpackaged applications, this is an empty list.

## -remarks

When language resource packages are used, the packages that are installed and registered for a given user are determined by the languages in the user's language profile.

The collection of languages returned by this property is limited to the languages available on the system for the user. Languages included in the main app package manifest will always be returned; languages from resource packages will be returned only if the language is applicable for the user (in the user's preferences) and the resource package has been installed and registered for the user at the time the property is accessed.

## -see-also

## -examples
