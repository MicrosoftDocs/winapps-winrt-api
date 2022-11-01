---
-api-id: T:Microsoft.Graphics.Display.DisplayAdvancedColorInfo
-api-type: winrt class
---

# Microsoft.Graphics.Display.DisplayAdvancedColorInfo

<!--
public sealed class DisplayAdvancedColorInfo
-->

## -description

Contains a snapshot of the Advanced Color-related information of a monitor or display driver.

## -remarks

Advanced color is a Windows developer term indicating support for high dynamic range (HDR), wide color gamut (WCG), and high-precision (bit-depth) visual content such as videos, games, and photos. To use advanced color, your computer must have an advanced-color-capable GPU and display. Further, the composition and display stack must enter a new advanced color mode that uses FP16 rendering and composition. 

To exploit advanced color, applications must be updated with enhanced rendering pipelines (for example, DirectX), and they must detect and adapt to the specific capabilities of the current display. In terms of API design, advanced color has similarities to features such as high DPI and stereoscopic 3D. 

* Apps need to understand the current feature state, such as whether HDR is active, and if so what kind of HDR is active. Apps must also understand the quantitative display characteristics (for example, peak luminance, color primaries) and underlying capabilities of the hardware (for example, whether HDR can be enabled at all).

* User action or operating system (OS) policy can change the feature state and display characteristics at any time. 

## -see-also

## -examples
