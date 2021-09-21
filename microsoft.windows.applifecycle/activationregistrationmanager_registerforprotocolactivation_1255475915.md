---
-api-id: M:Microsoft.Windows.AppLifecycle.ActivationRegistrationManager.RegisterForProtocolActivation(System.String,System.String,System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppLifecycle.ActivationRegistrationManager.RegisterForProtocolActivation(System.String,System.String,System.String,System.String)

<!--
public static void RegisterForProtocolActivation (string scheme, string logo, string displayName, string exePath);
-->

## -description

Registers to activate the app when the specified URI scheme is executed via [ShellExecute](/windows/win32/api/shellapi/nf-shellapi-shellexecuteexw), [Launcher.LaunchUriAsync](/uwp/api/windows.system.launcher.launchuriasync), or the command-line.

## -parameters

### -param scheme

The URI scheme to register for activations, such as `https`.

### -param logo

The path to the image or resource used by Windows for the URI scheme. For packaged apps, this parameter is a package-relative path to an image file. For unpackaged, this parameter is a literal filepath to a binary file (DLL, EXE) plus a resource index.

### -param displayName

This display name used by Windows for the URI scheme.

### -param exePath

The path to the executable to be activated. If you pass an empty string, the current exectuable will be activated by default. Typically this parameter is specified if the caller of this method is the app's installer rather than the app itself.

## -remarks

## -see-also

[UnregisterForProtocolActivation](activationregistrationmanager_unregisterforprotocolactivation_1644306636.md)

## -examples
