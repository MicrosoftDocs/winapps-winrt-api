---
-api-id: P:Microsoft.UI.Xaml.Controls.MapControl.MapServiceToken
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.MapControl.MapServiceToken

<!--
public string MapServiceToken { get; set; }
-->

## -description

Gets or sets the authentication key required for using the MapControl and online mapping services.

## -property-value

The authentication key required for using the MapControl and online mapping services. The default is an empty string.

## -remarks

See [Manage your Azure Maps account](/azure/azure-maps/how-to-manage-account-keys) for information about how to obtain a shared key for authentication.

An invalid token will prevent authentication with Azure Maps service. The MapControl will raise a map service error and show only a blue background.

## -see-also

## -examples


