---
-api-id: P:Microsoft.Windows.Management.Deployment.PackageDeploymentResult.ExtendedError
-api-type: winrt property
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentResult.ExtendedError

<!--
public System.Exception ExtendedError { get; }
-->


## -description

Gets the extended error code, which you can use to distinguish a specific error condition (which needs to be handled differently) from the general error indicated by the return code.

## -property-value

The extended error code.

## -remarks

The extended error code might provide a more specific reason for the failure that caused the general error. Also, it usually corresponds directly to the specific message in [ErrorText](./packagedeploymentresult_errortext.md).

## -see-also

## -examples
