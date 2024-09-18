---
-api-id: P:Microsoft.UI.Content.ContentIsland.IsIslandEnabled
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIsland.IsIslandEnabled

<!--
public bool IsIslandEnabled { get; set; }
-->

## -description

Gets or sets whether this [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) can receive input.

## -property-value

True, if the [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) can receive input; otherwise, false. The default is true.

## -remarks

If [Microsoft.UI.Content.ContentIsland.IsSiteEnabled](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland.issiteenabled) is false, the [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) cannot receive input, regardless of its value.

Useful for disabling input processing while showing a modal dialog.

## -see-also

## -examples
