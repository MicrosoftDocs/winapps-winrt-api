---
-api-id: P:Microsoft.UI.Xaml.Application.RequestedTheme
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ApplicationTheme RequestedTheme { get;  set; }
-->

# Microsoft.UI.Xaml.Application.RequestedTheme

## -description

Gets or sets a value that determines the light-dark preference for the overall theme of an app.

## -xaml-syntax

```xaml
<Application RequestedTheme="applicationThemeMemberName" .../>
```

## -property-value

A value of the enumeration. The initial value is the default theme set by the user in Windows settings.

## -remarks

There are two built in themes: "Light" and "Dark". By default your app runs using the theme set by the user in Windows settings (Settings > Personalization > Colors > Choose your default app mode). You can set the app's `RequestedTheme` property to override the user default and specify which theme is used. If you provide a UI to let the user select light or dark theme for the app, you should also provide an option to switch back to using the default, that is, the option that is selected in Windows Personalization settings.

The theme can only be set when the app is started, not while it's running. Attempting to set `RequestedTheme` while the app is running throws an exception (`NotSupportedException` for Microsoft .NET code). If you give the user an option to pick a theme that's part of app UI, you must save the setting in the app data and apply it when the app is restarted. (For more info about app settings, see [Store and retrieve settings and other app data](/windows/apps/design/app-settings/store-and-retrieve-app-data)).

You can change specific theme values at run-time after `Application.RequestedTheme` is applied, if you use the [FrameworkElement.RequestedTheme](frameworkelement_requestedtheme.md) property and set values on specific elements in the UI.

There is also a "HighContrast" theme that uses system values, but apps and app code use a different technique for switching the app to high contrast. The `RequestedTheme` property is ignored if the user is running in high contrast mode. See [Contrast themes](/windows/apps/design/accessibility/high-contrast-themes) and [XAML high contrast sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20high%20contrast%20style%20sample).

Although the app can't switch the themes at run-time, the user can. For example, a user might enable a high-contrast theme while your app is running, by using the Alt+Shift+PrtScn key shortcut. If this happens, the XAML resource system will recalculate the resource values for any [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) usage. Theme-appropriate resources such as colors and brushes then use values appropriate for the current theme, even though it wasn't the app that requested that theme originally.

The resources that are theme-specific are typically defined in a separate resource dictionary in XAML. This resource dictionary comes from the [ThemeDictionaries](resourcedictionary_themedictionaries.md) property of the primary [ResourceDictionary](resourcedictionary.md) that is used for control templates.

## -examples

This example shows how to save the requested theme in local app settings, and then retrieve and apply it when the app is restarted.

> [!CAUTION]
> This simplified example depends on the order of the radio button options matching the `ApplicationTheme` enumeration values: 0 = Light, 1 = Dark. If you want to put them in a different order, or use a UI other than radio buttons, you will need modify the code accordingly.

```xaml
<RadioButtons Header="App theme"
              SelectionChanged="AppTheme_SelectionChanged"
              Loaded="RadioButtons_Loaded">
    <x:String>Light</x:String>
    <x:String>Dark</x:String>
    <x:String>Use system setting</x:String>
</RadioButtons>
```

```csharp
private void AppTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    if (sender is RadioButtons rb)
    {
        // Save theme choice to LocalSettings. 
        // ApplicationTheme enum values: 0 = Light, 1 = Dark
        ApplicationData.Current.LocalSettings.Values["themeSetting"] = rb.SelectedIndex;
    }
}

private void RadioButtons_Loaded(object sender, RoutedEventArgs e)
{
    if (sender is RadioButtons rb)
    {
        // Set the RadioButtons selection to the saved value.
        rb.SelectedIndex = (int)ApplicationData.Current.LocalSettings.Values["themeSetting"];
    }
}
```

**App.xaml.cs**

```csharp
public App()
{
    this.InitializeComponent();

    // Get theme choice from LocalSettings.
    object value = ApplicationData.Current.LocalSettings.Values["themeSetting"];

    if (value != null)
    {
        // Apply theme choice if saved value is Light or Dark.
        // Otherwise, don't set it and the Windows Personalization setting is used. 
        if ((int)value == 0 || (int)value == 1)
        {
            App.Current.RequestedTheme = (ApplicationTheme)(int)value;
        }
    }
}
```

## -see-also

[FrameworkElement.RequestedTheme](frameworkelement_requestedtheme.md), [XAML requested theme sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20requested%20theme%20sample), [Contrast themes](/windows/apps/design/accessibility/high-contrast-themes)
