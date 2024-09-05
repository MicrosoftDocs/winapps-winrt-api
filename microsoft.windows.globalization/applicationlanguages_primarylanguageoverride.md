---
-api-id: P:Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride
-api-type: winrt property
---

# Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride

<!--
public static string PrimaryLanguageOverride { get; set; }
-->

## -description

Gets or sets a single, preferred language override of the supported languages collection returned by [Languages](applicationlanguages_languages.md).

## -property-value

A single, preferred language override of the supported languages collection returned by [Languages](applicationlanguages_languages.md), expressed as a [BCP-47 language tag](https://tools.ietf.org/html/bcp47).

> [!NOTE]
> This must be a single language tag. If a delimited list of language tags or any value not representing a language tag is used, an exception is thrown.

When your app gets the value, **PrimaryLanguageOverride** returns either a single language tag (if your app has previously set the property) or an empty string.

## -remarks

For packaged apps, this property is a wrapper for the [Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride](/uwp/api/windows.globalization.applicationlanguages.primarylanguageoverride) property and behaves similarly.

This property should only be set to languages available to the app. For packaged apps, languages available to the app are limited to those languages included in the main app package manifest. The [ManifestLanguages](applicationlanguages_manifestlanguages.md) property reflects language resource packages that are available to the user, and returns an appropriate collection of languages that can be used for setting the **PrimaryLanguageOverride** value. For unpackaged apps, languages available for the app to use are limited to languages for which your app has explicitly declared support.

This setting is global for the running process.

If this is a packaged app, the setting is persisted between app sessions. Otherwise, it is not persisted between app sessions and should be set each time the app is loaded.

Set PrimaryLanguageOverride setting during app load, before any resource is loaded.

If the property has never been set, it returns an empty string.

When you set the PrimaryLanguageOverride, it will be reflected in any resources loaded after. However, for resources already loaded in the app UI, this change might not take effect immediately. To ensure the app responds to these changes, you may need to reload resources (this can vary with UI framework, and may require an app restart).

## -see-also

## -examples

The following example shows how to set the primary language override to `de-DE`, which results in the app using German (Germany) resources. Resources loaded manually with [ResourceLoader](../microsoft.applicationmodel.resources/resourceloader.md) and XAML resources fetched with x:Uid will be German (Germany).

```c#
public partial class App : Application
{
    // ...
    public App()
    {
        Microsoft.Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "de-DE";

        var resourceLoader = new Microsoft.Windows.ApplicationModel.Resources.ResourceLoader();
        var resourceString = resourceLoader.GetString("SampleString");

        this.InitializeComponent();
    }
    // ...
}
```
