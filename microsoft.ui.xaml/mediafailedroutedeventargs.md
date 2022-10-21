---
-api-id: T:Microsoft.UI.Xaml.MediaFailedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFailedRoutedEventArgs : Microsoft.UI.Xaml.ExceptionRoutedEventArgs, Microsoft.UI.Xaml.IMediaFailedRoutedEventArgs
-->

# Microsoft.UI.Xaml.MediaFailedRoutedEventArgs

## -description

Provides event data for the [MediaElement.MediaFailed](/uwp/api/windows.ui.xaml.controls.mediaelement.mediafailed) event.

## -remarks

`MediaFailedRoutedEventArgs` extends [ExceptionRoutedEventArgs](exceptionroutedeventargs.md) by adding the [ErrorTrace](mediafailedroutedeventargs_errortrace.md) property. In a handler for `MediaFailed`, cast the `ExceptionRoutedEventArgs` data as `MediaFailedRoutedEventArgs` so that you can use the `ErrorTrace` information. Otherwise, if you're only interested in the message, you can access [ErrorMessage](exceptionroutedeventargs_errormessage.md) without casting.

## -examples

## -see-also

[ExceptionRoutedEventArgs](exceptionroutedeventargs.md), [Windows.UI.Xaml.Controls.MediaElement](/uwp/api/windows.ui.xaml.controls.mediaelement)
