---
-api-id: T:Microsoft.UI.System.ThemeSettings
-api-type: winrt class
---

# Microsoft.UI.System.ThemeSettings

<!--
public sealed class ThemeSettings
-->

## -description

The **ThemeSettings** API allows Win32 Windows Runtime apps to detect that the system's High Contrast setting has changed.

## -remarks

When the app releases all its references to a **ThemeSettings** object, the object will be destroyed and the [Changed](themesettings_changed.md) event will no longer fire.

## -see-also

[Changed](themesettings_changed.md)

## -examples

In this sample code, an app uses a **ThemeSettings** object to listen for high contrast changes on the system:

```cppwinrt
void MyApp::ListenForHighContrastChange(XamlRoot& xamlRoot) 
{
  const auto myWindowId = xamlRoot.ContentEnvironment().AppWindowId();
  m_themeSettings = ThemeSettings::CreateForWindowId(myWindowId);

  m_themeSettings.Changed([xamlRoot](const ThemeSettings& ts, const auto&) {
    if (ts.HighContrast())
    {
      ::OutputDebugString(L"High contrast is ON, scheme is: ");
      ::OutputDebugString(ts.HighContrastScheme().c_str());
    }
    else
    {
      ::OutputDebugString(L"High contrast is OFF.\n");
    }
  });
}
```

```csharp
void MyApp.ListenForHighContrastChange(XamlRoot xamlRoot)
{
    var myWindowId = xamlRoot.ContentEnvironment().AppWindowId();
    m_themeSettings = ThemeSettings.CreateForWindowId(myWindowId);

    m_themeSettings.Changed += (ts, _) =>
    {
        if (ts.HighContrast())
        {
            Debug.WriteLine("High contrast is ON, scheme is: ");
            Debug.WriteLine(ts.HighContrastScheme());
        }
        else
        {
            Debug.WriteLine("High contrast is OFF.");
        }
    };
}
```
