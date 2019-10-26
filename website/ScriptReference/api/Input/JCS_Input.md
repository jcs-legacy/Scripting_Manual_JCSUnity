# JCS_Input

Rewrap Input from Unity Engine and add more functionalities.


## Functions

<table>
  <tr>
    <td>OnMouseDoubleClick</td>
    <td>Check if the user double clicking?</td>
  </tr>
  <tr>
    <td>OnMouseDrag</td>
    <td>s the mouse dragging right now?</td>
  </tr>
  <tr>
    <td>MouseDeltaPosition</td>
    <td>Return mouse delta position between frame to frame.</td>
  </tr>
  <tr>
    <td>CanvasMousePosition</td>
    <td>Get the mouse position on canvas space.</td>
  </tr>
  <tr>
    <td>MousePositionOnGUILayer</td>
    <td>Returns the mouse position on GUI layer.</td>
  </tr>
  <tr>
    <td>MousePosition0To1</td>
    <td>Return mouse position between 0 to 1.</td>
  </tr>
  <tr>
    <td>GetMouseByAction</td>
    <td>Get the mouse state by passing it the action.</td>
  </tr>
  <tr>
    <td>GetMouseButtonDown</td>
    <td>Check if the mouse button is down.</td>
  </tr>
  <tr>
    <td>GetMouseButton</td>
    <td>Check if the mouse button is pressed.</td>
  </tr>
  <tr>
    <td>GetMouseButtonUp</td>
    <td>Check if the mouse button is up.</td>
  </tr>
  <tr>
    <td>GetKeyByAction</td>
    <td>Check if the key is down by key action type.</td>
  </tr>
  <tr>
    <td>GetKeyDown</td>
    <td>Is the key down?</td>
  </tr>
  <tr>
    <td>GetKey</td>
    <td>Is the key held down?</td>
  </tr>
  <tr>
    <td>GetKeyUp</td>
    <td>Is the key up?</td>
  </tr>
  <tr>
    <td>GetButtonByAction</td>
    <td> Get the boolean check depends on the button status.</td>
  </tr>
  <tr>
    <td>GetButton</td>
    <td>Is the button pressed?</td>
  </tr>
  <tr>
    <td>GetButtonDown</td>
    <td>Is the button down?</td>
  </tr>
  <tr>
    <td>GetButtonUp</td>
    <td>Is the button up?</td>
  </tr>
  <tr>
    <td>GetAnyKeyByAction</td>
    <td>Check if any key is down/up/pressed.</td>
  </tr>
  <tr>
    <td>IsAnyKeyBuffer</td>
    <td>Check if any key is sent the input signal.</td>
  </tr>
  <tr>
    <td>GetAnyKeyDown</td>
    <td>Check if any key is down.</td>
  </tr>
  <tr>
    <td>GetAnyKey</td>
    <td>Check if any key is pressed.</td>
  </tr>
  <tr>
    <td>GetAnyKeyUp</td>
    <td>Check if any key is up.</td>
  </tr>
  <tr>
    <td>GetAxis</td>
    <td>Return the joystick buffer.</td>
  </tr>
  <tr>
    <td>GetJoystickButton</td>
    <td>Check if the button have pressed.</td>
  </tr>
  <tr>
    <td>GetJoystickKey</td>
    <td>Check if joystick id, pressed the key?</td>
  </tr>
  <tr>
    <td>GetJoystickKeyUp</td>
    <td>Check if joystick id, up the key?</td>
  </tr>
  <tr>
    <td>GetJoystickKeyDown</td>
    <td>Check if joystick id, down the key?</td>
  </tr>
  <tr>
    <td>GetJoystickKeyByAction</td>
    <td>Check if the joystick key is doing something by these certain events.</td>
  </tr>
  <tr>
    <td>IsJoystickConnected</td>
    <td>Check if there is joy stick connect to the pc.</td>
  </tr>
  <tr>
    <td>OneKeys</td>
    <td>Check either of these key are preseed.</td>
  </tr>
  <tr>
    <td>OneKeysDown</td>
    <td>Check either of these key are down.</td>
  </tr>
  <tr>
    <td>OneKeysUp</td>
    <td>Check either of these key are up.</td>
  </tr>
  <tr>
    <td>AllKeys</td>
    <td>Check all of these key are preseed.</td>
  </tr>
  <tr>
    <td>AllKeysDown</td>
    <td>Check all of these key are down.</td>
  </tr>
  <tr>
    <td>AllKeysUp</td>
    <td>Check all of these key are up.</td>
  </tr>
  <tr>
    <td>OneJoystickButtons</td>
    <td>Check either of these key are preseed.</td>
  </tr>
  <tr>
    <td>OneJoystickKeysDown</td>
    <td>Check either of these key are down.</td>
  </tr>
  <tr>
    <td>OneJoystickKeysUp</td>
    <td>Check either of these key are up.</td>
  </tr>
  <tr>
    <td>AllJoystickButtons</td>
    <td>Check all of these key are preseed.</td>
  </tr>
  <tr>
    <td>AllJoystickKeysDown</td>
    <td>Check all of these key are down.</td>
  </tr>
  <tr>
    <td>AllJoystickKeysUp</td>
    <td>Check all of these key are up.</td>
  </tr>
  <tr>
    <td>OneCtrlKey</td>
    <td>Is one the ctrl key pressed?</td>
  </tr>
  <tr>
    <td>OneCtrlKeyDown</td>
    <td>Is one the ctrl key down?</td>
  </tr>
  <tr>
    <td>OneCtrlKeyUp</td>
    <td>Is one the ctrl key up?</td>
  </tr>
  <tr>
    <td>GetKeyWithCtrl</td>
    <td>Is key pressed with the control key?</td>
  </tr>
  <tr>
    <td>GetKeyDownWithCtrl</td>
    <td>Is key down with the control key?</td>
  </tr>
  <tr>
    <td>GetKeyUpWithCtrl</td>
    <td>Is key up with the control key?</td>
  </tr>
  <tr>
    <td>OneAltKey</td>
    <td>Is one the alt key pressed?</td>
  </tr>
  <tr>
    <td>OneAltKeyDown</td>
    <td>Is one the alt key down?</td>
  </tr>
  <tr>
    <td>OneAltKeyUp</td>
    <td>Is one the alt key up?</td>
  </tr>
  <tr>
    <td>GetKeyWithAlt</td>
    <td>Is key pressed with the alt key?</td>
  </tr>
  <tr>
    <td>GetKeyDownWithAlt</td>
    <td>Is key down with the alt key?</td>
  </tr>
  <tr>
    <td>GetKeyUpWithAlt</td>
    <td>Is key up with the alt key?</td>
  </tr>
  <tr>
    <td>OneShiftKey</td>
    <td>Is one the shift key pressed?</td>
  </tr>
  <tr>
    <td>OneShiftKeyDown</td>
    <td>Is one the shift key down?</td>
  </tr>
  <tr>
    <td>OneShiftKeyUp</td>
    <td>Is one the shift key up?</td>
  </tr>
  <tr>
    <td>GetKeyWithShift</td>
    <td>Is key pressed with the shift key?</td>
  </tr>
  <tr>
    <td>GetKeyDownWithShift</td>
    <td>Is key down with the shift key?</td>
  </tr>
  <tr>
    <td>GetKeyUpWithShift</td>
    <td>Is key up with the shift key?</td>
  </tr>
  <tr>
    <td>GetKeyWithCtrlShift</td>
    <td>Check if the 'key' and the ctrl and shift key is pressed.</td>
  </tr>
  <tr>
    <td>GetKeyDownWithCtrlShift</td>
    <td>Check if the 'key' and the ctrl and shift key is down.</td>
  </tr>
  <tr>
    <td>GetKeyUpWithCtrlShift</td>
    <td>Check if the 'key' and the ctrl and shift key is up.</td>
  </tr>
  <tr>
    <td>GetKeyWithAltCtrl</td>
    <td>Check if the 'key' and the ctrl and alt key is pressed.</td>
  </tr>
  <tr>
    <td>GetKeyDownWithAltCtrl</td>
    <td>Check if the 'key' and the ctrl and alt key is down.</td>
  </tr>
  <tr>
    <td>GetKeyUpWithAltCtrl</td>
    <td>Check if the 'key' and the ctrl and alt key is up.</td>
  </tr>
  <tr>
    <td>GetKeyWithAltShift</td>
    <td>Check if the 'key' and the alt and shift key is pressed.</td>
  </tr>
  <tr>
    <td>GetKeyDownWithAltShift</td>
    <td>Check if the 'key' and the alt and shift key is down.</td>
  </tr>
  <tr>
    <td>GetKeyUpWithAltShift</td>
    <td>Check if the 'key' and the alt and shift key is up.</td>
  </tr>
  <tr>
    <td>GetKeyWithAltCtrlShift</td>
    <td>Check if the 'key', alt, shift and ctrl key is pressed.</td>
  </tr>
  <tr>
    <td>GetKeyDownWithAltCtrlShift</td>
    <td>Check if the 'key', alt, shift and ctrl key is down.</td>
  </tr>
  <tr>
    <td>GetKeyUpWithAltCtrlShift</td>
    <td>Check if the 'key', alt, shift and ctrl key is up.</td>
  </tr>
  <tr>
    <td>GetKeyWith</td>
    <td>Get key with certain combination.</td>
  </tr>
  <tr>
    <td>GetKeyDownWith</td>
    <td>Get key down with certain combination.</td>
  </tr>
  <tr>
    <td>GetKeyUpWith</td>
    <td>Get key up with certain combination.</td>
  </tr>
</table>
