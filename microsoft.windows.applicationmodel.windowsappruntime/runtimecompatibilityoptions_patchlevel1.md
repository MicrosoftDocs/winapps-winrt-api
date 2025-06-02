---
-api-id: P:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.PatchLevel1
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.PatchLevel1

<!--
public Microsoft.Windows.ApplicationModel.WindowsAppRuntime.WindowsAppRuntimeVersion PatchLevel1 { get; set; }
-->


## -description

Gets or sets an optional patch level to use if the runtime version matches the major.minor version.

If your app isn't in the process of transitioning to a new version of the Windows App SDK, then you may set only this one patch level.

## -property-value

An optional patch level to use if the runtime version matches the major.minor version. If the runtime version doesn't match the specified major.minor version, then this value is ignored.

## -remarks

Instead of directly using *PatchLevel1*, you could specify this patch level in your app's project file,
like this:

```xml
<PropertyGroup>
  <WindowsAppSDKRuntimePatchLevel1>1.7.3</WindowsAppSDKRuntimePatchLevel1>
</PropertyGroup>
```

## -see-also

## -examples
