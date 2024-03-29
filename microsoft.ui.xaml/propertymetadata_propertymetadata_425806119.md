---
-api-id: M:Microsoft.UI.Xaml.PropertyMetadata.#ctor(System.Object,Microsoft.UI.Xaml.PropertyChangedCallback)
-api-type: winrt constructor
---

<!-- Method syntax
public PropertyMetadata(System.Object defaultValue, Microsoft.UI.Xaml.PropertyChangedCallback propertyChangedCallback)
-->

# Microsoft.UI.Xaml.PropertyMetadata.PropertyMetadata

## -description

Initializes a new instance of the [PropertyMetadata](propertymetadata.md) class, using a property default value and callback reference.

## -parameters

### -param defaultValue

A default value for the property where this [PropertyMetadata](propertymetadata.md) is applied.

### -param propertyChangedCallback

A reference to the callback to call for property changed behavior.

## -remarks

If you want to establish a [PropertyMetadata](propertymetadata.md) instance that has a property-changed callback method but not a default value, pass `null` for `defaultValue`.

If you pass a value for `defaultValue`, make sure that the type of that value is valid for the `propertyType` type from the dependency property's definition through the [Register](dependencyproperty_register_928563513.md) call. If you've created a type mismatch between registration parameter and metadata, the issue only manifests itself indirectly. You'll get runtime errors when you try to instantiate a type that has this dependency property value, you won't get any design-time or compile-time warning or error.

## -examples

This example shows usage of this constructor. `OnLabelChanged` refers to a delegate implementation for a [PropertyChangedCallback](propertychangedcallback.md) (not shown). To see more code that puts this example in context, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).

``` csharp
public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
  "Label",
  typeof(String),
  typeof(ImageWithLabelControl),
  new PropertyMetadata(null,new PropertyChangedCallback(OnLabelChanged))
);
```

``` cpp
DependencyProperty^ ImageWithLabelControl::_LabelProperty = 
    DependencyProperty::Register("Label", 
    Platform::String::typeid,
    ImageWithLabelControl::typeid, 
    ref new PropertyMetadata(nullptr,
      ref new PropertyChangedCallback(&ImageWithLabelControl::OnLabelChanged))
    );
```

## -see-also

[PropertyMetadata(Object)](propertymetadata_propertymetadata_365528641.md), [DependencyProperty.Register](dependencyproperty_register_928563513.md), [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties)
