---
-api-id: T:Microsoft.UI.Content.ContentDeferral
-api-type: winrt class
---

# Microsoft.UI.Content.ContentDeferral

<!--
public sealed class ContentDeferral
-->

## -description

Provides support for deferrals of state changes in a [ContentIsland](contentisland.md).

## -remarks

A ContentDeferral will be cancelled automatically in certain circumstances (such as when the ContentIsland is connected to a different [ContentSite](contentsite.md)).

> [!NOTE]
> This object has thread affinity and needs to be completed on the UI thread of the owner (unlike [Deferral](/uwp/api/windows.foundation.deferral)).

For more information on deferrals, see [Asynchronous work and deferrals](/windows/uwp/launch-resume/app-lifecycle).

## -see-also

[ContentIsland.GetStateChangeDeferral](contentisland_getstatechangedeferral_1844274107.md), [ContentSite.GetIslandStateChangeDeferral](contentsite_getislandstatechangedeferral_1427932365.md)

## -examples
