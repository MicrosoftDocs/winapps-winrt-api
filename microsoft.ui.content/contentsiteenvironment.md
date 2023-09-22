---
-api-id: T:Microsoft.UI.Content.ContentSiteEnvironment
-api-type: winrt class
---

# Microsoft.UI.Content.ContentSiteEnvironment

<!--
public class ContentSiteEnvironment
-->

## -description

Provides information about the <xref:Microsoft.UI.Content.ContentSite> environment to an associated <xref:Microsoft.UI.Content.ContentIsland>.

## -remarks

The <xref:Microsoft.UI.Content.ContentIslandEnvironment> is configured by the settings specified in a <xref:Microsoft.UI.Content.ContentSiteEnvironment>.

Each <xref:Microsoft.UI.Content.ContentSite> has a <xref:Microsoft.UI.Content.ContentSiteEnvironment> that manages the <xref:Microsoft.UI.Content.ContentIslandEnvironment> settings. An <xref:Microsoft.UI.Content.IContentSiteBridge> implementation is responsible for deciding when to propagate information from the <xref:Microsoft.UI.Content.ContentSiteEnvironment> to the <xref:Microsoft.UI.Content.ContentIslandEnvironment>. This enables the <xref:Microsoft.UI.Content.IContentSiteBridge> to determine policy how the environment is represented to the <xref:Microsoft.UI.Content.ContentIsland>.

## -see-also

## -examples
