---
-api-id: T:Microsoft.Windows.AI.AIFeatureReadyState
-api-type: winrt enum
---

# Microsoft.Windows.AI.AIFeatureReadyState

<!--
public enum AIFeatureReadyState
-->

## -description

Specifies the language model readiness states.

## -enum-fields

### -field Ready: 0

Model is installed and ready to use.

> [!NOTE]
> In some cases (such as during disk cleaning), model status can revert to a non-ready status.

### -field EnsureNeeded: 1

Model needs to be downloaded and installed.

### -field NotSupportedOnCurrentSystem: 2

Model is not supported for the current OS version or hardware configuration.

### -field DisabledByUser: 3

Model has been removed or disabled.

## -remarks

## -see-also

[Microsoft.Windows.AI.Text.LanguageModel.GetReadyState](../microsoft.windows.ai.text/languagemodel_getreadystate_1726041729.md), [Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator.GetReadyState](../microsoft.windows.ai.imaging/imagedescriptiongenerator_getreadystate_1726041729.md), [Microsoft.Windows.AI.Imaging.ImageObjectExtractor.GetReadyState](../microsoft.windows.ai.imaging/imageobjectextractor_getreadystate_1726041729.md), [Microsoft.Windows.AI.Imaging.ImageObjectRemover.GetReadyState](../microsoft.windows.ai.imaging/imageobjectremover_getreadystate_1726041729.md), [Microsoft.Windows.AI.Imaging.ImageScaler.GetReadyState](../microsoft.windows.ai.imaging/imagescaler_getreadystate_1726041729.md)

## -examples
