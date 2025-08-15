---
-api-id: P:Microsoft.UI.Content.ContentSiteEnvironmentView.DisplayId
-api-type: winrt property
---

# Microsoft.UI.Content.ContentSiteEnvironmentView.DisplayId

<!--
public Microsoft.UI.DisplayId DisplayId { get; }
-->

## -description

Gets the "metrics authority" monitor ID.

## -property-value

## -remarks

Although top-level windows may be displayed across multiple monitors, each top-level window gets its metrics from a single monitor (the [DisplayId](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment.displayid)), which might not have the same dots per inch (dpi) as the [Microsoft.UI.Content.ContentIsland.RasterizationScale](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland.rasterizationscale). Although these values typically match, there are cases where they might not, such as when a user changes the monitor topology or a top level window is moved across dpi boundaries.

## -see-also

## -examples
