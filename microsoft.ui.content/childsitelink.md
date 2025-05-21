---
-api-id: T:Microsoft.UI.Content.ChildSiteLink
-api-type: winrt class
---

# Microsoft.UI.Content.ChildSiteLink

<!--
public sealed class ChildSiteLink : Microsoft.UI.Content.IContentSiteAutomation, Microsoft.UI.Content.IContentSiteInput, Microsoft.UI.Content.IContentSiteLink, Microsoft.UI.IClosableNotifier, System.IDisposable
-->

## -description

Provides hosting for a [**ContentIsland**](contentisland.md) (child) in the environment of another [**ContentIsland**](contentisland.md) (parent).

## -remarks

This object controls the [**IsSiteVisible**](contentsite_issitevisible.md) property of the owned [**ContentSite**](contentsite.md). The [**IsSiteVisible**](contentsite_issitevisible.md) property is set to the value aggregated from the [**IsSiteVisible**](contentsite_issitevisible.md) and [**IsIslandVisible**](contentisland_isislandvisible.md) properties of the parent [**ContentIsland**](contentisland.md).

This object controls the [**IsSiteEnabled**](contentsite_issiteenabled.md) property of the owned [**ContentSite**](contentsite.md). The [**IsSiteEnabled**](contentsite_issiteenabled.md) property is set to the value aggregated from the [**IsSiteEnabled**](contentsite_issiteenabled.md) and [**IsIslandEnabled**](contentisland_isislandenabled.md) properties of the parent [**ContentIsland**](contentisland.md).

This object is implicitly closed when either the parent [**ContentIsland**](contentisland.md) is closed or the connected [**ContentIsland**](contentisland.md) is closed or the associated [**DispatcherQueue**](contentsite_dispatcherqueue.md) is closed.

A **ChildSiteLink** constructed with a [**ContentIsland**](contentisland.md) that uses a [**Visual**](../microsoft.ui.composition/visual.md) does not support connecting with a [**ContentIsland**](contentisland.md) that uses a [**Visual**](../microsoft.ui.composition/visual.md).

## -see-also

## -examples
