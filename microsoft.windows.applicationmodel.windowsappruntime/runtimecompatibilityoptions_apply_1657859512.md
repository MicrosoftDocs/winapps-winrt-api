---
-api-id: M:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.Apply
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.RuntimeCompatibilityOptions.Apply

<!--
public void Apply ();
-->


## -description

Applies the compatibility options to the runtime.

## -remarks

You must apply [RuntimeCompatibilityOptions](./runtimecompatibilityoptions.md) early in the process, before you call any other Windows App SDK APIs, or right after initializing the Windows App Runtime. You must set the options early, before the Windows App Runtime automatically locks the configuration for the lifetime of the process. Since the Windows App Runtime needs to run with a consistent configuration, it will lock the configuration when it needs to ensure that the configuration will no longer change. Calling **Apply** will also lock the configuration.

If the configuration has already been locked, then calling **Apply** will throw an **E_ILLEGAL_STATE_CHANGE** exception if the options differ from the locked configuration. It's okay to call **Apply** multiple times with the same configuration, such as if the process had initialized and used the Windows App Runtime earlier and is reinitializing for additional use.

## -see-also

## -examples
