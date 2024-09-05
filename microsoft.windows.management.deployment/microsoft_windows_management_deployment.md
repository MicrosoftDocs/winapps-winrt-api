---
-api-id: N:Microsoft.Windows.Management.Deployment
-api-type: winrt namespace
---

# Microsoft.Windows.Management.Deployment

## -description

This namespace provides MSIX package management APIs comparable to those in the [Windows.Management.Deployment](https://learn.microsoft.com/uwp/api/windows.management.deployment) namespace, but with additional functionality, improved developer experience, and performance optimizations.

These Windows Runtime (WinRT) APIs allow you to deploy and manage software as MSIX packages. You can install, update, uninstall, enumerate, and otherwise manage packages. Here are the scenarios that the APIs focus on:

* Stage a package
* Register a package
* Add/update a package
* Remove a package
* Repair a package
* Reset a package
* Provision a package
* Deprovision a package

Additional functionality includes:

* **IsReadyXxx**. Determine whether a package is ready for use.
* **EnsureReady**. Determine whether a package is ready for use and, if not, make it so.
* **IsPackageRegistrationPending**. Determine whether there's an update waiting to register.
* **PackageSets**. Batch operations.
* **PackageRuntimeManager**. Batch operations for use at runtime via dynamic dependencies.
* Usability. Quality-of-Life enhancements.

### API structure

Methods to drive deployment activity typically follow the pattern:

    <verb>Package[Set][By<Type>][Suffix]Async(target, options)

The following verbs are supported:

* Is...Ready\[OrNewerAvailable]
* Ensure...Ready
* Add
* Stage
* Register
* Remove
* Repair
* Reset
* Provision
* Deprovision

Those methods accept their target package(s) as their first parameter. That parameter can be various types of information including:

* Filename
* Path
* PackageFamilyName
* PackageFullName
* Uri

> ![NOTE]
> Methods with a target of a URI are named ...ByUri....

> ![NOTE]
> Methods with a target of a PackageFamilyName are named ...ByPackageFamilyName....

> ![NOTE]
> Methods with a target of a PackageFullName are named ...ByPackageFullName....

> ![NOTE]
> Methods with no ...By\<Type>... qualifier accept a string that can contain one or more types
of identifiers. Those can vary for different verbs. See the API documentation for the
specific target types supported by each method.

These methods accept options as a matching `<verb>Package[Set]Options` type; for example, `AddPackageAsync(string packageUri, AddPackageOptions options)`.

The following table shows the supported permutations of verbs and targets:

|Verb                    | Path   | Filename | PackageFamilyName | PackageFullName | file:  | http(s): | ms-uup: | PackageSet |
|------------------------|:------:|:--------:|:-----------------:|:---------------:|:------:|:--------:|:-------:|:----------:|
|IsReady                 |   X    |    X     |       OS/WAS      |       WAS       |   X    |    X     |  WAS    |    WAS     |
|IsReadyOrNewerAvailable |   X    |    X     |       OS/WAS      |       WAS       |   X    |    X     |  WAS    |    WAS     |
|EnsureReady             |   X    |    X     |         X         |        X        |   X    |    X     |  WAS    |    WAS     |
|Add                     | OS/WAS |    X     |         X         |        X        | OS/WAS |  OS/WAS  | OS/WAS  |    WAS     |
|Stage                   | OS/WAS |    X     |         X         |        X        | OS/WAS |  OS/WAS  | OS/WAS  |    WAS     |
|Register                |  WAS   |  OS/WAS  |       OS/WAS      |      OS/WAS     | OS/WAS |    X     | OS/WAS  |    WAS     |
|Remove                  |   X    |    X     |        WAS        |      OS/WAS     |   X    |    X     | OS/WAS  |    WAS     |
|Repair                  |   X    |    X     |        WAS        |       WAS       |   X    |    X     |  WAS    |    WAS     |
|Reset                   |   X    |    X     |        WAS        |       WAS       |   X    |    X     |  WAS    |    WAS     |
|IsProvisioned           |   X    |    X     |       OS/WAS      |        X        |   X    |    X     |  WAS    |    WAS     |
|Provision               |   X    |    X     |       OS/WAS      |        X        |   X    |    X     |  WAS    |    WAS     |
|Deprovision             |   X    |    X     |       OS/WAS      |        X        |   X    |    X     |  WAS    |    WAS     |

Legend:

* **OS** = Supported by Windows (OS) APIs in the **Windows.Management.Deployment.PackageManager** class.
* **WAS** = Supported by Windows App SDK APIs in the **Microsoft.Windows.Management.Deployment.PackageDeploymentManager** class.
* **X** = Not supported

### Usability

The package management APIs in the Windows App SDK (**Microsoft.Windows.Management.Deployment**) provide several quality-of-life enhancements over the package management APIs in [Windows.Management.Deployment](https://learn.microsoft.com/uwp/api/windows.management.deployment) (for example, **PackageManager**). These include:

* **PackageManager.AddPackageByUriAsync** fails, returning **ERROR_INSTALL_PACKAGE_DOWNGRADE**, if a newer version of the package is already installed. But [PackageDeploymentManager.AddPackageByUriAsync](./packagedeploymentmanager_addpackagebyuriasync_1387409977.md) succeeds because it treats the request as "install this package *or a higher version*", in the way that dependencies and other package references are routinely handled.
* **PackageManager.AddPackageByUriAsync** fails, returning **ERROR_PACKAGE_ALREADY_EXISTS**, if that exact version of the package is already installed. [PackageDeploymentManager.AddPackageByUriAsync](./packagedeploymentmanager_addpackagebyuriasync_1387409977.md) succeeds because the requested package is installed.
* Many **PackageManager** operations accept a target package as a file, but require it expressed as a **Uri**. [PackageDeploymentManager](./packagedeploymentmanager.md) provides overrides also accepting it as a **String**.
* **PackageManager.RemovePackageByFullNameAsync** fails if the specified package isn't found. [PackageDeploymentManager](./packagedeploymentmanager.md) succeeds because the requested package isn't present at the end of the operation.
  * This is because of the core deployment principle that it doesn't matter the previous state of the system; only that the desired end state is achieved.
* **PackageManager** methods accept inconsistent (and often inconvenient) permutations of expressing a target package. For example, **PackageManager** supports removing a package by package full name, but not by package family name. [PackageDeploymentManager](./packagedeploymentmanager.md) provides a richer API accepting additional identifiers.

### Platform support

These APIs are available only on Windows 10, version 2004 (10.0; Build 19041) and later.

A subset of functionality is available on newer releases. For example, [AddPackageOptions.ExpectedDigests](./addpackageoptions_expecteddigests.md) requires Windows 11, version 22H2 (10.0; Build 22621) or later. Any functionality requiring a release of windows newer than the Windows 10, version 2004 (10.0; Build 19041) baseline has affordances to detect at runtime whether the current platform supports the feature, for example:

```csharp
var options = new AddPackageOptions();
if (options.IsLimitToExistingPackagesSupported)
{
    options.LimitToExistingPackages = true;
}
```

## -remarks

## -see-also

## -examples
