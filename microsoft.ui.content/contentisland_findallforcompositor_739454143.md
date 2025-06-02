---
-api-id: M:Microsoft.UI.Content.ContentIsland.FindAllForCompositor(Microsoft.UI.Composition.Compositor)
-api-type: winrt method
---

# Microsoft.UI.Content.ContentIsland.FindAllForCompositor(Microsoft.UI.Composition.Compositor)

<!--
public static Microsoft.UI.Content.ContentIsland[] FindAllForCompositor (Microsoft.UI.Composition.Compositor compositor);
-->

## -description

Retrieves all [**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) objects associated with the specified [Microsoft.UI.Composition.Compositor](/windows/windows-app-sdk/api/winrt/microsoft.ui.composition.compositor).

## -parameters

### -param compositor

The compositor of interest.

## -returns

## -remarks

[**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) objects that still have outstanding memory references will not be included.

If the specified compositor is not associated with the calling thread, RPC_E_WRONGTHREAD is returned.

## -see-also

## -examples
