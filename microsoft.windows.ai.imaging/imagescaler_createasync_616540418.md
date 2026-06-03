---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageScaler.CreateAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageScaler.CreateAsync

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Imaging.ImageScaler> CreateAsync ();
-->

## -description

Asynchronously creates a new instance of the [ImageScaler](imagescaler.md) class.

## -returns

An asynchronous operation object that returns an [ImageScaler](imagescaler.md) object on completion.

## -remarks

Call [GetReadyState](imagescaler_getreadystate_1726041729.md) before calling this method. If **GetReadyState** does not return `Ready`, call [EnsureReadyAsync](imagescaler_ensurereadyasync_1335418254.md) first to download and install the model.

The returned **ImageScaler** implements [IDisposable](/dotnet/api/system.idisposable). Use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging), [Image scaler walkthrough](/windows/ai/apis/imaging-tutorial)

## -examples
