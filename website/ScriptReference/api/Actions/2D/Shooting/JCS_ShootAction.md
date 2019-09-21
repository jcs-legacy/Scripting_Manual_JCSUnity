<!--
   - $File: JCS_ShootAction.html $
   - $Date: 2018-10-01 23:47:47 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_ShootAction</h1>
</div>

<p>
  Action that shoot bullets.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mBullet</td>
    <td>Bullet to use.</td>
  </tr>
  <tr>
    <td>mSpawnPoint</td>
    <td>Spawn point.</td>
  </tr>
  <tr>
    <td>mSpanwPointOffset</td>
    <td>Offset position to spawn point.</td>
  </tr>
  <tr>
    <td>mDefaultHit</td>
    <td>Default hit active to live object.</td>
  </tr>
  <tr>
    <td>mShootCount</td>
    <td>How many bullet everytime active shoot event.</td>
  </tr>
  <tr>
    <td>mShootKeyCode</td>
    <td>Shoot keycode.</td>
  </tr>
  <tr>
    <td>mMouseButton</td>
    <td>Mouse button to shoot.</td>
  </tr>
  <tr>
    <td>mKeyAct</td>
    <td>Key action type.</td>
  </tr>
  <tr>
    <td>mTimeBeforeShoot</td>
    <td>Delay time before shooting a bullet.</td>
  </tr>
  <tr>
    <td>mTimeDelayAfterShoot</td>
    <td>Delay time after shooting a bullet.</td>
  </tr>
  <tr>
    <td>mAutoShoot</td>
    <td>Shoot the bullet depend on the delay time.</td>
  </tr>
  <tr>
    <td>mBulletSpeed</td>
    <td>Speed apply to the bullet</td>
  </tr>
  <tr>
    <td>mDelayTime</td>
    <td>How long it take to shoot a bullet.</td>
  </tr>
  <tr>
    <td>mDeviationEffectX</td>
    <td>Deviate the angle on x-axis.</td>
  </tr>
  <tr>
    <td>mDeviationRangeX</td>
    <td>Deviate range on x-axis.</td>
  </tr>
  <tr>
    <td>mDeviationEffectY</td>
    <td>Deviate the angle on y-axis.</td>
  </tr>
  <tr>
    <td>mDeviationRangeY</td>
    <td>Deviate range on y-axis.</td>
  </tr>
  <tr>
    <td>mDeviationEffectZ</td>
    <td>Deviate the angle on z-axis.</td>
  </tr>
  <tr>
    <td>mDeviationRangeZ</td>
    <td>Deviate range on z-axis.</td>
  </tr>
  <tr>
    <td>mRandPosX</td>
    <td>Spawn bullet at random position on x-axis.</td>
  </tr>
  <tr>
    <td>mRandPosRangeX</td>
    <td>Random position apply on x-axis.</td>
  </tr>
  <tr>
    <td>mRandPosY</td>
    <td>Spawn bullet at random position on y-axis.</td>
  </tr>
  <tr>
    <td>mRandPosRangeY</td>
    <td>Random position apply on y-axis.</td>
  </tr>
  <tr>
    <td>mRandPosZ</td>
    <td>Spawn bullet at random position on z-axis.</td>
  </tr>
  <tr>
    <td>mRandPosRangeZ</td>
    <td>Random position apply on z-axis.</td>
  </tr>
  <tr>
    <td>mRandomMultiSoundAction</td>
    <td>Sound when shoot action occurs.</td>
  </tr>
  <tr>
    <td>mAbilityFormat</td>
    <td>How much damage apply to other objects.</td>
  </tr>
  <tr>
    <td>mTrackSoot</td>
    <td>Will shoot to the target depends on Detect Area Action.</td>
  </tr>
  <tr>
    <td>mDetectAreaAction</td>
    <td>Physical area to detect the
      <a href="?page=Actions_sl_JCS_DetectAreaObject">
        JCS_DetectAreaObject
      </a>. (tag)</td>
  </tr>
  <tr>
    <td>mTrackType</td>
    <td>Track type.</td>
  </tr>
  <tr>
    <td>mPlayer</td>
    <td>Player uses the shoot action.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>Shoot</td>
    <td>Shoot a bullet.</td>
  </tr>
  <tr>
    <td>ShootWithShootCount</td>
    <td>Shoot the bullet with the shoot count.</td>
  </tr>
</table>
