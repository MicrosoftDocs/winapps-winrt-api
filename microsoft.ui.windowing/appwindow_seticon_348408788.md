---
-api-id: M:Microsoft.UI.Windowing.AppWindow.SetIcon(System.String)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.SetIcon(System.String)

<!--
public void SetIcon (string iconPath);
-->

## -description

Sets the icon for the window using the specified icon path.

## -parameters

### -param iconPath

The path of the icon.

## -remarks

The `SetIcon(String)` method works only with .ico files.

 You typically call `SetIcon` either from `App.xaml.cs` or from `MainWindow.xaml.cs`.

> [!IMPORTANT]
> When you include the .ico file with your apps assets, you have to set the Build Action to Content in the Visual Studio properties pane.
>
> :::image type="content" source="images/build-action-content.png" alt-text="Visual Studio properties U I for the icon file showing build action set to content.":::

The string you pass to this method is the fully qualified path to the .ico file. There are several ways to get the path to an icon file that's included in your app package.

- Use the `ms-appx` URI scheme to reference your icon file, then call [StorageFile.GetFileFromApplicationUriAsync](/uwp/api/windows.storage.storagefile.getfilefromapplicationuriasync). Pass the file's [Path](/uwp/api/windows.storage.storagefile.path) to `SetIcon`.

Here, the icon is set in `App.xaml.cs`.

```csharp
protected async override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
{
    m_window = new MainWindow();
    await SetIconAsync();
    m_window.Activate();
}

private async Task SetIconAsync()
{
    Uri uri = new Uri("ms-appx:///Assets/MyAppIcon.ico");
    StorageFile? storageFile = null;
    try
    {
        storageFile = await StorageFile.GetFileFromApplicationUriAsync(uri);
    }
    catch (Exception ex)
    {
        // Use default icon.
    }

    if (storageFile is not null)
    {
        m_window?.AppWindow.SetIcon(storageFile.Path);
    }
}
```

The following methods get the path to the app's package. Then you need to combine that path with the local path to the icon file to create the fully qualified path.

- For .NET apps, you can use the [AppContext.BaseDirectory](/dotnet/api/system.appcontext.basedirectory) property.

    ```csharp
    string path = AppContext.BaseDirectory;
    ```

- If your app will only target Windows 10, version 2004 (10.0.19041.0) or later, you can use the [Package.InstalledPath](/uwp/api/windows.applicationmodel.package.installedpath) property.

    ```csharp
    string path = Package.Current.InstalledPath;
    ```

- If your app targets versions of Windows prior to Windows 10, version 2004 (10.0.19041.0), you can use [Package.InstalledLocation](/uwp/api/windows.applicationmodel.package.installedlocation) to get the folder, then use the folder's [Path](/uwp/api/windows.storage.storagefolder.path) property.

    ```csharp
    string path = Package.Current.InstalledLocation.Path;
    ```

After you have the path to the app package, combine it with the path to the icon file. In this example, we use the [Path.Combine](/dotnet/api/system.io.path.combine) method to create the fully qualified path to the icon file.

Here, the icon is set in `MainWindow.xaml.cs`.

```csharp
public MainWindow()
{
    this.InitializeComponent();

    //string path = Package.Current.InstalledLocation.Path;
    // OR
    //string path = Package.Current.InstalledPath;
    // OR
    string path = AppContext.BaseDirectory;
    string iconFileName = "Assets/MyAppIcon.ico";
    string iconPath = Path.Combine(path, iconFileName);
    AppWindow.SetIcon(iconPath);

    // This code can also be condensed like this:
    // AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets\\MyAppIcon.ico"));
}
```

## -see-also

[Title bar customization](/windows/apps/develop/title-bar?tabs=wasdk#icon-and-system-menu), [Reference an asset from XAML markup and code](/windows/apps/windows-app-sdk/mrtcore/images-tailored-for-scale-theme-contrast#reference-an-image-or-other-asset-from-xaml-markup-and-code)

## -examples
