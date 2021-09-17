---
-api-id: M:Microsoft.Windows.ApplicationModel.Resources.ResourceLoader.#ctor
-api-type: winrt constructor
---

# Microsoft.Windows.ApplicationModel.Resources.ResourceLoader.#ctor

<!--
public ResourceLoader ();
-->


## -description

Constructs a new [ResourceLoader](resourceloader.md) object for the "Resources" subtree of the currently running app's main [ResourceMap](resourcemap.md).

## -remarks

The empty constructor typically allows access relative to a resource file's resources (resources.resjson or resources.resw).

This constructor fails with an exception if the main [ResourceMap](resourcemap.md) does not have a "Resources" subtree.

## -see-also

## -examples


