---
-api-id: P:Microsoft.UI.Xaml.Controls.Control.TabNavigation
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Input.KeyboardNavigationMode TabNavigation { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.Control.TabNavigation

## -description
Gets or sets a value that modifies how tabbing and [UIElement.TabIndex](../microsoft.ui.xaml/uielement_tabindex.md) work for this control.

> [!NOTE]
> For Windows 10 Creators Update (build 10.0.15063) and newer, the [TabFocusNavigation](../microsoft.ui.xaml/uielement_tabfocusnavigation.md) property is available on the [UIElement]() base class to include objects in the tab sequence that do not use a [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md).

## -xaml-syntax
```xaml
<control TabNavigation="keyboardNavigationModeMemberName"/>
```


## -xaml-values
<dl><dt>keyboardNavigationModeMemberName</dt><dd>keyboardNavigationModeMemberNameA named constant of the KeyboardNavigationMode enumeration, for example Cycle.</dd>
</dl>
## -property-value
A value of the enumeration. The default is **Local**.

## -remarks

## -examples

## -see-also
[UIElement.IsTabStop](../microsoft.ui.xaml/uielement_istabstop.md), [UIElement.TabIndex](../microsoft.ui.xaml/uielement_tabindex.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions), [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility)
