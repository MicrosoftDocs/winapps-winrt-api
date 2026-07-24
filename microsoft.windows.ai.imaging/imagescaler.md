---
-api-id: T:Microsoft.Windows.AI.Imaging.ImageScaler
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.ImageScaler

<!--
public sealed class ImageScaler : System.IDisposable
-->

## -description

Represents an object that can resize an image and increase or decrease its resolution.

## -remarks

**ImageScaler** uses AI-powered Image Super Resolution to scale and sharpen images while maintaining quality. The model runs on the device's NPU for hardware-accelerated performance. Call [MaxSupportedScaleFactor](imagescaler_maxsupportedscalefactor.md) to determine the maximum scale factor available on the current device.

Before creating an **ImageScaler** instance, call [GetReadyState](imagescaler_getreadystate_1726041729.md) to check whether the model is available on the device. If the model is not ready, call [EnsureReadyAsync](imagescaler_ensurereadyasync_1335418254.md) to download and prepare it. Then call [CreateAsync](imagescaler_createasync_616540418.md) to create an instance.

The **ImageScaler** class implements [IDisposable](/dotnet/api/system.idisposable), so you should use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

Check the [MaxSupportedScaleFactor](imagescaler_maxsupportedscalefactor.md) property to determine the maximum scaling factor supported by the device.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging), [Image scaler walkthrough](/windows/ai/apis/imaging-tutorial)

## -examples
