---
-api-id: P:Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Message
-api-type: winrt property
---

<!-- Property syntax
public string Message { get; }
-->

# Microsoft.UI.Xaml.UnhandledExceptionEventArgs.Message

## -description

Gets the message string as passed by the originating unhandled exception.

## -property-value

The message string, which may be useful for debugging.

## -remarks

The message is coming from info that's propagated by the original system or runtime app error. The message is not guaranteed to be an exact match to the original error message (as seen in native stacks or output windows). For more info on error propagation and exception handling techniques, see [Exception Handling (C# Programming Guide)](/dotnet/csharp/fundamentals/exceptions/exception-handling) and Remarks in [UnhandledException](application_unhandledexception.md).

## -examples

## -see-also

[UnhandledException](application_unhandledexception.md), [Exception Handling (C# Programming Guide)](/dotnet/csharp/fundamentals/exceptions/exception-handling)
