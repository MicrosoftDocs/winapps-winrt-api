---
-api-id: P:Microsoft.UI.Content.ContentIsland.CustomProperties
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIsland.CustomProperties

<!--
public Windows.Foundation.Collections.IPropertySet CustomProperties { get; }
-->

## -description

Gets the set of custom properties for the [**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland).

## -property-value

The set of custom properties for the [**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland).

## -remarks

Unlike [AppData](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland.appdata), objects stored in [CustomProperties](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland.customproperties) are only released when the ContentIsland is closed. This is similar to [Windows.UI.Core.CoreWindow.CustomProperties](/uwp/api/windows.ui.core.corewindow.customproperties) (or the Win32 <xref:NF:winuser.GetPropA> and <xref:NF:winuser.SetPropA>).

## -see-also

## -examples
