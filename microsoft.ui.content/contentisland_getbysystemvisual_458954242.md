---
-api-id: M:Microsoft.UI.Content.ContentIsland.GetBySystemVisual(Windows.UI.Composition.Visual)
-api-type: winrt method
---

# Microsoft.UI.Content.ContentIsland.GetBySystemVisual(Windows.UI.Composition.Visual)

<!--
public static Microsoft.UI.Content.ContentIsland GetBySystemVisual (Windows.UI.Composition.Visual child);
-->

## -description

Retrieves a [**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) object where the specified [**Visual**](../microsoft.ui.composition/visual.md) is the root [**Visual**](../microsoft.ui.composition/visual.md) or a descendant of the root [**Visual**](../microsoft.ui.composition/visual.md).

## -parameters

### -param child

The root [**Visual**](../microsoft.ui.composition/visual.md) or a descendant of the root [**Visual**](../microsoft.ui.composition/visual.md).

## -returns

the [**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) where the specified [**Visual**](../microsoft.ui.composition/visual.md) is the root [**Visual**](../microsoft.ui.composition/visual.md) or a descendant of the root [**Visual**](../microsoft.ui.composition/visual.md), or null if the content island is neither.

If the [**Visual**](../microsoft.ui.composition/visual.md) passed in is not associated with the current thread, RPC_E_WRONGTHREAD will be returned.

## -remarks

## -see-also

## -examples
