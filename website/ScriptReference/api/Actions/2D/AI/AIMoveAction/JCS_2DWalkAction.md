<!--
   - $File: JCS_2DWalkAction.html $
   - $Date: 2018-10-01 23:50:58 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_2DWalkAction</h1>
</div>

<p>
  Action does the AI walk action in 2D.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mWalkSpeed</td>
    <td>Speed of the action.</td>
  </tr>
  <tr>
    <td>mToLeft</td>
    <td>Possibility to walk LEFT way.</td>
  </tr>
  <tr>
    <td>mToRight</td>
    <td>Possibility to walk RIGHT way.</td>
  </tr>
  <tr>
    <td>mToIdle</td>
    <td>Possibility to IDLE.</td>
  </tr>
  <tr>
    <td>mPossibility</td>
    <td>Possiblity to active this action.</td>
  </tr>
  <tr>
    <td>mTimeZone</td>
    <td>Time to do one walk.</td>
  </tr>
  <tr>
    <td>mAdjustTimeZone</td>
    <td>Time that will randomize the Time Zone value.</td>
  </tr>
  <tr>
    <td>mStartRandomWalkSpeed</td>
    <td>Generate a random walk speed at the initilaize time.</td>
  </tr>
  <tr>
    <td>mRandomWalkSpeedRange</td>
    <td>Addition value to the walk speed.</td>
  </tr>
  <tr>
    <td>mMadEffect</td>
    <td>If get mad will start tracking the object that make this object mad.</td>
  </tr>
  <tr>
    <td>mAttackRecorder</td>
    <td>Recorder records the attacker.</td>
  </tr>
  <tr>
    <td>mLiveObjectAnimator</td>
    <td>Live object animation.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>WalkByPossiblity</td>
    <td>Do the walk action depends on possibility.</td>
  </tr
  <tr>
    <td>WalkDirectionPossibility</td>
    <td>
      Recusive function that will find the direction
      and do the walk.
    </td>
  </tr>
  <tr>
    <td>WalkRandomly</td>
    <td>Walk randomly.</td>
  </tr>
  <tr>
    <td>WalkByStatus</td>
    <td>Walk depends on the status.</td>
  </tr>
  <tr>
    <td>Walk</td>
    <td>Do the walk action.</td>
  </tr>
</table>
