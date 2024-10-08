---
-api-id: M:Microsoft.UI.Content.ContentIsland.GetByVisual(Microsoft.UI.Composition.Visual)
-api-type: winrt method
---

# Microsoft.UI.Content.ContentIsland.GetByVisual(Microsoft.UI.Composition.Visual)

<!--
public static Microsoft.UI.Content.ContentIsland GetByVisual (Microsoft.UI.Composition.Visual child);
-->

## -description

Retrieves the <xref:Microsoft.UI.Content.ContentIsland> that contains the specified child visual object on the current thread.

## -parameters

### -param child

The child visual object.

## -returns

the <xref:Microsoft.UI.Content.ContentIsland> that contains the specified child visual object, or null if the content island is not a parent of the visual object.

If the visual passed in is not associated with the current thread, RPC_E_WRONGTHREAD will be returned.

## -remarks

## -see-also

## -examples
