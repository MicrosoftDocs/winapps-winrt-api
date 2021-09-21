---
-api-id: M:Microsoft.Windows.AppLifecycle.AppInstance.FindOrRegisterForKey(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppLifecycle.AppInstance.FindOrRegisterForKey(System.String)

<!--
public static Microsoft.Windows.AppLifecycle.AppInstance FindOrRegisterForKey (string key);
-->

## -description

Registers an app instance with the platform, or finds an existing instance if another instance has already registered this key.

## -parameters

### -param key

A non-empty string as a key for the instance.

## -returns

An app instance that represents the first app that registered the key. The caller can determine whether that instance is the current instance.

## -remarks

Whereas the [FindOrRegisterInstanceForKey](/uwp/api/windows.applicationmodel.appinstance.findorregisterinstanceforkey) method in the Windows OS is specific to instance redirection, this method in the Windows App SDK allows for the app to register a key for any reason.

After an app has registered with the platform, it is returned when other instances query for app instances.

An app instance can register multiple times with different keys. The system cache maintains one row per instance, therefore, the key is overwritten.

## -see-also

[UnregisterKey](appinstance_unregisterkey_604376675.md), [App instancing](/windows/apps/windows-app-sdk/applifecycle/applifecycle-instancing)

## -examples
