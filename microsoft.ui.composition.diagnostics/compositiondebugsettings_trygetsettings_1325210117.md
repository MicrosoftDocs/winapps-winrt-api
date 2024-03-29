---
-api-id: M:Microsoft.UI.Composition.Diagnostics.CompositionDebugSettings.TryGetSettings(Microsoft.UI.Composition.Compositor)
-api-type: winrt method
---

<!-- Method syntax.
public CompositionDebugSettings CompositionDebugSettings.TryGetSettings(Compositor compositor)
-->

# Microsoft.UI.Composition.Diagnostics.CompositionDebugSettings.TryGetSettings

## -description

Attempts to get an instance of CompositionDebugSettings for the specified compositor.

## -parameters
### -param compositor

The compositor to get debug settings for.

## -returns

An instance of composition debug settings.

## -remarks

A call to TryGetSettings will fail with an exception if [developer mode](/windows/apps/get-started/enable-your-device-for-development) is not enabled.

## -see-also

## -examples

