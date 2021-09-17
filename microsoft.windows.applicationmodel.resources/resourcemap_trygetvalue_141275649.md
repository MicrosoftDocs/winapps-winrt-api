---
-api-id: M:Microsoft.Windows.ApplicationModel.Resources.ResourceMap.TryGetValue(System.String,Microsoft.Windows.ApplicationModel.Resources.ResourceContext)
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.Resources.ResourceMap.TryGetValue(System.String,Microsoft.Windows.ApplicationModel.Resources.ResourceContext)

<!--
public Microsoft.Windows.ApplicationModel.Resources.ResourceCandidate TryGetValue (string resource, Microsoft.Windows.ApplicationModel.Resources.ResourceContext context);
-->


## -description

Tries to find the most appropriate candidate for a resource that is specified by a resource identifier for the supplied context.

## -parameters

### -param resource

A resource specified as a name or reference. For details, see the remarks for [ResourceMap](resourcemap.md) class.

### -param context

The context for which to select the most appropriate candidate.

## -returns

A [ResourceCandidate](resourcecandidate.md) that describes the most appropriate candidate. If the specified resource identifier is not found, this method returns **null**.

## -remarks

Some resources are loaded according to the scale of the view where they will be displayed, and different views within an app might be displayed on different devices with different scales. Scale is a per-view characteristic.

Since the **TryGetValue** method selects the best candidate for the specified resource in relation to a runtime context, and since the scale qualifier of a [ResourceContext](resourcecontext.md) depends on the associated view, **TryGetValue** should always be called with a [ResourceContext](resourcecontext.md) object obtained from the view in which the resource will be used.

## -see-also

## -examples


