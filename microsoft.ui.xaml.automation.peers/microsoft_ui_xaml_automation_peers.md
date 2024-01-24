---
-api-id: N:Microsoft.UI.Xaml.Automation.Peers
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Microsoft.UI.Xaml.Automation.Peers 
-->

# Microsoft.UI.Xaml.Automation.Peers

## -description

Defines support types for the [Microsoft UI Automation](/windows/win32/winauto/entry-uiauto-win32) infrastructure.

> [!NOTE]
> This namespace requires the **Microsoft.UI.Xaml.Controls** NuGet package, a part of the [Microsoft Windows UI Library](https://aka.ms/winui-docs).

## -remarks

WinUI controls, and other UI elements, implement UI Automation support to report roles and values. You can use UI Automation tools to examine the role and value information, or you can review the AutomationPeer implementations of each control. The available roles in a UI Automation framework are defined in the [AutomationControlType](/uwp/api/Windows.UI.Xaml.Automation.Peers.AutomationControlType) enumeration. UI Automation clients, such as assistive technologies, can obtain role information by calling methods that the UI Automation framework exposes through the control's AutomationPeer.

## -see-also

[Custom automation peers](/windows/apps/design/accessibility/custom-automation-peers), [Expose basic accessibility information](/windows/apps/design/accessibility/basic-accessibility-information), [Accessibility Insights](https://accessibilityinsights.io/)

## -examples

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see AutomationProperties in action](winui3gallery:/item/AutomationProperties)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

