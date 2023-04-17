---
-api-id: T:Microsoft.Windows.AppLifecycle.ExtendedActivationKind
-api-type: winrt enum
---

# Microsoft.Windows.AppLifecycle.ExtendedActivationKind

<!--
public enum ExtendedActivationKind
-->

## -description

Defines values that represent activation types.

## -enum-fields

### -field Launch:0

The user launched the app or tapped a content tile.

### -field Search:1

The user wants to search with the app.

### -field ShareTarget:2

The app is activated as a target for share operations.

### -field File:3

An app launched a file whose file type this app is registered to handle.

### -field Protocol:4

An app launched a URI whose scheme name this app is registered to handle.

### -field FileOpenPicker:5

The user wants to pick files that are provided by the app.

### -field FileSavePicker:6

The user wants to save a file and selected the app as the location.

### -field CachedFileUpdater:7

The user wants to save a file that the app provides content management for.

### -field ContactPicker:8

The user wants to pick contacts.

### -field Device:9

The app handles AutoPlay.

### -field PrintTaskSettings:10

The app handles print tasks.

### -field CameraSettings:11

The app captures photos or video from an attached camera.

### -field RestrictedLaunch:12

The user launched the restricted app.

### -field AppointmentsProvider:13

The user wants to manage appointments that are provided by the app.

### -field Contact:14

The user wants to handle calls or messages for the phone number of a contact that is provided by the app.

### -field LockScreenCall:15

The app launches a call from the lock screen. If the user wants to accept the call, the app displays its call UI directly on the lock screen without requiring the user to unlock. A lock-screen call is a special type of launch activation.

### -field VoiceCommand:16

The app was activated as the result of a voice command.

### -field LockScreen:17

The app was activated as the lock screen.

### -field WebAccountProvider:1006

The app was activated by a web account provider.

### -field ComponentUI:1007

Reserved for system use.

### -field ProtocolForResults:1009

The app was launched by another app with the expectation that it will return a result back to the caller.

### -field ToastNotification:1010

The app was activated when a user tapped on the body of a toast notification or performed an action inside a toast notification.

### -field Print3DWorkflow:1011

This app was launched by another app to provide a customized printing experience for a 3D printer.

### -field DialReceiver:1012

This app was launched by another app on a different device by using the DIAL protocol.

### -field DevicePairing:1013

This app was activated as a result of pairing a device.

### -field UserDataAccountsProvider:1014

The app was launched to handle the user interface for account management. In circumstances where the system would have shown the default system user interface, it instead has invoked your app with the UserDataAccountProvider contract. The activation payload contains information about the type of operation being requested and all the information necessary to replicate the system-provided user interface. This activation kind is limited to 1st party apps. To use this field, you must add the **userDataAccountsProvider** capability in your app's package manifest. For more info see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

### -field FilePickerExperience:1015

Reserved for system use.

### -field ContactPanel:1017

The app was launched from the **My People** UI.

### -field LockScreenComponent:1016

Reserved for system use.

### -field PrintWorkflowForegroundTask:1018

The app was activated because the user is printing to a printer that has a Print Workflow App associated with it which has requested user input.

### -field GameUIProvider:1019

The app was activated because it was launched by the OS due to a game's request for Xbox-specific UI.

### -field StartupTask:1020

The app was activated because the app is specified to launch at system startup or user log-in.

### -field CommandLineLaunch:1021

The app was launched from the command line.

### -field BarcodeScannerProvider:1022

The app was activated as a barcode scanner provider.

### -field PrintSupportJobUI: 1023

The app was activated as print support job UI.

### -field PrintSupportSettingsUI: 1024

The app was activated as print support settings UI.

### -field PhoneCallActivation: 1025

The app was activated by a phone call.

### -field VpnForeground: 1026

The app was activated as a VPN app in the foreground.

## -remarks

This enum is used by the [Kind](appactivationarguments_kind.md) property.

## -see-also

[Kind](appactivationarguments_kind.md), [ActivationRegistrationManager](activationregistrationmanager.md), [Rich activation with the app lifecycle API](/windows/apps/windows-app-sdk/applifecycle/applifecycle-rich-activation)

## -examples


