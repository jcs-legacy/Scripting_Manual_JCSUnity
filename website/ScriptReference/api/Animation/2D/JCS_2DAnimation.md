# JCS_2DAnimation

Handle frame by frame animation in the simple way.

## Variables

<table>
<tr>
<td>donePlayingAnimCallback</td>
<td>Callback when done playing animation.</td>
</tr>

<tr>
<td>playFrameCallback</td>
<td>Callback when play the frame.</td>
</tr>

<tr>
<td>mStartingFrame</td>
<td>Starting frame index.</td>
</tr>

<tr>
<td>Active</td>
<td>Current animaion playing?</td>
</tr>

<tr>
<td>PlayOnAwake</td>
<td>Play the animation on awake time?</td>
</tr>

<tr>
<td>Loop</td>
<td>Does the animation loop?</td>
</tr>

<tr>
<td>NullSprite</td>
<td>Sprite displayed when the animation stopped.</td>
</tr>

<tr>
<td>NullSpriteAfterDonePlayingAnim</td>
<td>Set the sprite to null after done playing the animation.</td>
</tr>

<tr>
<td>FramePerSec</td>
<td>FPS for the animation to play.</td>
</tr>

<tr>
<td>mAnimFrames</td>
<td>Drag all the frame here, in order.</td>
</tr>

<tr>
<td>AnimationTimeProduction</td>
<td>How fast the animation plays.</td>
</tr>
</table>

## Functions

<table>
<tr>
<td>UpdateMaxFrame</td>
<td>Update the maxinum frame count from the animation frame sequence.</td>
</tr>

<tr>
<td>Play</td>
<td>Play the animation in current frame.</td>
</tr>

<tr>
<td>Pause</td>
<td>Pause the animation by frame?</td>
</tr>

<tr>
<td>Stop</td>
<td>Stop the animation, and set the sprite to null.</td>
</tr>

<tr>
<td>Replay</td>
<td>Play animation from the start of the frame.</td>
</tr>

<tr>
<td>PlayFrame</td>
<td>Set the current playing frame by index.</td>
</tr>

<tr>
<td>PlayNullFrame</td>
<td>Play the animation as null frame.</td>
</tr>
</table>
