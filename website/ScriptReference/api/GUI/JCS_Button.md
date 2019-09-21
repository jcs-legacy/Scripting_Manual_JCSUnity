<!--
   - $File: JCS_Button.html $
   - $Date: 2018-10-01 18:30:33 $
   - $Revision: $
   - $Creator: Jen-Chieh Shen $
   - $Notice: See LICENSE.txt for modification and distribution information
   -                   Copyright © 2018 by Shen, Jen-Chieh $
-->


<div id="content-header">
  <h1>JCS_Button</h1>
</div>

<p>
  Button wrapper for more usable functionalities.
</p>


<br/>
<h2>Variables</h2>
<br/>

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


<br/>
<h2>Example</h2>
<br/>

<p>ExampleButton.cs</p>
<div class="code-block">
  class ExampleButton : JCS_Button {
      public override void JCS_OnClickCallback() {
          Debug.Log("On click!"");
      }
  }
  
</div>
