---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageVolume.Repair
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageVolume.Repair

<!--
public void Repair ();
-->


## -description

Attempts to detect and correct invalidated package volume tracking information (and other similar conditions). **Repair** requires admin privilege.

## -remarks

A storage volume's mount point (a drive letter or a folder) can change over time. So, to mitigate that, Windows pairs a **PackageVolume** with the underlying storage volume's media ID. That way the **PackageVolume** can always be identified.

Say, for example, that you insert a USB flash key, and its mount point is `E:`. Then you remove the USB flash key, and later reinsert it, and this time it's mounted as `K:`. The **PackageVolume** is now recognized at `K:` because it (volume `K:`) has the media ID that's associated with the **PackageVolume**.

But it's possible for this tracking information to be invalidated. For example, you back up a drive's content, replace the drive with a new one, and then restore the content. The packages installed on that drive's **PackageVolume**(s) aren't recognized by Windows because the new drive has a different media ID. **Repair** attempts to detect and correct that and other similar conditions.

You can call [PackageVolume.IsRepairNeeded](./packagevolume_isrepairneeded_829404177.md) to determine whether the **PackageVolume** is in need of repair.

## -see-also

[Windows.ApplicationModel.Package](/uwp/api/windows.applicationmodel.package)

## -examples

A Fabrikam app checks whether a [PackageVolume](./packagevolume.md) is OK and, if not, prompts the user to confirm that the app should proceed to repair the **PackageVolume**.

```csharp
void CheckAndFixPackageVolume(string packageStorePath)
{
    var packageVolume = PackageVolume.FindPackageVolumeByPath(packageStorePath);
    if (packageVolume.IsRepairNeeded())
    {
        bool ok = PromptUserForConfirmation();
        if (!ok)
        {
            return;
        }
    }
    packageVolume.Repair();
}
```
