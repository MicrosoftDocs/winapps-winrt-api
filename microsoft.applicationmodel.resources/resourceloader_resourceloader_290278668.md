---
-api-id: M:Microsoft.ApplicationModel.Resources.ResourceLoader.#ctor(System.String)
-api-type: winrt constructor
---

<!-- Method syntax
public ResourceLoader(System.String fileName)
-->

# Microsoft.ApplicationModel.Resources.ResourceLoader.ResourceLoader

## -description

Constructs a new [ResourceLoader](resourceloader.md) object for the specified [ResourceMap](resourcemap.md).

## -parameters

### -param fileName

The path and name of the file that should be used for the current context.

## -remarks

This constructor is typically used to load resources from a specific PRI file. For example, `new ResourceLoader("MyResources.pri")` loads from the specified file relative to the app's working directory.

## -examples

## -see-also
