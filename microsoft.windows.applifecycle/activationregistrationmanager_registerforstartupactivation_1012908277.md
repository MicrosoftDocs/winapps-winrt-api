---
-api-id: M:Microsoft.Windows.AppLifecycle.ActivationRegistrationManager.RegisterForStartupActivation(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppLifecycle.ActivationRegistrationManager.RegisterForStartupActivation(System.String,System.String)

<!--
public static void RegisterForStartupActivation (string taskId, string exePath);
-->

## -description

Registers to activate the app when when the app is started by the user logging into the Windows OS, either because of a registry key, or because of a shortcut in a well-known startup folder.

## -parameters

### -param taskId

An app-defined ID that can be used to unregister for startup activations later by using the [UnregisterForStartupActivation](activationregistrationmanager_unregisterforstartupactivation_10141772.md) method.

### -param exePath

The path to the executable to be activated. If you pass an empty string, the current exectuable will be activated by default. Typically this parameter is specified if the caller of this method is the app's installer rather than the app itself.

## -remarks

## -see-also

[UnregisterForStartupActivation](activationregistrationmanager_unregisterforstartupactivation_10141772.md)

## -examples
