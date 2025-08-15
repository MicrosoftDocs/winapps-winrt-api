---
-api-id: E:Microsoft.Windows.AppLifecycle.AppInstance.Activated
-api-type: winrt event
---

# Microsoft.Windows.AppLifecycle.AppInstance.Activated

<!--
public event System.EventHandler<Microsoft.Windows.AppLifecycle.AppActivationArguments> Activated;
-->

## -description

Raised for activations that have been redirected via [Microsoft.Windows.AppLifecycle.AppInstance.RedirectActivationToAsync](appinstance_redirectactivationtoasync_829149860.md).

## -remarks

This event is only raised for redirected activations. In all other cases, apps should use either [Microsoft.Windows.AppLifecycle.AppInstance.GetActivatedEventArgs](appinstance_getactivatedeventargs_19856196.md) or [Windows.ApplicationModel.AppInstance.GetActivatedEventArgs](/uwp/api/windows.applicationmodel.appinstance.getactivatedeventargs) to retrieve the arguments on activation.

## -see-also

## -examples
