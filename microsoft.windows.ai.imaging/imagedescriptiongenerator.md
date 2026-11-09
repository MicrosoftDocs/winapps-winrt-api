---
-api-id: T:Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator

<!--
public sealed class ImageDescriptionGenerator : System.IDisposable
-->

## -description

Represents an object that can generate a description for the content of an image.

## -remarks

**ImageDescriptionGenerator** uses AI to produce natural-language descriptions of image content. The descriptions can be used for accessibility (alt text), search indexing, or content understanding.

Before creating an **ImageDescriptionGenerator** instance, call [GetReadyState](imagedescriptiongenerator_getreadystate_1726041729.md) to check whether the model is available on the device. If the model is not ready, call [EnsureReadyAsync](imagedescriptiongenerator_ensurereadyasync_1335418254.md) to download and prepare it. Then call [CreateAsync](imagedescriptiongenerator_createasync_616540418.md) to create an instance.

Call [DescribeAsync](imagedescriptiongenerator_describeasync_1940073159.md) with an image and an [ImageDescriptionKind](imagedescriptionkind.md) to specify the format of the description. The result is an [ImageDescriptionResult](imagedescriptionresult.md) containing the generated description text and a status code.

The **ImageDescriptionGenerator** class implements [IDisposable](/dotnet/api/system.idisposable), so you should use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
