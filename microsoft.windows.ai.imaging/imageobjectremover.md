---
-api-id: T:Microsoft.Windows.AI.Imaging.ImageObjectRemover
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.ImageObjectRemover

<!--
public sealed class ImageObjectRemover : System.IDisposable
-->

## -description

Represents an object that can remove artifacts from images.

## -remarks

**ImageObjectRemover** uses AI to erase objects from an image and fill the erased area with a reconstruction of the background. This is useful for removing unwanted elements from photos while preserving a natural appearance.

Before creating an **ImageObjectRemover** instance, call [GetReadyState](imageobjectremover_getreadystate_1726041729.md) to check whether the model is available on the device. If the model is not ready, call [EnsureReadyAsync](imageobjectremover_ensurereadyasync_1335418254.md) to download and prepare it. Then call [CreateAsync](imageobjectremover_createasync_616540418.md) to create an instance.

To remove an object, you typically first use [ImageObjectExtractor](imageobjectextractor.md) to generate a mask for the object you want to remove, then pass that mask along with the source image to [RemoveFromImageBuffer](imageobjectremover_removefromimagebuffer_1878721313.md) or [RemoveFromSoftwareBitmap](imageobjectremover_removefromsoftwarebitmap_1744765345.md).

The **ImageObjectRemover** class implements [IDisposable](/dotnet/api/system.idisposable), so you should use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
