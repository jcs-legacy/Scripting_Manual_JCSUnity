# JCS_Button

Button wrapper for more usable functionalities.


## Variables

<table>
  <tr>
    <td>mButtonText</td>
    <td>Text component under the button.</td>
  </tr>
  <tr>
    <td>mButtonSelection</td>
    <td>Button Selection for if the button that are in the group.</td>
  </tr>
  <tr>
    <td>mAutoListener</td>
    <td>Auto add listner to button click event?"</td>
  </tr>
  <tr>
    <td>mDialogueIndex</td>
    <td>Index/ID for record the dialogue instance.</td>
  </tr>
  <tr>
    <td>mInteractable</td>
    <td>Is the button interactable or not.</td>
  </tr>
  <tr>
    <td>mInteractColor</td>
    <td>Color tint when button is interactable.</td>
  </tr>
  <tr>
    <td>mNotInteractColor</td>
    <td>Color tint when button is not interactable.</td>
  </tr>
</table>


## Example

ExampleButton.cs

```cs
  class ExampleButton : JCS_Button {
      public override void JCS_OnClickCallback() {
          Debug.Log("On click!"");
      }
  }
```
