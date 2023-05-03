---
-api-id: T:Microsoft.Windows.System.EnvironmentManager
-api-type: winrt class
---

# Microsoft.Windows.System.EnvironmentManager

<!--
public sealed class EnvironmentManager
-->

## -description

A class for reading and writing environment variables.

## -remarks

The API adds tracking of environment variables, which is used to cleanly uninstall environment artifacts written by the app. Tracking also enables restoration of previously written tracked variables when an app is uninstalled.

For packaged apps, a variable that is created or modified with the new API will be tracked. Variables that are not created or modified with the new API continue not to be tracked.

The platform can track uninstall for packaged apps, but not for unpackaged apps. For unpackaged apps, the app's own uninstaller is relied upon to clean up environment variables. An unpackaged app can provide its own cleanup on uninstall, by calling the [SetEnvironmentVariable](environmentmanager_setenvironmentvariable_850184535.md) API with an empty string for the value, or [RemoveFromPath](environmentmanager_removefrompath_196614567.md) - but this would remove the path from the **PATH** variable, it would not revert it to its previous state.

When uninstalling a package, environment cleanup and restoration is triggered.

1. Any variables created by the app are deleted.
1. Where a variable was not originally created by the app, but was last modified by the app, its value will be restored to the last value set by another app.
1. Variable changes made by mechanisms other than using these APIs (eg, the user making manual changes via RegEdit) will be accounted for.

>[!NOTE]
>An app setting a variable to an empty string is effectively removing the variable, and no new value should be set.

Some other things to note:

- The system does not use a registry listener. So, the only way it will know if something has changed is if the caller uses these APIs to create or modify variables, or if an app that has done so is now uninstalled.
- The system won’t track changes that are made outside the API; and it won’t track uninstall of unpackaged apps.
- When a packaged app is uninstalled, any variable it created will be deleted, regardless of any other changes (tracked or untracked) made to that variable during its lifetime.
- If a variable was not created with these APIs, then it will not be deleted when a packaged app is uninstalled – instead, the last change made by that app (via the APIs) will be reverted.
- *A-la-carte apps* have identity but are not installed the way packaged apps are installed. There is no reliable way to detect when an a-la-carte app is uninstalled. Therefore, while a variable created/written by an a-la-carte app will be tracked, it will not be cleaned up when the app is uninstalled.

## -see-also

## -examples
