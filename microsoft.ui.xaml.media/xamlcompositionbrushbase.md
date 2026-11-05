---
-api-id: T:Microsoft.UI.Xaml.Media.XamlCompositionBrushBase
-api-type: winrt class
---

<!-- Class syntax.
public class XamlCompositionBrushBase : Brush, Brush
-->

# Microsoft.UI.Xaml.Media.XamlCompositionBrushBase

## -description
Provides a base class used to create XAML brushes that paint an area with a [CompositionBrush](../microsoft.ui.composition/compositionbrush.md).

## -remarks
You can use XamlCompositionBrushBase to create custom brushes. 

For example, it can be used to create a brush that applies [effects](/windows/apps/develop/composition/composition-effects) to XAML UIElements using a [CompositionEffectBrush](../microsoft.ui.composition/compositioneffectbrush.md), or a [SceneLightingEffect](../microsoft.ui.composition.effects/scenelightingeffect.md) that controls the reflective properties of elements when being lit by a [XamlLight](xamllight.md), or a whole series of effects chained together to produce something more complex.

When creating a brush, it's usually a good practice to delay creating a [CompositionBrush](../microsoft.ui.composition/compositionbrush.md) and any related resources until the brush is being used. The [OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) method is called when a brush is first used on screen to paint an element, so you can override [OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) to safely create resources only when they're needed. This means you can create an instance of a brush in a ResourceDictionary then reference that brush resource later from other parts of UI definitions and only pay the cost of creating composition resources when the brush is actually in use.

It's also a good practice to dispose of composition resources when they're no longer in use. The [OnDisconnected](xamlcompositionbrushbase_ondisconnected_510183142.md) method is called when a brush instance is no longer in use anywhere on the screen, so you can override [OnDisconnected](xamlcompositionbrushbase_ondisconnected_510183142.md) to safely dispose of resources. If the brush is later used again after being disconnected then [OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) will be called again.

## -examples

This example shows the definition for a custom brush that draws a blurred copy of whatever is behind a UIElement where the brush is applied using a [Win2D](https://github.com/Microsoft/Win2D) blur effect and a [CompositionBackdropBrush](../microsoft.ui.composition/compositionbackdropbrush.md):

```csharp
public sealed class BackdropBlurBrush : XamlCompositionBrushBase
{
    public static readonly DependencyProperty BlurAmountProperty = DependencyProperty.Register(
        "BlurAmount",
        typeof(double),
        typeof(BackdropBlurBrush),
        new PropertyMetadata(0.0, new PropertyChangedCallback(OnBlurAmountChanged)
        )
    );

    public double BlurAmount
    {
        get { return (double)GetValue(BlurAmountProperty); }
        set { SetValue(BlurAmountProperty, value); }
    }

    private static void OnBlurAmountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var brush = (BackdropBlurBrush)d;
        // Unbox and set a new blur amount if the CompositionBrush exists.
        brush.CompositionBrush?.Properties.InsertScalar("Blur.BlurAmount", (float)(double)e.NewValue);            
    }

    public BackdropBlurBrush()
    {
    }

    protected override void OnConnected()
    {
        // Delay creating composition resources until they're required.
        if (CompositionBrush == null)
        {
            var compositor = CompositionTarget.GetCompositorForCurrentThread();
            var backdrop = compositor.CreateBackdropBrush();

            // Use a Win2D blur affect applied to a CompositionBackdropBrush.
            var graphicsEffect = new GaussianBlurEffect
            {
                Name = "Blur",
                BlurAmount = (float)this.BlurAmount,
                Source = new CompositionEffectSourceParameter("backdrop")
            };

            var effectFactory = compositor.CreateEffectFactory(graphicsEffect, new[] { "Blur.BlurAmount" });
            var effectBrush = effectFactory.CreateBrush();

            effectBrush.SetSourceParameter("backdrop", backdrop);

            CompositionBrush = effectBrush;
        }
    }

    protected override void OnDisconnected()
    {
        // Dispose of composition resources when no longer in use.
        if (CompositionBrush != null)
        {
            CompositionBrush.Dispose();
            CompositionBrush = null;
        }
    }
}
```

For the [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt) code example below, you'll need to add a **Midl File (.idl)** file to your project.

```idl
// BackdropBlurBrush.idl
namespace MyApp
{
    [default_interface]
    runtimeclass BackdropBlurBrush : Microsoft.UI.Xaml.Media.XamlCompositionBrushBase
    {
        BackdropBlurBrush();
        static Microsoft.UI.Xaml.DependencyProperty BlurAmountProperty{ get; };
        Double BlurAmount;
    }
}
```

```cppwinrt
// pch.h
// You'll need to install the Microsoft Win2D NuGet package for this code example.
#include <winrt/Microsoft.Graphics.Canvas.Effects.h>
#include <winrt/Windows.Graphics.Effects.h>

// BackdropBlurBrush.h.
struct BackdropBlurBrush : BackdropBlurBrushT<BackdropBlurBrush>
{
    BackdropBlurBrush() = default;

    static Microsoft::UI::Xaml::DependencyProperty BlurAmountProperty() { return m_blurAmountProperty; }

    double BlurAmount()
    {
        return winrt::unbox_value<double>(GetValue(m_blurAmountProperty));
    }

    void BlurAmount(double value)
    {
        SetValue(m_blurAmountProperty, winrt::box_value(value));
    }

    void OnConnected();
    void OnDisconnected();

    static void OnBlurAmountChanged(Microsoft::UI::Xaml::DependencyObject const& d, Microsoft::UI::Xaml::DependencyPropertyChangedEventArgs const& e);

private:
    static Microsoft::UI::Xaml::DependencyProperty m_blurAmountProperty;
};

// WindowBlurBrush.cpp.
Microsoft::UI::Xaml::DependencyProperty BackdropBlurBrush::m_blurAmountProperty =
    Microsoft::UI::Xaml::DependencyProperty::Register(
        L"BlurAmount",
        winrt::xaml_typename<double>(),
        winrt::xaml_typename<MyApp::BackdropBlurBrush>(),
        Microsoft::UI::Xaml::PropertyMetadata{ winrt::box_value(0.), Microsoft::UI::Xaml::PropertyChangedCallback{ &BackdropBlurBrush::OnBlurAmountChanged } }
);

void BackdropBlurBrush::OnBlurAmountChanged(Microsoft::UI::Xaml::DependencyObject const& d, Microsoft::UI::Xaml::DependencyPropertyChangedEventArgs const& e)
{
    auto brush{ d.as<MyApp::BackdropBlurBrush>() };
    // Unbox and set a new blur amount if the CompositionBrush exists.
    if (brush.CompositionBrush() != nullptr)
    {
        brush.CompositionBrush().Properties().InsertScalar(L"Blur.BlurAmount", (float)winrt::unbox_value<double>(e.NewValue()));
    }
}

void BackdropBlurBrush::OnConnected()
{
    // Delay creating composition resources until they're required.
    if (!CompositionBrush())
    {
        auto compositor{ Microsoft::UI::Xaml::Media::CompositionTarget::GetCompositorForCurrentThread() };
        auto backdrop{ compositor.CreateBackdropBrush() };

        // Use a Win2D blur affect applied to a CompositionBackdropBrush.
        Microsoft::Graphics::Canvas::Effects::GaussianBlurEffect graphicsEffect{};
        graphicsEffect.Name(L"Blur");
        graphicsEffect.BlurAmount(this->BlurAmount());
        graphicsEffect.Source(Microsoft::UI::Composition::CompositionEffectSourceParameter(L"backdrop"));

        auto effectFactory{ compositor.CreateEffectFactory(graphicsEffect, { L"Blur.BlurAmount" }) };
        auto effectBrush{ effectFactory.CreateBrush() };

        effectBrush.SetSourceParameter(L"backdrop", backdrop);

        CompositionBrush(effectBrush);
    }
}

void BackdropBlurBrush::OnDisconnected()
{
    // Dispose of composition resources when no longer in use.
    if (CompositionBrush())
    {
        CompositionBrush(nullptr);
    }
}
```

```cppcx
// WindowBlurBrush.h:
public ref class BackdropBlurBrush sealed :
    public Microsoft::UI::Xaml::Media::XamlCompositionBrushBase
{
public:
    BackdropBlurBrush();

    static property Microsoft::UI::Xaml::DependencyProperty^ BlurAmountProperty
    {
        Microsoft::UI::Xaml::DependencyProperty^ get() { return m_blurAmountProperty; }
    };

    property double BlurAmount
    {
        double get() 
        {
            return static_cast<double>(GetValue(BlurAmountProperty));
        }
        void set(double value) 
        {
            SetValue(BlurAmountProperty, value);
        }
    };

protected:
    virtual void OnConnected() override;
    virtual void OnDisconnected() override;	
    private:
    static Microsoft::UI::Xaml::DependencyProperty^ m_blurAmountProperty;
    static void OnBlurAmountChanged(Microsoft::UI::Xaml::DependencyObject^ d, Microsoft::UI::Xaml::DependencyPropertyChangedEventArgs^ e);
};

// WindowBlurBrush.cpp:
DependencyProperty^ BackdropBlurBrush::m_blurAmountProperty = DependencyProperty::Register(
    "BlurAmount",
    double::typeid,
    BackdropBlurBrush::typeid,
    ref new PropertyMetadata(0.0, ref new PropertyChangedCallback(OnBlurAmountChanged))
);

BackdropBlurBrush::BackdropBlurBrush()
{
}

void BackdropBlurBrush::OnBlurAmountChanged(DependencyObject^ d, DependencyPropertyChangedEventArgs^ e)
{
    auto brush = static_cast<BackdropBlurBrush^>(d);
    // Unbox and set a new blur amount if the CompositionBrush exists
    if (brush->CompositionBrush != nullptr)
    {
        brush->CompositionBrush->Properties->InsertScalar("Blur.BlurAmount", (float)static_cast<double>(e->NewValue));
    }
}

void BackdropBlurBrush::OnConnected()
{
    // Delay creating composition resources until they're required
    if (CompositionBrush == nullptr)
    {
        auto compositor = Microsoft::UI::Xaml::Media::CompositionTarget::GetCompositorForCurrentThread();
        auto backdrop = compositor->CreateBackdropBrush();
        
        // Use a Win2D blur affect applied to a CompositionBackdropBrush
        auto graphicsEffect = ref new GaussianBlurEffect();
        graphicsEffect->Name = "Blur";
        graphicsEffect->BlurAmount = static_cast<float>(this->BlurAmount);
        graphicsEffect->Source = ref new Microsoft::UI::Composition::CompositionEffectSourceParameter("backdrop");
        
        auto animatableProperties = ref new Platform::Collections::Vector<Platform::String^>();
        animatableProperties->Append("Blur.BlurAmount");

        auto effectFactory = compositor->CreateEffectFactory(graphicsEffect, animatableProperties);
        auto effectBrush = effectFactory->CreateBrush();

        effectBrush->SetSourceParameter("backdrop", backdrop);

        CompositionBrush = effectBrush;
    }
}

void BackdropBlurBrush::OnDisconnected()
{
    // Dispose of composition resources when no longer in use
    if (CompositionBrush != nullptr)
    {
        delete CompositionBrush;
        CompositionBrush = nullptr;
    }
}
```

The above brush can then be used like any other XAML brush type to paint UIElements, for example:

For [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt), also add `#include "BackdropBlurBrush.h"` to `MainPage.h`.

```xaml
<Ellipse Width="100" Height="100">
    <Ellipse.Fill>
        <local:BackdropBlurBrush BlurAmount="10" />
    </Ellipse.Fill>
</Ellipse>
```

## -see-also

[Using XAML brushes](/windows/apps/develop/platform/xaml/brushes), [Using the composition Visual Layer with XAML](/windows/apps/develop/composition/using-the-visual-layer-with-xaml), [Composition brushes](/windows/apps/develop/composition/composition-brushes)
