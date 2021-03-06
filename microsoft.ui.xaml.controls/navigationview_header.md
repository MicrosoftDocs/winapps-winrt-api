---
-api-id: P:Microsoft.UI.Xaml.Controls.NavigationView.Header
-api-type: winrt property
---
<!-- Property syntax.
public object Header { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.NavigationView.Header


## -description

Gets or sets the header content.


## -property-value

The header content for the NavigationView.


## -remarks


## -see-also


## -examples


## -xaml-syntax

```xaml
<NavigationView Header="headerString"/>
```

```xaml
<NavigationView>
  <NavigationView.Header>
    headerObject
  </NavigationView.Header>
</NavigationView>
```


## -xaml-values

<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>


