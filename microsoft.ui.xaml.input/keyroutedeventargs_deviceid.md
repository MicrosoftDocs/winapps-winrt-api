---
-api-id: P:Microsoft.UI.Xaml.Input.KeyRoutedEventArgs.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Microsoft.UI.Xaml.Input.KeyRoutedEventArgs.DeviceId

## -description

Gets a unique ID for the input device that generated this key event (not supported for all input devices).

## -property-value

A unique identifier for the input device associated with the key event, or an empty string for an unsupported device. The same device can be assigned a different ID each time it is connected.

## -remarks

DeviceId can be used to differentiate between all connected devices that can generate key events.

## -examples

## -see-also
