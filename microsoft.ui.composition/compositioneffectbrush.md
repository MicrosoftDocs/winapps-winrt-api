---
-api-id: T:Microsoft.UI.Composition.CompositionEffectBrush
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionEffectBrush : Windows.UI.Composition.CompositionBrush, Windows.UI.Composition.ICompositionEffectBrush
-->

# Microsoft.UI.Composition.CompositionEffectBrush

## -description
Paints a SpriteVisual with the output of a filter effect. The filter effect description is defined using the  [CompositionEffectFactory](compositioneffectfactory.md) class.

## -remarks
The effect APIs enable developers to customize how their UI is rendered. This can be something as simple as adjusting saturation levels on an image or something more complex like chaining numerous effects together and animating the effect properties to create interesting application transitions and user experiences. A composition effect is a graph of operations that define how to produce graphical content based on composition surfaces. For example, the pixel content of images. Effects are applied to visuals in the tree and can reference existing surfaces.

An instance of CompositionEffectBrush is created using a [CompositionEffectFactory](compositioneffectfactory.md) based on a specified effect description. [CompositionEffectFactory](compositioneffectfactory.md) uses the [Win2D](https://microsoft.github.io/Win2D/html/Introduction.htm) effect description format in the **Microsoft.Graphics.Canvas.Effects** namespace ([WinAppSDK (WinUI 3)](https://microsoft.github.io/Win2D/WinUI3/html/N_Microsoft_Graphics_Canvas_Effects.htm) / [UWP (WinUI 2)](https://microsoft.github.io/Win2D/WinUI2/html/N_Microsoft_Graphics_Canvas_Effects.htm)).

> [!NOTE]
> Effects that are not supported are marked as **[NoComposition]** in the [Win2D API Reference](https://microsoft.github.io/Win2D/html/Introduction.htm) for effects namespace.

A CompositionEffectBrush is applied to a [SpriteVisual](spritevisual.md) in the composition tree.

Sources to CompositionEffectBrush can be an existing surface or texture, or another effect enabling effect chaining.

CompositionEffectBrush.Properties (inherited from CompositionObject.Properties) allows setting or animating the animatable properties that were specified in the call to Compositor.[CreateEffectFactory](compositor_createeffectfactory_720924202.md) using their full 'EffectName.PropertyName' name.

Effect sources can be set independently from other CompositionEffectBrush instances, and properties can be animated independently from other CompositionEffectBrush instances.

Once an effect graph is declared, the system compiles the effect using built-in shaders. Custom shaders cannot be specified.

### Creating a CompositionEffect

To create and apply an effect you need to perform the following steps:

1. Create an effect description. See the [Win2D](https://microsoft.github.io/Win2D/html/Introduction.htm) namespace, **Microsoft.Graphics.Canvas.Effects** namespace ([WinAppSDK (WinUI 3)](https://microsoft.github.io/Win2D/WinUI3/html/N_Microsoft_Graphics_Canvas_Effects.htm) / [UWP (WinUI 2)](https://microsoft.github.io/Win2D/WinUI2/html/N_Microsoft_Graphics_Canvas_Effects.htm)), for valid effect types.
1. Set any effect sources with either an instance of [CompositionEffectSourceParameter](compositioneffectsourceparameter.md) or another effect. Specifying another effect creates an effect chain.
1. Create a CompositionEffectFactory with Compositor.[CreateEffectFactory](compositor_createeffectfactory_720924202.md) using the effect description as input.
1. Create an instance of the effect using CompositorEffectFactory.[CreateBrush](compositioneffectfactory_createbrush_639615316.md).
1. Set any CompositionEffectSourceParameter using CompositionEffectBrush.[SetSourceParameter](compositioneffectbrush_setsourceparameter_286598971.md) and the name of the source parameter as previously specified using a [CompositionEffectSourceParameter](compositioneffectsourceparameter.md).
1. Create an instance of [SpriteVisual](spritevisual.md) using Compositor.[CreateSpriteVisual](compositor_createspritevisual_1850565165.md).
1. Set the [Brush](spritevisual_brush.md) property of the [SpriteVisual](spritevisual.md) to the created effect.
1. Add the [SpriteVisual](spritevisual.md) to the composition tree by using the [Children](containervisual_children.md) property of a [ContainerVisual](containervisual.md).


## -examples


```csharp

// Create an effect description 
GaussianBlurEffect blurEffect = new GaussianBlurEffect() 
{ 
    Name = "Blur", 
    BlurAmount = 1.0f, 
    BorderMode = EffectBorderMode.Hard, 
    Optimization = EffectOptimization.Balanced 
}; 

blurEffect.Source = new CompositionEffectSourceParameter("source"); 

CompositionEffectFactory blurEffectFactory = _compositor.CreateEffectFactory(blurEffect); 
CompositionEffectBrush blurBrush = blurEffectFactory.CreateBrush(); 
// Create a BackdropBrush and bind it to the EffectSourceParameter “source” 
CompositionBackdropBrush backdropBrush = _compositor.CreateBackdropBrush(); 
blurBrush.SetSourceParameter("source", backdropBrush); 

// The SpriteVisual to apply the blur BackdropBrush to 
// This will cause everything behind this SpriteVisual to be blurred 
SpriteVisual blurSprite = _compositor.CreateSpriteVisual(); 
blurSprite.Brush = blurBrush; 

// Set blurSprite as a child visual of a XAML element 
ElementCompositionPreview.SetElementChildVisual(blurArea, blurSprite); 
          
```



## -see-also
[Composition Brushes Overview](/windows/uwp/graphics/composition-brushes), [Composition Effects Overview](/en-us/windows/uwp/composition/composition-effects), [CompositionBrush](compositionbrush.md), [IClosable](/uwp/api/windows.foundation.iclosable)
