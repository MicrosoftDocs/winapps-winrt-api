---
-api-id: P:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.DisabledChanges
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.DisabledChanges

<!--
public System.Collections.Generic.IList<Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityChange> DisabledChanges { get; }
-->


## -description

Gets or sets an optional list of specific servicing changes to disable.

The [Latest stable channel release notes for the Windows App SDK](/windows/apps/windows-app-sdk/stable-channel) lists the name of each change that you can disabled.

## -property-value

An optional list of specific servicing changes to disable.

## -remarks

If you encounter a problem with a specific change in a servicing update, then you can disable just that change by adding it to the **DisabledChanges** ` list before calling [Apply](./runtimecompatibilityoptions_apply_1657859512.md), or by specifying it in your app's project file:

```xml
<PropertyGroup>
  <WindowsAppSDKDisabledChanges>SampleApiCrashFix, OtherSampleApiCrashFix</WindowsAppSDKDisabledChanges>
</PropertyGroup>
```

> [!NOTE]
> Disabling a change is a temporary measure, which gives time for a fix to be released in a future Windows App SDK update, or for you to implement an update in your app. You should report any change you disable if you believe it to be a bug in the Windows App SDK. Doing so will help the Windows App SDK team to understand the impact of the change, and prioritize a fix. You can [report issues](https://github.com/microsoft/WindowsAppSDK/issues/new?template=bug-report.yaml) on the WindowsAppSDK GitHub repo.

The capability to disable a change is *not* available across new Windows App SDK stable releases (such as 1.7.x to 1.8.x), so this doesn't allow you to permanently disable an intentional behavior change. Also, new stable releases, such as 1.8.0, start with no changes available to disable&mdash;this capability applies only to disabling targeted servicing changes added in servicing releases.

## -see-also

## -examples
