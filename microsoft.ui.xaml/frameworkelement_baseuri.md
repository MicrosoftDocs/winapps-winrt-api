---
-api-id: P:Microsoft.UI.Xaml.FrameworkElement.BaseUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri BaseUri { get; }
-->

# Microsoft.UI.Xaml.FrameworkElement.BaseUri

## -description

Gets a Uniform Resource Identifier (URI) that represents the base URI for an XAML-constructed object at XAML load time. This property is useful for URI resolution at run time.

## -property-value

The base Uniform Resource Identifier (URI) for an object at XAML load time.

## -remarks

The XAML parser can evaluate references to resources based on the context of the object in a page, and can thus evaluate what appear to be partial paths in a Uniform Resource Identifier (URI) property. For run-time code, the definition rules for the Uniform Resource Identifier (URI) types don't permit partial paths. At run time, you can use BaseUri from the scope of an object that was created by parsing a XAML page in order to get the "path" part of a URI, and then complete the URI with a particular resource reference.

## -examples

This example uses BaseUri in an event handler that resets an image source to a backup/default. BaseUri is used for the "path" part of a new Uniform Resource Identifier (URI) that is used for a [BitmapImage](../microsoft.ui.xaml.media.imaging/bitmapimage.md) constructor call, the rest of the URI points to an image file that the app has in its resources. To see this code in the context of a UWP app, see the [CameraCaptureUI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/CameraCaptureUI%20Sample).

[!code-cpp[FEBaseUri](../microsoft.ui.xaml/code/BaseElementEvents/cpp/PageWithAppBar.xaml.cpp#SnippetFEBaseUri)]

[!code-csharp[FEBaseUri](../microsoft.ui.xaml/code/BaseElementEvents/csharp/PageWithAppBar.xaml.cs#SnippetFEBaseUri)]

[!code-vb[FEBaseUri](../microsoft.ui.xaml/code/BaseElementEvents/vbnet/PageWithAppBar.xaml.vb#SnippetFEBaseUri)]

## -see-also
