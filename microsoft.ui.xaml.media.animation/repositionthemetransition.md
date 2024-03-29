---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class RepositionThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IRepositionThemeTransition, Windows.UI.Xaml.Media.Animation.IRepositionThemeTransition2
-->

# Microsoft.UI.Xaml.Media.Animation.RepositionThemeTransition

## -description
Reacts to layout moves when no context is set and a trigger of *move* is passed.

## -xaml-syntax
```xaml
<RepositionThemeTransition ../>
```


## -remarks
The RepositionThemeTransition is not designed to be used with Panels that perform UI virtualization such as the default Panel on a ListView or GridView control.

## -examples
The following example applies a RepositionThemeTransition to a button. When you click the button, its margin changes, which changes its position. This position change is animated.

[!code-xaml[RepositionThemeTransitionSimple](../microsoft.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml#SnippetRepositionThemeTransitionSimple)]

[!code-csharp[RepositionThemeTransitionSimple_code](../microsoft.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml.cs#SnippetRepositionThemeTransitionSimple_code)]


[!code-xaml[RepositionThemeTransition](../microsoft.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml#SnippetRepositionThemeTransition)]

[!code-csharp[RepositionThemeTransition_code](../microsoft.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml.cs#SnippetRepositionThemeTransition_code)]

## -see-also
[Transition](transition.md), [Animating repositions](/previous-versions/windows/apps/jj649434(v=win.10)), [Guidelines and checklist for reposition animations](/windows/uwp/style/motion-reposition), [reposition animations](/windows/apps/design/motion/motion-reposition)
