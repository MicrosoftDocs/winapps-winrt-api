---
-api-id: T:Microsoft.Windows.Widgets.Providers.IWidgetProvider
-api-type: winrt interface
---

# Microsoft.Windows.Widgets.Providers.IWidgetProvider

<!--
public interface IWidgetProvider
-->


## -description

This interface is implemented by Windows Widget providers to receive callbacks from the widget host for widget lifetime events.

## -remarks

This interface be implemented as an Out-of-process COM Server. The lifetime of a widget provider is independent of its widgets' lifetimes; a widget provider can be activated and released by the widget manager at any time. Multiple providers for the same provider app will be run in a shared process. Providers from different provider apps will run in separate processes.

Objects passed into the callback methods of the **IWidgetProvider** interface are only guaranteed to be valid within the callback. You should not store references to these objects because their behavior outside of the context of the callback is undefined.


For an overview of Windows Widgets, see [Widgets overview](/windows/apps/design/widgets/). For information about developing a widget provider, see [Widget service providers](/windows/apps/develop/widgets/widget-service-providers).

## -see-also

## -examples


