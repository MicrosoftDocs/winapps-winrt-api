---
-api-id: M:Microsoft.Windows.AppLifecycle.ActivationRegistrationManager.RegisterForFileTypeActivation(System.String[],System.String,System.String,System.String[],System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppLifecycle.ActivationRegistrationManager.RegisterForFileTypeActivation(System.String[],System.String,System.String,System.String[],System.String)

<!--
public static void RegisterForFileTypeActivation (string[] supportedFileTypes, string logo, string displayName, string[] supportedVerbs, string exePath);
-->


## -description

Registers to activate the app when the specified file type is opened via [ShellExecute](/windows/win32/api/shellapi/nf-shellapi-shellexecuteexw), [Launcher.LaunchFileAsync](/uwp/api/windows.system.launcher.launchfileasync), or the command-line.

## -parameters

### -param supportedFileTypes

One or more supported file types, specified by the file extension including the leading `.`, such as `.docx`.

### -param logo

The path to the image or resource used by Windows for the file type. For packaged apps, this parameter is a package-relative path to an image file. For unpackaged, this parameter is a literal filepath to a binary file (DLL, EXE) plus a resource index.

### -param displayName

This display name used by Windows for the file type.

### -param supportedVerbs

Zero or more app-defined verbs. Each verb is added to the **File Explorer** context menu when a registered file is right-clicked, and the selected verb is passed to the app as the [IFileActivatedEventArgs.Verb](/uwp/api/windows.applicationmodel.activation.ifileactivatedeventargs.verb) property.

### -param exePath

The path to the executable to be activated. If you pass an empty string, the current exectuable will be activated by default. Typically this parameter is specified if the caller of this method is the app's installer rather than the app itself.

## -remarks

[UnregisterForFileTypeActivation](activationregistrationmanager_unregisterforfiletypeactivation_236201725.md)

## -see-also

## -examples


