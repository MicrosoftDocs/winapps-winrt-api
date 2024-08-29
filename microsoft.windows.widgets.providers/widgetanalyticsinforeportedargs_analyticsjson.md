---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetAnalyticsInfoReportedArgs.AnalyticsJson
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetAnalyticsInfoReportedArgs.AnalyticsJson

<!--
public string AnalyticsJson { get; }
-->


## -description

Gets a JSON string describing the user interaction that triggered the analytics event.

## -property-value

A JSON string.

## -remarks

The JSON string returned by this property uses the following format:

```json
{
 "host": "dashboard.microsoft.com",
 "version": "1.0",
 "eventKind": "interaction",
 "interactionKind": "titleLink",
 "url": "https://www.contoso.com"
}
```

Telemetry data is provided for three kinds of events, user interaction, exit customization, and visibility events. The following sections provide detailed information about the format of the JSON telemetry data format for each type of event.

### EventKind - Interaction

The interaction events occur when an user interacts with a widget or its container. When telemetry data is triggered by this type of event, the value of *eventKind* is "interaction".

#### TitleBar

This event is raised when an user has clicked on the title bar of the widget, the event is triggered by a simple click on the title bar or by dragging a widget to a new position in the host app.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "interaction"|
| interactionKind | "titleBar"|

Example JSON payload for a TitleBar event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "titleBar"
}
```

#### ContextMenu

This event is raised when an user clicks on one of the actions under the ellipsis "..." button of the frame of a widget.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info. |
| version | Version of the JSON payload schema.|
| eventKind	 | interaction"|
| interactionKind | "contextMenu"|
| clickedItem | Name of the menu item clicked, for example: "customize", "unpin", "attribution", "feedback", "additionalInfo"|

Example JSON payload for a ContextMenu event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "contextMenu",
    "clickedItem": "feedback"
}
```


#### Hyperlink

This event is raised when a user clicks on a hyperlink in a Widget, for example, when clicking on a markdown link in a **TextBlock**. Url navigation is handled by the Widget Host, providers are not expected to navigate the hyperlink.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "interaction"|
| interactionKind | "hyperlink"|
| url | Link destination.|

Example JSON payload for a Hyperlink event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "hyperlink",
    "url": "https://www.contoso.com"
}
```

#### AdditionalInfoUri

This event is raised when an user launches the AdditionalInfoUri for a Widget, for example, when the user clicks on the widget title in the Dashboard that results in external navigation.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "interaction"|
| interactionKind | "additionalInfoUri"|
| uri | Uri registered for navigation when the user launches the AdditionalInfoUri for a Widget. For example, when clicking on the Widget's title in the Dashboard. |

Example JSON payload for a AdditionalInfoUri event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "additionalInfoUri",
    "uri": "https://www.contoso.com"
}


#### Action.OpenUrl

This event is raised when a user clicks on an [Action.OpenUrl](https://adaptivecards.io/explorer/Action.OpenUrl.html) action.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "interaction"|
| interactionKind | "action.openUrl"|
| actionId | Id of the AdaptiveCard action clicked.|
| actionTitle | Title of the AdaptiveCard action clicked.|
| Url | Value set in the Action.OpenUrl url property.|

Example JSON payload for a *Action.OpenUrl* event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "action.openUrl",
    "actionId": "ContosoAction",
    "actionTitle": "Go to home screen",
    "url": "https://www.contoso.com"
}
```

#### Action.ToggleVisibilty

This event is raised when a user clicks on an [Action.ToggleVisibility](https://adaptivecards.io/explorer/Action.ToggleVisibility.html) action.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "interaction"|
| interactionKind | "action.toggleVisibility"|
| actionId | Id of the AdaptiveCard action clicked.|
| actionTitle | Title of the AdaptiveCard action clicked.|
| elementIds | List of elements targeted by the Action.ToggleVisibility as defined in the targetElements property.|

Example JSON payload for an *Action.ToggleVisibilty* event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "action.toggleVisibility",
    "actionId": "ToggleAction",
    "actionTitle": "Show meat options",
    "elementIds": ["ImageChicken", "ImageSteak"]
}
```

> [!NOTE]
> Due to limitations in the AdaptiveCards library, the *elementIds* value may not contain the complete information. For example, elements under an invisible container will not become visible unless the container does.

#### Action.ShowCard

This event is raised when a user clicks on an [Action.ShowCard](https://adaptivecards.io/explorer/Action.ShowCard.html) action.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "interaction"|
| interactionKind | "action.showCard"|
| actionId | Id of the AdaptiveCard action clicked.|
| actionTitle | Title of the AdaptiveCard action clicked.|

Example JSON payload for an *Action.ShowCard* event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "action.showCard",
    "actionId": "ShowAnotherCardAction",
    "actionTitle": "See more details"
}
```

#### Carousel

This event is raised when an user interacts with a carousel element, for example, when clicking on a specific page in the carousel or when navigating it with the left and right arrows.

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.
| version | Version of the JSON payload schema.
| eventKind | "interaction"
| interactionKind | "carousel"
| activePageId | AdaptiveCards Carousel page Id.
| activePageIndex | Index of the currently active page.
| carouselId | Id of the AdaptiveCards Carousel.
| carouselEventName | String, one of the following: "navigationNext", "navigationPrevious", "pagination" or "autoplay"
| carouselEventKind | Numerical value that is mapped to one of the carousel event names. The values map as follows: navigationNext - 0, navigationPrevious - 1, pagination - 2, autoplay - 3 |


Example JSON payload for a Carousel event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "carousel",
    "activePageId": "MainPage",
    "activePageIndex": 0,
    "carouselId": "FeaturesCarousel",
    "carouselEventName": "navigationPrevious",
    "carouselEventKind": 1
}
```



### EventKind - exitCustomization

The *exitCustomization* event occurs when the user has entered customization mode by clicking the "Customize" menu item from widget frame context menu and the user leaves customization mode. When telemetry data is triggered by this type of event, the value of *eventKind* is "exitCustomization".

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "interaction"|
| interactionKind | "exitCustomization"|

Example JSON payload for a *existCustomization* event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "interaction",
    "interactionKind": "exitCustomization"
}
```

### EventKind - Visibility

The visibility events occur when the widget is moved into or out of the visible viewport. Visibility events are tied to the physical impression and may differ from the [IWidgetProvider](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.iwidgetprovider) interface [Activate](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.iwidgetprovider.activate) and [Deactivate](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers.iwidgetprovider.deactivate) APIs which Hosts may trigger at any time. When telemetry data is triggered by this type of event, the value of *eventKind* is "visibility".

| Property | Value |
|----------|-------|
| host | String that identifies the host sending the error info.|
| version | Version of the JSON payload schema.|
| eventKind | "visibility"|
| visibilityKind | "visible" or "hidden"|

Example JSON payload for a *existCustomization* event.

```json
{
    "host": "dashboard.microsoft.com",
    "version": "1.0",
    "eventKind": "visibility",
    "visibilityKind": "visible"
}
```

## -see-also

## -examples


