---
-api-id: M:Microsoft.UI.Content.ContentIsland.FindAllForCompositor(Microsoft.UI.Composition.Compositor)
-api-type: winrt method
---

# Microsoft.UI.Content.ContentIsland.FindAllForCompositor(Microsoft.UI.Composition.Compositor)

<!--
public static Microsoft.UI.Content.ContentIsland[] FindAllForCompositor (Microsoft.UI.Composition.Compositor compositor);
-->

## -description

Returns all <xref:Microsoft.UI.Content.ContentIsland> objects associated with the specified <xref:Microsoft.UI.Composition.Compositor?displayProperty=nameWithType>.

## -parameters

### -param compositor

The compositor of interest.

## -returns

## -remarks

<xref:Microsoft.UI.Content.ContentIsland> objects that still have outstanding memory references will not be included.

If the specified compositor is not associated with the calling thread, RPC_E_WRONGTHREAD is returned.

## -see-also

## -examples
