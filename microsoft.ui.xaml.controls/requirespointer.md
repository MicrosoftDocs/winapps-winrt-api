---
-api-id: T:Microsoft.UI.Xaml.Controls.RequiresPointer
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.RequiresPointer : int
-->

# RequiresPointer

## -description

Defines constants that specify when an element requires a mouse-like pointer behavior from an Xbox controller.

## -enum-fields

### -field Never:0

The pointer never acts as a mouse.

### -field WhenEngaged:1

The pointer acts as a mouse when the user engages mouse-mode.

### -field WhenFocused:2

The pointer acts as a mouse when the page gets focus. Supported on [Page](page.md) elements only.

## -remarks

This enumeration provides values for the [Control.RequiresPointer](control_requirespointer.md) property.

For non-pointer input devices, focus is moved between controls through a variety of methods, such as the Tab and arrow keys on a keyboard or the directional pad (D-pad) and thumb sticks on an Xbox controller. For some user experiences, such as maps and drawing surfaces, it is not possible or practical to use XY focus navigation. RequiresPointer enables an app to provide a more pointer-like interaction experience through a cursor that can be moved freely using the Xbox controller.

RequiresPointer is supported only when using an Xbox controller. The property is ignored otherwise.

For more info, see the [Mouse mode](/windows/uwp/input-and-devices/designing-for-tv) section of [Designing for Xbox and TV](/windows/uwp/input-and-devices/designing-for-tv).

## -examples

## -see-also
