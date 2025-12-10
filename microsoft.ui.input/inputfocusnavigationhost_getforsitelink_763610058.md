---
-api-id: M:Microsoft.UI.Input.InputFocusNavigationHost.GetForSiteLink(Microsoft.UI.Content.IContentSiteLink)
-api-type: winrt method
---

# Microsoft.UI.Input.InputFocusNavigationHost.GetForSiteLink(Microsoft.UI.Content.IContentSiteLink)

<!--
public static Microsoft.UI.Input.InputFocusNavigationHost GetForSiteLink (Microsoft.UI.Content.IContentSiteLink contentSiteLink);
-->

## -description

Retrieves an [InputFocusNavigationHost](inputfocusnavigationhost.md) object associated with a given [IContentSiteLink](../microsoft.ui.content/icontentsitebridge.md).

## -parameters

### -param contentSiteLink

An object representing the link to a [ContentSite](../microsoft.ui.content/contentsite.md) (typically a [ContentIsland](../microsoft.ui.content/contentisland.md)).

## -returns

The [InputFocusNavigationHost](inputfocusnavigationhost.md) associated with the specified [IContentSiteLink](../microsoft.ui.content/icontentsitebridge.md).

## -remarks

This enables focus navigation within a [ContentIsland](../microsoft.ui.content/contentisland.md), which is a compositional unit in the WinUI framework used to host content in Win32 environments.

## -see-also

## -examples


