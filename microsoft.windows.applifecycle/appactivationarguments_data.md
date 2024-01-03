---
-api-id: P:Microsoft.Windows.AppLifecycle.AppActivationArguments.Data
-api-type: winrt property
---

# Microsoft.Windows.AppLifecycle.AppActivationArguments.Data

<!--
public object Data { get; }
-->

## -description

Gets the data payload for a registered activation.

## -property-value

The data payload for a registered activation. For more information about the type of this object, see the remarks.

## -remarks

The value of this property has one of the following data types, depending on the activation type specified by the [Kind](appactivationarguments_kind.md) property.

| Activation kind | Data type |
|-----------------|-----------------------|
| `Launch` | [ILaunchActivatedEventArge](/uwp/api/windows.applicationmodel.activation.ilaunchactivatedeventargs) |
| `File` | [IFileActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.ifileactivatedeventargs) |
| `Protocol` | [IProtocolActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.iprotocolactivatedeventargs) |
| `StartupTask` | [IStartupTaskActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.istartuptaskactivatedeventargs) |

The **Kind** is limited to those activation kinds that are supported in the Windows App SDK. Currently, those are **Launch**, **File**, **Protocol**, and **StartupTask**.

## -see-also

[Kind](appactivationarguments_kind.md)

## -examples
