---
-api-id: P:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.PatchLevel2
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.PatchLevel2

<!--
public Microsoft.Windows.ApplicationModel.WindowsAppRuntime.WindowsAppRuntimeVersion PatchLevel2 { get; set; }
-->


## -description

Gets or sets an optional patch level to use if the runtime version matches the major.minor version.

This property enables setting a second patch level to help your app transition to a new version of the Windows App SDK. This is a convenience to allow the patch levels for both the old and new version to be specified during the transition. Apps not in the process of transitioning should set only the one patch level they want to use.

Setting both patch levels for the same major.minor version, such as 1.7.3 and 1.7.4, is not allowed and will generate an error when calling [Apply](./runtimecompatibilityoptions_apply_1657859512.md).

## -property-value

An optional patch level to use if the runtime version matches the major.minor version. If the runtime version doesn't match the specified major.minor version, then this value is ignored.

## -remarks

Instead of directly using *PatchLevel2*, you could specify this patch level in your app's project file, like this:

```xml
  <PropertyGroup>
    <WindowsAppSDKRuntimePatchLevel2>1.8.2</WindowsAppSDKRuntimePatchLevel2>
  </PropertyGroup>
```

## -see-also

## -examples
