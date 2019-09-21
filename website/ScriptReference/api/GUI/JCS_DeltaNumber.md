<!--
   - $File: JCS_DeltaNumber.html $
   - $Date: 2018-10-01 19:31:52 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_DeltaNumber</h1>
</div>

<p>
  System that control 0-9 number sprites and create a counter effect.
</p>


<br/>
<h2>Variables</h2>
<br/>

<table>
  <tr>
    <td>mCurrentScore</td>
    <td>Current score rendering.</td>
  </tr>
  <tr>
    <td>mScoreNull</td>
    <td><Default null slot./td>
  </tr>
  <tr>
    <td>mScoreText0</td>
    <td>Score text 0.</td>
  </tr>
  <tr>
    <td>mScoreText1</td>
    <td>Score text 1.</td>
  </tr>
  <tr>
    <td>mScoreText2</td>
    <td>Score text 2.</td>
  </tr>
  <tr>
    <td>mScoreText3</td>
    <td>Score text 3.</td>
  </tr>
  <tr>
    <td>mScoreText4</td>
    <td>Score text 4.</td>
  </tr>
  <tr>
    <td>mScoreText5</td>
    <td>Score text 5.</td>
  </tr>
  <tr>
    <td>mScoreText6</td>
    <td>Score text 6.</td>
  </tr>
  <tr>
    <td>mScoreText7</td>
    <td>Score text 7.</td>
  </tr>
  <tr>
    <td>mScoreText</td>
    <td>Score text 8.</td>
  </tr>
  <tr>
    <td>mScoreText9</td>
    <td>Score text 9.</td>
  </tr>
  <tr>
    <td>mDigitsRendererSlot</td>
    <td>Each digit, the more length the more digit.</td>
  </tr>
  <tr>
    <td>mDigitInterval</td>
    <td>Interval between each digit.</td>
  </tr>
  <tr>
    <td>mClearEmptyLeftZero</td>
    <td>Clear all the empty zero from the left.</td>
  </tr>
  <tr>
    <td>mVisibleOnZero</td>
    <td>Is visible when is zero?</td>
  </tr>
  <tr>
    <td>mTextAlign</td>
    <td>Align side.</td>
  </tr>
  <tr>
    <td>mMaxScore</td>
    <td>Maxinum score.</td>
  </tr>
  <tr>
    <td>mMinScore</td>
    <td>Mininum score.</td>
  </tr>
  <tr>
    <td>mDeltaToCurrentScore</td>
    <td>Show each digit between the score animation.</td>
  </tr>
  <tr>
    <td>mTargetScore</td>
    <td>Current targeting score.</td>
  </tr>
  <tr>
    <td>mAnimScoreTime</td>
    <td>How fast the score animate.</td>
  </tr>
  <tr>
    <td>mDeltaProduct</td>
    <td>How much the delta value add up.</td>
  </tr>
</table>


<br/>
<h2>Functions</h2>
<br/>

<table>
  <tr>
    <td>EnableDigitsRendererSlot</td>
    <td>Set enable/disable all digit render slot.</td>
  </tr>
  <tr>
    <td>UpdateScore</td>
    <td>Update the score GUI.</td>
  </tr>
  <tr>
    <td>UpdateIntervalForEachDigit</td>
    <td>Update the space to each digit.</td>
  </tr>
</table>
