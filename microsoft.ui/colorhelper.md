---
-api-id: T:Microsoft.UI.ColorHelper
-api-type: winrt class
---

<!-- Class syntax.
public class ColorHelper : Windows.UI.IColorHelper
-->

# Microsoft.UI.ColorHelper

## -description
Provides static helper methods for processing [Color](/uwp/api/windows.ui.color) values. C# and Microsoft Visual Basic code should use methods of [Color](/uwp/api/windows.ui.color) instead.

## -remarks
[Color](/uwp/api/windows.ui.color) is a Windows Runtime structure that represents a color that has four channels: **A** (alpha), **R** (red), **G** (green), **B** (blue). Each of the values is stored as a **Byte** type with value 0-255. The most frequent application of [Color](/uwp/api/windows.ui.color) is to define color-related properties in a UI element as part of a UWP app using C++, C#, or Visual Basic and its XAML UI definition.

ColorHelper is one of several **Helper** classes that are intended to provide utility methods for Windows Runtime structure values. C# and Microsoft Visual Basic code can use methods of [Color](/uwp/api/windows.ui.color) instead, because utility methods are available directly on the structure due to .NET Framework runtime support. C++ code including Visual C++ component extensions (C++/CX) can only access the data values on [Color](/uwp/api/windows.ui.color), for example the **A** field value. For C++ developers, some of the utility features that C# and Microsoft Visual Basic can use directly on [Color](/uwp/api/windows.ui.color) as nondata members are available from the ColorHelper class.

## -examples

## -see-also
[Color](/uwp/api/windows.ui.color), [Colors](colors.md), [SolidColorBrush](../microsoft.ui.xaml.media/solidcolorbrush.md)
