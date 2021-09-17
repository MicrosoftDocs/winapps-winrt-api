---
-api-id: M:Microsoft.Windows.ApplicationModel.Resources.ResourceLoader.GetStringForUri(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.Resources.ResourceLoader.GetStringForUri(Windows.Foundation.Uri)

<!--
public string GetStringForUri (System.Uri resourceUri);
-->


## -description

Returns the most appropriate string value of a resource, specified by a Uniform Resource Identifier (URI) resource identifier, for the default [ResourceContext](resourcecontext.md) of the currently running app.

## -parameters
### -param resourceUri
A Uniform Resource Identifier (URI) that represents the resource to be retrieved.

## -returns
The most appropriate string value of the specified resource for the default [ResourceContext](resourcecontext.md).

## -remarks
Uniform Resource Identifier (URI) objects require a scheme to be identified. In this context, the ms-resource scheme must be specified in the Uniform Resource Identifier (URI) passed to the method.

### Errors

This method fails with an exception if the supplied Uniform Resource Identifier (URI) is for some other protocol, if the requested resource is not found, or if the requested resource is not a string.

## -examples
