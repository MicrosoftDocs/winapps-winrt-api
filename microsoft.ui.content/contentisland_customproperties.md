---
-api-id: P:Microsoft.UI.Content.ContentIsland.CustomProperties
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIsland.CustomProperties

<!--
public Windows.Foundation.Collections.IPropertySet CustomProperties { get; }
-->

## -description

Gets the set of custom properties for the <xref:Microsoft.UI.Content.ContentIsland>.

## -property-value

The set of custom properties for the <xref:Microsoft.UI.Content.ContentIsland>.

## -remarks

Unlike <xref:Microsoft.UI.Content.ContentIsland.AppData>, objects stored in <xref:Microsoft.UI.Content.ContentIsland.CustomProperties> are only released when the ContentIsland is closed. This is similar to <xref:Windows.UI.Core.CoreWindow.CustomProperties?displayProperty=nameWithType> (or the Win32 <xref:NF:winuser.GetPropA> and <xref:NF:winuser.SetPropA>).

## -see-also

## -examples
