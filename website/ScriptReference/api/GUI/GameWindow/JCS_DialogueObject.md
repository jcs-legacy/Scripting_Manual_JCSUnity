# JCS_DialogueObject

Base class of Game Window.


## Variables

<table>
  <tr>
    <td>mDialogueIndex</td>
    <td>Unique index to open the dialogue.</td>
  </tr>
  <tr>
    <td>mKeyCode</td>
    <td>Key to open this dialogue.</td>
  </tr>
  <tr>
    <td>mDialogueType</td>
    <td>Dialogue type for priority.</td>
  </tr>
  <tr>
    <td>mPanelType</td>
    <td>Type for positioning the panel every time it opens.</td>
  </tr>
  <tr>
    <td>mOpenWindowClip</td>
    <td>Sound when open this dialouge window.</td>
  </tr>
  <tr>
    <td>mCloseWindowClip</td>
    <td>Sound when close this dialouge window.</td>
  </tr>
</table>


## Functions

<table>
  <tr>
    <td>DoPanelType</td>
    <td>Decide what panel is this panel going to be.</td>
  </tr>
  <tr>
    <td>DestroyDialogue</td>
    <td>Destroy this dialgoue.</td>
  </tr>
  <tr>
    <td>ShowDialogueWithoutSound</td>
    <td>Show the dialogue in the game without the sound.</td>
  </tr>
  <tr>
    <td>HideDialogueWithoutSound</td>
    <td>Hide the dialogue without the sound.</td>
  </tr>
  <tr>
    <td>MoveToTheLastChild</td>
    <td>
      Move the last child of the current child will make the panel in front
      of any other GUI in the current panel.
    </td>
  </tr>
  <tr>
    <td>ToggleVisibility</td>
    <td>Toggle this dialgoue show and hide.</td>
  </tr>
</table>
