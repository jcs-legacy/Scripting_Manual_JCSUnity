# JCS_Camera

Camera base class for JCSUnity.

## Variables

| Name | Description |
|:---|:---|
| mGameDepth | Distance as game origin depth. |
| mDisplayGameDepthCamera | Display the camera depth. |
| mGameCamColor | The color of the camera depth. |
| mFollowing | Flag to check if currently the camera following the target object. |
| PositionOffset | Offset the camera position from its' original position. |
| SmoothTrack | Flag to check if using smooth track, otherwise hard track. |

## Functions

| Name | Description |
|:---|:---|
| TakeScreenShot | Take a snap shot in the game. (Standalone only) |
| CheckInScreenSpace | Check if a gameobject is shown in the screen space. |
| WorldToCanvasSpace | Convert world space point to canvas space point. |
| CanvasToWorldSpace | Convert canvas space point to world space point. |
| SetPosition | Proper way to set camera position. |
