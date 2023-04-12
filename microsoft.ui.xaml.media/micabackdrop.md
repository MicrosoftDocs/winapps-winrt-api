---
-api-id: T:Microsoft.UI.Xaml.Media.MicaBackdrop
-api-type: winrt class
---

# Microsoft.UI.Xaml.Media.MicaBackdrop

<!--
public class MicaBackdrop : Microsoft.UI.Xaml.Media.SystemBackdrop
-->


## -description

Use this class to set a backdrop on a **Window**, **Popup**, or **FlyoutBase** (such as a **Flyout** or **MenuFlyout**).

**MicaBackdrop** isn't supported on all systems. Where it's not supported, a solid color will be used instead of the Mica effect.

## -remarks

## -see-also

## -examples

```xaml
<Window x:Class="MyApp.MainWindow">

    <Window.SystemBackdrop>
        <MicaBackdrop MicaKind="BaseAlt"/>
    </Window.SystemBackdrop>

</Window>
```
