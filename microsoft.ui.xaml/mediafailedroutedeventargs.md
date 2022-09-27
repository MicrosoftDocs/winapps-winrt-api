---
-api-id: T:Microsoft.UI.Xaml.MediaFailedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFailedRoutedEventArgs : Microsoft.UI.Xaml.ExceptionRoutedEventArgs, Microsoft.UI.Xaml.IMediaFailedRoutedEventArgs
-->

# Microsoft.UI.Xaml.MediaFailedRoutedEventArgs

## -description

Provides event data for media failed events.

## -remarks

`MediaFailedRoutedEventArgs` is the event data for the [MediaFailed](../microsoft.ui.xaml.controls/mediaelement_mediafailed.md) event. `MediaFailedRoutedEventArgs` extends [ExceptionRoutedEventArgs](exceptionroutedeventargs.md) by adding the [ErrorTrace](mediafailedroutedeventargs_errortrace.md) property. In a handler for `MediaFailed`, cast the `ExceptionRoutedEventArgs` data as `MediaFailedRoutedEventArgs` so that you can use the `ErrorTrace` information. Otherwise, if you're only interested in the message, you can access [ErrorMessage](exceptionroutedeventargs_errormessage.md) without casting.

## -examples

## -see-also

[ExceptionRoutedEventArgs](exceptionroutedeventargs.md), [MediaFailed](../microsoft.ui.xaml.controls/mediaelement_mediafailed.md)
