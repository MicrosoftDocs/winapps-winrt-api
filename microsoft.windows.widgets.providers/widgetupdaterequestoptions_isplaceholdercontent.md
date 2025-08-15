---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.IsPlaceholderContent
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.IsPlaceholderContent

<!--
public System.Nullable<bool> IsPlaceholderContent { get; set; }
-->


## -description

Gets or sets a value indicating whether the content of the update is placeholder content.

## -property-value

True if the content of the update is placeholder content. If the value is set to null, the previous value is retained.

## -remarks

Widget providers can set this value to true to indicate that the content they are providing is not customized or actionable. For example, a weather widget may supply placeholder content of a weather map for a default location until the user customizes the widget to show the weather map for a particular location. The widget host may use this information to prioritize widgets with custom content over widgets placeholder content.

## -see-also

## -examples


