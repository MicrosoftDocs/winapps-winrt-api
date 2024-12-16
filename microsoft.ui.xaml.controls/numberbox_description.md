---
-api-id: P:Microsoft.UI.Xaml.Controls.NumberBox.Description
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NumberBox.Description

<!--
public object Description { get; set; }
-->

## -description

Gets or sets content that is shown below the control. The content should provide guidance about the input expected by the control.

## -property-value

Content that is shown below the control. The default is `null`.

## -remarks

The [IsWrapEnabled](numberbox_iswrapenabled.md) property affects only the [Header](numberbox_header.md) text; it doesn't cause `Description` text to wrap.

If you need to wrap `Description` text, you can use a [TextBlock](textblock.md) as the `Description` property value and set it to wrap, like this.

```xaml
<NumberBox Header="Header" Width="160">
    <NumberBox.Description>
        <TextBlock Text="This is a long description for NumberBox."
                   TextWrapping="WrapWholeWords"/>
    </NumberBox.Description>
</NumberBox>
```

## -see-also

[Number box](/windows/apps/design/controls/number-box)

## -examples
