---
-api-id: P:Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Handled

## -description

Gets or sets a value that indicates whether the exception is handled.

## -property-value

`true` to mark the exception as handled, which indicates that the event system should not process it further; otherwise, `false`.

## -remarks

Do not routinely set this value to `true`, that is not always safe and may not guarantee that the app wouldn't terminate anyways. For more info, see [Exception Handling (C# Programming Guide)](/dotnet/csharp/fundamentals/exceptions/exception-handling) and Remarks in [UnhandledException](application_unhandledexception.md).

## -examples

## -see-also

[UnhandledException](application_unhandledexception.md), [Exception Handling (C# Programming Guide)](/dotnet/csharp/fundamentals/exceptions/exception-handling)
