---
-api-id: T:Microsoft.Windows.ApplicationModel.Background.BackgroundTaskBuilder
-api-type: winrt class
---

# Microsoft.Windows.ApplicationModel.Background.BackgroundTaskBuilder

<!--
public sealed class BackgroundTaskBuilder
-->

## -description

Represents a background task to register with the system.

## -remarks

For information on migrating UWP apps with background tasks to WinUI 3, see the Windows App SDK [Background task migration strategy](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/background-task-migration-strategy) guide.

This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Agile Objects in C++/WinRT](/windows/uwp/cpp-and-winrt-apis/agile-objects), [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx), and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

> [!NOTE]
> Internally, **BackgroundTaskBuilder** uses [ApplicationData.LocalSettings](uwp/api/windows.storage.applicationdata.localsettings) to store the background task registration information, so cleaning up the **LocalSettings** container may affect the function of previously registered background tasks. For more information on local settings, see [Store and retrieve settings and other app data](/windows/apps/design/app-settings/store-and-retrieve-app-data). 

## -see-also

[BackgroundTaskBuilder (WinRT)](/uwp/api/windows.applicationmodel.background.backgroundtaskbuilder)

## -examples
