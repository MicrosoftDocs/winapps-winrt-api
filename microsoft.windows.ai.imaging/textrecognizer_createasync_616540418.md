---
-api-id: M:Microsoft.Windows.AI.Imaging.TextRecognizer.CreateAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.TextRecognizer.CreateAsync

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Imaging.TextRecognizer> CreateAsync ();
-->

## -description

Asynchronously creates a new instance of the [TextRecognizer](textrecognizer.md) class.

## -returns

An asynchronous operation object that returns a [TextRecognizer](textrecognizer.md) object on completion.

## -remarks

Call [GetReadyState](textrecognizer_getreadystate_1726041729.md) before calling this method. If **GetReadyState** does not return `Ready`, call [EnsureReadyAsync](textrecognizer_ensurereadyasync_1335418254.md) first to download and install the model.

The returned **TextRecognizer** implements [IDisposable](/dotnet/api/system.idisposable). Use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
