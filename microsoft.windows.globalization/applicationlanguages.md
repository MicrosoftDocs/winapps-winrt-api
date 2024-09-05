---
-api-id: T:Microsoft.Windows.Globalization.ApplicationLanguages
-api-type: winrt class
---

# Microsoft.Windows.Globalization.ApplicationLanguages

<!--
public static class ApplicationLanguages
-->

## -description

Specifies the language-related preferences that a Windows App SDK application can use and maintain.

## -remarks

The languages referenced in this class are represented by [BCP-47](https://tools.ietf.org/html/bcp47) language tags. Each of these is a language identifier and not a locale name, although the two can be the same structurally. In the following example, the "en-US" language tag identifies American English (or the dialect of English spoken in the United States), but does not specify a location or any other conventions used in the United States (such as the measurement system or currency).

```c#
Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US";
```

>[!NOTE]
> Language tags support the Unicode extensions "ca-" and "nu-", which can affect the numeral system or calendar used by globalization objects.
>
>For more details, see [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).

## -see-also

## -examples
