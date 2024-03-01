---
-api-id: M:Microsoft.UI.Input.FocusNavigationRequest.Create(Microsoft.UI.Input.FocusNavigationReason,Windows.Foundation.Rect,System.Guid)
-api-type: winrt method
---

# Microsoft.UI.Input.FocusNavigationRequest.Create(Microsoft.UI.Input.FocusNavigationReason,Windows.Foundation.Rect,System.Guid)

<!--
public static Microsoft.UI.Input.FocusNavigationRequest Create (Microsoft.UI.Input.FocusNavigationReason reason, Windows.Foundation.Rect hintRect, Guid correlationId);
-->

## -description

Creates an instance of [FocusNavigationRequest](focusnavigationrequest.md) using the specified [FocusNavigationReason](focusnavigationreason.md), hint [Rect](/uwp/api/windows.foundation.rect), and [unique identifier](/windows/win32/api/guiddef/ns-guiddef-guid).

## -parameters

### -param reason

The reason for a focus navigation event.

### -param hintRect

The bounding rectangle used to identify the focus candidates most likely to receive navigation focus.

### -param correlationId

The unique ID generated when a focus movement event is initiated.

## -returns

A [FocusNavigationRequest](focusnavigationrequest.md) object.

## -remarks

## -see-also

## -examples
