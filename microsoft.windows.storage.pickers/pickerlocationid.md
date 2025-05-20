---
-api-id: T:Microsoft.Windows.Storage.Pickers.PickerLocationId
-api-type: winrt enum
---

# Microsoft.Windows.Storage.Pickers.PickerLocationId

<!--
public enum PickerLocationId
-->

## -description

Specifies the default folder or library that a picker starts from or displays to the user.

## -enum-fields

### -field DocumentsLibrary: 0

The user's Documents library.

This is the default location where many applications save documents, and it is often mapped to the `%USERPROFILE%\Documents` folder on the user's system. If the user has configured OneDrive for documents, this location would be redirected to a OneDrive folder, such as `%USERPROFILE%\OneDrive - ...\Documents`.

### -field ComputerFolder: 1

The value represents the "This PC" directory.

This location provides access to all drives and devices connected to the user's computer, including internal and external storage devices.

### -field Desktop: 2

This value represents the user's Desktop.

This is the location where users often save shortcuts, files, and folders for quick access. It is often mapped to `%USERPROFILE%\Desktop`.

### -field Downloads: 3

This value represents the user's Downloads folder.

This is the default location where web browsers and other applications save downloaded files. It is often mapped to `%USERPROFILE%\Downloads`.

### -field HomeGroup: 4

This value represents the user's HomeGroup folder.

This enum value is retained now for backward compatibility with the [Windows.Storage.Pickers.PickerLocationId](/uwp/api/windows.storage.pickers.pickerlocationid). It may be removed in future SDK releases.

> [!NOTE]
> HomeGroup has been removed from Windows 10 (version 1803) and later, so it's recommended to avoid use this value.

### -field MusicLibrary: 5

This value represents the user's Music library.

This is the default location where many applications save music files, and it's often mapped to `%USERPROFILE%\Music`. If the user has configured OneDrive for the music library, this location would be redirected to a OneDrive folder, such as `%USERPROFILE%\OneDrive - ...\Music`.

### -field PicturesLibrary: 6

This value represents the user's Pictures library.

This is the default location where many applications save image files, and it's often mapped to `%USERPROFILE%\Pictures`. If the user has configured OneDrive for the pictures library, this location would be redirected to a OneDrive folder, such as `%USERPROFILE%\OneDrive - ...\Pictures`.

### -field VideosLibrary: 7

This value represents the user's Videos library.

This is the default location where many applications save video files, and it's often mapped to `%USERPROFILE%\Videos`. If the user has configured OneDrive for the videos library, this location would be redirected to a OneDrive folder, such as `%USERPROFILE%\OneDrive - ...\Videos`.

### -field Objects3D: 8

This value represents the 3D Objects folder. This is the default location where many applications save 3D object files, and it's often mapped to `%USERPROFILE%\3D Objects`.

This enum value is retained for backward compatibility with the [Windows.Storage.Pickers.PickerLocationId](/uwp/api/windows.storage.pickers.pickerlocationid). It may be removed in future SDK releases.

> [!NOTE]
> This location is being phased out, so it's recommended to avoid using this value.

### -field Unspecified: 9

This value represents an unspecified location.

When this value is used, the file picker will use the system default location, which may vary depending on the user's configuration and the context in which the picker is used.

When the [SuggestedStartLocation](fileopenpicker_suggestedstartlocation.md) was not specified in [FileOpenPicker](fileopenpicker.md), [FileSavePicker](filesavepicker.md), or [FolderPicker](folderpicker.md), the default value is **PickerLocationId.Unspecified**.

## -remarks

## -see-also

## -examples
