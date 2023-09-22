---
-api-id: P:Microsoft.UI.Content.ContentEnvironmentStateChangedEventArgs.DidDisplayIdChange
-api-type: winrt property
---

# Microsoft.UI.Content.ContentEnvironmentStateChangedEventArgs.DidDisplayIdChange

<!--
public bool DidDisplayIdChange { get; }
-->

## -description

Gets whether the "metrics authority" monitor ID changed.

## -property-value

True, if the "metrics authority" monitor ID changed; otherwise, false.

## -remarks

Although top-level windows may be displayed across multiple monitors, each top-level window gets its metrics from a single monitor (the <xref:Microsoft.UI.Content.ContentIslandEnvironment.DisplayId>), which might not have the same dots per inch (dpi) as the <xref:Microsoft.UI.Content.ContentIsland.RasterizationScale?displayProperty=nameWithType>. Although these values typically match, there are cases where they might not, such as when a user changes the monitor topology or a top level window is moved across dpi boundaries.

## -see-also

[ContentIslandEnvironment.StateChanged](contentislandenvironment_statechanged.md)

## -examples
