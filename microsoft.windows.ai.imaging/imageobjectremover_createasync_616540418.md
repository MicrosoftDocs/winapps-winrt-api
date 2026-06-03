---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectRemover.CreateAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectRemover.CreateAsync

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Imaging.ImageObjectRemover> CreateAsync ();
-->

## -description

Asynchronously creates a new instance of the [ImageObjectRemover](imageobjectremover.md) class.

## -returns

An asynchronous operation object that returns an [ImageObjectRemover](imageobjectremover.md) object on completion.

## -remarks

Call [GetReadyState](imageobjectremover_getreadystate_1726041729.md) before calling this method. If **GetReadyState** returns `NotReady`, call [EnsureReadyAsync](imageobjectremover_ensurereadyasync_1335418254.md) first to download and install the model.

The returned **ImageObjectRemover** implements [IDisposable](/dotnet/api/system.idisposable). Use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
