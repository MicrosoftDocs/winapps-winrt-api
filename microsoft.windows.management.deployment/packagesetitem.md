---
-api-id: T:Microsoft.Windows.Management.Deployment.PackageSetItem
-api-type: winrt class
---

# Microsoft.Windows.Management.Deployment.PackageSetItem

<!-
public sealed class PackageSetItem
->


## -description

Represents a package in a [PackageSet](./packageset.md).

## -remarks

This table describes the properties of **PackageSetItem** that are used by various verbs:

|Verb | MinVersion | PackageFamilyName | PackageUri | ProcessorArchitectureFilter |
|-|:-:|:-:|:-:|:-:|
|IsReady | Required, but defaults | Required | N/A | Optional |
|IsReadyOrNewerAvailable | Required, but defaults | Required | N/A | Optional |
|EnsureReady | Required, but defaults | Required | Required, but defaults | Optional |
|Add | N/A | N/A | Required, but defaults | N/A |
|Stage | N/A | N/A | Required, but defaults | N/A |
|Register | N/A | N/A | Required, but defaults | N/A |
|Remove | N/A | Required, but defaults (if no PackageUri) | Optional | N/A |
|Repair | N/A | Required, but defaults (if no PackageUri) | Optional | N/A |
|Reset | N/A | Required, but defaults (if no PackageUri) | Optional | N/A |
|IsProvisioned | N/A | Required, but defaults | Optional | N/A |
|Provision | N/A | Required, but defaults (if no PackageUri) | Optional | N/A |
|Deprovision | N/A | Required, but defaults (if no PackageUri) | Optional | N/A |

**Legend:**

* **Required** = The property is required.
* **Required, but defaults** = The property is required; but if not specified, then the default value is used.
* **Optional** = The property is used if it's specified.
* **N/A** = Not applicable. The property isn't used.

## -see-also

## -examples
