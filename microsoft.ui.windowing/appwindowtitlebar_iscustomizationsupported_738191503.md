---
-api-id: M:Microsoft.UI.Windowing.AppWindowTitleBar.IsCustomizationSupported
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindowTitleBar.IsCustomizationSupported

<!--
public static bool IsCustomizationSupported ();
-->


## -description

Gets a value that indicates whether the title bar can be customized.

## -returns

`true` if the title bar can be customized; otherwise, `false`.

## -remarks

> [!IMPORTANT]
> Title bar customization APIs are currently supported on Windows 11 only. You should check `IsCustomizationSupported` in your code before you call these APIs to ensure your app doesn't crash on other versions of Windows. See [Title bar customization](/windows/apps/develop/title-bar?tabs=wasdk) for more info.

## -see-also

[Title bar customization](/windows/apps/develop/title-bar?tabs=wasdk)

## -examples


