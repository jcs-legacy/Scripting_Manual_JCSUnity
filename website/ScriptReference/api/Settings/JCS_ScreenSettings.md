# JCS_ScreenSettings

Screen related settings.

## Variables

| Name                                    | Description                                                                      |
|:----------------------------------------|:---------------------------------------------------------------------------------|
| onScreenResize                          | Callback execute when the screen resized.                                        |
| RESIZE_TO_ASPECT_WHEN_APP_STARTS        | Resize the screen/window to certain aspect when the application starts.          |
| RESIZE_TO_STANDARD_WHEN_APP_STARTS      | Resize the screen/window to standard resoltuion when application starts.         |
| RESIZE_TO_ASPECT_EVERYTIME_SCENE_LOADED | Resize the screen/window everytime a scene are loaded.                           |
| RESIZE_TO_SMALLER_EDGE                  | When resize, resize to the smaller edge, if not true will resize to larger edge. |
| mResizablePanelsColor                   | Defualt color to aspect panels.                                                  |
| STANDARD_SCREEN_WIDTH                   | Standard screen width to calculate the worldspace obejct's camera view.          |
| STANDARD_SCREEN_HEIGHT                  | Standard screen height to calculate the worldspace obejct's camera view.         |

## Functions

| Name                    | Description                                                                      |
|:------------------------|:---------------------------------------------------------------------------------|
| BlackspaceWidth         | Return width of the blackspace on the screen, if any after resizing the screen.  |
| BlackspaceHeight        | Return height of the blackspace on the screen, if any after resizing the screen. |
| VisibleScreenWidth      | Get the visible of the screen width.                                             |
| VisibleScreenHeight     | Get the size of the screen height.                                               |
| ForceAspectScreenOnce   | Make the screen in certain aspect ratio.                                         |
| ForceStandardScreenOnce | Resize the screen resolution to standard resolution once.                        |
