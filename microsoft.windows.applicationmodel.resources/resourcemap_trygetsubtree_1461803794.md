---
-api-id: M:Microsoft.Windows.ApplicationModel.Resources.ResourceMap.TryGetSubtree(System.String)
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.Resources.ResourceMap.TryGetSubtree(System.String)

<!--
public Microsoft.Windows.ApplicationModel.Resources.ResourceMap TryGetSubtree (string reference);
-->


## -description

Tries to find a [ResourceMap](resourcemap.md) that represents a part of another ResourceMap, typically used to access a particular resource file within an app package.

This method finds subtree, ancestor, sibling and cousin maps to this resource map, as well as top-level maps. It returns the resource map represented by a given resource map identifier, relative to this resource map. This method is typically used to make simpler references to a particular subset of resources, such as a single resource file, or a directory of files.

## -parameters

### -param reference

A resource map identifier that identifies the root of the new subtree. For details, see the remarks for [ResourceMap](resourcemap.md) class.

## -returns

The subtree [ResourceMap](resourcemap.md). If the specified resource map identifier is not found, this method returns **null**.

## -remarks

## -see-also

## -examples


