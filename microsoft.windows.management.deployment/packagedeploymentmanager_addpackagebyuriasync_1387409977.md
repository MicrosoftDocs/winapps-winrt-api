---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.AddPackageOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.AddPackageOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> AddPackageByUriAsync (System.Uri packageUri, Microsoft.Windows.Management.Deployment.AddPackageOptions options);
-->


## -description

Adds a [Package](/uwp/api/windows.applicationmodel.package) (the main package) and any additional dependency packages, for the current user, using the specified deployment options.

## -parameters

### -param packageUri

The URI of the package to add. The URI can use the file URI scheme (file://) for local file paths and local network paths. HTTP and HTTPS protocols are also supported. Starting with Windows build 22556, The URI can point to a package or an App Installer file.

### -param options

The package deployment options for the operation.

## -returns

The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [PackageDeploymentProgress](packagedeploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

* You can use the [ExternalLocationURI](addpackageoptions_externallocationuri.md) property of the *options* parameter to specify the URI of an external disk location outside of the MSIX package where the package manifest can reference application content. For more information about this scenario and a related code sample, see [Grant package identity by packaging with external location](/windows/apps/desktop/modernize/grant-identity-to-nonpackaged-apps).

* You can use the [AllowUnsigned](addpackageoptions_allowunsigned.md) property of the *options* parameter to allow activation information from an executable in an unsigned package.

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [AddPackageOptions](addpackageoptions.md),[Grant package identity by packaging with external location](/windows/apps/desktop/modernize/grant-identity-to-nonpackaged-apps)

## -examples

A Fabrikam app installing Contoso's *Example* package from an `https:` source.

```csharp
void Install()
{
    var package = new Uri("https://contoso.com/example.msix");
    var packageDeploymentManager = PackageDeploymentManager.GetDefault();
    var options = new AddPackageOptions();
    var deploymentResult = await packageDeploymentManager.AddPackageByUriAsync(package, options);
    if (deplymentResult.Status == PackageDeploymentStatus.CompletedSuccess)
    {
        Console.WriteLine("OK");
    }
    else
    {
        Console.WriteLine("Error:{} ExtendedError:{} {}",
            deploymentResult.Error.HResult, deploymentResult.ExtendedError.HResult, deploymentResult.ErrorText);
    }
}
```
