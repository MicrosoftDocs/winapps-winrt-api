---
-api-id: M:Microsoft.Windows.AI.Text.TextToTableConverter.ConvertAsync(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextToTableConverter.ConvertAsync(System.String)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.Text.TextToTableResponseResult,string> ConvertAsync (string text);
-->

## -description

Asynchronously formats the text input into a table.

## -parameters

### -param text

The text to format.

## -returns

The formatted text.

## -remarks

Returns a [TextToTableResponseResult](texttotableresponseresult.md) containing the table data. Call [GetRows](texttotableresponseresult_getrows_1751622459.md) on the result to iterate over rows, and [GetColumns](texttotablerow_getcolumns_2060251348.md) on each [TextToTableRow](texttotablerow.md) to access column values.

Check the [Status](texttotableresponseresult_status.md) property to determine whether the conversion completed successfully.

## -see-also

[TextToTableResponseResult](texttotableresponseresult.md), [TextToTableRow](texttotablerow.md)

## -examples
