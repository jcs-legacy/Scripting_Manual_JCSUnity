<!--
   - $File: JCS_2DCamera.html $
   - $Date: 2018-10-01 20:03:16 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_2DCamera</h1>
</div>

<p>
  Basic camera for 2d Games.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mSetToPlayerPositionAtStart</td>
    <td>Set the camera's position to the player when the game starts?</td>
  </tr>
  <tr>
    <td>mTargetTransform</td>
    <td>Target transform information.</td>
  </tr>
  <tr>
    <td>mHardTrack</td>
    <td>Hard track the target's transform?</td>
  </tr>
  <tr>
    <td>mResetVelocityToZeroWhileNotActive</td>
    <td>Set velocity to zero while the follow not active.</td>
  </tr>
  <tr>
    <td>mFreezeInRuntime</td>
    <td>Do freeze in runtime?</td>
  </tr>
  <tr>
    <td>mFreezeX</td>
    <td>Freeze on X axis?</td>
  </tr>
  <tr>
    <td>mFreezeY</td>
    <td>Freeze on Y axis?</td>
  </tr>
  <tr>
    <td>mFreezeZ</td>
    <td>Freeze on Z axis?</td>
  </tr>
  <tr>
    <td>mZoomEffect</td>
    <td>Do the zoom effect?</td>
  </tr>
  <tr>
    <td>mZoomWithMouse</td>
    <td>Zoom with the mouse?</td>
  </tr>
  <tr>
    <td>mScrollRange</td>
    <td>Distance once you scroll."</td>
  </tr>
  <tr>
    <td>mScrollFriction</td>
    <td>How fast it scroll. (Zoom In/Out)</td>
  </tr>
  <tr>
    <td>mFrictionX</td>
    <td>How fast this camera move toward the target. (x-axis)</td>
  </tr>
  <tr>
    <td>mFrictionY</td>
    <td>How fast this camera move toward the target. (y-axis)</td>
  </tr>
  <tr>
    <td>mMax_X_PositionInScene</td>
    <td>Maxinum this camera can go in x-axis.</td>
  </tr>
  <tr>
    <td>mMin_X_PositionInScene</td>
    <td>Mininum this camera can go in x-axis.</td>
  </tr>
  <tr>
    <td>mMax_Y_PositionInScene</td>
    <td>Maxinum this camera can go in y-axis.</td>
  </tr>
  <tr>
    <td>mMin_Y_PositionInScene</td>
    <td>ininum this camera can go in y-axis.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>SetToTargetImmediate</td>
    <td>Set to the target's position in frame.</td>
  </tr>
  <tr>
    <td>ZoomCamera</td>
    <td>Do the zooming on Z axis.</td>
  </tr>
</table>
