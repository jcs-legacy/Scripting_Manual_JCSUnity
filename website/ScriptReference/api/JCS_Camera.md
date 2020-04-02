# JCS_Camera

Camera base class for JCSUnity.

## Variables

<table>
<tr>
<td>mGameDepth</td>
<td>Distance as game origin depth.</td>
</tr>

<tr>
<td>mDisplayGameDepthCamera</td>
<td>Display the camera depth.</td>
</tr>

<tr>
<td>mGameCamColor</td>
<td>The color of the camera depth.</td>
</tr>

<tr>
<td>mFollowing</td>
<td>Flag to check if currently the camera following the target object.</td>
</tr>

<tr>
<td>PositionOffset</td>
<td>Offset the camera position from its' original position.</td>
</tr>

<tr>
<td>SmoothTrack</td>
<td>Flag to check if using smooth track, otherwise hard track.</td>
</tr>
</table>

## Functions

<table>
<tr>
<td>TakeScreenShot</td>
<td>Take a snap shot in the game. (Standalone only)</td>
</tr>

<tr>
<td>CheckInScreenSpace</td>
<td>Check if a gameobject is shown in the screen space.</td>
</tr>

<tr>
<td>WorldToCanvasSpace</td>
<td>Convert world space point to canvas space point.</td>
</tr>

<tr>
<td>CanvasToWorldSpace</td>
<td>Convert canvas space point to world space point.</td>
</tr>

<tr>
<td>SetPosition</td>
<td>Proper way to set camera position.</td>
</tr>
</table>
