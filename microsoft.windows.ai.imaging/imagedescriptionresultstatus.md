---
-api-id: T:Microsoft.Windows.AI.Imaging.ImageDescriptionResultStatus
-api-type: winrt enum
---

# Microsoft.Windows.AI.Imaging.ImageDescriptionResultStatus

<!--
public enum ImageDescriptionResultStatus
-->

## -description

Specifies the states supported when generating image descriptions.

## -enum-fields

### -field Complete: 0

Description generated.

### -field InProgress: 1

Description generation in progress.

### -field BlockedByPolicy: 2

Description generation is blocked by system policy or user permissions.

### -field ImageBlockedByContentModeration: 3

Description generation blocked by content moderation of source image.

### -field TextInImageBlockedByContentModeration: 4

Description generation blocked by content moderation of text in source image.

### -field DescriptionTextBlockedByContentModeration: 5

Description generation blocked by content moderation of image description.

### -field ImageHasTooMuchText: 6

Description generation compromised by image with too much text.

### -field InternalError: 7

Description generation failed due to internal error.

## -remarks

## -see-also

[ImageDescriptionResult.Status](imagedescriptionresult_status.md), [Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
