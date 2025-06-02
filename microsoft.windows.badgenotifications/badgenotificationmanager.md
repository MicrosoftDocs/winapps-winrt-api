---
-api-id: T:Microsoft.Windows.BadgeNotifications.BadgeNotificationManager
-api-type: winrt class
---

# Microsoft.Windows.BadgeNotifications.BadgeNotificationManager

<!--
public sealed class BadgeNotificationManager
-->

## -description

Provides methods to manage badge notifications shown on an app's taskbar icon.

## -remarks

A notification badge conveys summary or status information specific to your app. They can be one of a set of system-provided glyphs or numeric (1-99). If a numeric badge is set to a value higher than 99, it is shown as "99+".

Notification badges appear on your app's taskbar icon. If the app is pinned to the taskbar, the badge appears even if the app is not running.

## -see-also

## -examples

This example shows how to call [SetBadgeAsGlyph](badgenotificationmanager_setbadgeasglyph_1070366469.md) to set a notification badge with an `Alert` glyph.

```csharp
BadgeNotificationManager.Current.SetBadgeAsGlyph(BadgeNotificationGlyph.Alert);
```

This example shows how to call [SetBadgeAsCount](badgenotificationmanager_setbadgeascount_488974735.md) to set a notification badge with a numeric value of 20.

```csharp
BadgeNotificationManager.Current.SetBadgeAsCount(20);
```

This example shows how to synchronize a badge on the taskbar icon with an [InfoBadge](../microsoft.ui.xaml.controls/infobadge.md) control in the app. See [Example: Incrementing a numeric InfoBadge in a NavigationView](/windows/apps/design/controls/info-badge#example-incrementing-a-numeric-infobadge-in-a-navigationview) for the code. This code is added to the `MainWindow` constructor of that sample. It uses the [DependencyObject.RegisterPropertyChangedCallback](../microsoft.ui.xaml/dependencyobject_registerpropertychangedcallback_2003721961.md) method to listen for changes to the `InfoBadge.Value` property.

```csharp
public MainWindow()
{
    this.InitializeComponent();

    mailCountBadge.RegisterPropertyChangedCallback(InfoBadge.ValueProperty, (s, e) =>
    {
        if (e == InfoBadge.ValueProperty)
        {
            BadgeNotificationManager.Current.SetBadgeAsCount((uint)mailCountBadge.Value);
        }
    });
}
```
