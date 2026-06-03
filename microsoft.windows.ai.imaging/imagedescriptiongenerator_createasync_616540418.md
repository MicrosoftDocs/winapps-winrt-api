---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator.CreateAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator.CreateAsync

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator> CreateAsync ();
-->

## -description

Asynchronously creates a new instance of the [ImageDescriptionGenerator](imagedescriptiongenerator.md) class.

## -returns

An asynchronous operation object that returns an [ImageDescriptionGenerator](imagedescriptiongenerator.md) object on completion.

## -remarks

Call [GetReadyState](imagedescriptiongenerator_getreadystate_1726041729.md) before calling this method. If **GetReadyState** does not return `Ready`, call [EnsureReadyAsync](imagedescriptiongenerator_ensurereadyasync_1335418254.md) first to download and install the model.

The returned **ImageDescriptionGenerator** implements [IDisposable](/dotnet/api/system.idisposable). Use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
