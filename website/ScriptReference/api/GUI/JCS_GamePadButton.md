# JCS_GamePadButton

Button will listen to the gamepad.


## Variables

<table>
  <tr>
    <td>mIgnorePauseCheck</td>
    <td>Still check input when the game is pause?</td>
  </tr>
  <tr>
    <td>mListenToAnyKey</td>
    <td>Ignore the top two variables, listen to any key on the keyboard/gamepad.</td>
  </tr>
  <tr>
    <td>mKeyActionType</td>
    <td>Key action type.</td>
  </tr>
  <tr>
    <td>mKKeyToListen</td>
    <td>Key to trigger this button.</td>
  </tr>
  <tr>
    <td>mJKeyToListen</td>
    <td>Key to trigger this button.</td>
  </tr>
  <tr>
    <td>mJoystickLitener</td>
    <td>Which joystick should listen?</td>
  </tr>
  <tr>
    <td>mPlayWithGlobalSoundPlayer</td>
    <td>Play with the global sound player.</td>
  </tr>
  <tr>
    <td>mButtonClickSound</td>
    <td>Sound when button is pressed.</td>
  </tr>
  <tr>
    <td>mSoundMethod</td>
    <td>Sound method.</td>
  </tr>
</table>


## Example

ExampleGamePadButton.cs

```cs
  public class ExampleGamePadButton : JCS_GamePadButton {
      public override JCS_OnClickCallback() {
          Debug.Log("Gamepad button click!");
      }
  }
```
