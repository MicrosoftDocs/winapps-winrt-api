---
-api-id: N:Microsoft.Windows.ApplicationModel.DynamicDependency
-api-type: winrt namespace
---

# Microsoft.Windows.ApplicationModel.DynamicDependency

## -description

Provides the ability for unpackaged desktop apps to load [framework packages](/windows/apps/desktop/modernize/framework-packages/framework-packages-overview) other than the Windows App SDK framework package. After the specified framework package is loaded by an unpackaged desktop app, the app can call APIs provided by the framework package. 

## -remarks

Before you can use the APIs in this namespace in an unpackaged desktop app, you must first use the [Bootstrapper API](/windows/windows-app-sdk/api/win32/_bootstrap/) to load the Windows App SDK framework package. For more information, see [Use the Windows App SDK runtime for apps packaged with external location or unpackaged](/windows/apps/windows-app-sdk/use-windows-app-sdk-run-time).

## -see-also

[Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api), [MSIX framework packages and dynamic dependencies](/windows/apps/desktop/modernize/framework-packages/framework-packages-overview)

## -examples


