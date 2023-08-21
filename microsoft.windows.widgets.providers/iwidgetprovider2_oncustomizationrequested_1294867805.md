---
-api-id: M:Microsoft.Windows.Widgets.Providers.IWidgetProvider2.OnCustomizationRequested(Microsoft.Windows.Widgets.Providers.WidgetCustomizationRequestedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.IWidgetProvider2.OnCustomizationRequested(Microsoft.Windows.Widgets.Providers.WidgetCustomizationRequestedArgs)

<!--
public void OnCustomizationRequested (Microsoft.Windows.Widgets.Providers.WidgetCustomizationRequestedArgs customizationRequestedArgs);
-->


## -description

Raised when the user has requested widget customization through the widget host UI.

## -parameters

### -param customizationRequestedArgs

A [WidgetCustomizationRequestedArgs](xref:Microsoft.Windows.Widgets.Providers.WidgetCustomizationRequestedArgs) object providing access to the widget context and custom state.

## -remarks

To receive this event, you must set the **IsCustomizable** attribute to "true" in the **Definition** element for your widget in your widget provider app's package manifest file. For more information, see [Widget provider package manifest XML format](/windows/apps/develop/widgets/widget-provider-manifest).

## -see-also

## -examples


