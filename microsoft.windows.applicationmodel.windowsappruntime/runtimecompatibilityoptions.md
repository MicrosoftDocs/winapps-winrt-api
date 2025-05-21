---
-api-id: T:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions
-api-type: winrt class
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions

<!--
public sealed class RuntimeCompatibilityOptions
-->


## -description

Your app can use this class to configure any desired compatibility options for Windows App Runtime behavior of changes added in servicing updates. This class is used only to set the runtime behavior, and can't be used to query the applied options.

## -remarks

There are two ways in which you can deploy the Windows App SDK: Framework-dependent; or self-contained. For details, and advantages and problems, see [Windows App SDK deployment overview](/windows/apps/package-and-deploy/deploy-overview).

The **RuntimeCompatibilityOptions** class provides you with app-configurable compatibility. It's intended to prevent the problems with Framework-dependent deployment, enabling your app to use that option with confidence that it won't be broken.

Also, if you find a compatibility problem in a servicing release, you'll still be able to move forward by temporarily
disabling problematic changes. Even a self-contained app can update to a new package with confidence that app-configurable compatibility will ensure a successful update.

**RuntimeCompatibilityOptions** has APIs to control the behavior of servicing changes. There are also properties that can be set in your app's project file to automatically use the new APIs with the specified values.

**RuntimeCompatibilityOptions** configures which changes in Windows App SDK servicing releases are enabled. By default, all changes are enabled, but you can use **RuntimeCompatibilityOptions** to lock the runtime behavior to a
specified patch level, or to disable specific changes:

1. **Choose the patch level:** You can specify which servicing release's behavior you want to use. For example, your app can specify that it wants the 1.7.2 patch level behavior, which will have the Windows App SDK run in that patch level, even if 1.7.3 or later is installed. This capability allows you to control when your app gets new fixes or behavior changes, even when you're not using self-contained mode.
1. **Temporarily disable specific changes:** If your app encounters a problem with a specific change in a servicing update, then you can disable just that change while still benefiting from the other changes or features in that update. All changes are enabled by default for the patch level in use. Disabling a change is a temporary measure, which gives time for a fix to be released in a future Windows App SDK update, or for you to implement an update in your app.

Here's an example to specify a patch level, and disable a specific change:

```csharp
void ApplyRuntimeCompatibilityOptions() 
{
    var compatibilityOptions = new RuntimeCompatibilityOptions();
    compatibilityOptions.PatchLevel1 = new WindowsAppRuntimeVersion(1,7,3);
    compatibilityOptions.PatchLevel2 = new WindowsAppRuntimeVersion(1,8,2);
    compatibilityOptions.DisabledChanges.Add(RuntimeCompatibilityChange.SampleApiCrashFix);
    compatibilityOptions.Apply();
}
```

You must apply **RuntimeCompatibilityOptions** early in the process, before any other Windows App SDK APIs are called; or right after initializing the Windows App Runtime.

[PatchLevel1](./runtimecompatibilityoptions_patchlevel1.md) and [PatchLevel2](./runtimecompatibilityoptions_patchlevel2.md) are simply two fields to set relevant patch levels. These needn't match any specific version of the Windows App Runtime, nor be in a specific order. So it's valid to set *PatchLevel1* to 1.8.2 and *PatchLevel2* to 1.7.3, for example. And, in the above example, when updating the app to 1.9, you might choose to simply update *PatchLevel1* to 1.9.3, and leave *PatchLevel2* as 1.8.2.

### Specifying RuntimeCompatibilityOptions in your app's project file

Alternatively, you can use your app's project file to specify the patch level and disabled changes, instead of directly using **RuntimeCompatibilityOptions**. This approach has the advantage of ensuring that the options are applied early at the proper timing. Here's an example of how to specify the patch level and disabled changes in your project file (such as `.csproj` or `.vcxproj`):

```xml
<PropertyGroup>
  <WindowsAppSDKRuntimePatchLevel1>1.7.3</WindowsAppSDKRuntimePatchLevel1>
  <WindowsAppSDKRuntimePatchLevel2>1.8.2</WindowsAppSDKRuntimePatchLevel2>
  <WindowsAppSDKDisabledChanges>SampleApiCrashFix, OtherSampleApiCrashFix</WindowsAppSDKDisabledChanges>
</PropertyGroup>
```

The **WindowsAppSDKDisabledChanges** property is a comma-separated list of **RuntimeCompatibilityChange** values to disable.

### Behavior with no PatchLevel specified

If no *PatchLevel1* or *PatchLevel2* is specified, or if neither value matches the major.minor version of the runtime being used, then the runtime will use the latest patch level. In other words, the runtime will run with all servicing changes enabled (just like how the Windows App SDK works if you don't use this API).

## -see-also

## -examples
