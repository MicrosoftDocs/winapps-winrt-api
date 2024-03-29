---
-api-id: T:Microsoft.UI.Xaml.TriggerAction
-api-type: winrt class
---

<!-- Class syntax.
public class TriggerAction : Microsoft.UI.Xaml.DependencyObject, Microsoft.UI.Xaml.ITriggerAction
-->

# Microsoft.UI.Xaml.TriggerAction

## -description

Serves as the base class for [BeginStoryboard](../microsoft.ui.xaml.media.animation/beginstoryboard.md). Not commonly used. See Remarks.

## -remarks

[Triggers](frameworkelement_triggers.md), [EventTrigger](eventtrigger.md), [Actions](eventtrigger_actions.md) and [BeginStoryboard](../microsoft.ui.xaml.media.animation/beginstoryboard.md) are not commonly used. These API mainly exist for compatibility in XAML originally used for Microsoft Silverlight. For most scenarios where event triggers were used previously, you should either use visual states, or start animations by writing a [Loaded](frameworkelement_loaded.md) handler that looks up an animation in page-level resources and then calls [Begin](../microsoft.ui.xaml.media.animation/storyboard_begin_1621727531.md) on the animation's main [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md). For more info, see [XAML Control templates](/windows/apps/design/style/xaml-control-templates) or [Storyboarded animations](/windows/apps/design/motion/storyboarded-animations).

## -examples

## -see-also

[DependencyObject](dependencyobject.md)
