---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.BeginStoryboard
-api-type: winrt class
---

<!-- Class syntax.
public class BeginStoryboard : Windows.UI.Xaml.TriggerAction, Windows.UI.Xaml.Media.Animation.IBeginStoryboard
-->

# Microsoft.UI.Xaml.Media.Animation.BeginStoryboard

## -description
A trigger action that begins a [Storyboard](storyboard.md). Not commonly used. See Remarks.

## -xaml-syntax
```xaml
<BeginStoryboard ...>
  singleStoryboard
</BeginStoryboard>
```


## -remarks
[Triggers](../microsoft.ui.xaml/frameworkelement_triggers.md), [EventTrigger](../microsoft.ui.xaml/eventtrigger.md), [Actions](../microsoft.ui.xaml/eventtrigger_actions.md) and BeginStoryboard are not commonly used. These API mainly exist for compatibility in XAML originally used for Microsoft Silverlight. For most scenarios where event triggers were used previously, you should either use visual states, or start animations by writing a [Loaded](../microsoft.ui.xaml/frameworkelement_loaded.md) handler that looks up an animation in page-level resources and then calls [Begin](storyboard_begin_1621727531.md) on the animation's main [Storyboard](storyboard.md). For more info, see [XAML Control templates](/windows/apps/design/style/xaml-control-templates) or [Storyboarded animations](/windows/apps/design/motion/storyboarded-animations).

If you do choose to use [Triggers](../microsoft.ui.xaml/frameworkelement_triggers.md), in Windows Runtime XAML, the default behavior for event triggers and the only event that can be used to invoke an [EventTrigger](../microsoft.ui.xaml/eventtrigger.md) is [FrameworkElement.Loaded](../microsoft.ui.xaml/frameworkelement_loaded.md). Because that's both the default and the only enabled behavior, you don't set [RoutedEvent](../microsoft.ui.xaml/eventtrigger_routedevent.md), and just use the XAML `<EventTrigger>`. For more info, see [Triggers](../microsoft.ui.xaml/frameworkelement_triggers.md).

## -examples
This XAML example shows the basic structure for using [FrameworkElement.Triggers](../microsoft.ui.xaml/frameworkelement_triggers.md) with its default [FrameworkElement.Loaded](../microsoft.ui.xaml/frameworkelement_loaded.md) trigger behavior to run a storyboarded animation. This XAML shows the [EventTrigger](../microsoft.ui.xaml/eventtrigger.md) and BeginStoryboard container elements in proper relationship with each using their XAML content property syntax and unnecessary property element tags (such as [BeginStoryboard.Storyboard](beginstoryboard_storyboard.md)) omitted.

```xaml
<Canvas Width="200" Height="200" x:Name="animatedcanvas" Background="Red">
    <Canvas.Triggers>
        <EventTrigger>
            <BeginStoryboard>
                <Storyboard x:Name="ColorStoryboard">
                   <!-- Animate the background of the canvas to green over 4 seconds. -->
                    <ColorAnimation Storyboard.TargetName="animatedcanvas"
                      Storyboard.TargetProperty="(Panel.Background).(SolidColorBrush.Color)"
                      To="Green" Duration="0:0:4"/>
                </Storyboard>
            </BeginStoryboard>
        </EventTrigger>
    </Canvas.Triggers>
</Canvas>
```



## -see-also
[TriggerAction](../microsoft.ui.xaml/triggeraction.md), [Triggers](../microsoft.ui.xaml/frameworkelement_triggers.md), [Storyboard](storyboard.md), [XAML Control templates](/windows/apps/design/style/xaml-control-templates)
