---
-api-id: T:Microsoft.Windows.AI.Imaging.ImageObjectExtractor
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.ImageObjectExtractor

<!--
public sealed class ImageObjectExtractor : System.IDisposable
-->

## -description

Represents an object that can extract artifacts from an image.

## -remarks

**ImageObjectExtractor** uses AI to identify and segment specific objects within an image. You provide hints in the form of points and rectangles through an [ImageObjectExtractorHint](imageobjectextractorhint.md), and the extractor returns a mask of the identified object.

Create an **ImageObjectExtractor** from either a [SoftwareBitmap](/uwp/api/windows.graphics.imaging.softwarebitmap) using [CreateWithSoftwareBitmapAsync](imageobjectextractor_createwithsoftwarebitmapasync_1289883320.md) or an [ImageBuffer](/windows/windows-app-sdk/api/winrt/microsoft.graphics.imaging.imagebuffer) using [CreateWithImageBufferAsync](imageobjectextractor_createwithimagebufferasync_698545862.md). Both factory methods first load and analyze the source image.

After creating the extractor, call [GetSoftwareBitmapObjectMask](imageobjectextractor_getsoftwarebitmapobjectmask_775650447.md) or [GetImageBufferObjectMask](imageobjectextractor_getimagebufferobjectmask_396059515.md) with an **ImageObjectExtractorHint** to retrieve the object mask.

The **ImageObjectExtractor** class implements [IDisposable](/dotnet/api/system.idisposable), so you should use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
