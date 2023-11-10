---
-api-id: M:Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.#ctor(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason,Windows.Foundation.Rect)
-api-type: winrt constructor
---

# Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.#ctor(Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason,Windows.Foundation.Rect)

<!--
public XamlSourceFocusNavigationRequest (Microsoft.UI.Xaml.Hosting.XamlSourceFocusNavigationReason reason, Windows.Foundation.Rect hintRect);
-->

## -description

Initializes a new instance of a [XamlSourceFocusNavigationRequest](xamlsourcefocusnavigationrequest.md) object for the the specified navigation request reason and the bounding rectangle that will receive navigation focus.

## -parameters

### -param reason

The reason for the navigation request.

### -param hintRect

The bounding rectangle of the element in the desktop application that is losing focus (that is, the element that had focus before the [DesktopWindowXamlSource](desktopwindowxamlsource.md) received focus). This parameter is used to provide context to the WinUI XAML framework when the user enters the **DesktopWindowXamlSource** using a 4-direction navigation experience, such as the keyboard arrow keys.

## -remarks

An example use case for this object is where there are three WPF buttons to the left of the **DesktopWindowXamlSource** and there are three WinUI buttons inside the **DesktopWindowXamlSource** (a total of six buttons in a 3x2 grid across two UI frameworks). When the user presses the right arrow on the keyboard from the middle WPF button, focus should move to the middle WinUI button in the **DesktopWindowXamlSource**. To accomplish this, pass the bounding rectangle of the middle WPF button to the *hintRect* parameter and specify **Right** for the *reason* parameter.

## -see-also

## -examples
