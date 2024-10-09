---
-api-id: P:Microsoft.UI.Content.ContentIsland.IsConnected
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIsland.IsConnected

<!--
public bool IsConnected { get; }
-->

## -description

Gets whether this <xref:Microsoft.UI.Content.ContentIsland> is connected to a <xref:Microsoft.UI.Content.ContentSite>.

## -property-value

True, if this <xref:Microsoft.UI.Content.ContentIsland> is connected to a <xref:Microsoft.UI.Content.ContentSite>; otherwise, false. The default is true.

## -remarks

A <xref:Microsoft.UI.Content.ContentIsland> must be connected to a <xref:Microsoft.UI.Content.ContentSite> to:

- Convert coordinates by calling one of the <xref:Microsoft.UI.Content.ContentCoordinateConverter> methods.
- Retrieve the automation host provider by calling <xref:Microsoft.UI.Content.ContentIsland.GetAutomationHostProvider>.

## -see-also

## -examples
