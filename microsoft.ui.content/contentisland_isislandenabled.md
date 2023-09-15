---
-api-id: P:Microsoft.UI.Content.ContentIsland.IsIslandEnabled
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIsland.IsIslandEnabled

<!--
public bool IsIslandEnabled { get; set; }
-->

## -description

Gets whether this <xref:Microsoft.UI.Content.ContentIsland> can receive input.

## -property-value

True, if the <xref:Microsoft.UI.Content.ContentIsland> can receive input; otherwise, false. The default is true.

## -remarks

If <xref:Microsoft.UI.Content.ContentIsland.IsSiteEnabled?displayProperty=nameWithType> is false, the <xref:Microsoft.UI.Content.ContentIsland> cannot receive input, regardless of its value.

Useful for disabling input processing while showing a modal dialog.

## -see-also

## -examples
