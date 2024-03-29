---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedChevronDownSmallVisualSource.Markers
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedChevronDownSmallVisualSource.Markers

<!--
public System.Collections.Generic.IReadOnlyDictionary<string,double> Markers { get; }
-->

## -description

Provides a mapping from marker names to playback positions in the animated visual for an [AnimatedIcon](../microsoft.ui.xaml.controls/AnimatedIcon.md).

## -property-value

The collection of marker names and values as defined in the JSON file for the animated icon.

## -remarks

The JSON file that defines the marker names and values is  generated by [LottieGen](/windows/communitytoolkit/animations/lottie-scenarios/getting_started_codegen).

The following example shows the marker format in a Lottie JSON file. See the [AnimatedIcon](/windows/apps/design/controls/animated-icon) guidance for more detail.

```json
"markers":[{"tm":0,"cm":"NormalToPointerOver_Start","dr":0},{"tm":9,"cm":"NormalToPointerOver_End","dr":0}, 

{"tm":10,"cm":"NormalToPressed_Start","dr":0},{"tm":19,"cm":"NormalToPressed_End","dr":0}, 

{"tm":20,"cm":"PointerOverToNormal_Start","dr":0},{"tm":29,"cm":"PointerOverToNormal_End","dr":0}, 

{"tm":30,"cm":"PointerOverToPressed_Start","dr":0},{"tm":39,"cm":"PointerOverToPressed_End","dr":0}, 

{"tm":40,"cm":"PressedToNormal_Start","dr":0},{"tm":49,"cm":"PressedToNormal_End","dr":0}, 

{"tm":50,"cm":"PressedToPointerOver_Start","dr":0},{"tm":69,"cm":"PressedToPointerOver_End","dr":0}, 

{"tm":90,"cm":"PressedToNormal_Start","dr":0},{"tm":99,"cm":"PressedToNormal_End","dr":0}, 

{"tm":100,"cm":"PressedToPointerOver_Start","dr":0},{"tm":101,"cm":"PressedToPointerOver_End","dr":0}]
```

## -see-also

[IAnimatedVisualSource2.Markers](../microsoft.ui.xaml.controls/ianimatedvisualsource2_markers.md), [Animated icons guidance](/windows/apps/design/controls/animated-icon)

## -examples
