---
-api-id: M:Microsoft.UI.Content.ContentIsland.GetStateChangeDeferral
-api-type: winrt method
---

# Microsoft.UI.Content.ContentIsland.GetStateChangeDeferral

<!--
public Microsoft.UI.Content.ContentDeferral GetStateChangeDeferral ();
-->

## -description

Retrieves a <xref:Microsoft.UI.Content.ContentDeferral> object that enables asynchronous updates to individual properties without raising <xref:Microsoft.UI.Content.ContentIsland.StateChanged> events until the deferral is completed.

## -returns

A <xref:Microsoft.UI.Content.ContentDeferral> object that enables asynchronous updates to individual properties.

## -remarks

A ContentDeferral will be cancelled automatically in certain circumstances (such as when the ContentIsland is connected to a different <xref:Microsoft.UI.Content.ContentSite>).

For more information on deferrals, see [Asynchronous work and deferrals](/windows/uwp/launch-resume/app-lifecycle).

## -see-also

[ContentDeferral.Complete](contentdeferral_complete_1807836922.md)

## -examples
