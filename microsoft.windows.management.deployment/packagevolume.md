---
-api-id: T:Microsoft.Windows.Management.Deployment.PackageVolume
-api-type: winrt class
---

# Microsoft.Windows.Management.Deployment.PackageVolume

<!--
public sealed class PackageVolume
-->


## -description

Represents a [Package](/uwp/api/windows.applicationmodel.package) storage volume.

## -remarks

Packages are typically installed to a **PackageVolume**. For example, `C:\Program Files\WindowsApps` is the default package volume on a new Windows system. However, [RegisterPackageOptions.DeveloperMode](./registerpackageoptions_developermode.md), and [AddPackageOptions.StageInPlace](./addpackageoptions_stageinplace.md), and other options, can alter the typical behavior and install packages to a non-package-volume location.

## -see-also

[Windows.ApplicationModel.Package](/uwp/api/windows.applicationmodel.package)

## -examples
