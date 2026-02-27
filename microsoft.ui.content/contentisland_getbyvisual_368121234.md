---
-api-id: M:Microsoft.UI.Content.ContentIsland.GetByVisual(Microsoft.UI.Composition.Visual)
-api-type: winrt method
---

# Microsoft.UI.Content.ContentIsland.GetByVisual(Microsoft.UI.Composition.Visual)

<!--
public static Microsoft.UI.Content.ContentIsland GetByVisual (Microsoft.UI.Composition.Visual child);
-->

## -description

Retrieves the [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) that contains the specified child [Visual](../microsoft.ui.composition/visual.md) object on the current thread.

## -parameters

### -param child

The child visual object.

## -returns

the [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) that contains the specified child [Visual](../microsoft.ui.composition/visual.md) object, or null if the content island is not a parent of the visual object.

If the [Visual](../microsoft.ui.composition/visual.md) passed in is not associated with the current thread, RPC_E_WRONGTHREAD will be returned.

## -remarks

## -see-also

## -examples
