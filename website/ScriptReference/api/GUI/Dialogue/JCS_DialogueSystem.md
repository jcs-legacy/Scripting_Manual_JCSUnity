# JCS_DialogueSystem

Dialogue system core implementation.


## Functions

<table>
  <tr>
    <td>mMakeHoverSelect</td>
    <td>If the mouse hover then select the selection.</td>
  </tr>
  <tr>
    <td>mCenterImage</td>
    <td>Image displayed at the center.</td>
  </tr>
  <tr>
    <td>mLeftImage</td>
    <td>Image displayed at the left.</td>
  </tr>
  <tr>
    <td>mRightImage</td>
    <td>Image displayed at the right.</td>
  </tr>
  <tr>
    <td>mNameTag</td>
    <td>Current name tag.</td>
  </tr>
  <tr>
    <td>mScrollTime</td>
    <td>Speed of scrolling the text.</td>
  </tr>
  <tr>
    <td>mButtonSelectionGroup</td>
    <td>Make control from the gamepad.</td>
  </tr>
  <tr>
    <td>mActiveSound</td>
    <td>Sound plays when active dialogue.</td>
  </tr>
  <tr>
    <td>mDisposeSound</td>
    <td>Sound plays when dispose dialogue.</td>
  </tr>
</table>


## Functions

<table>
  <tr>
    <td>ActiveDialogue</td>
    <td>Start the dialogue, in other word same as start a conversation.</td>
  </tr>
  <tr>
    <td>SendChoice</td>
    <td>Send a choice to current status.</td>
  </tr>
  <tr>
    <td>SendNext</td>
    <td>Next button is the only option for current status.</td>
  </tr>
  <tr>
    <td>SendNextPrev</td>
    <td>Current status will be next and prev control/options.</td>
  </tr>
  <tr>
    <td>SendOk</td>
    <td>Okay button for only option.</td>
  </tr>
  <tr>
    <td>SendYesNo</td>
    <td>Yes/No options for current status.</td>
  </tr>
  <tr>
    <td>SendSimple</td>
    <td>Only exit button will be the only option.</td>
  </tr>
  <tr>
    <td>SendAcceptDecline</td>
    <td>Accept/Decline options.</td>
  </tr>
  <tr>
    <td>SendEmpty</td>
    <td>Send Empty option, expect selections take over it.</td>
  </tr>
  <tr>
    <td>Dispose</td>
    <td>Call this to end the dialogue status.</td>
  </tr>
  <tr>
    <td>ResetStats</td>
    <td>Reset all dialogue system.</td>
  </tr>
  <tr>
    <td>WorldMessage</td>
    <td>Send a world message, online mode only.</td>
  </tr>
  <tr>
    <td>SendNameTag</td>
    <td>Set the current status name tag.</td>
  </tr>
  <tr>
    <td>SendCenterImage</td>
    <td>Set the sprite to the image component. (Center)</td>
  </tr>
  <tr>
    <td>SendLeftImage</td>
    <td>Set the sprite to the image component. (Left)</td>
  </tr>
  <tr>
    <td>SendRightImage</td>
    <td>Set the sprite to the image component. (Right)</td>
  </tr>
  <tr>
    <td>IncPage</td>
    <td>Increament one from page.</td>
  </tr>
  <tr>
    <td>DecPage</td>
    <td>Decreament one from page.</td>
  </tr>
</table>
