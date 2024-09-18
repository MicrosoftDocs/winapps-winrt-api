---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationProgressData.#ctor(System.UInt32)
-api-type: winrt constructor
---

# Microsoft.Windows.AppNotifications.AppNotificationProgressData.#ctor(System.UInt32)

<!--
public AppNotificationProgressData (uint sequenceNumber);
-->


## -description

Creates an instance of the [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) class with the specified sequence number.

## -parameters

### -param sequenceNumber

A non-zero integer that specifies the order of progress data updates. When multiple **AppNotificationProgressData** objects are received, the platform displays the data with the greatest non-zero number.

## -remarks

Initiate app notification progress updates by calling [UpdateAsync](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync*).

## -see-also

## -examples


