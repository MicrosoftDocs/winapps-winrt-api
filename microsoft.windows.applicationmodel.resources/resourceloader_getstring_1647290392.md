---
-api-id: M:Microsoft.Windows.ApplicationModel.Resources.ResourceLoader.GetString(System.String)
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.Resources.ResourceLoader.GetString(System.String)

<!--
public string GetString (string resourceId);
-->


## -description

Returns the most appropriate string value of a resource, specified by resource identifier.

## -parameters
### -param resourceId
The resource identifier of the resource to be resolved.

> [!NOTE]
> The resource identifier is treated as a Uniform Resource Identifier (URI) fragment, subject to Uniform Resource Identifier (URI) semantics. For example, **getString** ("Caption%20") is treated as **getString** ("Caption "). Do not use "?" or "#" in resource identifiers, as they terminate the resource path. For example, "Foo?3" is treated as "Foo".

## -returns
The most appropriate string value of the specified resource for the default [ResourceContext](resourcecontext.md).

## -remarks

## -examples
See the example in [ResourceLoader](resourceloader.md).

## -see-also
[ResourceContext](resourcecontext.md)
