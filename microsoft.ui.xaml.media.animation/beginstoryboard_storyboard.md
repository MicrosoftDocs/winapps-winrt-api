---
-api-id: P:Microsoft.UI.Xaml.Media.Animation.BeginStoryboard.Storyboard
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { get;  set; }
-->

# Microsoft.UI.Xaml.Media.Animation.BeginStoryboard.Storyboard

## -description
Gets or sets the [Storyboard](storyboard.md) that this [BeginStoryboard](beginstoryboard.md) starts.

## -xaml-syntax
```xaml
<BeginStoryboard>
  <Storyboard ...>
    oneOrMoreAnimations
  </Storyboard>
</BeginStoryboard>
```


## -xaml-values
<dl><dt>oneOrMoreAnimations</dt><dd>oneOrMoreAnimationsOne or more animation types that derive from Timeline. These provide the value of Storyboard.Children.</dd>
</dl>
## -property-value
The [Storyboard](storyboard.md) that the [BeginStoryboard](beginstoryboard.md) starts. The default is null.

## -remarks
[Triggers](../microsoft.ui.xaml/frameworkelement_triggers.md), [EventTrigger](../microsoft.ui.xaml/eventtrigger.md), and [BeginStoryboard](beginstoryboard.md) are not commonly used. These API mainly exist for compatibility in XAML originally used for Microsoft Silverlight. For most scenarios where event triggers were used previously, you should either use visual states, or start animations by writing a [Loaded](../microsoft.ui.xaml/frameworkelement_loaded.md) handler that looks up an animation in page-level resources and then calls [Begin](storyboard_begin_1621727531.md) on the animation's main [Storyboard](storyboard.md). For more info, see [XAML Control templates](/windows/apps/design/style/xaml-control-templates) or [Storyboarded animations](/windows/apps/design/motion/storyboarded-animations).

## -examples
This XAML example shows the basic structure for using [FrameworkElement.Triggers](../microsoft.ui.xaml/frameworkelement_triggers.md) with its default [FrameworkElement.Loaded](../microsoft.ui.xaml/frameworkelement_loaded.md) trigger behavior to run a storyboarded animation. This XAML shows the [EventTrigger](../microsoft.ui.xaml/eventtrigger.md) and [BeginStoryboard](beginstoryboard.md) container elements in proper relationship with each using their XAML content property syntax and unnecessary property element tags (such as [BeginStoryboard.Storyboard](beginstoryboard_storyboard.md)) omitted.

```xaml
<Canvas Width="200" Height="200" x:Name="animatedcanvas" Background="Red">
    <Canvas.Triggers>
        <EventTrigger>
            <BeginStoryboard>
                <Storyboard x:Name="ColorStoryboard">
                   <!-- Animate the background of the canvas to green over 4 seconds. -->
                    <ColorAnimation Storyboard.TargetName="animatedcanvas"
                      Storyboard.TargetProperty="(Panel.Background).(SolidColorBrush.Color)"
                      To="Green" Duration="0:0:4" />
                </Storyboard>
            </BeginStoryboard>
        </EventTrigger>
    </Canvas.Triggers>
</Canvas>
```



## -see-also
[XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide)
