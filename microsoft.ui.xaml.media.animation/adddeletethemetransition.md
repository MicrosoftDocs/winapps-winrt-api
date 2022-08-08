---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.AddDeleteThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class AddDeleteThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IAddDeleteThemeTransition
-->

# Microsoft.UI.Xaml.Media.Animation.AddDeleteThemeTransition

## -description
Provides the animated transition behavior for when controls add or delete children of a panel. For example, if you have a collection of photos displayed in a [Grid](../microsoft.ui.xaml.controls/grid.md), you can associate this animation to the [Grid](../microsoft.ui.xaml.controls/grid.md) so that when photos are added or deleted, the photos will animate in and out of view.

## -xaml-syntax
```xaml
<AddDeleteThemeTransition .../>
```


## -remarks

## -examples
The following example shows how to use the AddDeleteThemeTransition to animate rectangles as they are added and deleted from a panel. Notice how the other child elements of the panel re-flow when one of them is removed.

[!code-xaml[AddDeleteThemeTransition](../microsoft.ui.xaml.media.animation/code/AddDeleteThemeTransition/csharp/BlankPage.xaml#SnippetAddDeleteThemeTransition)]

[!code-csharp[AddDeleteThemeTransition_code](../microsoft.ui.xaml.media.animation/code/AddDeleteThemeTransition/csharp/BlankPage.xaml.cs#SnippetAddDeleteThemeTransition_code)]

## -see-also
[Transition](transition.md), [Guidelines for add and delete animations](/windows/apps/design/motion/motion-list)
